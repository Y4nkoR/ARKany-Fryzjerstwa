using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class ResourceDaoTests : BaseDaoTests<ResourceDao>
    {
        #region AddResource
        [Test]
        public void AddResourceTest()
        {
            //Arrange
            var resourceToAdd = new Resource()
            {
                Name = "test resource",
                SalonId = CURRENT_SALON_ID,
                Unit = ResourceUnit.Ml,
                Quantity = 50.5f,
                AlertQuantity = 20
            };

            //Act
            _dao.AddResource(resourceToAdd);

            //Assert
            var result = Context.Resources.FirstOrDefault(r => r.Id == resourceToAdd.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(resourceToAdd, result);
        }
        #endregion
        #region GetResourceById
        [Test]
        public void GetResourceByIdTest()
        {
            //Arrange
            var resourceToAdd = new Resource()
            {
                Name = "test resource",
                SalonId = CURRENT_SALON_ID,
                Unit = ResourceUnit.Ml,
                Quantity = 50.5f,
                AlertQuantity = 20
            };
            Context.Resources.Add(resourceToAdd);
            Context.SaveChanges();

            //Act
            var result = _dao.GetResourceById(resourceToAdd.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(resourceToAdd, result);
        }
        #endregion
        #region GetResourcesBySalonId
        [Test]
        public void GetResourcesBySalonIdTest()
        {
            //Arrange
            var resourcesToAdd = new List<Resource>()
            {
                new()
                {
                    Name = "test resource",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Ml,
                    Quantity = 50.5f,
                    AlertQuantity = 20
                },
                new()
                {
                    Name = "test resource 2 ",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Szt,
                    Quantity = 10.2f,
                    AlertQuantity = 25.6f
                },
            };
            Context.Resources.AddRange(resourcesToAdd);
            Context.SaveChanges();

            //Act
            var result = _dao.GetResourcesBySalonId(CURRENT_SALON_ID);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(2));
            foreach (var expected in resourcesToAdd)
            {
                var resultResource = result.FirstOrDefault(r => r.Id == expected.Id);
                Assert.That(result, Is.Not.Null);
                AssertAreEqual(expected, resultResource);
            }
        }
        #endregion
        #region GetResourcesGettingLow
        [Test]
        public void GetResourcesGettingLowTest()
        {
            //Arrange
            var resourcesToAdd = new List<Resource>()
            {
                new()
                {
                    Name = "test resource",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Ml,
                    Quantity = 10.5f,
                    AlertQuantity = 20
                },
                new()
                {
                    Name = "test resource 2 ",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Szt,
                    Quantity = 6.2f,
                    AlertQuantity = 25.6f
                },
                new()
                {
                    Name = "test resource 3 ",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Szt,
                    Quantity = 70,
                    AlertQuantity = 80
                },
                new()
                {
                    Name = "test resource 4 ",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Ml,
                    Quantity = 6,
                    AlertQuantity = 2.6f
                },
                new()
                {
                    Name = "test resource 5 ",
                    SalonId = CURRENT_SALON_ID,
                    Unit = ResourceUnit.Szt,
                    Quantity = 68.2f,
                    AlertQuantity = 15.6f
                },
            };
            Context.Resources.AddRange(resourcesToAdd);
            Context.SaveChanges();
            var expected = resourcesToAdd.GetRange(0, 3);
            
            //Act
            var result = _dao.GetResourcesGettingLow(CURRENT_SALON_ID);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expectedResource in expected)
            {
                var resultResource = result.FirstOrDefault(x => x.Id == expectedResource.Id);
                Assert.That(resultResource, Is.Not.Null);
                AssertAreEqual(expectedResource, resultResource);
            }
        }
        #endregion
        #region UpdateResource
        [Test]
        public void UpdateResourceTest()
        {
            //Arrange
            var resourceToUpdate = Context.Resources.FirstOrDefault();
            Assert.That(resourceToUpdate, Is.Not.Null);
            resourceToUpdate.Name = "New name";
            resourceToUpdate.Unit = ResourceUnit.Szt;
            resourceToUpdate.Quantity = 11.4f;
            resourceToUpdate.AlertQuantity = 7.3f;
            
            //Act
            _dao.UpdateResource(resourceToUpdate);

            //Assert
            var result = Context.Resources.FirstOrDefault(x => x.Id == resourceToUpdate.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(resourceToUpdate, result);
        }
        #endregion
        #region RemoveResource
        [Test]
        public void RemoveResourceTest()
        {
            //Arrange
            var resourceToRemove = Context.Resources.FirstOrDefault();
            Assert.That(resourceToRemove, Is.Not.Null);
            var resourceId = resourceToRemove.Id;

            //Act
            _dao.RemoveResource(resourceToRemove);

            //Assert
            var result = Context.Resources.FirstOrDefault(x => x.Id == resourceId);
            Assert.That(result, Is.Null);
        }
        #endregion
        #region RemoveResources
        [Test]
        public void RemoveResourcesTest()
        {
            //Arrange
            var resourcesToRemove = Context.Resources.Take(3).ToList();
            Assert.That(resourcesToRemove, Is.Not.Null);
            Assert.That(resourcesToRemove, Has.Count.EqualTo(3));
            var resourcesIds = resourcesToRemove.Select(x => x.Id).ToList();

            //Act
            _dao.RemoveResources(resourcesToRemove);

            //Assert
            var result = Context.Resources.Any(x => resourcesIds.Contains(x.Id));
            Assert.That(result, Is.False);
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new ResourceDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(Resource expected, Resource actual)
        {
            Assert.Multiple((() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.SalonId, Is.EqualTo(expected.SalonId));
                Assert.That(actual.Name, Is.EqualTo(expected.Name));
                Assert.That(actual.Quantity, Is.EqualTo(expected.Quantity));
                Assert.That(actual.Unit, Is.EqualTo(expected.Unit));
                Assert.That(actual.AlertQuantity, Is.EqualTo(expected.AlertQuantity));
            }));
        }
    }
}
