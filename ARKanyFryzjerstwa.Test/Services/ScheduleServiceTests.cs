using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class ScheduleServiceTests
    {
        private MyMock<IMemoryCache> _memoryCache;
        private MyMock<IUserDao> _userDao;
        private MyMock<IAppointmentDao> _appointmentDao;
        private MyMock<IClientDao> _clientDao;
        private MyMock<IServiceDao> _serviceDao;
        private IScheduleService _service;

        [SetUp]
        public void Setup()
        {
            _memoryCache = new MyMock<IMemoryCache>();
            _userDao = new MyMock<IUserDao>();
            _appointmentDao = new MyMock<IAppointmentDao>();
            _clientDao = new MyMock<IClientDao>();
            _serviceDao = new MyMock<IServiceDao>();

            _service = new ScheduleService(_memoryCache.Object, _userDao.Object, _appointmentDao.Object, _serviceDao.Object, _clientDao.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _userDao.VerifyAll();
            _appointmentDao.VerifyAll();
            _clientDao.VerifyAll();
            _serviceDao.VerifyAll();
        }

        #region GetScheduleModel
        //TODO
        #endregion
        #region GetScheduleDays
        //TODO
        #endregion
        #region ConvertAppointments
        //TODO
        #endregion
    }
}
