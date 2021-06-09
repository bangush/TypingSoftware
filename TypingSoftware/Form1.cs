using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSoftware
{
    public partial class Form1 : Form
    {
        Library library;
        public Form1()
        {
            InitializeComponent();
            library = new Library();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Paragraph p= library.pParagraphs.ElementAt(0);//this is going to be a random paragraph later
            textBoxTexto.Text = p.pText;
            labelBiblio.Text = "From: " + p.pSource + " Writen by: " + p.pAuthor;
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(textBoxTexto.Text.StartsWith(textBoxTyper.Text))
            {
                label1.Text = "Correct";
                label1.ForeColor = Color.Green;
            }
            else
            {
                label1.Text = "Incorrect";
                label1.ForeColor = Color.Red;
            }
            labelWordsCount.Text = textBoxTyper.Text.Length + " / " + textBoxTexto.Text.Length;
        }
    }
}
