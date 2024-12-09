using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using MyNamespace;

public class SideQuest
{
    // Variabel untuk menghitung berapa kali quest ini diakses
    private static int questAccessCount = 0;
    private const int maxQuestAccess = 3;

    public static void Start(Scientist player)
    {
        if (questAccessCount >= maxQuestAccess)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Report: The quiz has already been completed 3 times.");
            Console.WriteLine("You can no longer access the Cerdas Cermat Challenge.");
            Console.WriteLine("Returning to the main menu...");
            Thread.Sleep(2000);
            return; 
        }
        questAccessCount++;

        Console.Clear();
        Console.WriteLine("========================================================");
        Console.WriteLine("| Selamat Datang ke Cerdas Cermat Tingkat Internasiona; |");
        Console.WriteLine("|          Earth Branch - Challenge Dr. Zombie          |");
        Console.WriteLine("========================================================");
        Thread.Sleep(1000);

        // Pertanyaan dan jawaban
        var questions = new List<(string Question, string Answer)>
        {
            ("What is the chemical symbol for water?", "H2O"),
            ("What planet is known as the Red Planet?", "Mars"),
            ("What is the powerhouse of the cell?", "Mitochondria"),
            ("Who developed the theory of relativity?", "Einstein"),
            ("What is the speed of light (in m/s)?", "299792458"),
            ("Amanjiwo terletak dimana?", "Magelang"),
            ("Who is the infamous Detective who lives in BAker Street 221B", "Sherlock Holmes"),
            ("What is the first words of Jabberwocky", "Twas"),
            ("What is the largest country in the world", "Russia"),
            ("What animals that not only embraces democracy, but also seniority?", "Cockroach")
        };

        // Shuffle pertanyaan
        var random = new Random();
        var shuffledQuestions = questions.OrderBy(_ => random.Next()).ToList();

        int playerScore = 0;
        int drZombieScore = 0;

        // Quiz loop
        for (int i = 0; i < 3; i++)
        {
            var (question, correctAnswer) = shuffledQuestions[i];
            Console.WriteLine($"Round {i + 1}:");
            Console.WriteLine($"Question: {question}");
            Console.Write("Your Answer: ");

            string playerAnswer = Console.ReadLine()?.Trim().ToLower();

            // Pemain menjawab
            if (string.Equals(playerAnswer, correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Correct!");
                playerScore++;
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer is {correctAnswer}.");
            }

            // Dr. Zombie menjawab
            bool drZombieCorrect = random.Next(2) == 0; // 50% kemungkinan benar
            if (drZombieCorrect)
            {
                drZombieScore++;
                Console.WriteLine("Dr. Zombie answered correctly!");
            }
            else
            {
                Console.WriteLine("Dr. Zombie answered incorrectly.");
            }

            Console.WriteLine($"Score - You: {playerScore}, Dr. Zombie: {drZombieScore}");
            Thread.Sleep(1000);
        }

        // Hasil akhir
        Console.WriteLine("====================================");
        Console.WriteLine("Final Scores:");
        Console.WriteLine($"You: {playerScore}");
        Console.WriteLine($"Dr. Zombie: {drZombieScore}");
        Console.WriteLine("====================================");

        if (playerScore > drZombieScore)
        {
            Console.WriteLine("Congratulations! You defeated Dr. Zombie in the quiz!");
            Console.WriteLine("Reward: XP and a Legendary Rare Seed");

            player.AddXP(100); // Menambahkan XP

            // Membuat dan memberikan RareSeed kepada pemain
            RareSeed rareSeed = new RareSeed();
            player.AddPlant(rareSeed); 
            
            Console.WriteLine("You have received a Rare Seed!");
            rareSeed.Use(player); 

            Console.WriteLine("Returning to the main menu...");
            Thread.Sleep(5000);
            return;
        }
    }
}
