﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UCS.Core;

namespace UCS.Helpers
{
    class CommandParser
    {
        /// <summary>
        /// Parses the given Console Command
        /// </summary>
        /// <param name="Command">Command as string</param>
        public static void Parse(string Command)
        {
            switch(Command)
            {
                case "/help":
                    Console.WriteLine("");
                    Console.WriteLine("/startx => Starts the UCS Interface.");
                    Console.WriteLine("/status => Shows the actual UCS status.");
                    Console.WriteLine("/clear => Clears the console screen.");
                    Console.WriteLine("/restart => Restarts UCS instantly.");
                    Console.WriteLine("/shutdown => Shuts UCS down instantly.");
                    break;
                case "/startx":
                    // @ADeltaX Code goes here
                    break;
                case "/status":
                    Console.WriteLine("");
                    Console.WriteLine("IP Address (public): " + new WebClient().DownloadString("http://bot.whatismyipaddress.com/"));
                    Console.WriteLine("IP Address (local): " + Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
                    Console.WriteLine("Online players: " + ResourcesManager.GetOnlinePlayers().Count);
                    Console.WriteLine("Connected players: " + ResourcesManager.GetConnectedClients().Count);
                    Console.WriteLine("Clash Version: " + ConfigurationManager.AppSettings["clientVersion"]);
                    break;
                case "/clear":
                    Console.Clear();
                    break;
                case "/restart":
                    System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
                    Environment.Exit(0);
                    break;
                case "/shutdown":
                    // Extended shutdown code goes here
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unknown command. Type \"/help\" for a list containing all available commands.");
                    break;
            }
        }
    }
}
