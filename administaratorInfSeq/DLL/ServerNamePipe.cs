using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
using System.Threading.Tasks;
using System.Text;
using System.Threading;

public class ServerNamePipe
{
    public string Commands;

    private NamedPipeServerStream pipe;

    public ServerNamePipe()
    {
        Thread thread = new Thread(Server);
        thread.Start();
    }
	
    private void Server()
    {
        try
        {
            pipe = new NamedPipeServerStream("psexe", PipeDirection.InOut);
            pipe.WaitForConnection();
            Debug.Log("StartServer: Connected");
            do
            {
                    using (StreamReader sr = new StreamReader(pipe))
                    {
                        while ((Commands = sr.ReadLine()) != null)
                        {
                            //Commands
                        };
                    }
                Thread.Sleep(2000);
            }
            while (!pipe.IsConnected);
        }
        catch
        {
            Debug.Log("StartServer: try");
        }
    }

    //private IEnumerator StartServer()
    //{

    //    Task.Run(() => 
    //    {
    //        Debug.Log("StartServer: WaitForConnection");
    //        pipe.WaitForConnection();

    //        do
    //        {
    //            if (pipe.IsConnected)
    //            {
    //                using (StreamReader sr = new StreamReader(pipe))
    //                {
    //                    string tmp;
    //                    while ((tmp = sr.ReadLine()) != null)
    //                    {
    //                        Debug.Log(tmp);
    //                    };
    //                }
    //            }
    //            return new WaitForSecondsRealtime(2);
    //        }
    //        while (!pipe.IsMessageComplete);

    //    });
    //    //pipe.WaitForConnection();
    //    Debug.Log("StartServer: [*] Client connected");

    //}

}
