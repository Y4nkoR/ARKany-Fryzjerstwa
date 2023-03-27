using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

public interface IServiceDao : IBaseDaoGetters
{
    /// <summary> Pobiera informacje o usłudze na podstawie numeru Id.</summary>
    /// <param name="serviceId"> Uniklany numer Id usługi. </param>
    /// <returns> Obiekt <see cref="Service"/> zawierający informacje o usłudze. Jeśli informacje o danej usłudze nie istnieją, zwracana jest wartość null.</returns>
    Service? GetServiceById(int serviceId);
    /// <summary> Pobiera informacje o aktywnych usługach dla danego salonu.</summary>
    /// <param name="salonId"> Uniklany numer Id salonu. </param>
    /// <returns> Lista obiektów <see cref="Service"/> zawierających informacje o usługach.</returns>
    IList<Service> GetActiveServicesForSalon(int salonId);
    /// <summary> Pobiera informacje o usługach dla danego salonu.</summary>
    /// <param name="salonId"> Uniklany numer Id salonu. </param>
    /// <returns> Lista obiektów <see cref="Service"/> zawierających informacje o usługach.</returns>
    IList<Service> GetServicesBySalonId(int salonId);
    /// <summary> Dodaje podaną usługę do bazy danych.</summary>
    /// <param name="service"> Obiekt <see cref="Service"/> zawierający informacje o dodawanej usłudze. </param>
    void AddService(Service service);
    /// <summary> Aktualizuje informacje o danej usłudze.</summary>
    /// <param name="service"> Obiekt <see cref="Service"/> zawierający informacje o usłudze. </param>
    void UpdateService(Service service);
    /// <summary> Aktualizuje informacje o danych usługach.</summary>
    /// <param name="services"> Lista obiektów <see cref="Service"/> zawierających informacje o usługach. </param>
    void UpdateServices(List<Service> services);
}
