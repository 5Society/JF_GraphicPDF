using iText.Kernel.Pdf;
using iText.Layout;
using JF.GraphicPDF.Definitions;

namespace JF.GraphicPDF.Generator.Generator
{
    internal class SectionGenerator : ElementGenerator, ISectionGenerator
    {
        public List<IElement> Elements => new List<IElement>();

        public Section? Section => (Section?)_elementDefinition;

        public MarginGenerator MarginGenerator { get; set; }

        public SectionGenerator(ISection section)
        { 
            _elementDefinition = (IElement?)section;
            MarginGenerator = new MarginGenerator();
            if (Section!.Margin != null) MarginGenerator.SetDefinitionElement(Section!.Margin);
        }


        public override void Generate(PdfDocument pdfDocument, Document document)
        {
            MarginGenerator.Generate(pdfDocument, document);
            document.Add(new iText.Layout.Element.Paragraph("Sección 1"));
            base.Generate(pdfDocument, document);
        }

        public void AddElement(IElement element)=>            
            Elements.Add(element);
        

        public void RemoveElement(IElement element)=>
            Elements.Remove(element);

       }
}
