using UnityEngine;
using System.IO;

namespace UnityZed
{
    public class ZedSettings
    {
        public void sync()
        {
            string settingsPath = Path.Combine(Directory.GetParent(Application.dataPath).FullName, ".zed", "settings.json");
            if (!File.Exists(settingsPath))
            {
                Debug.Log("[ZED] settings file not found, creating default settings file.");
                Directory.CreateDirectory(Path.GetDirectoryName(settingsPath));
                File.WriteAllText(settingsPath, defaultSettings);
            }
        }

        const string defaultSettings = @"{
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
