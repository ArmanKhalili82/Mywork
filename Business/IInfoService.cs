using Models.Models;

namespace Business;

public interface IInfoService
{
    Task<List<Info>> GetAll();
    Task<List<Info>> GetById(int id);
}
