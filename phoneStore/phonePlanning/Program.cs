using System;
using System.Collections.Generic;
using phoneBusiness;
using phoneModels;
using phoneRepository;
using System.Data.SqlClient;
using System.Data;

namespace phoneStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation
            //simulate dependency injection
            //creating instance to communicate with repo class 
            CosmoRepoClass crc = new CosmoRepoClass();
            //creating instance to communicate with domain(Business) class
            //in Domainclass there is constructor takes 1 argument (r)
            DomainClass dc = new DomainClass(crc);



            //write a Welcome string and make a loop for register/login

            Console.WriteLine("Hello Valued Customer!");
            Console.WriteLine("please Enter your Choice /n Enter 1 to Login /n Enter 2 to Register");
            string choice = Console.ReadLine();

            //start the program here!
            Console.WriteLine("Would you like to see a list of all the members?");
            string answer = Console.ReadLine();


            // choose a store loop



            // on choosing a store correctly, you query the Db for the products of th at store,. 




            //fill your cart loop
            // Dictionary<Product>
            //present them with the products
            // they choose a product and the quantity the way
            // over and over
            // make don't choose more product that there are in inventory 
            // once the y choose to check out, break out of loop





            //add up the total.
            // insert the ordered products in to the Db.
            // make sure to decrement the inventory or each rproduct in the stores inventory.



            // ask if they would like to continue shopping. if yes.. loop back to the top.
            // if no, log them out and loop back to the very very tip top () login .




            if (answer.CompareTo("yes") == 0)
            {
                // This creates the member class
                List<Member> members = fb.MembersList();

                foreach (Member m in members)
                {
                    Console.WriteLine($"The members data is Fname-{m.Fname}.....");
                }

            }

        }
    }
}