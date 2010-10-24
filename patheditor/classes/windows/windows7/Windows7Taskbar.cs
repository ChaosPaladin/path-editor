using System;
namespace com.jds.PathEditor.classes.windows.windows7
{
    public static class Windows7Taskbar
    {
        static ITaskbarList3 _taskbarList;
        internal static ITaskbarList3 TaskbarList
        {
            get
            {
                if (_taskbarList == null)
                {
                    lock (typeof(Windows7Taskbar))
                    {
                        if (_taskbarList == null)
                        {
                            _taskbarList = (ITaskbarList3)new CTaskbarList();
                            _taskbarList.HrInit();
                        }
                    }
                }
                return _taskbarList;
            }
        }

        /// <summary>
        /// Sets the progress state of the specified window's
        /// taskbar button.
        /// </summary>
        /// <param name="hwnd">The window handle.</param>
        /// <param name="state">The progress state.</param>
        public static void SetProgressState(IntPtr hwnd, ThumbnailProgressState state)
        {
            if (SystemInfo.Instance.Windows7OrGreater)
                TaskbarList.SetProgressState(hwnd, state);
        }
        /// <summary>
        /// Sets the progress value of the specified window's
        /// taskbar button.
        /// </summary>
        /// <param name="hwnd">The window handle.</param>
        /// <param name="current">The current value.</param>
        /// <param name="maximum">The maximum value.</param>
        public static void SetProgressValue(IntPtr hwnd, int current, int maximum)
        {
            if (SystemInfo.Instance.Windows7OrGreater)
                TaskbarList.SetProgressValue(hwnd, (ulong)current, (ulong)maximum);
        }


        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //internal static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}