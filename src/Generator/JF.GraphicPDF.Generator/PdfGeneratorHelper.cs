
using System.Xml;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using JF.GraphicPDF.Definition;
using JF.GraphicPDF.Generator.Generator;

namespace JF.GraphicPDF.Generator
{

    public static class PdfGeneratorHelper
    {
        /// <summary>
        /// Genera PDF de acuerdo a un documento XML definido
        /// </summary>
        /// <param name="xmlDoc">Documento XML a convertir en PDF</param>
        /// <param name="outputPath">Ruta en donde se almacenará el PDF</param>
        /// <returns></returns>
        public static string GeneratePdf64FromXml(XmlDocument xmlDoc, string outputPath)
        {
            GeneratePdfFromXml(xmlDoc, outputPath);
            byte[] fileBytes = File.ReadAllBytes(outputPath);
            return Convert.ToBase64String(fileBytes);
        }

        /// <summary>
        /// Genera PDF de acuerdo a un documento XML definido.
        /// </summary>
        /// <param name="xmlDoc">Documento XML a convertir en PDF</param>
        /// <param name="outputPath">Ruta en donde se almacenará el PDF</param>
        public static void GeneratePdfFromXml(XmlDocument xmlDoc, string outputPath)
        {
            //Convierte el XML en un documento
            PdfGenerator document = new();
            document.SetPageSize(Enum.PageSize.Letter);
            for (int i = 0; i < 4; i++)
            {
                ISection section = new Section();
                document.AddSection(section);
            }

            document.GenerateDocument(outputPath);

            /*
            // Crear el documento PDF
            PdfWriter pdfWriter = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document document = new Document(pdf);

            // Obtener los elementos del XML
            var elements = xmlDoc.GetElementsByTagName("element");

            // Recorrer los elementos y generar el contenido del PDF
            foreach (XmlElement element in elements)
            {
                switch (element.Attributes["Name"]!.Value.ToLower())
                {
                    case "text":
                        // Crear un párrafo con el texto y aplicar estilos si es necesario
                        var paragraph = new Paragraph(element.InnerText);
                        //ApplyStyles(element, paragraph);
                        document.Add(paragraph);
                        break;

                    case "table":
                        // Crear una tabla y agregar filas y celdas
                        var table = new PdfPTable(element.ChildNodes.Count);
                        ApplyStyles(element, table);
                        foreach (XmlElement rowElement in element.ChildNodes)
                        {
                            var row = new PdfPCell[rowElement.ChildNodes.Count];
                            for (int i = 0; i < rowElement.ChildNodes.Count; i++)
                            {
                                var cellElement = (XmlElement)rowElement.ChildNodes[i];
                                row[i] = new PdfPCell(new Phrase(cellElement.InnerText));
                                ApplyStyles(cellElement, row[i]);
                                table.AddCell(row[i]);
                            }
                        }
                        document.Add(table);
                        break;

                    case "image":
                        // Insertar una imagen en el PDF
                        var imagePath = element.InnerText;
                        var image = Image.GetInstance(imagePath);
                        ApplyStyles(element, image);
                        document.Add(image);
                        break;

                    case "line":
                        // Insertar una línea en el PDF
                        var line = new LineSeparator();
                        ApplyStyles(element, line);
                        document.Add(line);
                        break;

                }
            }

            document.Close();
            */            
        }

        /*
        private void ApplyStyles(XmlElement element, Element pdfElement)
        {
            // Aplicar estilos al elemento del PDF basado en los atributos del XML
            if (element.HasAttributes)
            {
                var font = pdfElement.Font ?? FontFactory.GetFont();
                var fontSize = font.Size;

                if (element.HasAttribute("font-family"))
                {
                    var fontFamily = element.GetAttribute("font-family");
                    font = FontFactory.GetFont(fontFamily, fontSize);
                }

                if (element.HasAttribute("font-size"))
                {
                    var fontSizeStr = element.GetAttribute("font-size");
                    if (float.TryParse(fontSizeStr, out var parsedFontSize))
                    {
                        font = FontFactory.GetFont(font.Familyname, parsedFontSize);
                    }
                }

                if (element.HasAttribute("font-style"))
                {
                    var fontStyle = element.GetAttribute("font-style");
                    switch (fontStyle)
                    {
                        case "bold":
                            font.SetStyle(Font.BOLD);
                            break;
                        case "italic":
                            font.SetStyle(Font.ITALIC);
                            break;
                        case "underline":
                            font.SetStyle(Font.UNDERLINE);
                            break;
                    }
                }

                pdfElement.Font = font;
            }
        }
        */
    }
}
