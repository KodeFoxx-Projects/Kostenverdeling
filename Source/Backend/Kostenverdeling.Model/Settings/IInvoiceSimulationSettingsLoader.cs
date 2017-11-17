using Kostenverdeling.Model.InvoiceSimulation;

namespace Kostenverdeling.Model.Settings
{
    public interface IInvoiceSimulationSettingsLoader
    {
        InvoiceSimulationSettings Load();
    }
}
