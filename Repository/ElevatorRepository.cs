using WebApiCoderbyte.DTOs;
using WebApiCoderbyte.Interfaces;

namespace WebApiCoderbyte.Repository
{
    public class ElevatorRepository : IElevatorRepository
    {
        public ServicingFloorsResponseDto GetAllServicingFloors()
        {
            var random = new Random();
            var servicingFloors = Enumerable.Range(1, 34)
                                  .OrderBy(x => random.Next())
                                  .Take(6)
                                  .ToList();

            return new ServicingFloorsResponseDto { CurrentServicingFloors = servicingFloors };
        }

        public int GetNextFloor()
        {
            var random = new Random();

            return Enumerable.Range(1, 34)
                                   .OrderBy(x => random.Next())
                                   .Take(1)
                                   .FirstOrDefault();
        }
    }
}
