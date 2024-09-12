using AutoMapper;
using ContactAPI.DbContexts;

using ContactAPI.Entitties;
using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;

namespace ContactAPI.Services
{
    public class ContactService : IContactService
    {
        private readonly ContactsContext _context;
        private readonly IMapper _mapper;

        public ContactService(ContactsContext context, IMapper mapper)
        {
            _context = context?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<bool> MobileNumberExistsAsync(string mobileNumber)
        {
            return await _context.Contacts.AnyAsync(c => c.MobileNumber == mobileNumber);
        }

        // Check if an email already exists in the database
        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.Contacts.AnyAsync(c => c.Email == email);
        }
        
           public async Task<List<ContactDto>> GetAllContactsAsync(int pageNumber, int pageSize, string sortBy, string sortOrder, string? searchQuery)
        {
            IQueryable<Contact> query = _context.Contacts;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                // Assuming you want to search by name or mobile number
                query = query.Where(c => c.Name.ToLower().Contains(searchQuery.ToLower()) ||
                                         c.MobileNumber.Contains(searchQuery));
            }

            // Apply sorting

            if (sortBy.ToLower() == "name")
            {
                query = sortOrder.ToLower() == "asc"
                    ? query.OrderBy(c => c.Name.ToLower())
                    : query.OrderByDescending(c => c.Name.ToLower());
            }
            else if (sortBy.ToLower() == "number")
            {
                query = sortOrder.ToLower() == "asc"
                    ? query.OrderBy(c => c.MobileNumber)
                    : query.OrderByDescending(c => c.MobileNumber);
            }

            
            var contacts = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

           

            var contactDtos = _mapper.Map<List<ContactDto>>(contacts);

            return contactDtos;
        }


        public async Task<ContactDto> GetContactByIdAsync(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            return _mapper.Map<ContactDto>(contact);
        }

        public async Task<ContactDto> AddContactAsync(CreateContactDto contactDto)
        {
            
            var contact = _mapper.Map<Contact>(contactDto);
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return _mapper.Map<ContactDto>(contact);
        }

        public async Task<ContactDto> UpdateContactAsync(int id, UpdateContactDto contactDto)
        {
            var existingContact = await _context.Contacts.FindAsync(id);
            if (existingContact == null)
            {
                return null;
            }
      
            _mapper.Map(contactDto, existingContact);
            await _context.SaveChangesAsync();
            return _mapper.Map<ContactDto>(existingContact);
        }

        public async Task<bool> DeleteContactAsync(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return false;
            }

            _context.Contacts.Remove(contact);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<ContactDto> PatchContactAsync(int id, PatchContactDto patchDto)
        {
            var existingContact = await _context.Contacts.FindAsync(id);
            if (existingContact == null)
            {
                return null;
            }

            _mapper.Map(patchDto, existingContact);
            await _context.SaveChangesAsync();
            return _mapper.Map<ContactDto>(existingContact);
        }
    }
}
