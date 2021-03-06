﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace PatientRegistry
{
    public partial class Form1 : Form
    {
        DatabaseHandler databaseHandler;
        String path = @"S:\Projects\PatientRegistry\PatientRegistry\";
        public Form1()
        {
           
            InitializeComponent();
            databaseHandler = new DatabaseHandler(path,'|', dataGridView1);
            databaseHandler.ReadAllFromFile();
            databaseHandler.FillDataGridView();
            genderComboBox.SelectedIndex = 0;
            isLyingWithParentComboBox.SelectedIndex = 0;
            

            placeOfLivingComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            placeOfLivingComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            placeOfLivingComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            String[] lines = System.IO.File.ReadAllLines(path+"Cities.txt", System.Text.Encoding.Default);
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            foreach (String str in lines)
            {
                data.Add(str);
                placeOfLivingComboBox.Items.Add(str);
            }
            lines = System.IO.File.ReadAllLines(path+"Settlements.txt", System.Text.Encoding.Default);
            foreach (String str in lines)
            {
                data.Add(str);
                placeOfLivingComboBox.Items.Add(str);
            }
            placeOfLivingComboBox.AutoCompleteCustomSource = data;
            lines = System.IO.File.ReadAllLines(path+"BedProfiles.txt", System.Text.Encoding.Default);
            bedProfileComboBox.Items.Add("Все");
            foreach (String str in lines)
            {
                data.Add(str);
                bedProfileComboBox.Items.Add(str);
            }
       
            lines = System.IO.File.ReadAllLines(path+"Departments.txt", System.Text.Encoding.Default);
            departmentComboBox.Items.Add("Все");
            foreach (String str in lines)
            {
                data.Add(str);
                departmentComboBox.Items.Add(str);
            }
            lines = System.IO.File.ReadAllLines(path+"Statuses.txt", System.Text.Encoding.Default);
            statusComboBox.Items.Add("Все");
            foreach (String str in lines)
            {
                data.Add(str);
                statusComboBox.Items.Add(str);
            }
            bedProfileComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            departmentComboBox.SelectedIndex = 0;
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
            AddRecord addRecord = new AddRecord(true, path);
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
            DateTime dateOfEntry = dateOfEntryDateTimePicker.Value.Date;
            bool ignoreDateOfEntry=true;
            bool isDateOfEntryPeriod = false;
            DateTime endDateOfEntry = DateTime.MinValue;
            DateTime dateOfRetirement =dateOfRetirementDateTimePicker.Value.Date;
            bool ignoreDateOfRetirement = true;
            bool isDateOfRetirementPeriod = false;
            DateTime endDateOfRetirement = DateTime.MinValue;

            DateTime dateOfBirth = dateOfBirthDateTimePicker.Value.Date;
            bool ignoreDateOfBirth = true;
            bool isDateOfBirthPeriod = false;
            DateTime endDateOfBirth=DateTime.MinValue;

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
                isDateOfBirthPeriod = true;
                endDateOfBirth = endDateOfBirthDateTimePicker.Value.Date;
            }
            else
            {
                isDateOfBirthPeriod = false;
                
            }

            if (checkBox2.Checked == true)
            {
                isDateOfEntryPeriod = true;
                endDateOfEntry = endDateOfEntryDateTimePicker.Value.Date;
            }
            else
            {
                isDateOfEntryPeriod = false;
                
            }

            if (checkBox3.Checked == true)
            {
                isDateOfRetirementPeriod = true;
                endDateOfRetirement = endDateOfRetirementDateTimePicker.Value.Date;
            }
            else
            {
                isDateOfRetirementPeriod = false;
                
            }
            if (checkBox4.Checked == true)
            {
                ignoreDateOfBirth = true;
                
            }
            else
            {
                ignoreDateOfBirth = false;

            }
            if (checkBox5.Checked == true)
            {
                ignoreDateOfEntry = true;

            }
            else
            {
                ignoreDateOfEntry = false;

            }
            if (checkBox6.Checked == true)
            {
                ignoreDateOfRetirement = true;

            }
            else
            {
                ignoreDateOfRetirement = false;

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
                ignoreDateOfBirth,dateOfBirth, isDateOfBirthPeriod, ignoreDateOfEntry, dateOfEntry,isDateOfEntryPeriod, ignoreDateOfRetirement, dateOfRetirement,isDateOfRetirementPeriod,
                endDateOfBirth, endDateOfEntry, endDateOfRetirement,
                placeOfLiving,bedProfile, department,status);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
                
                endDateOfBirthDateTimePicker.Enabled = true;
            }
            else endDateOfBirthDateTimePicker.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                endDateOfEntryDateTimePicker.Enabled = true;
            }
            else endDateOfEntryDateTimePicker.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                endDateOfRetirementDateTimePicker.Enabled = true;
            }
            else endDateOfRetirementDateTimePicker.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                dateOfBirthDateTimePicker.Enabled = false;
                endDateOfBirthDateTimePicker.Enabled = false;
                checkBox1.Enabled = false;
               
            }
            else
            {
                dateOfBirthDateTimePicker.Enabled = true;
                //endDateOfBirthDateTimePicker.Enabled = true;
                checkBox1.Enabled = true;
                checkBox1.Checked = false;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                dateOfEntryDateTimePicker.Enabled = false;
                endDateOfBirthDateTimePicker.Enabled = false;
                checkBox2.Enabled = false;

            }
            else
            {
                dateOfEntryDateTimePicker.Enabled = true;
                //endDateOfBirthDateTimePicker.Enabled = true;
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                dateOfRetirementDateTimePicker.Enabled = false;
                endDateOfBirthDateTimePicker.Enabled = false;
                checkBox3.Enabled = false;


            }
            else
            {
                dateOfRetirementDateTimePicker.Enabled = true;
                //endDateOfBirthDateTimePicker.Enabled = true;
                checkBox3.Enabled = true;
                checkBox3.Checked = false;
            }
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
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            dateOfBirthDateTimePicker.Value = DateTime.Now;
            dateOfEntryDateTimePicker.Value = DateTime.Now;
            dateOfRetirementDateTimePicker.Value = DateTime.Now;

            endDateOfBirthDateTimePicker.Value = DateTime.Now;
            endDateOfEntryDateTimePicker.Value = DateTime.Now;
            endDateOfRetirementDateTimePicker.Value = DateTime.Now;
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
          
            //DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Номер");
            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Имя");
            dt.Columns.Add("Отчество");
            dt.Columns.Add("Пол");
            dt.Columns.Add("По уходу?");
            dt.Columns.Add("Дата рождения");
            dt.Columns.Add("Количество койко-дней");
            dt.Columns.Add("Дата поступления");
            dt.Columns.Add("Дата выбытия");
            dt.Columns.Add("Место проживания");
            dt.Columns.Add("Профиль койки");
            dt.Columns.Add("Отделение");
            dt.Columns.Add("Статус");
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                dt.Rows.Add(i.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString(), row.Cells[10].Value.ToString(), row.Cells[11].Value.ToString(), row.Cells[12].Value.ToString(), row.Cells[13].Value.ToString());
                i++;
            }
            
            //ds.Tables.Add(dt);
            ExportDataSetToExcel(dt, false);
        }
        public static void ExportDataSetToExcel(DataTable dt, bool isRotation)
        {
          
            using (XLWorkbook wb = new XLWorkbook())
            {
                if (isRotation == true)
                {
                    var ws = wb.Worksheets.Add("Движение за период");
                    ws.Cell("A1").Value = "Отделение";
                    ws.Cell("B1").Value = "Количество больних на начало периода";
                    ws.Cell("C1").Value = "Поступило больных";
                    ws.Cell("C2").Value = "ВСЕГО";
                    ws.Cell("D2").Value = "Из них село";
                    ws.Cell("E2").Value = "Выписано";
                    ws.Cell("F2").Value = "Переведено";
                    ws.Cell("G2").Value = "Умерло";

                    ws.Cell("E1").Value = "Выбыло больных";
                    ws.Cell("H1").Value = "Количество больных на конец периода";
                    ws.Cell("I1").Value = "Количество койко-дней всего";
                   
                    ws.Cell("J1").Value = "Количество койко-дней по уходу";

                    ws.Range("A1:A2").Merge();
                    ws.Range("B1:B2").Merge();
                    ws.Range("H1:H2").Merge();
                    ws.Range("I1:I2").Merge();
                    ws.Range("J1:J2").Merge();

                    ws.Range("C1:D1").Merge();
                    ws.Range("E1:G1").Merge();

                  

                    ws.Cell(3, 1).InsertData(dt.Rows);
                    #warning Не работает автосайз 
                    ws.Rows().AdjustToContents();
                    ws.Columns().AdjustToContents();
                    
                }
                else
                {
                    wb.Worksheets.Add(dt,"Список пациентов");
                }

               

                /*wb.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                wb.Style.Font.Bold = true;*/

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);

                }

            }
        }

        private void движениеЗаПериодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            RotationForm rotationForm = new RotationForm();
            var result = rotationForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DateTime start = rotationForm.start;
                DateTime end = rotationForm.end;
                List<RotationTable> list=databaseHandler.calculateRotation(start,end);

                DataTable dt = new DataTable();
                for (int i = 0; i < 10; i++)
                    dt.Columns.Add();

                foreach (RotationTable table in list)
                {

                    dt.Rows.Add(table.department, table.startNumberOfPatients, table.patientsEnteredTotal, table.patientsEnteredFromSettlements, table.patientsRetiredByWriteOut, table.patientsRetiredByMoving, table.patientsRetiredByDying, table.endNumberOfPatients, table.numberOfBedDaysTotal, table.numberOfBedDaysCare);
                }

                //ds.Tables.Add(dt);
                ExportDataSetToExcel(dt, true);
            }
            else return;
              
        }
    }
}
