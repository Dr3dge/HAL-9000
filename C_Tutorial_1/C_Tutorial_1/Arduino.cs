using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace HAL_9000
{
    public class Arduino
    {
        public static void Start()
        {
            Writting.Arduino();
        //    SerialPort serialPort;
        //    bool portFound;

        //    string[] ports = SerialPort.GetPortNames();
            
        //    serialPort.Open();

        //    foreach (string port in ports)
        //    {
        //        serialPort = new SerialPort(port, 115200);
        //        if (DetectArduino())
        //        {
        //            portFound = true;
        //            break;
        //        }
        //        else
        //        {
        //            portFound = false;
        //        }


        //        while (true)
        //        {
        //        Main:
        //            String arduinoInput = Console.ReadLine();

        //            if (arduinoInput == "stop" || arduinoInput == "end" || arduinoInput == "terminate" || arduinoInput == "exit" || arduinoInput == "Stop" || arduinoInput == "End" || arduinoInput == "Terminate" || arduinoInput == "Exit ")
        //            {
        //                break;
        //            }
        //            else if (arduinoInput == "light" || arduinoInput == "Light" || arduinoInput == "lights" || arduinoInput == "Lights")
        //            {
        //                serialPort.Write("L");

        //                try
        //                {
        //                    Console.WriteLine(serialPort.ReadLine());
        //                }
        //                catch
        //                {
        //                    Writting.sorryDave();
        //                }
        //            }
        //            else
        //            {
        //                goto Main;
        //            }
        //        }
        //        serialPort.Close();
        //    }
        //}

        //private static bool DetectArduino()
        //{
        //    SerialPort serialPort;
        //    bool portFound;

        //    try
        //    {
        //        byte[] buffer = new byte[5];
        //        buffer[0] = Convert.ToByte(16);
        //        buffer[1] = Convert.ToByte(128);
        //        buffer[2] = Convert.ToByte(0);
        //        buffer[3] = Convert.ToByte(0);
        //        buffer[4] = Convert.ToByte(4);

        //        int intReturnASCII = 0;
        //        char charReturnValue = (Char)intReturnASCII;

        //        serialPort.Write(buffer, 0, 5);

        //        Thread.Sleep(1000);

        //        int count = serialPort.BytesToRead;
        //        string returnMessage = "";
                
        //        while (count > 0)
        //        {
        //            intReturnASCII = serialPort.ReadByte();
        //            returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
        //            count--;
        //        }

        //        serialPort.PortName = returnMessage;

        //        serialPort.Close();

        //        if (returnMessage.Contains("HELLO FROM ARDUINO"))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch
        //    {
        ////        return false;
        //    }
        }
    }
}