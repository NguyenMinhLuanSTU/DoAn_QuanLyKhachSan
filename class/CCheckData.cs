using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CCheckData
    {
        static string filePath = @"D:\studyNam\projs\DoAn\QLKS\Data\checks.json";

        public static List<CCheck> checks;
        public static List<CCheck> getAllCheck()
        {
            return checks;
        }
        
        public static bool Find(string CCCD, ref CCheck c){
            CCheck check = checks.Find(ch => ch.costomer.CCCD == CCCD);
            if (check != null)
            {
                c = check;
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public static bool Add(CCheck newCheck)
        {

            if (newCheck == null)
                return false;
            checks.Add(newCheck);
            return true;
        }

        public static bool SaveCheckData()
        {
            try
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(checks));
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
                    checks = JsonConvert.DeserializeObject<List<CCheck>>(jsonContent);
                    if (checks == null)
                        checks = new List<CCheck>();
                    return true;
                }
                else
                {
                    checks = new List<CCheck>();
                    return false;
                }
            }
            catch
            {
                checks = new List<CCheck>();
                return false;
            }
        }
    }
}
