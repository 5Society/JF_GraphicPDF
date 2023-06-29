using iText.Kernel.Geom;
using JF.GraphicPDF.Definition;

namespace JF.GraphicPDF.Generator.Generator
{
    public interface IPdfGenerator: IElementGenerator
    {
        void GenerateDocument(string outputPath);
        Root? Root { get; }
        PageSize GetPdfPageSize();
    }
}
