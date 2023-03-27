using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.Models;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class ServiceResourceDaoTests : BaseDaoTests<ServiceResourceDao>
    {
        #region GetServiceResources

        [Test]
        public void GetServiceResourcesTest()
        {
            //Arrange
            var service = Context.Services.FirstOrDefault();
            Assert.That(service, Is.Not.Null);

            var resources = new List<Resource>()
            {
                new()
                {
                    Name = "Test1",
                    SalonId = service.SalonId,
                },

                new()
                {
                    Name = "Test2",
                    SalonId = service.SalonId
                },
                new()
                {
                    Name = "Test3",
                    SalonId = service.SalonId
                }
            };
            Context.Resources.AddRange(resources);
            Context.SaveChanges();

            var usage = 20;
            var serviceResources = resources
                .Select(x => new ServiceResource() { ResourceId = x.Id, ServiceId = service.Id, Usage = usage++}).ToList();
            Context.ServiceResource.AddRange(serviceResources);
            Context.SaveChanges();

            //Act
            var result = _dao.GetServiceResources(service.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(1));
            foreach (var resource in serviceResources)
            {
                var resultModel = result.FirstOrDefault(x => x.Id == resource.ResourceId);
                Assert.That(result, Is.Not.Null);
                AssertAreEqual(resource, resultModel);
            }
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new ServiceResourceDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(ServiceResource expected, DisplayingServiceResourceModel actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.ResourceId));
                Assert.That(actual.Usage, Is.EqualTo(expected.Usage));
            });
        }

    }
}
