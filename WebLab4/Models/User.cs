using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLab4.Models
{
    public class User
    {
        public PrivateUserInfo PrivateUserInfoModel { get; set; }
        public UserInfo UserInfoModel { get; set; }
    }
}
