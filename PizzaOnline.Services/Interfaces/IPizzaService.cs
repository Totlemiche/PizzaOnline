using PizzaOnline.Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOnline.Services.Interfaces
{
    public interface IPizzaService
    {
        Task<List<PizzasViewModels>> GetAllAsync();
    }
}
