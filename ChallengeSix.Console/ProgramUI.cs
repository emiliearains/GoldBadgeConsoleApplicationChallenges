using ChallengeSixClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSixConsole
{
    public class ProgramUI
    {
        public CarRepository ElectricCarRepo { get; set; }
        public CarRepository HybridCarRepo { get; set; }
        public CarRepository GasCarRepo { get; set; }
        public void Run()
        {
            ElectricCarRepo = new CarRepository();
            HybridCarRepo = new CarRepository();
            GasCarRepo = new CarRepository();
            SeedCar();
            MainMenu();
        }
        public void SeedCar()
        {
            ElectricCarRepo.AddCar(new Car("Hyundai", "Ioniq", 170));
            ElectricCarRepo.AddCar(new Car("Porsche", "Taycan", 203));
            ElectricCarRepo.AddCar(new Car("Audi", "e-tron", 204));
            ElectricCarRepo.AddCar(new Car("Jaguar", "I-Pace", 234));
            GasCarRepo.AddCar(new Car("Hyundai", "Sonata", 330));
            HybridCarRepo.AddCar(new Car("Hyundai", "Sonata Hybrid", 340));
            GasCarRepo.AddCar(new Car("Lincoln", "MKC", 335));
            GasCarRepo.AddCar(new Car("Honda", "Civic", 350));
            HybridCarRepo.AddCar(new Car("Honda", "Civic Hybrid", 450));
            GasCarRepo.AddCar(new Car("Honda", "Accord", 330));
            HybridCarRepo.AddCar(new Car("Honda", "Accord Hybrid", 330));
            GasCarRepo.AddCar(new Car("Honda", "Pilot", 300));
            HybridCarRepo.AddCar(new Car("Honda", "Insight", 500));
            GasCarRepo.AddCar(new Car("Honda", "CR-V", 320));
            GasCarRepo.AddCar(new Car("Toyota", "Corolla", 360));
            HybridCarRepo.AddCar(new Car("Toyota", "Corolla Hybrid", 460));
            GasCarRepo.AddCar(new Car("Toyota", "Avalon", 360));
            HybridCarRepo.AddCar(new Car("Toyota", "Avalon Hybrid", 460));
            GasCarRepo.AddCar(new Car("Toyota", "Camry", 350));
            GasCarRepo.AddCar(new Car("Toyota", "RAV4", 330));
            GasCarRepo.AddCar(new Car("Toyota", "Highlander", 300));
            GasCarRepo.AddCar(new Car("Ford", "Fiesta", 390));
            GasCarRepo.AddCar(new Car("Ford", "Focus", 380));
            GasCarRepo.AddCar(new Car("Ford", "Fusion", 340));
            HybridCarRepo.AddCar(new Car("Ford", "Fusion Hybrid", 340));
            GasCarRepo.AddCar(new Car("Ford", "F-150", 280));
            GasCarRepo.AddCar(new Car("Ford", "F-250", 180));
            HybridCarRepo.AddCar(new Car("Kia", "Optima Hybrid", 330));
            ElectricCarRepo.AddCar(new Car("Nissan", "Leaf", 226));
            HybridCarRepo.AddCar(new Car("Toyota", "Prius", 730));
            ElectricCarRepo.AddCar(new Car("Tesla", "Model X", 300));
            ElectricCarRepo.AddCar(new Car("Tesla", "Model Y", 300));
            ElectricCarRepo.AddCar(new Car("Tesla", "Model S", 373));
            ElectricCarRepo.AddCar(new Car("Tesla", "Model 3", 300));
            ElectricCarRepo.AddCar(new Car("Mini", "Electric", 110));
            ElectricCarRepo.AddCar(new Car("Fiat", "500e", 84));
            ElectricCarRepo.AddCar(new Car("Kia", "Niro EV", 239));
            ElectricCarRepo.AddCar(new Car("BMW", "i3", 153));
            ElectricCarRepo.AddCar(new Car("Chevy", "Bolt", 238));
            ElectricCarRepo.AddCar(new Car("Hyundai", "Kona Electric", 258));
        }
        public void MainMenu()
        {
            bool isAcceptingInput = true;
            while (isAcceptingInput == true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add car.");
                Console.WriteLine("2. Update car.");
                Console.WriteLine("3. Delete car.");
                Console.WriteLine("4. View all car data.");
                Console.WriteLine("5. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        SubMenuAddCar();
                        break;
                    case "2":
                        SubMenuUpdateCar();
                        break;
                    case "3":
                        SubMenuDeleteCar();
                        break;
                    case "4":
                        SubMenuViewAllCars();
                        break;
                    case "5":
                        isAcceptingInput = false;
                        break;
                }
            }
        }
        public void SubMenuAddCar()
        {
            Console.Clear();
            Car newCar = new Car();

            Console.WriteLine("Enter car make:");
            newCar.Make = Console.ReadLine();

            Console.WriteLine("Enter car model:");
            newCar.Model = Console.ReadLine();

            Console.WriteLine("Enter the maximum mile range for car:");
            newCar.MaxMileRange = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Is the car powered by gas (G), electric (E) or a hybrid (H)?");
            string engineType = Console.ReadLine();

            switch (engineType)
            {
                case "G":
                    GasCarRepo.AddCar(newCar);
                    break;
                case "E":
                    ElectricCarRepo.AddCar(newCar);
                    break;
                case "H":
                    HybridCarRepo.AddCar(newCar);
                    break;
            }
        }
        public void SubMenuUpdateCar()
        {
            Console.Clear();
            Console.WriteLine("What model car do you want to update?");
            string model = Console.ReadLine();
            Console.WriteLine($"Is the {model} powered by gas (G), electric (E) or a hybrid (H)?");
            string engineType = Console.ReadLine();

            Car updatedCar = new Car();
            bool selectedValidEngine = true;

            switch (engineType)
            {
                case "G":
                    updatedCar = GasCarRepo.GetCarByModel(model); 
                    break;
                case "E":
                    updatedCar = ElectricCarRepo.GetCarByModel(model);
                    break;
                case "H":
                    updatedCar = HybridCarRepo.GetCarByModel(model);
                    break;
                default:
                    selectedValidEngine = false;
                    break;
            }

            if (selectedValidEngine == true)
            {
                //Console.WriteLine("Enter the model you want to update:");
                //string input = Console.ReadLine();

                bool isAcceptingInput = true;
                while (isAcceptingInput == true)
                {
                    Console.Clear();
                    Console.WriteLine($"Updating {updatedCar.Model}....What would you like to update?");
                    Console.WriteLine("1. Make");
                    Console.WriteLine("2. Model");
                    Console.WriteLine("3. Maximum Mile Range");
                    Console.WriteLine("4. Return to previous menu");
                    string updatedInput = Console.ReadLine();

                    switch (updatedInput)
                    {
                        case "1":
                            Console.WriteLine("Enter the updated make:");
                            string existingMake = updatedCar.Make;
                            updatedCar.Make = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Enter the updated model:");
                            string existingModel = updatedCar.Model;
                            updatedCar.Model = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Enter the updated maximum mile range:");
                            int existingMaxMileRange = updatedCar.MaxMileRange;
                            updatedCar.MaxMileRange = Int32.Parse(Console.ReadLine());
                            break;
                        case "4":
                            isAcceptingInput = false;
                            break;
                    }

                    if (isAcceptingInput == true)
                    {
                        switch (engineType)
                        {
                            case "G":
                                GasCarRepo.UpdateCar(model, updatedCar);
                                break;
                            case "E":
                                ElectricCarRepo.UpdateCar(model, updatedCar);
                                break;
                            case "H":
                                HybridCarRepo.UpdateCar(model, updatedCar);
                                break;
                        }
                    }
                }
            }
            
        }
        public void SubMenuDeleteCar()
        {
            Console.Clear();
            Console.WriteLine("Enter the model to delete:");
            string model = Console.ReadLine();
            Console.WriteLine($"Is the {model} powered by gas (G), electric (E) or a hybrid (H)?");
            string engineType = Console.ReadLine();
            
            Console.WriteLine($"Are you sure you want to delete {model})? Y or N:");
            string shouldDeleteCar = Console.ReadLine();

            if (shouldDeleteCar == "Y")
            {
                switch (engineType)
                {
                    case "G":
                        GasCarRepo.DeleteCar(model);
                        break;
                    case "E":
                        ElectricCarRepo.DeleteCar(model);
                        break;
                    case "H":
                        HybridCarRepo.DeleteCar(model);
                        break;
                }
                Console.WriteLine("Car has been deleted.");
                Console.Read();
            }
            else
            {
                SubMenuDeleteCar();
            }
            Console.WriteLine("");
        }
        public void SubMenuViewAllCars()
        {
            Console.Clear();
            Console.WriteLine("What would you like to view?");
            Console.WriteLine("1. All gas cars.");
            Console.WriteLine("2. All electric cars.");
            Console.WriteLine("3. All hybrid cars.");
            Console.WriteLine("4. All types of cars.");
            Console.WriteLine("5. Exit");
            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    Console.WriteLine("List of All Gas Cars");
                    Console.WriteLine("--------------------------------");
                    DisplayCarList(GasCarRepo.GetCars());
                    break;
                case "2":
                    Console.WriteLine("List of All Electric Cars");
                    Console.WriteLine("--------------------------------");
                    
                    break;
                case "3":
                    Console.WriteLine("List of All Hybrid Cars");
                    Console.WriteLine("--------------------------------");
                    DisplayCarList(HybridCarRepo.GetCars());
                    break;
                case "4":
                    Console.WriteLine("List of All Cars");
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("Gas Cars"); 
                    Console.WriteLine("--------------------------------");
                    DisplayCarList(GasCarRepo.GetCars());
                    Console.WriteLine("Electric Cars");
                    Console.WriteLine("--------------------------------");
                    DisplayCarList(ElectricCarRepo.GetCars());
                    Console.WriteLine("Hybrid Cars");
                    Console.WriteLine("--------------------------------");
                    DisplayCarList(HybridCarRepo.GetCars());
                    break;

            }
            Console.Read();
        }
        public void DisplayCarList(List<Car> carList)
        {
            foreach (Car currentCar in carList)
            {
                Console.WriteLine($"Make: {currentCar.Make}");
                Console.WriteLine($"Model: {currentCar.Model}");
                Console.WriteLine($"Maximum Mile Range: {currentCar.MaxMileRange}");
                Console.WriteLine("");
            }



        }
    }
}
