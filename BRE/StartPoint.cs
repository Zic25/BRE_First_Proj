using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BRE
{
    /// <summary>
    /// Below is the Program.cs file as we have converted it to as a starting file for our requirement to identify the starting point
    /// </summary>
    class StartPoint 
    {
        public static String Inputstr;        

        public enum Level
        {
            Physical_Product,
            Book,
            Membership,
            Video,
            PhysicalOrBooks_Commision
        }        

        public static string Calculate(string Input, Level op, ProClasses.PhysicalProducts pp, ProClasses.Books BK, ProClasses.Membership Mbs, ProClasses.Other Oth, ProClasses.Videos Vi)
        {            
            switch (op)
            {
                case Level.Physical_Product:
                    Inputstr = pp.PhysicalProduct();                  
                    return Inputstr;

                case Level.Book:
                    Inputstr = BK.BooksLogic();
                    return Inputstr;

                case Level.Membership:
                    Inputstr = Mbs.AnyOneMembershipCreateorUpgrade();
                    return Inputstr;

                case Level.Video:
                    Inputstr = Vi.video();
                    return Inputstr;

                case Level.PhysicalOrBooks_Commision:
                    Inputstr = Oth.AgentCommision();
                    return Inputstr;

                default:
                    throw new InvalidOperationException("Couldn't process operation: " + Inputstr);
            }          
        }

        static void Main(string[] args)
        {
            ProClasses.PhysicalProducts PPObj=new ProClasses.PhysicalProducts();
            ProClasses.Books BKObj=new ProClasses.Books();
            ProClasses.Membership MbsObj=new ProClasses.Membership();
            ProClasses.Other OthObj=new ProClasses.Other();
            ProClasses.Videos ViObj=new ProClasses.Videos();

            /// Note : We have process it for Books.If want to try others options just change enum argument to different options.            

            Console.Write("What do you want to Process : \n 1.Physical Product \n 2.Book \n 3.Membership \n 4.Video\n\n");
            Console.WriteLine("\n Just Type \'Book\' Word in console for Book option selection");
            Inputstr = Console.ReadLine();
            Console.WriteLine("*****************************************************");
            string result = Calculate(Inputstr, Level.Book, PPObj, BKObj, MbsObj, OthObj, ViObj); /// Note : We have process it for Books.If want to try others options just change enum argument to different options.  
            Console.WriteLine("\nWe have process successfully : " + result+"\n");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("\n\n Note: We have process it for Books.If want to try others options just change \'enum argument in Calculate function\' to different options");
            Console.WriteLine("\n*****************************************************");
            Console.WriteLine("\n\n Note :- Unit Test Project created for it as well");
            Console.ReadLine();
        }
    }
}
