using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appointment
{
    class Users
    {
     
        private string username;
        private string password;
        private string category;





        public Users(string username, string password, string category)
        {
            this.username = username;

            this.password = password;
            this.category = category;
            
            
             
        }
        public string getusername()
        {
            return this.username;
        }



        public string getpassword()
        {
            return this.password;
        }

        public string getcategory()
        {
            return this.category;
        }
         
    }
}
