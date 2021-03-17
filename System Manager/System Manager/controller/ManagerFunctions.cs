using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Manager
{
    class ManagerFunctions
    {
        static public DataGridView GetSystemProcesses(DataGridView dataGridView__Manager, Process[] processes)
        {
            for (int i = 0; i < processes.Count(); i++)
            {
                if (i > 0) { 
                string[] row = new string[7];

                row[0] = i.ToString();
                row[1] = processes[i].ProcessName.ToString();
                row[2] = processes[i].Id.ToString();
                row[3] = processes[i].MachineName.ToString();
                row[4] = processes[i].VirtualMemorySize64.ToString();
                row[5] = processes[i].BasePriority.ToString();
                row[6] = processes[i].Threads.Count.ToString();
                dataGridView__Manager.Rows.Add(row);
                }
                else
                {
                    dataGridView__Manager.Rows[0].Cells[0].Value = i.ToString();

                    dataGridView__Manager.Rows[0].Cells[1].Value = processes[i].ProcessName.ToString();

                    dataGridView__Manager.Rows[0].Cells[2].Value = processes[i].Id.ToString();

                    dataGridView__Manager.Rows[0].Cells[3].Value = processes[i].MachineName.ToString();

                    dataGridView__Manager.Rows[0].Cells[4].Value = processes[i].VirtualMemorySize64.ToString();

                    dataGridView__Manager.Rows[0].Cells[5].Value = processes[i].BasePriority.ToString();

                    dataGridView__Manager.Rows[0].Cells[6].Value = processes[i].Threads.Count.ToString();
                }
            }
            return dataGridView__Manager;
        }

        static public DataGridView GetProcessInfo(DataGridView dataGridView__Process, Process process)
        {
            for (int i = 0; i < process.Threads.Count; i++)
            {
                if (i > 0)
                {
                    string[] row = new string[3];
                    row[0] = i.ToString();
                    row[1] = process.Threads[i].Id.ToString();
                    row[2] = process.Threads[i].BasePriority.ToString();
                    dataGridView__Process.Rows.Add(row);
                }
                else
                {
                    dataGridView__Process.Rows[0].Cells[0].Value = i.ToString();

                    dataGridView__Process.Rows[0].Cells[1].Value = process.Threads[i].Id.ToString();

                    dataGridView__Process.Rows[0].Cells[2].Value = process.Threads[i].BasePriority.ToString();
                }
            }
            return dataGridView__Process;
        }

        static public DataGridView Refresh(DataGridView dataGridView__Manager, Process[] processes)
        {
            for (int i = 0; i < processes.Count(); i++)
            {
                if (i > dataGridView__Manager.Rows.Count - 1)
                {
                    string[] row = new string[7];
                    row[0] = i.ToString();
                    row[1] = processes[i].ProcessName.ToString();
                    row[2] = processes[i].Id.ToString();
                    row[3] = processes[i].MachineName.ToString();
                    row[4] = processes[i].VirtualMemorySize64.ToString();
                    row[5] = processes[i].BasePriority.ToString();
                    row[6] = processes[i].Threads.Count.ToString();
                    dataGridView__Manager.Rows.Add(row);
                }
                else
                {
                    dataGridView__Manager.Rows[i].Cells[0].Value = i.ToString();

                    dataGridView__Manager.Rows[i].Cells[1].Value = processes[i].ProcessName.ToString();

                    dataGridView__Manager.Rows[i].Cells[2].Value = processes[i].Id.ToString();

                    dataGridView__Manager.Rows[i].Cells[3].Value = processes[i].MachineName.ToString();

                    dataGridView__Manager.Rows[i].Cells[4].Value = processes[i].VirtualMemorySize64.ToString();

                    dataGridView__Manager.Rows[i].Cells[5].Value = processes[i].BasePriority.ToString();

                    dataGridView__Manager.Rows[i].Cells[6].Value = processes[i].Threads.Count.ToString();
                }
            }

            if (dataGridView__Manager.Rows.Count > processes.Count())
                dataGridView__Manager.Rows.RemoveAt(processes.Count() - 1);

            return dataGridView__Manager;
        }

        static public DataGridView Refresh(DataGridView dataGridView__Process, Process process)
        {
            for (int i = 0; i < process.Threads.Count; i++)
            {
                if (i > dataGridView__Process.Rows.Count - 1)
                {
                    string[] row = new string[3];
                    row[0] = i.ToString();
                    row[1] = process.Threads[i].Id.ToString();;
                    row[2] = process.Threads[i].BasePriority.ToString();
                    dataGridView__Process.Rows.Add(row);
                }
                else
                {
                    dataGridView__Process.Rows[i].Cells[0].Value = i.ToString();

                    dataGridView__Process.Rows[i].Cells[1].Value = process.Threads[i].Id.ToString();

                    dataGridView__Process.Rows[i].Cells[2].Value = process.Threads[i].BasePriority.ToString();
                }
            }

            if(dataGridView__Process.Rows.Count > process.Threads.Count)
                dataGridView__Process.Rows.RemoveAt(process.Threads.Count - 1);

            return dataGridView__Process;
        }
    }
}
