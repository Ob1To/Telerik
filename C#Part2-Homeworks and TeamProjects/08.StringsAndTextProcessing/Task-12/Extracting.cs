/* Write a program that parses an URL address given in the format:
 * [protocol]://[server]/[resource]

		
 * and extracts from it the [protocol], [server] and [resource] elements. 
 * For example from the URL http://www.devbg.org/forum/index.php the following 
 * information should be extracted:
		
 * [protocol] = "http"
 * [server] = "www.devbg.org"
 * [resource] = "/forum/index.php"
 */

namespace Task_12
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Extracting
    {
        static void Main()
        {
            //Uri uri = new Uri("http://www.devbg.org/forum/index.php"); //This is an alternative solution
            //Console.WriteLine(uri.Scheme);
            //Console.WriteLine(uri.Host);
            //Console.WriteLine(uri.AbsolutePath);
            //**************************************************************************************

            //string url = "http://www.devbg.org/forum/index.php"; //Second Solution
            //string protocol = url.Substring(0, url.IndexOf(':'));

            //int indexOfServer = url.IndexOf(':') + 3;
            //int nextSlash = url.IndexOf('/', indexOfServer);

            //string server = url.Substring(indexOfServer, nextSlash - indexOfServer);
            //string resource = url.Substring(nextSlash);
            //Console.WriteLine("Protocol: " + protocol);
            //Console.WriteLine("Server: " + server);
            //Console.WriteLine("Resource: " + resource);
            //**************************************************************************************

            string url = "http://www.devbg.org/forum/index.php";
            string[] arguments = { "://", "/" };
            string[] parsed = url.Split(arguments, 3, StringSplitOptions.None);
            parsed[2] = "/" + parsed[2];
            Console.WriteLine("protocol: {0}, server: {1}, resourse: {2}", parsed[0], parsed[1], parsed[2]);
        }
    }
}
