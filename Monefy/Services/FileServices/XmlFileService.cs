using Monefy.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Monefy.Services.FileServices
{
    class XmlFileService : IFileService
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));


        public User LoadUserInformation(string filename)
        {
            User user = new User();

            using (var ser = new StreamReader(filename))
            {
                user = (User)xmlSerializer.Deserialize(ser);
            }

            return user;
        }

        public void SaveUserInformation(string filename, User user)
        {
            using (var ser = new StreamWriter(filename))
            {
                xmlSerializer.Serialize(ser, user);
            }
        }
    }
}
