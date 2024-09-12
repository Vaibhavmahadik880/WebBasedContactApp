using AutoMapper;
using ContactAPI.DbContexts;
using ContactAPI.Entitties;
using ContactAPI.Helpers;
using ContactAPI.Models;
using ContactAPI.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;
        private readonly ContactsContext _context;

        public ContactsController(IContactService contactService, IMapper mapper, ContactsContext context)
        {
            _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public async Task<ActionResult<PagedResult<ContactDto>>> GetContacts(
              [FromQuery] int pageNumber = 1,
              [FromQuery] int pageSize = 10,
              [FromQuery] string sortBy = "name",
              [FromQuery] string sortOrder = "asc",
              [FromQuery] string? searchQuery = null
           )
        {
            var contacts = await _contactService.GetAllContactsAsync(pageNumber, pageSize, sortBy, sortOrder, searchQuery);

            // Apply the same filtering logic as in GetAllContactsAsync
            IQueryable<Contact> query = _context.Contacts;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                searchQuery = searchQuery.ToLower();
                query = query.Where(c => c.Name.ToLower().Contains(searchQuery) ||
                                         c.MobileNumber.Contains(searchQuery));
            }

            var totalCount = await query.CountAsync();

            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            var pagedResult = new PagedResult<ContactDto>
            {
                Contacts = contacts,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalPages = totalPages
            };

            return Ok(pagedResult);
        }



        // GET: api/contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDto>> GetContact(int id)
        {
            var contact = await _contactService.GetContactByIdAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        // POST: api/contacts
        [HttpPost]
        public async Task<ActionResult<ContactDto>> PostContact(CreateContactDto createContactDto)
        {
            var contact = await _contactService.AddContactAsync(createContactDto);
            return CreatedAtAction(nameof(GetContact), new { id = contact.Id }, contact);
        }

        // PUT: api/contacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, UpdateContactDto updateContactDto)
        {
            var contact = await _contactService.UpdateContactAsync(id, updateContactDto);
            if (contact == null)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var result = await _contactService.DeleteContactAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
};

