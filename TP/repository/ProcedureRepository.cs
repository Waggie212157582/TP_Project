using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using TP.Domain;

namespace TP.Repository
{
    public class ProcedureRepository
    {
        public void save(Procedures procedure)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(procedure);
                    transaction.Commit();
                }
            }
        }

        public Procedures findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<Procedures>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new Procedures();
            }
        }

        public void update(Procedures procedures)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(procedures);
                    transaction.Commit();
                }
            }
        }

        public void remove(Procedures procedures)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(procedures);
                    transaction.Commit();
                }
            }
        }
    }
}
