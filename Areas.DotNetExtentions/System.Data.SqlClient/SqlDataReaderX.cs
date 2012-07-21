using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Reflection;
using System.Web;
	public static class SqlDataReaderX
	{
		#region�Methods�(1)�

		//�Public�Methods�(1)�
		public static List<T> ParseToObjectList<T>(this SqlDataReader reader,
		   SqlConnection connectionToUseAndCloseAfterReading, bool closeReader, 
			params string[] onlyThese)
		{
			Type t = typeof(T);
			ConstructorInfo ci = t.GetConstructor(new Type[] { });
			List<T> list = new List<T>();
			PropertyInfo[] arrp = t.GetProperties();
			if (onlyThese.CountedZero())
			{
				onlyThese = (from p in arrp
							select p.Name).ToArray<string>();
			}
			Dictionary<string, PropertyInfo> props = new Dictionary<string, PropertyInfo>();
			foreach (var pi in arrp)
			{
				props[pi.Name] = pi;
			}
			while (reader.Read())
			{
				object instance = ci.Invoke(new object[] { });
				foreach (string propertName in onlyThese)
				{
					try
					{
						object aValue = reader[propertName];
						if (null != aValue && DBNull.Value != aValue)
						{
							props[propertName].SetValue(instance, aValue, null);
						}
					}
					catch { }
				}
				list.Add(instance.CastTo<T>());
			}
			if (closeReader)
			{
				reader.Close();
				reader.Dispose();
				connectionToUseAndCloseAfterReading.CloseSafely();
				connectionToUseAndCloseAfterReading.Dispose();
			}
			return list;
		}
		public static List<T> ParseToObjectList<T>(this SqlDataReader reader,
			SqlConnection connectionToUseAndCloseAfterReading,
			params string[] onlyThese)
		{
			return ParseToObjectList<T>(reader, connectionToUseAndCloseAfterReading, true);
		}
		public static string ColumnValueHtmlEncoded(this SqlDataReader reader, string columnName)
		{
			return HttpContext.Current.Server.HtmlEncode(reader[columnName].text());
		}
		/// <summary>
		/// Escapes null values and sends empty string where data is null.
		/// </summary>
		public static string StringValue(this SqlDataReader reader, string columnName)
		{
			return reader[columnName].text();
		}
		#endregion�Methods�
	}