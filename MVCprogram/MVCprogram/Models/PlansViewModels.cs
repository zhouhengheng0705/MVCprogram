using System.ComponentModel.DataAnnotations;

namespace MVCprogram.Models
{
    public class PlansListViewModel
    {
        [Display(Name = "日付")]
        [DataType(DataType.Date)]
        public string  PlanDate { get; set; }

        [Display(Name = "優先度")]
        public int Priority { get; set; }

    }
}