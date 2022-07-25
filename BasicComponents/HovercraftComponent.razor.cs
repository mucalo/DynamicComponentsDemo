using DynamicComponentsDemo.Models;
using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.BasicComponents
{
    public class HovercraftComponentBase : ComponentBase, IMyComponentParameters
    {
        [Parameter]
        public DateTime CreatedAt { get; set; }
        [Parameter]
        public EventCallback<string> OnButtonClicked { get; set; }

        protected string ActionDescription = "Hovercraft button clicked!";


    }
}
