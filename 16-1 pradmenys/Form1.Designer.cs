namespace _16_1_pradmenys
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
            this.buttonMygtukas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxReiksme = new System.Windows.Forms.TextBox();
            this.buttonGautiReiksme = new System.Windows.Forms.Button();
            this.labelReiksme = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxDuomenisSiuntimui = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMygtukas
            // 
            this.buttonMygtukas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMygtukas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonMygtukas.Location = new System.Drawing.Point(32, 19);
            this.buttonMygtukas.Name = "buttonMygtukas";
            this.buttonMygtukas.Size = new System.Drawing.Size(127, 54);
            this.buttonMygtukas.TabIndex = 0;
            this.buttonMygtukas.Text = "mygtukas";
            this.buttonMygtukas.UseVisualStyleBackColor = false;
            this.buttonMygtukas.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMygtukas);
            this.groupBox1.Location = new System.Drawing.Point(38, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "pranešimas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelReiksme);
            this.groupBox2.Controls.Add(this.buttonGautiReiksme);
            this.groupBox2.Controls.Add(this.textBoxReiksme);
            this.groupBox2.Location = new System.Drawing.Point(324, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gauti reikšme iš laukelio";
            // 
            // textBoxReiksme
            // 
            this.textBoxReiksme.Location = new System.Drawing.Point(32, 19);
            this.textBoxReiksme.Name = "textBoxReiksme";
            this.textBoxReiksme.Size = new System.Drawing.Size(287, 20);
            this.textBoxReiksme.TabIndex = 3;
            this.textBoxReiksme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonGautiReiksme
            // 
            this.buttonGautiReiksme.Location = new System.Drawing.Point(32, 46);
            this.buttonGautiReiksme.Name = "buttonGautiReiksme";
            this.buttonGautiReiksme.Size = new System.Drawing.Size(287, 23);
            this.buttonGautiReiksme.TabIndex = 4;
            this.buttonGautiReiksme.Text = "Gauti Reiksme";
            this.buttonGautiReiksme.UseVisualStyleBackColor = true;
            this.buttonGautiReiksme.Click += new System.EventHandler(this.buttonGautiReiksme_Click);
            // 
            // labelReiksme
            // 
            this.labelReiksme.AutoSize = true;
            this.labelReiksme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelReiksme.Location = new System.Drawing.Point(29, 85);
            this.labelReiksme.Name = "labelReiksme";
            this.labelReiksme.Size = new System.Drawing.Size(63, 15);
            this.labelReiksme.TabIndex = 5;
            this.labelReiksme.Text = "Reiksme";
            this.labelReiksme.Click += new System.EventHandler(this.labelReiksme_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDuomenisSiuntimui);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(324, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "siusti duomenis i kita forma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(796, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Siusti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxDuomenisSiuntimui
            // 
            this.textBoxDuomenisSiuntimui.Location = new System.Drawing.Point(32, 20);
            this.textBoxDuomenisSiuntimui.Name = "textBoxDuomenisSiuntimui";
            this.textBoxDuomenisSiuntimui.Size = new System.Drawing.Size(287, 20);
            this.textBoxDuomenisSiuntimui.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(38, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Naujas langas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rodyti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Location = new System.Drawing.Point(38, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ivesti duomenis";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ivedimas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 562);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMygtukas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelReiksme;
        private System.Windows.Forms.Button buttonGautiReiksme;
        private System.Windows.Forms.TextBox textBoxReiksme;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDuomenisSiuntimui;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

