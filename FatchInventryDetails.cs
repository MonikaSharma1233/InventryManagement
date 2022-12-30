using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace InventryManagement
{
    public class FatchInventryDetails
    {
        public Details Read(String path)//method detail datatype method name is read
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    String json=file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Details>(json);

                }
                catch
                {
                    return null;
                }
            }
        }

    }
}
