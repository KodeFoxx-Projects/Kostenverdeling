namespace Kostenverdeling.Model.DataImport
{
    /// <summary>
    /// Responsible for importing data from e-blox.
    /// </summary>
    /// <typeparam name="TSource">Type of the source.</typeparam>
    public interface IEBloxImporter<TSource>
    {
        EBloxImportResult Import(TSource source);
    }
}
