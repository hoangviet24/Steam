using SteamNextGen.Data;
using SteamNextGen.Models.Interface;

namespace SteamNextGen.Models.Services
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
            dbContext.contact.Add(contact);
            dbContext.SaveChanges();
        }
    }
}
