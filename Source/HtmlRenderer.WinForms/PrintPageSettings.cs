using System;
using System.Collections.Generic;
using System.Text;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

//Used to make multiple pages for just printing the rendered HTML
namespace TheArtOfDev.HtmlRenderer.WinForms
{

    public class PrintPageSettings
    {
        public RSize pageSize { get; set; } = new RSize(99999, 99999);

        public int pageNum { get; set; } = 0;
    }
}
