using Progress.Sitefinity.AspNetCore.Widgets.Models.ContentList;

namespace WebApp.ViewModels.ExtendedContentList
{
    public class ExtendedContentListViewModel : ContentListViewModel
    {
        public ExtendedContentListViewModel(ContentListViewModel source)
        {
            this.Pager = source.Pager;
            this.Items = source.Items;
            this.DetailItemUrl = source.DetailItemUrl;
            this.RenderLinks = source.RenderLinks;
            this.ListFieldMapping = source.ListFieldMapping;
        }
        public string Heading { get; set; }

        public bool SmallList { get; set; }
    }
}
