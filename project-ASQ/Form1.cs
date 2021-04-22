using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";
        public void SaveEvent(string ch1)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save file?", "Confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (Resfinal != null)
                    {
                        saveFile(ch1);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void saveFile(string ch1)
        { // Save File to .txt
            FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(ch1);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
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
            string res = "";
            foreach (string s in Resultat3.Items)
            {
                if (id2.Text.Equals(input.Text))
                {

                    Resfinal.Items.Add(s);
                    res += s;
                }
            }

            SaveEvent(res);
           
        }
    }
}
            
