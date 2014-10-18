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
    public class TestTerminalUser
    {
        long id;
        TerminalUserRepository repo = new TerminalUserRepository();
        [TestMethod]
        public void TestAllTerminalUser()
        {
            testCreate();
            testRead();
            testUpdate();
            testDelete();
        }

        public void testCreate()
        {
            ConnectionConfig.loadPatientAddressConfig();
            TerminalUser user = new TerminalUser();
            user.userName = "qwerty";
            user.password = "789456123";
            user.secQuestion = "What is your cat's name";
            user.secAnswer = "Fluffy";

            repo.save(user);
            id = user.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            TerminalUser user = repo.findById(id);
            Assert.AreEqual("qwerty", user.userName);
        }

        public void testUpdate()
        {
            TerminalUser user = repo.findById(id);
            user.password = "keyboard";
            repo.update(user);

            TerminalUser updateUser = repo.findById(id);
            Assert.AreEqual("keyboard", user.password);
        }

        public void testDelete()
        {
            TerminalUser user = repo.findById(id);
            repo.remove(user);

            TerminalUser deletedUser = repo.findById(id);
            Assert.IsNull(deletedUser);
        }
    }
}
