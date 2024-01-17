using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models;

public class InfoDetails
{
    public int Id { get; set; }
    public Info Info { get; set; }
    public string Title { get; set; }
}
