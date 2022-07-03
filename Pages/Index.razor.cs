using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Pages
{
    public class IndexBase : ComponentBase
    {
        private const string BASIC_CAR_COMPONENT = "DynamicComponentsDemo.BasicComponents.CarComponent";
        private const string BASIC_MOTORCYCLE_COMPONENT = "DynamicComponentsDemo.BasicComponents.MotorcycleComponent";
        private const string BASIC_BIKE_COMPONENT = "DynamicComponentsDemo.BasicComponents.BikeComponent";
        private const string CREATED_AT_PARAMETER = "CreatedAt";
        
        protected Type DynamicComponentType { get; set; } = Type.GetType(BASIC_CAR_COMPONENT);
        protected int SelectedVehicleType { get; set; } = 1;
        protected Dictionary<string, object> DynamicComponentParameters { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            DynamicComponentParameters = new();
            DynamicComponentParameters.Add(CREATED_AT_PARAMETER, DateTime.Now);
        }

        protected void SelectedVehicleChanged(ChangeEventArgs e)
        {
            SelectedVehicleType = Convert.ToInt32(e.Value);
            switch (SelectedVehicleType)
            {
                case 1:
                    DynamicComponentType = Type.GetType(BASIC_CAR_COMPONENT);
                    break;
                case 2:
                    DynamicComponentType = Type.GetType(BASIC_MOTORCYCLE_COMPONENT);
                    break;
                case 3:
                    DynamicComponentType = Type.GetType(BASIC_BIKE_COMPONENT);
                    break;
                default:
                    break;
            }
            DynamicComponentParameters[CREATED_AT_PARAMETER] = DateTime.Now;
        }
    }
}
