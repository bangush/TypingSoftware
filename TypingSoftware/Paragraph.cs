using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingSoftware
{
    class Paragraph
    {
        
        private string author;
        private string source;
        private string text;

        public Paragraph(string author, string source, string text)
        {
           
            this.author = author;
            this.source = source;
            this.text = text;

        }
       
        public string pAuthor
        {
            get { return author; }
            set { author = value; }
        }
        public string pSource
        {
            get { return source; }
            set { source = value; }
        }
        public string pText
        {
            get { return text; }
            set { text = value; }
        }

    }
}
