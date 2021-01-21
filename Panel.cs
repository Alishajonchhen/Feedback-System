using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReview
{
    class Panel
    {
        private string _path = "Review.txt";
        public string reviewername { get; set; }
        public string reviewerphone { get; set; }
        public string revieweremail { get; set; }
        public string reviewersuggest { get; set;}
        public string timer { get; set; }
       
        public String Save(Panel data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }
        public List<Panel> List()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<Panel> lst = JsonConvert.DeserializeObject<List<Panel>>(d);
                return lst;
            }
            return null;
        }

        public List<Panel> SortingByName(List<Panel> list)
        {
            string CstmName;
            string CstmNumber;
            string CstmEmail;
            string suggest;
            string time;
           
            if (list != null)
            {
                for (int a = 0; a < list.Count - 1; a++)
                {
                    for (int b = a + 1; b < list.Count; b++)
                    {
                        if (list[a].reviewername.ToUpper().CompareTo(list[b].reviewername.ToUpper()) >0)
                        {
                            CstmName = list[a].reviewername;
                            list[a].reviewername = list[b].reviewername;
                            list[b].reviewername = CstmName;

                            CstmNumber = list[a].reviewerphone;
                            list[a].reviewerphone = list[b].reviewerphone;
                            list[b].reviewerphone = CstmNumber;

                            CstmEmail = list[a].revieweremail;
                            list[a].revieweremail = list[b].revieweremail;
                            list[b].revieweremail = CstmEmail;

                            suggest = list[a].reviewersuggest;
                            list[a].reviewersuggest = list[b].reviewersuggest;
                            list[b].reviewersuggest = suggest;

                            time = list[a].timer;
                            list[a].timer = list[b].timer;
                            list[b].timer = time;
                        }
                    }
                }
                return list;
            }
            return null;
        }
    }
 
}
