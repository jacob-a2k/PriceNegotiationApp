using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PriceNegotiationApp.Data;
using PriceNegotiationApp.Entities;

namespace PriceNegotiationApp.Services
{
    public class NegotiationService(NegotiationDbContext dbContext): ControllerBase
    {
        private readonly NegotiationDbContext _dbContext = dbContext;

        
    }
}
