using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;


public class UdpSender
{
    public bool exception_thrown { get; set; }
    Socket sending_socket = null;
    IPAddress send_to_address = null;
    IPEndPoint sending_end_point = null;
    public UdpSender(string ip, int port)
    {
        sending_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram,
ProtocolType.Udp);
        send_to_address = IPAddress.Parse(ip);
        sending_end_point = new IPEndPoint(send_to_address, port);
    }
    public void SendByte(byte[] send_buffer)
    {
        // Remind the user of where this is going.
        Debug.Log(string.Format("sending to address: {0} port: {1}",
        sending_end_point.Address,
        sending_end_point.Port));
        try
        {
            sending_socket.SendTo(send_buffer, sending_end_point);
        }
        catch (Exception send_exception)
        {
            exception_thrown = true;
            Debug.LogError(" Exception" + send_exception.Message);
        }
        if (exception_thrown == false)
        {
            Debug.LogError("Message has been sent to the broadcast address");
        }
        else
        {
            exception_thrown = false;
            Debug.LogError("The exception indicates the message was not sent.");
        }

    }

}

