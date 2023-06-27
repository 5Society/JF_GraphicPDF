using System.ComponentModel.Design;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using JF.GraphicPDF.Definition;

namespace JF.GraphicPDF.Generator.Generator
{
    internal class PdfGenerator: Root, IPdfGenerator
    {
        /// <summary>
        /// Creación de un objeto de clase PdfGenerator a partir de un documento root 
        /// </summary>
        /// <param name="document">Documento a generar</param>
        /// <returns></returns>
        public static PdfGenerator Create(IRoot document) => (PdfGenerator)document;

        public void GenerateDocument(string outputPath)
        {
            // Crear el documento PDF
            PdfWriter pdfWriter = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document document = new Document(pdf);

            pdf.SetDefaultPageSize(GetPdfPageSize());

            //Crea las secciones del PDF
            foreach (Section item in Sections)
            {
                SectionGenerator sectionGenerator = new(item);
                sectionGenerator.AddSection(document);
                if(item!=Sections.Last()) 
                    document.Add(new AreaBreak());
            }

            //Cierra el documento
            document.Close();
        }

        public PageSize GetPdfPageSize()
        {
            PageSize result;
            switch (this.PageSize)
            {
                case Enum.PageSize.Letter:
                    result = iText.Kernel.Geom.PageSize.LETTER;
                    break;
                case Enum.PageSize.Legal:
                    result = iText.Kernel.Geom.PageSize.LEGAL;
                    break;
                default:
                    result = iText.Kernel.Geom.PageSize.LETTER;
                    break;
            }
            return result;

        }
    }
}
