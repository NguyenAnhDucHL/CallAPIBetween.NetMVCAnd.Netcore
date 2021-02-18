using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebB.Service
{
    public class Home
    {


        public void Demo()
        {
            IHomeService homeService = new PeopleService();
            homeService.Action();
            homeService.Feeee();
            homeService.Demoooo();
        }

    }
}
