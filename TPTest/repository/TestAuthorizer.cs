using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP.repository;
using TP.Config;
using TP.Domain;

namespace TPTest.repository
{
    [TestClass]
    public class TestAuthorizer
    {
        long id;
        AuthorizerRepository repo = new AuthorizerRepository();
        [TestMethod]
        public void TestAllAuthorizer()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadAuthorizerConfig();
            Authorizer auth = new Authorizer();
            auth.authCode = "321sd654sdf";
            auth.secQuestion = "What is your name";
            auth.secAnswer = "I dont't have one";

            repo.save(auth);
            id = auth.id;
            
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            Authorizer auth = repo.findById(id);
            Assert.AreEqual("What is your name", auth.secQuestion);
        }

        public void testUpdate()
        {
            Authorizer auth = repo.findById(id);
            auth.secAnswer = "Boniface";
            repo.update(auth);

            Authorizer updatedAuth = repo.findById(id);
            Assert.AreEqual("Boniface", updatedAuth.secAnswer);
        }

        public void testRemove()
        {
            Authorizer auth = repo.findById(id);
            repo.remove(auth);

            Authorizer deletedAuth = repo.findById(id);
            Assert.IsNull(deletedAuth);
        }
    }
}
