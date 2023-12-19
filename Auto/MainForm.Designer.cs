
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Generate = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_location = new System.Windows.Forms.ComboBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.radioButton_Mobile = new System.Windows.Forms.RadioButton();
            this.radioButton_MAC = new System.Windows.Forms.RadioButton();
            this.radioButton_PC = new System.Windows.Forms.RadioButton();
            this.button_Issue = new System.Windows.Forms.Button();
            this.button_Equipment = new System.Windows.Forms.Button();
            this.button_Question = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottom.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.statusStrip1);
            this.panel_bottom.Controls.Add(this.button_Submit);
            this.panel_bottom.Controls.Add(this.button_Generate);
            this.panel_bottom.Controls.Add(this.button_Clear);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 770);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1174, 159);
            this.panel_bottom.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 137);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1174, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(730, 41);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(239, 77);
            this.button_Submit.TabIndex = 2;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            // 
            // button_Generate
            // 
            this.button_Generate.Location = new System.Drawing.Point(468, 41);
            this.button_Generate.Name = "button_Generate";
            this.button_Generate.Size = new System.Drawing.Size(239, 77);
            this.button_Generate.TabIndex = 1;
            this.button_Generate.Text = "Generate";
            this.button_Generate.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(202, 41);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(239, 77);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.dataGridView1);
            this.panel_left.Controls.Add(this.button1);
            this.panel_left.Controls.Add(this.comboBox_location);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(650, 770);
            this.panel_left.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Issue});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(634, 626);
            this.dataGridView1.TabIndex = 2;
            // 
            // Name
            // 
            this.Name.Frozen = true;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 200;
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
            this.button1.Location = new System.Drawing.Point(528, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fetch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_location
            // 
            this.comboBox_location.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_location.FormattingEnabled = true;
            this.comboBox_location.ItemHeight = 25;
            this.comboBox_location.Location = new System.Drawing.Point(353, 12);
            this.comboBox_location.Name = "comboBox_location";
            this.comboBox_location.Size = new System.Drawing.Size(169, 33);
            this.comboBox_location.TabIndex = 0;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.textBox2);
            this.panel_right.Controls.Add(this.textBox1);
            this.panel_right.Controls.Add(this.textBox_Description);
            this.panel_right.Controls.Add(this.label3);
            this.panel_right.Controls.Add(this.label2);
            this.panel_right.Controls.Add(this.comboBox_Subject);
            this.panel_right.Controls.Add(this.radioButton_Mobile);
            this.panel_right.Controls.Add(this.radioButton_MAC);
            this.panel_right.Controls.Add(this.radioButton_PC);
            this.panel_right.Controls.Add(this.button_Issue);
            this.panel_right.Controls.Add(this.button_Equipment);
            this.panel_right.Controls.Add(this.button_Question);
            this.panel_right.Controls.Add(this.label1);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(656, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(518, 770);
            this.panel_right.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 52);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 46);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 664);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 84);
            this.textBox1.TabIndex = 14;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(29, 542);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(477, 71);
            this.textBox_Description.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Work Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bogle", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Subject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.ItemHeight = 25;
            this.comboBox_Subject.Location = new System.Drawing.Point(337, 360);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(169, 33);
            this.comboBox_Subject.TabIndex = 10;
            // 
            // radioButton_Mobile
            // 
            this.radioButton_Mobile.AutoSize = true;
            this.radioButton_Mobile.Location = new System.Drawing.Point(390, 52);
            this.radioButton_Mobile.Name = "radioButton_Mobile";
            this.radioButton_Mobile.Size = new System.Drawing.Size(107, 29);
            this.radioButton_Mobile.TabIndex = 8;
            this.radioButton_Mobile.TabStop = true;
            this.radioButton_Mobile.Text = "Mobile";
            this.radioButton_Mobile.UseVisualStyleBackColor = true;
            // 
            // radioButton_MAC
            // 
            this.radioButton_MAC.AutoSize = true;
            this.radioButton_MAC.Location = new System.Drawing.Point(290, 52);
            this.radioButton_MAC.Name = "radioButton_MAC";
            this.radioButton_MAC.Size = new System.Drawing.Size(90, 29);
            this.radioButton_MAC.TabIndex = 7;
            this.radioButton_MAC.TabStop = true;
            this.radioButton_MAC.Text = "MAC";
            this.radioButton_MAC.UseVisualStyleBackColor = true;
            // 
            // radioButton_PC
            // 
            this.radioButton_PC.AutoSize = true;
            this.radioButton_PC.Location = new System.Drawing.Point(212, 52);
            this.radioButton_PC.Name = "radioButton_PC";
            this.radioButton_PC.Size = new System.Drawing.Size(72, 29);
            this.radioButton_PC.TabIndex = 6;
            this.radioButton_PC.TabStop = true;
            this.radioButton_PC.Text = "PC";
            this.radioButton_PC.UseVisualStyleBackColor = true;
            // 
            // button_Issue
            // 
            this.button_Issue.Location = new System.Drawing.Point(349, 273);
            this.button_Issue.Name = "button_Issue";
            this.button_Issue.Size = new System.Drawing.Size(160, 71);
            this.button_Issue.TabIndex = 5;
            this.button_Issue.Text = "Issue";
            this.button_Issue.UseVisualStyleBackColor = true;
            this.button_Issue.Click += new System.EventHandler(this.button_Issue_Click);
            // 
            // button_Equipment
            // 
            this.button_Equipment.Location = new System.Drawing.Point(182, 273);
            this.button_Equipment.Name = "button_Equipment";
            this.button_Equipment.Size = new System.Drawing.Size(160, 71);
            this.button_Equipment.TabIndex = 4;
            this.button_Equipment.Text = "Equipment";
            this.button_Equipment.UseVisualStyleBackColor = true;
            this.button_Equipment.Click += new System.EventHandler(this.button_Equipment_Click);
            // 
            // button_Question
            // 
            this.button_Question.Location = new System.Drawing.Point(16, 273);
            this.button_Question.Name = "button_Question";
            this.button_Question.Size = new System.Drawing.Size(160, 71);
            this.button_Question.TabIndex = 3;
            this.button_Question.Text = "Question";
            this.button_Question.UseVisualStyleBackColor = true;
            this.button_Question.Click += new System.EventHandler(this.button_Question_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bogle", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
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
            //this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto IMS";
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Issue;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RadioButton radioButton_Mobile;
        private System.Windows.Forms.RadioButton radioButton_MAC;
        private System.Windows.Forms.RadioButton radioButton_PC;
        private System.Windows.Forms.ComboBox comboBox_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

