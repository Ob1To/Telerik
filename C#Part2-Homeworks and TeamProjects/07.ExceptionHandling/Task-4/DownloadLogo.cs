/* Write a program that downloads a file from Internet 
 * (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
 * Find in Google how to download files in C#. 
 * Be sure to catch all exceptions and to free any used resources in the finally block.
 */

namespace Task_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Net;
    class DownloadLogo
    {
        static void Main()
        {
            using (WebClient webDownload = new WebClient())
            {
                try
                {
                    webDownload.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("The address can not be null");
                }
                catch (WebException)
                {
                    Console.Error.WriteLine("The address is invalid.");
                }

                catch (NotSupportedException)
                {
                    Console.Error.WriteLine("The method has been called simultaneously on multiple threads.");
                }
            }
        }
    }
}
