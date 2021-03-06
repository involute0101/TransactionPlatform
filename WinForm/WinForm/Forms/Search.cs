using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WinForm.EntityClass;

namespace WinForm.Forms
{
    class Search
    {
        static public List<TransactionRecord> SearchRecordByGoodName(List<TransactionRecord> transactionRecords, string goodName)
        {
            List<TransactionRecord> results = new List<TransactionRecord>();
            foreach (TransactionRecord tr in transactionRecords)
            {
                if (Regex.IsMatch(tr.GoodName, goodName))
                    results.Add(tr);
            }
            return results;
        }

        static public List<TransactionRecord> SearchRecordByGoodId(List<TransactionRecord> transactionRecords, int goodId)
        {
            List<TransactionRecord> results = new List<TransactionRecord>();
            foreach (TransactionRecord tr in transactionRecords)
            {
                if (tr.GoodId == goodId)
                    results.Add(tr);
            }
            return results;
        }
        static public List<TransactionRecord> SearchRecordBySalerName(List<TransactionRecord> transactionRecords, string SalerName)
        {
            List<TransactionRecord> results = new List<TransactionRecord>();
            foreach (TransactionRecord tr in transactionRecords)
            {
                if (Regex.IsMatch(tr.SalerName, SalerName))
                    results.Add(tr);
            }
            return results;
        }
        static public List<Good> SearchGoodByGoodName(List<Good> goods, string goodName)
        {
            List<Good> results = new List<Good>();

            foreach (Good good in goods)
            {
                if (Regex.IsMatch(good.GoodName, goodName))
                    results.Add(good);
            }
            return results;
        }
        static public List<Good> SearchGoodByGoodState(List<Good> goods, string goodState)
        {
            List<Good> results = new List<Good>();
            foreach (Good good in goods)
            {
                if (good.State == goodState)
                    results.Add(good);
            }
            return results;
        }
        static public List<Good> SearchGoodBySalerName(List<Good> goods, string salerName)
        {
            List<Good> results = new List<Good>();

            foreach (Good good in goods)
            {
                if (Regex.IsMatch(good.SellerName, salerName))
                    results.Add(good);
            }
            return results;
        }
    }
}