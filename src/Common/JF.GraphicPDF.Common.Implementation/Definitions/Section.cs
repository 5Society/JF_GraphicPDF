
namespace JF.GraphicPDF.Definitions
{
    public class Section: ISection
    {
        public string Prueba { get; set; } = "a";
        public IMargin Margin { get; set; }

        public Section()
        {
            Margin = new Margin(10, 10, 10, 10);
        }
    }
}
