using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class ServicesServiceTests
    {
        private MyMock<IServiceDao> _serviceDao;
        private MyMock<IMemoryCache> _memoryCache;
        private MyMock<IResourceDao> _resourcesDao;
        private MyMock<IServiceResourceDao> _serviceResourceDao;
        private IServicesService _service;

        [SetUp]
        public void Setup()
        {
            _serviceDao = new MyMock<IServiceDao>();
            _memoryCache = new MyMock<IMemoryCache>();
            _resourcesDao = new MyMock<IResourceDao>();
            _serviceResourceDao = new MyMock<IServiceResourceDao>();

            _service = new ServicesService(_memoryCache.Object, _serviceDao.Object, _resourcesDao.Object, _serviceResourceDao.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _serviceDao.VerifyAll();
            _memoryCache.VerifyAll();
            _resourcesDao.VerifyAll();
            _serviceResourceDao.VerifyAll();
        }

        #region GetServicesModel
        //TODO
        #endregion
        #region AddNewService
        //TODO
        #endregion
        #region UpdateService
        //TODO
        #endregion
        #region ConvertService
        //TODO
        #endregion
        #region ConvertServiceModel
        //TODO
        #endregion
        #region ValidateServiceModel
        //TODO
        #endregion
    }
}
