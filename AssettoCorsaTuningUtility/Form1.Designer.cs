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
            this.idleRpmLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxBoostLable = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.maxRpmLable = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.revLimiterLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.limiterHzLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.engInertiaLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DriveTrainPage = new System.Windows.Forms.TabPage();
            this.TuneThisBtn = new System.Windows.Forms.Button();
            this.CreateChildBtn = new System.Windows.Forms.Button();
            this.tooltp = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.picbox_car)).BeginInit();
            this.tabs.SuspendLayout();
            this.EnginePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // carBox
            // 
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(16, 33);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(421, 21);
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
            this.tabs.Location = new System.Drawing.Point(478, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(567, 506);
            this.tabs.TabIndex = 4;
            // 
            // EnginePage
            // 
            this.EnginePage.Controls.Add(this.idleRpmLabel);
            this.EnginePage.Controls.Add(this.textBox1);
            this.EnginePage.Controls.Add(this.label8);
            this.EnginePage.Controls.Add(this.label7);
            this.EnginePage.Controls.Add(this.maxBoostLable);
            this.EnginePage.Controls.Add(this.textBox6);
            this.EnginePage.Controls.Add(this.maxRpmLable);
            this.EnginePage.Controls.Add(this.textBox5);
            this.EnginePage.Controls.Add(this.revLimiterLabel);
            this.EnginePage.Controls.Add(this.textBox4);
            this.EnginePage.Controls.Add(this.limiterHzLabel);
            this.EnginePage.Controls.Add(this.textBox3);
            this.EnginePage.Controls.Add(this.engInertiaLabel);
            this.EnginePage.Controls.Add(this.textBox2);
            this.EnginePage.Location = new System.Drawing.Point(4, 22);
            this.EnginePage.Name = "EnginePage";
            this.EnginePage.Padding = new System.Windows.Forms.Padding(3);
            this.EnginePage.Size = new System.Drawing.Size(559, 480);
            this.EnginePage.TabIndex = 0;
            this.EnginePage.Text = "Engine";
            this.EnginePage.UseVisualStyleBackColor = true;
            // 
            // idleRpmLabel
            // 
            this.idleRpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.idleRpmLabel.Location = new System.Drawing.Point(6, 112);
            this.idleRpmLabel.Name = "idleRpmLabel";
            this.idleRpmLabel.Size = new System.Drawing.Size(115, 18);
            this.idleRpmLabel.TabIndex = 15;
            this.idleRpmLabel.Text = "Idle rpm";
            this.idleRpmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.idleRpmLabel, "Idle rpm");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(127, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(219, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "DAMAGE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(219, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "ENGINE DATA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxBoostLable
            // 
            this.maxBoostLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.maxBoostLable.Location = new System.Drawing.Point(6, 212);
            this.maxBoostLable.Name = "maxBoostLable";
            this.maxBoostLable.Size = new System.Drawing.Size(115, 18);
            this.maxBoostLable.TabIndex = 11;
            this.maxBoostLable.Text = "Max boost";
            this.maxBoostLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.maxBoostLable, "Level of TOTAL boost before the engine starts to take damage");
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(127, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(146, 20);
            this.textBox6.TabIndex = 10;
            // 
            // maxRpmLable
            // 
            this.maxRpmLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.maxRpmLable.Location = new System.Drawing.Point(6, 184);
            this.maxRpmLable.Name = "maxRpmLable";
            this.maxRpmLable.Size = new System.Drawing.Size(115, 18);
            this.maxRpmLable.TabIndex = 9;
            this.maxRpmLable.Text = "Max rpm";
            this.maxRpmLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.maxRpmLable, "RPM at which the engine starts to take damage");
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(127, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 20);
            this.textBox5.TabIndex = 8;
            // 
            // revLimiterLabel
            // 
            this.revLimiterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.revLimiterLabel.Location = new System.Drawing.Point(6, 86);
            this.revLimiterLabel.Name = "revLimiterLabel";
            this.revLimiterLabel.Size = new System.Drawing.Size(115, 18);
            this.revLimiterLabel.TabIndex = 7;
            this.revLimiterLabel.Text = "Rev limiter";
            this.revLimiterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.revLimiterLabel, "Engine rev limiter. 0 no limiter");
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(127, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 6;
            // 
            // limiterHzLabel
            // 
            this.limiterHzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.limiterHzLabel.Location = new System.Drawing.Point(6, 60);
            this.limiterHzLabel.Name = "limiterHzLabel";
            this.limiterHzLabel.Size = new System.Drawing.Size(115, 18);
            this.limiterHzLabel.TabIndex = 5;
            this.limiterHzLabel.Text = "Limiter hz";
            this.limiterHzLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.limiterHzLabel, "Frequency of engine limiter");
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(127, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 4;
            // 
            // engInertiaLabel
            // 
            this.engInertiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.engInertiaLabel.Location = new System.Drawing.Point(6, 34);
            this.engInertiaLabel.Name = "engInertiaLabel";
            this.engInertiaLabel.Size = new System.Drawing.Size(115, 18);
            this.engInertiaLabel.TabIndex = 3;
            this.engInertiaLabel.Text = "Engine inertia";
            this.engInertiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tooltp.SetToolTip(this.engInertiaLabel, "Engine inertia");
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(127, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 2;
            // 
            // DriveTrainPage
            // 
            this.DriveTrainPage.Location = new System.Drawing.Point(4, 22);
            this.DriveTrainPage.Name = "DriveTrainPage";
            this.DriveTrainPage.Padding = new System.Windows.Forms.Padding(3);
            this.DriveTrainPage.Size = new System.Drawing.Size(559, 480);
            this.DriveTrainPage.TabIndex = 1;
            this.DriveTrainPage.Text = "Drivetrain";
            this.DriveTrainPage.UseVisualStyleBackColor = true;
            // 
            // TuneThisBtn
            // 
            this.TuneThisBtn.Location = new System.Drawing.Point(16, 309);
            this.TuneThisBtn.Name = "TuneThisBtn";
            this.TuneThisBtn.Size = new System.Drawing.Size(194, 43);
            this.TuneThisBtn.TabIndex = 5;
            this.TuneThisBtn.Text = "Tune this";
            this.TuneThisBtn.UseVisualStyleBackColor = true;
            this.TuneThisBtn.Click += new System.EventHandler(this.TuneThisBtn_Click);
            // 
            // CreateChildBtn
            // 
            this.CreateChildBtn.Location = new System.Drawing.Point(243, 309);
            this.CreateChildBtn.Name = "CreateChildBtn";
            this.CreateChildBtn.Size = new System.Drawing.Size(194, 43);
            this.CreateChildBtn.TabIndex = 6;
            this.CreateChildBtn.Text = "Create a child";
            this.CreateChildBtn.UseVisualStyleBackColor = true;
            this.CreateChildBtn.Click += new System.EventHandler(this.CreateChildBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1011, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1074, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateChildBtn);
            this.Controls.Add(this.TuneThisBtn);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.picbox_car);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.set_path_button);
            this.Controls.Add(this.carBox);
            this.Name = "Form1";
            this.Text = "Assetto Corsa Tuning Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picbox_car)).EndInit();
            this.tabs.ResumeLayout(false);
            this.EnginePage.ResumeLayout(false);
            this.EnginePage.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxBoostLable;

        private System.Windows.Forms.Label engInertiaLabel;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;
        private ToolTip tooltp;
        private System.Windows.Forms.Label limiterHzLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.Label maxRpmLable;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label revLimiterLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label idleRpmLabel;
        private System.Windows.Forms.TextBox textBox4;

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
        
        private String AssettoCorsaFolderPath = "";

        #endregion
    }
}