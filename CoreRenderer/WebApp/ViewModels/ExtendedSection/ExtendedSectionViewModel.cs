using Progress.Sitefinity.AspNetCore.Widgets.Models.Section;

namespace WebApp.ViewModels.ExtendedSection
{
    public class ExtendedSectionViewModel : SectionViewModel
    {
        public ExtendedSectionViewModel(SectionViewModel source)
        {
        }

        public string View { get; set; }
    }
}
