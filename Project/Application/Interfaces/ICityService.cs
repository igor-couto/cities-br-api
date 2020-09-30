using CitiesBR.Domain.Interfaces;

namespace CitiesBR.Application.Interfaces
{
    public interface ICityService
    {
        public IEntity GetAll();

        public IEntity GetCityByName(string name);

        public IEntity GetCityById(int id);

        public IEntity GetRandon();
    }
}