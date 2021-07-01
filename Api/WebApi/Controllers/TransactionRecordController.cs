using Microsoft.AspNetCore.Mvc;
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

        /// <summary>
        /// 买家用户Id查询所有的交易记录
        /// </summary>
        /// <param name="buyerId"></param>
        /// <returns></returns>
        [HttpGet("getTransactionRecordByBuyerId")]
        public ActionResult<List<TransactionRecord>> GetDoneDealByBuyerId(int buyerId)
        {
            List<TransactionRecord> records = transactionContext.TransactionRecords.Where(t => t.BuyerId == buyerId).ToList();
            if (records == null)return NotFound();
            return records;
        }

        /// <summary>
        /// 根据用户id查询交易记录（买方或卖方）
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("getTransactionRecordByUserId")]
        public ActionResult<List<TransactionRecord>> GetTransactionRecordByUserId(int userId)
        {
            List<TransactionRecord> records = transactionContext.TransactionRecords.
                Where(t => t.BuyerId == userId || t.SalerId == userId).ToList();
            if (records == null) return NotFound();
            return records;
        }

        /// <summary>
        /// 卖家用户Id查询所有的交易成功商品
        /// </summary>
        /// <param name="salerId"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 根据交易记录ID查询
        /// </summary>
        /// <param name="tranId"></param>
        /// <returns></returns>
        [HttpGet("getTransactionById")]
        public ActionResult<TransactionRecord> GetTransactionRecordById(int tranId)
        {
            try
            {
                TransactionRecord record = transactionContext.TransactionRecords.
                    Where(t => t.TransactionRecordId == tranId).ToList().First();
                if (record == null) return NoContent();
                return record;
            }catch(Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
            
        }
    }
}
