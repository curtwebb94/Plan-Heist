using System;
using System.Collections.Generic;

// The program should be updated to...

// Run the scenario multiple times.
// After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.

namespace PlanHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            List<TeamMember> teamMembers = new List<TeamMember>();

             // Prompt the user to enter team member's information
                Console.Write("Enter bank difficulty level (0-150): ");
                int bankDifficultyLevel = int.Parse(Console.ReadLine());

            while (true)

            {        

                Console.Write("Enter team member's name (enter break to exit): ");
                string name = Console.ReadLine();

                if (name.ToLower() == "break")
                    break;

                Console.Write("Enter team member's skill level (0-40): ");
                int skillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter team member's courage factor (0-2.0): ");
                double courageFactor = double.Parse(Console.ReadLine());

                // Create a new TeamMember object with the provided information
                TeamMember teamMember = new TeamMember(name, skillLevel, courageFactor);

                // Add the team member to the list of team members
                teamMembers.Add(teamMember);
            }

            Console.WriteLine("\nTeam Members Information");
            Console.WriteLine($"There are {teamMembers.Count} members ");
            Console.WriteLine();

            // Prompt the user to enter the number of trial runs
            Console.Write("Enter the number of trial runs: ");
            int numTrialRuns = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numTrialRuns; i++)
            {

                // Store a value for the bank's difficulty level. Set this value to 100.

                // Sum the skill levels of the team. Save that number.
                int totalSkillLevel = 0;
                // Sum the courage factor of the team. Save that number.
                double totalCourageFactor = 0;
                // Create a random number between -10 and 10 for the heist's luck value.
                Random random = new Random();
                int luck = random.Next(-10, 11);

                // Combine Total Skill level of luck and Bank Difficulty Level
                int luckAndDifficulty = luck += bankDifficultyLevel;

                Console.WriteLine($"Your Heist Score is: {luckAndDifficulty}!");
                Console.WriteLine(" ");

                foreach (var teamMember in teamMembers)
                {
                    totalSkillLevel += teamMember.SkillLevel;
                    totalCourageFactor += teamMember.CourageFactor;
                }

                if (totalSkillLevel >= bankDifficultyLevel)
                {
                    Console.WriteLine("SUCCESS!");
                    Console.WriteLine(" ");

                }
                else
                {
                    Console.WriteLine("FAILURE");
                    Console.WriteLine(" ");

                }

            }
        }
    }


    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            // Assign the provided values to the properties of the TeamMember object
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}
