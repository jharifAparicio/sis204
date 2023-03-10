using System.Runtime.InteropServices;
using System.Security;

namespace SIS204BaseDeDatos {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AsignarConsola();
            Application.Run(new Inicio());
            LiberarConsola();
        }

        public static int AsignarConsola() {
            return AllocConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        public static int LiberarConsola() {
            return FreeConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
    }
}