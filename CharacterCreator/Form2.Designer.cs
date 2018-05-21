namespace CharacterCreator
{
    partial class Form2
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
            this.hpBox = new System.Windows.Forms.TextBox();
            this.hpGrowthBox = new System.Windows.Forms.TextBox();
            this.maxHpBox = new System.Windows.Forms.TextBox();
            this.SaveStat_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hpBox
            // 
            this.hpBox.Location = new System.Drawing.Point(107, 43);
            this.hpBox.Name = "hpBox";
            this.hpBox.Size = new System.Drawing.Size(46, 20);
            this.hpBox.TabIndex = 0;
            this.hpBox.TextChanged += new System.EventHandler(this.hpBox_TextChanged);
            // 
            // hpGrowthBox
            // 
            this.hpGrowthBox.Location = new System.Drawing.Point(159, 43);
            this.hpGrowthBox.Name = "hpGrowthBox";
            this.hpGrowthBox.Size = new System.Drawing.Size(46, 20);
            this.hpGrowthBox.TabIndex = 1;
            // 
            // maxHpBox
            // 
            this.maxHpBox.Location = new System.Drawing.Point(213, 43);
            this.maxHpBox.Name = "maxHpBox";
            this.maxHpBox.Size = new System.Drawing.Size(46, 20);
            this.maxHpBox.TabIndex = 2;
            // 
            // SaveStat_button
            // 
            this.SaveStat_button.Location = new System.Drawing.Point(28, 162);
            this.SaveStat_button.Name = "SaveStat_button";
            this.SaveStat_button.Size = new System.Drawing.Size(100, 50);
            this.SaveStat_button.TabIndex = 3;
            this.SaveStat_button.Text = "refresh";
            this.SaveStat_button.UseVisualStyleBackColor = true;
            this.SaveStat_button.Click += new System.EventHandler(this.SaveStat_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(46, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveStat_button);
            this.Controls.Add(this.maxHpBox);
            this.Controls.Add(this.hpGrowthBox);
            this.Controls.Add(this.hpBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hpBox;
        private System.Windows.Forms.TextBox hpGrowthBox;
        private System.Windows.Forms.TextBox maxHpBox;
        private Stat hp;
        private System.Windows.Forms.Button SaveStat_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}