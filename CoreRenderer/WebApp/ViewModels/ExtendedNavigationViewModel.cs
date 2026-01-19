using Progress.Sitefinity.AspNetCore.Widgets.Models.Navigation;

namespace WebApp.ViewModels
{
    public class ExtendedNavigationViewModel:NavigationViewModel
    {
        public ExtendedNavigationViewModel(NavigationViewModel source)
        {
            this.Nodes = source.Nodes;
            this.Attributes = source.Attributes;
            this.WrapperCssClass = source.WrapperCssClass;
        }
        public string NavigationTitle { get; set; }
        public string DefaultColor { get; set; }
    }
}
