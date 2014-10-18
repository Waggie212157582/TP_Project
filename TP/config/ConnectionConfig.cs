using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using TP.Domain;
using NHibernate.Tool.hbm2ddl;

namespace TP.Config
{
    public static class ConnectionConfig
    {
        public static void loadPatientConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Patient).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadNextOfKinConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(NextOfKin).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadAppointmentConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Appointment).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadEmployeeConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Employee).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadMedicalHistoryConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(MedicalHistory).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadPaymentConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Payment).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadPaymentDataConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(PaymentData).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadProcedureConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Procedures).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadTerminalUserConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(TerminalUser).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadPatientAddressConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(PatientAddress).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static void loadAuthorizerConfig()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Authorizer).Assembly);
            new SchemaExport(cfg).Execute(true, true, false);
        }
    }
}
