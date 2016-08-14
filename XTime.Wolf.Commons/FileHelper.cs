using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace XTime.Wolf.Commons
{
    public class FileHelper
    {
        /// <summary>
        /// 功能描述：通过内嵌资源文件获取图片
        /// </summary>
        /// <param name="imagePath">图片名字</param>
        /// <returns></returns>
        public static System.Drawing.Image GetImageFormResourceStream(string imagePath)
        {
            var ass = Assembly.GetExecutingAssembly();
            var currentNamespace = MethodBase.GetCurrentMethod().DeclaringType.Namespace;
            var fileStream = ass.GetManifestResourceStream(currentNamespace + "." + imagePath);
            return System.Drawing.Image.FromStream(fileStream);
        }

        /// <summary>
        /// 功能描述：通过命名空间和图片名称获取图片资源
        /// 例子：XTime.Wolf.Commons.find.png
        /// </summary>
        /// <param name="nameSpace">命名空间</param>
        /// <param name="imageName">图片名称</param>
        /// <returns></returns>
        public static System.Drawing.Image GetImageFromResourceStream(string nameSpace, string imageName)
        {
            var ass = Assembly.GetExecutingAssembly();
            var fileStream = ass.GetManifestResourceStream(nameSpace + "." + imageName);
            return System.Drawing.Image.FromStream(fileStream);
        }
    }
}
