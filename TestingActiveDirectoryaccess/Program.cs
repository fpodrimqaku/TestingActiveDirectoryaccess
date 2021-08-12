using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace TestingActiveDirectoryaccess
{
    class Program
    {
        private static AuthenticationTypes atAuthentType;
        static void Main(string[] args)
        {
            Console.WriteLine("strDomain?\n");
            String strDomain = Console.ReadLine();
            Console.WriteLine("strUser?\n");
            String strUser = Console.ReadLine();
            Console.WriteLine("strPass?\n");
            String strPass = Console.ReadLine();
            Console.WriteLine("atAuthentType?\n");
            String atAuthentType = Console.ReadLine();

            Console.WriteLine(strDomain);
            Console.WriteLine(strUser);
            Console.WriteLine(strPass);
            Console.WriteLine(atAuthentType);
            Console.Write('\n');


            string mesazhi = "";

            using (DirectoryEntry deDirEntry = new DirectoryEntry(strDomain, strUser, strPass, atAuthentType.Equals("true")? AuthenticationTypes.SecureSocketsLayer: AuthenticationTypes.Secure))
            {

                try
                {
                    mesazhi = "Mirese vini ne '" + deDirEntry.Name + "'";
                    Console.WriteLine(""+true+"--"+ mesazhi);
                        }
                catch (Exception exp)
                {
                    mesazhi = "Me vjen keq, te dhenat tua nuk mund te verifikohen";
                    Console.WriteLine("" + false + "--" + mesazhi);
                }
                Console.ReadKey();
                Console.ReadKey();
            }


        }



     
    }
}
