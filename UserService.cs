using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalPoint
{
    public class UserService
    {

        public client AddClient(string name, string pasport, DateTime birth, string adress, string email)
        {
            var client = new client
            {
                fio = name,
                passport = pasport,
                birth = birth,
                adress = adress,
                email = email
            };

            using (RentalPointEntities entities = new RentalPointEntities())
            {
                entities.client.Add(client);
                entities.SaveChanges();
                AcountForm acount = new AcountForm();
                acount.dataGridView1.Update();
            }
            return client;
        }


    }
}
