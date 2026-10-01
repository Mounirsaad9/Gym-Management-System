using clsDataAccess;
using System;
using System.IO;

namespace clsBusinessLayer
{
    public static class clsDatabase
    {
        // إرجاع المسار الافتراضي الآمن (مثلاً D:\Gym_Backups أو C:\Gym_Backups)
        public static string GetDefaultBackupFolder()
        {
            string drive = DriveInfo.GetDrives().Length > 1 && Directory.Exists(@"D:\") ? @"D:\" : @"C:\";
            string defaultPath = Path.Combine(drive, "Gym_Backups");

            if (!Directory.Exists(defaultPath))
            {
                try
                {
                    Directory.CreateDirectory(defaultPath);
                }
                catch
                {
                    // في حال عدم توفر الصلاحيات نلجأ لمجلد MyDocuments
                    defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Gym_Backups");
                    Directory.CreateDirectory(defaultPath);
                }
            }
            return defaultPath;
        }

        public static bool PerformBackup(string fullPath)
        {
            return clsDatabaseData.CreateBackup(fullPath);
        }

        public static bool PerformRestore(string fullPath)
        {
            if (!File.Exists(fullPath)) return false;
            return clsDatabaseData.RestoreBackup(fullPath);
        }
    }
}