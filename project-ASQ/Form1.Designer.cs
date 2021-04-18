
using System;

namespace project_ASQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numerocours = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.numeroducours = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
            this.Resultat2 = new System.Windows.Forms.ListBox();
            this.Resultat3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Resfinal = new System.Windows.Forms.ListBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Etudiant";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(778, 34);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(107, 27);
            this.id.TabIndex = 1;
            this.id.Text = "22";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(1048, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ajouter Etudiant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.Info;
            this.c.FormattingEnabled = true;
            this.c.ItemHeight = 20;
            this.c.Location = new System.Drawing.Point(852, 281);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(345, 104);
            this.c.TabIndex = 3;
            this.c.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Location = new System.Drawing.Point(1048, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ajouter Cours";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(1048, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ajouter Note";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numerocours
            // 
            this.numerocours.Location = new System.Drawing.Point(778, 130);
            this.numerocours.Name = "numerocours";
            this.numerocours.Size = new System.Drawing.Size(125, 27);
            this.numerocours.TabIndex = 6;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(461, 45);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(125, 27);
            this.nom.TabIndex = 7;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(461, 130);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(125, 27);
            this.code.TabIndex = 8;
            this.code.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(95, 45);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(125, 27);
            this.prenom.TabIndex = 9;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(95, 130);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(125, 27);
            this.titre.TabIndex = 10;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(781, 223);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(125, 27);
            this.id2.TabIndex = 11;
            this.id2.TextChanged += new System.EventHandler(this.numeroetudiant_TextChanged);
            // 
            // numeroducours
            // 
            this.numeroducours.Location = new System.Drawing.Point(461, 223);
            this.numeroducours.Name = "numeroducours";
            this.numeroducours.Size = new System.Drawing.Size(125, 27);
            this.numeroducours.TabIndex = 12;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(95, 223);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(125, 27);
            this.note.TabIndex = 13;
            // 
            // Resultat2
            // 
            this.Resultat2.BackColor = System.Drawing.SystemColors.Info;
            this.Resultat2.FormattingEnabled = true;
            this.Resultat2.ItemHeight = 20;
            this.Resultat2.Location = new System.Drawing.Point(378, 281);
            this.Resultat2.Name = "Resultat2";
            this.Resultat2.Size = new System.Drawing.Size(415, 104);
            this.Resultat2.TabIndex = 14;
            // 
            // Resultat3
            // 
            this.Resultat3.BackColor = System.Drawing.SystemColors.Info;
            this.Resultat3.FormattingEnabled = true;
            this.Resultat3.ItemHeight = 20;
            this.Resultat3.Location = new System.Drawing.Point(12, 281);
            this.Resultat3.Name = "Resultat3";
            this.Resultat3.Size = new System.Drawing.Size(360, 104);
            this.Resultat3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Titre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Numero du cours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Numero du cours";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(784, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Numero Etudiant";
            // 
            // Resfinal
            // 
            this.Resfinal.BackColor = System.Drawing.SystemColors.Info;
            this.Resfinal.FormattingEnabled = true;
            this.Resfinal.ItemHeight = 20;
            this.Resfinal.Location = new System.Drawing.Point(513, 403);
            this.Resfinal.Name = "Resfinal";
            this.Resfinal.Size = new System.Drawing.Size(455, 204);
            this.Resfinal.TabIndex = 24;
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enregistrer.Location = new System.Drawing.Point(78, 443);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(142, 46);
            this.enregistrer.TabIndex = 25;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(344, 453);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(125, 27);
            this.input.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(322, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Entrer le numero d\'etud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1241, 604);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.input);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.Resfinal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Resultat3);
            this.Controls.Add(this.Resultat2);
            this.Controls.Add(this.note);
            this.Controls.Add(this.numeroducours);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.code);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.numerocours);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.c);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ajouter Cours";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }





        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox c;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox numerocours;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.TextBox numerodetudiant;
        private System.Windows.Forms.TextBox numeroducours;
        private System.Windows.Forms.TextBox note;
        private System.Windows.Forms.ListBox Resultat2;
        private System.Windows.Forms.ListBox Resultat3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.ListBox Resfinal;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label10;
    }
}

