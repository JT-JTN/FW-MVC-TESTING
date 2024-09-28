using FW.CoreBusiness;
using FW.WebApp.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UseCase.Plugins;
using UseCase.ViewModels.Client;

namespace FW.WebApp.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClientsByNameAsync(string search)
        {
            if (string.IsNullOrEmpty(search))
                return await _context.Clients.ToListAsync();

            return await _context.Clients.Where(c => c.FirstName.Contains(search) || c.LastName.Contains(search)).ToListAsync();
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public Task<Client> GetClientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<DetailsViewModel> GetClientByIdWithDetailsAsync(int id)
        {
            if (id <= 0)
                return null!;

            var client = await _context.Clients
                .Include(c => c.Vehicles)
                .ThenInclude(v => v.AppColor)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (client == null)
                return null!;
            var vehicleColor = await _context.AppColors.FindAsync(client.Vehicles?.FirstOrDefault()?.Color);
            var createdByEmail = await _context.Users.FindAsync(client.CreatedBy);
            var updatedByEmail = await _context.Users.FindAsync(client.UpdatedBy);

            var detailsViewModel = new DetailsViewModel
            {
                Client = client,
                CreatedByEmail = createdByEmail?.ToString() ?? string.Empty,
                UpdateByEmail = updatedByEmail?.ToString() ?? string.Empty,
                Color = vehicleColor!
            };

            return detailsViewModel;
        }
    }
}
