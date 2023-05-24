using System.Data;

namespace Services
{
    public class FolderService
    {
        public static DataTable Get(string path)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("caption");
            dataTable.Columns.Add("size", typeof(string)).Caption = "size in bytes";
            dataTable.Columns.Add("Filecount", typeof(string)).Caption = "File count";

            string[] entries = Directory.GetFileSystemEntries(path);
            foreach (string entry in entries)
            {
                DataRow row = dataTable.NewRow();
                string name = Path.GetFileName(entry);
                bool isFile = (File.GetAttributes(entry) & FileAttributes.Directory) == 0;
                if (isFile)
                {
                    FileInfo fileInfo = new FileInfo(entry);
                    row["caption"] = name;
                    row["size"] = fileInfo.Length.ToString() + " b";
                }
                else
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(entry);
                    int fileCount = dirInfo.GetFiles().Length;
                    row["caption"] = name;
                    row["Filecount"] = fileCount.ToString();
                }
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

    }
}