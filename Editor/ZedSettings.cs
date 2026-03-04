using UnityEngine;
using SimpleJSON;
using System.IO;

namespace UnityZed
{
    public class ZedSettings
    {
        private readonly string m_SettingsPath;

        public ZedSettings()
        {
            m_SettingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, ".zed", "settings.json");
        }

        public void Sync()
        {
            if (File.Exists(m_SettingsPath) == false)
            {
                UnityEngine.Debug.Log("Zed settings file not found, creating default settings file.");
                Directory.CreateDirectory(Path.GetDirectoryName(m_SettingsPath));
                File.WriteAllText(m_SettingsPath, JSON.Parse(kDefaultSettings).ToString());
            }
        }

        private const string kDefaultSettings = @"{
            ""file_scan_exclusions"": [
                ""**/.*"",
                ""**/*~"",

                ""*.csproj"",
                ""*.sln"",

                ""**/*.meta"",
                ""**/*.booproj"",
                ""**/*.pibd"",
                ""**/*.suo"",
                ""**/*.user"",
                ""**/*.userprefs"",
                ""**/*.unityproj"",
                ""**/*.dll"",
                ""**/*.exe"",
                ""**/*.pdf"",
                ""**/*.mid"",
                ""**/*.midi"",
                ""**/*.wav"",
                ""**/*.gif"",
                ""**/*.ico"",
                ""**/*.jpg"",
                ""**/*.jpeg"",
                ""**/*.png"",
                ""**/*.psd"",
                ""**/*.tga"",
                ""**/*.tif"",
                ""**/*.tiff"",
                ""**/*.3ds"",
                ""**/*.3DS"",
                ""**/*.fbx"",
                ""**/*.FBX"",
                ""**/*.lxo"",
                ""**/*.LXO"",
                ""**/*.ma"",
                ""**/*.MA"",
                ""**/*.obj"",
                ""**/*.OBJ"",
                ""**/*.asset"",
                ""**/*.cubemap"",
                ""**/*.flare"",
                ""**/*.mat"",
                ""**/*.meta"",
                ""**/*.prefab"",
                ""**/*.unity"",

                ""build/"",
                ""Build/"",
                ""library/"",
                ""Library/"",
                ""obj/"",
                ""Obj/"",
                ""ProjectSettings/"",
                ""UserSettings/"",
                ""temp/"",
                ""Temp/"",
                ""logs"",
                ""Logs"",
            ]
        }";
    }
}