using OA.Data;
using OA.REPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAService
{
    public class UserProfileService : IUserProfileService
    {
       
        private readonly IRepository<UserProfile> userProfileRepository;


        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
           
            this.userProfileRepository = userProfileRepository;

        }

        public UserProfile GetUserProfile(long id)
        {
            return userProfileRepository.Get(id);
        }

       
    }
}
