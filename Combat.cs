using ElementType;
namespace MyNamespace
{
    public static class Combat
    {
        // Fungsi untuk menghitung damage berdasarkan efektivitas elemen
        public static int CalculateElementDamage(int baseDamage, ElementType.Element attackerElement, ElementType.Element defenderElement)
        {
            double multiplier = ElementEffectiveness.GetMultiplier(attackerElement, defenderElement);
            return (int)(baseDamage * multiplier);
        }

        private static readonly Random rand = new Random();

        private static void DisplayAtmosphere()
        {
            switch (rand.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("The wind is howling....");
                    break;
                case 2:
                    Console.WriteLine("The ground is shaking....");
                    break;
                case 3:
                    Console.WriteLine("The sky is darkening....");
                    break;
            }
        }

        // Metode utama pertarungan
        public static void Fight(Entity player, Entity enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                DisplayAtmosphere();

                // Menampilkan status kesehatan pemain dan musuh
                Console.WriteLine($"{player.Name} Health: {player.Health}");
                Console.WriteLine($"{enemy.Name}'s Health: {enemy.Health}");
                Console.WriteLine("-------------------------");
                Console.WriteLine("     Attack, Shield      ");
                Console.WriteLine("        Use Item         ");
                Console.WriteLine("          Run            ");
                Console.WriteLine("     Show Information    ");
                Console.WriteLine("-------------------------");

                // Mengecek input pemain
                Console.Write("Choose an action: ");
                string option = (Console.ReadLine() ?? "").ToLower();

                // Pemain menyerang
                if (option == "attack")
                {
                    if (player is Scientist scientist)
                    {
                        if (scientist.Plants.Count > 0)
                        {
                            for (int i = 0; i < scientist.Plants.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {scientist.Plants[i].Name}");
                            }
                            Console.WriteLine("Choose a plant to attack:");

                            int choice;
                            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= scientist.Plants.Count)
                            {
                                Entity plant = scientist.Plants[choice - 1];
                                int damage = CalculateElementDamage(plant.AttackDamage, plant.TypeElement, enemy.TypeElement);
                                enemy.Health -= damage;
                                Console.WriteLine($"You attacked the zombie with {plant.Name}, dealing {damage} damage!");

                                // Cek jika HP plant atau zombie < 50, panggil skill khusus
                                if (plant.Health <= 50)
                                {
                                    // Trigger skill khusus untuk tanaman jika HP <= 50
                                    if (plant is FreezePea freezePea)
                                    {
                                        freezePea.FreezeAttack(enemy);  // Panggil FreezeAttack untuk FreezePea
                                    }

                                    if (plant is FireBlaze fireBlaze)
                                    {
                                        fireBlaze.Ignite(enemy);  // Panggil Ignite untuk FireBlaze
                                    }

                                    if (plant is LightningSnap lightningSnap)
                                    {
                                        lightningSnap.ChainLightning(new Entity[] { enemy });  // Panggil ChainLightning untuk LightningSnap
                                    }

                                    if (plant is SolarBloom solarBloom)
                                    {
                                        solarBloom.Heal(player, 20);  // Panggil Heal untuk SolarBloom jika HP < 50
                                    }

                                    if (plant is ThornyCactus thornyCactus)
                                    {
                                        thornyCactus.TakeDamage(10);  // Panggil Counterattack untuk ThornyCactus
                                    }
                                }

                                // Cek jika HP musuh < 50, panggil skill khusus untuk zombie
                                if (enemy.Health <= 50)
                                {
                                    if (enemy is FireZombie fireZombie)
                                    {
                                        fireZombie.FlameBurst(player);  // Panggil FlameBurst untuk FireZombie
                                    }

                                    if (enemy is BossZombie bossZombie)
                                    {
                                        bossZombie.Regenerate();  // Panggil Regenerate untuk BossZombie
                                    }

                                    if (enemy is KingZombie kingZombie)
                                    {
                                        kingZombie.Berserk();  // Panggil Berserk untuk KingZombie
                                    }

                                    if (enemy is WaterZombie waterZombie)
                                    {
                                        waterZombie.Drench(player);  // Panggil Drench untuk WaterZombie
                                    }
                                }

                                // Hapus tanaman dari inventory setelah digunakan
                                if (plant is Item itemPlant)
                                {
                                    scientist.Inventory.RemoveItem(itemPlant);  // Hapus item jika plant merupakan Item
                                }


                                // Hapus tanaman dari daftar tanaman setelah digunakan
                                scientist.Plants.RemoveAt(choice - 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid choice. No attack performed.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No plants in inventory!");
                        }
                    }
                }


                // Pemain menggunakan item (Health Potion atau Shield Upgrade)
                else if (option == "use item")
                {
                    if (player is Scientist scientist && scientist.Inventory != null && scientist.Inventory.Count > 0)
                    {
                        Console.WriteLine("Choose an item to use from your inventory:");

                        // Tampilkan item di inventory
                        scientist.Inventory.DisplayInventory();  // Menampilkan semua item di inventory

                        int itemChoice;
                        if (int.TryParse(Console.ReadLine(), out itemChoice) && itemChoice > 0 && itemChoice <= scientist.Inventory.Count)
                        {
                            // Pilih item dari inventory menggunakan GetItemAt
                            Item selectedItem = scientist.Inventory.GetItemAt(itemChoice - 1);

                            if (selectedItem != null)
                            {
                                // Gunakan item pada player (misalnya heal atau shield)
                                selectedItem.Use(player);
                                scientist.Inventory.RemoveItem(selectedItem);  // Hapus item setelah digunakan
                            }
                            else
                            {
                                Console.WriteLine("Invalid item choice.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid item choice.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No items available or inventory is empty.");
                    }
                }
                // Pemain bertahan dengan shield
                else if (option == "shield")
                {
                    player.Health = player.Shielded(player.Health, player.Shield);
                    Console.WriteLine("You shielded yourself!");
                }
                // Pemain melarikan diri
                else if (option == "run")
                {
                    Console.WriteLine("You ran away...");
                    break;
                }
                // Menampilkan informasi
                else if (option == "showinformation")
                {
                    player.Display();
                    enemy.Display();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                // Input tidak valid
                else
                {
                    Console.WriteLine("Invalid option. Try again.");
                }

                // Musuh menyerang jika pemain tidak memilih ShowInformation atau Run
                if (option != "showinformation" && option != "run")
                {
                    Entity target = player;
                    int enemyDamage = CalculateElementDamage(
                        enemy.AttackDamage,
                        enemy.TypeElement,
                        target.TypeElement
                    );
                    if (player is Scientist scientist && scientist.Plants.Count > 0)
                    {
                        int randomPlantIndex = rand.Next(0, scientist.Plants.Count); // Random index
                        target = scientist.Plants[randomPlantIndex]; // Randomly select a plant
                        Console.WriteLine($"{enemy.Name} attacked your plant, {target.Name}, dealing {enemyDamage} damage!!");
                    }
                    else
                    {
                        Console.WriteLine($"{enemy.Name} attacked you directly!");
                    }

                    player.Health -= enemyDamage;
                    if (rand.Next(1, 101) <= 15)
                    { // 15% chance untuk memberi debuff
                        player.ApplyDebuff("shield", 3); // Mengurangi shield pemain
                    }
                }

                // Mengecek kondisi menang/kalah
                if (player.Health <= 0)
                {
                    Console.WriteLine("You died...");
                    break;
                }

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("You defeated the zombie!");
                    player.Exp += enemy.Exp;
                    break;
                }
            }
        }
    }
}
