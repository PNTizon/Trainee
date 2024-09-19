using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingCodes
{
    internal class OOP_User
    {
        //Private Attributes / Fields
        private int userID;
        private string username;
        private string password;

        //Properties
        public int UserID
        {
            get { return userID; }
            set {
                if (value >= 2000) userID = value;
                else Console.WriteLine("Error User ID must not be below 2000");

                if (value <= 2000) userID = value;
                else Console.WriteLine("Welcome!");
            }

        }
        public string Username
        {

            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public OOP_User( int userID,string username,string password)
        {
            UserID = userID;
            Username = username;    
            Password = password;    
        }
        /*

        //Automatic Properties

        public int userID
        {
            get;
            set;
            (get; set;)
            */
        
    }
}
