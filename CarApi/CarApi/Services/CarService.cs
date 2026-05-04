using CarApi.Models;

namespace CarApi.Services
{
    public class CarService
    {
        public static List<Car> cars = new List<Car>
        {
            new Car { Id = 1, Brand = "Lamborghini", Model = "Huracan", Year = 2014, Color = "Green", Mileage = 88000, HorsePower = 610, IsAvailable = true },
            new Car { Id = 2, Brand = "Lamborghini", Model = "Aventador", Year = 2016, Color = "Blue", Mileage = 23000, HorsePower = 700, IsAvailable = true },
            new Car { Id = 3, Brand = "Lamborghini", Model = "Gallardo", Year = 2008, Color = "Yellow", Mileage = 124000, HorsePower = 520, IsAvailable = true },
            new Car { Id = 4, Brand = "Lamborghini", Model = "Murcielago", Year = 2006, Color = "Orange", Mileage = 5800, HorsePower = 580, IsAvailable = false },
            new Car { Id = 5, Brand = "Lamborghini", Model = "Urus", Year = 2020, Color = "Black", Mileage = 17000, HorsePower = 650, IsAvailable = true },

            new Car { Id = 6, Brand = "Ferrari", Model = "Testarossa", Year = 1989, Color = "Red", Mileage = 42000, HorsePower = 390, IsAvailable = true },
            new Car { Id = 7, Brand = "Ferrari", Model = "458", Year = 2012, Color = "Red", Mileage = 36000, HorsePower = 570, IsAvailable = true },
            new Car { Id = 8, Brand = "Ferrari", Model = "488", Year = 2017, Color = "White", Mileage = 28000, HorsePower = 670, IsAvailable = true },
            new Car { Id = 9, Brand = "Ferrari", Model = "LaFerrari", Year = 2015, Color = "Red", Mileage = 4500, HorsePower = 963, IsAvailable = false },
            new Car { Id = 10, Brand = "Ferrari", Model = "296", Year = 2023, Color = "Yellow", Mileage = 3200, HorsePower = 830, IsAvailable = true },
            new Car { Id = 11, Brand = "Ferrari", Model = "SF90", Year = 2022, Color = "Black", Mileage = 6500, HorsePower = 1000, IsAvailable = true },

            new Car { Id = 12, Brand = "Porsche", Model = "911 Turbo S", Year = 2021, Color = "Silver", Mileage = 12000, HorsePower = 650, IsAvailable = false },
            new Car { Id = 13, Brand = "Porsche", Model = "GT3 RS", Year = 2023, Color = "White", Mileage = 3500, HorsePower = 525, IsAvailable = true },
            new Car { Id = 14, Brand = "Porsche", Model = "Taycan Turbo S", Year = 2022, Color = "Blue", Mileage = 18000, HorsePower = 761, IsAvailable = true },
            new Car { Id = 15, Brand = "Porsche", Model = "Cayenne Turbo GT", Year = 2022, Color = "Black", Mileage = 22000, HorsePower = 640, IsAvailable = true },

            new Car { Id = 16, Brand = "Aston Martin", Model = "DB11", Year = 2019, Color = "Green", Mileage = 26000, HorsePower = 608, IsAvailable = true },
            new Car { Id = 17, Brand = "Aston Martin", Model = "Vantage", Year = 2021, Color = "Grey", Mileage = 14000, HorsePower = 510, IsAvailable = true },
            new Car { Id = 18, Brand = "Aston Martin", Model = "DBS Superleggera", Year = 2020, Color = "Black", Mileage = 11000, HorsePower = 725, IsAvailable = false },
            new Car { Id = 19, Brand = "Aston Martin", Model = "Valkyrie", Year = 2023, Color = "Red", Mileage = 900, HorsePower = 1160, IsAvailable = false },

            new Car { Id = 20, Brand = "McLaren", Model = "720S", Year = 2018, Color = "Orange", Mileage = 19000, HorsePower = 720, IsAvailable = true },
            new Car { Id = 21, Brand = "McLaren", Model = "Artura", Year = 2023, Color = "Green", Mileage = 2500, HorsePower = 680, IsAvailable = true },
            new Car { Id = 22, Brand = "McLaren", Model = "P1", Year = 2015, Color = "Yellow", Mileage = 5200, HorsePower = 916, IsAvailable = false },
            new Car { Id = 23, Brand = "McLaren", Model = "765LT", Year = 2021, Color = "Blue", Mileage = 8000, HorsePower = 765, IsAvailable = true }
        };

        public List<Car> GetAllCars()
        {
            return cars;
        }


        public Car GetCarById(int id)
        {
            return cars.FirstOrDefault(car => car.Id == id);
        }


        public List<Car> GetCarsByBrand(string brand)
        {
            return cars
                .Where(car => car.Brand.ToLower() == brand.ToLower())
                .ToList();
        }


        public Car AddCar(Car newCar)
        {
            int nextId = cars.Max(car => car.Id) + 1;

            newCar.Id = nextId;
            cars.Add(newCar);

            return newCar;
        }


        public Car UpdateCar(int id, Car updatedCar)
        {
            Car car = GetCarById(id);

            if (car == null)
            {
                return null;
            }

            car.Brand = updatedCar.Brand;
            car.Model = updatedCar.Model;
            car.Year = updatedCar.Year;
            car.Color = updatedCar.Color;
            car.Mileage = updatedCar.Mileage;
            car.HorsePower = updatedCar.HorsePower;
            car.IsAvailable = updatedCar.IsAvailable;

            return car;
        }


        public bool DeleteCar(int id)
        {
            Car car = GetCarById(id);

            if (car == null)
            {
                return false;
            }

            cars.Remove(car);

            return true;
        }
    }
}
