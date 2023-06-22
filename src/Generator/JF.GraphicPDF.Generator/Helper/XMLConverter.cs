using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JF.GraphicPDF.Generator.Helper
{
    public static class XMLConverter
    {
        /// <summary>
        /// Convertir string en XML
        /// </summary>
        /// <param name="xmlString">string en formato XML</param>
        /// <returns>Objeto de tipo XMLDocument si su conversión fue exitosa</returns>
        public static XmlDocument? ConvertToXml(string xmlString)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlString);
                return xmlDoc;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir la cadena a XML: " + ex.Message);
                return null;
            }
        }
    }
}
