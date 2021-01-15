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
        private string _filePath = "Review.txt";
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string FoodQuality { get; set; }
        public string StaffFriendliness { get; set; }
        public string Cleanliness { get; set; }
        public string OrderAccuracy { get; set; }
        public string RestAmbiance { get; set; }
        public string ValueMoney { get; set; }
        public String Save(Panel data)
        {
            string str = JsonConvert.SerializeObject(data, Formatting.None);
            Utility.WriteToTextFile(_filePath, str);
            return "success";
        }
        public List<Panel> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Panel> lst = JsonConvert.DeserializeObject<List<Panel>>(d);
                return lst;
            }
            return null;
        }
    }
}
