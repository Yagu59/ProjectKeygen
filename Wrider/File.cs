using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Text;

namespace Wrider
{
    public static class File
    {
        public static T LoadJson<T>(string directoryPath, string fileName)
        {
            try
            {
                string folderPath = directoryPath;
                string filePath = Path.Combine(folderPath, fileName);

                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader reader = new StreamReader(fileStream);
                string json = reader.ReadToEnd();
                fileStream.Close();
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception e)
            {
#if DEBUG
                MessageBox.Show(e.Message, "ÉGÉâÅ[");
#endif
                return default(T);
            }
        }

        public static void SaveJson<T>(T type, string directoryPath, string fileName)
        {
            try
            {
                string json = JsonConvert.SerializeObject(type, Formatting.Indented);
                string folderPath = directoryPath;
                string filePath = Path.Combine(folderPath, fileName);

                if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
                FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter writer = new StreamWriter(fileStream);
                writer.WriteLine(json);
                writer.Write(Environment.NewLine);
                writer.Flush();
                writer.Close();
                fileStream.Close();
            }
            catch (Exception e)
            {
                
            }
        }
    }
}