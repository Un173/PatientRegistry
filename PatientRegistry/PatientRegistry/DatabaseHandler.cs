using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistry
{
    public class DBRecord
    {
        public int id;
        public String firstName;
        public String lastName;
        public String patronymic;
        public bool gender;
        public bool isMother;
        public DateTime dateOfEntry;
        public DateTime dateOfBirth;
        public String placeOfLiving;
        public String bedProfile;
        public String department;
        public int status;
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
                record.placeOfLiving = str[8];
                record.bedProfile = str[9];
                record.department = str[10];
                record.status = Convert.ToInt32(str[11]);

                records.Add(record);
            }
            currentId = lines.Length;
        }
        public void WriteToFile(String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfEntry, DateTime _dateOfBirth, String _placeOfLiving1, String _bedProfile, String _department, int _status)
        {

            currentId++;
            DBRecord record = new DBRecord();
            record.id = currentId;
            record.lastName = _lastName;
            record.firstName = _firstName;
            record.patronymic =_patronymic;
            record.gender = _gender;
            record.isMother = _isMother;
            record.dateOfEntry = _dateOfEntry;
            record.dateOfBirth = _dateOfBirth;
            record.placeOfLiving =_placeOfLiving1;
            record.bedProfile = _bedProfile;
            record.department = _department;
            record.status = _status;
            records.Add(record);

            String stringToWrite = currentId.ToString()+separator+ _lastName + separator+_firstName+separator+_patronymic+separator+_gender+separator+_isMother+separator+_dateOfEntry+separator+_dateOfBirth+separator+_placeOfLiving1+separator+_bedProfile + separator+_department+separator+_status;

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path + "Database.txt"))
                {
                    sw.WriteLine(stringToWrite);
                }
            }
        }
        public void ModifyRegistry(int id,String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfEntry, DateTime _dateOfBirth, String _placeOfLiving1, String _bedProfile, String _department, int _status)
        {
          
           
            DBRecord record = new DBRecord();
           
            record.id = id;
            record.lastName = _lastName;
            record.firstName = _firstName;
            record.patronymic = _patronymic;
            record.gender = _gender;
            record.isMother = _isMother;
            record.dateOfEntry = _dateOfEntry;
            record.dateOfBirth = _dateOfBirth;
            record.placeOfLiving = _placeOfLiving1;
            record.bedProfile = _bedProfile;
            record.department = _department;
            record.status = _status;
            for(int i=0; i<records.Count;i++)
            {
                if (records[i].id == id) records[i] = record;
            }
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = new StreamWriter(path + "Database.txt", false))
                {
                    foreach (DBRecord r in records)
                    {
                        String stringToWrite = r.id.ToString() + separator + r.lastName + separator + r.firstName + separator + r.patronymic + separator + r.gender + separator + r.isMother + separator + r.dateOfEntry + separator + r.dateOfBirth + separator + r.placeOfLiving + separator + r.bedProfile + separator + r.department + separator + r.status;
                        sw.WriteLine(stringToWrite);
                    }
                }
            }
        }
        public void FillDataGridView()
        {
            dataGridView.Rows.Clear();
    
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
                String status="";
              switch(record.status)
                {
                    case 0:
                        {
                            status = "Состоит";
                            break;
                        }
                    case 1:
                        {
                            status = "Перевод в другое ЛПУ";
                            break;
                        }
                    case 2:
                        {
                            status = "Смерть";
                            break;
                        }

                }
                dataGridView.Rows.Add(record.id, record.lastName, record.firstName, record.patronymic, gender, isMother,record.dateOfBirth.ToShortDateString(), record.dateOfEntry.ToShortDateString(),record.placeOfLiving,record.bedProfile,record.department,status);
            }
        }
        public DBRecord FindRecordById(int id)
        {
            foreach (DBRecord record in records) if (record.id == id) return record;
            return null;
        }
    }
    
}
