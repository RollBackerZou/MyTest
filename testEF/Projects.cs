//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace testEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projects
    {
        public Projects()
        {
            this.AssetPositions = new HashSet<AssetPositions>();
            this.Attachments = new HashSet<Attachments>();
            this.BudgetaryDatas = new HashSet<BudgetaryDatas>();
            this.Cashflows = new HashSet<Cashflows>();
            this.Comments = new HashSet<Comments>();
            this.DeviceEvents = new HashSet<DeviceEvents>();
            this.DeviceEvents1 = new HashSet<DeviceEvents>();
            this.EnterApplications = new HashSet<EnterApplications>();
            this.InitialCostInfoes = new HashSet<InitialCostInfoes>();
            this.LoanInfoes = new HashSet<LoanInfoes>();
            this.Maintainences = new HashSet<Maintainences>();
            this.MonitoringInfoes = new HashSet<MonitoringInfoes>();
            this.OmLogs = new HashSet<OmLogs>();
            this.PowerTrades = new HashSet<PowerTrades>();
            this.ProjectImages = new HashSet<ProjectImages>();
            this.ProjectPCS = new HashSet<ProjectPCS>();
            this.ProjectProperties = new HashSet<ProjectProperties>();
            this.ProjectPropertyPaymentDetails = new HashSet<ProjectPropertyPaymentDetails>();
            this.PropertyPayments = new HashSet<PropertyPayments>();
            this.Scenarios = new HashSet<Scenarios>();
            this.Schedules = new HashSet<Schedules>();
            this.SubscibeProjects = new HashSet<SubscibeProjects>();
            this.WeeklyTasks = new HashSet<WeeklyTasks>();
            this.IncidentReports = new HashSet<IncidentReports>();
        }
    
        public int Id { get; set; }
        public string Number { get; set; }
        public string Region { get; set; }
        public string Prefecture { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Capacity { get; set; }
        public int FIT { get; set; }
        public double Cost { get; set; }
        public System.DateTime CommercialOperationDate { get; set; }
        public Nullable<System.DateTime> FCDate { get; set; }
        public Nullable<System.DateTime> SecuredDate { get; set; }
        public int Status { get; set; }
        public int Status2 { get; set; }
        public int Priority { get; set; }
        public string ResponserUserIds { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Nullable<int> MapScaling { get; set; }
        public string RegionOffice { get; set; }
        public Nullable<int> LandContract { get; set; }
        public Nullable<bool> IsPowerRestriction { get; set; }
        public string PowerRestriction { get; set; }
        public int Scale { get; set; }
        public int Type { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public byte[] Timestamp { get; set; }
        public string AppUser_Id { get; set; }
        public string WeatherStationId { get; set; }
        public double YieldChartMax { get; set; }
        public int PVMNH { get; set; }
        public string Anonymity { get; set; }
        public string SerialName { get; set; }
        public string ForeignOrder { get; set; }
        public Nullable<bool> InFundList { get; set; }
    
        public virtual ICollection<AssetPositions> AssetPositions { get; set; }
        public virtual ICollection<Attachments> Attachments { get; set; }
        public virtual ICollection<BudgetaryDatas> BudgetaryDatas { get; set; }
        public virtual ICollection<Cashflows> Cashflows { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<DeviceEvents> DeviceEvents { get; set; }
        public virtual ICollection<DeviceEvents> DeviceEvents1 { get; set; }
        public virtual EnergyYieldEstimations EnergyYieldEstimations { get; set; }
        public virtual ICollection<EnterApplications> EnterApplications { get; set; }
        public virtual ICollection<InitialCostInfoes> InitialCostInfoes { get; set; }
        public virtual ICollection<LoanInfoes> LoanInfoes { get; set; }
        public virtual ICollection<Maintainences> Maintainences { get; set; }
        public virtual ICollection<MonitoringInfoes> MonitoringInfoes { get; set; }
        public virtual ICollection<OmLogs> OmLogs { get; set; }
        public virtual ICollection<PowerTrades> PowerTrades { get; set; }
        public virtual ICollection<ProjectImages> ProjectImages { get; set; }
        public virtual ICollection<ProjectPCS> ProjectPCS { get; set; }
        public virtual ProjectProfiles ProjectProfiles { get; set; }
        public virtual ICollection<ProjectProperties> ProjectProperties { get; set; }
        public virtual ICollection<ProjectPropertyPaymentDetails> ProjectPropertyPaymentDetails { get; set; }
        public virtual Users Users { get; set; }
        public virtual WeatherStations WeatherStations { get; set; }
        public virtual ICollection<PropertyPayments> PropertyPayments { get; set; }
        public virtual ICollection<Scenarios> Scenarios { get; set; }
        public virtual ICollection<Schedules> Schedules { get; set; }
        public virtual ICollection<SubscibeProjects> SubscibeProjects { get; set; }
        public virtual ICollection<WeeklyTasks> WeeklyTasks { get; set; }
        public virtual ICollection<IncidentReports> IncidentReports { get; set; }
    }
}
