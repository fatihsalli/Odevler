﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public class DiamondUser : GetUserType
    {
        public override string UserDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
