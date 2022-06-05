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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.EngineSwapPage.Controls.Add(this.textBox8);
            this.EngineSwapPage.Controls.Add(this.textBox7);
            this.EngineSwapPage.Controls.Add(this.textBox6);
            this.EngineSwapPage.Controls.Add(this.textBox5);
            this.EngineSwapPage.Controls.Add(this.textBox4);
            this.EngineSwapPage.Controls.Add(this.textBox3);
            this.EngineSwapPage.Controls.Add(this.textBox2);
            this.EngineSwapPage.Controls.Add(this.textBox1);
            this.EngineSwapPage.Controls.Add(this.label13);
            this.EngineSwapPage.Controls.Add(this.label14);
            this.EngineSwapPage.Controls.Add(this.label11);
            this.EngineSwapPage.Controls.Add(this.label12);
            this.EngineSwapPage.Controls.Add(this.label9);
            this.EngineSwapPage.Controls.Add(this.label10);
            this.EngineSwapPage.Controls.Add(this.label8);
            this.EngineSwapPage.Controls.Add(this.label7);
            this.EngineSwapPage.Controls.Add(this.label6);
            this.EngineSwapPage.Controls.Add(this.label5);
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
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(439, 190);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.ShortcutsEnabled = false;
            this.textBox8.Size = new System.Drawing.Size(79, 20);
            this.textBox8.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(439, 157);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(79, 20);
            this.textBox7.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(439, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(79, 20);
            this.textBox6.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(439, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(79, 20);
            this.textBox5.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(109, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(79, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label13.Location = new System.Drawing.Point(347, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 21);
            this.label13.TabIndex = 19;
            this.label13.Text = "Turbo";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label14.Location = new System.Drawing.Point(15, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 21);
            this.label14.TabIndex = 18;
            this.label14.Text = "Turbo";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.Location = new System.Drawing.Point(347, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Idle RPM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.Location = new System.Drawing.Point(15, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Idle RPM";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.Location = new System.Drawing.Point(347, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Max RPM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label10.Location = new System.Drawing.Point(15, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Max RPM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(347, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max torque";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(15, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max torque";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(360, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "New engine";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(40, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Old engine";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Comment1
            // 
            this.Comment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
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
            this.EngineSwapPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

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