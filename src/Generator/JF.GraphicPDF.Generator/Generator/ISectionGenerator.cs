using iText.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JF.GraphicPDF.Generator.Generator
{
    internal interface ISectionGenerator
    {
        void AddSection(Document document);
    }
}
