using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP.Domain;
using NHibernate;

namespace TP.Repository
{
    public class TerminalUserRepository
    {
        public void save(TerminalUser terminalUser)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(terminalUser);
                    transaction.Commit();
                }
            }
        }

        public TerminalUser findById(long id)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                var result = session.QueryOver<TerminalUser>().Where(x => x.id == id).SingleOrDefault();
                if (result == null)
                    return null;
                else
                    return result ?? new TerminalUser();
            }
        }

        public void update(TerminalUser terminalUser)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(terminalUser);
                    transaction.Commit();
                }
            }
        }

        public void remove(TerminalUser terminalUser)
        {
            using (ISession session = NHibernateHelper.openSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(terminalUser);
                    transaction.Commit();
                }
            }
        }
    }
}
