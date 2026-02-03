using Progress.Sitefinity.AspNetCore.Widgets.Models.Section;
using Progress.Sitefinity.AspNetCore.Widgets.ViewComponents.Common;
using Progress.Sitefinity.RestSdk;
using System.Threading.Tasks;
using WebApp.Entities.ExtendedSection;
using WebApp.ViewModels.ExtendedSection;

namespace WebApp.Models.ExtendedSection
{
    public class ExtendedSectionModel : SectionModel
    {
        public ExtendedSectionModel(IStyleClassesProvider styles, IRestClient service) : base(styles, service)
        {
        }

        public override async Task<SectionViewModel> InitializeViewModel(SectionEntity entity)
        {
            var viewModel = await base.InitializeViewModel(entity).ConfigureAwait(false);

            return new ExtendedSectionViewModel(viewModel)
            {
                View = (entity as ExtendedSectionEntity).View
            };
        }
    }
}
