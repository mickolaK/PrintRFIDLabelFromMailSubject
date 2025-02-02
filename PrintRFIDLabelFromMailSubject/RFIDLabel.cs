﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PrintRFIDLabelFromMailSubject
{
    /// <summary>
    /// Класс для работы с RFID-этикеткой
    /// </summary>
    
    class RFIDLabel
    {
        public string PrinterIP { get; }
        public int PrinterPort { get; }
        public RFIDLabel(IConfig cfg)
        {
            this.PrinterIP = cfg.GetConfig().GetValue<string>("PrinterIP");
            this.PrinterPort = cfg.GetConfig().GetValue<int>("PrinterPort");
        }
        ///<summary>Метод для печати RFID-этикетки</summary>
        ///<param name="RFIDString">Строки для печати</param>
        public bool SendRFIDLabelToPrinter(List<string> RFIDString)
        {
            try
            {
                var client = new TcpClient(PrinterIP, PrinterPort);
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
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }


}
