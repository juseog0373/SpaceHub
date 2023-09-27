using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userIdSession
{
    internal class Session
    {

        private string userId = null;


        public Session(string userId)
        {

            this.userId = userId;
        }

        public string getUserId() { return userId; }
        public void setUserId(string s)
        {
            userId = s;
        }
    }
}