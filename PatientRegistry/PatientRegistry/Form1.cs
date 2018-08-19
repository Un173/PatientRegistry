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
    public partial class Form1 : Form
    {
        DatabaseHandler databaseHandler;
        public Form1()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler(@"S:\Projects\PatientRegistry\PatientRegistry\",'|', dataGridView1);
            databaseHandler.ReadAllFromFile();
            databaseHandler.FillDataGridView();
            genderComboBox.SelectedIndex = 0;
            isLyingWithParentComboBox.SelectedIndex = 0;
            bedProfileComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            departmentComboBox.SelectedIndex = 0;

            placeOfLivingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            placeOfLivingComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            placeOfLivingComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            String[] lines = System.IO.File.ReadAllLines(@"S:\Projects\PatientRegistry\PatientRegistry\Cities.txt", System.Text.Encoding.Default);
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (String str in lines)
            {
                data.Add(str);
                placeOfLivingComboBox.Items.Add(str);
            }
            lines = System.IO.File.ReadAllLines(@"S:\Projects\PatientRegistry\PatientRegistry\Settlements.txt", System.Text.Encoding.Default);
            foreach (String str in lines)
            {
                data.Add(str);
                placeOfLivingComboBox.Items.Add(str);
            }


            placeOfLivingComboBox.AutoCompleteCustomSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            int id = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
            DBRecord record = databaseHandler.FindRecordById(id);
            if (record == null) return;
            AddRecord addRecord = new AddRecord(false, @"S:\Projects\PatientRegistry\PatientRegistry\", record);
            var result = addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                databaseHandler.ModifyRegistry(id,addRecord.firstName, addRecord.lastName, addRecord.patronymic, addRecord.gender, addRecord.isMother, addRecord.dateOfBirth, addRecord.dateOfEntry, addRecord.dateOfRetirement, addRecord.placeOfLiving, addRecord.bedProfile, addRecord.department, addRecord.status);
                databaseHandler.FillDataGridView();
            }
        }

        private void поступлениеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddRecord addRecord = new AddRecord(true, @"S:\Projects\PatientRegistry\PatientRegistry\");
            var result = addRecord.ShowDialog();
            if (result == DialogResult.OK)
            {
                databaseHandler.WriteToFile(addRecord.firstName, addRecord.lastName, addRecord.patronymic, addRecord.gender, addRecord.isMother, addRecord.dateOfBirth, addRecord.dateOfEntry, addRecord.dateOfRetirement, addRecord.placeOfLiving, addRecord.bedProfile, addRecord.department, addRecord.status);
                databaseHandler.FillDataGridView();
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            /*String str = lastNameTextBox.Text;
            databaseHandler.FillDataGridView(str);*/

        }

        private void filterButton_Click(object sender, EventArgs e)
        {

            String firstName;
            String lastName;
            String patronymic;
            bool gender=false;
            bool ignoreGender;
            bool isLyingWithParent= false;
            bool ignoreIsLyingWithParent;
            DateTime dateOfEntry;
            bool ignoreDateOfEntry = true;
            DateTime endDateOfEntry;
            bool ignoreEndDateOfEntry = true;
            DateTime dateOfRetirement;
            bool ignoreDateOfRetirement = true;
            DateTime endDateOfRetirement;
            bool ignoreEndDateOfRetirement = true;
            DateTime dateOfBirth;
            bool ignoreDateOfBirth = true;
            DateTime endDateOfBirth;
            bool ignoreEndDateOfBirth = true;
            String placeOfLiving;
            String bedProfile;
            String department;
            int status = -1;

            lastName = lastNameTextBox.Text;
            firstName = firstNameTextBox.Text;
            patronymic= patronymicTextBox.Text;

            if (genderComboBox.SelectedIndex == 0) ignoreGender = true;
            else
            {
                ignoreGender = false;
                if (genderComboBox.SelectedIndex == 1) gender = true;
                else gender = false;
            }

            if (isLyingWithParentComboBox.SelectedIndex == 0) ignoreIsLyingWithParent = true;
            else
            {
                ignoreIsLyingWithParent = false;
                if (isLyingWithParentComboBox.SelectedIndex == 1) isLyingWithParent = false;
                else isLyingWithParent = true;
            }
            if (checkBox1.Checked == true)
            {
                ignoreDateOfBirth = true;
                dateOfBirth = DateTime.MinValue;
            }
            else
            {
                ignoreDateOfBirth = false;
                dateOfBirth = dateOfBirthDateTimePicker.Value.Date;
            }

            if (checkBox2.Checked == true)
            {
                ignoreDateOfEntry = true;
                dateOfEntry = DateTime.MinValue;
            }
            else
            {
                ignoreDateOfEntry = false;
                dateOfEntry = dateOfEntryDateTimePicker.Value.Date;
            }

            if (checkBox3.Checked == true)
            {
                ignoreDateOfRetirement = true;
                dateOfRetirement= DateTime.MinValue; 
            }
            else
            {
                ignoreDateOfRetirement = false;
                dateOfRetirement = dateOfRetirementDateTimePicker.Value.Date;
            }

            if (checkBox4.Checked == true)
            {
                ignoreEndDateOfBirth = true;
                endDateOfBirth = DateTime.MinValue;
            }
            else
            {
                ignoreEndDateOfBirth = false;
                endDateOfBirth = endDateOfBirthDateTimePicker.Value.Date;
            }

            if (checkBox5.Checked == true)
            {
                ignoreEndDateOfEntry = true;
                endDateOfEntry = DateTime.MinValue;
            }
            else
            {
                ignoreEndDateOfEntry = false;
                endDateOfEntry = endDateOfEntryDateTimePicker.Value.Date;
            }

            if (checkBox6.Checked == true)
            {
                ignoreEndDateOfRetirement = true;
                endDateOfRetirement = DateTime.MinValue;
            }
            else
            {
                ignoreEndDateOfRetirement = false;
                endDateOfRetirement = endDateOfRetirementDateTimePicker.Value.Date;

            }

            placeOfLiving = placeOfLivingComboBox.Text;
            bedProfile = bedProfileComboBox.Text;
            department = departmentComboBox.Text;
            switch (statusComboBox.Text)
            {
                case "Все":
                    {
                        status = -1;
                        break;
                    }
                case "Состоит":
                    {
                        status = 0;
                        break;
                    }
                case "Выписка":
                    {
                        status =1;
                        break;
                    }
                case "Перевод в другое ЛПУ":
                    {
                        status = 2;
                        break;
                    }
                case "Смерть":
                    {
                        status = 3;
                        break;
                    }


            }
            databaseHandler.FillDataGridView(lastName,firstName,patronymic,gender,ignoreGender,isLyingWithParent,ignoreIsLyingWithParent,
                dateOfBirth, ignoreDateOfBirth,dateOfEntry,ignoreDateOfEntry,dateOfRetirement,ignoreDateOfRetirement,
                endDateOfBirth, ignoreEndDateOfBirth, endDateOfEntry, ignoreEndDateOfEntry, endDateOfRetirement, ignoreEndDateOfRetirement,
                placeOfLiving,bedProfile, department,status);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
                dateOfBirthDateTimePicker.Enabled = false;
            }
            else dateOfBirthDateTimePicker.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateOfEntryDateTimePicker.Enabled = false;
            }
            else dateOfEntryDateTimePicker.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                dateOfRetirementDateTimePicker.Enabled = false;
            }
            else dateOfRetirementDateTimePicker.Enabled = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {

                endDateOfBirthDateTimePicker.Enabled = false;
            }
            else endDateOfBirthDateTimePicker.Enabled = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                endDateOfEntryDateTimePicker.Enabled = false;
            }
            else endDateOfEntryDateTimePicker.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                endDateOfRetirementDateTimePicker.Enabled = false;
            }
            else endDateOfRetirementDateTimePicker.Enabled = true;
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            databaseHandler.FillDataGridView();
            lastNameTextBox.Text = "";
            firstNameTextBox.Text = "";
            patronymicTextBox.Text = "";
            genderComboBox.SelectedIndex = 0;
            placeOfLivingComboBox.Text = "";
            isLyingWithParentComboBox.SelectedIndex = 0;
            bedProfileComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            departmentComboBox.SelectedIndex = 0;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
        }
    }
}
