using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CCostomerData
    {
         static string filePath = @"D:\studyNam\projs\DoAn\QuanLiKS\Data\costomers.json";

        public static List<CCostomer> costomers;
        public static List<CCostomer> getAllCostomer()
        {
            return costomers;
        }
        public static bool Find(string CCCD, ref CCostomer c)
        {

            CCostomer costomer = costomers.Find(rm => rm.CCCD == CCCD);
            if (costomer != null)
            {
                c = costomer;
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool Add(CCostomer newCostomer)
        {

            if (newCostomer == null)
                return false;
            costomers.Add(newCostomer);
            return true;
        }

        public static bool SaveCostomerData()
        {
            try
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(costomers));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ReadCostomerData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string jsonContent = File.ReadAllText(filePath);
                    costomers = JsonConvert.DeserializeObject<List<CCostomer>>(jsonContent);
                    if (costomers == null)
                        costomers = new List<CCostomer>();
                    return true;
                }
                else
                {
                    costomers = new List<CCostomer>();
                    return false;
                }
            }
            catch
            {
                costomers = new List<CCostomer>();
                return false;
            }
        }
    }
}
