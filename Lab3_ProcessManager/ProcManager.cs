using System.Diagnostics;

namespace Lab3_ProcessManager
{
    class ProcManager
    {
        public static Process RunProcessByName(string processName)
        {
            switch (processName)
            {
                case "Notepad":
                    return StartNewProcess("notepad.exe");
                case "Calculator":
                    return StartNewProcess("calc.exe");
                case "Paint":
                    return StartNewProcess("mspaint.exe");
                case "Microsoft Word":
                    return StartNewProcess("winword.exe");
                case "Microsoft Excel":
                    return StartNewProcess("excel.exe");
                default:
                    throw new Exception("Please select a correct process to run");
            }
        }

        private static Process StartNewProcess(string processName)
        {

            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c start " + processName;
            process.Start();

            return process;
        }

        public static void Close(int pid)
        {
            Process.GetProcessById(pid).Kill();
        }

        public static object GetProcessInfo(Process proc)
        {
            var x = new string[] { proc.ProcessName, proc.Id.ToString(), proc.PagedMemorySize.ToString(), proc.StartTime.ToString(), proc.PriorityClass.ToString(), proc.Threads.Count.ToString()};

            return x;
        }

        public static void ChangePriority(int pid, string newPriority)
        {

            var selectedProcess = Process.GetProcessById(pid);

            if (newPriority == "Normal")
                selectedProcess.PriorityClass = ProcessPriorityClass.Normal;
            else if (newPriority == "High")
                selectedProcess.PriorityClass = ProcessPriorityClass.High;
            else if (newPriority == "Low")
                selectedProcess.PriorityClass = ProcessPriorityClass.Idle;
            else if (newPriority == "Realtime")
                selectedProcess.PriorityClass = ProcessPriorityClass.RealTime;
            else if (newPriority == "Above normal")
                selectedProcess.PriorityClass = ProcessPriorityClass.AboveNormal;
            else if (newPriority == "Below normal")
                selectedProcess.PriorityClass = ProcessPriorityClass.BelowNormal;
            else
            {
                throw new Exception("Please select a correct priority");
            }
        }
    }
}
