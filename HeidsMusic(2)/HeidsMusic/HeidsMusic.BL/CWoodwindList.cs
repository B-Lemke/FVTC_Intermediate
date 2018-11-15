using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.DL;
using System.Xml.Serialization;
using System.IO;

namespace HeidsMusic.BL
{
    public class CWoodwindList : List<CWoodwind>, IInstruments
    {
        
        public void Save()
        {
            try
            {
                CFile oFile = new CFile();
                oFile.Delete("Woodwinds.txt");

                foreach (CWoodwind oWoodwind in this)
                {
                    oWoodwind.Save();
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
                CFile oFile = new CFile("Woodwinds.xml");
                oFile.Delete("Woodwinds.xml");
                oFile.SaveXML(this, typeof(List<CWoodwind>));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CWoodwind>));
            TextReader textReader = new StreamReader("Woodwinds.xml");
            this.AddRange((List<CWoodwind>)serializer.Deserialize(textReader));
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }
    }
}
