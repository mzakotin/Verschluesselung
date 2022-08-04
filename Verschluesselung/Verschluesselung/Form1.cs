using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace Verschluesselung
{
    public partial class fm_Verschluesselung : Form
    {
        public fm_Verschluesselung()
        {
            InitializeComponent();
        }

        private void Fm_Caesar_Load(object sender, EventArgs e)
        {
            CB_Caesar.Text = "0";
            TB_Ausgabe.ReadOnly = true;
            RB_Caesar.Checked = false;
            RB_Vigenere.Checked = false;
        }

        private void TB_Eingabe_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            char caesar;
            int zwischen;

            //8: Rücktaste (Ascii-Code)
            if (!((keycode >= 'A' && keycode <= 'Z') || (keycode >= 'a' && keycode <= 122) || keycode == 8))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

                if (RB_Caesar.Checked == true)
                {
                    if (CB_Caesar.Text != "" && keycode != 8)
                    {

                        zwischen = keycode + CB_Caesar.SelectedIndex;

                        //check Großbuchstabe-kleinbuchstabe
                        if (keycode >= 'A' && keycode <= 'Z')
                        {
                            if (zwischen > 'Z')
                            {
                                caesar = (char)(zwischen - 26);
                            }
                            else
                            {
                                caesar = (char)(zwischen);
                            }

                        }
                        else
                        {
                            if (zwischen > 'z')
                            {
                                caesar = (char)(zwischen - 26);
                            }
                            else
                            {
                                caesar = (char)(zwischen);
                            }
                        }
                        TB_Ausgabe.Text += caesar.ToString();
                    }

                    else if (keycode == 8) { TB_Ausgabe.Clear(); }
                }


            }
        }

        private void CB_Caesar_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;

            //8: Rücktaste nicht erfüllt
            if ((!(keycode >= '0' && keycode <= '9' || keycode == 8)) ||
                (CB_Caesar.Text.Length > 1 && keycode != 8) || //maximal 2 Stellen
                (CB_Caesar.Text == "0" && (keycode != 8)) || // wenn 0 eingetragen, nur löschen mit Rücktaste möglich
                (CB_Caesar.Text == "2" && (!(keycode == 8 || keycode >= '0' && keycode <= '5'))) || //Zahlen von 20 bis 25
                (!(CB_Caesar.Text == "" || CB_Caesar.Text == "1" || CB_Caesar.Text == "2") && (keycode != 8))) //keine weitere Stelle nach den Ziffern 3 bis 9

            {
                e.Handled = true;
            }
            else e.Handled = false;
        }

        private void RB_Caesar_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Caesar.Checked == true)
            {
                RB_Vigenere.Checked = false;
                CB_Caesar.Visible = true;
                TB_Schluessel.Hide();
                Bt_Verschluesseln.Hide();
                TB_Eingabe.Clear();
                TB_Schluessel.Clear();
                TB_Ausgabe.Clear();
            }
        }

        private void RB_Vigenere_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Vigenere.Checked == true)
            {
                RB_Caesar.Checked = false;
                CB_Caesar.Hide();
                TB_Schluessel.Visible = true;
                Bt_Verschluesseln.Visible = true;
                TB_Eingabe.Clear();
                CB_Caesar.Text = "0";
                TB_Schluessel.Clear();
                TB_Ausgabe.Clear();
            }
        }

        private void Bt_Verschluesseln_Click(object sender, EventArgs e)
        {
            if (RB_Vigenere.Checked == false) { MessageBox.Show("Es ist nichts ausgewählt worden!"); }

            else
            if (TB_Eingabe.Text == "" || TB_Schluessel.Text == "") { MessageBox.Show("Bitte Klartext und Schlüssel eingeben!"); }

            else
            {
                string klartext = TB_Eingabe.Text;
                string key = TB_Schluessel.Text;
                char vigenere;
                int i = 0;

                if (klartext.Length != key.Length)
                {
                    MessageBox.Show("Klartext und Schlüssel müssen die gleiche Anzahl von Buchstaben haben!");
                }

                else

                    foreach (char c in klartext)
                    {
                        int zwischen = c + key[i];

                        //check Großbuchstabe-kleinbuchstabe
                        if ((c >= 'A' && c <= 'Z') && (key[i] >= 'A' && key[i] <= 'Z'))
                        {
                            zwischen = zwischen - 65;

                            if (zwischen > 'Z')
                            {
                                vigenere = (char)(zwischen - 26);
                                TB_Ausgabe.Text += vigenere.ToString();
                                i++;
                            }
                            else
                            {
                                vigenere = (char)(zwischen);
                                TB_Ausgabe.Text += vigenere.ToString();
                                i++;
                            }

                        }
                        else
                        {
                            zwischen = zwischen - 97;

                            if (zwischen > 'z')
                            {
                                vigenere = (char)(zwischen - 26);
                                TB_Ausgabe.Text += vigenere.ToString();
                                i++;
                            }
                            else
                            {
                                vigenere = (char)(zwischen);
                                TB_Ausgabe.Text += vigenere.ToString();
                                i++;
                            }
                        }
                    }
            }
        }

        private void TB_Schluessel_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;                                        //8 = Rücktaste
            if (!((keycode >= 'A' && keycode <= 'Z') || (keycode >= 'a' && keycode <= 'z') || keycode == 8))
            {
                e.Handled = true;
            }
            else e.Handled = false;

            if (keycode == 8) { TB_Ausgabe.Clear(); }
        }

        private void TB_Ausgabe_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if (keycode == 8 && TB_Ausgabe.Text != "") { TB_Ausgabe.ReadOnly = false; }
            else
            { TB_Ausgabe.ReadOnly = true; e.Handled = true; }
        }

        private void Bt_einlesen_Click(object sender, EventArgs e)
        {
            if (OFD_Chiffre.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = OFD_Chiffre.FileName;
                    /*using (Stream str = OFD_Chiffre.OpenFile())
                    {
                        Process.Start("notepad.exe", filePath);

                    }*/

                    //Read the contents of the file into a stream
                    var fileStream = OFD_Chiffre.OpenFile();
                    var fileContent = "Gedicht.txt";

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                        TB_Eingabe.Text = fileContent;
                    }

                    if (RB_Caesar.Checked == false && RB_Vigenere.Checked == false) 
                    { MessageBox.Show("Bitte wählen Sie die Art der Verschlüsselung aus!"); }

                    else

                        foreach (char c in fileContent)
                        {
                            if (CB_Caesar.Text != "" && TB_Eingabe.Text != "")
                            {
                                int zwischen = c + CB_Caesar.SelectedIndex;
                                char caesar;

                                //check Großbuchstabe-kleinbuchstabe
                                if (c >= 'A' && c <= 'Z')
                                {
                                    if (zwischen > 'Z')
                                    {
                                        caesar = (char)(zwischen - 26);
                                    }
                                    else
                                    {
                                        caesar = (char)(zwischen);
                                    }

                                }
                                else
                                {

                                    if (zwischen > 'z')
                                    {
                                        caesar = (char)(zwischen - 26);
                                    }
                                    else
                                    {
                                        caesar = (char)(zwischen);
                                    }
                                }

                                if (c == ' ' || c == '.' || c == '\r')
                                {
                                    zwischen = c;
                                    caesar = (char)(zwischen);
                                }
                                TB_Ausgabe.Text += caesar.ToString();
                            }
                        }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
