
namespace JF.GraphicPDF.Definitions
{

    /// <summary>
    /// Definición del documento a crear
    /// </summary>
    public interface IRoot: IElement
    {
        List<ISection> Sections { get; }
        PageSize PageSize { get; }
        void AddSection(ISection section);
        void RemoveSection(ISection section);
        void SetPageSize(PageSize pageSize);
      
    }
}

