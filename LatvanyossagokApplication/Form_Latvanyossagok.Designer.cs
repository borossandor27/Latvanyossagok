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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_Varosok = new System.Windows.Forms.ListBox();
            this.label_Varosnev = new System.Windows.Forms.Label();
            this.textBox_Varosnev = new System.Windows.Forms.TextBox();
            this.numeric_Lakossag = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Varos_Insert = new System.Windows.Forms.Button();
            this.button_Varos_Update = new System.Windows.Forms.Button();
            this.button_Varos_Delete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_Latvanyossagok = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nevezetesseg = new System.Windows.Forms.TextBox();
            this.textBox_Nevezetesseg_leiras = new System.Windows.Forms.TextBox();
            this.button_Latvanyossag_Insert = new System.Windows.Forms.Button();
            this.button_Latvanyossag_Update = new System.Windows.Forms.Button();
            this.button_Latvanyossag_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Varosok);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Városok";
            // 
            // listBox_Varosok
            // 
            this.listBox_Varosok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Varosok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Varosok.FormattingEnabled = true;
            this.listBox_Varosok.Location = new System.Drawing.Point(3, 16);
            this.listBox_Varosok.Name = "listBox_Varosok";
            this.listBox_Varosok.Size = new System.Drawing.Size(160, 406);
            this.listBox_Varosok.TabIndex = 0;
            // 
            // label_Varosnev
            // 
            this.label_Varosnev.AutoSize = true;
            this.label_Varosnev.Location = new System.Drawing.Point(186, 24);
            this.label_Varosnev.Name = "label_Varosnev";
            this.label_Varosnev.Size = new System.Drawing.Size(70, 13);
            this.label_Varosnev.TabIndex = 1;
            this.label_Varosnev.Text = "A város neve";
            // 
            // textBox_Varosnev
            // 
            this.textBox_Varosnev.Location = new System.Drawing.Point(186, 41);
            this.textBox_Varosnev.Name = "textBox_Varosnev";
            this.textBox_Varosnev.Size = new System.Drawing.Size(174, 20);
            this.textBox_Varosnev.TabIndex = 2;
            // 
            // numeric_Lakossag
            // 
            this.numeric_Lakossag.Location = new System.Drawing.Point(240, 99);
            this.numeric_Lakossag.Name = "numeric_Lakossag";
            this.numeric_Lakossag.Size = new System.Drawing.Size(120, 20);
            this.numeric_Lakossag.TabIndex = 3;
            this.numeric_Lakossag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeric_Lakossag.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A város lakossága";
            // 
            // button_Varos_Insert
            // 
            this.button_Varos_Insert.Location = new System.Drawing.Point(189, 146);
            this.button_Varos_Insert.Name = "button_Varos_Insert";
            this.button_Varos_Insert.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Insert.TabIndex = 5;
            this.button_Varos_Insert.Text = "Város rögzítése";
            this.button_Varos_Insert.UseVisualStyleBackColor = true;
            this.button_Varos_Insert.Click += new System.EventHandler(this.button_Varos_Insert_Click);
            // 
            // button_Varos_Update
            // 
            this.button_Varos_Update.Location = new System.Drawing.Point(189, 186);
            this.button_Varos_Update.Name = "button_Varos_Update";
            this.button_Varos_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Update.TabIndex = 5;
            this.button_Varos_Update.Text = "Kiválasztott módosítása";
            this.button_Varos_Update.UseVisualStyleBackColor = true;
            // 
            // button_Varos_Delete
            // 
            this.button_Varos_Delete.Location = new System.Drawing.Point(189, 225);
            this.button_Varos_Delete.Name = "button_Varos_Delete";
            this.button_Varos_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Varos_Delete.TabIndex = 5;
            this.button_Varos_Delete.Text = "Törlés";
            this.button_Varos_Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_Latvanyossagok);
            this.groupBox2.Location = new System.Drawing.Point(388, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 422);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "A város látnivalói";
            // 
            // listBox_Latvanyossagok
            // 
            this.listBox_Latvanyossagok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Latvanyossagok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Latvanyossagok.FormattingEnabled = true;
            this.listBox_Latvanyossagok.Location = new System.Drawing.Point(3, 16);
            this.listBox_Latvanyossagok.Name = "listBox_Latvanyossagok";
            this.listBox_Latvanyossagok.Size = new System.Drawing.Size(228, 403);
            this.listBox_Latvanyossagok.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A város nevezetessége";
            // 
            // textBox_nevezetesseg
            // 
            this.textBox_nevezetesseg.Location = new System.Drawing.Point(645, 66);
            this.textBox_nevezetesseg.Name = "textBox_nevezetesseg";
            this.textBox_nevezetesseg.Size = new System.Drawing.Size(174, 20);
            this.textBox_nevezetesseg.TabIndex = 8;
            // 
            // textBox_Nevezetesseg_leiras
            // 
            this.textBox_Nevezetesseg_leiras.Location = new System.Drawing.Point(645, 122);
            this.textBox_Nevezetesseg_leiras.Multiline = true;
            this.textBox_Nevezetesseg_leiras.Name = "textBox_Nevezetesseg_leiras";
            this.textBox_Nevezetesseg_leiras.Size = new System.Drawing.Size(174, 126);
            this.textBox_Nevezetesseg_leiras.TabIndex = 9;
            // 
            // button_Latvanyossag_Insert
            // 
            this.button_Latvanyossag_Insert.Location = new System.Drawing.Point(648, 267);
            this.button_Latvanyossag_Insert.Name = "button_Latvanyossag_Insert";
            this.button_Latvanyossag_Insert.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Insert.TabIndex = 5;
            this.button_Latvanyossag_Insert.Text = "Látványosság rögzítése";
            this.button_Latvanyossag_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Latvanyossag_Update
            // 
            this.button_Latvanyossag_Update.Location = new System.Drawing.Point(648, 307);
            this.button_Latvanyossag_Update.Name = "button_Latvanyossag_Update";
            this.button_Latvanyossag_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Update.TabIndex = 5;
            this.button_Latvanyossag_Update.Text = "Kiválasztott módosítása";
            this.button_Latvanyossag_Update.UseVisualStyleBackColor = true;
            // 
            // button_Latvanyossag_Delete
            // 
            this.button_Latvanyossag_Delete.Location = new System.Drawing.Point(648, 346);
            this.button_Latvanyossag_Delete.Name = "button_Latvanyossag_Delete";
            this.button_Latvanyossag_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Latvanyossag_Delete.TabIndex = 5;
            this.button_Latvanyossag_Delete.Text = "Törlés";
            this.button_Latvanyossag_Delete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nevezetesség leírása";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(207, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 122);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Latvanyossagok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nevezetesseg_leiras);
            this.Controls.Add(this.textBox_nevezetesseg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Latvanyossag_Delete);
            this.Controls.Add(this.button_Varos_Delete);
            this.Controls.Add(this.button_Latvanyossag_Update);
            this.Controls.Add(this.button_Latvanyossag_Insert);
            this.Controls.Add(this.button_Varos_Update);
            this.Controls.Add(this.button_Varos_Insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_Lakossag);
            this.Controls.Add(this.textBox_Varosnev);
            this.Controls.Add(this.label_Varosnev);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Latvanyossagok";
            this.Text = "LatvanyossagokApplication";
            this.Load += new System.EventHandler(this.Form_Latvanyossagok_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Lakossag)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_Varosok;
        private System.Windows.Forms.Label label_Varosnev;
        private System.Windows.Forms.TextBox textBox_Varosnev;
        private System.Windows.Forms.NumericUpDown numeric_Lakossag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Varos_Insert;
        private System.Windows.Forms.Button button_Varos_Update;
        private System.Windows.Forms.Button button_Varos_Delete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox_Latvanyossagok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nevezetesseg;
        private System.Windows.Forms.TextBox textBox_Nevezetesseg_leiras;
        private System.Windows.Forms.Button button_Latvanyossag_Insert;
        private System.Windows.Forms.Button button_Latvanyossag_Update;
        private System.Windows.Forms.Button button_Latvanyossag_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

