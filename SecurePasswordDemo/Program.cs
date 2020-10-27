using SecurePasswordDemo.Data;
using SecurePasswordDemo.Services;
using System;
using System.Text;

namespace SecurePasswordDemo
{
    class Program
    {
        internal static AuthorizationService AuthService { get; set; } = new AuthorizationService();
        internal static DatabaseService DbService { get; set; } = new DatabaseService();

        static void Main(string[] args)
        {
            bool programState = true;

            while (programState)
            {
                Console.WriteLine("Do you want to login: Y\nDo you want to create a user: Z\nDo you want to exit system: Q\n");

                var answer = Console.ReadLine();

                switch (answer.ToUpper())
                {
                    case "Y":
                        RunUserLoginProcedure();
                        break;
                    case "Z":
                        RunCreateUserProcedure();
                        break;
                    case "Q":
                        programState = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        public static void RunUserLoginProcedure()
        {
            User loginUser = new User();
            bool verified = false;
            bool isAccountLocked = false;

            while (!isAccountLocked && !verified)
            {
                Console.Write("Enter username: ");
                loginUser.UserName = Console.ReadLine();

                if (DbService.GetUserLoginAttemptsByUserName(loginUser.UserName) <= 4)
                {
                    Console.Write("Enter password: ");
                    string plainPass = Console.ReadLine();

                    loginUser.Salt = DbService.GetUserSaltByUserName(loginUser.UserName);

                    if (!string.IsNullOrEmpty(loginUser.Salt))
                    {
                        loginUser.Password = AuthService.HashPasswordWithIterations(plainPass, loginUser.Salt);

                        verified = DbService.VerifyUser(loginUser);

                        if (verified)
                        {
                            Console.WriteLine($"Access Granted, Welcome Home.");
                        }
                        else
                        {
                            var loginAttempts = DbService.GetUserLoginAttemptsByUserName(loginUser.UserName);

                            if (loginAttempts != 5)
                            {
                                Console.WriteLine($"Username / Password was wrong. {loginAttempts} / 5 is used.");
                            }
                            else
                            {
                                DbService.LockAccount(loginUser.UserName);
                                isAccountLocked = true;

                                Console.WriteLine($"Your account is locked. Check your email to verify your identity.");
                            }
                        }
                    }
                }
                else
                {
                    isAccountLocked = true;
                    Console.WriteLine($"Your account is locked. Check your email to verify your identity.");
                }
            }
        }

        public static void RunCreateUserProcedure()
        {
            const string MenuText = "<< Fill out the Fields to create a User >>";

            User runTimeUser = new User();

            var tempPassword = string.Empty;

            Console.WriteLine(MenuText);

            Console.Write("Enter first name : ");
            runTimeUser.FirstName = Console.ReadLine();

            Console.Write("Enter last name : ");
            runTimeUser.LastName = Console.ReadLine();

            Console.Write("Enter username : ");
            runTimeUser.UserName = Console.ReadLine();

            Console.Write("Enter password : ");
            tempPassword = Console.ReadLine();

            // Hashing with Pepper (Salt)
            runTimeUser.Salt = AuthService.GenerateSalt();
            //runTimeUser.Password = AuthService.GenerateHashedPassword(tempPassword, runTimeUser.Salt);
            Console.WriteLine("Wait a minute..");
            runTimeUser.Password = AuthService.HashPasswordWithIterations(tempPassword, runTimeUser.Salt);
            Console.WriteLine("Completed...");

            DbService.CreateUser(runTimeUser);

            Console.Clear();
        }
    }
}
