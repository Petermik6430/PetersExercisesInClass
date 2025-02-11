
using System;
using System.Security.Cryptography.X509Certificates;
using What_is_printed__explain_session_2;

namespace What_Is_Printed__Explain_Session_2
{




    internal class Program
    {
        static void Main()
        {
            //  I det første tilfælde med str1 og str2 printes "1. Variables are equal: True",
            //  fordi de to strenge er identiske og sammenlignes ved hjælp af værdien.
            string str1 = "Hans";
            string str2 = "Hans";

            Console.WriteLine("1. Variables are equal:" + (str1 == str2));

            //I det andet tilfælde med p1 og p2 printes "2. Variables are equal: False",
            //fordi selvom objekterne har samme værdier, sammenlignes referenceadresserne i hukommelsen,
            //som er forskellige for p1 og p2.
            Person p1 = new Person("Hans", "Hovedvejen 1");
            Person p2 = new Person("Hans", "Hovedvejen 1");

            Console.WriteLine("2. Variables are equal: " + (p1 == p2));
        }
    }
}