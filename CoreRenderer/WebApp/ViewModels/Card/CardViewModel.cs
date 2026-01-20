using Progress.Sitefinity.Renderer.Entities.Content;
using Progress.Sitefinity.Renderer.Models;
using Progress.Sitefinity.RestSdk.Dto;
using System.Collections.Generic;

namespace WebApp.ViewModels.Card
{
    public class CardViewModel
    {
        public ImageDto Image { get; set; }
        public string CardTitle { get; set; }
        public string CardSubtitle { get; set; }
        public string CardText { get; set; }
        public string LinkText { get; set; }
        public LinkModel Link { get; set; }
        public string ViewName { get; set; }
    }
}
