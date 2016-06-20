using System;
using System.Linq;

namespace EasyEnglish.Models {
    public interface IViRepository : IDisposable {
//        IQueryable<UserProfile> UserProfiles { get; }
        IQueryable<Card> Cards { get; }

        void SaveCard(Card card);
        Card DeleteCard(int cardId);
    }
}
