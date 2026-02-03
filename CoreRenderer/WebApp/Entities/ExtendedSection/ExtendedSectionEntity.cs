using Progress.Sitefinity.AspNetCore.ViewComponents.AttributeConfigurator.Attributes;
using Progress.Sitefinity.AspNetCore.Widgets.Models.Section;

namespace WebApp.Entities.ExtendedSection
{
    public class ExtendedSectionEntity:SectionEntity
    {
        [ViewSelector]
        public string View { get; set; }
    }
}
