using Monefy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monefy.Services.FileServices
{
    // For saving User

    public interface IFileService
    {
        User LoadUserInformation(string filename);

        void SaveUserInformation(string filename, User user);

    }
}
