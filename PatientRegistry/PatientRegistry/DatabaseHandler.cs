using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistry
{
    class DBRecord
    {
        public int id;
        public String firstName;
        public String lastName;
        public String patronymic;
        public bool gender;
        public bool isMother;
        public DateTime dateOfEntry;
        public DateTime dateOfBirth;
        public String placeOfLiving1;
        public String placeOfLiving2;
        public String bedProfile;
        public String department;
    }
    class DatabaseHandler
    {
        int currentId;
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
                record.id = Convert.ToInt32(str[0]);
                record.lastName = str[1];
                record.firstName = str[2];
                record.patronymic = str[3];
                record.gender=Convert.ToBoolean(str[4]);
                record.isMother = Convert.ToBoolean(str[5]);
                record.dateOfEntry = Convert.ToDateTime(str[6]);
                record.dateOfBirth = Convert.ToDateTime(str[7]);
                record.placeOfLiving1 = str[8];
                record.placeOfLiving2 = str[9];
                record.bedProfile = str[10];
                record.department = str[11];
               
                records.Add(record);
            }
            currentId = lines.Length;
        }
        public void WriteToFile(String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfEntry, DateTime _dateOfBirth, String _placeOfLiving1, String _placeOfLiving2, String _bedProfile, String _department)
        {
            currentId++;
            String stringToWrite = currentId.ToString()+separator+_firstName+separator+_lastName+separator+_patronymic+separator+_gender+separator+_isMother+separator+_dateOfEntry+separator+_dateOfBirth+separator+_placeOfLiving1+separator+ _placeOfLiving2 + separator+_bedProfile + separator+_department;

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path + "Database.txt"))
                {
                    sw.WriteLine(stringToWrite);
                }
            }
        }
        public void FillDataGridView()
        {
            foreach (DBRecord record in records)
            {
                String gender;
                if (record.gender == true)
                {
                    gender = "Мужской";
                }
                else gender = "Женский";

                String isMother;
                if (record.isMother == true)
                {
                    isMother = "Да";
                }
                else isMother = "Нет";

                dataGridView.Rows.Add(record.id, record.lastName, record.firstName, record.patronymic, gender, isMother, record.dateOfEntry.ToShortDateString(),record.dateOfBirth.ToShortDateString(), record.placeOfLiving1,record.placeOfLiving2,record.bedProfile,record.department);
            }
        }
    }
    
}
