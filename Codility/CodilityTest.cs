using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Codility
{
    public class CodilityTest
    {
        private int[] ToIntArray(string str)
        {
            var arr = str.Split(',');
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(Convert.ToInt32(arr[i]));
            }

            return lst.ToArray();
        }
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(9, 2, "1001")]
        [TestCase(529, 4, "1000010001")]
        [TestCase(20, 1, "10100")]
        [TestCase(15, 0, "1111")]
        [TestCase(32, 0, "100000")]
        [Test]
        public void TestBinaryGap(int N, int expectedValue, string rep = null)
        {
            var bg = new BinaryGap();
            Assert.AreEqual(expectedValue, bg.solution(N));
        }



        [TestCase("3, 8, 9, 7, 6", 3, "9, 7, 6, 3, 8")]
        [TestCase("0,0,0", 1, "0,0,0")]
        [TestCase("1, 2, 3, 4", 4, "1, 2, 3, 4")]
        [Test]
        public void TestCyclicRotation(string A, int K, string B)
        {
            var cr = new CyclicRotation();
            var a = ToIntArray(A);
            var b = ToIntArray(B);
            Assert.AreEqual(b, cr.solution(a, K));
        }

        [TestCase(7, 9, 3, 9, 3, 9, 7, 9)]
        [Test]
        public void TestOddOccurrencesInArray(int expectedIndex, params int[] lst)
        {
            var odd = new OddOccurrencesInArray();
            Assert.AreEqual(expectedIndex, odd.solution(lst));

        }
        [TestCase(10, 85, 30, 3)]
        [Test]
        public void TestFrogJmp(int X, int Y, int D, int expected)
        {
            var fj = new FrogJmp();
            Assert.AreEqual(expected, fj.solution(X, Y, D));

        }
        /*    [TestCase(-1, 23, 94, 38, 96, 65, 53, 22, 17, 23, 55, 61, 58, 36, 100, 78, 8, 9, 52, 17, 26, 70, 77, 14, 62, 70, 66, 63, 53, 10, 40, 89, 65, 36, 35, 25, 78, 97, 73, 47, 54, 51, 42, 82, 86, 22, 31, 98, 59, 29, 51, 38, 65, 32, 71, 46, 39, 74, 20, 83, 96, 96, 30, 16, 67, 37, 31, 87, 41, 11, 59, 3, 39, 4, 88, 90, 33, 16, 85, 33, 23, 20, 50, 82, 1, 12, 46, 77, 20, 58, 61, 77, 1, 98, 74, 88, 42, 20, 94, 55, 41
    )] */
        [TestCase(4, 2, 3, 1, 5)]
        [TestCase(1, 3, 4, 2)]
        [TestCase(1)]
        [Test]
        public void TestPermMissingElem(int expected, params int[] lst)
        {
            var pme = new PermMissingElem();


            if (expected == -1)
                Assert.AreNotEqual(expected, pme.solution(lst));
            else
                Assert.AreEqual(expected, pme.solution(lst));


        }


        [TestCase(1, 3, 1, 2, 4, 3)]
        [TestCase(2000, -1000, 1000)]
        [TestCase(0, 1, 1)]
        [Test]
        public void TestTapeEqiilibrium(int expected, params int[] lst)
        {
            var pme = new TapeEqiuilibrium();
            Assert.AreEqual(expected, pme.solution(lst));

        }

        [TestCase(6, 5, 
                     1,
                     3,
                     1,
                     4,
                     2,
                     3,
                     5,
                     4)]
        public void TestFrogRiverOne(int expected, int X, params int[] A)
        {
            var frOne = new FrogRiverOne();
            Assert.AreEqual(expected, frOne.solution(X, A));
        }
        [TestCase("3,2,2,4,2", 5, 3, 4, 4, 6, 1, 4, 4)]
        [TestCase("0,0,0,0,0", 5, 6,6,6,6,6)]
        public void TestMaxCounter(string expectedCSV, int N, params int[]A)
        {
            var prob = new MaxCounter();
            
            var B = prob.solution(N,A);
            var E = ToIntArray(expectedCSV);
            Assert.AreEqual(E[0], B[0]);
            Assert.AreEqual(E[1], B[1]);
            Assert.AreEqual(E[2], B[2]);
            Assert.AreEqual(E[3], B[3]);
            Assert.AreEqual(E[4], B[4]);

        }

        [TestCase(5,3,6,4,1,2)]
        [TestCase(5, 3, 6, 4, 1, 2)]
        [TestCase(5,1, 3, 6, 4, 1, 2)]
        [TestCase(4, 1, 2, 3)]
        [TestCase(1,-1,-3)]
        
        public void TestMMissingInteger(int expected, params int[] A)
        {
            var sol = new MissingInteger();
            Assert.AreEqual(expected, sol.solution(A));


        }
        [TestCase(1,4,1,3,2)]
        [TestCase(0, 4, 1, 3)]
        [TestCase(1,1)]
        


        public void TestPermCheck(int expected, params int[] A)
        {
            var sol = new PermCheck();
            Assert.AreEqual(expected, sol.solution(A));
        }

        [TestCase(3, 6,11,2)]
        public void TestCountDiv(int expected, int A, int B, int K)
        {
            var prob = new CountDiv();
            Assert.AreEqual(expected, prob.solution(A, B, K));
        }

        [TestCase("2,4,1", "CAGCCTA","2,5,0", "4,5,6")]
        public void TestGenomicRangeQuery(string expectedStr, string S, string Pstr, string Qstr)
        {
            var prob = new GenomicRangeQuery();
            var expected = ToIntArray(expectedStr);
            var P = ToIntArray(Pstr);
            var Q = ToIntArray(Qstr);
            var retVal = prob.solution(S, P, Q);
            Assert.AreEqual(expected[0], retVal[0]);
            Assert.AreEqual(expected[1], retVal[1]);
            Assert.AreEqual(expected[2], retVal[2]);
            Assert.Inconclusive("Optimize More");
        }
        [TestCase("2,4,1", "CAGCCTACAGCCTA", "2,5,0", "4,5,6")]
        public void TestGenomicRangeQuery2(string expectedStr, string S, string Pstr, string Qstr)
        {
            var prob = new GenomicRangeQuery();
            var expected = ToIntArray(expectedStr);
            var P = ToIntArray(Pstr);
            var Q = ToIntArray(Qstr);
            var retVal = prob.solution(S, P, Q);
            Assert.AreEqual(expected[0], retVal[0]);
            Assert.AreEqual(expected[1], retVal[1]);
            Assert.AreEqual(expected[2], retVal[2]);      
        }

        [TestCase(1,
                  4,
                  2,
                  2,
                  5,
                  1,
                  5,
                  8
            )]
        public void TestMinAvgTwoSlices(int expected, params int[] A)
        {
            var prob = new MinAvgTwoSlice();
            Assert.AreEqual(expected, prob.solution(A));
        }

        [TestCase(5, 
                  0,
                  1,
                  0,
                  1,
                  1
            
            )]
        public void TestPassingCars(int expected, params int[] A)
        {
            var prob = new PassingCars();
            Assert.AreEqual(expected, prob.solution(A));
        }

        [TestCase(3,  2, 1 ,1, 2, 3, 1)]
        public void TestDistinct(int expected, params int[] A)
        {
            var prob = new Distinct();
            Assert.AreEqual(expected, prob.solution(A));
        }

        [TestCase(7, "aakmaakmakda")]
        [TestCase(1, "aaa")]
        [TestCase(2, "aaaa")]
        [TestCase(-1, "codility")]
        [TestCase(13, "goaagowerhhingo")]

        public void TestProblemOne(int expected, string S)
        {
            var prob = new SchneiderProblemOne();
            Assert.AreEqual(expected, prob.solution(S));

        }

        [TestCase(4,3,5,6,3,3,5)]
        [TestCase(1, 1,1)]
        [TestCase(0,1,2,3)]
        [TestCase(1,1,1,3)]
        public void TestProblemTwo(int expected, params int[] A)
        {
            var prob = new SchneiderProblemTwo();
            Assert.AreEqual(expected, prob.solution(A));

        }
    }
}