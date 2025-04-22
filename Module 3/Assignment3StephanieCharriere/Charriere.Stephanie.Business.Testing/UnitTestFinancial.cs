using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Charriere.Stephanie.Business.Testing
{
    [TestClass]
    public class UnitTestFinancial
    {
        [TestMethod]
        public void Rate_LessThanZero_ErrorThrown()
        {
            //  Arrange
            decimal rate = -0.05m;
            int numberOfPaymentPeriods = 12;
            decimal presentValue = 1000;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be less than 0.\r\nParameter name: rate";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void Rate_GreaterThanOne_ErrorThrown()
        {  //  Arrange
            decimal rate = 1.05m;
            int numberOfPaymentPeriods = 12;
            decimal presentValue = 1000;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be greater than 1.\r\nParameter name: rate";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void NumberOfPaymentPeriods_LessThanZero_ErrorThrown()
        {
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = -12;
            decimal presentValue = 1000;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Should have thrown error.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be less than or equal to 0.\r\nParameter name: numberOfPaymentPeriods";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void NumberOfPaymentPeriods_Zero_ErrorThrown() {
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = 0;
            decimal presentValue = 1000;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Should have thrown error.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be less than or equal to 0.\r\nParameter name: numberOfPaymentPeriods";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void PresentValue_LessThanZero_ErrorThrown() {
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = -1000;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Should have thrown error.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be less than or equal to 0.\r\nParameter name: presentValue";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void PresentValue_Zero_ErrorThrown() {
            decimal rate = 0.05m;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 0;
            //  Act

            try
            {
                Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.Fail("Should have thrown error.");

            }
            catch (ArgumentOutOfRangeException e)
            {
                string expected = "The argument cannot be less than or equal to 0.\r\nParameter name: presentValue";
                //  Assert
                Assert.AreEqual(expected, e.Message);
            }
        }
        [TestMethod]
        public void GetPayment_RateEqualsZero_Test() {
            decimal rate = 0;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 1000;
            //  Act

            try
            {

                decimal expected = 100;
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.AreEqual(expected, actual);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail("No errors should have been thrown. " + e);

            }
        }
        [TestMethod]
        public void GetPayment_RateValid_Test()
        {
            decimal rate = 0.5M;
            int numberOfPaymentPeriods = 10;
            decimal presentValue = 1000;
            //  Act

            try
            {

                decimal expected = 508.82M;
                decimal actual = Financial.GetPayment(rate, numberOfPaymentPeriods, presentValue);
                Assert.AreEqual(expected, actual);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Fail("No errors should have been thrown. " + e);

            }
        }
    }
}
