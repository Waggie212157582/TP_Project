using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.Repository
{
    public class AppointmentRepository
    {
        public void save(Appointment appointment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(appointment);
                    transaction.Commit();
                }
            }
        }

        public Appointment findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<Appointment>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new Appointment();
            }
        }

        public void update(Appointment appointment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(appointment);
                    transaction.Commit();
                }
            }
        }

        public void remove(Appointment appointment)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(appointment);
                    transaction.Commit();
                }
            }
        }
    }
}
