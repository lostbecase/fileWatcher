using System;
using System.Windows.Forms;
using System.IO;
namespace fileWatcherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void watchBTN_Click(object sender, EventArgs e)
        {
            string strPath = dirPath.Text;

            watcher = new FileSystemWatcher();
            try
            {
                watcher.Path = strPath;
            }
            catch
            {
                MessageBox.Show("wrong!");
                return;
            }
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*.*";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            try
            {
                watcher.EnableRaisingEvents = true;
            }
            catch
            {
                MessageBox.Show("wrong!");
                return;
            }
            
            MessageBox.Show("开始监视!\npath:\n"+strPath);
        }
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            //MessageBox.Show("path:\n"+e.FullPath + "\nChangeType:\n" + e.ChangeType);
            int rowIndex=eventGrid.Rows.Add();
            DateTime now = DateTime.Now;
            eventGrid.Rows[rowIndex].Cells[0].Value = now.ToString("yyyy-MM-dd");
            eventGrid.Rows[rowIndex].Cells[1].Value = e.ChangeType;
            eventGrid.Rows[rowIndex].Cells[2].Value = e.FullPath;
        }
        private void  OnRenamed(object source, RenamedEventArgs e)
        {
            //MessageBox.Show("path:\n" + e.FullPath + "\nChangeType:\n" + e.ChangeType);
            int rowIndex = eventGrid.Rows.Add();
            DateTime now = DateTime.Now;
            eventGrid.Rows[rowIndex].Cells[0].Value = now.ToString("yyyy-MM-dd");
            eventGrid.Rows[rowIndex].Cells[1].Value = e.ChangeType;
            eventGrid.Rows[rowIndex].Cells[2].Value = e.FullPath;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                MessageBox.Show("已停止监控");
            }
            catch
            {
                MessageBox.Show("wrong!");
                return;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream("d:\\test.txt", FileMode.Create);
                file.Seek(0, SeekOrigin.Begin);
                //string str = "abcdeee";
                //byte[] byteArray=System.Text.Encoding.Default.GetBytes(str);
                //file.Write(byteArray, 0, 6);
                //file.Read(byData, 0, 100); 
                //Console.WriteLine(charData);
                int rowCnt = eventGrid.RowCount-1;
                int cluCnt = eventGrid.ColumnCount;
                byte[] tabLabel = System.Text.Encoding.Default.GetBytes("\t");
                byte[] lineLabel = System.Text.Encoding.Default.GetBytes("\r\n");
                for (int i=0;i<rowCnt;i++)
                {
                    for(int j=0;j<cluCnt;j++)
                    {
                        string str = eventGrid.Rows[i].Cells[j].Value.ToString();
                        byte[] byteArray = System.Text.Encoding.Default.GetBytes(str);
                        file.Write(byteArray, 0, byteArray.Length);
                   
                        file.Write(tabLabel, 0, tabLabel.Length);
                    }
                    file.Write(lineLabel, 0, lineLabel.Length);
                }
                file.Close();
                MessageBox.Show("saved in d:\\test.txt");
            }
            catch 
            {
                MessageBox.Show("wrong");
            }
        }
    }
}
