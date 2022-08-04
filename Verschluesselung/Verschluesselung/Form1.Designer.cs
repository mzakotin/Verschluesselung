namespace Verschluesselung
{
    partial class fm_Verschluesselung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Eingabe = new System.Windows.Forms.TextBox();
            this.CB_Caesar = new System.Windows.Forms.ComboBox();
            this.TB_Ausgabe = new System.Windows.Forms.TextBox();
            this.GB_Chiffre = new System.Windows.Forms.GroupBox();
            this.RB_Vigenere = new System.Windows.Forms.RadioButton();
            this.RB_Caesar = new System.Windows.Forms.RadioButton();
            this.TB_Schluessel = new System.Windows.Forms.TextBox();
            this.Bt_Verschluesseln = new System.Windows.Forms.Button();
            this.Bt_einlesen = new System.Windows.Forms.Button();
            this.OFD_Chiffre = new System.Windows.Forms.OpenFileDialog();
            this.GB_Chiffre.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Eingabe
            // 
            this.TB_Eingabe.Location = new System.Drawing.Point(58, 41);
            this.TB_Eingabe.Name = "TB_Eingabe";
            this.TB_Eingabe.Size = new System.Drawing.Size(100, 20);
            this.TB_Eingabe.TabIndex = 0;
            this.TB_Eingabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Eingabe_KeyPress);
            // 
            // CB_Caesar
            // 
            this.CB_Caesar.FormattingEnabled = true;
            this.CB_Caesar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.CB_Caesar.Location = new System.Drawing.Point(332, 40);
            this.CB_Caesar.Name = "CB_Caesar";
            this.CB_Caesar.Size = new System.Drawing.Size(51, 21);
            this.CB_Caesar.TabIndex = 1;
            this.CB_Caesar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_Caesar_KeyPress);
            // 
            // TB_Ausgabe
            // 
            this.TB_Ausgabe.Location = new System.Drawing.Point(58, 202);
            this.TB_Ausgabe.Name = "TB_Ausgabe";
            this.TB_Ausgabe.ReadOnly = true;
            this.TB_Ausgabe.Size = new System.Drawing.Size(100, 20);
            this.TB_Ausgabe.TabIndex = 2;
            this.TB_Ausgabe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Ausgabe_KeyPress);
            // 
            // GB_Chiffre
            // 
            this.GB_Chiffre.Controls.Add(this.RB_Vigenere);
            this.GB_Chiffre.Controls.Add(this.RB_Caesar);
            this.GB_Chiffre.Location = new System.Drawing.Point(483, 40);
            this.GB_Chiffre.Name = "GB_Chiffre";
            this.GB_Chiffre.Size = new System.Drawing.Size(115, 89);
            this.GB_Chiffre.TabIndex = 3;
            this.GB_Chiffre.TabStop = false;
            this.GB_Chiffre.Text = "Art der Chiffre";
            // 
            // RB_Vigenere
            // 
            this.RB_Vigenere.AutoSize = true;
            this.RB_Vigenere.Location = new System.Drawing.Point(6, 53);
            this.RB_Vigenere.Name = "RB_Vigenere";
            this.RB_Vigenere.Size = new System.Drawing.Size(67, 17);
            this.RB_Vigenere.TabIndex = 1;
            this.RB_Vigenere.TabStop = true;
            this.RB_Vigenere.Text = "Vigenère";
            this.RB_Vigenere.UseVisualStyleBackColor = true;
            this.RB_Vigenere.CheckedChanged += new System.EventHandler(this.RB_Vigenere_CheckedChanged);
            // 
            // RB_Caesar
            // 
            this.RB_Caesar.AutoSize = true;
            this.RB_Caesar.Location = new System.Drawing.Point(6, 30);
            this.RB_Caesar.Name = "RB_Caesar";
            this.RB_Caesar.Size = new System.Drawing.Size(58, 17);
            this.RB_Caesar.TabIndex = 0;
            this.RB_Caesar.TabStop = true;
            this.RB_Caesar.Text = "Caesar";
            this.RB_Caesar.UseVisualStyleBackColor = true;
            this.RB_Caesar.CheckedChanged += new System.EventHandler(this.RB_Caesar_CheckedChanged);
            // 
            // TB_Schluessel
            // 
            this.TB_Schluessel.Location = new System.Drawing.Point(58, 109);
            this.TB_Schluessel.Name = "TB_Schluessel";
            this.TB_Schluessel.Size = new System.Drawing.Size(100, 20);
            this.TB_Schluessel.TabIndex = 4;
            this.TB_Schluessel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Schluessel_KeyPress);
            // 
            // Bt_Verschluesseln
            // 
            this.Bt_Verschluesseln.Location = new System.Drawing.Point(319, 106);
            this.Bt_Verschluesseln.Name = "Bt_Verschluesseln";
            this.Bt_Verschluesseln.Size = new System.Drawing.Size(106, 23);
            this.Bt_Verschluesseln.TabIndex = 5;
            this.Bt_Verschluesseln.Text = "Verschlüsseln";
            this.Bt_Verschluesseln.UseVisualStyleBackColor = true;
            this.Bt_Verschluesseln.Click += new System.EventHandler(this.Bt_Verschluesseln_Click);
            // 
            // Bt_einlesen
            // 
            this.Bt_einlesen.Location = new System.Drawing.Point(319, 147);
            this.Bt_einlesen.Name = "Bt_einlesen";
            this.Bt_einlesen.Size = new System.Drawing.Size(106, 23);
            this.Bt_einlesen.TabIndex = 6;
            this.Bt_einlesen.Text = "Datei einlesen";
            this.Bt_einlesen.UseVisualStyleBackColor = true;
            this.Bt_einlesen.Click += new System.EventHandler(this.Bt_einlesen_Click);
            // 
            // OFD_Chiffre
            // 
            this.OFD_Chiffre.DefaultExt = "*.txt";
            this.OFD_Chiffre.FileName = "C:\\Users\\user\\Documents\\BFW\\Praktikum_2020\\Projekt2020_MZakotin\\Verschluesselung";
            this.OFD_Chiffre.Filter = "Textdateien (*.txt)|*.txt";
            // 
            // fm_Verschluesselung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt_einlesen);
            this.Controls.Add(this.Bt_Verschluesseln);
            this.Controls.Add(this.TB_Schluessel);
            this.Controls.Add(this.GB_Chiffre);
            this.Controls.Add(this.TB_Ausgabe);
            this.Controls.Add(this.CB_Caesar);
            this.Controls.Add(this.TB_Eingabe);
            this.Name = "fm_Verschluesselung";
            this.Text = "Verschlüsselung";
            this.Load += new System.EventHandler(this.Fm_Caesar_Load);
            this.GB_Chiffre.ResumeLayout(false);
            this.GB_Chiffre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Eingabe;
        private System.Windows.Forms.ComboBox CB_Caesar;
        private System.Windows.Forms.TextBox TB_Ausgabe;
        private System.Windows.Forms.GroupBox GB_Chiffre;
        private System.Windows.Forms.RadioButton RB_Vigenere;
        private System.Windows.Forms.RadioButton RB_Caesar;
        private System.Windows.Forms.TextBox TB_Schluessel;
        private System.Windows.Forms.Button Bt_Verschluesseln;
        private System.Windows.Forms.Button Bt_einlesen;
        private System.Windows.Forms.OpenFileDialog OFD_Chiffre;
    }
}

