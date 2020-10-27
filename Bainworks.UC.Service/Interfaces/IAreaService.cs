using Brainworks.UC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.UC.Services
{
    public interface IAreaService
    {
        IEnumerable<Area> GetAllAreas();
        Area GetById(int id);
        Area GetByCity (string city);
        int AddAreas(Area area);


    }
}
