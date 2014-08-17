using System;
using System.Net;
using System.IO;
using System.Text;

class Downloader
{
    static void Main(string[] args)
    {

        WebClient downloader = new WebClient();
        string uri = "http://www.devbg.org/img/Logo-BASD.jpg";
        string destination = Directory.GetCurrentDirectory() + @"\Logo-BASD.jpg";
        try
        {
            downloader.DownloadFile(uri, destination);
        }
        catch (WebException we)
        {
            Console.WriteLine(we.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message); ;
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        finally
        {
            downloader.Dispose();
        }
            
    }
}

