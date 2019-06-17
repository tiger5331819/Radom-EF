using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models2
{
    public partial class CarTasks
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? TaskDate { get; set; }
        public string Remark { get; set; }
    }
}
