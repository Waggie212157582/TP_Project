using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.repository
{
    public class AuthorizerRepository
    {
        public void save(Authorizer authorizer)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(authorizer);
                    transaction.Commit();
                }
            }
        }

        public Authorizer findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<Authorizer>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new Authorizer();
            }
        }

        public void update(Authorizer authorizer)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(authorizer);
                    transaction.Commit();
                }
            }
        }

        public void remove(Authorizer authorizer)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(authorizer);
                    transaction.Commit();
                }
            }
        }
    }
}
