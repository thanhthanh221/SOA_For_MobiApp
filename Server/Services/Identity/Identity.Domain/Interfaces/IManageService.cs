using Identity.Domain.Model;
using Identity.Domain.Services;
using Identity.Domain.ViewModel.Manage;

namespace Identity.Domain.Interfaces
{
    public interface IManageService
    {
        Task<ApplicationUser> GetUserInfomation(Guid userId);
        Task<ResponseClient> ChangeEmailAsync(ChangeEmailViewModel changeEmail);
        Task<ResponseClient> EditProfileAsync(EditExtraProfileViewModel editExtraProfile);
        Task<ResponseClient> AddPhoneNumberService(AddPhoneNumberViewModel phoneNumberViewModel);
        Task<ResponseClient> VerifyPhoneNumberService(VerifyPhoneNumberViewModel verifyPhoneNumber);    
    }
}
