using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Threading;
using administaratorInfSeq;
using System;
using System.Windows.Threading;
using System.Diagnostics;
using System.Net.Sockets;
using System.Net;

/// <summary>
/// класс для взаимодействия с программой распознавания голоса
/// </summary>
public class ServerNamePipe
{
    public string Commands;
    internal bool runThread = true;

   // private NamedPipeServerStream pipe;

    private Speaker sp;
    Dispatcher dsp;
    private UdpClient receive;
    public ServerNamePipe(Speaker sp, Dispatcher dsp)
    {
        Thread thread = new Thread(Server);
        thread.Start();
        this.sp = sp;
        this.dsp = dsp;
        
    }
	
    private void Server()
    {

        receive = new UdpClient(7777);
        IPEndPoint remoteIP = null;
        try
        {
            while (runThread)
            {
                byte[] data = receive.Receive(ref remoteIP);
                string message = Encoding.UTF8.GetString(data);
                //Debug.Log($"Receive:{message}");
                //Console.WriteLine($"Receive:{message}");
                Commands = message;
                dsp.Invoke(() => sp.command = Commands);
            }

        }
        catch
        {
            receive.Close();
            Console.WriteLine($"Receive cath");
        }

    }
}
public class Wrapped<T>
{
    private T _value;
    public Action ValueChanged;

    public T Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged();
        }
    }

    protected virtual void OnValueChanged() => ValueChanged?.Invoke();
}



