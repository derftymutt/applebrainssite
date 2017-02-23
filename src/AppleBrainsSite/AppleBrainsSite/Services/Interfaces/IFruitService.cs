using AppleBrainsSite.Models.Requests;

namespace AppleBrainsSite.Services
{
    public interface IFruitService
    {
        int Create(FruitCreateRequest model);
    }
}