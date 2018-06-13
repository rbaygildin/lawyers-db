using System;
using System.ComponentModel;

namespace CHW_2_Yarnykh_Roman_V13
{
    class Requisite
    {
        
        public string Assignment { get; set; }
        public string AssignmentEntry { get; set; }
        public string Suspension { get; set; }
        public string SuspensionEntry { get; set; }
        public string Resumption { get; set; }
        public string ResumptionEntry { get; set; }
        public string CancelSuspension { get; set; }
        public string CancelSuspensionEntry { get; set; }
        public string ClearRecords { get; set; }
        public string ClearRecordsEntry { get; set; }
        public string Description { get; set; }
        public string DescriptionEntry { get; set; }
        public string Status { get; set; }
        public string Org { get; set; }
        public string Cab { get; set; }
    }
    [Serializable]
    class Lawyer
    {
        private Requisite requisite_;
        [DisplayName("Номер регистрации")]
        public string RegistryNumber { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Имя")]
        public string FirstName { get; set; }
        [DisplayName("Отчество")]
        public string Patronym { get; set; }
        [DisplayName("Присвоение статуса адвоката")]
        public string Assignment { get { return requisite_.Assignment; } }
        [DisplayName("Распоряжение Минюста о присвоении статуса адвоката")]
        public string AssignmentEntry { get { return requisite_.AssignmentEntry; } }
        [DisplayName("Приостановка статуса адвоката")]
        public string Suspension { get { return requisite_.Suspension; } }
        [DisplayName("Распоряжение Минюста о приостановке статуса адвоката")]
        public string SuspensionEntry { get { return requisite_.SuspensionEntry; } }
        [DisplayName("Возобновление статуса адвоката")]
        public string Resumption { get { return requisite_.Resumption; } }
        [DisplayName("Распоряжение Минюста о возобновлении статуса адвоката")]
        public string ResumptionEntry { get { return requisite_.ResumptionEntry; } }
        [Browsable(false)]
        public string CancelSuspension { get { return requisite_.CancelSuspension; } }
        [Browsable(false)]
        public string CancelSuspensionEntry { get { return requisite_.CancelSuspensionEntry; } }
        [Browsable(false)]
        public string ClearRecords { get { return requisite_.ClearRecords; } }
        [Browsable(false)]
        public string ClearRecordsEntry { get { return requisite_.ClearRecordsEntry; } }
        [Browsable(false)]
        public string Description { get { return requisite_.Description; } }
        [Browsable(false)]
        public string DescriptionEntry { get { return requisite_.DescriptionEntry; } }
        [Browsable(false)]
        public string Status { get; set; }
        [Browsable(false)]
        public string Org { get; set; }
        [Browsable(false)]
        public string Cab { get; set; }
        [Browsable(false)]
        public Requisite Requisite { set { requisite_ = value; } }
    }
}
