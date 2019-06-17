using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models2
{
    public partial class Records
    {
        public int Id { get; set; }
        public int? CarNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Volume { get; set; }
        public int? LoadingRate { get; set; }
        public int? Count { get; set; }
        public string Sn { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Remark { get; set; }
    }
}
