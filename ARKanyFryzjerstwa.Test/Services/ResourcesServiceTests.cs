using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Moq;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class ResourcesServiceTests
    {
        private MyMock<IResourceDao> _resourceDao;
        private IResourcesService _service;

        [SetUp]
        public void Setup()
        {
            _resourceDao = new MyMock<IResourceDao>();
            _service = new ResourcesService(_resourceDao.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _resourceDao.VerifyAll();
        }

        #region GetResourcesModel
        [Test]
        public void GetResourcesModelTest()
        {
            //Arrange
            const int salonId = 5;
            var salonResources = new List<Resource>()
            {
                new Resource() { Id=21, SalonId=salonId, Name="Pianka do włosów", Quantity=5.4f, Unit=ResourceUnit.Ml, AlertQuantity=0.2f },
                new Resource() { Id=47, SalonId=salonId, Name="Żel do włosów", Quantity=12.0f, Unit=ResourceUnit.Szt, AlertQuantity=0.5f }
            };
            _resourceDao.Setup(x => x.GetResourcesBySalonId(salonId), Times.Once()).Returns(salonResources);

            //Act
            var result = _service.GetResourcesModel(salonId);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Resources, Is.Not.Null);
            Assert.That(result.Resources, Is.Not.Empty);
            Assert.That(result.Resources.Count, Is.EqualTo(salonResources.Count));
            foreach (var resultResource in result.Resources)
            {
                var resource = salonResources.FirstOrDefault(x => x.Id == resultResource.Id);
                Assert.That(resource, Is.Not.Null);
                Assert.That(resultResource.Id, Is.EqualTo(resource.Id));
                Assert.That(resultResource.Name, Is.EqualTo(resource.Name));
                Assert.That(resultResource.Quantity, Is.EqualTo(resource.Quantity.ToString()));
                Assert.That(resultResource.Unit, Is.EqualTo(resource.Unit));
                Assert.That(resultResource.AlertQuantity, Is.EqualTo(resource.AlertQuantity.ToString()));
            }
        }
        #endregion
        #region AddNewResource
        //tood
        #endregion
        #region UpdateResource
        //tood
        #endregion
        #region RemoveResource
        //tood
        #endregion
        #region RemoveResources
        //tood
        #endregion
    }
}
