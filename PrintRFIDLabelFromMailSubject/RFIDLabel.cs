﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace PrintRFIDLabelFromMailSubject
{
    class RFIDLabel
    {
        public RFIDLabel()
        {

        }

        public void SendRFIDLabelToPrinter(List<string> RFIDString, string printerIP, string printerport)
        {
            try
            {
                var client = new TcpClient(printerIP, Int32.Parse(printerport));
                StreamWriter writer = new System.IO.StreamWriter(client.GetStream());
                foreach (var item in RFIDString)
                {
                    Console.WriteLine($"Print {item}");
                    //Next string Disabled until real printer is not connected
                    //format string like string RFIDZPLString = @"^XA^FO50,50^A0N,65^FDSimple write example^FS^RFW,A^FD00 rfid data^FS^XZ";
                    /* writer.Write(RFIDZPLString);*/
                }
                writer.Flush();
                writer.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }


}
