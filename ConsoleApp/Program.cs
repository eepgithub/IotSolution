using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;
using System;



namespace ConsoleApp
{
    class Program
    {
        private static readonly string _conn = "HostName=EC-iothub.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=Wpp+e1YG/15ffM0XYiK61eeSSVT6ltskDc97X7EktEk=";

        private static readonly DeviceClient deviceClient = DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);


        static void Main(string[] args)
        {

            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.ReceiveMessageAsync(deviceClient).GetAwaiter();



            Console.ReadKey();
        }
    }
}
