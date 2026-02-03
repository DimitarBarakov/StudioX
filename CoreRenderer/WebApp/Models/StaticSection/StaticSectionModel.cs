using Progress.Sitefinity.AspNetCore.ViewComponents;
using Progress.Sitefinity.AspNetCore.Widgets.Models.Section;
using Progress.Sitefinity.AspNetCore.Widgets.ViewComponents.Common;
using Progress.Sitefinity.RestSdk;
using System;
using System.Text;
using System.Threading.Tasks;
using ViewComponents.StaticSection;
using WebApp.ViewModels.StaticSection;

namespace WebApp.Models.StaticSection
{
    public class StaticSectionModel : SectionModel
    {
        private IRestClient service;
        private IStyleClassesProvider styles;

        public StaticSectionModel(IStyleClassesProvider styles, IRestClient service) : base(styles, service)
        {
            if (service == null)
            {
                throw new ArgumentNullException(nameof(service));
            }

            this.service = service;
            this.styles = styles;
        }
        public StaticSectionViewModel InitializeViewModel(StaticSectionEntity entity, ICompositeViewComponentContext<StaticSectionEntity> context)
        {
            var viewModel = new StaticSectionViewModel
            {
                //WrapperCssClass = $"{entity.CssClass} {ConstructSectionClass(entity)}",
                //Context = context,
                //BackgroudColor = entity.BackgroundColor,
                //RoundingPixels = entity.RoundingPixels,
                //ViewType = entity.ViewType
            };

            return viewModel;
        }
        private string ConstructSectionClass(SectionEntity entity)
        {
            StringBuilder sectionCss = new StringBuilder();

            var paddings = this.styles.GetPaddingsClasses(entity.SectionPadding);
            if (!string.IsNullOrEmpty(paddings))
            {
                sectionCss.Append(paddings + " ");
            }

            var margins = this.styles.GetMarginsClasses(entity.SectionMargin);
            if (!string.IsNullOrEmpty(margins))
            {
                sectionCss.Append(margins + " ");
            }

            return sectionCss.ToString().TrimEnd();
        }
    }
}
