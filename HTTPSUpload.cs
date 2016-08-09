// Copyright (c) 2016 Dmitrii Evdokimov. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// Source https://github.com/diev/HTTPSUpload

using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace HTTPSUpload
{
    class Program
    {
        // HTTPSUpload https://icrs.nbki.ru/inout/cgi-bin/uploadvb.cgi uploads file
        public static void Main(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                Console.WriteLine("Wrong number of parameters!");
                Environment.Exit(4);
            }

            string uri = args[0];
            string cmd = args[1];
            string file = args[2];

            if (!File.Exists(file))
            {
                Console.WriteLine("File {0} not found!", file);
                Environment.Exit(3);
            }

            // Create a new WebClient instance.
            var client = new WebClient();
            Console.WriteLine("Uploading {0} to {1} ...", file, uri);

            var nameValue = new NameValueCollection();
            nameValue.Add("pathnm", cmd);
            client.QueryString = nameValue;

            // Upload the file to the URI.
            // The 'UploadFile(uriString, fileName)' method implicitly uses HTTP POST method.
            byte[] responseArray = null;
            try
            {
                responseArray = client.UploadFile(uri, file);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(2);
            }

            // Decode and display the response.
            if (responseArray == null || responseArray.Length == 0)
            {
                Console.WriteLine("No response received");
                Environment.Exit(1);
            }

            Console.WriteLine("Response received: {0}", Encoding.ASCII.GetString(responseArray));
            Environment.Exit(0);
        }
    }
}
