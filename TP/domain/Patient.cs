using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace TP.Domain
{
    public class Patient
    {
        public virtual long id { get; set; }
        public virtual String patientNum { get; set; }
        public virtual String surname { get; set; }
        public virtual String firstName { get; set; }
        public virtual String idNum { get; set; }
        public virtual String gender { get; set; }
        public virtual String maritalStatus { get; set; }
        public virtual String telNo { get; set; }
        public virtual String workTelNo { get; set; }
        public virtual String refferedBy { get; set; }
        public virtual ISet<Appointment> appointmentList { get; set; }
        public virtual Payment payment { get; set; }
        public virtual ISet<PatientAddress>patientAddresses { get; set; }
        public virtual NextOfKin nextOfKin { get; set; }
        public virtual MedicalHistory medicalHistory { get; set; }
        public virtual ISet<PaymentData> paymentData { get; set; }
    }
}
