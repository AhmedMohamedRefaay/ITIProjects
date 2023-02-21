using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    class PhoneBook 
    {
        Dictionary<int, string> dictionary;
        
        
        public PhoneBook()
        {
            dictionary= new Dictionary<int, string>();
            
           
        }
        public string this[int key]
        {
            set
            {
                dictionary.Add(key, value);

                
            }
            get
            {
                return dictionary[key];

            }
        }

        public int this[string key]
        {
            set
            {
                dictionary.Add(value, key);
            }
            get
            {
               
                foreach(KeyValuePair<int,string>val in dictionary)
                {
                    if (val.Value == key)
                        return val.Key;

                   
                }
                  return -1;


            }
        }
    }
}
