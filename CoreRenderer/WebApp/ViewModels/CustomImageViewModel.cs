using Progress.Sitefinity.AspNetCore.ViewComponents.AttributeConfigurator.Attributes;
using Progress.Sitefinity.RestSdk.Dto;

namespace WebApp.ViewModels
{
    public class CustomImageViewModel
    {
        public ImageDto Image { get; set; }
        public string ViewName { get; set; }
    }
}
