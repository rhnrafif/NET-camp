﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.TransactionDetailServices.Dto
{
    public class UpdateTransactionDetailDto
    {
        public int TransactionDetailId { get; set; }
        public int TransactionsId { get; set; }
        public int ProductsId { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
    }
}
