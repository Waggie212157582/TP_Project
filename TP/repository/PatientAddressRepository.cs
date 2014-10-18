using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using TP.Domain;

namespace TP.Repository
{
    public class PatientAddressRepository
    {
        public void save(PatientAddress patientaddress)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(patientaddress);
                    transaction.Commit();
                }
            }
        }

        public PatientAddress findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<PatientAddress>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new PatientAddress();
            }
        }

        public void update(PatientAddress patientaddress)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(patientaddress);
                    transaction.Commit();
                }
            }
        }

        public void remove(PatientAddress patientaddress)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(patientaddress);
                    transaction.Commit();
                }
            }
        }

    }
}
