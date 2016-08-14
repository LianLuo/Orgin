using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace XTime.Wolf.Views
{
    public static class ViewHelper
    {
        /// <summary>
        /// 功能描述：从当前程序集中获取嵌入的图片资源
        /// 创建作者：luolian
        /// 创建日期：2016-7-27
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Image GetImageFromResource(string fileName)
        {
            var ass = Assembly.GetExecutingAssembly();
            var sm = ass.GetManifestResourceStream(fileName);
            return Image.FromStream(sm);
        }

        /// <summary>
        /// 功能描述：从当前程序集中获取嵌入的文件资源
        /// 创建作者：luolian
        /// 创建日期：2016-7-29
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string GetStringFromResource(string fileName)
        {
            var ass = Assembly.GetExecutingAssembly();
            var sm = ass.GetManifestResourceStream(fileName);
            return new System.IO.StreamReader(sm).ReadToEnd();
        }
    }
}
