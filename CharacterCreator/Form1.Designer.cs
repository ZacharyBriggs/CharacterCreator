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
            this.magGrowthBox = new System.Windows.Forms.TextBox();
            this.skillGrowthBox = new System.Windows.Forms.TextBox();
            this.defGrowthBox = new System.Windows.Forms.TextBox();
            this.luckGrowthBox = new System.Windows.Forms.TextBox();
            this.spdGrowthBox = new System.Windows.Forms.TextBox();
            this.resGrowthBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hpGrowthBox = new System.Windows.Forms.TextBox();
            this.maxStrBox = new System.Windows.Forms.TextBox();
            this.maxMagBox = new System.Windows.Forms.TextBox();
            this.maxSkillBox = new System.Windows.Forms.TextBox();
            this.maxSpdBox = new System.Windows.Forms.TextBox();
            this.maxLuckBox = new System.Windows.Forms.TextBox();
            this.maxDefBox = new System.Windows.Forms.TextBox();
            this.maxResBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // strBox
            //
            this.strBox.Location = new System.Drawing.Point(157, 30);
            this.strBox.Name = "strBox";
            this.strBox.Size = new System.Drawing.Size(28, 20);
            this.strBox.TabIndex = 0;
            //
            // magBox
            //
            this.magBox.Location = new System.Drawing.Point(157, 56);
            this.magBox.Name = "magBox";
            this.magBox.Size = new System.Drawing.Size(28, 20);
            this.magBox.TabIndex = 1;
            //
            // skillBox
            //
            this.skillBox.Location = new System.Drawing.Point(158, 82);
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(28, 20);
            this.skillBox.TabIndex = 2;
            //
            // spdBox
            //
            this.spdBox.Location = new System.Drawing.Point(157, 108);
            this.spdBox.Name = "spdBox";
            this.spdBox.Size = new System.Drawing.Size(28, 20);
            this.spdBox.TabIndex = 3;
            //
            // luckBox
            //
            this.luckBox.Location = new System.Drawing.Point(157, 134);
            this.luckBox.Name = "luckBox";
            this.luckBox.Size = new System.Drawing.Size(28, 20);
            this.luckBox.TabIndex = 4;
            //
            // defBox
            //
            this.defBox.Location = new System.Drawing.Point(158, 160);
            this.defBox.Name = "defBox";
            this.defBox.Size = new System.Drawing.Size(28, 20);
            this.defBox.TabIndex = 5;
            //
            // resBox
            //
            this.resBox.Location = new System.Drawing.Point(158, 186);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(28, 20);
            this.resBox.TabIndex = 6;
            //
            // moveBox
            //
            this.moveBox.Location = new System.Drawing.Point(12, 170);
            this.moveBox.Name = "moveBox";
            this.moveBox.Size = new System.Drawing.Size(104, 20);
            this.moveBox.TabIndex = 7;
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
            this.lvlBox.Location = new System.Drawing.Point(14, 144);
            this.lvlBox.Name = "lvlBox";
            this.lvlBox.Size = new System.Drawing.Size(47, 20);
            this.lvlBox.TabIndex = 10;
            //
            // expBox
            //
            this.expBox.Location = new System.Drawing.Point(67, 144);
            this.expBox.Name = "expBox";
            this.expBox.Size = new System.Drawing.Size(49, 20);
            this.expBox.TabIndex = 11;
            //
            // hpBox
            //
            this.hpBox.Location = new System.Drawing.Point(156, 4);
            this.hpBox.Multiline = true;
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(29, 20);
            this.hpBox.TabIndex = 12;
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
            this.maxHpBox.Location = new System.Drawing.Point(225, 4);
            this.maxHpBox.Name = "maxHpBox";
            this.maxHpBox.Size = new System.Drawing.Size(29, 20);
            this.maxHpBox.TabIndex = 16;
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
            this.strGrowthBox.Location = new System.Drawing.Point(191, 30);
            this.strGrowthBox.Name = "strGrowthBox";
            this.strGrowthBox.Size = new System.Drawing.Size(28, 20);
            this.strGrowthBox.TabIndex = 19;
            //
            // magGrowthBox
            //
            this.magGrowthBox.Location = new System.Drawing.Point(192, 56);
            this.magGrowthBox.Name = "magGrowthBox";
            this.magGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.magGrowthBox.TabIndex = 20;
            //
            // skillGrowthBox
            //
            this.skillGrowthBox.Location = new System.Drawing.Point(192, 82);
            this.skillGrowthBox.Name = "skillGrowthBox";
            this.skillGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.skillGrowthBox.TabIndex = 21;
            //
            // defGrowthBox
            //
            this.defGrowthBox.Location = new System.Drawing.Point(192, 160);
            this.defGrowthBox.Name = "defGrowthBox";
            this.defGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.defGrowthBox.TabIndex = 22;
            //
            // luckGrowthBox
            //
            this.luckGrowthBox.Location = new System.Drawing.Point(192, 134);
            this.luckGrowthBox.Name = "luckGrowthBox";
            this.luckGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.luckGrowthBox.TabIndex = 23;
            //
            // spdGrowthBox
            //
            this.spdGrowthBox.Location = new System.Drawing.Point(192, 108);
            this.spdGrowthBox.Name = "spdGrowthBox";
            this.spdGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.spdGrowthBox.TabIndex = 24;
            //
            // resGrowthBox
            //
            this.resGrowthBox.Location = new System.Drawing.Point(192, 186);
            this.resGrowthBox.Name = "resGrowthBox";
            this.resGrowthBox.Size = new System.Drawing.Size(27, 20);
            this.resGrowthBox.TabIndex = 26;
            //
            // nameBox
            //
            this.nameBox.Location = new System.Drawing.Point(14, 64);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(102, 20);
            this.nameBox.TabIndex = 27;
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(331, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 76);
            this.button2.TabIndex = 28;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // hpGrowthBox
            //
            this.hpGrowthBox.Location = new System.Drawing.Point(191, 4);
            this.hpGrowthBox.Name = "hpGrowthBox";
            this.hpGrowthBox.Size = new System.Drawing.Size(28, 20);
            this.hpGrowthBox.TabIndex = 30;
            //
            // maxStrBox
            //
            this.maxStrBox.Location = new System.Drawing.Point(225, 30);
            this.maxStrBox.Name = "maxStrBox";
            this.maxStrBox.Size = new System.Drawing.Size(28, 20);
            this.maxStrBox.TabIndex = 31;
            //
            // maxMagBox
            //
            this.maxMagBox.Location = new System.Drawing.Point(225, 56);
            this.maxMagBox.Name = "maxMagBox";
            this.maxMagBox.Size = new System.Drawing.Size(28, 20);
            this.maxMagBox.TabIndex = 32;
            //
            // maxSkillBox
            //
            this.maxSkillBox.Location = new System.Drawing.Point(225, 82);
            this.maxSkillBox.Name = "maxSkillBox";
            this.maxSkillBox.Size = new System.Drawing.Size(28, 20);
            this.maxSkillBox.TabIndex = 33;
            //
            // maxSpdBox
            //
            this.maxSpdBox.Location = new System.Drawing.Point(225, 108);
            this.maxSpdBox.Name = "maxSpdBox";
            this.maxSpdBox.Size = new System.Drawing.Size(28, 20);
            this.maxSpdBox.TabIndex = 34;
            //
            // maxLuckBox
            //
            this.maxLuckBox.Location = new System.Drawing.Point(225, 134);
            this.maxLuckBox.Name = "maxLuckBox";
            this.maxLuckBox.Size = new System.Drawing.Size(28, 20);
            this.maxLuckBox.TabIndex = 35;
            //
            // maxDefBox
            //
            this.maxDefBox.Location = new System.Drawing.Point(225, 160);
            this.maxDefBox.Name = "maxDefBox";
            this.maxDefBox.Size = new System.Drawing.Size(28, 20);
            this.maxDefBox.TabIndex = 36;
            //
            // maxResBox
            //
            this.maxResBox.Location = new System.Drawing.Point(225, 186);
            this.maxResBox.Name = "maxResBox";
            this.maxResBox.Size = new System.Drawing.Size(28, 20);
            this.maxResBox.TabIndex = 37;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 244);
            this.Controls.Add(this.maxResBox);
            this.Controls.Add(this.maxDefBox);
            this.Controls.Add(this.maxLuckBox);
            this.Controls.Add(this.maxSpdBox);
            this.Controls.Add(this.maxSkillBox);
            this.Controls.Add(this.maxMagBox);
            this.Controls.Add(this.maxStrBox);
            this.Controls.Add(this.hpGrowthBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.resGrowthBox);
            this.Controls.Add(this.spdGrowthBox);
            this.Controls.Add(this.luckGrowthBox);
            this.Controls.Add(this.defGrowthBox);
            this.Controls.Add(this.skillGrowthBox);
            this.Controls.Add(this.magGrowthBox);
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
        private Job Mercenary;
        private List<Character> allCharacters;
        private List<Character> loadedCharacters;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox maxHpBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox classesBox;
        private System.Windows.Forms.TextBox strGrowthBox;
        private System.Windows.Forms.TextBox magGrowthBox;
        private System.Windows.Forms.TextBox skillGrowthBox;
        private System.Windows.Forms.TextBox defGrowthBox;
        private System.Windows.Forms.TextBox luckGrowthBox;
        private System.Windows.Forms.TextBox spdGrowthBox;
        private System.Windows.Forms.TextBox resGrowthBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox hpGrowthBox;
        private System.Windows.Forms.TextBox maxStrBox;
        private System.Windows.Forms.TextBox maxMagBox;
        private System.Windows.Forms.TextBox maxSkillBox;
        private System.Windows.Forms.TextBox maxSpdBox;
        private System.Windows.Forms.TextBox maxLuckBox;
        private System.Windows.Forms.TextBox maxDefBox;
        private System.Windows.Forms.TextBox maxResBox;
    }
}

