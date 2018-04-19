using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Model.Model
{
    public class TaskReminder
    {
        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime ToTime { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int TaskId { get; set; }
        [ForeignKey("TaskId")]
        public Tasks Task { get; set; }


    }
}
