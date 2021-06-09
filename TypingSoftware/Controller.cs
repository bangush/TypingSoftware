using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingSoftware
{
    class Controller
    {
        /*
         * Ok. what need to do the controller, takes a paragraph and split into an array of strings
         * */
        private string[] words;
        public Controller(Paragraph p)
        {
            words = p.pText.Split();
        }
        public string[] pWords
        {
            get { return words; }
        }
        public void Compare()
        {

        }
        
    }
}
