using System;
using System.IO;
using System.Windows.Forms;

namespace AssettoCorsaTuningUtility
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
            this.carBox = new System.Windows.Forms.ComboBox();
            this.set_path_button = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.picbox_car = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabs = new System.Windows.Forms.TabControl();
            this.EnginePage = new System.Windows.Forms.TabPage();
            this.engineTextBox = new System.Windows.Forms.RichTextBox();
            this.DriveTrainPage = new System.Windows.Forms.TabPage();
            this.drivetrainTextBox = new System.Windows.Forms.RichTextBox();
            this.EngineSwapPage = new System.Windows.Forms.TabPage();
            this.Comment1 = new System.Windows.Forms.Label();
            this.CarBox2 = new System.Windows.Forms.ComboBox();
            this.TuneThisBtn = new System.Windows.Forms.Button();
            this.CreateChildBtn = new System.Windows.Forms.Button();
            this.tooltp = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.newTuneNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newCarNameTextBox = new System.Windows.Forms.TextBox();
            this.createNewCarBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.picbox_car)).BeginInit();
            this.tabs.SuspendLayout();
            this.EnginePage.SuspendLayout();
            this.DriveTrainPage.SuspendLayout();
            this.EngineSwapPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // carBox
            // 
            this.carBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.carBox.FormattingEnabled = true;
            this.carBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.carBox.Location = new System.Drawing.Point(16, 33);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(421, 21);
            this.carBox.Sorted = true;
            this.carBox.TabIndex = 0;
            this.carBox.SelectedIndexChanged += new System.EventHandler(this.carBox_SelectedValueChanged);
            // 
            // set_path_button
            // 
            this.set_path_button.Location = new System.Drawing.Point(16, 4);
            this.set_path_button.Name = "set_path_button";
            this.set_path_button.Size = new System.Drawing.Size(110, 23);
            this.set_path_button.TabIndex = 1;
            this.set_path_button.Text = "Set AC folder";
            this.set_path_button.UseVisualStyleBackColor = true;
            this.set_path_button.Click += new System.EventHandler(this.Set_Assetto_Corsa_Path);
            // 
            // label_path
            // 
            this.label_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label_path.Location = new System.Drawing.Point(132, 7);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(305, 20);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "assetto corsa folder path";
            // 
            // picbox_car
            // 
            this.picbox_car.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox_car.Location = new System.Drawing.Point(20, 66);
            this.picbox_car.Name = "picbox_car";
            this.picbox_car.Size = new System.Drawing.Size(417, 229);
            this.picbox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_car.TabIndex = 3;
            this.picbox_car.TabStop = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.EnginePage);
            this.tabs.Controls.Add(this.DriveTrainPage);
            this.tabs.Controls.Add(this.EngineSwapPage);
            this.tabs.Location = new System.Drawing.Point(478, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(567, 506);
            this.tabs.TabIndex = 4;
            // 
            // EnginePage
            // 
            this.EnginePage.Controls.Add(this.engineTextBox);
            this.EnginePage.Enabled = false;
            this.EnginePage.Location = new System.Drawing.Point(4, 22);
            this.EnginePage.Name = "EnginePage";
            this.EnginePage.Padding = new System.Windows.Forms.Padding(3);
            this.EnginePage.Size = new System.Drawing.Size(559, 480);
            this.EnginePage.TabIndex = 0;
            this.EnginePage.Text = "Engine";
            this.EnginePage.UseVisualStyleBackColor = true;
            // 
            // engineTextBox
            // 
            this.engineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engineTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.engineTextBox.Location = new System.Drawing.Point(0, -1);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.ReadOnly = true;
            this.engineTextBox.ShortcutsEnabled = false;
            this.engineTextBox.Size = new System.Drawing.Size(558, 480);
            this.engineTextBox.TabIndex = 0;
            this.engineTextBox.Text = "";
            // 
            // DriveTrainPage
            // 
            this.DriveTrainPage.Controls.Add(this.drivetrainTextBox);
            this.DriveTrainPage.Enabled = false;
            this.DriveTrainPage.Location = new System.Drawing.Point(4, 22);
            this.DriveTrainPage.Name = "DriveTrainPage";
            this.DriveTrainPage.Padding = new System.Windows.Forms.Padding(3);
            this.DriveTrainPage.Size = new System.Drawing.Size(559, 480);
            this.DriveTrainPage.TabIndex = 2;
            this.DriveTrainPage.Text = "Drivetrain";
            this.DriveTrainPage.UseVisualStyleBackColor = true;
            // 
            // drivetrainTextBox
            // 
            this.drivetrainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drivetrainTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.drivetrainTextBox.Location = new System.Drawing.Point(0, 0);
            this.drivetrainTextBox.Name = "drivetrainTextBox";
            this.drivetrainTextBox.ReadOnly = true;
            this.drivetrainTextBox.ShortcutsEnabled = false;
            this.drivetrainTextBox.Size = new System.Drawing.Size(558, 480);
            this.drivetrainTextBox.TabIndex = 1;
            this.drivetrainTextBox.Text = "";
            // 
            // EngineSwapPage
            // 
            this.EngineSwapPage.Controls.Add(this.Comment1);
            this.EngineSwapPage.Controls.Add(this.CarBox2);
            this.EngineSwapPage.Enabled = false;
            this.EngineSwapPage.Location = new System.Drawing.Point(4, 22);
            this.EngineSwapPage.Name = "EngineSwapPage";
            this.EngineSwapPage.Padding = new System.Windows.Forms.Padding(3);
            this.EngineSwapPage.Size = new System.Drawing.Size(559, 480);
            this.EngineSwapPage.TabIndex = 3;
            this.EngineSwapPage.Text = " Engine Swap";
            this.EngineSwapPage.UseVisualStyleBackColor = true;
            // 
            // Comment1
            // 
            this.Comment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Comment1.Location = new System.Drawing.Point(15, 3);
            this.Comment1.Name = "Comment1";
            this.Comment1.Size = new System.Drawing.Size(538, 23);
            this.Comment1.TabIndex = 9;
            this.Comment1.Text = "Choose the car which engine you want to swap:";
            this.Comment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarBox2
            // 
            this.CarBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CarBox2.FormattingEnabled = true;
            this.CarBox2.Location = new System.Drawing.Point(15, 29);
            this.CarBox2.Name = "CarBox2";
            this.CarBox2.Size = new System.Drawing.Size(538, 21);
            this.CarBox2.TabIndex = 8;
            // 
            // TuneThisBtn
            // 
            this.TuneThisBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TuneThisBtn.Location = new System.Drawing.Point(16, 347);
            this.TuneThisBtn.Name = "TuneThisBtn";
            this.TuneThisBtn.Size = new System.Drawing.Size(194, 43);
            this.TuneThisBtn.TabIndex = 5;
            this.TuneThisBtn.Text = "Tune this";
            this.TuneThisBtn.UseVisualStyleBackColor = true;
            this.TuneThisBtn.Click += new System.EventHandler(this.TuneThisBtn_Click);
            // 
            // CreateChildBtn
            // 
            this.CreateChildBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CreateChildBtn.Location = new System.Drawing.Point(243, 347);
            this.CreateChildBtn.Name = "CreateChildBtn";
            this.CreateChildBtn.Size = new System.Drawing.Size(194, 43);
            this.CreateChildBtn.TabIndex = 6;
            this.CreateChildBtn.Text = "Create a child tune";
            this.CreateChildBtn.UseVisualStyleBackColor = true;
            this.CreateChildBtn.Click += new System.EventHandler(this.CreateChildBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 23);
            this.label1.TabIndex = 7;
            this.label1.Visible = false;
            // 
            // newTuneNameTextBox
            // 
            this.newTuneNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newTuneNameTextBox.Location = new System.Drawing.Point(16, 323);
            this.newTuneNameTextBox.Name = "newTuneNameTextBox";
            this.newTuneNameTextBox.Size = new System.Drawing.Size(417, 20);
            this.newTuneNameTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(16, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter new tune name or edit current car";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newCarNameTextBox
            // 
            this.newCarNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCarNameTextBox.Location = new System.Drawing.Point(16, 444);
            this.newCarNameTextBox.Name = "newCarNameTextBox";
            this.newCarNameTextBox.Size = new System.Drawing.Size(421, 20);
            this.newCarNameTextBox.TabIndex = 10;
            // 
            // createNewCarBtn
            // 
            this.createNewCarBtn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.createNewCarBtn.Location = new System.Drawing.Point(16, 470);
            this.createNewCarBtn.Name = "createNewCarBtn";
            this.createNewCarBtn.Size = new System.Drawing.Size(421, 43);
            this.createNewCarBtn.TabIndex = 11;
            this.createNewCarBtn.Text = "Create New Car";
            this.createNewCarBtn.UseVisualStyleBackColor = true;
            this.createNewCarBtn.Click += new System.EventHandler(this.CreateNewCarBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(16, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter name for new car";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(16, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "or";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1074, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createNewCarBtn);
            this.Controls.Add(this.newCarNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newTuneNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateChildBtn);
            this.Controls.Add(this.TuneThisBtn);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.picbox_car);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.set_path_button);
            this.Controls.Add(this.carBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(1090, 592);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picbox_car)).EndInit();
            this.tabs.ResumeLayout(false);
            this.EnginePage.ResumeLayout(false);
            this.DriveTrainPage.ResumeLayout(false);
            this.EngineSwapPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.TextBox newTuneNameTextBox;

        private System.Windows.Forms.Button createNewCarBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox newCarNameTextBox;
        
        private System.Windows.Forms.RichTextBox engineTextBox;

        private System.Windows.Forms.RichTextBox drivetrainTextBox;

        private System.Windows.Forms.ComboBox CarBox2;

        private System.Windows.Forms.Label Comment1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TabPage EngineSwapPage;
        

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolTip tooltp;

        private System.Windows.Forms.Button CreateChildBtn;

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage EnginePage;
        private System.Windows.Forms.TabPage DriveTrainPage;
        private System.Windows.Forms.Button TuneThisBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        private System.Windows.Forms.ComboBox carBox;

        private System.Windows.Forms.PictureBox picbox_car;

        private System.Windows.Forms.Button set_path_button;
        private System.Windows.Forms.Label label_path;
        
        public String AssettoCorsaFolderPath = "";

        #endregion
    }
}