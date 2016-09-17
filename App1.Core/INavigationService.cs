using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.Core
{
    public interface INavigationService
    {
        Task PushPageAsync(object pageKey);

        Task PopToRootPageAsync();

        INavigation Navigation { get; set; }
    }
}
