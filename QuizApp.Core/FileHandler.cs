using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Core
{
    public class FileHandler
    {
        private string path = "";
        private string fileName = "";
        public String Path
        {
            get
            {
                return path;
            }
            set => path = value;
        }

        public string FileName {
            get {
                return fileName;
            }
            set {
                fileName = value;
            }
        }
    }
}
