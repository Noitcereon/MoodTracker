using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerLib.Implementation
{
    public class Concurrency
    {
        private const string FileName = "moodStats.json";

        private static readonly string DirPath = Directory.GetCurrentDirectory() + "/Data";
        private static readonly string FilePath = DirPath + $"/{FileName}";

        public static List<IDay> LoadDaysFromJson()
        {
            
            CheckIfDirExists();

            byte[] fileBytes = File.ReadAllBytes(FilePath);
            //using FileStream fs = File.OpenRead(filePath);
            //fs.
            string json = Encoding.UTF8.GetString(fileBytes);

            if(string.IsNullOrWhiteSpace(json)) return new List<IDay>();

            List<IDay> output = new List<IDay>(JsonSerializer.Deserialize<List<Day>>(json)); 

            return output.Count > 0 ? output : new List<IDay>();
        }

        public static void SaveDaysToJson(List<IDay> days)
        {
            CheckIfDirExists();
            string json = JsonSerializer.Serialize(days);
            using StreamWriter sw = File.CreateText(FilePath);
            sw.AutoFlush = true;
            sw.Write(json);
        }

        private static void CheckIfDirExists()
        {
            if (Directory.Exists(DirPath)) return;
            Directory.CreateDirectory(DirPath);
            File.Create(FilePath);
        }
    }
}
