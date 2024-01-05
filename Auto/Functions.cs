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

        public static void HandleButtonSelection(Button selectedButton, Button[] allButtons, ComboBox comboBox,  string type = "")
        {
            string name = selectedButton.Name.Substring(selectedButton.Name.IndexOf('_') + 1).ToLower();

            PopulateDropDown(comboBox, name, type);
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
        //public static Dictionary<string, string> issueDict = new Dictionary<string, string>();

        //public static Dictionary<string, object> equipmentDict = new Dictionary<string, object>();
        //public static Dictionary<string, object> questionDict = new Dictionary<string, object>();
        //public static Dictionary<string, object> issueDict = new Dictionary<string, object>();


        public static Dictionary<string, List<string>> pcDict;
        public static Dictionary<string, List<string>> macDict;
        public static Dictionary<string, List<string>> mobileDict;

        // Call this method to initialize all dictionaries
        public static void CreateDictionaries()
        {
            CreateEquipmentDict();
            CreateQuestionDict();
            CreateIssueDirectories();
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

        private static void CreateIssueDirectories()
        {
            pcDict = new Dictionary<string, List<string>>
            {
                {"PC - Misc Issues", new List<string> { "General PC troubleshooting", "Routine PC maintenance" }},
                {"PC - Physical Damage", new List<string> { "Screen damage", "Keyboard damage", "Case damage" }},
                {"PC - Replacement", new List<string> { "PC upgrade required", "PC replacement due to damage", "End-of-life PC replacement" }},
                {"PC - Eagle", new List<string> { "Eagle software issues", "Eagle connectivity problems" }},
                {"PC - Proxy", new List<string> { "Proxy server connection issue", "Proxy configuration problem" }},

                {"New Hire - PC", new List<string> { "New employee PC setup", "New hire workstation configuration" }},
                {"New Hire - Zero Touch Setup", new List<string> { "Zero touch PC deployment", "Automated PC setup for new hire" }},
                {"Device - Loaner Return", new List<string> { "Returning loaner PC", "Loaner device check-in" }},
                {"Device - Pick Up", new List<string> { "Pick up pre-configured PC", "Collect new device" }},
                {"Account - Access", new List<string> { "Account login issue", "Access to PC account problem" }},
                {"Account - Lockout", new List<string> { "Account locked due to failed logins", "User lockout issue" }},
                {"Account - Password", new List<string> { "Password reset request", "Password change assistance" }},
                {"2FA - Yubikey Enroll", new List<string> { "Setup Yubikey for PC", "Yubikey enrollment assistance" }},
                {"2FA - Yubikey Elevated", new List<string> { "Yubikey elevated access setup", "Configure Yubikey for admin access" }},
                {"2FA - LinOTP", new List<string> { "Configure LinOTP for PC", "LinOTP setup assistance" }},
                {"2FA - VIP", new List<string> { "VIP access setup for PC", "Configure VIP 2FA for user" }},
                {"2FA - Yubikey not recognized", new List<string> { "Yubikey recognition issue on PC", "Troubleshoot Yubikey connectivity" }},
                {"2FA - SSPR", new List<string> { "Setup self-service password reset for PC", "Configure SSPR for user" }},
                {"VPN - Connection Issues", new List<string> { "Troubleshoot VPN connectivity", "VPN not connecting on PC" }},
                {"VPN - Login Issues", new List<string> { "VPN login failure", "Assist with VPN access credentials" }},
                {"VPN - Slowness Issues", new List<string> { "VPN connection slow", "Improve VPN performance" }},
                {"Software - Misc. Issues", new List<string> { "General software troubleshooting", "Software performance issues" }},
                {"Software EDLP - Installation request", new List<string> { "Install EDLP software", "Assist with EDLP setup" }},
                {"Software EDLP - Issues", new List<string> { "Troubleshoot EDLP software problems", "Resolve EDLP errors" }},
                {"Software External - Installation request", new List<string> { "External software setup", "Install third-party software" }},
                {"Software External - Issues", new List<string> { "Troubleshoot third-party software", "Resolve external application errors" }},
                {"Microsoft Office - All", new List<string> { "General Office suite issues", "Office software troubleshooting" }},
                {"Microsoft Office - Outlook - Email", new List<string> { "Outlook email problems", "Assist with email setup" }},
                {"Microsoft Office - Outlook - Calendar", new List<string> { "Outlook calendar issues", "Setup Outlook calendar" }},
                {"Microsoft Office - Excel", new List<string> { "Excel issues", "Assist with Excel functions" }},
                {"Microsoft Office - PowerPoint", new List<string> { "PowerPoint issues", "Assist with presentation setup" }},
                {"Microsoft Office - Word", new List<string> { "Word document issues", "Assist with Word formatting" }},
                {"Zoom - Audio Issues", new List<string> { "Troubleshoot Zoom audio problems", "Resolve microphone issues in Zoom" }},
                {"Zoom - Chat Issues", new List<string> { "Chat functionality issues in Zoom", "Assist with Zoom messaging" }},
                {"Zoom - Download Issues", new List<string> { "Problems downloading Zoom", "Assist with Zoom installation" }},
                {"Zoom - Login Issues", new List<string> { "Zoom login failure", "Assist with Zoom account access" }},
                {"Zoom - Outlook Plug-in", new List<string> { "Troubleshoot Zoom Outlook plug-in", "Setup Zoom meetings in Outlook" }},
                {"Zoom - Update Issues", new List<string> { "Problems updating Zoom", "Assist with Zoom version upgrade" }},
                {"Teams - Outlook Plug-in", new List<string> { "Troubleshoot Teams Outlook plug-in", "Setup Teams meetings in Outlook" }},
                {"Teams - Misc", new List<string> { "General Teams issues", "Teams configuration and usage assistance" }},
                {"Browser - Chrome", new List<string> { "Chrome issues", "Assist with Chrome extensions" }},
                {"Browser - Safari", new List<string> { "Safari issues on PC", "Assist with Safari settings" }},
                {"Browser - Edge", new List<string> { "Edge issues", "Assist with Edge configuration" }},
            };

            macDict = new Dictionary<string, List<string>>
            {
                {"Mac - Misc Issues", new List<string> { "General Mac troubleshooting", "Routine Mac maintenance" }},
                {"Mac - Physical Damage", new List<string> { "Screen damage", "Keyboard damage", "Case damage" }},
                {"Mac - Replacement", new List<string> { "Mac upgrade required", "Mac replacement due to damage", "End-of-life Mac replacement" }},
                {"Mac - Eagle", new List<string> { "Eagle software issues on Mac", "Eagle connectivity problems on Mac" }},
                {"Mac - Proxy", new List<string> { "Proxy server connection issue on Mac", "Proxy configuration problem on Mac" }},

                {"New Hire - Mac", new List<string> { "New employee Mac setup", "New hire Mac workstation configuration" }},
                {"New Hire - Zero Touch Setup", new List<string> { "Zero touch Mac deployment", "Automated Mac setup for new hire" }},
                {"Device - Loaner Return", new List<string> { "Returning loaner Mac", "Loaner Mac device check-in" }},
                {"Device - Pick Up", new List<string> { "Pick up pre-configured Mac", "Collect new Mac device" }},
                {"Account - Access", new List<string> { "Account login issue on Mac", "Access to Mac account problem" }},
                {"Account - Lockout", new List<string> { "Account locked due to failed logins on Mac", "User lockout issue on Mac" }},
                {"Account - Password", new List<string> { "Password reset request for Mac", "Password change assistance for Mac" }},
                {"2FA - Yubikey Enroll", new List<string> { "Setup Yubikey for Mac", "Yubikey enrollment assistance for Mac" }},
                {"2FA - Yubikey Elevated", new List<string> { "Yubikey elevated access setup for Mac", "Configure Yubikey for admin access on Mac" }},
                {"2FA - LinOTP", new List<string> { "Configure LinOTP for Mac", "LinOTP setup assistance for Mac" }},
                {"2FA - VIP", new List<string> { "VIP access setup for Mac", "Configure VIP 2FA for Mac user" }},
                {"2FA - Yubikey not recognized", new List<string> { "Yubikey recognition issue on Mac", "Troubleshoot Yubikey connectivity on Mac" }},
                {"2FA - SSPR", new List<string> { "Setup self-service password reset for Mac", "Configure SSPR for Mac user" }},
                {"VPN - Connection Issues", new List<string> { "Troubleshoot VPN connectivity on Mac", "VPN not connecting on Mac" }},
                {"VPN - Login Issues", new List<string> { "VPN login failure on Mac", "Assist with VPN access credentials for Mac" }},
                {"VPN - Slowness Issues", new List<string> { "VPN connection slow on Mac", "Improve VPN performance on Mac" }},
                {"Software - Misc. Issues", new List<string> { "General software troubleshooting for Mac", "Software performance issues on Mac" }},
                {"Software EDLP - Installation request", new List<string> { "Install EDLP software on Mac", "Assist with EDLP setup for Mac" }},
                {"Software EDLP - Issues", new List<string> { "Troubleshoot EDLP software problems on Mac", "Resolve EDLP errors for Mac" }},
                {"Software External - Installation request", new List<string> { "External software setup for Mac", "Install third-party software on Mac" }},
                {"Software External - Issues", new List<string> { "Troubleshoot third-party software on Mac", "Resolve external application errors for Mac" }},
                {"Microsoft Office - All", new List<string> { "General Office suite issues on Mac", "Office software troubleshooting for Mac" }},
                {"Microsoft Office - Outlook - Email", new List<string> { "Outlook email problems on Mac", "Assist with email setup for Mac" }},
                {"Microsoft Office - Outlook - Calendar", new List<string> { "Outlook calendar issues on Mac", "Setup Outlook calendar for Mac" }},
                {"Microsoft Office - Excel", new List<string> { "Excel issues on Mac", "Assist with Excel functions for Mac" }},
                {"Microsoft Office - PowerPoint", new List<string> { "PowerPoint issues on Mac", "Assist with presentation setup for Mac" }},
                {"Microsoft Office - Word", new List<string> { "Word document issues on Mac", "Assist with Word formatting for Mac" }},
                {"Zoom - Audio Issues", new List<string> { "Troubleshoot Zoom audio problems on Mac", "Resolve microphone issues in Zoom for Mac" }},
                {"Zoom - Chat Issues", new List<string> { "Chat functionality issues in Zoom on Mac", "Assist with Zoom messaging for Mac" }},
                {"Zoom - Download Issues", new List<string> { "Problems downloading Zoom on Mac", "Assist with Zoom installation for Mac" }},
                {"Zoom - Login Issues", new List<string> { "Zoom login failure on Mac", "Assist with Zoom account access for Mac" }},
                {"Zoom - Outlook Plug-in", new List<string> { "Troubleshoot Zoom Outlook plug-in on Mac", "Setup Zoom meetings in Outlook for Mac" }},
                {"Zoom - Update Issues", new List<string> { "Problems updating Zoom on Mac", "Assist with Zoom version upgrade for Mac" }},
                {"Teams - Outlook Plug-in", new List<string> { "Troubleshoot Teams Outlook plug-in on Mac", "Setup Teams meetings in Outlook for Mac" }},
                {"Teams - Misc", new List<string> { "General Teams issues on Mac", "Teams configuration and usage assistance for Mac" }},
                {"Browser - Chrome", new List<string> { "Chrome issues on Mac", "Assist with Chrome extensions for Mac" }},
                {"Browser - Safari", new List<string> { "Safari issues", "Assist with Safari settings for Mac" }},
                {"Browser - Edge", new List<string> { "Edge issues on Mac", "Assist with Edge configuration for Mac" }},
            };

            mobileDict = new Dictionary<string, List<string>>
            {
                {"Mobile - Enrollment", new List<string> { "Mobile device enrollment in MDM", "New mobile device setup" }},
                {"Mobile - Compliance", new List<string> { "Mobile device compliance check", "Non-compliance issue resolution" }},
                {"Mobile - Connectivity", new List<string> { "Mobile network connectivity issue", "Mobile data connection problem" }},
                {"Mobile - Application issues", new List<string> { "Mobile app installation problem", "Mobile app performance issue" }},
                {"Mobile - Damage", new List<string> { "Mobile screen damage", "Mobile water damage" }},
                {"Mobile - EOL", new List<string> { "Mobile device end-of-life", "Mobile device upgrade required" }},
            };
        }

        public static void PopulateDropDown(ComboBox dropBut, string option, string issueType)
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
                    if (issueType == "pc")
                        UpdateComboBox(dropBut, pcDict); // pcDict is your dictionary for PC issues
                    else if (issueType == "mac")
                        UpdateComboBox(dropBut, macDict); // macDict is your dictionary for Mac issues
                    else if (issueType == "mobile")
                        UpdateComboBox(dropBut, mobileDict); // mobileDict is your dictionary for Mobile issues
                    break;
                default:
                    dropBut.Items.Clear();
                    break;
            }
        }

        //private static void UpdateComboBox(ComboBox comboBox, Dictionary<string, string> dict)
        //{
        //    comboBox.Items.Clear();

        //    foreach (var item in dict)
        //    {
        //        comboBox.Items.Add(item.Key);
        //    }
        //}

        // Modify this method to accept Dictionary<string, List<string>>
        private static void UpdateComboBox(ComboBox comboBox, object dict)
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Key";

            if (dict is Dictionary<string, string> simpleDict)
            {
                foreach (var item in simpleDict)
                {
                    comboBox.Items.Add(new { Key = item.Key, Description = item.Value });
                }
            }
            else if (dict is Dictionary<string, List<string>> listDict)
            {
                foreach (var kvp in listDict)
                {
                    foreach (var value in kvp.Value)
                    {
                        comboBox.Items.Add(new { Key = kvp.Key, Description = value });
                    }
                }
            }
        }


        public static string GetValueFromSelectedKey(string selectedKey)
        {
            // Assuming 'equipmentDict' is the relevant dictionary for your case
            if (equipmentDict.TryGetValue(selectedKey, out string value))
                return value;

            return string.Empty; // Or handle as appropriate if key not found
        }


        //public static void AttachSelectedIndexChangedHandler(ComboBox comboBox, TextBox textBox, string option)
        //{
        //    comboBox.SelectedIndexChanged += (sender, e) =>
        //    {
        //        if (comboBox.SelectedItem is string key)
        //        {
        //            string value = string.Empty;
        //            switch (option)
        //            {
        //                case "equipment":
        //                    value = equipmentDict.TryGetValue(key, out var equipValue) ? equipValue : string.Empty;
        //                    break;
        //                case "question":
        //                    value = questionDict.TryGetValue(key, out var questionValue) ? questionValue : string.Empty;
        //                    break;
        //                case "issue":
        //                    value = issueDict.TryGetValue(key, out var issueValue) ? issueValue : string.Empty;
        //                    break;
        //            }

        //            textBox.Text = $"Accessories - New | {value}";
        //        }
        //    };
        //}

        private static void UpdateDescriptionText(TextBox box, Dictionary<string, string> dict)
        {
  
        }
    }
}
