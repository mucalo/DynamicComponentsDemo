using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Models
{
    public class MyComponentParameters : ComponentParameters, IMyComponentParameters
    {
        public DateTime CreatedAt { get; set; }
        public EventCallback<string> OnButtonClicked { get; set; }
    }
}
