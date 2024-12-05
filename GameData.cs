using System.Collections.Generic;

namespace MyNamespace {
    public class GameData {
        public string PlayerName { get; set; }
        public int PlayerHealth { get; set; }
        public int PlayerShield { get; set; }
        public int PlayerExp { get; set; }
        public int PlayerLevel { get; set; }
        public string PlayerTypeElement { get; set; }
        public List<string> Inventory { get; set; }

        public GameData() {
            Inventory = new List<string>();
        }
    }
}