#region Using directives

using System;
using System.IO;
using System.Threading;

#endregion

namespace com.jds.PathEditor.classes.lm
{
    public static class GlobalUtilities
    {
        private static Mutex app_identity_mutex;

        public static bool IsUniqueApp(string name)
        {
            bool app_unique;
            app_identity_mutex = new Mutex(true, name, out app_unique);

            return app_unique;
        }

        /// <summary>
        /// Returns directory where the program executable is located (with '\' at the end)
        /// </summary>
        /// <param name="set_cur_directory">true for changing current directory to program start directory</param>
        /// <returns>directory where the program executable is located</returns>
        public static string GetStartDirectory(bool set_cur_directory)
        {
            string start_dir = Environment.CommandLine;
            start_dir = start_dir.Substring(1, start_dir.IndexOf('"', 1) - 1);
            start_dir = start_dir.Substring(0, start_dir.LastIndexOf('\\') + 1);

            if (set_cur_directory)
                Directory.SetCurrentDirectory(start_dir);

            return start_dir;
        }
    }
}