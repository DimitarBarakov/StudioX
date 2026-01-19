using Progress.Sitefinity.AspNetCore.ViewComponents.AttributeConfigurator.Attributes;
using Progress.Sitefinity.AspNetCore.Widgets.Models.Navigation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{
    public class ExtendedNavigationEntity:NavigationEntity
    {
        [DisplayName("Title")]
        public string NavigationTitle { get; set; }

        [ColorPalette("Default")]
        [DisplayName("Color")]
        public string DefaultColor { get; set; }
    }
}
