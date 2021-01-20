using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReview

{
    class Requirements
    {
        public string Criteria { get; set; }
        private string _filepath = "criteriadata.txt";

        public string Save(Requirements r)
        {
            string data = JsonConvert.SerializeObject(r, Formatting.None);
            Utility.WriteToTextFile(_filepath, data);
            return "Success";
        }
        public List<Requirements> List()
        {
            string d = Utility.ReadFromTextFile(_filepath);
            if (d != null)
            {
                List<Requirements> list = JsonConvert.DeserializeObject<List<Requirements>>(d);
                return list;
            }
            return null;
        }
    }
}

