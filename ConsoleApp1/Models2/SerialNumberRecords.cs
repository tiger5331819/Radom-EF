using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models2
{
    public partial class SerialNumberRecords
    {
        public int Id { get; set; }
        public int? CarNo { get; set; }
        public string Sn { get; set; }
        public DateTime? Datetime { get; set; }
        public string CreateUser { get; set; }
        public string Remark { get; set; }
    }
}
