using iText.Kernel.Pdf;
using iText.Layout;
using JF.GraphicPDF.Definitions;

namespace JF.GraphicPDF.Generator.Generator
{
    public interface IElementGenerator
    {
        IElement? GetDefinitionElement();
        void SetDefinitionElement(IElement element);
        void Generate(PdfDocument pdfDocument, Document document);

    }
}
