﻿using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public class PremiumCustomer : GetCustomerType
    {
        public override double CustomerDiscount()
        {
            return ((double)(100 - CustomerDiscountType.discountpremium)) / 100;
        }
    }
}
