using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Models
{
    public class IComponentParameters
    {
        public DateTime CreatedAt { get; set; }
        public EventCallback<string> OnButtonClicked { get; set; }
    }
}
