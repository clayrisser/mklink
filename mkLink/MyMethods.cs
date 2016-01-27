using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkLink {
    class MyMethods {

        public static string findDescription(string type) {
            string description = "";

            switch(type) {
                case "Symbolic Link":
                    description = "Creates a symbolic link, also known as a shortcut.";
                    break;
                case "Hard Link":
                    description = "Creates a hard link.";
                    break;
                case "Directory Junction":
                    description = "Creates a Directory Junction.";
                    break;
                default:
                    description = "No description found.";
                    break;
            }

            return description;
        }

    }
}
