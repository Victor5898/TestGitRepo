using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GitFlowTraining.Tests
{
    [TestClass()]
    public class LinearSearchingAlgorithmTests
    {
        [TestMethod()]
        public void findExistingElementTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new LinearSearchingAlgorithm();
            Credit[] credits = new Credit[] { 
                new Credit(22),
                new Credit(43),
                new Credit(2),
                new Credit(99),
                new Credit(1),
            };

            Credit expectedElement = new Credit(99);
            Credit foundElement = searchingAlgorithm.findElement(credits, expectedElement);

            Assert.AreEqual(expectedElement.Amount, foundElement.Amount);
        }

        [TestMethod()]
        public void findNonExistiedElementTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new LinearSearchingAlgorithm();
            Credit[] credits = new Credit[] {
                new Credit(22),
                new Credit(43),
                new Credit(2),
                new Credit(99),
                new Credit(1),
            };

            Credit expectedElement = new Credit(999);
            Credit foundElement = searchingAlgorithm.findElement(credits, expectedElement);

            Assert.IsNull(foundElement);
        }

        [TestMethod()]
        public void algorithmIterationsTest()
        {
            ISearchingAlgorithm searchingAlgorithm = new LinearSearchingAlgorithm();
            Credit[] credits = new Credit[] {
                new Credit(22),
                new Credit(33),
                new Credit(444),
                new Credit(777),
                new Credit(1001),
            };

            Credit expectedElement = new Credit(1001);
            searchingAlgorithm.findElement(credits, expectedElement);

            Assert.AreEqual((uint)5, searchingAlgorithm.IterationCountForLastExecution());
        }
    }
}