using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.Repository
{
    public class PatientRepository
    {
        public void save(Patient patient)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(patient);
                    transaction.Commit();
                }
            }
        }

        public Patient findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<Patient>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new Patient();
            }
        }

        public void update(Patient patient)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(patient);
                    transaction.Commit();
                }
            }
        }

        public void remove(Patient patient)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(patient);
                    transaction.Commit();
                }
            }
        }
    }
}
