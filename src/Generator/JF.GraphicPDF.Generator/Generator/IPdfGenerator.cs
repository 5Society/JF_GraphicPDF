using iText.Kernel.Geom;

namespace JF.GraphicPDF.Generator.Generator
{
    public interface IPdfGenerator
    {
        void GenerateDocument(string outputPath);
        PageSize GetPdfPageSize();
    }
}
