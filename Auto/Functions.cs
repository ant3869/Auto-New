using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Auto.ComboBoxUpdater;

namespace Auto
{
    public static class Functions
    {
        private static string[] allButtons = { "question", "equipment", "issue", "none" };

        public static void HandleButtonSelection(Button selectedButton, Button[] allButtons, ComboBox comboBox)
        {
            string name = selectedButton.Name.Substring(selectedButton.Name.IndexOf('_') + 1).ToLower();

            PopulateDropDown(comboBox, name);
            ResetAllButtonsAppearance(allButtons);
            UpdateButtonAppearance(selectedButton);     
            EnableOrDisableOtherButtons(selectedButton, allButtons, false);
        }

        private static void UpdateButtonAppearance(Button selectedButton)
        {
            selectedButton.BackColor = Color.LightGreen;
            selectedButton.FlatAppearance.BorderColor = Color.Blue;
            selectedButton.FlatAppearance.BorderSize = 2;
        }

        private static void ResetAllButtonsAppearance(Button[] allButtons)
        {
            foreach (var button in allButtons)
            {
                button.BackColor = SystemColors.Window;
                button.FlatStyle = FlatStyle.Standard;
                button.FlatAppearance.BorderColor = SystemColors.ControlDark;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        private static void EnableOrDisableOtherButtons(Button selectedButton, Button[] allButtons, bool enabled)
        {
            //foreach (var button in allButtons)
            //{
            //    if (button != selectedButton)
            //    {
            //        button.Enabled = enabled;
            //    }
            //}
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

        public static string GetValueFromSelectedKey(string selectedKey)
        {
            // Assuming 'equipmentDict' is the relevant dictionary for your case
            if (equipmentDict.TryGetValue(selectedKey, out string value))
                return value;

            return string.Empty; // Or handle as appropriate if key not found
        }


        public static void AttachSelectedIndexChangedHandler(ComboBox comboBox, TextBox textBox, string option)
        {
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox.SelectedItem is string key)
                {
                    string value = string.Empty;
                    switch (option)
                    {
                        case "equipment":
                            value = equipmentDict.TryGetValue(key, out var equipValue) ? equipValue : string.Empty;
                            break;
                        case "question":
                            value = questionDict.TryGetValue(key, out var questionValue) ? questionValue : string.Empty;
                            break;
                        case "issue":
                            value = issueDict.TryGetValue(key, out var issueValue) ? issueValue : string.Empty;
                            break;
                    }

                    textBox.Text = $"Accessories - New | {value}";
                }
            };
        }

        private static void UpdateDescriptionText(TextBox box, Dictionary<string, string> dict)
        {
  
        }
    }
}
