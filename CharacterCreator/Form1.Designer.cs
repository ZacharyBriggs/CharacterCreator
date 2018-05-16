using System.Collections.Generic;

namespace CharacterCreator
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
            this.strBox = new System.Windows.Forms.TextBox();
            this.magBox = new System.Windows.Forms.TextBox();
            this.skillBox = new System.Windows.Forms.TextBox();
            this.spdBox = new System.Windows.Forms.TextBox();
            this.luckBox = new System.Windows.Forms.TextBox();
            this.defBox = new System.Windows.Forms.TextBox();
            this.resBox = new System.Windows.Forms.TextBox();
            this.moveBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvlBox = new System.Windows.Forms.TextBox();
            this.expBox = new System.Windows.Forms.TextBox();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.maxHpBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.classesBox = new System.Windows.Forms.ComboBox();
            this.strGrowthBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(144, 17);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(28, 20);
            this.strBox.TabIndex = 0;
            this.strBox.TextChanged += new System.EventHandler(this.strBox_TextChanged);
            // 
            // magBox
            // 
            this.magBox.Location = new System.Drawing.Point(144, 43);
            this.magBox.Name = "magBox";
            this.magBox.Size = new System.Drawing.Size(28, 20);
            this.magBox.TabIndex = 1;
            this.magBox.TextChanged += new System.EventHandler(this.magBox_TextChanged);
            // 
            // skillBox
            // 
            this.skillBox.Location = new System.Drawing.Point(144, 69);
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(28, 20);
            this.skillBox.TabIndex = 2;
            this.skillBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // spdBox
            // 
            this.spdBox.Location = new System.Drawing.Point(144, 95);
            this.spdBox.Name = "spdBox";
            this.spdBox.Size = new System.Drawing.Size(28, 20);
            this.spdBox.TabIndex = 3;
            this.spdBox.TextChanged += new System.EventHandler(this.spdBox_TextChanged);
            // 
            // luckBox
            // 
            this.luckBox.Location = new System.Drawing.Point(144, 121);
            this.luckBox.Name = "luckBox";
            this.luckBox.Size = new System.Drawing.Size(28, 20);
            this.luckBox.TabIndex = 4;
            this.luckBox.TextChanged += new System.EventHandler(this.luckBox_TextChanged);
            // 
            // defBox
            // 
            this.defBox.Location = new System.Drawing.Point(144, 147);
            this.defBox.Name = "defBox";
            this.defBox.Size = new System.Drawing.Size(28, 20);
            this.defBox.TabIndex = 5;
            this.defBox.TextChanged += new System.EventHandler(this.defBox_TextChanged);
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(144, 173);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(28, 20);
            this.resBox.TabIndex = 6;
            this.resBox.TextChanged += new System.EventHandler(this.resBox_TextChanged);
            // 
            // moveBox
            // 
            this.moveBox.Location = new System.Drawing.Point(144, 199);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(28, 20);
            this.moveBox.TabIndex = 7;
            this.moveBox.TextChanged += new System.EventHandler(this.moveBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lvlBox
            // 
            this.lvlBox.Location = new System.Drawing.Point(13, 170);
            this.lvlBox.Name = "lvlBox";
            this.lvlBox.Size = new System.Drawing.Size(49, 20);
            this.lvlBox.TabIndex = 10;
            this.lvlBox.TextChanged += new System.EventHandler(this.lvlBox_TextChanged);
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(68, 170);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(49, 20);
            this.expBox.TabIndex = 11;
            this.expBox.TextChanged += new System.EventHandler(this.expBox_TextChanged);
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(12, 144);
            this.hpBox.Multiline = true;
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(49, 20);
            this.hpBox.TabIndex = 12;
            this.hpBox.TextChanged += new System.EventHandler(this.hpBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(13, 196);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 23);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // maxHpBox
            // 
            this.maxHpBox.Location = new System.Drawing.Point(67, 144);
            this.maxHpBox.Name = "maxHpBox";
            this.maxHpBox.Size = new System.Drawing.Size(50, 20);
            this.maxHpBox.TabIndex = 16;
            this.maxHpBox.TextChanged += new System.EventHandler(this.maxHpBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // classesBox
            // 
            this.classesBox.FormattingEnabled = true;
            this.classesBox.Location = new System.Drawing.Point(12, 117);
            this.classesBox.Name = "classesBox";
            this.classesBox.Size = new System.Drawing.Size(104, 21);
            this.classesBox.TabIndex = 18;
            // 
            // strGrowthBox
            // 
            this.strGrowthBox.Location = new System.Drawing.Point(178, 17);
            this.strGrowthBox.Name = "strGrowthBox";
            this.strGrowthBox.Size = new System.Drawing.Size(28, 20);
            this.strGrowthBox.TabIndex = 19;
            this.strGrowthBox.TextChanged += new System.EventHandler(this.strGrowthBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(27, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(178, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 20);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(178, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 20);
            this.textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(178, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 20);
            this.textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(178, 95);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(27, 20);
            this.textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(178, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(27, 20);
            this.textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(178, 173);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(27, 20);
            this.textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(14, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(102, 20);
            this.textBox8.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 76);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.strGrowthBox);
            this.Controls.Add(this.classesBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxHpBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hpBox);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.lvlBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moveBox);
            this.Controls.Add(this.resBox);
            this.Controls.Add(this.defBox);
            this.Controls.Add(this.luckBox);
            this.Controls.Add(this.spdBox);
            this.Controls.Add(this.skillBox);
            this.Controls.Add(this.magBox);
            this.Controls.Add(this.strBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox strBox;
        private System.Windows.Forms.TextBox magBox;
        private System.Windows.Forms.TextBox skillBox;
        private System.Windows.Forms.TextBox spdBox;
        private System.Windows.Forms.TextBox luckBox;
        private System.Windows.Forms.TextBox defBox;
        private System.Windows.Forms.TextBox resBox;
        private System.Windows.Forms.TextBox moveBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lvlBox;
        private System.Windows.Forms.TextBox expBox;
        private System.Windows.Forms.TextBox hpBox;
        private Character Guy;
        private Job Mercenary;
        private List<Character> allCharacters;
        private List<Stat> FeStats;
        private List<Stat> StatGrowths;
        private List<Stat> MaxStats;
        private Dictionary<string, Character> charactersDictionary;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox maxHpBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classesBox;
        private System.Windows.Forms.TextBox strGrowthBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
    }
}

