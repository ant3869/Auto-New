﻿using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public static class Functions
    {
        //public static Dictionary<string, string> equipmentDict = new Dictionary<string, string>();

        //public static void CreateDictions()
        //{
        //    // Initialize the equipment dictionary
        //    equipmentDict = new Dictionary<string, string>
        //    {
        //        {"ACC: USB-A Headset (JPL-400)",               "HW_Duo_Headset"},
        //        {"ACC: Webcam (Lenovo 500)",               "HW_Webcam"},
        //        {"ACC: Numeric Keypad (Targus)",           "HW_W_10Key"},
        //        {"ACC: Keyboard and Mouse Set (Dell KM636)",   "HW_W_KBM"},
        //        {"ACC: Wirelesss Mouse (Logitech M510)",       "HW_W_Mouse"},
        //        {"HUB: x2 USB-A 3.0, x2 USB-C (Dev & MBP)",    "HW_USBC_Hub_Power"},
        //        {"HUB: x3 USB-A 2.0 w/ Ethernet (USB-C))",     "HW_USBC_RJ45"},
        //        {"HUB: x4 USB-A 2.0 (Ultra-Mini)",         "HW_USB2_Hub"},
        //        {"HUB: x3 USB-A 3.0 w/ Ethernet (USB-C)",      "HW_USBC_RJ45_hub"},
        //        {"CABLE: Display Port to Display Port (6ft)",  "HW_6ft_DP"},
        //        {"CABLE: HDMI to HDMI (6ft)",              "HW_6ft_HDMI"},
        //        {"CABLE: USB-C to HDMI (6ft)",             "HW_6ft_USBC_HDMI"},
        //        {"CABLE: RJ45 Ethernet (6ft)",                 "HW_6ft_RJ45"},
        //        {"CABLE: USB-C to USB-C (3ft)",            "HW_W_USBC_USBC"},
        //        {"ADPT: Dell 90-Watt (USB-C Power)",           "HW_USBC_Power_Adapter"},
        //        {"ADPT: Dell 130-Watt (USB-C Power)",          "HW_USBC_Power_Adapter"},
        //        {"ADPT: USB-C to HDMI (StarTech)",         "HW_USBC_HDMI"},
        //        {"DONGLE: USB-C to USB-A",             "HW_USBC_USBA_Dongle"},
        //        {"BATT: AA",                       "HW_dub_A"},
        //        {"BATT: AAA",                          "HW_trip_A"},
        //        {"YUBI: USB-C",                    "HW_Yubikey-C"},
        //        {"YUBI: Nano",                     "HW_Yubikey-Nano"},
        //        {"YUBI: Neo",                          "HW_Yubikey-Neo"}
        //    };
        //}

        //public static void PopulateDropDown(ComboBox dropbut, string option)
        //{
        //    dropbut.ContextMenu = GetSubjectItems(option);
        //}

        //public static ContextMenu GetSubjectItems(string a)
        //{
        //    //// Create menu items
        //    //ContextMenu contextMenu = new ContextMenu();
        //    //MenuItems menuitem = new MenuItem();

        //    //try 
        //    //{
        //    //    menuitem = GetMenuItems(a);

        //    //    if (items != null)
        //    //        contextMenu.Items.Add(items);
        //    //}
        //    //catch (Exception e) { }     

        //    //return contextMenu;
        //}

        //private static MenuItem GetMenuItems(string butname)
        //{
        //    //var menuItems;

        //    //switch (butname)
        //    //{
        //    //    case "CheckButton_Inquiry":
        //    //        menuItems.MenuItems.Add(new MenuItem("Inquiry 1", null));
        //    //        menuItems.MenuItems.Add(new MenuItem("Inquiry 2", null, Item_Click));
        //    //        break;
        //    //    case "CheckButton_Equip":
        //    //        foreach (KeyValuePair<string, string> entry in equipmentDict)
        //    //        {
        //    //            ContextMenuItem item = new ContextMenuItem(entry.Key, null, Item_Click);
        //    //            menuItems.Items.Add(item);
        //    //        }
        //    //        break;
        //    //    case "CheckButton_Issue":
        //    //        menuItems.Items.Add(new ContextMenuItem("Issue 1", null, Item_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("Issue 2", null, Item2_Click));
        //    //        break;
        //    //    case "kryptonDropButton_Location":
        //    //        menuItems.Items.Add(new ContextMenuItem("J Street", null, Item_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("DGTC", null, Item2_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("Homeoffice", null, Item_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("Sams Club", null, Item2_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("MLK", null, Item_Click));
        //    //        menuItems.Items.Add(new ContextMenuItem("Aviation", null, Item2_Click));
        //    //        break;
        //    //}

        //    //return menuItems;
        //}

        //private static void Item_Click(object sender, EventArgs e)
        //{
        //    // Handle Item 1 click
        //}

        //private static void Item2_Click(object sender, EventArgs e)
        //{
        //    // Handle Item 2 click
        //}

        public static void UpdateButtonAppearance(Button selectedButton)
        {
            // Apply selected style
            selectedButton.BackColor = Color.LightBlue; // Or any color you prefer
            selectedButton.FlatStyle = FlatStyle.Flat;
            selectedButton.FlatAppearance.BorderColor = Color.Blue; // Border color
            selectedButton.FlatAppearance.BorderSize = 2; // Border size
        }

        public static void ResetAllButtonsAppearance(params Button[] buttons)
        {
            foreach (var button in buttons)
            {
                button.BackColor = SystemColors.Control; // Default color
                button.FlatStyle = FlatStyle.Standard;
                button.FlatAppearance.BorderColor = SystemColors.ControlDark; // Default border color
                button.FlatAppearance.BorderSize = 1; // Default border size
            }
        }
    }

    public static class ComboBoxUpdater
    {
        public static Dictionary<string, string> equipmentDict = new Dictionary<string, string>();
        public static Dictionary<string, string> questionDict = new Dictionary<string, string>();
        public static Dictionary<string, string> issueDict = new Dictionary<string, string>();

        // Call this method to initialize all dictionaries
        public static void CreateDictionaries()
        {
            CreateEquipmentDict();
            CreateQuestionDict();
            CreateIssueDict();
        }

        private static void CreateEquipmentDict()
        {
            // Initialize the equipment dictionary with key-value pairs
            equipmentDict = new Dictionary<string, string>
            {
                {"ACC: USB-A Headset (JPL-400)",               "HW_Duo_Headset"},
                {"ACC: Webcam (Lenovo 500)",               "HW_Webcam"},
                {"ACC: Numeric Keypad (Targus)",           "HW_W_10Key"},
                {"ACC: Keyboard and Mouse Set (Dell KM636)",   "HW_W_KBM"},
                {"ACC: Wirelesss Mouse (Logitech M510)",       "HW_W_Mouse"},
                {"HUB: x2 USB-A 3.0, x2 USB-C (Dev & MBP)",    "HW_USBC_Hub_Power"},
                {"HUB: x3 USB-A 2.0 w/ Ethernet (USB-C))",     "HW_USBC_RJ45"},
                {"HUB: x4 USB-A 2.0 (Ultra-Mini)",         "HW_USB2_Hub"},
                {"HUB: x3 USB-A 3.0 w/ Ethernet (USB-C)",      "HW_USBC_RJ45_hub"},
                {"CABLE: Display Port to Display Port (6ft)",  "HW_6ft_DP"},
                {"CABLE: HDMI to HDMI (6ft)",              "HW_6ft_HDMI"},
                {"CABLE: USB-C to HDMI (6ft)",             "HW_6ft_USBC_HDMI"},
                {"CABLE: RJ45 Ethernet (6ft)",                 "HW_6ft_RJ45"},
                {"CABLE: USB-C to USB-C (3ft)",            "HW_W_USBC_USBC"},
                {"ADPT: Dell 90-Watt (USB-C Power)",           "HW_USBC_Power_Adapter"},
                {"ADPT: Dell 130-Watt (USB-C Power)",          "HW_USBC_Power_Adapter"},
                {"ADPT: USB-C to HDMI (StarTech)",         "HW_USBC_HDMI"},
                {"DONGLE: USB-C to USB-A",             "HW_USBC_USBA_Dongle"},
                {"BATT: AA",                       "HW_dub_A"},
                {"BATT: AAA",                          "HW_trip_A"},
                {"YUBI: USB-C",                    "HW_Yubikey-C"},
                {"YUBI: Nano",                     "HW_Yubikey-Nano"},
                {"YUBI: Neo",                          "HW_Yubikey-Neo"}
            };
        }

        private static void CreateQuestionDict()
        {
            // Initialize the question dictionary with key-value pairs
            questionDict = new Dictionary<string, string>
            {
                // Add your question key-value pairs here
            };
        }

        private static void CreateIssueDict()
        {
            // Initialize the issue dictionary with key-value pairs
            issueDict = new Dictionary<string, string>
            {
                // Add your issue key-value pairs here
            };
        }

        public static void PopulateDropDown(ComboBox dropBut, string option)
        {
            switch (option)
            {
                case "equipment":
                    UpdateComboBox(dropBut, equipmentDict);
                    break;
                case "question":
                    UpdateComboBox(dropBut, questionDict);
                    break;
                case "issue":
                    UpdateComboBox(dropBut, issueDict);
                    break;
                default:
                    dropBut.Items.Clear();
                    break;
            }
        }

        private static void UpdateComboBox(ComboBox comboBox, Dictionary<string, string> dict)
        {
            comboBox.Items.Clear();

            foreach (var item in dict)
            {
                comboBox.Items.Add(item.Key);
            }
        }
    }
}
