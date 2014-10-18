using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.Repository
{
    public class PaymentRepository
    {
        public void save(Payment payment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(payment);
                    transaction.Commit();
                }
            }
        }

        public Payment findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<Payment>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new Payment();
            }
        }

        public void update(Payment payment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(payment);
                    transaction.Commit();
                }
            }
        }

        public void remove(Payment payment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(payment);
                    transaction.Commit();
                }
            }
        }
    }
}
