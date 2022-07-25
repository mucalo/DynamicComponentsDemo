using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Models
{
    public interface IMyComponentParameters
    {
        DateTime CreatedAt { get; set; }
        EventCallback<string> OnButtonClicked { get; set; }
    }
}
