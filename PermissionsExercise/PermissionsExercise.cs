using System;

namespace CSharpFundamentalsCourse.PermissionsExercise 
{
    public class PermissionsExercise
    {
        #region Static Methods

        public static void Main(string[] args)
        {
        
            string permission = "Admin|Manager";
            int level = 55;
            bool hasPermissions = CheckPermissionLevelsExerciseOne(level, permission, out string message);
            string hasPermissionsMsg = hasPermissions ? "" : "Access Denied.";
            Console.WriteLine($"{hasPermissionsMsg} {message}");
            Console.Write($"Press Enter to Continue...");
            Console.ReadLine();

            CheckPermissionsLevelExerciseTwoDoWhile();
        }

        // returns whether a user has the correct permissions and level ratings
        private static bool CheckPermissionLevelsExerciseOne(int level, string permission, out string message)
        {
            bool isAdmin = permission.Contains("Admin");
            bool isManager = permission.Contains("Manager");

            if (isAdmin){
                switch (level)
                {
                    case <= 55:
                        message = "You do not have sufficient privileges.";
                        return false;
                    case > 55:
                        message = "Welcome, Super Admin user.";
                        return true;
                }
            }
            else if (isManager) 
            {
                switch (level){
                    case >= 20:
                        message = "Contact an Admin for access.";
                        return false;
                    case < 20:
                        message = "You do not have sufficient privileges.";
                        return false;       
                }
            }
            else {
                message = "You do not have sufficient privileges.";
                return false;
            }
        }

        private static void CheckPermissionsLevelExerciseTwoDoWhile()
        {
            string? readResult;
            string roleName = "";
            bool validEntry = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);

            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            Console.Write("Press Enter to Continue.");
            readResult = Console.ReadLine();
        }

        #endregion
    }
}