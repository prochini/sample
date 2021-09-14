
using sample.Interface;
using sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample.ViewModels
{
    public class UserDetails: Authentication
    {
       public MobiiUser MobiiUser { get; set; }

       public TbaseUserinfo TbaseUserinfo { get; set; }

        public TbaseUserprofile TbaseUserprofile { get; set; }

        public ICollection<TbaseUserfavourite1> TbaseUserfavourite1 { get; set; }
    }
}
