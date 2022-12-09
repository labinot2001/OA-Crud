using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAService
{
    public interface IUserProfileService
    {

        UserProfile GetUserProfile(long id);



    }
}
