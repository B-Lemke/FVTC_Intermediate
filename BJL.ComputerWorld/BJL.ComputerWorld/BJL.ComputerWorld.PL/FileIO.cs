using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BJL.ComputerWorld.PL
{
    public class FileIO
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }




        public string Read()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    //open stream reader, 
                    StreamReader sr = new StreamReader(fileName);
                    sr = File.OpenText(fileName);

                    string contents = sr.ReadToEnd();

                    sr.Close();

                    sr = null;

                    return contents;

                }
                else
                {
                    throw new Exception("File Does Not Exist. (" + fileName + " ) ");
                }
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public void Write(string contents)
        {
            try
            {
                StreamWriter sw = File.AppendText(fileName);
                sw.WriteLine(contents);
                sw.Close();
                sw = null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Move(string target)
        {
            try
            {
                File.Move(fileName, target);
                fileName = target;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Copy(string target)
        {
            try
            {
                File.Copy(fileName, target);
                fileName = target;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }



    }
    
}
