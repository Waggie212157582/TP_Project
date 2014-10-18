using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.Repository
{
    public class PaymentDataRepository
    {
        public void save(PaymentData paymentData)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(paymentData);
                    transaction.Commit();
                }
            }
        }

        public PaymentData findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<PaymentData>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new PaymentData();
            }
        }

        public void update(PaymentData paymentData)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(paymentData);
                    transaction.Commit();
                }
            }
        }

        public void remove(PaymentData paymentData)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(paymentData);
                    transaction.Commit();
                }
            }
        }
    }
}
