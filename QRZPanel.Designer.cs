namespace OE6CLD.HamCockpitPlugins.QRZcom
{
    partial class QRZPanel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QRZsearchcall = new System.Windows.Forms.TextBox();
            this.QRZfullname = new System.Windows.Forms.Label();
            this.QRZaddr1 = new System.Windows.Forms.Label();
            this.QRZaddr2 = new System.Windows.Forms.Label();
            this.QRZcountry = new System.Windows.Forms.Label();
            this.QRZLookup = new System.Windows.Forms.Button();
            this.QRZCQZ = new System.Windows.Forms.Label();
            this.QRZITUZ = new System.Windows.Forms.Label();
            this.QRZIOTA = new System.Windows.Forms.Label();
            this.QRZLOTW = new System.Windows.Forms.Label();
            this.QRZEQSL = new System.Windows.Forms.Label();
            this.QRZMail = new System.Windows.Forms.Label();
            this.QRZQSLMgr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QSLInfoMgr = new System.Windows.Forms.Label();
            this.QRZImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRZImage)).BeginInit();
            this.SuspendLayout();
            // 
            // QRZsearchcall
            // 
            this.QRZsearchcall.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.QRZsearchcall.Location = new System.Drawing.Point(27, 23);
            this.QRZsearchcall.Name = "QRZsearchcall";
            this.QRZsearchcall.Size = new System.Drawing.Size(118, 20);
            this.QRZsearchcall.TabIndex = 0;
            this.QRZsearchcall.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QRZsearchcall_KeyDown);
            // 
            // QRZfullname
            // 
            this.QRZfullname.AutoSize = true;
            this.QRZfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZfullname.Location = new System.Drawing.Point(23, 57);
            this.QRZfullname.Name = "QRZfullname";
            this.QRZfullname.Size = new System.Drawing.Size(0, 24);
            this.QRZfullname.TabIndex = 1;
            // 
            // QRZaddr1
            // 
            this.QRZaddr1.AutoSize = true;
            this.QRZaddr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZaddr1.Location = new System.Drawing.Point(24, 90);
            this.QRZaddr1.Name = "QRZaddr1";
            this.QRZaddr1.Size = new System.Drawing.Size(0, 16);
            this.QRZaddr1.TabIndex = 2;
            // 
            // QRZaddr2
            // 
            this.QRZaddr2.AutoSize = true;
            this.QRZaddr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZaddr2.Location = new System.Drawing.Point(24, 106);
            this.QRZaddr2.Name = "QRZaddr2";
            this.QRZaddr2.Size = new System.Drawing.Size(0, 16);
            this.QRZaddr2.TabIndex = 3;
            // 
            // QRZcountry
            // 
            this.QRZcountry.AutoSize = true;
            this.QRZcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZcountry.Location = new System.Drawing.Point(23, 132);
            this.QRZcountry.Name = "QRZcountry";
            this.QRZcountry.Size = new System.Drawing.Size(0, 20);
            this.QRZcountry.TabIndex = 4;
            // 
            // QRZLookup
            // 
            this.QRZLookup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QRZLookup.Location = new System.Drawing.Point(167, 21);
            this.QRZLookup.Name = "QRZLookup";
            this.QRZLookup.Size = new System.Drawing.Size(75, 23);
            this.QRZLookup.TabIndex = 5;
            this.QRZLookup.Text = "Lookup";
            this.QRZLookup.UseVisualStyleBackColor = true;
            this.QRZLookup.Click += new System.EventHandler(this.ButtonQRZLookup_Click);
            // 
            // QRZCQZ
            // 
            this.QRZCQZ.AutoSize = true;
            this.QRZCQZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZCQZ.Location = new System.Drawing.Point(18, 11);
            this.QRZCQZ.Name = "QRZCQZ";
            this.QRZCQZ.Size = new System.Drawing.Size(37, 15);
            this.QRZCQZ.TabIndex = 6;
            this.QRZCQZ.Text = "CQZ: ";
            // 
            // QRZITUZ
            // 
            this.QRZITUZ.AutoSize = true;
            this.QRZITUZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZITUZ.Location = new System.Drawing.Point(78, 11);
            this.QRZITUZ.Name = "QRZITUZ";
            this.QRZITUZ.Size = new System.Drawing.Size(39, 15);
            this.QRZITUZ.TabIndex = 7;
            this.QRZITUZ.Text = "ITUZ: ";
            // 
            // QRZIOTA
            // 
            this.QRZIOTA.AutoSize = true;
            this.QRZIOTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZIOTA.Location = new System.Drawing.Point(150, 11);
            this.QRZIOTA.Name = "QRZIOTA";
            this.QRZIOTA.Size = new System.Drawing.Size(33, 15);
            this.QRZIOTA.TabIndex = 8;
            this.QRZIOTA.Text = "IOTA";
            // 
            // QRZLOTW
            // 
            this.QRZLOTW.AutoSize = true;
            this.QRZLOTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZLOTW.Location = new System.Drawing.Point(18, 26);
            this.QRZLOTW.Name = "QRZLOTW";
            this.QRZLOTW.Size = new System.Drawing.Size(39, 15);
            this.QRZLOTW.TabIndex = 9;
            this.QRZLOTW.Text = "LoTW";
            // 
            // QRZEQSL
            // 
            this.QRZEQSL.AutoSize = true;
            this.QRZEQSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZEQSL.Location = new System.Drawing.Point(78, 26);
            this.QRZEQSL.Name = "QRZEQSL";
            this.QRZEQSL.Size = new System.Drawing.Size(44, 15);
            this.QRZEQSL.TabIndex = 10;
            this.QRZEQSL.Text = "eQSL: ";
            // 
            // QRZMail
            // 
            this.QRZMail.AutoSize = true;
            this.QRZMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZMail.Location = new System.Drawing.Point(150, 26);
            this.QRZMail.Name = "QRZMail";
            this.QRZMail.Size = new System.Drawing.Size(37, 15);
            this.QRZMail.TabIndex = 11;
            this.QRZMail.Text = "Mail: ";
            // 
            // QRZQSLMgr
            // 
            this.QRZQSLMgr.AutoSize = true;
            this.QRZQSLMgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRZQSLMgr.Location = new System.Drawing.Point(24, 218);
            this.QRZQSLMgr.Name = "QRZQSLMgr";
            this.QRZQSLMgr.Size = new System.Drawing.Size(64, 16);
            this.QRZQSLMgr.TabIndex = 12;
            this.QRZQSLMgr.Text = "QSL Info: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.QRZCQZ);
            this.panel1.Controls.Add(this.QRZLOTW);
            this.panel1.Controls.Add(this.QRZEQSL);
            this.panel1.Controls.Add(this.QRZMail);
            this.panel1.Controls.Add(this.QRZITUZ);
            this.panel1.Controls.Add(this.QRZIOTA);
            this.panel1.Location = new System.Drawing.Point(27, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 51);
            this.panel1.TabIndex = 13;
            // 
            // QSLInfoMgr
            // 
            this.QSLInfoMgr.AutoSize = true;
            this.QSLInfoMgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QSLInfoMgr.Location = new System.Drawing.Point(24, 250);
            this.QSLInfoMgr.Name = "QSLInfoMgr";
            this.QSLInfoMgr.Size = new System.Drawing.Size(132, 16);
            this.QSLInfoMgr.TabIndex = 15;
            this.QSLInfoMgr.Text = "QSL Mgr (qslinfo.de):";
            // 
            // QRZImage
            // 
            this.QRZImage.Location = new System.Drawing.Point(445, 21);
            this.QRZImage.Name = "QRZImage";
            this.QRZImage.Size = new System.Drawing.Size(388, 270);
            this.QRZImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRZImage.TabIndex = 16;
            this.QRZImage.TabStop = false;
            // 
            // QRZPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.QRZImage);
            this.Controls.Add(this.QSLInfoMgr);
            this.Controls.Add(this.QRZQSLMgr);
            this.Controls.Add(this.QRZLookup);
            this.Controls.Add(this.QRZcountry);
            this.Controls.Add(this.QRZaddr2);
            this.Controls.Add(this.QRZaddr1);
            this.Controls.Add(this.QRZfullname);
            this.Controls.Add(this.QRZsearchcall);
            this.Controls.Add(this.panel1);
            this.Name = "QRZPanel";
            this.Size = new System.Drawing.Size(849, 307);
            this.Load += new System.EventHandler(this.MyQRZPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.ButtonQRZLookup_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRZImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        internal System.Windows.Forms.TextBox QRZsearchcall;
        internal System.Windows.Forms.Button QRZLookup;
        internal System.Windows.Forms.Label QRZfullname;
        internal System.Windows.Forms.Label QRZaddr1;
        internal System.Windows.Forms.Label QRZaddr2;
        internal System.Windows.Forms.Label QRZcountry;
        private System.Windows.Forms.Label QRZCQZ;
        private System.Windows.Forms.Label QRZITUZ;
        private System.Windows.Forms.Label QRZIOTA;
        private System.Windows.Forms.Label QRZLOTW;
        private System.Windows.Forms.Label QRZEQSL;
        private System.Windows.Forms.Label QRZMail;
        private System.Windows.Forms.Label QRZQSLMgr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label QSLInfoMgr;
        private System.Windows.Forms.PictureBox QRZImage;
    }
}
