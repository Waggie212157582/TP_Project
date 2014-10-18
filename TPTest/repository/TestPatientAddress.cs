using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP.Repository;
using TP.Domain;
using TP.Config;

namespace TPTest.repository
{
    [TestClass]
    public class TestPatientAddress
    {

        long id;
        PatientAddressRepository repo = new PatientAddressRepository();

        [TestMethod()]
        public void TestAllPatientAddress()
        {
            testCreate();
            testRead();
            testUpdate();
            testDelete();
        }

        public void testCreate()
        {
            ConnectionConfig.loadPatientConfig();
            PatientAddress patientAddress = new PatientAddress();
            patientAddress.addressType = "I dont know what must be here";
            patientAddress.city = "Cape Town";
            patientAddress.postalCode = "9987";
            patientAddress.streetNameNo = "94 100 Acre Wood";
            patientAddress.suburb = "Poo-land";




            repo.save(patientAddress);
            id = patientAddress.id;
            Assert.IsNotNull(id);
        }



        public void testRead()
        {
            PatientAddress patientAddress = repo.findById(id);
            Assert.AreEqual("94 100 Acre Wood", patientAddress.streetNameNo);
        }

        public void testUpdate()
        {
            PatientAddress patientAddress = repo.findById(id);
            patientAddress.streetNameNo = "39 PekeurStreet Montagu";
            repo.update(patientAddress);
            PatientAddress updatedPatientAddress = repo.findById(id);
            Assert.AreEqual("39 PekeurStreet Montagu", updatedPatientAddress.streetNameNo);
        }

        public void testDelete()
        {
            PatientAddress patientAddress = repo.findById(id);
            repo.remove(patientAddress);

            PatientAddress deletedPatientaddress = repo.findById(id);
            Assert.IsNull(deletedPatientaddress);
        }
    }
}
