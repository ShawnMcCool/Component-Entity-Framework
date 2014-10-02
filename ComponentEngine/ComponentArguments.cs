using System;
using System.Collections.Generic;

namespace ComponentEngine
{
    public class ComponentArguments
    {
        Dictionary<String, String> arguments = new Dictionary<String, String>();

        public void Add(String key, String value) {
            arguments.Add(key, value);
        }

        public String Get(String key) {
            if (! arguments.ContainsKey(key))
                throw new ComponentArgumentNotFound();
            return arguments[key];
        }
    }
}

