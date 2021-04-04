// join for more https://discord.gg/kSSF6eM4Er

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace VITAL9999

{
    class Program

    {

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0x0;
        private const int SW_SHOW = 0x5;


        [STAThread]
        static void Main(string[] args)
        {
            IntPtr handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            {
                System.Diagnostics.Process.Start("https://discord.gg/kSSF6eM4Er");
            }

            try
            {
                if (VITAL9999.Run(GetPathDLL()))
                {
                    MessageBox.Show("[VITAL#9999] DLL injected thanks for using our services!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }  
                else
                {
                    MessageBox.Show("[VITAL#9999] Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "[VITAL#9999] Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetPathDLL()
        {
            string dllPath = string.Empty;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "DLL files (*.dll)|*.dll";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dllPath = fileDialog.FileName;
                }
                else
                {
                    throw new ApplicationException("[VITAL#9999] Dll Opening Error");
                }
            }

            return dllPath;
        }
    }
}