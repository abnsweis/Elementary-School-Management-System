using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

public static class DataTableExtensions
{
    public static List<T> ToList<T>(this DataTable dt) where T : new()
    {
        List<T> list = new List<T>();


        if (dt.Rows.Count > 0)
        {

            foreach (DataRow row in dt.Rows)
            {
                T obj = new T();
                MethodInfo method = typeof(T).GetMethod("SetModeToUpdate", BindingFlags.NonPublic | BindingFlags.Instance);
                method?.Invoke(obj,null);
                foreach (DataColumn column in dt.Columns)
                {

                    PropertyInfo property = obj.GetType().GetProperty(column.ColumnName);
                    if (property != null && row[column] != DBNull.Value)
                    {
                        property.SetValue(obj, row[column]);
                    }
                }
                list.Add(obj);
            }
        }

        return list;
    }

        
    

}
