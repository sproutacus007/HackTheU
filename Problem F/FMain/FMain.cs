using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace ProblemF
{
    class FMain
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "Text File | *.txt";
            open.Filter = "Text File | *.txt";
            open.ShowDialog();
            string[] text = File.ReadAllLines(open.FileName);
            foreach (string line in text)
            {
                if (Int32.TryParse(line, out int x) && x <= 500 && x >= 1)
                {
                    
                }
            }
        }

        private static int ReadFile(OpenFileDialog open)
        {

            throw new NotImplementedException();
        }
    }
}
