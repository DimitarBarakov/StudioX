using Progress.Sitefinity.AspNetCore.Web;
using Progress.Sitefinity.AspNetCore.Widgets.Models.Navigation;
using Progress.Sitefinity.AspNetCore.Widgets.ViewComponents.Common;
using Progress.Sitefinity.RestSdk.OData;
using System.Threading.Tasks;
using WebApp.Entities;
using WebApp.ViewModels;

namespace WebApp.Models
{
    public class ExtendedNavigationModel : NavigationModel
    {
        public ExtendedNavigationModel(IODataRestClient restService, IStyleClassesProvider styles, IRequestContext requestContext) 
            : base(restService, styles, requestContext)
        {
        }
        public override async Task<NavigationViewModel> InitializeViewModel(NavigationEntity entity)
        {
            var viewModel = await base.InitializeViewModel(entity).ConfigureAwait(false);
            return new ExtendedNavigationViewModel(viewModel)
            {
                NavigationTitle = (entity as ExtendedNavigationEntity).NavigationTitle,
                DefaultColor = (entity as ExtendedNavigationEntity).DefaultColor
            };
            //return base.InitializeViewModel(entity);
        }
    }
}
