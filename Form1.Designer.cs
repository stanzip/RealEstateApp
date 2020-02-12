using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp3
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
            this.CommunitySelection = new System.Windows.Forms.GroupBox();
            this.SycamoreRadioBtn = new System.Windows.Forms.RadioButton();
            this.DeKalbRadioBtn = new System.Windows.Forms.RadioButton();
            this.ResidenceListBox = new System.Windows.Forms.ListBox();
            this.PersonListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToggleForSaleBtn = new System.Windows.Forms.Button();
            this.BuyBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputArea = new System.Windows.Forms.RichTextBox();
            this.CommunitySelection.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CommunitySelection
            // 
            this.CommunitySelection.Controls.Add(this.SycamoreRadioBtn);
            this.CommunitySelection.Controls.Add(this.DeKalbRadioBtn);
            this.CommunitySelection.Location = new System.Drawing.Point(16, 15);
            this.CommunitySelection.Margin = new System.Windows.Forms.Padding(4);
            this.CommunitySelection.Name = "CommunitySelection";
            this.CommunitySelection.Padding = new System.Windows.Forms.Padding(4);
            this.CommunitySelection.Size = new System.Drawing.Size(267, 123);
            this.CommunitySelection.TabIndex = 0;
            this.CommunitySelection.TabStop = false;
            this.CommunitySelection.Text = "Communities";
            // 
            // SycamoreRadioBtn
            // 
            this.SycamoreRadioBtn.AutoSize = true;
            this.SycamoreRadioBtn.Location = new System.Drawing.Point(9, 53);
            this.SycamoreRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SycamoreRadioBtn.Name = "SycamoreRadioBtn";
            this.SycamoreRadioBtn.Size = new System.Drawing.Size(92, 21);
            this.SycamoreRadioBtn.TabIndex = 1;
            this.SycamoreRadioBtn.TabStop = true;
            this.SycamoreRadioBtn.Text = "Sycamore";
            this.SycamoreRadioBtn.UseVisualStyleBackColor = true;
            this.SycamoreRadioBtn.Click += new System.EventHandler(this.SycamoreRadioBtn_Click);
            // 
            // DeKalbRadioBtn
            // 
            this.DeKalbRadioBtn.AutoSize = true;
            this.DeKalbRadioBtn.Location = new System.Drawing.Point(9, 25);
            this.DeKalbRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeKalbRadioBtn.Name = "DeKalbRadioBtn";
            this.DeKalbRadioBtn.Size = new System.Drawing.Size(75, 21);
            this.DeKalbRadioBtn.TabIndex = 0;
            this.DeKalbRadioBtn.TabStop = true;
            this.DeKalbRadioBtn.Text = "DeKalb";
            this.DeKalbRadioBtn.UseVisualStyleBackColor = true;
            this.DeKalbRadioBtn.Click += new System.EventHandler(this.DeKalbRadioBtn_Click);
            // 
            // ResidenceListBox
            // 
            this.ResidenceListBox.FormattingEnabled = true;
            this.ResidenceListBox.ItemHeight = 16;
            this.ResidenceListBox.Location = new System.Drawing.Point(920, 39);
            this.ResidenceListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResidenceListBox.Name = "ResidenceListBox";
            this.ResidenceListBox.Size = new System.Drawing.Size(245, 324);
            this.ResidenceListBox.Sorted = true;
            this.ResidenceListBox.TabIndex = 1;
            this.ResidenceListBox.SelectedIndexChanged += new System.EventHandler(this.ResidenceListBox_SelectedIndexChanged);
            // 
            // PersonListBox
            // 
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.ItemHeight = 16;
            this.PersonListBox.Location = new System.Drawing.Point(665, 39);
            this.PersonListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.Size = new System.Drawing.Size(245, 324);
            this.PersonListBox.Sorted = true;
            this.PersonListBox.TabIndex = 2;
            this.PersonListBox.SelectedIndexChanged += new System.EventHandler(this.PersonListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Person";
            // 
            // ToggleForSaleBtn
            // 
            this.ToggleForSaleBtn.Location = new System.Drawing.Point(497, 39);
            this.ToggleForSaleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ToggleForSaleBtn.Name = "ToggleForSaleBtn";
            this.ToggleForSaleBtn.Size = new System.Drawing.Size(160, 28);
            this.ToggleForSaleBtn.TabIndex = 4;
            this.ToggleForSaleBtn.Text = "Toggle For Sale";
            this.ToggleForSaleBtn.UseVisualStyleBackColor = true;
            this.ToggleForSaleBtn.Click += new System.EventHandler(this.ToggleForSaleBtn_Click);
            // 
            // BuyBtn
            // 
            this.BuyBtn.Location = new System.Drawing.Point(497, 75);
            this.BuyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.BuyBtn.Name = "BuyBtn";
            this.BuyBtn.Size = new System.Drawing.Size(160, 28);
            this.BuyBtn.TabIndex = 5;
            this.BuyBtn.Text = "Buy Property";
            this.BuyBtn.UseVisualStyleBackColor = true;
            this.BuyBtn.Click += new System.EventHandler(this.BuyBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Add Resident";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(497, 146);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 28);
            this.button4.TabIndex = 7;
            this.button4.Text = "Remove Resident";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(281, 319);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Resident";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 196);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 138);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Residence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Occupation";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(167, 283);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 12;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 89);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(339, 182);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 319);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Property";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(155, 130);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Floors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Baths";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 130);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bedrooms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Square Footage";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(159, 151);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown4.TabIndex = 20;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(83, 151);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 151);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(59, 22);
            this.numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 102);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown1.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 203);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Garage?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Apt #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Street Address";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 42);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(63, 22);
            this.textBox5.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 283);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 11;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 42);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Residence (* = For Sale)";
            // 
            // OutputArea
            // 
            this.OutputArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputArea.Enabled = false;
            this.OutputArea.Location = new System.Drawing.Point(24, 524);
            this.OutputArea.Name = "OutputArea";
            this.OutputArea.ReadOnly = true;
            this.OutputArea.Size = new System.Drawing.Size(1040, 122);
            this.OutputArea.TabIndex = 10;
            this.OutputArea.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 672);
            this.Controls.Add(this.OutputArea);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BuyBtn);
            this.Controls.Add(this.ToggleForSaleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PersonListBox);
            this.Controls.Add(this.ResidenceListBox);
            this.Controls.Add(this.CommunitySelection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Real Estate Management";
            this.CommunitySelection.ResumeLayout(false);
            this.CommunitySelection.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CommunitySelection;
        private System.Windows.Forms.RadioButton SycamoreRadioBtn;
        private System.Windows.Forms.RadioButton DeKalbRadioBtn;
        private System.Windows.Forms.ListBox ResidenceListBox;
        private System.Windows.Forms.ListBox PersonListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToggleForSaleBtn;
        private System.Windows.Forms.Button BuyBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private RichTextBox OutputArea;
    }
}

