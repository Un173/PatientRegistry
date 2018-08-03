using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientRegistry
{
    public partial class AddRecord : Form
    {
        bool mode;
        String path;
        public String firstName;
        public String lastName;
        public bool gender;
        public bool isMother;
        public String patronymic;
        public DateTime dateOfBirth;
        public DateTime dateOfEntry;
        public DateTime dateOfRetirement=DateTime.MinValue;
        public String placeOfLiving;
        public String bedProfile;
        public String department;
        public int status;
        public AddRecord(bool _mode, String _path)
        {
            mode = _mode;
            path = _path;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDown;

            String[] lines = System.IO.File.ReadAllLines(path + "Cities.txt", System.Text.Encoding.Default);
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (String str in lines)
            {
                data.Add(str);
                comboBox3.Items.Add(str);
            }
            lines = System.IO.File.ReadAllLines(path + "Settlements.txt", System.Text.Encoding.Default);
            foreach (String str in lines)
            {
                data.Add(str);
                comboBox3.Items.Add(str);
            }
          

            comboBox3.AutoCompleteCustomSource = data;
        }
        //String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother, DateTime _dateOfEntry, DateTime _dateOfBirth, String _placeOfLiving1, String _placeOfLiving2, String _bedProfile, String _department
        public AddRecord(bool _mode,String _path, DBRecord record)
        {
            InitializeComponent();
            path = _path;
            mode = _mode;
            hidingLabel1.Visible = true;
            statusComboBox.Visible = true;
            dateOfRetirement = record.dateOfRetirement;
            statusComboBox.SelectedIndex = record.status;
            if (record.status == 0)
            {
                hidingLabel2.Visible = false;
                dateTimePicker3.Visible = false;
            }
            else
            {
                hidingLabel2.Visible = true;
                dateTimePicker3.Visible = true;
                dateTimePicker3.Value = record.dateOfRetirement;
            }
        
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDown;
            String[] lines = System.IO.File.ReadAllLines(path + "Cities.txt", System.Text.Encoding.Default);
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (String str in lines)
            {
                data.Add(str);
                comboBox3.Items.Add(str);
            }
            lines = System.IO.File.ReadAllLines(path + "Settlements.txt", System.Text.Encoding.Default);
            foreach (String str in lines)
            {
                data.Add(str);
                comboBox3.Items.Add(str);
            }


            comboBox3.AutoCompleteCustomSource = data;


            textBox1.Text = record.lastName;
            textBox2.Text = record.firstName;
            textBox3.Text = record.patronymic;
            if (record.gender == true)
            {
                comboBox2.Visible = false;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox2.Visible = true;
                comboBox1.SelectedIndex = 1;


                if (record.isMother == true)
                {
                    comboBox2.SelectedIndex = 1;
                }
                else
                    comboBox2.SelectedIndex = 0;

            }
            dateTimePicker1.Value = record.dateOfBirth;
            dateTimePicker2.Value = record.dateOfEntry;

            comboBox3.SelectedIndex = comboBox3.FindStringExact(record.placeOfLiving);


            comboBox4.SelectedIndex = comboBox4.FindStringExact(record.bedProfile);
            comboBox5.SelectedIndex = comboBox5.FindStringExact(record.department);



        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Visible = true;
                comboBox2.Visible = true;
              
            }
            else
            {
                label5.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedIndex = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (mode == true)
            {
                status = 0;
                dateOfRetirement = DateTime.MinValue;
            }
            else
            {
                status = statusComboBox.SelectedIndex;
            }
            
            firstName = textBox2.Text;
            lastName = textBox1.Text;
            patronymic = textBox3.Text;
            if (comboBox1.SelectedIndex == 0) gender = true;
            else gender = false;
            if (comboBox2.SelectedIndex == 0) isMother = false;
            else isMother = true;
            dateOfBirth = dateTimePicker1.Value.Date;
            dateOfEntry = dateTimePicker2.Value.Date;
           
            bedProfile = comboBox4.Text;
            department = comboBox5.Text;

            if (statusComboBox.SelectedIndex == 0|| statusComboBox.SelectedIndex==-1)
            {
                dateOfRetirement = DateTime.MinValue;
            }
            else
            {
                dateOfRetirement = dateTimePicker3.Value.Date;
            }

            if (comboBox3.FindStringExact(comboBox3.Text) == -1)
            {
                var result = MessageBox.Show("Неправильно введено место жительства", "Ошибка",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
               
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                placeOfLiving = comboBox3.Text;
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statusComboBox.SelectedIndex== 0)
            {
                hidingLabel2.Visible = false;
                dateTimePicker3.Visible = false;
                
            }
            else
            {
                hidingLabel2.Visible = true;
                dateTimePicker3.Visible = true;
                if(dateOfRetirement==DateTime.MinValue)
                dateTimePicker3.Value = DateTime.Now;
                else
                    dateTimePicker3.Value = dateOfRetirement;
            }
        }
    }
}
