using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T17_Jätkänshakki
{
    public partial class Form1 : Form
    {
        //Käytän nappien tilan tarkistukseen arrayta, jokaisella napilla on oma muuttuja arrayssa
        //Joka vaihtuu kun napista painetaan
        int[] buttons = new int[25];
        int vuoro = 1;
        int k = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;        
            /*Riippuen kumman vuoro on, nappi josta painetaan laitetaan joko ristiksi tai nollaksi
             ja sitä nappia edustava muuttuja arrayssa muutetaan oikeaksi numeroksi*/
            if (vuoro == 1)
            {
                buttons[Convert.ToInt32(nappi.Tag)] = 1;
                nappi.Image = Properties.Resources.Risti;
                vuoro = 2;
            } else
            {
                buttons[Convert.ToInt32(nappi.Tag)] = 2;
                nappi.Image = Properties.Resources.Nolla;
                vuoro = 1;
            }            
            /*Aina kun lisätään risti tai nolla koko ruudukko tutkitaan, onko siinä rivejä
             for loopit tarkistavat automaattisesti viittä rivissä olevaa nappia edustavaa
             muuttujaa arraysta, jos kaikki viisi ovat samat, rivi on valmis ja jompikumpi voittaa,
             jos yksikin on erilainen, se aloittaa tarkistuksen uudestaan seuraavasta napista*/
            for (int i = 0; i < 25;i++)
            {
                if (buttons[i] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[i] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int rivi1 = 0; rivi1 < 21; rivi1 = rivi1 + 5)
            {
                if (buttons[rivi1] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[rivi1] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int rivi2 = 1; rivi2 < 22; rivi2 = rivi2 + 5)
            {
                if (buttons[rivi2] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[rivi2] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int rivi3 = 2; rivi3 < 23; rivi3 = rivi3 + 5)
            {
                if (buttons[rivi3] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[rivi3] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int rivi4 = 3; rivi4 < 24; rivi4 = rivi4 + 5)
            {
                if (buttons[rivi4] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[rivi4] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int rivi5 = 4; rivi5 < 25; rivi5 = rivi5 + 5)
            {
                if (buttons[rivi5] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[rivi5] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int sivurivi = 0; sivurivi < 25; sivurivi = sivurivi + 6)
            {
                if (buttons[sivurivi] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[sivurivi] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            for (int sivurivi2 = 4; sivurivi2 < 21; sivurivi2 = sivurivi2 + 4)
            {
                if (buttons[sivurivi2] == 2)
                {
                    y++;
                }
                else
                {
                    y = 0;
                }
                if (y == 5)
                {
                    MessageBox.Show("Nolla on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
                if (buttons[sivurivi2] == 1)
                {
                    k++;
                }
                else
                {
                    k = 0;
                }
                if (k == 5)
                {
                    MessageBox.Show("Risti on viineri");
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element != button26)
                        {
                            element.Click -= button1_Click;
                        }
                    }
                }
            }
            nappi.Click -= button1_Click;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            /*Reset nappi tyhjentää kaikki variablet ja arrayn, sekä ottaa kuvat pois napeista*/
            y = 0;
            k = 0;
            vuoro = 1;
            for (int i = 0; i < 25; i++)
            {
                buttons[i] = 0;
            }
                foreach (Button element in this.Controls.OfType<Button>())
                {
                    if (element != button26)
                    {
                        element.Image = null;
                        element.Click -= button1_Click;
                        element.Click += button1_Click;
                    }
                }            
        }
    }
}