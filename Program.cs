using System;

namespace RegexDay19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1
            UserInfo uc1 = new UserInfo();
            Console.WriteLine("First Name - ");
            string input = Console.ReadLine();
            Console.WriteLine(uc1.validateFirstName(input));
            #endregion

            #region UC2
            UserInfo uc2 = new UserInfo();
            Console.WriteLine("Last Name - ");
            string input2 = Console.ReadLine();
            Console.WriteLine(uc2.validateFirstName(input2));
            #endregion

            #region UC3
            UserInfo uc3 = new UserInfo();
            Console.WriteLine("Email - ");
            string input3 = Console.ReadLine();
            Console.WriteLine(uc3.validateEmail(input3));
            #endregion

            #region UC4
            UserInfo uc4 = new UserInfo();
            Console.WriteLine("Phone Number - ");
            string input4 = Console.ReadLine();
            Console.WriteLine(uc4.validateNumber(input4));
            #endregion

            #region UC5 - UC8
            UserInfo uc5_8 = new UserInfo();
            Console.WriteLine("Enter Password - ");
            string input5 = Console.ReadLine();
            Console.WriteLine(uc5_8.validatePassword(input5));
            #endregion

            #region UC9 - Valid Emails
            Console.WriteLine("*****************Valid Emails*************************");

            string v1 = "abc@yahoo.com";
            Console.WriteLine(uc3.validateEmail(v1));

            string v2 = "abc-100@yahoo.com";
            Console.WriteLine(uc3.validateEmail(v2));

            string v3 = "abc.100@yahoo.com";
            Console.WriteLine(uc3.validateEmail(v3));

            string v4 = "abc111@abc.com";
            Console.WriteLine(uc3.validateEmail(v4));

            string v5 = "abc.100@abc.com.au";
            Console.WriteLine(uc3.validateEmail(v5));

            string v6 = "abc@1.com";
            Console.WriteLine(uc3.validateEmail(v6));

            string v7 = "abc@gmail.com.com";
            Console.WriteLine(uc3.validateEmail(v7));

            string v8 = "abc+100@gmail.com";
            Console.WriteLine(uc3.validateEmail(v8));
            #endregion


            #region UC9 - Invalid Emails
            Console.WriteLine("*****************Invalid Emails*************************");

            string iv1 = "abc";
            Console.WriteLine(uc3.validateEmail(iv1));

            string iv2 = "abc@.com.my";
            Console.WriteLine(uc3.validateEmail(iv2));

            string iv3 = "abc123@gmail.a";
            Console.WriteLine(uc3.validateEmail(iv3));

            string iv4 = "abc123@.com";
            Console.WriteLine(uc3.validateEmail(iv4));

            string iv5 = "abc123@.com.com";
            Console.WriteLine(uc3.validateEmail(iv5));

            string iv6 = ".abc@abc.com";
            Console.WriteLine(uc3.validateEmail(iv6));

            string iv7 = "abc()*@gmail.com";
            Console.WriteLine(uc3.validateEmail(iv7));

            string iv8 = "abc@%*.com";
            Console.WriteLine(uc3.validateEmail(iv8));

            string iv9 = "abc..2002@gmail.com";
            Console.WriteLine(uc3.validateEmail(iv9));

            string iv10 = "abc.@gmail.com";
            Console.WriteLine(uc3.validateEmail(iv10));

            string iv11 = "abc@abc@gmail.com";
            Console.WriteLine(uc3.validateEmail(iv11));

            string iv12 = "abc@gmail.com.1a";
            Console.WriteLine(uc3.validateEmail(iv12));

            string iv13 = "abc@gmail.com.aa.au";
            Console.WriteLine(uc3.validateEmail(iv13));
            #endregion

            Console.ReadKey();
        }
    }
}
