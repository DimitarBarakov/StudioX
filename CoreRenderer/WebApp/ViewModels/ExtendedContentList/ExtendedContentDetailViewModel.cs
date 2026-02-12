using Progress.Sitefinity.AspNetCore.Widgets.Models.ContentList;

namespace WebApp.ViewModels.ExtendedContentList
{
    public class ExtendedContentDetailViewModel : ContentDetailViewModel
    {
        public ExtendedContentDetailViewModel(ContentDetailViewModel source) : base(source.Item)
        {
            this.CssClass = source.CssClass;
        }

        public string WhereLabel { get; set; }

        public string WhenLabel { get; set; }
    }
}
