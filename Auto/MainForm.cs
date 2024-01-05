using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public enum buttonselection { question, equipment, issue, none};

    public partial class MainForm : Form
    {
        public static Button[] allButtons;
        public static buttonselection buttselect;
       // private static string selectedbuttonname;


        public MainForm()
        {
            InitializeComponent();
            InitializeBase();
        }

        private void InitializeBase()
        {
            ComboBoxUpdater.CreateDictionaries();
            allButtons = new Button[] { button_Equipment, button_Question, button_Issue };      
            buttselect = buttonselection.none;
        }

        private void button_Equipment_Click(object sender, EventArgs e)
        {
            buttoncontroller(button_Equipment);
        }

        private void button_Question_Click(object sender, EventArgs e)
        {
            buttoncontroller(button_Question);
        }

        private void button_Issue_Click(object sender, EventArgs e)
        {
            buttoncontroller(button_Issue);
        }

        private void buttoncontroller(Button but)
        {
            buttselect = enumcontroller(but.Name.ToLower());
            radiobuttoncontroller(buttselect);
            Functions.HandleButtonSelection(but, allButtons, comboBox_Subject);     
        }

        private void radiobuttoncontroller(buttonselection selection)
        {
            radioButton_Replace.Checked = false;

            if (selection != buttonselection.question)
            {
                radioButton_Replace.Visible = true;

                if (selection == buttonselection.issue)
                {
                    radioButton_PC.Visible = true;
                    radioButton_Mac.Visible = true;
                    radioButton_Mobile.Visible = true;
                }
                else
                {
                    radioButton_PC.Visible = false;
                    radioButton_Mac.Visible = false;
                    radioButton_Mobile.Visible = false;
                }
            }
            else
                radioButton_Replace.Visible = false;
        }

        private buttonselection enumcontroller(string butname)
        {
            buttonselection butsel = new buttonselection();

            switch (butname)
            {
                case "button_question":
                    butsel = buttonselection.question;
                    break;
                case "button_equipment":
                    butsel = buttonselection.equipment;
                    break;
                case "button_issue":
                    butsel = buttonselection.issue;
                    break;
                case "none":
                    butsel = buttonselection.none;
                    break;
            }

            return butsel;
        }

        //private void comboBox_Subject_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox_Subject.SelectedItem != null)
        //    {
        //        string selectedKey = comboBox_Subject.SelectedItem.ToString();
        //        string value = ComboBoxUpdater.GetValueFromSelectedKey(selectedKey);
        //        string pretext = GetPreText();

        //        textBox_Description.Text = $"{pretext} | {value}";
        //    }
        //}

        private void comboBox_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Subject.SelectedItem != null)
            {
                var selectedItem = comboBox_Subject.SelectedItem;
                var itemType = selectedItem.GetType();

                // Retrieve the 'Description' property
                var descriptionProperty = itemType.GetProperty("Description");
                string description = descriptionProperty?.GetValue(selectedItem)?.ToString() ?? string.Empty;

                // Use GetPreText to get the correct pretext
                string pretext = GetPreText();

                textBox_Description.Text = $"{pretext} | {description}";
            }
        }


        //private string GetPreText()
        //{

        //    if (buttselect != buttonselection.question)
        //    {
        //        if (buttselect == buttonselection.equipment)
        //            return radioButton_Replace.Checked ? "Accessories - Replacement" : "Accessories - New";

        //        if (comboBox_Subject.SelectedItem is dynamic item)
        //        {
        //            return item.Key;  // The dictionary key is used as pretext
        //        }
        //    }
        //    else
        //        return "Question";
        //}

        private string GetPreText()
        {
            if (buttselect == buttonselection.equipment)
            {
                return radioButton_Replace.Checked ? "Accessories - Replacement" : "Accessories - New";
            }
            else if (buttselect == buttonselection.question)
            {
                return "Question";
            }
            else if (comboBox_Subject.SelectedItem != null)
            {
                var selectedItem = comboBox_Subject.SelectedItem;
                var itemType = selectedItem.GetType();
                var keyProperty = itemType.GetProperty("Key");
                var key = keyProperty?.GetValue(selectedItem)?.ToString();

                return key ?? string.Empty;
            }

            // Default return statement if none of the above conditions are met
            return string.Empty;
        }

        private void radioButton_PC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PC.Checked)
            {
                ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "issue", "pc");
            }
        }

        private void radioButton_Mac_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mac.Checked)
            {
                ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "issue", "mac");
            }
        }

        private void radioButton_Mobile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Mobile.Checked)
            {
                ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "issue", "mobile");
            }
        }

    }
}
