namespace DynamicComponentsDemo.Extensions
{
    public static class GetDictionaryForDynamicComponentExtensions
    {
        public static Dictionary<string, object> GetParametersForDynamicComponent<T>(this T source)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            foreach (var property in source.GetType().GetProperties())
            {
                parameters.Add(property.Name, property.GetValue(source));
            }

            return parameters;
        }
    }
}
