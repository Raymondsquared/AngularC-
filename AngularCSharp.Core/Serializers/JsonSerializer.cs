using System;
using AngularCSharp.Core.Interfaces;
using Newtonsoft.Json;

namespace AngularCSharp.Core.Serializers
{
    public class JsonSerializer : ISerializer
    {
        public T Deserialise<T>(string input)
        {            
            //return (T)Activator.CreateInstance(typeof (T));
            return JsonConvert.DeserializeObject<T>(input);
        }
    }
}
