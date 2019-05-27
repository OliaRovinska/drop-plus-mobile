using System.IO;
using System.Threading.Tasks;

namespace DropPlus.Interfaces
{
    public interface IPicturePicker
    {
        Task<Stream> GetImageStreamAsync();
    }
}