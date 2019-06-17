using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models2
{
    public partial class SerialNumber
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public string DateFormat { get; set; }
        public int? Increment { get; set; }
        public int? Init { get; set; }
        public int? Length { get; set; }
        public int? CurrentValue { get; set; }
    }
}
