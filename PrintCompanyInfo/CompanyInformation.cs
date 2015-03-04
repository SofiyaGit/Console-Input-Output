using System;

//Problem 2. Print Company Information
namespace PrintCompanyInfo
{
    class CompanyInformation
    {
        static void Main()
        {  
            Console.WriteLine("Enter a company name :");

            string companyName = Console.ReadLine();

            Console.WriteLine("Enter address :");

            string companyAdress = Console.ReadLine();

            Console.WriteLine("Enter phone number :");

            string phoneNumber = (Console.ReadLine());

            Console.WriteLine("Enter fax number :");

            int fax = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter website :");

            string website = Console.ReadLine();

            Console.WriteLine("Enter manager first name :");

            string managerFName = Console.ReadLine();

            Console.WriteLine("Enter manager last name :");

            string managerLName = Console.ReadLine();

            Console.WriteLine("Enter manager age :");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter manager phone number :");

            string managerPhoneNum = (Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine(companyName);

            Console.WriteLine("Address : {0}", companyAdress);

            Console.WriteLine("Tel. : {0}", phoneNumber);

            if (fax == 0)
            {
                 Console.WriteLine("Fax:  (no fax)");
            }

            Console.WriteLine("Fax : {0}", fax);

            Console.WriteLine("Web site : {0}", website);

            Console.WriteLine("Manager: {0} {1}  (age: {2}, tel. {3} )",managerFName,managerLName,age,managerPhoneNum);
        }
    }
}
