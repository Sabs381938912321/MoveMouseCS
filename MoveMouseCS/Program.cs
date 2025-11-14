using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    // Importar funciones de la API de Windows //
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

    private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
    private const uint MOUSEEVENTF_LEFTUP = 0x04;

    static void Main(string[] args)
    {
        Console.WriteLine("El programa hará un click cada 90 segundos.");
        Console.WriteLine("Presiona CTRL + C para detenerlo.\n");

        while (true)
        {
            // Simular clic izquierdo
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

            Console.WriteLine("Click realizado a las: " + DateTime.Now);

            // Esperar 90 segundos
            Thread.Sleep(90000);
        }
    }
}