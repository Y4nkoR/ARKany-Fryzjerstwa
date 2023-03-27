using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class VerificationCodeDaoTests : BaseDaoTests<VerificationCodeDao>
    {
        #region AddVerificationCode
        [Test]
        public void AddVerificationCodeTest()
        {
            //Arrange
            var user = Context.Users.FirstOrDefault();
            Assert.That(user, Is.Not.Null);
            const string code = "afs34SD";

            //Act
            var result = _dao.AddVerificationCode(code, user.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Code, Is.EqualTo(code));
            Assert.That(result.UserId, Is.EqualTo(user.Id));
            var dbResult = Context.VerificationCodes.FirstOrDefault(x => x.Id == result.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(result, dbResult);
        }
        #endregion
        #region GetLastUserVerificationCode
        [Test]
        public void GetLastUserVerificationCode()
        {
            //Arrange
            var user = Context.Users.FirstOrDefault();
            Assert.That(user, Is.Not.Null);

            var newCodes = new List<VerificationCode>()
            {
                new()
                {
                    Code = "123123",
                    InsertDateTime = DateTime.Now,
                    UserId = user.Id
                },
                new()
                {
                    Code = "aaasss",
                    InsertDateTime = DateTime.Now.AddHours(-1),
                    UserId = user.Id
                }
            };
            Context.VerificationCodes.AddRange(newCodes);
            Context.SaveChanges();

            //Act
            var result = _dao.GetLastUserVerificationCode(user.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(newCodes[0], result);
        }
        #endregion
        #region Update
        [Test]
        public void Update()
        {
            //Arrange
            var codeToUpdate = Context.VerificationCodes.FirstOrDefault();
            Assert.That(codeToUpdate, Is.Not.Null);
            codeToUpdate.Code = "newnew";
            codeToUpdate.IsUsed = true;

            //Act
            _dao.Update(codeToUpdate);

            //Assert
            var result = Context.VerificationCodes.FirstOrDefault(x => x.Id == codeToUpdate.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(codeToUpdate, result);
        }
        #endregion


        protected override void SetDao()
        {
            _dao = new VerificationCodeDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(VerificationCode expected, VerificationCode actual)
        {
            Assert.Multiple((() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.Code, Is.EqualTo(expected.Code));
                Assert.That(actual.UserId, Is.EqualTo(expected.UserId));
                Assert.That(actual.IsUsed, Is.EqualTo(expected.IsUsed));
            }));
        }
    }
}
