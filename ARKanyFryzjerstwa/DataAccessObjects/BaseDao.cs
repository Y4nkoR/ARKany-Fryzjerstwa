using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public abstract class BaseDao : IBaseDaoSetters, IBaseDaoGetters
    {
        protected readonly IdentityContext _identityContext;
        protected readonly DatabaseTable _databaseTable;
        protected readonly int? _currentSalonId;

        public BaseDao(IdentityContext identityContext, DatabaseTable databaseTable, int? currentSalonId)
        {
            _identityContext = identityContext;
            _databaseTable = databaseTable;
            _currentSalonId = currentSalonId;
        }

        /// <summary> Ustawia datę i czas modyfikacji danych na aktualną.</summary>
        public void SetModificationDateTimeToNow()
        {
            var resultTableModification = GetModificationDateTimeForTableBySalonIdAndTable();

            if (resultTableModification == null)
            {
                var tableModification = new TableModification()
                {
                    SalonId = _currentSalonId!.Value,
                    Table = _databaseTable,
                    ModificationDateTime = DateTime.Now
                };

                _identityContext.Add(tableModification);
            }
            else
            {
                resultTableModification.ModificationDateTime = DateTime.Now;
                _identityContext.Update(resultTableModification);
            }

            _identityContext.SaveChanges();
        }

        /// <summary> Sprawdza, czy dane w cache są aktualne.</summary>
        /// <param name="cacheModification"> Data i czas zamieszczenia danych w cache.</param>
        /// <returns> True, jeśli dane są aktualne, w przeciwnym wypadku - false. </returns>
        public bool IsUpToDate(DateTime cacheModification)
        {
            var tableModification = GetModificationDateTimeForTableBySalonIdAndTable();
            return tableModification == null || cacheModification > tableModification.ModificationDateTime;
        }

        /// <summary> Pobiera datę i czas modyfikacji danych w tabeli.</summary>
        /// <returns> Obiekt <see cref="TableModification"/> lub, jeśli informacje o danej tabeli nie istnieją, wartość null. </returns>
        private TableModification? GetModificationDateTimeForTableBySalonIdAndTable()
        {
            return _identityContext.TablesModificationDateTimes.Where(tm => tm.SalonId == _currentSalonId && tm.Table == _databaseTable).FirstOrDefault();
        }
    }
}
