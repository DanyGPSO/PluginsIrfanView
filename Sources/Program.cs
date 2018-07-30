using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PluginsIrfanView
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES PATH
            string filePluginEmailSrc = "\\\\GPSO-SRV-AD02\\NETLOGON\\GPO\\PluginsIview\\Email.dll";
            string filePluginFrenchSrc = "\\\\GPSO-SRV-AD02\\NETLOGON\\GPO\\PluginsIview\\French.dll";
            string filePluginEmailDest = 
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "IrfanView\\Plugins\\Email.dll");
            string filePluginFrenchDest = 
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "IrfanView\\Languages\\French.dll");

            //PLUGIN EMAIL
            if (!File.Exists(filePluginEmailDest))
            {
                File.Copy(filePluginEmailSrc, filePluginEmailDest);
            }
            else if (File.Exists(filePluginEmailDest))
            {
                File.Delete(filePluginEmailDest);
                File.Copy(filePluginEmailSrc, filePluginEmailDest);
            }

            //PLUGIN LANGUAGE FRANCAIS
            if (!File.Exists(filePluginFrenchDest))
            {
                File.Copy(filePluginFrenchSrc, filePluginFrenchDest);
            }
        }
    }
}
