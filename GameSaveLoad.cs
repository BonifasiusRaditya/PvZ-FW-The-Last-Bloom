using System;
using System.IO;
using System.Text.Json;
using ElementType;

namespace MyNamespace {
    public static class GameSaveLoad {
        private static string saveFilePath = "game_save.json";


        public static void SaveGame(Scientist player) {
            GameData data = new GameData {
                PlayerName = player.Name,
                PlayerHealth = player.Health,
                PlayerShield = player.Shield,
                PlayerExp = player.Exp,
                PlayerLevel = player.Level,
                PlayerTypeElement = player.TypeElement.ToString(),
                Inventory = player.Plants.ConvertAll(p => p.Name)
            };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(saveFilePath, json);
            Console.WriteLine("Game saved successfully!");
        }

        public static Scientist LoadGame() {
            if (!File.Exists(saveFilePath)) {
                Console.WriteLine("No save file found!");
                return null;
            }

            string json = File.ReadAllText(saveFilePath);
            GameData data = JsonSerializer.Deserialize<GameData>(json);

            if (data == null) return null;

            Scientist player = new Scientist(data.PlayerName) {
                Health = data.PlayerHealth,
                Shield = data.PlayerShield,
                Exp = data.PlayerExp,
                Level = data.PlayerLevel,
                TypeElement = Enum.Parse<Element>(data.PlayerTypeElement)
            };

            foreach (var itemName in data.Inventory) {
                // Tambahkan logika untuk membuat instance Entity dari nama item
            }

            Console.WriteLine("Game loaded successfully!");
            return player;
        }
    }
}
