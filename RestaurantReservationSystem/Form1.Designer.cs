namespace RestaurantReservationSystem
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
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.txtNumeClient = new System.Windows.Forms.TextBox();
            this.lblDataRezervare = new System.Windows.Forms.Label();
            this.dtpDataRezervare = new System.Windows.Forms.DateTimePicker();
            this.lblNrPersoane = new System.Windows.Forms.Label();
            this.nudNrPersoane = new System.Windows.Forms.NumericUpDown();
            this.btnAdaugaRezervare = new System.Windows.Forms.Button();
            this.lstRezervari = new System.Windows.Forms.ListBox();
            this.btnStergeRezervare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValidare = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrPersoane)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeClient
            // 
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.Location = new System.Drawing.Point(12, 31);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(66, 13);
            this.lblNumeClient.TabIndex = 0;
            this.lblNumeClient.Text = "Nume client:";
            // 
            // txtNumeClient
            // 
            this.txtNumeClient.Location = new System.Drawing.Point(124, 31);
            this.txtNumeClient.Name = "txtNumeClient";
            this.txtNumeClient.Size = new System.Drawing.Size(124, 20);
            this.txtNumeClient.TabIndex = 1;
            // 
            // lblDataRezervare
            // 
            this.lblDataRezervare.AutoSize = true;
            this.lblDataRezervare.Location = new System.Drawing.Point(12, 63);
            this.lblDataRezervare.Name = "lblDataRezervare";
            this.lblDataRezervare.Size = new System.Drawing.Size(106, 13);
            this.lblDataRezervare.TabIndex = 2;
            this.lblDataRezervare.Text = "Data și ora rezervarii:";
            // 
            // dtpDataRezervare
            // 
            this.dtpDataRezervare.Location = new System.Drawing.Point(124, 57);
            this.dtpDataRezervare.Name = "dtpDataRezervare";
            this.dtpDataRezervare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataRezervare.TabIndex = 3;
            // 
            // lblNrPersoane
            // 
            this.lblNrPersoane.AutoSize = true;
            this.lblNrPersoane.Location = new System.Drawing.Point(12, 95);
            this.lblNrPersoane.Name = "lblNrPersoane";
            this.lblNrPersoane.Size = new System.Drawing.Size(85, 13);
            this.lblNrPersoane.TabIndex = 4;
            this.lblNrPersoane.Text = "Numar persoane";
            // 
            // nudNrPersoane
            // 
            this.nudNrPersoane.Location = new System.Drawing.Point(124, 93);
            this.nudNrPersoane.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNrPersoane.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNrPersoane.Name = "nudNrPersoane";
            this.nudNrPersoane.Size = new System.Drawing.Size(60, 20);
            this.nudNrPersoane.TabIndex = 5;
            this.nudNrPersoane.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdaugaRezervare
            // 
            this.btnAdaugaRezervare.Location = new System.Drawing.Point(12, 138);
            this.btnAdaugaRezervare.Name = "btnAdaugaRezervare";
            this.btnAdaugaRezervare.Size = new System.Drawing.Size(312, 23);
            this.btnAdaugaRezervare.TabIndex = 6;
            this.btnAdaugaRezervare.Text = "Adauga rezervare";
            this.btnAdaugaRezervare.UseVisualStyleBackColor = true;
            this.btnAdaugaRezervare.Click += new System.EventHandler(this.btnAdaugaRezervare_Click);
            // 
            // lstRezervari
            // 
            this.lstRezervari.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRezervari.FormattingEnabled = true;
            this.lstRezervari.ItemHeight = 15;
            this.lstRezervari.Location = new System.Drawing.Point(30, 204);
            this.lstRezervari.Name = "lstRezervari";
            this.lstRezervari.ScrollAlwaysVisible = true;
            this.lstRezervari.Size = new System.Drawing.Size(450, 109);
            this.lstRezervari.TabIndex = 7;
            // 
            // btnStergeRezervare
            // 
            this.btnStergeRezervare.Location = new System.Drawing.Point(30, 320);
            this.btnStergeRezervare.Name = "btnStergeRezervare";
            this.btnStergeRezervare.Size = new System.Drawing.Size(191, 23);
            this.btnStergeRezervare.TabIndex = 8;
            this.btnStergeRezervare.Text = "Sterge rezervare";
            this.btnStergeRezervare.UseVisualStyleBackColor = true;
            this.btnStergeRezervare.Click += new System.EventHandler(this.btnStergeRezervare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnValidare
            // 
            this.btnValidare.Location = new System.Drawing.Point(263, 319);
            this.btnValidare.Name = "btnValidare";
            this.btnValidare.Size = new System.Drawing.Size(183, 23);
            this.btnValidare.TabIndex = 10;
            this.btnValidare.Text = "Validare";
            this.btnValidare.UseVisualStyleBackColor = true;
            this.btnValidare.Click += new System.EventHandler(this.btnValidare_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(124, 178);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 11;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(30, 178);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 12;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnValidare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStergeRezervare);
            this.Controls.Add(this.lstRezervari);
            this.Controls.Add(this.btnAdaugaRezervare);
            this.Controls.Add(this.nudNrPersoane);
            this.Controls.Add(this.lblNrPersoane);
            this.Controls.Add(this.dtpDataRezervare);
            this.Controls.Add(this.lblDataRezervare);
            this.Controls.Add(this.txtNumeClient);
            this.Controls.Add(this.lblNumeClient);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sistem rezervari restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNrPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.TextBox txtNumeClient;
        private System.Windows.Forms.Label lblDataRezervare;
        private System.Windows.Forms.DateTimePicker dtpDataRezervare;
        private System.Windows.Forms.Label lblNrPersoane;
        private System.Windows.Forms.NumericUpDown nudNrPersoane;
        private System.Windows.Forms.Button btnAdaugaRezervare;
        private System.Windows.Forms.ListBox lstRezervari;
        private System.Windows.Forms.Button btnStergeRezervare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValidare;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCauta;
    }
}

