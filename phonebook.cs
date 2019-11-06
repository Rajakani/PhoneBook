using System;
using System.Collections.Generic;
using System.Linq;

List<Contact> Contacts=new List<Contact>();
static void Main(string[] args)
    {
        Console.WriteLine("1 : Add ContactDetails");
        Console.WriteLine("2 : Delete ContactDetails");
        Console.WriteLine("3 : Display ContactDetails");
        Console.WriteLine("4 : Exit");
        int UserInput = Int32.Parse(Console.ReadLine());
             if(UserInput==1)
             {
                 PhoneBook().AddContact();
             }
             else if(UserInput==2)
             {
                 PhoneBook().DeleteContact();
             }
             else if(UserInput==3)
             {
                 PhoneBook().ShowContact();
             }
             else
             {
                 Console.WriteLine("You have entered a wrong option.Please try again with different option.");
                Main();
             }
       
    }
public class PhoneBook
{

   
   
        public void AddContact()
        {
            Contact Contact= new Contact();
                   
            Console.WriteLine("Enter firstName : ");
            Contact.firstName=Console.ReadLine();
            Console.WriteLine("Enter lastName : ");
            Contact.lastName=Console.ReadLine();
            Console.WriteLine("Enter phoneNumber : ");
            Contact.phoneNumber=Console.ReadLine();
            Console.WriteLine("Enter emailId : ");
            Contact.emailId=Console.ReadLine();
            Master.Add(Contact);
            Console.WriteLine("Details added successfully ");
            Main();
        }
        public void DeleteContact()
        {
            Console.Write("Enter phone number you want to delete:");
            int phonenumber=Console.ReadLine();
            Contacts.RemoveAll(mobileNumber => mobileNumber.phoneNumber ==phonenumber);
            Console.Write("Contact deleted successfully");
            Main();
        } 
        public void ShowContact()
        {
            foreach (var person in Contacts)
            {
                Console.WriteLine("Name : "+person.firstName+" "+person.lastName+",PhoneNumber :"+person.phoneNumber+", Email Id:"+person.emailId);
            }
            Main();
        }
}
 public class Contact
    {
        public string firstName{get;set;}
        public string lastName{get;set;}
        public double phoneNumber{get;set;}
        public string emailId{get;set;}

    }


    