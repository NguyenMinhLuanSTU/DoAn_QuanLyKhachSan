﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WindowsFormsApp1.Data
{
    class FileControl<T>
    {
        public static List<T> Read(string fileName)
        {
            string path = GetSourceCodePath(fileName);
            List<T> list = new List<T>();

            if (File.Exists(path))
            {
                try
                {
                    string json = File.ReadAllText(path);
                    list = JsonConvert.DeserializeObject<List<T>>(json);
                    return list;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi đọc tệp JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tệp không tồn tại: " + path, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        public static void Write(List<T> list, string fileName)
        {
            string path = GetSourceCodePath(fileName);

            try
            {
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(path, json);
                MessageBox.Show("Ghi tệp JSON thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi ghi tệp JSON: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetSourceCodePath(String fileName)
        {
            var relation = @"..\..\Data\";

            //chưa sửa path được
            string sourceCodePath = Path.Combine(Environment.CurrentDirectory, relation, fileName);

            return sourceCodePath;

        }
    }

}
