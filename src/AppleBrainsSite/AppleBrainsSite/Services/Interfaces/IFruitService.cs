using AppleBrainsSite.Domain;
using AppleBrainsSite.Models.Requests;
using System.Collections.Generic;

namespace AppleBrainsSite.Services
{
    public interface IFruitService
    {
        int Create(FruitCreateRequest model);

        List<Fruit> GetAll();
    }
}