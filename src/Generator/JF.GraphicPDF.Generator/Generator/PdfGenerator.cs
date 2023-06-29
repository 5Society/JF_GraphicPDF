using System.ComponentModel.Design;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using JF.GraphicPDF.Definition;
using JF.GraphicPDF.Definitions;

namespace JF.GraphicPDF.Generator.Generator
{
    internal class PdfGenerator : ElementGenerator, IPdfGenerator
    {

        public Root? Root => (Root?)_elementDefinition;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="root"></param>
        public PdfGenerator(Root root)
        {
            _elementDefinition = root;
        }

        public override void Generate(PdfDocument pdfDocument, Document document)
        {
            pdfDocument.SetDefaultPageSize(GetPdfPageSize());

            if (Root != null)
            {

                //Crea las secciones del PDF
                foreach (Section item in Root.Sections)
                {
                    ISectionGenerator sectionGenerator = new SectionGenerator(item);
                    sectionGenerator.Generate(pdfDocument, document);
                    if (item != Root.Sections.Last())
                        document.Add(new AreaBreak());
                }
            }

            base.Generate(pdfDocument, document);
        }

        public void GenerateDocument(string outputPath)
        {
            // Crear el documento PDF
            PdfWriter pdfWriter = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document document = new Document(pdf);
            Generate(pdf, document);

            //Cierra el documento
            document.Close();
        }

        public iText.Kernel.Geom.PageSize GetPdfPageSize()
        {
            iText.Kernel.Geom.PageSize result = iText.Kernel.Geom.PageSize.LETTER;
            if (Root != null)
            {
                switch (Root.PageSize)
                {
                    case Definitions.PageSize.Letter:
                        result = iText.Kernel.Geom.PageSize.LETTER;
                        break;
                    case Definitions.PageSize.Legal:
                        result = iText.Kernel.Geom.PageSize.LEGAL;
                        break;
                    default:
                        result = iText.Kernel.Geom.PageSize.LETTER;
                        break;
                }
            }
            return result;

        }

    }
}
