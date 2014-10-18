using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP.Repository;
using TP.Config;
using TP.Domain;

namespace TPTest.Repository
{
    [TestClass]
    public class TestPaymentData
    {
        long id;
        PaymentDataRepository repo = new PaymentDataRepository();
        [TestMethod]
        public void TestAllPaymentData()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadPaymentDataConfig();
            PaymentData paymentData = new PaymentData();
            paymentData.numberOfProcedures = 3;
            paymentData.paymentDate = DateTime.Today.ToLongDateString();
            paymentData.paymentTime = DateTime.Now.ToLongTimeString();
            paymentData.tax = 0.14;
            paymentData.total = 999999.99;
            paymentData.changes = 999999.99;

            repo.save(paymentData);
            id = paymentData.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            PaymentData paymentData = repo.findById(id);
            Assert.AreEqual(3, paymentData.numberOfProcedures);
        }

        public void testUpdate()
        {
            PaymentData paymentData = repo.findById(id);
            paymentData.numberOfProcedures = 5;
            repo.update(paymentData);

            PaymentData updatedData = repo.findById(id);
            Assert.AreEqual(5, paymentData.numberOfProcedures);
        }

        public void testRemove()
        {
            PaymentData paymentData = repo.findById(id);
            repo.remove(paymentData);

            PaymentData deletedData = repo.findById(id);
            Assert.IsNull(deletedData);
        }
    }
}
