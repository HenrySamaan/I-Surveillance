using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace I_Surveillance
{
    public class TelnetClient
    {
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private StreamReader reader;
        private StreamWriter writer;

        // Function to connect and login via Telnet
        public void LoginToTelnet(string host, int port, string username, string password)
        {
            try
            {
                tcpClient = new TcpClient(host, port);
                networkStream = tcpClient.GetStream();
                reader = new StreamReader(networkStream, Encoding.ASCII);
                writer = new StreamWriter(networkStream, Encoding.ASCII) { AutoFlush = true };


                ReadUntil("login: ");
                Write(username);

                ReadUntil("Password: ");
                Write(password);

                // Optionally, you can send further commands after logging in
                string command = "whoami"; // Replace with the command you want to run
                Write(command);
                Console.WriteLine(ReadUntil(">")); // Read until next prompt or end of output

                Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Function to write data to the Telnet server
        private void Write(string command)
        {
            writer.WriteLine(command);
        }

        // Function to read data from the Telnet server until a specific prompt is found
        private string ReadUntil(string prompt)
        {
            StringBuilder sb = new StringBuilder();
            while (!sb.ToString().Contains(prompt))
            {
                sb.Append((char)reader.Read());
            }
            return sb.ToString();
        }

        // Disconnect from the Telnet server
        public void Disconnect()
        {
            reader.Close();
            writer.Close();
            networkStream.Close();
            tcpClient.Close();
            Console.WriteLine("Disconnected from the Telnet server.");
        }
    }
}
