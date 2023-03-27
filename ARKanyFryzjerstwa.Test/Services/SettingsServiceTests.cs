using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Identity;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class SettingsServiceTests
    {
        private MyMock<ISalonDao> _salonDao;
        private MyMock<IUserDao> _userDao;
        private ISettingsService _service;

        [SetUp]
        public void Setup()
        {
            _service = new SettingsService((null as UserManager<User>), _userDao.Object, _salonDao.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _userDao.VerifyAll();
            _salonDao.VerifyAll();
        }

    }
}
