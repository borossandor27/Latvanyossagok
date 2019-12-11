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
            this.groupBox_Latnivalok = new System.Windows.Forms.GroupBox();
            this.panel_Latvanyossagadatok = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numeric_Latvanyossag_ar = new System.Windows.Forms.NumericUpDown();
            this.button_Latvanyossag_Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Latvanyossag_Update = new System.Windows.Forms.Button();
            this.textBox_Nevezetesseg_leiras = new System.Windows.Forms.TextBox();
            this.button_Varosok_form_view = new System.Windows.Forms.Button();
            this.button_Latvanyossag_Delete = new System.Windows.Forms.Button();
            this.textBox_nevezetesseg = new System.Windows.Forms.TextBox();
            this.label_Varos_nevezetesseg = new System.Windows.Forms.Label();
            this.listBox_Latvanyossagok = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_Varosnev = new System.Windows.Forms.Label();
            this.panel_Varosnev = new System.Windows.Forms.Panel();
            this.groupBox_Latnivalok.SuspendLayout();
            this.panel_Latvanyossagadatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Latvanyossag_ar)).BeginInit();
            this.panel_Varosnev.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Latnivalok
            // 
            this.groupBox_Latnivalok.Controls.Add(this.panel_Latvanyossagadatok);
            this.groupBox_Latnivalok.Controls.Add(this.listBox_Latvanyossagok);
            this.groupBox_Latnivalok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Latnivalok.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Latnivalok.Name = "groupBox_Latnivalok";
            this.groupBox_Latnivalok.Size = new System.Drawing.Size(618, 505);
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
            this.panel_Latvanyossagadatok.Controls.Add(this.button_Varosok_form_view);
            this.panel_Latvanyossagadatok.Controls.Add(this.button_Latvanyossag_Delete);
            this.panel_Latvanyossagadatok.Controls.Add(this.textBox_nevezetesseg);
            this.panel_Latvanyossagadatok.Controls.Add(this.label_Varos_nevezetesseg);
            this.panel_Latvanyossagadatok.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Latvanyossagadatok.Location = new System.Drawing.Point(376, 16);
            this.panel_Latvanyossagadatok.Name = "panel_Latvanyossagadatok";
            this.panel_Latvanyossagadatok.Size = new System.Drawing.Size(239, 486);
            this.panel_Latvanyossagadatok.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ár";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 304);
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
            this.numeric_Latvanyossag_ar.Location = new System.Drawing.Point(68, 302);
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
            this.button_Latvanyossag_Insert.Location = new System.Drawing.Point(37, 353);
            this.button_Latvanyossag_Insert.Name = "button_Latvanyossag_Insert";
            this.button_Latvanyossag_Insert.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Insert.TabIndex = 10;
            this.button_Latvanyossag_Insert.Text = "Új látványosság rögzítése";
            this.button_Latvanyossag_Insert.UseVisualStyleBackColor = true;
            this.button_Latvanyossag_Insert.Click += new System.EventHandler(this.button_Latvanyossag_Insert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nevezetesség leírása";
            // 
            // button_Latvanyossag_Update
            // 
            this.button_Latvanyossag_Update.Location = new System.Drawing.Point(38, 392);
            this.button_Latvanyossag_Update.Name = "button_Latvanyossag_Update";
            this.button_Latvanyossag_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Update.TabIndex = 11;
            this.button_Latvanyossag_Update.Text = "Kiválasztott módosítása";
            this.button_Latvanyossag_Update.UseVisualStyleBackColor = true;
            // 
            // textBox_Nevezetesseg_leiras
            // 
            this.textBox_Nevezetesseg_leiras.Location = new System.Drawing.Point(35, 155);
            this.textBox_Nevezetesseg_leiras.Multiline = true;
            this.textBox_Nevezetesseg_leiras.Name = "textBox_Nevezetesseg_leiras";
            this.textBox_Nevezetesseg_leiras.Size = new System.Drawing.Size(174, 126);
            this.textBox_Nevezetesseg_leiras.TabIndex = 9;
            // 
            // button_Varosok_form_view
            // 
            this.button_Varosok_form_view.BackColor = System.Drawing.Color.LightGreen;
            this.button_Varosok_form_view.Image = global::LatvanyossagokApplication.Properties.Resources.back_icon;
            this.button_Varosok_form_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Varosok_form_view.Location = new System.Drawing.Point(37, 27);
            this.button_Varosok_form_view.Name = "button_Varosok_form_view";
            this.button_Varosok_form_view.Size = new System.Drawing.Size(171, 23);
            this.button_Varosok_form_view.TabIndex = 12;
            this.button_Varosok_form_view.Text = "Vissza a városokhoz";
            this.button_Varosok_form_view.UseVisualStyleBackColor = false;
            this.button_Varosok_form_view.Click += new System.EventHandler(this.button_Varosok_form_view_Click);
            this.button_Varosok_form_view.MouseEnter += new System.EventHandler(this.button_Varosok_form_view_MouseEnter);
            this.button_Varosok_form_view.MouseLeave += new System.EventHandler(this.button_Varosok_form_view_MouseLeave);
            // 
            // button_Latvanyossag_Delete
            // 
            this.button_Latvanyossag_Delete.Location = new System.Drawing.Point(38, 431);
            this.button_Latvanyossag_Delete.Name = "button_Latvanyossag_Delete";
            this.button_Latvanyossag_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Delete.TabIndex = 12;
            this.button_Latvanyossag_Delete.Text = "Törlés";
            this.button_Latvanyossag_Delete.UseVisualStyleBackColor = true;
            // 
            // textBox_nevezetesseg
            // 
            this.textBox_nevezetesseg.Location = new System.Drawing.Point(35, 99);
            this.textBox_nevezetesseg.Name = "textBox_nevezetesseg";
            this.textBox_nevezetesseg.Size = new System.Drawing.Size(174, 20);
            this.textBox_nevezetesseg.TabIndex = 6;
            // 
            // label_Varos_nevezetesseg
            // 
            this.label_Varos_nevezetesseg.AutoSize = true;
            this.label_Varos_nevezetesseg.Location = new System.Drawing.Point(35, 81);
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
            this.listBox_Latvanyossagok.Size = new System.Drawing.Size(325, 486);
            this.listBox_Latvanyossagok.TabIndex = 0;
            this.listBox_Latvanyossagok.SelectedIndexChanged += new System.EventHandler(this.listBox_Latvanyossagok_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_Varosnev
            // 
            this.label_Varosnev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Varosnev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Varosnev.Location = new System.Drawing.Point(0, 0);
            this.label_Varosnev.Name = "label_Varosnev";
            this.label_Varosnev.Size = new System.Drawing.Size(618, 37);
            this.label_Varosnev.TabIndex = 14;
            this.label_Varosnev.Text = "label1";
            this.label_Varosnev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Varosnev
            // 
            this.panel_Varosnev.Controls.Add(this.label_Varosnev);
            this.panel_Varosnev.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Varosnev.Location = new System.Drawing.Point(0, 0);
            this.panel_Varosnev.Name = "panel_Varosnev";
            this.panel_Varosnev.Size = new System.Drawing.Size(618, 37);
            this.panel_Varosnev.TabIndex = 14;
            // 
            // Form_Latvanyossagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Varosnev);
            this.Controls.Add(this.groupBox_Latnivalok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Latvanyossagok";
            this.Text = "LatvanyossagokApplication";
            this.Activated += new System.EventHandler(this.Form_Latvanyossagok_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Latvanyossagok_FormClosed);
            this.groupBox_Latnivalok.ResumeLayout(false);
            this.panel_Latvanyossagadatok.ResumeLayout(false);
            this.panel_Latvanyossagadatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Latvanyossag_ar)).EndInit();
            this.panel_Varosnev.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Latnivalok;
        private System.Windows.Forms.ListBox listBox_Latvanyossagok;
        private System.Windows.Forms.Label label_Varos_nevezetesseg;
        private System.Windows.Forms.TextBox textBox_nevezetesseg;
        private System.Windows.Forms.TextBox textBox_Nevezetesseg_leiras;
        private System.Windows.Forms.Button button_Latvanyossag_Insert;
        private System.Windows.Forms.Button button_Latvanyossag_Update;
        private System.Windows.Forms.Button button_Latvanyossag_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Latvanyossagadatok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_Latvanyossag_ar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Varosok_form_view;
        private System.Windows.Forms.Label label_Varosnev;
        private System.Windows.Forms.Panel panel_Varosnev;
    }
}

