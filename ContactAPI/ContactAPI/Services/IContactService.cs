
using ContactAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactAPI.Services
{
    public interface IContactService
    {

        Task<List<ContactDto>> GetAllContactsAsync(int pageNumber, int pageSize, string sortBy, string sortOrder, string? searchQuery);


        Task<ContactDto> GetContactByIdAsync(int id);
        Task<ContactDto> AddContactAsync(CreateContactDto contactDto);
        Task<ContactDto> UpdateContactAsync(int id, UpdateContactDto contactDto);
        Task<bool> DeleteContactAsync(int id);
        Task<ContactDto> PatchContactAsync(int id, PatchContactDto patchDto);
        Task<bool> MobileNumberExistsAsync(string mobileNumber);
        Task<bool> EmailExistsAsync(string email);
    }
}
