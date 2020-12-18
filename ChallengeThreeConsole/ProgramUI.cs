using ChallengeThreeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThreeConsole
{
    public class ProgramUI
    {
        public BadgeRepository BadgeRepo { get; set; }

        public void Run()
        {
            BadgeRepo = new BadgeRepository();
            SeedBadges();
            MainMenu();
        }
        public void SeedBadges()
        {
            BadgeRepo.AddBadge(new Badge(1, new List<string>() { "D2", "D4", "D6"}));
            BadgeRepo.AddBadge(new Badge(3, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(5, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(7, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(9, new List<string>() { "D20", "D30", "D40" }));
            BadgeRepo.AddBadge(new Badge(11, new List<string>() { "D2", "D4", "D6" }));
            BadgeRepo.AddBadge(new Badge(13, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(15, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(17, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(19, new List<string>() { "D20", "D30", "D40" }));
            BadgeRepo.AddBadge(new Badge(21, new List<string>() { "D2", "D4", "D6" }));
            BadgeRepo.AddBadge(new Badge(23, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(25, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(27, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(29, new List<string>() { "D20", "D30", "D40" }));
            BadgeRepo.AddBadge(new Badge(31, new List<string>() { "D2", "D4", "D6" }));
            BadgeRepo.AddBadge(new Badge(33, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(35, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(37, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(39, new List<string>() { "D20", "D30", "D40" })); 
            BadgeRepo.AddBadge(new Badge(41, new List<string>() { "D2", "D4", "D6" }));
            BadgeRepo.AddBadge(new Badge(43, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(45, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(47, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(49, new List<string>() { "D20", "D30", "D40" }));
            BadgeRepo.AddBadge(new Badge(51, new List<string>() { "D2", "D4", "D6" }));
            BadgeRepo.AddBadge(new Badge(53, new List<string>() { "D8", "D12", "D16" }));
            BadgeRepo.AddBadge(new Badge(55, new List<string>() { "D10", "D14", "D18" }));
            BadgeRepo.AddBadge(new Badge(57, new List<string>() { "D22", "D24", "D26" }));
            BadgeRepo.AddBadge(new Badge(59, new List<string>() { "D20", "D30", "D40" }));

        }
        public void MainMenu()
        {
            bool isAcceptingInput = true;
            while (isAcceptingInput == true)
            {
                Console.Clear();
                Console.WriteLine("Badge Management System");
                Console.WriteLine("1. Add a badge");
                Console.WriteLine("2. Edit badge");
                Console.WriteLine("3. List all badges");
                Console.WriteLine("4. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SubMenuAddBadge();
                        break;
                    case "2":
                        SubMenuUpdateBadge();
                        break;
                    case "3":
                        SubMenuGetBadges();
                        break;
                    case "4":
                        isAcceptingInput = false;
                        break;
                }
            }
        }
        public void SubMenuAddBadge()
        {
            Console.Clear();
            Badge newBadge = new Badge();

            Console.WriteLine("Enter badge ID:");
            newBadge.BadgeID = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Badge ID:{newBadge.BadgeID} // To which door would you like to grant access?");
            newBadge.AddDoor(Console.ReadLine());

            bool stillAddingDoors = true;
            while (stillAddingDoors == true)
            {
            Console.WriteLine("Add another door access to this badge? Y or N:");
            string addAnotherDoor = Console.ReadLine();

                switch (addAnotherDoor)
                {
                    case "Y":
                        Console.WriteLine($"Badge ID:{newBadge.BadgeID} // To which door would you like to grant access?");
                        newBadge.AddDoor(Console.ReadLine());
                        break;
                    case "N":
                        stillAddingDoors = false;
                        break;
                }
            }
            BadgeRepo.AddBadge(newBadge);
        }

       public void SubMenuUpdateBadge()
       {
            Console.Clear();
            
            Console.WriteLine("Enter badge ID to update:");
            int badgeId = Int32.Parse(Console.ReadLine());
            Badge selectedBadge = BadgeRepo.GetBadgesByBadgeID(badgeId);
            Console.WriteLine($"Updating Badge ID:{selectedBadge.BadgeID}");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add door access");
            Console.WriteLine("2. Remove door access");
            Console.WriteLine("3. Exit");

            bool isAcceptingInput = true;
            while (isAcceptingInput == true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine($"Granting Badge ID:{selectedBadge.BadgeID} access to door:");
                        selectedBadge.AddDoor(Console.ReadLine());
                        Console.WriteLine($"Confirmed: Badge {selectedBadge.BadgeID} granted access to {selectedBadge.GetFormattedDoorList()}");
                        break;
                    case "2":
                        Console.WriteLine($"Removing Badge ID:{selectedBadge.BadgeID} access to door:");
                        selectedBadge.RemoveDoor(Console.ReadLine());
                        Console.WriteLine($"Confirmed: Badge {selectedBadge.BadgeID} only able to access {selectedBadge.GetFormattedDoorList()}");
                        break;
                    case "3":
                        isAcceptingInput = false;
                        break;
                }

            }

            
       }
        public void SubMenuGetBadges()
        {
            Console.Clear();
            Dictionary<int,Badge> subMenuOfBadges = BadgeRepo.ViewBadges();
            
            foreach (int key in subMenuOfBadges.Keys)
            {
                Badge currBadge = subMenuOfBadges[key];
                Console.WriteLine($"Badge {currBadge.BadgeID} // Door Access: {currBadge.GetFormattedDoorList()}");
            }
            Console.Read();
        }

    }
}
