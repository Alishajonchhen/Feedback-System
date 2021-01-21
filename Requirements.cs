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
        

        public List<Requirements> SortingByCriteria(List<Requirements> list)
        {
            string criteria;
            

            if (list != null)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    for (int b = a + 1; b < list.Count; b++)
                    {
                        if (list[a].Criteria.ToUpper().CompareTo(list[b].Criteria.ToUpper()) > 0)
                        {
                            criteria = list[a].Criteria;
                            list[a].Criteria = list[b].Criteria;
                            list[b].Criteria = criteria;

                        }
                    }
                }
                return list;
            }
            return null;
        }
    }
}

