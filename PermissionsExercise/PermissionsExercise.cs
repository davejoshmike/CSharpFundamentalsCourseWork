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
            bool hasPermissions = CheckPermissionLevels(level, permission, out string message);
            string hasPermissionsMsg = hasPermissions ? "" : "Access Denied.";
            Console.WriteLine($"{hasPermissionsMsg} {message}");
        }

        // returns whether a user has the correct permissions and level ratings
        private static bool CheckPermissionLevels(int level, string permission, out string message)
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

        #endregion
    }
}