using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiCoderbyte.DTOs;
using WebApiCoderbyte.Interfaces;

namespace WebApiCoderbyte.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ElevatorController : ControllerBase
    {
        private readonly IElevatorRepository _repository;

        public ElevatorController(IElevatorRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("call")]
        public IActionResult CallElevator(CallElevatorRequestDto request)
        {
            if (request is null)
                return BadRequest(new
                {
                    statusCode = HttpStatusCode.BadRequest.GetHashCode(),
                    message = "Please provide current floor argument."
                });

            return Ok(new
            {
                statusCode = HttpStatusCode.OK.GetHashCode(),
                message = $"The elevator is headed to {request.CurrentFloor} floor."
            });
        }

        [HttpPost("travel")]
        public IActionResult TravelElevator(TravelElevatorRequestDto request)
        {
            if (request is null)
                return BadRequest(new
                {
                    statusCode = HttpStatusCode.BadRequest.GetHashCode(),
                    message = "Please provide destination floor argument."
                });

            return Ok(new
            {
                statusCode = HttpStatusCode.OK.GetHashCode(),
                message = $"The elevator is headed to {request.DestinationFloor} floor."
            });
        }


        [HttpGet("get-servicing-floors")]
        public IActionResult GetServicingFloorsElevator()
        {
            var allServicingFloors = _repository.GetAllServicingFloors();

            if (allServicingFloors is null)
                return NotFound();

            return Ok(allServicingFloors);
        }


        [HttpGet("get-next-floor")]
        public IActionResult GetNextFloorElevator()
        {
            var nextFloor = _repository.GetNextFloor();

            if (nextFloor is 0)
                return NotFound();

            return Ok(new { message = $"Elevator's next floor is {nextFloor}" });
        }
    }
}