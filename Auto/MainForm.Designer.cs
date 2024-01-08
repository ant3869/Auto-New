
namespace Auto
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_Generate = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.radioButton_Replace = new System.Windows.Forms.RadioButton();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.radioButton_Mobile = new System.Windows.Forms.RadioButton();
            this.radioButton_Mac = new System.Windows.Forms.RadioButton();
            this.radioButton_PC = new System.Windows.Forms.RadioButton();
            this.button_Issue = new System.Windows.Forms.Button();
            this.button_Equipment = new System.Windows.Forms.Button();
            this.button_Question = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_right.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_Submit);
            this.panel_bottom.Controls.Add(this.button_Generate);
            this.panel_bottom.Controls.Add(this.button_Clear);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 770);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1174, 159);
            this.panel_bottom.TabIndex = 0;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(12, 70);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(166, 77);
            this.button_Generate.TabIndex = 1;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.dataGridView1);
            this.panel_left.Controls.Add(this.groupBox3);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(650, 770);
            this.panel_left.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.Issue});
            this.dataGridView1.Location = new System.Drawing.Point(8, 90);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(634, 596);
            this.dataGridView1.TabIndex = 2;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // Issue
            // 
            this.Issue.Frozen = true;
            this.Issue.HeaderText = "Issue";
            this.Issue.MinimumWidth = 10;
            this.Issue.Name = "Issue";
            this.Issue.ReadOnly = true;
            this.Issue.Width = 200;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(510, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_location
            // 
            this.comboBox_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_location.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_location.DropDownHeight = 110;
            this.comboBox_location.Font = new System.Drawing.Font("Bogle", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.IntegralHeight = false;
            this.comboBox_location.ItemHeight = 38;
            this.comboBox_location.Items.AddRange(new object[] {
            "HomeOffice",
            "DGTC",
            "J Street",
            "Sam\'s Club",
            "Mobile"});
            this.comboBox_location.Location = new System.Drawing.Point(451, 22);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(179, 46);
            this.comboBox_location.TabIndex = 0;
            this.comboBox_location.Text = "Location";
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.groupBox1);
            this.panel_right.Controls.Add(this.radioButton_Replace);
            this.panel_right.Controls.Add(this.comboBox_Subject);
            this.panel_right.Controls.Add(this.radioButton_Mobile);
            this.panel_right.Controls.Add(this.radioButton_Mac);
            this.panel_right.Controls.Add(this.radioButton_PC);
            this.panel_right.Controls.Add(this.button_Issue);
            this.panel_right.Controls.Add(this.button_Equipment);
            this.panel_right.Controls.Add(this.button_Question);
            this.panel_right.Controls.Add(this.groupBox2);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(656, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(518, 770);
            this.panel_right.TabIndex = 2;
            // 
            // radioButton_Replace
            // 
            this.radioButton_Replace.AutoCheck = false;
            this.radioButton_Replace.AutoSize = true;
            this.radioButton_Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton_Replace.Font = new System.Drawing.Font("Bogle", 7.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Replace.Location = new System.Drawing.Point(394, 310);
            this.radioButton_Replace.Name = "radioButton_Replace";
            this.radioButton_Replace.Size = new System.Drawing.Size(107, 30);
            this.radioButton_Replace.TabIndex = 17;
            this.radioButton_Replace.Text = "Replace";
            this.radioButton_Replace.UseVisualStyleBackColor = true;
            this.radioButton_Replace.Visible = false;
            // 
            // textBox_userID
            // 
            this.textBox_userID.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_userID.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_userID.Location = new System.Drawing.Point(98, 40);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(116, 28);
            this.textBox_userID.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bogle", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 194);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 100);
            this.textBox1.TabIndex = 14;
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.Font = new System.Drawing.Font("Bogle", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Description.Location = new System.Drawing.Point(10, 61);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(477, 98);
            this.textBox_Description.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Work Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Subject.Font = new System.Drawing.Font("Bogle", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.ItemHeight = 38;
            this.comboBox_Subject.Location = new System.Drawing.Point(10, 300);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(372, 46);
            this.comboBox_Subject.TabIndex = 10;
            this.comboBox_Subject.SelectedIndexChanged += new System.EventHandler(this.comboBox_Subject_SelectedIndexChanged);
            // 
            // radioButton_Mobile
            // 
            this.radioButton_Mobile.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Mobile.AutoSize = true;
            this.radioButton_Mobile.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Mobile.Location = new System.Drawing.Point(158, 174);
            this.radioButton_Mobile.Name = "radioButton_Mobile";
            this.radioButton_Mobile.Size = new System.Drawing.Size(85, 39);
            this.radioButton_Mobile.TabIndex = 8;
            this.radioButton_Mobile.Text = "Mobile";
            this.radioButton_Mobile.UseVisualStyleBackColor = true;
            this.radioButton_Mobile.Visible = false;
            this.radioButton_Mobile.CheckedChanged += new System.EventHandler(this.radioButton_Mobile_CheckedChanged);
            // 
            // radioButton_Mac
            // 
            this.radioButton_Mac.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_Mac.AutoSize = true;
            this.radioButton_Mac.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Mac.Location = new System.Drawing.Point(75, 174);
            this.radioButton_Mac.Name = "radioButton_Mac";
            this.radioButton_Mac.Size = new System.Drawing.Size(70, 39);
            this.radioButton_Mac.TabIndex = 7;
            this.radioButton_Mac.Text = "MAC";
            this.radioButton_Mac.UseVisualStyleBackColor = true;
            this.radioButton_Mac.Visible = false;
            this.radioButton_Mac.CheckedChanged += new System.EventHandler(this.radioButton_Mac_CheckedChanged);
            // 
            // radioButton_PC
            // 
            this.radioButton_PC.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_PC.AutoSize = true;
            this.radioButton_PC.Checked = true;
            this.radioButton_PC.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_PC.Location = new System.Drawing.Point(10, 174);
            this.radioButton_PC.Name = "radioButton_PC";
            this.radioButton_PC.Size = new System.Drawing.Size(50, 39);
            this.radioButton_PC.TabIndex = 6;
            this.radioButton_PC.TabStop = true;
            this.radioButton_PC.Text = "PC";
            this.radioButton_PC.UseVisualStyleBackColor = true;
            this.radioButton_PC.Visible = false;
            this.radioButton_PC.CheckedChanged += new System.EventHandler(this.radioButton_PC_CheckedChanged);
            // 
            // button_Issue
            // 
            this.button_Issue.BackColor = System.Drawing.SystemColors.Window;
            this.button_Issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Issue.Location = new System.Drawing.Point(10, 223);
            this.button_Issue.Name = "button_Issue";
            this.button_Issue.Size = new System.Drawing.Size(160, 71);
            this.button_Issue.TabIndex = 5;
            this.button_Issue.Text = "Issue";
            this.button_Issue.UseVisualStyleBackColor = false;
            this.button_Issue.Click += new System.EventHandler(this.button_Issue_Click);
            // 
            // button_Equipment
            // 
            this.button_Equipment.BackColor = System.Drawing.SystemColors.Window;
            this.button_Equipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Equipment.Location = new System.Drawing.Point(179, 223);
            this.button_Equipment.Name = "button_Equipment";
            this.button_Equipment.Size = new System.Drawing.Size(160, 71);
            this.button_Equipment.TabIndex = 4;
            this.button_Equipment.Text = "Equipment";
            this.button_Equipment.UseVisualStyleBackColor = false;
            this.button_Equipment.Click += new System.EventHandler(this.button_Equipment_Click);
            // 
            // button_Question
            // 
            this.button_Question.BackColor = System.Drawing.SystemColors.Window;
            this.button_Question.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Question.Location = new System.Drawing.Point(348, 223);
            this.button_Question.Name = "button_Question";
            this.button_Question.Size = new System.Drawing.Size(160, 71);
            this.button_Question.TabIndex = 3;
            this.button_Question.Text = "Question";
            this.button_Question.UseVisualStyleBackColor = false;
            this.button_Question.Click += new System.EventHandler(this.button_Question_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_userID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 143);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 33);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(98, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 28);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(98, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 28);
            this.textBox3.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Description);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 309);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Preview";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBox_location);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.groupBox3.Location = new System.Drawing.Point(8, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(634, 748);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // button_Submit
            // 
            this.button_Submit.AutoSize = true;
            this.button_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Submit.Image = global::Auto.Properties.Resources.upload_small;
            this.button_Submit.Location = new System.Drawing.Point(1027, 21);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(68, 68);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.AutoSize = true;
            this.button_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Image = global::Auto.Properties.Resources.reset_small1;
            this.button_Clear.Location = new System.Drawing.Point(874, 21);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(67, 68);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Model";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(304, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 28);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(304, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 28);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(304, 70);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 28);
            this.textBox6.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 29);
            this.label7.TabIndex = 23;
            this.label7.Text = "Seral";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bogle", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(214, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "WSN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1174, 929);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_bottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto IMS";
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_location;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Generate;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Issue;
        private System.Windows.Forms.Button button_Equipment;
        private System.Windows.Forms.Button button_Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_Mobile;
        private System.Windows.Forms.RadioButton radioButton_Mac;
        private System.Windows.Forms.RadioButton radioButton_PC;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue;
        private System.Windows.Forms.RadioButton radioButton_Replace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
    }
}

