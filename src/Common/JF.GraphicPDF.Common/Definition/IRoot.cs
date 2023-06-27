using JF.GraphicPDF.Enum;

namespace JF.GraphicPDF.Definition
{

    /// <summary>
    /// Definición del documento a crear
    /// </summary>
    public interface IRoot
    {
        List<ISection> Sections { get; }
        PageSize PageSize { get; }
        void AddSection(ISection section);
        void RemoveSection(ISection section);
        void SetPageSize(PageSize pageSize);
    }
}

