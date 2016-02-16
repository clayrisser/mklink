using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mkLink {
    static class MyMethods {


        public static bool IsFile(this string path) {
            bool isFile = true;
            try {
                FileAttributes fa = File.GetAttributes(path);
                if (fa.HasFlag(FileAttributes.Directory)) {
                    isFile = false;
                }
            } catch (FileNotFoundException) { // Manuelly determine if path is a file
                isFile = false;
                for (int i = path.Length - 1; i > 0; i--) {
                    if (path[i] == '\\' || path[i] == '/') {
                        break;
                    } else {
                        if (path[i] == '.') {
                            isFile = true;
                        }
                    }
                }
            } catch (ArgumentException) { }
            return isFile;
        }


        public static string FindDescription(this string type) {
            string description = "";

            switch (type) {
                case "Symbolic Link":
                    description = "Creates a symbolic link, also known as a shortcut.";
                    break;
                case "Hard Link / Directory Junction":
                    description = "Creates a new path for the target file/folder in addtion to the origional path.";
                    break;
                default:
                    description = "No description found.";
                    break;
            }

            return description;
        }
    }
}