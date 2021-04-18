using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project_ASQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etudiant et = new Etudiant(Int32.Parse(id.Text), nom.Text, prenom.Text);
            c.Items.Add(et.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Cours cou = new Cours(Int32.Parse(numerocours.Text), Int32.Parse(code.Text), titre.Text);
            Resultat2.Items.Add(cou.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Notes no = new Notes(Int32.Parse(id2.Text), Int32.Parse(numeroducours.Text), Int32.Parse(note.Text));
            Resultat3.Items.Add(no.ToString());
        }

        private void numeroetudiant_TextChanged(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            foreach (string s in Resultat3.Items)
            {
                if (id2.Text.Equals(input.Text))
                {

                    Resfinal.Items.Add(s);
                    data.Add(s);
                }
            }

            StreamWriterTwo.SaveDataAsync(data);
        }
    }
}
            
