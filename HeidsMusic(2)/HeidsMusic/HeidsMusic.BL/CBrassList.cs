using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeidsMusic.Interfaces;
using HeidsMusic.DL;
using System.IO;
using System.Xml.Serialization;
namespace HeidsMusic.BL
{
    public class CBrassList : List<CBrass>, IInstruments
    {
       
        public void Save()
        {
            try
            {
                CFile oFile = new CFile();
                oFile.Delete("Brass.txt");

                foreach (CBrass oBrass in this)
                {
                    oBrass.Save();
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
                CFile oFile = new CFile("Brass.xml");
                oFile.Delete("Brass.xml");
                oFile.SaveXML(this, typeof(List<CBrass>));
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<CBrass>));
            TextReader textReader = new StreamReader("Brass.xml");
            this.AddRange((List<CBrass>)serializer.Deserialize(textReader));
            textReader.Close();
            textReader.Dispose();
            textReader = null;
        }


    }
}
