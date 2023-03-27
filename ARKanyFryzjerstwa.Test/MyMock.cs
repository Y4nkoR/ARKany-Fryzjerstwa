using Moq;
using System.Linq.Expressions;
using Moq.Language.Flow;

namespace ARKanyFryzjerstwa.Test
{
    public class MyMock<T> : Mock<T> where T : class
    {
        private readonly List<Action> _functionsToVerify = new List<Action>();

        #region Ctors
        public MyMock() : base() { }
        public MyMock(params object[] args) : base(args) { }
        public MyMock(MockBehavior mockBehavior) : base(mockBehavior) { }
        public MyMock(MockBehavior behavior, params object[] args) : base(behavior, args) { }
        public MyMock(Expression<Func<T>> newExpression, MockBehavior behavior = MockBehavior.Default)
            : base(behavior, newExpression, behavior) { }
        #endregion
        #region Setups
        public ISetup<T> Setup(Expression<Action<T>> expression, Times times)
        {
            _functionsToVerify.Add(() => Verify(expression, times));
            return base.Setup(expression);
        }
        public ISetup<T, TResult> Setup<TResult>(Expression<Func<T, TResult>> expression, Times times)
        {
            _functionsToVerify.Add(() => Verify(expression, times));
            return base.Setup(expression);
        }
        #endregion

        public new void VerifyAll()
        {
            VerifySetup();
            base.VerifyNoOtherCalls();
        }
        public void VerifySetup()
        {
            _functionsToVerify.ForEach(f => f());
            base.VerifyAll();

        }
    }
}
