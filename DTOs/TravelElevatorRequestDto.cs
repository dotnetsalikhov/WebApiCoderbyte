using System.ComponentModel.DataAnnotations;

namespace WebApiCoderbyte.DTOs;

public class TravelElevatorRequestDto
{
    [Range(1, 34)]
    public int DestinationFloor { get; set; }
}
