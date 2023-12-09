namespace Cafe_Falaicha.Data.Utils;

public static class Utils
{
    public static string ApplicationDirectoryPath()
    {
        string appDirectoryPath = @"D:\IIC\Application Development\Self\Cafe_Failcha Database";
        if (!Directory.Exists(appDirectoryPath))
        {
            Directory.CreateDirectory(appDirectoryPath);
            return appDirectoryPath;
        }
        else
        {
            return appDirectoryPath;
        }
    }

    public static string AddInsFilePath()
    {
        string directoryPath = ApplicationDirectoryPath();
        string fileName = "AddIns.json";
        string filePath = Path.Combine(directoryPath, fileName);
        if (!File.Exists(filePath))
        { 
            File.Create(filePath);
            return filePath;
        }
        else
        {
            return filePath;
        }
    }
}
