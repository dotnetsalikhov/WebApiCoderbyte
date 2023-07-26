using System.ComponentModel.DataAnnotations;

namespace WebApiCoderbyte.DTOs;

public class CallElevatorRequestDto
{
    [Range(1, 34)]
    public int CurrentFloor { get; set; }
}
