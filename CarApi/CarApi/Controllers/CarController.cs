using CarApi.Models;
using CarApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly CarService _carService;
        private readonly CarValidationService _validateService;

        public CarController(CarService carService, CarValidationService validationService)
        {
            _carService = carService;
            _validateService = validationService;
        }


   


        [HttpGet]
        public ActionResult<List<Car>> GetAllCars()
        {
            return Ok(_carService.GetAllCars());
        }



        [HttpGet("{id}")]
        public ActionResult<Car> GetCarById(int id)
        {
            Car car = _carService.GetCarById(id);
        
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found.");
            }

            return Ok(car);
        }


        [HttpGet("brand/{brand}")]
        public ActionResult<List<Car>> GetCarsByBrand(string brand)
        {
            return Ok(_carService.GetCarsByBrand(brand));
        }


        [HttpPost]
        public ActionResult<Car> AddCar(Car newCar)
        {
            List<string> validationErrors = _validateService.ValidateCar(newCar);

            if (validationErrors.Count > 0)
            {
                return BadRequest(validationErrors);
            }

            Car createdCar = _carService.AddCar(newCar);

            return CreatedAtAction(nameof(GetCarById), new { id = newCar.Id }, newCar);
        }


        [HttpPut("{id}")]
        public ActionResult<Car> UpdateCar(int id, Car updatedCar)
        {
            List<string> validationErrors = _validateService.ValidateCar(updatedCar);

            if (validationErrors.Count > 0)
            {
                return BadRequest(validationErrors);
            }

            Car car = _carService.UpdateCar(id, updatedCar);

            if (car == null)
            {
                return NotFound($"Car with ID {id} not found.");
            }

            return Ok(car);
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id)
        {
            bool deleted = _carService.DeleteCar(id);

            if (!deleted)
            {
                return NotFound($"Car with ID {id} not found.");
            }

            return NoContent();
        }
    }
}
