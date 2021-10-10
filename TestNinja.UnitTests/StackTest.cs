using NUnit.Framework;
using TestNinja.Fundamentals;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Push_ArgIsNull_ThrowArgNullExceptionn() 
        {
            Stack<object> S = new Stack<object>();
            object obj = null;
            Assert.That(() => S.Push(obj), Throws.Exception);
        }
        
        [Test]
        public void Push_ValidArg_AddTheObjToTheStack()
        {
            Stack<object> S = new Stack<object>();
            object obj = " ";
            S.Push(obj);
            Assert.That(S.Count ,Is.EqualTo(1));
        }

        [Test]
        public void test_Peek()
        {
            Stack<object> S = new Stack<object>();
            object obj = "1";
            S.Push(obj);
            var result = S.Peek();
            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Peek_Emptytack_ThrowArgNullException()
        {
            Stack<object> S = new Stack<object>();
           
            Assert.That(()=> S.Peek(), Throws.Exception);
        }

        [Test]
        public void Pop_Emptytack_ThrowArgNullException()
        {
            Stack<object> S = new Stack<object>();

            Assert.That(() => S.Peek(), Throws.Exception);
        }

        [Test]
        public void Pop_StackWiththeAFewObjects_ReturnObjectOnTheTop()
        {
            Stack<object> S = new Stack<object>();
            S.Push("1");
            var result = S.Pop();
            int Count = S.Count;
            Assert.That(result, Is.EqualTo("1"));
            Assert.That(Count, Is.EqualTo(0));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Stack<object> S = new Stack<object>();
            int Count = S.Count;
            Assert.That(Count, Is.EqualTo(0));
        }
        
    }
}
