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
        public bool isLyingWithParent;
        public DateTime dateOfEntry;
        public DateTime dateOfRetirement;
        public DateTime dateOfBirth;
        public int daysWithin;
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
                record.isLyingWithParent = Convert.ToBoolean(str[5]);
                record.dateOfBirth = Convert.ToDateTime(str[6]);
                record.dateOfEntry = Convert.ToDateTime(str[7]);
                record.dateOfRetirement = Convert.ToDateTime(str[8]);
                record.placeOfLiving = str[9];
                record.bedProfile = str[10];
                record.department = str[11];
                record.status = Convert.ToInt32(str[12]);
                TimeSpan time;
                if (record.dateOfRetirement == DateTime.MinValue)
                    // time = DateTime.Today - record.dateOfEntry;
                    record.daysWithin = - 1;
                else
                {
                    time = record.dateOfRetirement - record.dateOfEntry;
                    record.daysWithin = time.Days - 1;
                }
                

                records.Add(record);
            }
            currentId = lines.Length;
        }
        public void WriteToFile(String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfBirth, DateTime _dateOfEntry, DateTime _dateOfRetirement, String _placeOfLiving1, String _bedProfile, String _department, int _status)
        {

            currentId++;
            DBRecord record = new DBRecord();
            record.id = currentId;
            record.lastName = _lastName;
            record.firstName = _firstName;
            record.patronymic =_patronymic;
            record.gender = _gender;
            record.isLyingWithParent = _isMother;
            record.dateOfEntry = _dateOfEntry;
            record.dateOfBirth = _dateOfBirth;
            record.dateOfRetirement = _dateOfRetirement;
            record.placeOfLiving =_placeOfLiving1;
            record.bedProfile = _bedProfile;
            record.department = _department;
            record.status = _status;
            records.Add(record);

            String stringToWrite = currentId.ToString()+separator+ _lastName + separator+_firstName+separator+_patronymic+separator+_gender+separator+_isMother+separator+ _dateOfBirth + separator+ _dateOfEntry + separator+ _dateOfRetirement+separator+_placeOfLiving1 + separator+_bedProfile + separator+_department+separator+_status;

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.AppendText(path + "Database.txt"))
                {
                    sw.WriteLine(stringToWrite);
                }
            }
        }
        public void ModifyRegistry(int id,String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfBirth, DateTime _dateOfEntry, DateTime _dateOfRetirement , String _placeOfLiving1, String _bedProfile, String _department, int _status)
        {   
            DBRecord record = new DBRecord();
            record.id = id;
            record.lastName = _lastName;
            record.firstName = _firstName;
            record.patronymic = _patronymic;
            record.gender = _gender;
            record.isLyingWithParent = _isMother;
            record.dateOfEntry = _dateOfEntry;
            record.dateOfBirth = _dateOfBirth;
            record.dateOfRetirement = _dateOfRetirement;
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
                using (StreamWriter sw = new StreamWriter(path + "Database.txt", false))
                {
                    foreach (DBRecord r in records)
                    {
                        String stringToWrite = r.id.ToString() + separator + r.lastName + separator + r.firstName + separator + r.patronymic + separator + r.gender + separator + r.isLyingWithParent + separator + r.dateOfBirth + separator + r.dateOfEntry + separator + r.dateOfRetirement + separator + r.placeOfLiving + separator + r.bedProfile + separator + r.department + separator + r.status;
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
                String isMother;
                String status = "";
                String dateOfRetirement;
                if (record.gender == true)
                {
                    gender = "Мужской";
                }
                else gender = "Женский";

        
                if (record.isLyingWithParent == true)
                {
                    isMother = "Да";
                }
                else isMother = "Нет";

                TimeSpan time;
                if (record.dateOfRetirement == DateTime.MinValue)
                    // time = DateTime.Today - record.dateOfEntry;
                    record.daysWithin = -1;
                else
                {
                    time = record.dateOfRetirement - record.dateOfEntry;
                    record.daysWithin = time.Days - 1;
                }

                if (record.dateOfRetirement == DateTime.MinValue) dateOfRetirement = "";
                else dateOfRetirement = record.dateOfRetirement.ToShortDateString();

                switch (record.status)
                {
                    case 0:
                        {
                            status = "Состоит";
                            break;
                        }
                    case 1:
                        {
                            status = "Выписка";
                            break;
                        }
                    case 2:
                        {
                            status = "Перевод в другое ЛПУ";
                            break;
                        }
                    case 3:
                        {
                            status = "Смерть";
                            break;
                        }
                  

                }
                String daysWithin;
                if (record.daysWithin == -1) daysWithin = "";
                else daysWithin = record.daysWithin.ToString();
                dataGridView.Rows.Add(record.id, record.lastName, record.firstName, record.patronymic, gender, isMother,record.dateOfBirth.ToShortDateString(), daysWithin, record.dateOfEntry.ToShortDateString(), dateOfRetirement, record.placeOfLiving,record.bedProfile,record.department,status);
            }
        }
        public void FillDataGridView(String str)
        {
            dataGridView.Rows.Clear();
            foreach (DBRecord record in records)
            {
                String gender;
                String isMother;
                String status="";
                String dateOfRetirement = "";
                if (record.gender == true)
                {
                    gender = "Мужской";
                }
                else gender = "Женский";

                
                if (record.isLyingWithParent == true)
                {
                    isMother = "Да";
                }
                else isMother = "Нет";

                TimeSpan time;
                if (record.dateOfRetirement == DateTime.MinValue)
                    // time = DateTime.Today - record.dateOfEntry;
                    record.daysWithin = -1;
                else
                {
                    time = record.dateOfRetirement - record.dateOfEntry;
                    record.daysWithin = time.Days - 1;
                }
                if (record.dateOfRetirement == DateTime.MinValue) dateOfRetirement = "";
                else dateOfRetirement = record.dateOfRetirement.ToShortDateString();

                switch (record.status)
                {
                    case 0:
                        {
                            status = "Состоит";
                            break;
                        }
                    case 1:
                        {
                            status = "Выписка";
                            break;
                        }
                    case 2:
                        {
                            status = "Перевод в другое ЛПУ";
                            break;
                        }
                    case 3:
                        {
                            status = "Смерть";
                            break;
                        }


                }
                String daysWithin;
                if (record.daysWithin == -1) daysWithin = "";
                else daysWithin = record.daysWithin.ToString();
                if (record.lastName.ToUpper().Contains(str.ToUpper()))
                dataGridView.Rows.Add(record.id, record.lastName, record.firstName, record.patronymic, gender, isMother, record.dateOfBirth.ToShortDateString(), daysWithin, record.dateOfEntry.ToShortDateString(), dateOfRetirement, record.placeOfLiving, record.bedProfile, record.department, status);
            }
        }
        public void FillDataGridView(String lastName, String firstName, String patronymic,bool _gender, bool ignoreGender, bool isLyingWithParent, bool ignoreIsLyingWithParent,
                DateTime dateOfBirth, bool ignoreDateOfBirth, DateTime dateOfEntry, bool ignoreDateOfEntry, DateTime _dateOfRetirement, bool ignoreDateOfRetirement,
               DateTime endDateOfBirth, bool ignoreEndDateOfBirth, DateTime endDateOfEntry, bool ignoreEndDateOfEntry, DateTime endDateOfRetirement, bool ignoreEndDateOfRetirement,
               String placeOfLiving, String bedProfile, String department, int _status)
        {
            dataGridView.Rows.Clear();
            foreach (DBRecord record in records)
            {
                String gender;
                String isMother;
                String status = "";
                String dateOfRetirement = "";
                if (record.gender == true)
                {
                    gender = "Мужской";
                }
                else gender = "Женский";


                if (record.isLyingWithParent == true)
                {
                    isMother = "Да";
                }
                else isMother = "Нет";

                TimeSpan time;
                if (record.dateOfRetirement == DateTime.MinValue)
                    // time = DateTime.Today - record.dateOfEntry;
                    record.daysWithin = -1;
                else
                {
                    time = record.dateOfRetirement - record.dateOfEntry;
                    record.daysWithin = time.Days - 1;
                }
                if (record.dateOfRetirement == DateTime.MinValue) dateOfRetirement = "";
                else dateOfRetirement = record.dateOfRetirement.ToShortDateString();

                switch (record.status)
                {
                    case 0:
                        {
                            status = "Состоит";
                            break;
                        }
                    case 1:
                        {
                            status = "Выписка";
                            break;
                        }
                    case 2:
                        {
                            status = "Перевод в другое ЛПУ";
                            break;
                        }
                    case 3:
                        {
                            status = "Смерть";
                            break;
                        }


                }
                String daysWithin;
                if (record.daysWithin == -1) daysWithin = "";
                else daysWithin = record.daysWithin.ToString();


                /*List<bool> flags = new List<bool>();
                for(int i=0;i<)
                flags.Add(new bool);*/

                if (record.lastName.ToUpper().Contains(lastName.ToUpper()) &&
                    record.firstName.ToUpper().Contains(firstName.ToUpper()) &&
                    record.patronymic.ToUpper().Contains(patronymic.ToUpper()) &&
                    (ignoreGender == true || record.gender == _gender) &&
                     (ignoreIsLyingWithParent == true || record.isLyingWithParent == isLyingWithParent)
                    )
                {
                    if (ignoreDateOfBirth == false)
                    {
                        if (ignoreEndDateOfBirth == false)
                        {
                            int result1 = DateTime.Compare(record.dateOfBirth, dateOfBirth);
                            int result2 = DateTime.Compare(record.dateOfBirth, endDateOfBirth);
                            if (result1 < 0 && result2 > 0)
                            {
                                continue;
                            }

                        }
                        else
                        {
                            int result1 = DateTime.Compare(record.dateOfBirth, dateOfBirth);
                            // int result2 = DateTime.Compare(record.dateOfBirth, endDateOfBirth);
                            if (result1 < 0)
                            {
                                continue;
                            }
                        }
                       
                    }
                    else
                    {
                        if (ignoreEndDateOfBirth == false)
                        {
                            //int result1 = DateTime.Compare(record.dateOfBirth, dateOfBirth);
                            int result2 = DateTime.Compare(record.dateOfBirth, endDateOfBirth);
                            if (result2 > 0)
                            {
                                continue;
                            }

                        }
                        else
                        {
                            
                        }

                    }
                    dataGridView.Rows.Add(record.id, record.lastName, record.firstName, record.patronymic, gender, isMother, record.dateOfBirth.ToShortDateString(), daysWithin, record.dateOfEntry.ToShortDateString(), dateOfRetirement, record.placeOfLiving, record.bedProfile, record.department, status);
                }
                    
            }
        }
        public DBRecord FindRecordById(int id)
        {
            foreach (DBRecord record in records) if (record.id == id) return record;
            return null;
        }
    }
    
}
