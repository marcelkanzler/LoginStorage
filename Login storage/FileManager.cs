using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Login_storage
{
    class FileManager
    {
        private string path = "";

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        private string content = null;

       public FileManager(String path)
        {
            this.path = path;
            UpdatePath();
        }

       public void WriteFile(String content)
       {
           UpdatePath();
           File.WriteAllText(path, content, Encoding.UTF8);
           this.content = content;
        }

       public string ReadFile()
       {
           if (System.IO.File.Exists(this.path))
           {
               string[] toSplittContent = File.ReadAllLines(this.path, Encoding.UTF8);
               string toReturn = "";
               for (int i = 0; i < toSplittContent.Length; i++)
               {
                   if (i != 0)
                   {
                       toReturn = "\n" + toSplittContent[i];
                   }
                   else
                   {
                       toReturn = toSplittContent[i];
                   }
               }
               return toReturn;
           }
           else
           {
               UpdatePath();
               return null;
           }
       }


       private void UpdatePath()
       {
           if (!System.IO.File.Exists(this.path))
           {
               String[] spllittetPath = this.path.Split('\\');
               System.IO.Directory.CreateDirectory(path.Replace(spllittetPath[spllittetPath.Length - 1], ""));
           }
       }

    }
}
