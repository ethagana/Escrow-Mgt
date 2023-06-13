using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EscrowManagement
{

    class GlobalVar
    {
        public static string conn_url = "https://blueviolet.tech/ver_id/websrvc.php";

        public static string api_key = "P0oG6pnwuI>t*gQ*SehXqEp#x`5#Y";

        public static string no_conn_msg = "Unable to Connect to the Blueviolet Network, Kindly check your internet connection";

        public static string fid;

        public static string usrid;

        public static string usrnme;

        public static string fp_hex;

        public static int fp_digit;

        public static int access_lvl;

        public static frmLogin loginfrm;

        public static frmMain mainfrm;

        public static ucEscrows ucEscrw;

        public static ucFinailzeEscrows ucfzEscrw;

        public static Boolean checkConn()
        {
            try
            {
                Ping x = new Ping();
                PingReply reply = x.Send(IPAddress.Parse("68.66.241.65"), 10000);//104.27.183.73 169.239.252.83
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
            }

            catch { }


            return false;
        }

        public static string ToTitleCase(string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title);
        }

        public static string ToUpperCase(string title)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToUpper(title);
        }
    }
}
