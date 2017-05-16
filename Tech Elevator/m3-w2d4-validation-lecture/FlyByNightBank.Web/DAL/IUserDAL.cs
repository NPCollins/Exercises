using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.Web.DAL
{
    public interface IUserDAL
    {
        bool SaveUser(User user);
        User LoginUser(string username, string password);
    }
}
