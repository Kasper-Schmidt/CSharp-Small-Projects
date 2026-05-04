using CarApi.Models;

namespace CarApi.Services
{
    public class CarValidationService
    {
        public List<string> ValidateCar(Car car)
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(car.Brand))
            {
                errors.Add("Brand is required.");
            }

            if (string.IsNullOrWhiteSpace(car.Model))
            {
                errors.Add("Model is required.");
            }

            if (car.Year < 1900 || car.Year > DateTime.Now.Year + 1)
            {
                errors.Add("Year is not valid.");
            }

            if (string.IsNullOrWhiteSpace(car.Color))
            {
                errors.Add("Color is required.");
            }

            if (car.Mileage < 0 )
            {
                errors.Add("Mileage is not valid.");
            }

            if (car.HorsePower < 0)
            {
                errors.Add("Horsepower is not valid.");
            }

            return errors;
        }
    }
}
