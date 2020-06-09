using System;
using System.Collections.Generic;
using System.Reflection;
using csv_db.tables.interfaces;

namespace csv_db
{
    public class TableBase<TModel> : IModel where TModel : IModel
    {
        internal virtual string TABLE_NAME;

        public List<TModel> Items { get; } = new List<TModel>();

        public void Store()
        {
            foreach (var p in typeof(TModel).GetProperties())
            {
                Console.Write(p.Name + ",");
            }
            Console.WriteLine(string.Empty);
            foreach (TModel item in Items)
            {
                string line = string.Empty;
                foreach (PropertyInfo prop in typeof(TModel).GetProperties())
                {
                    line += item.GetType().GetProperty(prop.Name)?.GetValue(item, null) + ",";
                }

                Console.WriteLine(line);
            }
        }
    }
}