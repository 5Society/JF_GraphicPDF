using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JF.GraphicPDF.Generator.Helper
{
    public static class JSONConverter
    {
        /// <summary>
        /// Convertir string en Json
        /// </summary>
        /// <param name="jsonString">string en formato Json</param>
        /// <returns>Objeto de tipo JObject si su conversión fue exitosa</returns>
        public static JObject? ConvertToJson(string jsonString)
        {
            try
            {
                JObject json = JObject.Parse(jsonString);
                return json;
            }
            catch (JsonReaderException ex)
            {
                Console.WriteLine("Error al convertir la cadena a JSON: " + ex.Message);
                return null;
            }
        }
    }
}
