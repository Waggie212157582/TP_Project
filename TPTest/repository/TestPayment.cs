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
    public class TestPayment
    {
        long id;
        PaymentRepository repo = new PaymentRepository();
        [TestMethod]
        public void TestAllPayment()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadPaymentConfig();
            Payment payment = new Payment();
            payment.payAddress = "Somewhere in the world";
            payment.payIdNumber = 7896541230;
            payment.payName = "Kobus";
            payment.payOccupation = "C# Developer";
            payment.payRelationship = "Not related";
            payment.paySurname = "Burger";
            payment.payTelNo = "(021) 988 5555";
            payment.payTelNoWork = "(021) 966 333";

            repo.save(payment);
            id = payment.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            Payment payment = repo.findById(id);
            Assert.AreEqual("Burger", payment.paySurname);
        }

        public void testUpdate()
        {
            Payment payment = repo.findById(id);
            payment.payOccupation = "Java Developer";
            repo.update(payment);

            Payment updatedPayment = repo.findById(id);
            Assert.AreEqual("Java Developer", updatedPayment.payOccupation);
        }

        public void testRemove()
        {
            Payment payment = repo.findById(id);
            repo.remove(payment);

            Payment deletedPayment = repo.findById(id);
            Assert.IsNull(deletedPayment);
        }
    }
}
