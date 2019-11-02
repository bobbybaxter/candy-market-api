using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyMarket.Api.DataModels
{
    public class UserCandy : Candy
    {
        public DateTime DateReceived { get; set; }
    }
}
