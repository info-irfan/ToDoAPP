using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Model.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int StatusId { get; set; }
        public int TaskTypeId { get; set; }
        public string Note { get; set; }
    }
}
