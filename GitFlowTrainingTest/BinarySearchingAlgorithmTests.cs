using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitFlowTraining.Tests
{
    [TestClass()]
    public class BinarySearchingAlgorithmTests
    {
        [TestMethod()]
        public void findExistingElementTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new BinarySearchingAlgorithm();
            Credit[] credits = new Credit[] {
                new Credit(22),
                new Credit(33),
                new Credit(444),
                new Credit(777),
                new Credit(1001),
            };

            Credit expectedElement = new Credit(777);
            Credit foundElement = searchingAlgorithm.findElement(credits, expectedElement);

            Assert.AreEqual(expectedElement, foundElement);
        }

        [TestMethod()]
        public void findNonExistiedElementTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new BinarySearchingAlgorithm();
            Credit[] credits = new Credit[] {
                new Credit(22),
                new Credit(33),
                new Credit(444),
                new Credit(777),
                new Credit(1001),
            };

            Credit expectedElement = new Credit(7710999);
            Credit foundElement = searchingAlgorithm.findElement(credits, expectedElement);

            Assert.IsNull(foundElement);
        }

        [TestMethod()]
        public void algorithmIterationsTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new BinarySearchingAlgorithm();
            Credit[] credits = new Credit[] {
                new Credit(22),
                new Credit(33),
                new Credit(444),
                new Credit(777),
                new Credit(1001),
            };

            Credit expectedElement = new Credit(777);
            searchingAlgorithm.findElement(credits, expectedElement);

            Assert.AreEqual((uint)2, searchingAlgorithm.IterationCountForLastExecution());
        }
    }
}