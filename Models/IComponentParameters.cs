using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Models
{
    public interface IComponentParameters
    {
        DateTime CreatedAt { get; set; }
        EventCallback<string> OnButtonClicked { get; set; }
    }
}
