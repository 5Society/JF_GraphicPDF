using JF.GraphicPDF.Generator;

namespace JF.GraphicPDF.Generator.ConsoleTest
{
    internal static class PdfJob
    {
        public static void CreatePDF(string sourceFilePath, string jsonFilePath, string destinationFilePath)
        {
            sourceFilePath= Path.GetFullPath(sourceFilePath);
            jsonFilePath = Path.GetFullPath(jsonFilePath);
            destinationFilePath = Path.GetFullPath(destinationFilePath);

            string layout = ReadFile(sourceFilePath);
            string json = ReadFile(jsonFilePath);
            PdfCreator pdfCreator = new PdfCreator(layout);
            string base64String = pdfCreator.Create(json);
            // Convertir la cadena Base64 en un arreglo de bytes
            byte[] fileBytes = Convert.FromBase64String(base64String);
            // Guardar el arreglo de bytes como un archivo en la ruta especificada
            string directoryPath = Path.GetDirectoryName(destinationFilePath)!;
            Directory.CreateDirectory(directoryPath);
            File.WriteAllBytes(destinationFilePath, fileBytes);
        }

        /// <summary>
        /// Lectura de un archivo de texto
        /// </summary>
        /// <param name="filePath">Ruta del archivo</param>
        /// <returns>Contenido del archivo si existe</returns>
        public static string ReadFile(string filePath)
        {
            string fileContent = string.Empty;
            try
            {
                // Verificar si el archivo existe
                if (File.Exists(filePath))
                {
                    // Leer todo el contenido del archivo
                    fileContent = File.ReadAllText(filePath);
                }
                else
                {
                    Console.WriteLine("El archivo no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
            return fileContent;
        }
    }
}
