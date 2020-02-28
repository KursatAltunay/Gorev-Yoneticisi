using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gorev_Yoneticisi.API.Model
{
    public class Work
    {
        public Work()
        {
            // WorkType=new WorkType();
            //User= new User();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int WorkTypeId { get; set; }
        public string Location { get; set; }
        public string Detail { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }

        public WorkType WorkType { get; set; }
        //public User User { get; set; }

    }
}
