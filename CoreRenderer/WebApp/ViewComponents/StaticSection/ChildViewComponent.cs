using Microsoft.AspNetCore.Mvc;
using Progress.Sitefinity.AspNetCore.ViewComponents;
using System;

namespace WebApp.ViewComponents.StaticSection
{
    [SitefinityWidget]
    public class ChildViewComponent : ViewComponent     
    {
        public IViewComponentResult Invoke(IViewComponentContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            return this.View(context);
        }
    }
}
