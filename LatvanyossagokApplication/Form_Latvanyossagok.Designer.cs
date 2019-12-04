namespace LatvanyossagokApplication
{
    partial class Form_Latvanyossagok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Latvanyossagok));
            this.groupBox_Varosok = new System.Windows.Forms.GroupBox();
            this.panel_Varosadatok = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Cimer_feltoltese = new System.Windows.Forms.Button();
            this.button_Varos_Delete = new System.Windows.Forms.Button();
            this.pictureBox_Cimer = new System.Windows.Forms.PictureBox();
            this.label_Varosnev = new System.Windows.Forms.Label();
            this.textBox_Varosnev = new System.Windows.Forms.TextBox();
            this.numeric_Lakossag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Varos_Insert = new System.Windows.Forms.Button();
            this.button_Varos_Update = new System.Windows.Forms.Button();
            this.listBox_Varosok = new System.Windows.Forms.ListBox();
            this.groupBox_Latnivalok = new System.Windows.Forms.GroupBox();
            this.panel_Latvanyossagadatok = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_Latvanyossag_ar = new System.Windows.Forms.NumericUpDown();
            this.button_Latvanyossag_Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Latvanyossag_Update = new System.Windows.Forms.Button();
            this.textBox_Nevezetesseg_leiras = new System.Windows.Forms.TextBox();
            this.button_Latvanyossag_Delete = new System.Windows.Forms.Button();
            this.textBox_nevezetesseg = new System.Windows.Forms.TextBox();
            this.label_Varos_nevezetesseg = new System.Windows.Forms.Label();
            this.listBox_Latvanyossagok = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_Varosok.SuspendLayout();
            this.panel_Varosadatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).BeginInit();
            this.groupBox_Latnivalok.SuspendLayout();
            this.panel_Latvanyossagadatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Latvanyossag_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Varosok
            // 
            this.groupBox_Varosok.Controls.Add(this.panel_Varosadatok);
            this.groupBox_Varosok.Controls.Add(this.listBox_Varosok);
            this.groupBox_Varosok.Location = new System.Drawing.Point(13, 13);
            this.groupBox_Varosok.Name = "groupBox_Varosok";
            this.groupBox_Varosok.Size = new System.Drawing.Size(479, 425);
            this.groupBox_Varosok.TabIndex = 0;
            this.groupBox_Varosok.TabStop = false;
            this.groupBox_Varosok.Text = "Városok";
            // 
            // panel_Varosadatok
            // 
            this.panel_Varosadatok.Controls.Add(this.label5);
            this.panel_Varosadatok.Controls.Add(this.button_Cimer_feltoltese);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Delete);
            this.panel_Varosadatok.Controls.Add(this.pictureBox_Cimer);
            this.panel_Varosadatok.Controls.Add(this.label_Varosnev);
            this.panel_Varosadatok.Controls.Add(this.textBox_Varosnev);
            this.panel_Varosadatok.Controls.Add(this.numeric_Lakossag);
            this.panel_Varosadatok.Controls.Add(this.label1);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Insert);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Update);
            this.panel_Varosadatok.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Varosadatok.Location = new System.Drawing.Point(276, 16);
            this.panel_Varosadatok.Name = "panel_Varosadatok";
            this.panel_Varosadatok.Size = new System.Drawing.Size(200, 406);
            this.panel_Varosadatok.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "fő";
            // 
            // button_Cimer_feltoltese
            // 
            this.button_Cimer_feltoltese.Location = new System.Drawing.Point(16, 365);
            this.button_Cimer_feltoltese.Name = "button_Cimer_feltoltese";
            this.button_Cimer_feltoltese.Size = new System.Drawing.Size(171, 23);
            this.button_Cimer_feltoltese.TabIndex = 5;
            this.button_Cimer_feltoltese.Text = "Cimer feltöltése";
            this.button_Cimer_feltoltese.UseVisualStyleBackColor = true;
            this.button_Cimer_feltoltese.Click += new System.EventHandler(this.button_Cimer_feltoltese_Click);
            // 
            // button_Varos_Delete
            // 
            this.button_Varos_Delete.Location = new System.Drawing.Point(12, 187);
            this.button_Varos_Delete.Name = "button_Varos_Delete";
            this.button_Varos_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Delete.TabIndex = 5;
            this.button_Varos_Delete.Text = "Kiválasztott törlése";
            this.button_Varos_Delete.UseVisualStyleBackColor = true;
            this.button_Varos_Delete.Click += new System.EventHandler(this.button_Varos_Delete_Click);
            // 
            // pictureBox_Cimer
            // 
            this.pictureBox_Cimer.Location = new System.Drawing.Point(30, 228);
            this.pictureBox_Cimer.Name = "pictureBox_Cimer";
            this.pictureBox_Cimer.Size = new System.Drawing.Size(138, 122);
            this.pictureBox_Cimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Cimer.TabIndex = 11;
            this.pictureBox_Cimer.TabStop = false;
            // 
            // label_Varosnev
            // 
            this.label_Varosnev.AutoSize = true;
            this.label_Varosnev.Location = new System.Drawing.Point(9, 7);
            this.label_Varosnev.Name = "label_Varosnev";
            this.label_Varosnev.Size = new System.Drawing.Size(70, 13);
            this.label_Varosnev.TabIndex = 1;
            this.label_Varosnev.Text = "A város neve";
            // 
            // textBox_Varosnev
            // 
            this.textBox_Varosnev.Location = new System.Drawing.Point(9, 24);
            this.textBox_Varosnev.Name = "textBox_Varosnev";
            this.textBox_Varosnev.Size = new System.Drawing.Size(174, 20);
            this.textBox_Varosnev.TabIndex = 1;
            // 
            // numeric_Lakossag
            // 
            this.numeric_Lakossag.Location = new System.Drawing.Point(48, 82);
            this.numeric_Lakossag.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numeric_Lakossag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Lakossag.Name = "numeric_Lakossag";
            this.numeric_Lakossag.Size = new System.Drawing.Size(120, 20);
            this.numeric_Lakossag.TabIndex = 2;
            this.numeric_Lakossag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_Lakossag.ThousandsSeparator = true;
            this.numeric_Lakossag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A város lakossága";
            // 
            // button_Varos_Insert
            // 
            this.button_Varos_Insert.Location = new System.Drawing.Point(12, 120);
            this.button_Varos_Insert.Name = "button_Varos_Insert";
            this.button_Varos_Insert.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Insert.TabIndex = 3;
            this.button_Varos_Insert.Text = "Város rögzítése";
            this.button_Varos_Insert.UseVisualStyleBackColor = true;
            this.button_Varos_Insert.Click += new System.EventHandler(this.button_Varos_Insert_Click);
            // 
            // button_Varos_Update
            // 
            this.button_Varos_Update.Location = new System.Drawing.Point(12, 151);
            this.button_Varos_Update.Name = "button_Varos_Update";
            this.button_Varos_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Update.TabIndex = 4;
            this.button_Varos_Update.Text = "Kiválasztott módosítása";
            this.button_Varos_Update.UseVisualStyleBackColor = true;
            this.button_Varos_Update.Click += new System.EventHandler(this.button_Varos_Update_Click);
            // 
            // listBox_Varosok
            // 
            this.listBox_Varosok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Varosok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Varosok.FormattingEnabled = true;
            this.listBox_Varosok.Location = new System.Drawing.Point(3, 16);
            this.listBox_Varosok.Name = "listBox_Varosok";
            this.listBox_Varosok.Size = new System.Drawing.Size(384, 406);
            this.listBox_Varosok.TabIndex = 0;
            this.listBox_Varosok.SelectedIndexChanged += new System.EventHandler(this.listBox_Varosok_SelectedIndexChanged);
            // 
            // groupBox_Latnivalok
            // 
            this.groupBox_Latnivalok.Controls.Add(this.panel_Latvanyossagadatok);
            this.groupBox_Latnivalok.Controls.Add(this.listBox_Latvanyossagok);
            this.groupBox_Latnivalok.Location = new System.Drawing.Point(521, 12);
            this.groupBox_Latnivalok.Name = "groupBox_Latnivalok";
            this.groupBox_Latnivalok.Size = new System.Drawing.Size(580, 425);
            this.groupBox_Latnivalok.TabIndex = 6;
            this.groupBox_Latnivalok.TabStop = false;
            this.groupBox_Latnivalok.Text = "A város látnivalói";
            // 
            // panel_Latvanyossagadatok
            // 
            this.panel_Latvanyossagadatok.Controls.Add(this.label4);
            this.panel_Latvanyossagadatok.Controls.Add(this.label2);
            this.panel_Latvanyossagadatok.Controls.Add(this.numeric_Latvanyossag_ar);
            this.panel_Latvanyossagadatok.Controls.Add(this.button_Latvanyossag_Insert);
            this.panel_Latvanyossagadatok.Controls.Add(this.label3);
            this.panel_Latvanyossagadatok.Controls.Add(this.button_Latvanyossag_Update);
            this.panel_Latvanyossagadatok.Controls.Add(this.textBox_Nevezetesseg_leiras);
            this.panel_Latvanyossagadatok.Controls.Add(this.button_Latvanyossag_Delete);
            this.panel_Latvanyossagadatok.Controls.Add(this.textBox_nevezetesseg);
            this.panel_Latvanyossagadatok.Controls.Add(this.label_Varos_nevezetesseg);
            this.panel_Latvanyossagadatok.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Latvanyossagadatok.Location = new System.Drawing.Point(338, 16);
            this.panel_Latvanyossagadatok.Name = "panel_Latvanyossagadatok";
            this.panel_Latvanyossagadatok.Size = new System.Drawing.Size(239, 406);
            this.panel_Latvanyossagadatok.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ft";
            // 
            // numeric_Latvanyossag_ar
            // 
            this.numeric_Latvanyossag_ar.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_Latvanyossag_ar.Location = new System.Drawing.Point(66, 229);
            this.numeric_Latvanyossag_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_Latvanyossag_ar.Name = "numeric_Latvanyossag_ar";
            this.numeric_Latvanyossag_ar.Size = new System.Drawing.Size(118, 20);
            this.numeric_Latvanyossag_ar.TabIndex = 13;
            this.numeric_Latvanyossag_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_Latvanyossag_ar.ThousandsSeparator = true;
            // 
            // button_Latvanyossag_Insert
            // 
            this.button_Latvanyossag_Insert.Location = new System.Drawing.Point(36, 264);
            this.button_Latvanyossag_Insert.Name = "button_Latvanyossag_Insert";
            this.button_Latvanyossag_Insert.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Insert.TabIndex = 10;
            this.button_Latvanyossag_Insert.Text = "Látványosság rögzítése";
            this.button_Latvanyossag_Insert.UseVisualStyleBackColor = true;
            this.button_Latvanyossag_Insert.Click += new System.EventHandler(this.button_Latvanyossag_Insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nevezetesség leírása";
            // 
            // button_Latvanyossag_Update
            // 
            this.button_Latvanyossag_Update.Location = new System.Drawing.Point(36, 304);
            this.button_Latvanyossag_Update.Name = "button_Latvanyossag_Update";
            this.button_Latvanyossag_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Update.TabIndex = 11;
            this.button_Latvanyossag_Update.Text = "Kiválasztott módosítása";
            this.button_Latvanyossag_Update.UseVisualStyleBackColor = true;
            // 
            // textBox_Nevezetesseg_leiras
            // 
            this.textBox_Nevezetesseg_leiras.Location = new System.Drawing.Point(33, 82);
            this.textBox_Nevezetesseg_leiras.Multiline = true;
            this.textBox_Nevezetesseg_leiras.Name = "textBox_Nevezetesseg_leiras";
            this.textBox_Nevezetesseg_leiras.Size = new System.Drawing.Size(174, 126);
            this.textBox_Nevezetesseg_leiras.TabIndex = 9;
            // 
            // button_Latvanyossag_Delete
            // 
            this.button_Latvanyossag_Delete.Location = new System.Drawing.Point(36, 343);
            this.button_Latvanyossag_Delete.Name = "button_Latvanyossag_Delete";
            this.button_Latvanyossag_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Delete.TabIndex = 12;
            this.button_Latvanyossag_Delete.Text = "Törlés";
            this.button_Latvanyossag_Delete.UseVisualStyleBackColor = true;
            // 
            // textBox_nevezetesseg
            // 
            this.textBox_nevezetesseg.Location = new System.Drawing.Point(33, 26);
            this.textBox_nevezetesseg.Name = "textBox_nevezetesseg";
            this.textBox_nevezetesseg.Size = new System.Drawing.Size(174, 20);
            this.textBox_nevezetesseg.TabIndex = 6;
            // 
            // label_Varos_nevezetesseg
            // 
            this.label_Varos_nevezetesseg.AutoSize = true;
            this.label_Varos_nevezetesseg.Location = new System.Drawing.Point(33, 8);
            this.label_Varos_nevezetesseg.Name = "label_Varos_nevezetesseg";
            this.label_Varos_nevezetesseg.Size = new System.Drawing.Size(118, 13);
            this.label_Varos_nevezetesseg.TabIndex = 7;
            this.label_Varos_nevezetesseg.Text = "A város nevezetessége";
            // 
            // listBox_Latvanyossagok
            // 
            this.listBox_Latvanyossagok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Latvanyossagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Latvanyossagok.FormattingEnabled = true;
            this.listBox_Latvanyossagok.Location = new System.Drawing.Point(3, 16);
            this.listBox_Latvanyossagok.Name = "listBox_Latvanyossagok";
            this.listBox_Latvanyossagok.Size = new System.Drawing.Size(325, 406);
            this.listBox_Latvanyossagok.TabIndex = 0;
            this.listBox_Latvanyossagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Latvanyossagok_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Latvanyossagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.groupBox_Latnivalok);
            this.Controls.Add(this.groupBox_Varosok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Latvanyossagok";
            this.Text = "LatvanyossagokApplication";
            this.Load += new System.EventHandler(this.Form_Latvanyossagok_Load);
            this.groupBox_Varosok.ResumeLayout(false);
            this.panel_Varosadatok.ResumeLayout(false);
            this.panel_Varosadatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).EndInit();
            this.groupBox_Latnivalok.ResumeLayout(false);
            this.panel_Latvanyossagadatok.ResumeLayout(false);
            this.panel_Latvanyossagadatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Latvanyossag_ar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Varosok;
        private System.Windows.Forms.ListBox listBox_Varosok;
        private System.Windows.Forms.Label label_Varosnev;
        private System.Windows.Forms.TextBox textBox_Varosnev;
        private System.Windows.Forms.NumericUpDown numeric_Lakossag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Varos_Insert;
        private System.Windows.Forms.Button button_Varos_Update;
        private System.Windows.Forms.Button button_Varos_Delete;
        private System.Windows.Forms.GroupBox groupBox_Latnivalok;
        private System.Windows.Forms.ListBox listBox_Latvanyossagok;
        private System.Windows.Forms.Label label_Varos_nevezetesseg;
        private System.Windows.Forms.TextBox textBox_nevezetesseg;
        private System.Windows.Forms.TextBox textBox_Nevezetesseg_leiras;
        private System.Windows.Forms.Button button_Latvanyossag_Insert;
        private System.Windows.Forms.Button button_Latvanyossag_Update;
        private System.Windows.Forms.Button button_Latvanyossag_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_Cimer;
        private System.Windows.Forms.Panel panel_Varosadatok;
        private System.Windows.Forms.Panel panel_Latvanyossagadatok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_Latvanyossag_ar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Cimer_feltoltese;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

