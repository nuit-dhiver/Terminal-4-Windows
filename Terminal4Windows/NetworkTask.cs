using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace Terminal4Windows
{
    class NetworkTask
    {
        public static void Ping()
        {
            Console.Write("pleas enter IP address or Domain name:");
            string IP2Ping = Console.ReadLine();
            Ping pingsender = new Ping();
            int TimeOut = 1000;
            for (int i = 0; i < 4; i++)
            {
                PingReply Reply = pingsender.Send(IP2Ping, TimeOut);
                if (Reply.Status == IPStatus.Success)
                {
                    Console.Write("Address: {0}  ", Reply.Address.ToString());
                    Console.Write("RoundTrip Time: {0}  ", Reply.RoundtripTime);
                    Console.Write("TTL: {0}  ", Reply.Options.Ttl);
                    Console.WriteLine("Buffer Size: {0}  ", Reply.Buffer.Length);
                }
                else
                {
                    Console.Write("ping failed. ");
                    Console.WriteLine(Reply.Status);
                }
            }
        }
    }
}
