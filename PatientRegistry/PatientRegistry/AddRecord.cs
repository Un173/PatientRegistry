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
        String path;
        public String firstName;
        public String lastName;
        public bool gender;
        public bool isMother;
        public String patronymic;
        public DateTime dateOfEntry;
        public DateTime dateOfBirth;
        public String placeOfLiving1;
        public String placeOfLiving2;
        public String bedProfile;
        public String department;
        public AddRecord(String _path)
        {
            path = _path;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            variableComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            variableComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            variableComboBox.DropDownStyle = ComboBoxStyle.DropDown;
        }
        public AddRecord(String _path, String _firstName, String _lastName, String _patronymic, bool _gender, bool _isMother,DateTime _dateOfEntry, DateTime _dateOfBirth, String _placeOfLiving1, String _placeOfLiving2, String _bedProfile, String _department)
        {
            textBox1.Text = _lastName;
            textBox2.Text = _firstName;
            textBox3.Text = _patronymic;
            if (_gender == true)
            {
                comboBox2.Visible = false;
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                comboBox1.SelectedIndex = 1;


                if (_isMother == true)
                {
                    comboBox2.SelectedIndex = 1;
                }
                else
                    comboBox2.SelectedIndex = 0;

            }
            dateTimePicker1.Value = _dateOfEntry;
            dateTimePicker2.Value = _dateOfBirth;
            comboBox3.SelectedValue = _placeOfLiving1;
            variableComboBox.SelectedValue = _placeOfLiving2;
            comboBox4.SelectedValue = _bedProfile;
            comboBox5.SelectedValue = _department;


            path = _path;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            variableComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            variableComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            variableComboBox.DropDownStyle = ComboBoxStyle.DropDown;
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
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0://Город
                    {
                        variableComboBox.Text = "";
                        variableComboBox.Items.Clear();
                        variableComboBox.Visible = true;
                       
                        String[] lines = System.IO.File.ReadAllLines(path + "Cities.txt", System.Text.Encoding.Default);
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        foreach (String str in lines)
                        {
                            data.Add(str);
                            variableComboBox.Items.Add(str);
                        }
                        variableComboBox.AutoCompleteCustomSource = data;
                        break;
                    }
                case 1://Село
                    {
                        variableComboBox.Text = "";
                        variableComboBox.Items.Clear();
                        variableComboBox.Visible = true;
      
                        String[] lines = System.IO.File.ReadAllLines(path + "Settlements.txt", System.Text.Encoding.Default);
                        AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                        foreach (String str in lines)
                        {
                            data.Add(str);
                            variableComboBox.Items.Add(str);
                        }
                        variableComboBox.AutoCompleteCustomSource = data;

                        break;
                    }
                case 2://Другая область
                    {
                        variableComboBox.Items.Clear();
                        variableComboBox.Visible = false;
                        break;
                    }
                case 3://Иваново
                    {
                        variableComboBox.Items.Clear();
                        variableComboBox.Visible = false;
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            firstName = textBox2.Text;
            lastName = textBox1.Text;
            patronymic = textBox3.Text;
            if (comboBox1.SelectedIndex == 0) gender = true;
            else gender = false;
            if (comboBox2.SelectedIndex == 0) isMother = false;
            else isMother = true;
            dateOfBirth = dateTimePicker1.Value.Date;
            dateOfEntry = dateTimePicker2.Value.Date;
            placeOfLiving1 = comboBox3.Text;
            placeOfLiving2 = variableComboBox.Text;
            bedProfile = comboBox4.Text;
            department = comboBox5.Text;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
