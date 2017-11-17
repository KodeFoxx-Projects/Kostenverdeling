namespace Kostenverdeling.Model.Settings
{
    public class CalculationSettings
    {
        public CalculationSettingsElement ManagementCosts { get; set; }
        public CalculationSettingsElement SocialSecurity { get; set; }
        public CalculationSettingsElement SocialSecurityProvision { get; set; }
        public CalculationSettingsElement AdvanceTaxPayment { get; set; }
        public CalculationSettingsElement WageGarnishmentManagement { get; set; }
        public CalculationSettingsElement WageGarnishment { get; set; }
    }
}
