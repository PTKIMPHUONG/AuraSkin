using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aura_skin.Lib
{
    static class ConvertUltil
    {
        public static DataTable ConvertListToDataTable<T>(this List<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = props[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);

                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[props.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
