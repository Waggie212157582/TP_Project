using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP.Repository;
using TP.Config;
using TP.Domain;
using System.Data.SqlServerCe;

namespace TPTest.Repository
{
    [TestClass]
    public class TestAppointment
    {
        long id;
        AppointmentRepository repo = new AppointmentRepository();
        [TestMethod]
        public void TestAllAppoinment()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadAppointmentConfig();
            Appointment appointment = new Appointment();
            appointment.appDate = DateTime.Today.ToLongDateString();
            appointment.appTime = DateTime.Now.ToLongTimeString();
            appointment.reasonForVisit = "Foot Massage";
            appointment.appId = "1354asd";


            repo.save(appointment);
            id = appointment.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            Appointment appointment = repo.findById(id);
            Assert.AreEqual("1354asd", appointment.appId);
        }

        public void testUpdate()
        {
            Appointment appoinment = repo.findById(id);
            appoinment.reasonForVisit = "Check Up";
            repo.update(appoinment);

            Appointment updatedAppoinment = repo.findById(id);
            Assert.AreEqual("Check Up", updatedAppoinment.reasonForVisit);
        }

        public void testRemove()
        {
            Appointment appoinment = repo.findById(id);
            repo.remove(appoinment);

            Appointment deletedAppoinment = repo.findById(id);
            Assert.IsNull(deletedAppoinment);
        }
    }
}
