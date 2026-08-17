using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class PipeCommunication
{
    static void Main()
    {
        using (AnonymousPipeServerStream server =
               new AnonymousPipeServerStream(
                   PipeDirection.Out,
                   HandleInheritability.Inheritable))
        {
            string pipeHandle = server.GetClientHandleAsString();

            Thread writerThread = new Thread(() =>
            {
                try
                {
                    using (StreamWriter writer =
                           new StreamWriter(server))
                    {
                        writer.AutoFlush = true;

                        string[] messages =
                        {
                            "Hello from writer thread!",
                            "This is pipe communication.",
                            "Data sent successfully."
                        };

                        foreach (string message in messages)
                        {
                            writer.WriteLine(message);
                            Thread.Sleep(500);
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Writer IO Error: " + ex.Message);
                }
            });

            Thread readerThread = new Thread(() =>
            {
                try
                {
                    using (AnonymousPipeClientStream client =
                           new AnonymousPipeClientStream(
                               PipeDirection.In,
                               pipeHandle))
                    using (StreamReader reader =
                           new StreamReader(client))
                    {
                        string message;

                        while ((message = reader.ReadLine()) != null)
                        {
                            Console.WriteLine("Reader received: " + message);
                        }
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Reader IO Error: " + ex.Message);
                }
            });

            readerThread.Start();
            writerThread.Start();

            writerThread.Join();
            readerThread.Join();

            server.DisposeLocalCopyOfClientHandle();
        }

        Console.WriteLine("Communication completed.");
    }
}