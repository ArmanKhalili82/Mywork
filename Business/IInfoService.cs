using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Models;

namespace Business;

public interface IInfoService
{
    Task<List<Info>> GetAll();
    Task<List<Info>> GetById(int id);
}
