using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Animals.Interfaces;
using Animals.DL;
using System.IO;
using System.Xml.Serialization;

namespace Animals.BL
{
    public class CatList : List<Cat>
    {
        public void Save()
        {
            try
            {
                CFile oFile = new CFile();
                oFile.Delete("Cat.txt");

                foreach (Cat oCat in this)
                {
                    oCat.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void SaveXML()
        {

            try
            {
                CFile oFile = new CFile("Cat.xml");
                oFile.Delete("Cat.xml");
                oFile.SaveXML(this, typeof(List<Cat>));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cat>));
            TextReader textReader = new StreamReader("Cat.xml");
            this.AddRange((List<Cat>)serializer.Deserialize(textReader));
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }


    }
}
