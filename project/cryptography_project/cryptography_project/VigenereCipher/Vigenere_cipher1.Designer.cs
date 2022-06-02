namespace cryptography_project
{
    partial class Vigenere_cipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vigenere_cipher));
            this.t = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_key = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_encry = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_decry = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_save_dec = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Dock = System.Windows.Forms.DockStyle.Left;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(0, 174);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(627, 567);
            this.t.TabIndex = 25;
            this.t.Text = "-------";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_key);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 174);
            this.panel1.TabIndex = 26;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(210, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(472, 44);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Vigenere cipher  with method 1";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.label2.Size = new System.Drawing.Size(140, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choice File :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_key
            // 
            this.txt_key.AutoSize = true;
            this.txt_key.BackColor = System.Drawing.Color.White;
            this.txt_key.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_key.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_key.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_key.BorderThickness = 1;
            this.txt_key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_key.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_key.isPassword = false;
            this.txt_key.Location = new System.Drawing.Point(210, 122);
            this.txt_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(424, 33);
            this.txt_key.TabIndex = 10;
            this.txt_key.Text = "hello";
            this.txt_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_key_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 122);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(12, 5, 5, 5);
            this.label1.Size = new System.Drawing.Size(140, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Key :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnHome.ImageActive")));
            this.btnHome.Location = new System.Drawing.Point(210, 65);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 43);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 12;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(642, 684);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(85, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 25;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageActive")));
            this.btnExit.Location = new System.Drawing.Point(768, 684);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 46);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 20;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_encry
            // 
            this.btn_encry.ActiveBorderThickness = 1;
            this.btn_encry.ActiveCornerRadius = 20;
            this.btn_encry.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_encry.ActiveForecolor = System.Drawing.Color.White;
            this.btn_encry.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_encry.AutoSize = true;
            this.btn_encry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_encry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_encry.BackgroundImage")));
            this.btn_encry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_encry.ButtonText = "Encryption";
            this.btn_encry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_encry.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encry.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_encry.IdleBorderThickness = 1;
            this.btn_encry.IdleCornerRadius = 20;
            this.btn_encry.IdleFillColor = System.Drawing.Color.White;
            this.btn_encry.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_encry.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_encry.Location = new System.Drawing.Point(635, 182);
            this.btn_encry.Margin = new System.Windows.Forms.Padding(5);
            this.btn_encry.Name = "btn_encry";
            this.btn_encry.Size = new System.Drawing.Size(206, 57);
            this.btn_encry.TabIndex = 19;
            this.btn_encry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_encry.Click += new System.EventHandler(this.btn_encry_Click);
            // 
            // btn_decry
            // 
            this.btn_decry.ActiveBorderThickness = 1;
            this.btn_decry.ActiveCornerRadius = 20;
            this.btn_decry.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_decry.ActiveForecolor = System.Drawing.Color.White;
            this.btn_decry.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_decry.AutoSize = true;
            this.btn_decry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_decry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_decry.BackgroundImage")));
            this.btn_decry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_decry.ButtonText = "Decryption";
            this.btn_decry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_decry.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decry.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_decry.IdleBorderThickness = 1;
            this.btn_decry.IdleCornerRadius = 20;
            this.btn_decry.IdleFillColor = System.Drawing.Color.White;
            this.btn_decry.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_decry.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_decry.Location = new System.Drawing.Point(635, 265);
            this.btn_decry.Margin = new System.Windows.Forms.Padding(5);
            this.btn_decry.Name = "btn_decry";
            this.btn_decry.Size = new System.Drawing.Size(206, 57);
            this.btn_decry.TabIndex = 27;
            this.btn_decry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_decry.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btn_save_dec
            // 
            this.btn_save_dec.ActiveBorderThickness = 1;
            this.btn_save_dec.ActiveCornerRadius = 20;
            this.btn_save_dec.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_save_dec.ActiveForecolor = System.Drawing.Color.White;
            this.btn_save_dec.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_save_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_save_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save_dec.BackgroundImage")));
            this.btn_save_dec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_save_dec.ButtonText = "Save file";
            this.btn_save_dec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_dec.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_dec.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_save_dec.IdleBorderThickness = 1;
            this.btn_save_dec.IdleCornerRadius = 20;
            this.btn_save_dec.IdleFillColor = System.Drawing.Color.White;
            this.btn_save_dec.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_save_dec.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_save_dec.Location = new System.Drawing.Point(635, 354);
            this.btn_save_dec.Margin = new System.Windows.Forms.Padding(5);
            this.btn_save_dec.Name = "btn_save_dec";
            this.btn_save_dec.Size = new System.Drawing.Size(206, 59);
            this.btn_save_dec.TabIndex = 28;
            this.btn_save_dec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save_dec.Click += new System.EventHandler(this.btn_save_dec_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuThinButton21.ButtonText = "About Algorithm";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(635, 443);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(213, 72);
            this.bunifuThinButton21.TabIndex = 33;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // Vigenere_cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(853, 741);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_save_dec);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_decry);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.t);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_encry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vigenere_cipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vigenere_cipher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox t;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_key;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_encry;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_decry;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_save_dec;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}