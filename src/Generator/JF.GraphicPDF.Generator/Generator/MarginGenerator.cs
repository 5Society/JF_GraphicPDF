
using iText.Kernel.Pdf;
using iText.Layout;
using JF.GraphicPDF.Definitions;
using System.Runtime.CompilerServices;

namespace JF.GraphicPDF.Generator.Generator
{
    public class MarginGenerator: ElementGenerator
    {
        
        public override void Generate(PdfDocument pdfDocument, Document document)
        {
            Margin? margin = (Margin?)_elementDefinition;
            if (margin != null)
            {
                document.SetMargins(margin.TopMargin, margin.RightMargin, margin.BottomMargin, margin.LeftMargin);
            }
            base.Generate(pdfDocument, document);
        }
    }
}
