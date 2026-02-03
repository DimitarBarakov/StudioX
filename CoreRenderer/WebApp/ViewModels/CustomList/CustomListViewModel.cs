using Progress.Sitefinity.Renderer.Models;
using System.Collections.Generic;
using ViewComponents.CustomList;

namespace WebApp.ViewModels.CustomList
{
    public class CustomListViewModel
    {
        public string Title { get; set; }

        public IList<ListItemBase> Items { get; set; } = new List<ListItemBase>();

        public LinkModel Link { get; set; }
        public string LinkText { get; set; }
        public string TextAlign { get; set; }
        public string Margin{ get; set; }
    }
}
