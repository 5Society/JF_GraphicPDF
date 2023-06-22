using JF.GraphicPDF.Generator.Helper;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace JF.GraphicPDF.Generator
{
    public class PdfCreator
    {
        private XmlDocument? _layout;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="layout"></param>
        public PdfCreator(XmlDocument layout)
        { 
            _layout = layout;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="layout"></param>
        public PdfCreator(string layout)
        {
            _layout = XMLConverter.ConvertToXml(layout);
        }

        /// <summary>
        /// Crea PDF de acuerdo a la plantilla definida combinandola con el json que incluye la data 
        /// </summary>
        /// <param name="jsonDocument">Documento Json con los datos necesarios a combinar con la plantilla</param>
        /// <returns>PDF generado en base64</returns>
        public string Create(string jsonDocument)
        { 
            JObject? json = JSONConverter.ConvertToJson(jsonDocument);
            return (json == null)? "":Create(json!);
        }

        /// <summary>
        /// Crea PDF de acuerdo a la plantilla definida combinandola con el json que incluye la data 
        /// </summary>
        /// <param name="jsonDocument">Documento Json con los datos necesarios a combinar con la plantilla</param>
        /// <returns>PDF generado en base64</returns>
        public string Create(JObject jsonDocument)
        {
            XmlDocument xmlDoc;
            xmlDoc = _layout!;
            string outputPath = FilePathGenerator.GenerateFilePath();
            string directoryPath = Path.GetDirectoryName(outputPath)!;
            Directory.CreateDirectory(directoryPath);
            PdfGenerator.GeneratePdfFromXml(xmlDoc, outputPath);
            byte[] fileBytes = File.ReadAllBytes(outputPath);
            return Convert.ToBase64String(fileBytes);
        }
    }
}
