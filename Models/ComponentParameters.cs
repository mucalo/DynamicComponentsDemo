﻿using Microsoft.AspNetCore.Components;

namespace DynamicComponentsDemo.Models
{
    public class ComponentParameters
    {
        public Dictionary<string, object> GetParameterDictionary()
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            foreach (var property in this.GetType().GetProperties())
            {
                parameters.Add(property.Name, property.GetValue(this));
            }

            return parameters;
        }
    }
}
