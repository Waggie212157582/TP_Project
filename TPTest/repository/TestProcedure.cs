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
    public class TestProcedure
    {
        long id;
        ProcedureRepository repo = new ProcedureRepository();
        [TestMethod]
        public void TestAllProcedures()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadProcedureConfig();
            Procedures procedure = new Procedures();
            procedure.procedureCode = 025511;
            procedure.procedureName = "Tooth Extraction";
            procedure.procedurePrice = 350.00;

            repo.save(procedure);
            id = procedure.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            Procedures procedure = repo.findById(id);
            Assert.AreEqual("Tooth Extraction", procedure.procedureName);
        }

        public void testUpdate()
        {
            Procedures procedure = repo.findById(id);
            procedure.procedureCode = 11115;
            repo.update(procedure);

            Procedures updateProcedure = repo.findById(id);
            Assert.AreEqual(11115, procedure.procedureCode);
        }

        public void testRemove()
        {
            Procedures procedure = repo.findById(id);
            repo.remove(procedure);

            Procedures deletedProcedure = repo.findById(id);
            Assert.IsNull(deletedProcedure);
        }
    }
}
