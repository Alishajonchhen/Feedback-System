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
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string Suggestion { get; set;}
        public string Timer { get; set; }
        
     
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
                        if (list[a].CustomerName.ToUpper().CompareTo(list[b].CustomerName.ToUpper()) >0)
                        {
                            CstmName = list[a].CustomerName;
                            list[a].CustomerName = list[b].CustomerName;
                            list[b].CustomerName = CstmName;

                            CstmNumber = list[a].CustomerNumber;
                            list[a].CustomerNumber = list[b].CustomerNumber;
                            list[b].CustomerNumber = CstmNumber;

                            CstmEmail = list[a].CustomerEmail;
                            list[a].CustomerEmail = list[b].CustomerEmail;
                            list[b].CustomerEmail = CstmEmail;

                            suggest = list[a].Suggestion;
                            list[a].Suggestion = list[b].Suggestion;
                            list[b].Suggestion = suggest;

                            time = list[a].Timer;
                            list[a].Timer = list[b].Timer;
                            list[b].Timer = time;
                        }
                    }
                }
                return list;
            }
            return null;
        }
    }
}
