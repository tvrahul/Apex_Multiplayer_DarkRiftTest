using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Models
{
    public class Users
    {
        public long UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public decimal Balance { get; set; }

        public string Token { get; set; }
    }

}