using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CRoomData
    {
        private static string filePath = @"D:\studyNam\projs\DoAn\QuanLiKS\Data\rooms.json";

        public static List<CRoom> rooms;
        public static List<CRoom> getAllRoom()
        {
            return rooms;
        }
        public static bool Find(string idRoom, ref CRoom r)
        {

            CRoom room = rooms.Find(rm => rm.IDRoom == idRoom);
            if (room != null)
            {
                r = room;
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Add(CRoom newRoom)
        {

            if (newRoom == null) {return false; }
            rooms.Add(newRoom);
            return true;
        }

        public static bool SaveRoomData()
        {
            try
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(rooms));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ReadRoomData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    rooms = JsonConvert.DeserializeObject<List<CRoom>>(jsonContent);
                    if (rooms == null)
                        rooms = new List<CRoom>();
                    return true;
                }
                else
                {
                    rooms = new List<CRoom>();
                    return false;
                }
            }
            catch
            {
                rooms = new List<CRoom>();
                return false;
            }
        }

    }
}
