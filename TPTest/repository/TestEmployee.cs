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
    public class TestEmployee
    {
        long id;
        EmployeeRepository repo = new EmployeeRepository();
        [TestMethod]
        public void TestAllEmployee()
        {
            testCreate();
            testRead();
            testUpdate();
            testRemove();
        }

        public void testCreate()
        {
            ConnectionConfig.loadEmployeeConfig();
            Employee employee = new Employee();
            employee.empName = "Tino";
            employee.empSurname = "Moerat";
            employee.empAddress = "Somehwere Far in a lost city";
            employee.empGender = "Male";
            employee.empId = "E96543218";
            employee.jobTitle = "Cleaner";
            employee.empType = "A";

            repo.save(employee);
            id = employee.id;
            Assert.IsNotNull(id);
        }

        public void testRead()
        {
            Employee employee = repo.findById(id);
            Assert.AreEqual("Cleaner", employee.jobTitle);
        }

        public void testUpdate()
        {
            Employee employee = repo.findById(id);
            employee.jobTitle = "Software Developer";
            repo.update(employee);

            Employee updatedEmployee = repo.findById(id);
            Assert.AreEqual("Software Developer", employee.jobTitle);
        }

        public void testRemove()
        {
            Employee employee = repo.findById(id);
            repo.remove(employee);

            Employee deletedEmployee = repo.findById(id);
            Assert.IsNull(deletedEmployee);
        }
    }
}
