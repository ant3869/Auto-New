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
            radioButton_Replace.Checked = false;

            buttselect = enumcontroller(but.Name.ToLower());
            Functions.HandleButtonSelection(but, allButtons, comboBox_Subject);

            if (buttselect != buttonselection.question)
            {
                radioButton_Replace.Visible = true;

                if (buttselect == buttonselection.issue)
                {
                    radioButton_PC.Visible = true;
                    radioButton_MAC.Visible = true;
                    radioButton_Mobile.Visible = true;
                }
                else 
                {
                    radioButton_PC.Visible = false;
                    radioButton_MAC.Visible = false;
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
                case "button_Question":
                    butsel = buttonselection.question;
                    break;
                case "button_Equipment":
                    butsel = buttonselection.equipment;
                    break;
                case "button_Issue":
                    butsel = buttonselection.issue;
                    break;
                case "none":
                    butsel = buttonselection.none;
                    break;
            }

            return butsel;
        }

        private void comboBox_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Subject.SelectedItem != null)
            {
                string selectedKey = comboBox_Subject.SelectedItem.ToString();
                string value = ComboBoxUpdater.GetValueFromSelectedKey(selectedKey);
                string pretext = GetPreText();

                if (buttselect == buttonselection.equipment)
                {
                    


                }
                    textBox_Description.Text = $"{pretext} | {value}";
            }
        }

        private string GetPreText()
        {

            if (buttselect != buttonselection.question)
            {
                if (radioButton_Replace.Checked)
                    return "Accessories - Replacement";
                else
                    return "Accessories - New";
            }
            else
                return "Question";


        }
    }
}
