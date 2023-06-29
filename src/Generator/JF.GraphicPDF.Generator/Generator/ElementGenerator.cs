using iText.Kernel.Pdf;
using iText.Layout;
using JF.GraphicPDF.Definitions;

namespace JF.GraphicPDF.Generator.Generator
{
    public class ElementGenerator : IElementGenerator
    {
        internal IElement? _elementDefinition;

        public virtual void Generate(PdfDocument pdfDocument, Document document)
        {
            
        }

        public IElement? GetDefinitionElement() => _elementDefinition;
        
        public void SetDefinitionElement(IElement element) => _elementDefinition=element;
    }
}
