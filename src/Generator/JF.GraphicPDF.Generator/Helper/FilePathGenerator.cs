
namespace JF.GraphicPDF.Generator.Helper
{
    public static class FilePathGenerator
    {

        /// <summary>
        /// Genera el nombre de archivo a crear
        /// </summary>
        /// <returns>Ruta del archivo a crear</returns>
        public static string GenerateFilePath()
        {
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string currentDate = DateTime.Now.ToString("yyyyMMdd.HH");
            string guid = Guid.NewGuid().ToString();
            string fileName = $"{guid}.pdf";

            string folderPath = Path.Combine(executablePath, currentDate);
            string filePath = Path.Combine(folderPath, fileName);

            return filePath;
        }
    }
}
