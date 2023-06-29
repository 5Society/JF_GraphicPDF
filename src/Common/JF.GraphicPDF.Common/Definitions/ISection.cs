
namespace JF.GraphicPDF.Definitions
{
    /// <summary>
    /// Define cada sección del documento
    /// </summary>
    public interface ISection:IElement
    {
        IMargin Margin { get; set; }
    }
}
