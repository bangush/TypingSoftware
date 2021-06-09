using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingSoftware
{
    class Library
    {
        
        private List<Paragraph> paragraphs;
        public Library()
        {
            paragraphs = new List<Paragraph>();
            paragraphs.Add(AddExamples());

        }
        public List<Paragraph> pParagraphs
        {
            get { return paragraphs; }
        }
        public void AddParagraph(Paragraph p)
        {
            paragraphs.Add(p);
        }
        public void RemoveParagraph(Paragraph p)
        {
            paragraphs.Remove(p);
        }
        public Paragraph AddExamples()
        {
            Paragraph p = new Paragraph("Me","MyBook", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
            return p;
        }
    }
}
