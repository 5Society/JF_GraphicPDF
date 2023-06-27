using iText.Layout;
using iText.Layout.Element;
using JF.GraphicPDF.Definition;

namespace JF.GraphicPDF.Generator.Generator
{
    internal class SectionGenerator : ISectionGenerator
    {
        ISection Section { get; }

        public SectionGenerator(ISection section)
        { 
            Section = section;
        }

        public void AddSection(Document document)
        {
            document.SetMargins(10, 10, 10, 10);
            document.Add(new Paragraph("Sección 1"));
        }
    }
}
