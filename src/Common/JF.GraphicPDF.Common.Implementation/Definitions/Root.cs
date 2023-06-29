using JF.GraphicPDF.Definitions;
using System.Xml;
using System.Xml.Serialization;


namespace JF.GraphicPDF.Definition
{
    public class Root : IRoot
    {
        
        private PageSize _pageSize = PageSize.Letter;

        [XmlArray("Sections")]
        [XmlArrayItem("Section")]
        public List<ISection> Sections { get; set; } = new List<ISection>();

        [XmlAttribute]
        public PageSize PageSize => _pageSize;

        public void AddSection(ISection section)
        {
            Sections.Add(section);
        }

        public void RemoveSection(ISection section)
        {
            Sections.Remove(section);
        }

        public void SetPageSize(PageSize pageSize)
        {
           this._pageSize = pageSize;
        }

        
    }
}
