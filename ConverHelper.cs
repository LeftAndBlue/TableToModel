using System.Data;
using System.Reflection;


public static class ToListHelper
    {
        
       
    // 转换 Datatable 到 List 的方法
    public static List<T> ToListByReflect<T>(this DataTable dt) where T : new()
        {
            List<T> ts = new List<T>();
            string tempName = string.Empty;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T t = new T();
                    PropertyInfo[] propertys = t.GetType().GetProperties();
                    foreach (PropertyInfo pi in propertys)
                    {
                        tempName = pi.Name;
                        if (dt.Columns.Contains(tempName))
                        {
                            object value = dr[tempName];
                            if (value != DBNull.Value)
                            {
                                pi.SetValue(t, value, null);
                            }
                        }
                    }
                    ts.Add(t);
                }
                return ts;
            }
            catch (Exception)
            {
                string res = tempName;
                throw;
            }
        }
		 #region 转换 List 到 DataTable 的方法
			public static DataTable ConvertToDataTable<T>(List<T> list)
			{
				// 创建一个空的 DataTable
				DataTable dt = new DataTable();

				// 获取类型的属性信息
				PropertyInfo[] properties = typeof(T).GetProperties();

				// 为 DataTable 创建列
				foreach (var property in properties)
				{
					dt.Columns.Add(property.Name, property.PropertyType);
				}

				// 填充 DataTable 行
				foreach (var item in list)
				{
					DataRow row = dt.NewRow();
					foreach (var property in properties)
					{
						row[property.Name] = property.GetValue(item);
					}
					dt.Rows.Add(row);
				}

				return dt;
			}
		#endregion
        /// <summary>
        /// 字段名称转大写
        /// </summary>
        /// <param name="dst"></param>
        public static void UpperCaseDataTableField(ref DataTable dst)
        {
            for (int j = 0; j < dst.Columns.Count; j++)
            {
                dst.Columns[j].ColumnName = dst.Columns[j].ColumnName.ToUpper();
            }

        }
		#region 数据类型转换避免DBNull的情况
		public static int ToInt32(this object value, int defaultValue = 0)
		{
			// 检查值是否为 DBNull 或 null
			if (value == DBNull.Value || value == null)
			{
				return defaultValue; // 如果是DBNull或null，返回默认值
			}
			
			// 如果不是DBNull，则进行正常的转换
			try
			{
				return Convert.ToInt32(value);
			}
			catch (FormatException)
			{
				return defaultValue; // 如果转换失败，返回默认值
			}
		}
    public static string ToString(this object value, string defaultValue = "")
    {
        // 检查值是否为 DBNull 或 null
        if (value == DBNull.Value || value == null)
        {
            return defaultValue; // 如果是DBNull或null，返回默认值
        }

        // 如果不是DBNull，则进行正常的转换
        try
        {
            return Convert.ToString(value);
        }
        catch (FormatException)
        {
            return defaultValue; // 如果转换失败，返回默认值
        }
    }
    
    public static decimal ToDecimal(this object value, decimal defaultValue = 0m)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToDecimal(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static double ToDouble(this object value, double defaultValue = 0.0)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToDouble(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static DateTime ToDateTime(this object value, DateTime defaultValue = default(DateTime))
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToDateTime(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static bool ToBoolean(this object value, bool defaultValue = false)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToBoolean(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static Guid ToGuid(this object value, Guid defaultValue = default(Guid))
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return new Guid(value.ToString());
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    } 
    public static byte ToByte(this object value, byte defaultValue = 0)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToByte(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static short ToInt16(this object value, short defaultValue = 0)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToInt16(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static long ToInt64(this object value, long defaultValue = 0)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToInt64(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static float ToSingle(this object value, float defaultValue = 0)
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToSingle(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    public static char ToChar(this object value, char defaultValue = '\0')
    {
        if (value == DBNull.Value || value == null)
        {
            return defaultValue;
        }
        try
        {
            return Convert.ToChar(value);
        }
        catch (FormatException)
        {
            return defaultValue;
        }
    }
    #endregion
    /// <summary>
    /// 校验字符串是否为空或者null
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static bool IsNullOrEmpty(this string str)
    {
        if (str == "" || str == null)
        {
            return true;
        }
        return false;
    }
}


