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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // textBox1
            //
            this.textBox1.Location = new System.Drawing.Point(130, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Str";
            //
            // textBox2
            //
            this.textBox2.Location = new System.Drawing.Point(130, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Mag";
            //
            // textBox3
            //
            this.textBox3.Location = new System.Drawing.Point(130, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(49, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Skill";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            //
            // textBox4
            //
            this.textBox4.Location = new System.Drawing.Point(130, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(49, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Spd";
            //
            // textBox5
            //
            this.textBox5.Location = new System.Drawing.Point(185, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(49, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Luck";
            //
            // textBox6
            //
            this.textBox6.Location = new System.Drawing.Point(185, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(49, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Def";
            //
            // textBox7
            //
            this.textBox7.Location = new System.Drawing.Point(185, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(49, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Res";
            //
            // textBox8
            //
            this.textBox8.Location = new System.Drawing.Point(185, 90);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(49, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Move";
            //
            // pictureBox1
            //
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            //
            // textBox9
            //
            this.textBox9.Location = new System.Drawing.Point(65, 73);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 9;
            this.textBox9.Text = "Class";
            //
            // textBox10
            //
            this.textBox10.Location = new System.Drawing.Point(10, 99);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(49, 20);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "Level";
            //
            // textBox11
            //
            this.textBox11.Location = new System.Drawing.Point(65, 99);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(49, 20);
            this.textBox11.TabIndex = 11;
            this.textBox11.Text = "Exp";
            //
            // textBox12
            //
            this.textBox12.Location = new System.Drawing.Point(10, 125);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(49, 20);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "HP";
            //
            // textBox13
            //
            this.textBox13.Location = new System.Drawing.Point(10, 73);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(49, 20);
            this.textBox13.TabIndex = 13;
            this.textBox13.Text = "Name";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
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
        private Stat Move = new Stat("Move", 0);
        private List<Stat> FeStats;
    }
}

