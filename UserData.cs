using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    internal class UserData
    {
        private static List<CUser> users;
        private static string filePath = @"D:\DA Tinhoc_1\Data\users.json";
        public static List<CUser> getAllUser()
        {
            return users;
        }
        public static bool Find(string username,ref CUser u)
        {
            
            CUser user = users.Find(us => us.Username == username);
            if(user != null)
            {
                u = user;
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool Add(CUser newUser)
        {
          
            if (newUser == null)
                return false;
            users.Add(newUser);
            return true;
        }
        public static bool SaveUserData()
        {
            try
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(users));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ReadUserData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    users = JsonConvert.DeserializeObject<List<CUser>>(jsonContent);
                    if (users == null)
                        users = new List<CUser>();
                    return true;
                }
                else
                {
                    users = new List<CUser>();
                    return false;
                }
            }
            catch
            {
                users = new List<CUser>();
                return false;
            }
        }

    }
}
