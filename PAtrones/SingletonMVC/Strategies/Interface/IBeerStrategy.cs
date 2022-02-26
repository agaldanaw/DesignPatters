using DesignPatters.Repository;
using PatterDesigns.Models.ViewModels;

namespace PatterDesigns.Strategies.Interface
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfwork);
    }
}
