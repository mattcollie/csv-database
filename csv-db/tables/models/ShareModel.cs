using System;
using Microsoft.VisualBasic.CompilerServices;

namespace csv_db.tables.interfaces
{
    public class ShareModel : IModel
    {
        public string Name { get; set; }
        public Int64 Value { get; set; }
        public int Price { get; set; }
    }
}