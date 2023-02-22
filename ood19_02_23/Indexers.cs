using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
        public class MyDictionary
        {
            private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

            // Define the indexer with the "this" keyword.
            // This allows you to use the [] syntax to access elements of the dictionary.
            public string this[string key]
            {
                get
                {
                    // If the key exists in the dictionary, return the corresponding value.
                    if (_dictionary.ContainsKey(key))
                    {
                        return _dictionary[key];
                    }
                    // Otherwise, return null.
                    return null;
                }
                set
                {
                    // If the key already exists in the dictionary, update the value.
                    if (_dictionary.ContainsKey(key))
                    {
                        _dictionary[key] = value;
                    }
                    // Otherwise, add the key-value pair to the dictionary.
                    else
                    {
                        _dictionary.Add(key, value);
                    }
                }
            }
        }
    
}
