using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.ServiceProcess;

namespace E_videoteka
{
    public static class PokretacServisa
    {
        static string trenutniDirektorijPrograma = Path.GetDirectoryName(Application.ExecutablePath);
        static string prviDio = "sc create WorkerService binpath=";
        static string drugiDio = "WorkerService.exe start=\"demand\" displayname=\"e-Videoteka\"";

        public static void kreirajServis()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + prviDio + trenutniDirektorijPrograma + "\\WorkerService\\" + drugiDio;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        public static void pokreniServis() 
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = "WorkerService";
            sc.Start();
        }

        public static void zaustaviServis() 
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = "WorkerService";
            sc.Stop();
        }
    }
}
