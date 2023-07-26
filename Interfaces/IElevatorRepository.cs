using WebApiCoderbyte.DTOs;

namespace WebApiCoderbyte.Interfaces
{
    public interface IElevatorRepository
    {
        ServicingFloorsResponseDto GetAllServicingFloors();

        int GetNextFloor();
    }
}