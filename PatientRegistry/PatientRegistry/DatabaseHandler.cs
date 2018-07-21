using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistry
{
    class DBRecord
    {
        public String lastName;
        public String firstName;
        public String patronymic;
        public String second;
        public String third;
    }
    class DatabaseHandler
    {
        public List<DBRecord> records=new List<DBRecord>();
        public String path;
        public char separator;
        public DataGridView dataGridView;
        public DatabaseHandler(String _path, char _separator,DataGridView _dataGridView)
        {
            path = _path;
            separator = _separator;
            dataGridView = _dataGridView;
        }

        public void ReadAllFromFile()
        {
            String[] lines = System.IO.File.ReadAllLines(path+ "Database.txt");
            foreach (String s in lines)
            {
                String[] str = s.Split(separator);
                DBRecord record = new DBRecord();
                record.lastName = str[0];
                record.firstName = str[1];
                record.patronymic = str[2];
                record.second = str[3];
                record.third = str[4];
                records.Add(record);
            }
        }

        public void FillDataGridView()
        {
            foreach(DBRecord record in records)
            dataGridView.Rows.Add(record.lastName,record.firstName,record.patronymic, record.second, record.third);
        }
    }
    
}
