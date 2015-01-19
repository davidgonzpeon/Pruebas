using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiNQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] greetings = { "hello world", "hello LINQ", "hello Apress" };

             var items =
                 from s in greetings
                 where s.EndsWith("world")
                 select s;

             foreach (var item in items)
             {
                 Console.WriteLine(item);
             }

             Console.ReadKey(); */

            XElement books = XElement.Parse(
                @"<books>
                    <book>
                        <title>Pro LINQ: Language Integrated Query in C# 2008</title>
                        <author>Joe Rattz</author>
                    </book>
                    <book>
                        <title>Pro WF: Windows Workflow in .NET 3.0</title>
                        <author>Bruce Bukovics</author>
                    </book>
                    <book>
                        <title>Pro C# 2005 and the .NET 2.0 Platform, Third Edition</title>
                        <author>Andrew Troelsen</author>
                    </book>
                </books>");
            
            var titles =
                from book in books.Elements("book")
                where (string)book.Element("author") == "Joe Rattz"
                select book.Element("title");
            
            foreach (var title in titles)
                Console.WriteLine(title.Value);

            Console.ReadKey();
        }
    }
}
