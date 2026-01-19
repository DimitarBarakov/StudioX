using Progress.Sitefinity.Renderer.Entities.Content;
using Progress.Sitefinity.RestSdk.Dto;

namespace WebApp.ViewModels.Card
{
    public class CardViewModel
    {
        public ImageDto Image { get; set; }
        public string CardTitle { get; set; }
        public string CardText { get; set; }
    }
}
