﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class TransactionRecord
    {
        public int TransactionRecordId { get; set; }

        public int GoodId { get; set; }//商品

        public int BuyerId { get; set; }//买家

        public DateTime Time { get; set; }//完成交易时间
    }
}