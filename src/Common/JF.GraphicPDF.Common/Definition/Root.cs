using JF.GraphicPDF.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JF.GraphicPDF.Definition
{
    public class Root : IRoot
    {
        private PageSize _pageSize = PageSize.Letter;

        public List<ISection> Sections { get; } = new List<ISection>();

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
