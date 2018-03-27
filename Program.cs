using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListsAndMoreList.Models;



//Use System.Linq for all the requirements. IE. Don't use a for/foreach loop to manipulate the users list.

//1. Display to the console, all the passwords that are "hello". Hint: Where

//2. Delete any passwords that are the lower-cased version of their Name.Do not just look for "steve". It has to be data-driven.Hint: Remove or RemoveAll

//3. Delete the first User that has the password "hello". Hint: First or FirstOrDefault

//4. Display to the console the remaining users with their Name and Password.


namespace ListsAndMoreList
{

    class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }

    class Program
    {
        private static User password;

        public static User Password { get; private set; }

        //public static DirectoryInfo CreateDirectory()

        static void Main(string[] args)
        {

            //string s = "steve";



            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            var firstUser = users[0];

            //1
            var findhello = users.Cast<Models.User>().First(t => t.Password == "hello");

            //Models.User Password = ({ "hello, steve, hello" });

            //2
            //string s1 = s.Remove(5);
            //var organize = users.Remove(Password);
            //List<string> userPassword = new List<string> { "hello, steve, hello" };
            //userPassword.RemoveAll("steve");

            var user = users.Find(t => t.Password == "hello");
            if (findhello == null)
            {
                users.Remove("steve");
            }

            var users = new Dictionary<string, Models.User>();
            users.Add(["8-6-12-12-15"], new Models.User { Password = "hello" });
            users.Add(["19-20-6-22-5"], new Models.User { Password = "steve" });

            if (users.ContainsKey("22"))
            {
                users.Remove();
            }




            //3
            //string[] user = { "Dave"};
            //string[] none = { };
            //var result = user.FirstOrDefault();
            //var resultEmpty = none.FirstOrDefault();
            //Debug.WriteLine(user = null);


            var user = users.OrderBy(t => t.Password = "hello").First();


            //4

            Console.Write("Remaining: Name = {0} Password = {1}");


        }
    }
}
