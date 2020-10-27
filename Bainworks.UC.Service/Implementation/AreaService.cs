using Brainworks.UC.Data;
using System.Collections.Generic;
using Brainworks.UC.Persistance;


namespace Brainworks.UC.Services
{
    public class AreaService : IAreaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AreaService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<Area> GetAllAreas()
        {
            return this._unitOfWork.AreaRepository.GetAll();

        }
        public Area GetById(int Id)
        {
            return this._unitOfWork.AreaRepository.GetById(Id);

        }
        public Area GetByCity(string city)
        {
            return this._unitOfWork.AreaRepository.FirstOrDefault(x => x.City == city);
        }
        public int AddAreas(Area area)
        {
            this._unitOfWork.AreaRepository.Add(area);
            this._unitOfWork.Save();
            return area.Id;

            //context.customers.Add(customer);
            //context.SaveChanges();
        }
    }

}
