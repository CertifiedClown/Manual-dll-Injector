// join for more https://discord.gg/mS9Jzg8SRT
// Give credits if you paste this 1310's#1310 no credits = gae
// New account 1310's#1310 the other one got banned

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
                System.Diagnostics.Process.Start("https://discord.gg/FYh9KERzkY");
            }

            try
            {
                if (VITAL9999.Run(GetPathDLL()))
                {
                    MessageBox.Show("[1310's#1310] DLL injected thanks for using our services!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }  
                else
                {
                    MessageBox.Show("[1310's#1310] Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "[1310's#1310] Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    throw new ApplicationException("[1310's#1310] Dll Opening Error");
                }
            }

            return dllPath;
        }
    }
}
