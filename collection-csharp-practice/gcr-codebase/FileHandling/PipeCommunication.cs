using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipeCommunication
{
    static void Main()
    {
        AnonymousPipeServerStream server = new AnonymousPipeServerStream(PipeDirection.Out);
        AnonymousPipeClientStream client = new AnonymousPipeClientStream(
            PipeDirection.In,
            server.ClientSafePipeHandle
        );

        Thread writer = new Thread(() =>
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello Pipe");
            server.Write(data, 0, data.Length);
            server.Dispose();
        });

        Thread reader = new Thread(() =>
        {
            byte[] buffer = new byte[100];
            int read = client.Read(buffer, 0, buffer.Length);
            Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, read));
        });

        writer.Start();
        reader.Start();
    }
}
