namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IBaseDaoSetters
    {
        /// <summary> Ustawia datę i czas modyfikacji danych na aktualną.</summary>
        void SetModificationDateTimeToNow();
    }

    /// <summary> Sprawdza, czy dane w cache są aktualne.</summary>
    /// <param name="cacheModification"> Data i czas zamieszczenia danych w cache.</param>
    /// <returns> True, jeśli dane są aktualne, w przeciwnym wypadku - false. </returns>
    public interface IBaseDaoGetters
    {
        bool IsUpToDate(DateTime cacheModification);
    }
}
