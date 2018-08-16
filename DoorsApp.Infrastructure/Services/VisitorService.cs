using DoorsApp.Core.Domain;
using DoorsApp.Core.Helpers;
using DoorsApp.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DoorsApp.Infrastructure.Services
{
    public class VisitorService : IVisitorService
    {
        private readonly IDoorService _doorService;
        private readonly List<Door> _doorList;

        public VisitorService(IDoorService doorService)
        {
            _doorService = doorService;
            _doorList = Enumerable.Range(0, 100).Select(d => new Door()).ToList();
        }

        public string VisitDoors()
        {
            for (var tour = 1; tour < 101; tour++)
            {
                for (var index = tour - 1; index < 100; index += tour)
                    _doorService.ToggleDoorState(_doorList[index]);
            }

            return string.Join("", _doorList.Select(p => p.DoorState.GetDescription()));
        }
    }
}
