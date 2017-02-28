using System.Web;

namespace AppleBrainsSite.Services
{
    public interface IUploadsService
    {
        string Upload(HttpPostedFile file);
    }
}