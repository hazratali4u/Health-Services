using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web;
using System.Xml.Serialization;

/// <summary>
/// Summary description for Helper
/// </summary>
public static class Helper
{
    public static List<T> ToList<T>(this DataTable dt)
    {
        List<T> list = new List<T>();

        if (dt == null || dt.Rows == null || dt.Rows.Count <= 0)
        {
            return list;
        }

        foreach (DataRow dr in dt.Rows)
        {
            T instance = Activator.CreateInstance<T>();

            dr.Fill<T>(ref instance);

            list.Add(instance);
        }

        return list;
    }
    public static T ToObject<T>(this DataTable dt)
    {
        T instance = Activator.CreateInstance<T>();

        if (dt == null || dt.Rows == null || dt.Rows.Count <= 0)
        {
            return instance;
        }

        DataRow dr = dt.Rows[0];

        dr.Fill<T>(ref instance);

        return instance;
    }
    public static string ToXML<T>(this T instance)
    {
        XmlSerializer serializer = new XmlSerializer(instance.GetType());
        MemoryStream memStream = new MemoryStream();
        string replace = "<?xml version=\"1.0\"?>";
        string xmlString = string.Empty;

        serializer.Serialize(memStream, instance);

        memStream.Close();

        xmlString = Encoding.UTF7.GetString(memStream.ToArray());
        xmlString = xmlString.Replace(replace, "");

        return xmlString;
    }
    public static string ToAbsoluteUrl(this string relativeUrl)
    {
        if (string.IsNullOrEmpty(relativeUrl))
        {
            return relativeUrl;
        }

        if (HttpContext.Current == null)
        {
            return relativeUrl;
        }

        if (relativeUrl.StartsWith("/"))
        {
            relativeUrl = relativeUrl.Insert(0, "~");
        }

        if (!relativeUrl.StartsWith("~/"))
        {
            relativeUrl = relativeUrl.Insert(0, "~/");
        }

        var url = HttpContext.Current.Request.Url;
        var port = url.Port != 80 ? (":" + url.Port) : String.Empty;

        return String.Format("{0}://{1}{2}{3}", url.Scheme, url.Host, port, VirtualPathUtility.ToAbsolute(relativeUrl));
    }

    public static void Fill<T>(this DataRow oRow, ref T obj)
    {
        if (oRow == null)
            throw new ArgumentNullException("DataRow cannot be null");

        if (obj == null)
            throw new ArgumentNullException("Object cannot be null");

        PropertyInfo[] oProperties = typeof(T).GetProperties();

        for (int i = 0; i < oProperties.Length; i++)
        {
            PropertyInfo oProperty = oProperties[i];

            if (!oProperty.CanWrite)
                continue;

            if (oRow.Table.Columns[oProperty.Name] != null)
            {
                if (oRow[oProperty.Name] != System.DBNull.Value)
                    oProperty.SetValue(obj, oRow[oProperty.Name], null);
                else
                    oProperty.SetValue(obj, null, null);
            }
        }
    }
}