using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class AccountServiceTests
    {
        private IAccountService _service;

        [SetUp]
        public void Setup()
        {
            _service = new AccountService(null, null, null, null, null);
        }
        [TearDown]
        public void TearDown()
        { }
    }
}
