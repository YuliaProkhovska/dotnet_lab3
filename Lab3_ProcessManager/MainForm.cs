using System;
using System.ComponentModel;
using System.Diagnostics;

namespace Lab3_ProcessManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateData();
        }

        List<Process> processes = new List<Process>();
        private Process selectedProcess;

        private void runProcBtn_Click(object sender, EventArgs e)
        {
            try 
            { 
                var selectedProcess = selectProcessCbx.SelectedItem.ToString();
                var process = ProcManager.RunProcessByName(selectedProcess);

                processes.Add(process);

                Thread.Sleep(500);
                UpdateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var pid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            selectedProcess = processes.FirstOrDefault(p => p.Id == pid);

            dataGridView1.Rows[e.RowIndex].Selected = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i != e.RowIndex)
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.White;
            }

            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;

            dataGridView1.Refresh();
        }

        private void killProcessBtn_Click(object sender, EventArgs e)
        {
            if (selectedProcess == null)
            {
                MessageBox.Show("Please select a process to kill");
                return;
            }


            var pid = selectedProcess.Id;
            processes.Remove(selectedProcess);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

            ProcManager.Close(pid);
            UpdateData();
        }

        private void UpdateData(object sender = null, EventArgs e = null)
        {
            processes = Process.GetProcesses().ToList();

            if (dataGridView1.Rows.Count == 0)
            {
                foreach (var proc in processes)
                {
                    try
                    {
                        dataGridView1.Rows.Add(proc.ProcessName, proc.Id, proc.PagedMemorySize, proc.StartTime, proc.PriorityClass.ToString(), proc.Threads.Count);
                    }
                    catch { }
                }
                return;
            }

            foreach (var proc in processes)
            {
                var row = dataGridView1.Rows.Cast<DataGridViewRow>().FirstOrDefault(r => Convert.ToInt32(r.Cells[1].Value) == proc.Id);
                if (row == null)
                {
                    try
                    {
                        dataGridView1.Rows.Add(ProcManager.GetProcessInfo(proc));
                    }
                    catch { }
                    continue;

                }

                try
                {
                    row.Cells[0].Value = proc.ProcessName;
                    row.Cells[1].Value = proc.Id;
                    row.Cells[2].Value = proc.PagedMemorySize;
                    row.Cells[3].Value = proc.StartTime;
                    row.Cells[4].Value = proc.PriorityClass.ToString();
                    row.Cells[5].Value = proc.Threads.Count;
                }
                catch { }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var pid = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                var proc = processes.FirstOrDefault(p => p.Id == pid);
                if (proc == null)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    continue;
                }
            }

            dataGridView1.Refresh();
        }

        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            var newPriority = priorityCbx.SelectedItem.ToString();
            if (selectedProcess == null)
            {
                MessageBox.Show("Please select a process to change priority");
                return;
            }
            try
            {
                ProcManager.ChangePriority(selectedProcess.Id, newPriority);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            UpdateData();
        }
    }
}