using WaiterAPP.Dto.WaitersDtos;

namespace WaiterAPP.Interfaces
{
    public interface IWaitersAuthService
    {
        Task<WaitersSignupDto> SignupAsync();

        Task<WaitersLoginDto> LoginAsync();

        Task LogoutAsync();
    }
}
