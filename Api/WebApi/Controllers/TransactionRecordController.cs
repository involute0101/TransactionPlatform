﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;


namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionRecordController : ControllerBase
    {
        private readonly TranscationContext transactionContext;

        public TransactionRecordController(TranscationContext context)
        {
            transactionContext = context;
        }

        //记录交易成功的商品
        [HttpPost("addTransactionRecord")]
        public ActionResult<TransactionRecord> AddDoneDeal([FromBody] Object body)
        {
            TransactionRecord record = JsonConvert.DeserializeObject<TransactionRecord>(body.ToString());
            try
            {
                transactionContext.TransactionRecords.Add(record);
                transactionContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return record;
        }


        //买家用户Id查询所有的交易成功商品
        [HttpPost("getTransactionRecordByBuyer")]
        public ActionResult<List<Good>> GetDoneDealByBuyer(int buyerId)
        {

            List<TransactionRecord> records = transactionContext.TransactionRecords.Where(t => t.BuyerId == buyerId).ToList();
            List<Good> goods = new List<Good>();
            records.ForEach(record => goods.Add(transactionContext.Goods.SingleOrDefault(g => g.GoodId == record.GoodId)));
            if (goods == null)
                return NotFound();
            else
                return goods.ToList();
        }

        //卖家用户Id查询所有的交易成功商品
        [HttpPost("getTransactionRecordBySaler")]
        public ActionResult<List<Good>> GetDoneDealBySaler(int salerId)
        {

            List<TransactionRecord> records = transactionContext.TransactionRecords.Where(t => t.SalerId == salerId).ToList();
            List<Good> goods = new List<Good>();
            records.ForEach(record => goods.Add(transactionContext.Goods.SingleOrDefault(g => g.GoodId == record.GoodId)));
            if (goods == null)
                return NotFound();
            else
                return goods.ToList();
        }
    }
}