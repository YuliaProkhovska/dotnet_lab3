using Lab3.Classes;
using System.ComponentModel;

namespace Lab3
{
    public partial class Form1 : Form
    {

        private static string _path = string.Empty;
        private static string _key = string.Empty;

        public Form1()
        {
            InitializeComponent();

            EncryptionBw.WorkerReportsProgress = true;
            EncryptionBw.WorkerSupportsCancellation = true;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _path = openFileDialog.FileName;
                    filePathLbl.Text = _path;
                }
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Setup();

                if (EncryptionBw.IsBusy != true)
                    EncryptionBw.RunWorkerAsync("Encrypt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Setup();

                if (EncryptionBw.IsBusy != true)
                    EncryptionBw.RunWorkerAsync("Decrypt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Setup()
        {
            _key = keyTb.Text;
            if (string.IsNullOrEmpty(_path) || string.IsNullOrEmpty(_key))
            {
                MessageBox.Show("Please select file and enter key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            openFileBtn.Enabled = false;
            DecryptBtn.Enabled = false;
            EncryptBtn.Enabled = false;
        }

        private void EncryptionBw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (e.Argument == "Encrypt")
                e.Result = Cryptography.Encrypt(_path, _key, worker);
            else if (e.Argument == "Decrypt")
                e.Result = Cryptography.Decrypt(_path, _key, worker);
            
        }

        private void EncryptionBw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            ProgressLbl.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void EncryptionBw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _path = string.Empty;
            _key = string.Empty;
            filePathLbl.Text = string.Empty;
            keyTb.Text = string.Empty;
            openFileBtn.Enabled = true;
            EncryptBtn.Enabled = true;
            DecryptBtn.Enabled = true;
            progressBar1.Value = 0;
            ProgressLbl.Text = "0%";
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}