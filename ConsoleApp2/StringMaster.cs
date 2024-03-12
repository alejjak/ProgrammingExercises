using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComAlgLib
{
    public class StringMaster
    {
        private string str1 = "";
        public string Str
        {
            get { return str1; }
            set { str1 = value; }
        }

        private StringMaster()
        {

        }

        public StringMaster(string str)
        {
            str1 = str;
        }

        /// <summary>
        /// returns the last word of each line in one line
        /// </summary>
        /// <param name="s">
        /// string input = "The quick\nbrown fox jumps over \nthe lazy dog";
        /// </param>
        /// <returns>quick over dog</returns>
        public static string StringExample1(string s)
        {
            string NewLine = "";
            int indexCheck = 1;
            int numLines = s.Trim().Split("\n").Count();
            int numLines2 = s.Trim().Split("\n").Length;
            // read each line one by one
            foreach (string eachLine in s.Split("\n"))
            {
                string[] str = eachLine.Trim().Split(" ");
                NewLine += str[str.Length - 1];
                if (indexCheck++ < numLines)
                    NewLine += " ";
            }
            return NewLine;
        }



    }
}
