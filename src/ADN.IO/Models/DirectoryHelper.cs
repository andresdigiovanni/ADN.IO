using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ADN.IO
{
    /// <summary>
    /// A static class of extension methods for <see cref="Directory"/>.
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Copy files from the source folder to destination folder overwriting the content.
        /// </summary>
        /// <param name="source">Source folder.</param>
        /// <param name="destination">Destination folder.</param>
        /// <param name="overwrite">Overwrite destination file.</param>
        /// <remarks>
        /// This method check if is posible to override a file and retry it.
        /// </remarks>
        /// <example>
        /// <code lang="csharp">
        /// var source = "sourceDir";
        /// var destination = "destDir";
        /// var overwrite = true;
        /// DirectoryHelper.CopyDirectory(source, destination, overwrite);
        /// </code>
        /// </example>
        public static void CopyDirectory(string source, string destination, bool overwrite = false)
        {
            DirectoryInfo dir = new DirectoryInfo(source);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destination, file.Name);
                file.CopyTo(temppath, overwrite);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destination, subdir.Name);
                CopyDirectory(subdir.FullName, temppath, overwrite);
            }
        }
    }
}
