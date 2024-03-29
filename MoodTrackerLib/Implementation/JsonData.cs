﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;
using NLog;

namespace MoodTrackerLib.Implementation
{
    public class JsonData
    {
        private const string FileName = "moodStats.json";

        private static readonly string DirPath = Directory.GetCurrentDirectory() + "/Data";
        private static readonly string FilePath = DirPath + $"/{FileName}";
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public static List<IDay> LoadDaysFromJson()
        {
            CheckIfDirExists();

            // TODO: it might be better to use StreamReader, but can't be bothered looking into how it should be done atm.
            //using StreamReader sr = new StreamReader(FilePath);
            //sr.ReadLine();
            _logger.Debug("Reading data from {file}", FilePath);
            byte[] fileBytes = File.ReadAllBytes(FilePath);
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
            _logger.Debug("Day data has been saved to {file}", FilePath);
        }

        public static void BackupOldData(List<IDay> oldData)
        {
            CheckIfDirExists();
            string json = JsonSerializer.Serialize(oldData);
            String backupDataPath = DirPath + "/moodStatsOldData.json";
            using StreamWriter sw = File.CreateText(backupDataPath);
            sw.AutoFlush = true;
            sw.Write(json);
            _logger.Debug("Old data has been saved to {oldDataPath}", backupDataPath);
        }

        private static void CheckIfDirExists()
        {
            if (Directory.Exists(DirPath) && File.Exists(FilePath)) return;
            
            _logger.Debug("Couldn't find {dataFile}, so creating new one.", DirPath);
            Directory.CreateDirectory(DirPath);
            using FileStream fs = File.Create(FilePath);
        }
    }
}
