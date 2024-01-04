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
<<<<<<< HEAD
        private static string selectedbuttonname;
=======
>>>>>>> 518e65e2e28d8a5610f1ae6b55e1f6485ea40879


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
<<<<<<< HEAD
            buttselect = enumcontroller(but.Name.ToLower());
            Functions.HandleButtonSelection(but, allButtons, comboBox_Subject);
=======
            string butname = but.Name.ToLower();
            buttselect = enumcontroller(butname);
            Functions.HandleButtonSelection(button_Equipment, allButtons, comboBox_Subject, butname);
>>>>>>> 518e65e2e28d8a5610f1ae6b55e1f6485ea40879
        }

        private buttonselection enumcontroller(string butname)
        {
            buttonselection butsel = new buttonselection();

            switch (butname)
            {
<<<<<<< HEAD
                case "button_Question":
                    butsel = buttonselection.question;
                    break;
                case "button_Equipment":
                    butsel = buttonselection.equipment;
                    break;
                case "button_Issue":
=======
                case "question" :
                    butsel = buttonselection.question;
                    break;
                case "equipment":
                    butsel = buttonselection.equipment;
                    break;
                case "issue":
>>>>>>> 518e65e2e28d8a5610f1ae6b55e1f6485ea40879
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

        }
    }
}
