using Microsoft.EntityFrameworkCore.Metadata.Internal;
using steam.Data;
using steam.Models.Interface;

namespace steam.Models.Services
{
    public class ContactRepository : IContactRepository
    {
        private SteamDBContext dbContext;

        public ContactRepository(SteamDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Send(Contact contact)
        {
            dbContext.contacts.Add(contact);
            dbContext.SaveChanges();
        }
    }
}
