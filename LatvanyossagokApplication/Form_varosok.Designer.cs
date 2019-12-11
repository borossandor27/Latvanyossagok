namespace LatvanyossagokApplication
{
    partial class Form_varosok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_varosok));
            this.groupBox_Varosok = new System.Windows.Forms.GroupBox();
            this.panel_Varosadatok = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Cimer_feltoltese = new System.Windows.Forms.Button();
            this.button_Varos_Delete = new System.Windows.Forms.Button();
            this.label_Varosnev = new System.Windows.Forms.Label();
            this.textBox_Varosnev = new System.Windows.Forms.TextBox();
            this.numeric_Lakossag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Varos_Insert = new System.Windows.Forms.Button();
            this.button_Varos_Update = new System.Windows.Forms.Button();
            this.listBox_Varosok = new System.Windows.Forms.ListBox();
            this.button_Latvanyossagok_form_view = new System.Windows.Forms.Button();
            this.pictureBox_Cimer = new System.Windows.Forms.PictureBox();
            this.groupBox_Varosok.SuspendLayout();
            this.panel_Varosadatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cimer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Varosok
            // 
            this.groupBox_Varosok.Controls.Add(this.panel_Varosadatok);
            this.groupBox_Varosok.Controls.Add(this.listBox_Varosok);
            this.groupBox_Varosok.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Varosok.Name = "groupBox_Varosok";
            this.groupBox_Varosok.Size = new System.Drawing.Size(527, 496);
            this.groupBox_Varosok.TabIndex = 1;
            this.groupBox_Varosok.TabStop = false;
            this.groupBox_Varosok.Text = "Városok";
            // 
            // panel_Varosadatok
            // 
            this.panel_Varosadatok.Controls.Add(this.label5);
            this.panel_Varosadatok.Controls.Add(this.button_Cimer_feltoltese);
            this.panel_Varosadatok.Controls.Add(this.button_Latvanyossagok_form_view);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Delete);
            this.panel_Varosadatok.Controls.Add(this.pictureBox_Cimer);
            this.panel_Varosadatok.Controls.Add(this.label_Varosnev);
            this.panel_Varosadatok.Controls.Add(this.textBox_Varosnev);
            this.panel_Varosadatok.Controls.Add(this.numeric_Lakossag);
            this.panel_Varosadatok.Controls.Add(this.label1);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Insert);
            this.panel_Varosadatok.Controls.Add(this.button_Varos_Update);
            this.panel_Varosadatok.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Varosadatok.Location = new System.Drawing.Point(299, 16);
            this.panel_Varosadatok.Name = "panel_Varosadatok";
            this.panel_Varosadatok.Size = new System.Drawing.Size(225, 477);
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
            this.button_Cimer_feltoltese.Location = new System.Drawing.Point(12, 231);
            this.button_Cimer_feltoltese.Name = "button_Cimer_feltoltese";
            this.button_Cimer_feltoltese.Size = new System.Drawing.Size(199, 23);
            this.button_Cimer_feltoltese.TabIndex = 6;
            this.button_Cimer_feltoltese.Text = "Cimer feltöltése";
            this.button_Cimer_feltoltese.UseVisualStyleBackColor = true;
            this.button_Cimer_feltoltese.Click += new System.EventHandler(this.button_Cimer_feltoltese_Click);
            // 
            // button_Varos_Delete
            // 
            this.button_Varos_Delete.Location = new System.Drawing.Point(12, 194);
            this.button_Varos_Delete.Name = "button_Varos_Delete";
            this.button_Varos_Delete.Size = new System.Drawing.Size(199, 23);
            this.button_Varos_Delete.TabIndex = 5;
            this.button_Varos_Delete.Text = "Kiválasztott város törlése";
            this.button_Varos_Delete.UseVisualStyleBackColor = true;
            this.button_Varos_Delete.Click += new System.EventHandler(this.button_Varos_Delete_Click);
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
            this.textBox_Varosnev.Size = new System.Drawing.Size(202, 20);
            this.textBox_Varosnev.TabIndex = 1;
            this.textBox_Varosnev.TextChanged += new System.EventHandler(this.textBox_Varosnev_TextChanged);
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
            this.button_Varos_Insert.Size = new System.Drawing.Size(199, 23);
            this.button_Varos_Insert.TabIndex = 3;
            this.button_Varos_Insert.Text = "Új város rögzítése";
            this.button_Varos_Insert.UseVisualStyleBackColor = true;
            this.button_Varos_Insert.Click += new System.EventHandler(this.button_Varos_Insert_Click);
            // 
            // button_Varos_Update
            // 
            this.button_Varos_Update.Location = new System.Drawing.Point(12, 157);
            this.button_Varos_Update.Name = "button_Varos_Update";
            this.button_Varos_Update.Size = new System.Drawing.Size(199, 23);
            this.button_Varos_Update.TabIndex = 4;
            this.button_Varos_Update.Text = "Kiválasztott város módosítása";
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
            this.listBox_Varosok.Size = new System.Drawing.Size(267, 477);
            this.listBox_Varosok.TabIndex = 8;
            this.listBox_Varosok.SelectedIndexChanged += new System.EventHandler(this.listBox_Varosok_SelectedIndexChanged);
            // 
            // button_Latvanyossagok_form_view
            // 
            this.button_Latvanyossagok_form_view.BackColor = System.Drawing.Color.LightGreen;
            this.button_Latvanyossagok_form_view.Image = global::LatvanyossagokApplication.Properties.Resources.next_icon1;
            this.button_Latvanyossagok_form_view.Location = new System.Drawing.Point(12, 432);
            this.button_Latvanyossagok_form_view.Name = "button_Latvanyossagok_form_view";
            this.button_Latvanyossagok_form_view.Size = new System.Drawing.Size(199, 40);
            this.button_Latvanyossagok_form_view.TabIndex = 7;
            this.button_Latvanyossagok_form_view.Text = "Kiválasztott város látványosságai";
            this.button_Latvanyossagok_form_view.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Latvanyossagok_form_view.UseVisualStyleBackColor = false;
            this.button_Latvanyossagok_form_view.Click += new System.EventHandler(this.button_Latvanyossagok_form_view_Click);
            this.button_Latvanyossagok_form_view.MouseEnter += new System.EventHandler(this.button_Latvanyossagok_form_view_MouseEnter);
            this.button_Latvanyossagok_form_view.MouseLeave += new System.EventHandler(this.button_Latvanyossagok_form_view_MouseLeave);
            // 
            // pictureBox_Cimer
            // 
            this.pictureBox_Cimer.Location = new System.Drawing.Point(33, 274);
            this.pictureBox_Cimer.Name = "pictureBox_Cimer";
            this.pictureBox_Cimer.Size = new System.Drawing.Size(154, 139);
            this.pictureBox_Cimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Cimer.TabIndex = 11;
            this.pictureBox_Cimer.TabStop = false;
            // 
            // Form_varosok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 512);
            this.Controls.Add(this.groupBox_Varosok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_varosok";
            this.Text = "Form_varosok";
            this.Load += new System.EventHandler(this.Form_varosok_Load);
            this.groupBox_Varosok.ResumeLayout(false);
            this.panel_Varosadatok.ResumeLayout(false);
            this.panel_Varosadatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Varosok;
        private System.Windows.Forms.Panel panel_Varosadatok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Cimer_feltoltese;
        private System.Windows.Forms.Button button_Varos_Delete;
        private System.Windows.Forms.PictureBox pictureBox_Cimer;
        private System.Windows.Forms.Label label_Varosnev;
        private System.Windows.Forms.TextBox textBox_Varosnev;
        private System.Windows.Forms.NumericUpDown numeric_Lakossag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Varos_Insert;
        private System.Windows.Forms.Button button_Varos_Update;
        private System.Windows.Forms.ListBox listBox_Varosok;
        private System.Windows.Forms.Button button_Latvanyossagok_form_view;
    }
}