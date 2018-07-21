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
                            data.Add(str);
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
    }
}
