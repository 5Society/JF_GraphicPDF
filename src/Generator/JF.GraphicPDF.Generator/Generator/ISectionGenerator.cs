using JF.GraphicPDF.Definitions;


namespace JF.GraphicPDF.Generator.Generator
{
    internal interface ISectionGenerator: IElementGenerator
    {
        Section? Section { get; }

        MarginGenerator MarginGenerator { get; set; }
        List<IElement> Elements { get; }
        void AddElement(IElement element);
        void RemoveElement(IElement element);
    }
}
