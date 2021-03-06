﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalMinutes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.rdoCurrentUser = new System.Windows.Forms.RadioButton();
            this.pbCurrentUser = new System.Windows.Forms.ProgressBar();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.dpSaveDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Positions",
            "Off Codes",
            "Terms / Trans",
            "Calls",
            "Emails",
            "Project / Working Group",
            "Discussion",
            "Misc"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(359, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(359, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Visible = false;
            // 
            // txtMins
            // 
            this.txtMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMins.Location = new System.Drawing.Point(449, 39);
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(100, 38);
            this.txtMins.TabIndex = 3;
            this.txtMins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(15, 119);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComments.Size = new System.Drawing.Size(346, 82);
            this.txtComments.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "No of Mins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.113208F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Minutes for:";
            // 
            // lblTotalMinutes
            // 
            this.lblTotalMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMinutes.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalMinutes.Location = new System.Drawing.Point(10, 65);
            this.lblTotalMinutes.Name = "lblTotalMinutes";
            this.lblTotalMinutes.Size = new System.Drawing.Size(86, 23);
            this.lblTotalMinutes.TabIndex = 9;
            this.lblTotalMinutes.Text = "0";
            this.lblTotalMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(235, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 26);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.BackgroundImage")));
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportToExcel.Location = new System.Drawing.Point(204, 63);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(25, 26);
            this.btnExportToExcel.TabIndex = 11;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(554, 48);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(78, 24);
            this.btnTimer.TabIndex = 12;
            this.btnTimer.Text = "Start Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(167, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPercentage);
            this.groupBox1.Controls.Add(this.rdoCurrentUser);
            this.groupBox1.Controls.Add(this.pbCurrentUser);
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnExportToExcel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lblTotalMinutes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(370, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 108);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // lblPercentage
            // 
            this.lblPercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblPercentage.Location = new System.Drawing.Point(5, 88);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(261, 17);
            this.lblPercentage.TabIndex = 16;
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoCurrentUser
            // 
            this.rdoCurrentUser.AutoSize = true;
            this.rdoCurrentUser.Location = new System.Drawing.Point(78, 17);
            this.rdoCurrentUser.Name = "rdoCurrentUser";
            this.rdoCurrentUser.Size = new System.Drawing.Size(85, 17);
            this.rdoCurrentUser.TabIndex = 15;
            this.rdoCurrentUser.Text = "radioButton2";
            this.rdoCurrentUser.UseVisualStyleBackColor = true;
            // 
            // pbCurrentUser
            // 
            this.pbCurrentUser.Location = new System.Drawing.Point(95, 68);
            this.pbCurrentUser.Name = "pbCurrentUser";
            this.pbCurrentUser.Size = new System.Drawing.Size(101, 19);
            this.pbCurrentUser.Step = 1;
            this.pbCurrentUser.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbCurrentUser.TabIndex = 15;
            this.pbCurrentUser.Value = 50;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(10, 17);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(54, 17);
            this.rdoAll.TabIndex = 14;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "For All";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // dpSaveDate
            // 
            this.dpSaveDate.Location = new System.Drawing.Point(380, 12);
            this.dpSaveDate.Name = "dpSaveDate";
            this.dpSaveDate.Size = new System.Drawing.Size(254, 20);
            this.dpSaveDate.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 242);
            this.Controls.Add(this.dpSaveDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.txtMins);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trainers Logs v2018.03.28";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalMinutes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCurrentUser;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.ProgressBar pbCurrentUser;
        private System.Windows.Forms.DateTimePicker dpSaveDate;
    }
}

