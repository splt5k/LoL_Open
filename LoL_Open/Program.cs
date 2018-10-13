using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LoL_Open
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists(@"LeagueClient.exe"))
            {
                MessageBox.Show("O Launcher do cliente não foi encontrado (LeagueClient.exe).\n \nVerifique se o LoL_Open encontra-se na pasta do League of Legends.", "LoL_Open - Erro ao iniciar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lol = { "LeagueClient", "LeagueClientUx", "LeagueClientUxRender", "League of Legends" };

            foreach (string value in lol)
            {
                kill(value);
            }

            start();
        }

        static void kill(string sProcessName)
        {
            foreach (var process in Process.GetProcessesByName(sProcessName))
            {
                process.Kill();
            }
        }

        static void start()
        {
            Process.Start("LeagueClient.exe");
        }


    }
}
