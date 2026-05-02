using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGROMET.Models
{
    public class SurveysModel
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string OptionOneTitle { get; set; }
        public string OptionTwoTitle { get; set; }
        public string ScientistId { get; set; }
        public int StateId { get; set; }
        public string DistrictList { get; set; }
        public string BlockList { get; set; }
        public string CropList { get; set; }
        public string LanguageList { get; set; }
    }
}