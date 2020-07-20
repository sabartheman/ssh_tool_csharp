using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tamir.SharpSsh.jsch;

namespace Simple_Inventory
{
    class Tunnel
    {

        private Session session;
        private string disconnectString = "Disconnected from SSH tunnel.";

        private List<String> Statements = new List<String>(),
                             parsedFiles = new List<String>();

        string user = <username>; //ssh username
        string pass = <password>; //ssh password

        public bool connect()
        {
            try
            {
                //Create a new JSch instance
                JSch jsch = new JSch();//Create a new SSH session
                string host = <server_address>; //url
                int rPort = 3306;
                int lPort = 3306;
                int port = 22;

                Console.WriteLine(user + pass);

                Console.WriteLine("Connecting to SSH tunnel...");

                session = jsch.getSession(user, host, port);
                session.setHost(host);
                session.setPassword(pass);
                UserInfo ui = new MyUserInfo();
                session.setUserInfo(ui);
                session.connect();

                //Set port forwarding on the opened session
                session.setPortForwardingL(lPort, "localhost", rPort);
                if (session.isConnected())
                {
                    Console.WriteLine("Connected to SSH tunnel.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Failed to connect to SSH tunnel");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        public void disconnect()
        {


            try
            {
                this.session.disconnect();
                Console.WriteLine(disconnectString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
