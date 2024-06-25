using System.ComponentModel;

namespace Lab3.Classes
{
    internal class Cryptography
    {
        public static string Encrypt(string filePath, string key, BackgroundWorker sender)
        {
            var startTimer = DateTime.Now;
            var data = File.ReadAllBytes(filePath);

            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key[i % key.Length]);
                if (i % (data.Length / 100) == 0 && sender != null)
                    sender.ReportProgress((int)(i / (data.Length / 100)));
            }

            var endTimer = DateTime.Now;
            var time = endTimer - startTimer;
            var resultPath = Path.GetFileName(filePath) + "_encrypted.encr";
            
            using (var fileStream = new FileStream(resultPath, FileMode.Create))
            {
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(result);
                }
            }

            return "File encrypted and saved as " + resultPath + "\nTime: " + time.ToString() + "\nSize: " + Helpers.SizeConvert(result.Length) + Environment.NewLine;
        }

        public static string Decrypt(string filePath, string key, BackgroundWorker sender)
        {
            var startTimer = DateTime.Now;

            var data = File.ReadAllBytes(filePath);

            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key[i % key.Length]);
                if (i % (data.Length / 100) == 0 && sender != null)
                    sender.ReportProgress((int)(i / (data.Length / 100)));
            }

            var endTimer = DateTime.Now;
            var time = endTimer - startTimer;
            var resultPath = Path.GetFileName(filePath).Replace("_encrypted.encr", "");

            using (var fileStream = new FileStream(resultPath, FileMode.Create))
            {
                using (var binaryWriter = new BinaryWriter(fileStream))
                {
                    binaryWriter.Write(result);
                }
            }

            return "File decrypted and saved as " + resultPath + "\nTime: " + time.ToString() + "\nSize: " + Helpers.SizeConvert(result.Length) + Environment.NewLine;
        }   
    }
}
