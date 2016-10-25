/*
    Description:
    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
    and extracts from it the [protocol], [server] and [resource] elements.
    
    Input:
    On the only line you will receive an address
    
    Output:
    Print the protocol, server and resource as shown below
*/

using System;

public class Startup
{
    public static void Main()
    {
        string url = Console.ReadLine();

        string protocol = url.Substring(0, url.IndexOf(":", 0));
        int protocolLen = protocol.Length;

        string server = url.Substring(protocolLen + 3, url.IndexOf("/", protocolLen + 3) - (protocolLen + 3));
        int serverLen = server.Length;

        string resource = url.Substring(url.IndexOf(server, 0) + serverLen);

        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
    }
}

