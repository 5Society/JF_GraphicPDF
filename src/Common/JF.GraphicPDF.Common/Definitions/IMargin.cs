namespace JF.GraphicPDF.Definitions
{
    public interface IMargin: IElement
    {
        float TopMargin { get; set; }
        float BottomMargin { get; set; }
        float LeftMargin { get; set; }
        float RightMargin { get; set; }
    }
}
