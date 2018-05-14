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
            this.classBox = new System.Windows.Forms.TextBox();
            this.lvlBox = new System.Windows.Forms.TextBox();
            this.expBox = new System.Windows.Forms.TextBox();
            this.hpBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // strBox
            // 
            this.strBox.Location = new System.Drawing.Point(130, 12);
            this.strBox.Name = "strBox";
            this.strBox.ReadOnly = true;
            this.strBox.Size = new System.Drawing.Size(49, 20);
            this.strBox.TabIndex = 0;
            this.strBox.Text = "Str ";
            this.strBox.TextChanged += new System.EventHandler(this.strBox_TextChanged);
            // 
            // magBox
            // 
            this.magBox.Location = new System.Drawing.Point(130, 38);
            this.magBox.Name = "magBox";
            this.magBox.ReadOnly = true;
            this.magBox.Size = new System.Drawing.Size(49, 20);
            this.magBox.TabIndex = 1;
            this.magBox.Text = "Mag ";
            // 
            // skillBox
            // 
            this.skillBox.Location = new System.Drawing.Point(130, 64);
            this.skillBox.Name = "skillBox";
            this.skillBox.ReadOnly = true;
            this.skillBox.Size = new System.Drawing.Size(49, 20);
            this.skillBox.TabIndex = 2;
            this.skillBox.Text = "Skill ";
            this.skillBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // spdBox
            // 
            this.spdBox.Location = new System.Drawing.Point(130, 90);
            this.spdBox.Name = "spdBox";
            this.spdBox.ReadOnly = true;
            this.spdBox.Size = new System.Drawing.Size(49, 20);
            this.spdBox.TabIndex = 3;
            this.spdBox.Text = "Spd ";
            // 
            // luckBox
            // 
            this.luckBox.Location = new System.Drawing.Point(185, 12);
            this.luckBox.Name = "luckBox";
            this.luckBox.ReadOnly = true;
            this.luckBox.Size = new System.Drawing.Size(49, 20);
            this.luckBox.TabIndex = 4;
            this.luckBox.Text = "Luck ";
            // 
            // defBox
            // 
            this.defBox.Location = new System.Drawing.Point(185, 38);
            this.defBox.Name = "defBox";
            this.defBox.ReadOnly = true;
            this.defBox.Size = new System.Drawing.Size(49, 20);
            this.defBox.TabIndex = 5;
            this.defBox.Text = "Def ";
            // 
            // resBox
            // 
            this.resBox.Location = new System.Drawing.Point(185, 64);
            this.resBox.Name = "resBox";
            this.resBox.ReadOnly = true;
            this.resBox.Size = new System.Drawing.Size(49, 20);
            this.resBox.TabIndex = 6;
            this.resBox.Text = "Res ";
            // 
            // moveBox
            // 
            this.moveBox.Location = new System.Drawing.Point(185, 90);
            this.moveBox.Name = "moveBox";
            this.moveBox.ReadOnly = true;
            this.moveBox.Size = new System.Drawing.Size(49, 20);
            this.moveBox.TabIndex = 7;
            this.moveBox.Text = "Move ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // classBox
            // 
            this.classBox.Location = new System.Drawing.Point(67, 99);
            this.classBox.Name = "classBox";
            this.classBox.ReadOnly = true;
            this.classBox.Size = new System.Drawing.Size(49, 20);
            this.classBox.TabIndex = 9;
            // 
            // lvlBox
            // 
            this.lvlBox.Location = new System.Drawing.Point(12, 125);
            this.lvlBox.Name = "lvlBox";
            this.lvlBox.ReadOnly = true;
            this.lvlBox.Size = new System.Drawing.Size(49, 20);
            this.lvlBox.TabIndex = 10;
            this.lvlBox.Text = "Level ";
            // 
            // expBox
            // 
            this.expBox.Location = new System.Drawing.Point(67, 125);
            this.expBox.Name = "expBox";
            this.expBox.ReadOnly = true;
            this.expBox.Size = new System.Drawing.Size(49, 20);
            this.expBox.TabIndex = 11;
            this.expBox.Text = "Exp ";
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(12, 99);
            this.hpBox.Multiline = true;
            this.hpBox.Name = "hpBox";
            this.hpBox.ReadOnly = true;
            this.hpBox.Size = new System.Drawing.Size(49, 20);
            this.hpBox.TabIndex = 12;
            this.hpBox.Text = "HP ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.hpBox);
            this.Controls.Add(this.expBox);
            this.Controls.Add(this.lvlBox);
            this.Controls.Add(this.classBox);
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
        private System.Windows.Forms.TextBox classBox;
        private System.Windows.Forms.TextBox lvlBox;
        private System.Windows.Forms.TextBox expBox;
        private System.Windows.Forms.TextBox hpBox;
        private Character Guy;
        private Job Mercenary;
        private Stat HP = new Stat("HP", 0);
        private Stat MaxHP = new Stat("MaxHP", 0);
        private Stat Str = new Stat("Str", 0);
        private Stat Mag = new Stat("Mag", 0);
        private Stat Skill = new Stat("Skill", 0);
        private Stat Spd = new Stat("Spd", 0);
        private Stat Luck = new Stat("Luck", 0);
        private Stat Def = new Stat("Def", 0);
        private Stat Res = new Stat("Res", 0);
        private Stat MoveStat = new Stat("Move", 0);
        private List<Stat> FeStats;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

