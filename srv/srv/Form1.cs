using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace srv
{
    public partial class Form1 : Form
    {
        private bool ServerOpen1;
        private bool ServerOpen2;
        private bool ServerOpen3;
        private bool ServerOpen4;
        private bool ServerOpen5;
        private bool ServerOpen6;
        static int spnr;
        public Form1()
        {
            InitializeComponent();
            ServerOpen1 = false;
            ServerOpen2 = false;
            ServerOpen3 = false;
            ServerOpen4 = false;
            ServerOpen5 = false;
            ServerOpen6 = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AxMSWinsockLib.AxWinsock temp;
                //if(ServerOpen1 == false)
                //{
                //    temp = w1;
                //    ServerOpen1 = true;
                //}
                //else if(ServerOpen2 == false)
                //    {
                //    temp = w2;
                //    ServerOpen2 = true;
                //    }
                //    else if(ServerOpen3 == false)
                //            {
                //                temp = w3;
                //                ServerOpen3 = true;
                //            }
                //            else if(ServerOpen4 == false)
                //                {
                //                    temp = w4;
                //                    ServerOpen4 = true;
                //                }
                //                else if(ServerOpen5 == false)
                //                {
                //                    temp = w5;
                //                    ServerOpen5 = true;
                //                }else if(ServerOpen6 == false)
                //                {
                //                    temp = w6;
                //                    ServerOpen6 = true;
                //                }
                //                else
                //                {
                //                    temp = null;
                //                }
                    //to create a connection we need a server(host).
                    //server we call the program that keeps a port open
                    //so the someone ( client ) can connect
                    //do open the port we must write the following code
                    //with this we set the port we want to use for .the connection
                if (ServerOpen1 == true)
                {
                    w1.Close();
                    spnr = 0;
                }
                    w1.LocalPort = 1337;
                    //this command opens the port and waits (listens) for a connection
                    w1.Listen();
                    ServerOpen1 = true;
                    label1.Text = Convert.ToString(w1.LocalIP) + ":" + Convert.ToString(w1.LocalPort);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void w1_ConnectionRequest(object sender,AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent e)
        {
            //with this commands we accept the connection request to the server..
            try
            {
                w1.Close();
                w1.Accept(e.requestID);
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //now we are connected with the client
            
        }

        private void w1_DataArrival(object sender, AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent e)
        {
            try
            {
                String data = "";
                Object dat = (object)data;
                w1.GetData(ref dat);
                spieler sp = new spieler((string)dat, 0);
                spnr++;
                w1.SendData("O+" + spnr.ToString());
                ServerOpen1 = true;

            }
            catch (Exception ex)
            {
                String s = ex.Message;
                int kk = 0;
                    
                kk++;
            }
        }

        private void w1_ConnectionRequest_1(object sender, AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent e)
        {
            try
            {
                Object ob = true;
                if (ServerOpen1 == true)
                {
                    w1.Close();
                    w1.Accept(e.requestID);
                    w1.SendData(ob);

                }
                if (ServerOpen2 == true)
                {
                    w2.Close();
                    w2.Accept(e.requestID);
                }
                if (ServerOpen3 == true)
                {
                    w3.Close();
                    w3.Accept(e.requestID);
                }
                if (ServerOpen4 == true)
                {
                    w4.Close();
                    w4.Accept(e.requestID);
                }
                if (ServerOpen5 == true)
                {
                    w5.Close();
                    w5.Accept(e.requestID);
                }
                if (ServerOpen6 == true)
                {
                    w6.Close();
                    w6.Accept(e.requestID);
                } 
            }
            catch (Exception ex)
            {
                string s = "";
                s = ex.Message;
                int j =0;
                j++;
            }
        }

        private void w1_ConnectEvent(object sender, EventArgs e)
        {
            

            MessageBox.Show("w1_ConnectEvent");
        }

        private void w1_SendProgress(object sender, AxMSWinsockLib.DMSWinsockControlEvents_SendProgressEvent e)
        {
            MessageBox.Show("w1_SendProgress");
        }
    }
}
