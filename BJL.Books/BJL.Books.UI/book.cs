using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJL.Books.UI
{
    public class Book
    {
        private string title;
        private int numPages;

        public string Title
        {
            get { return title; } //Allows the outside to read/see the title
            set { title = value; } //Allows the outside to change title
        }

        
        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }

        public void TellStory()
        {
            //Tell story
            
        }

    }
}
