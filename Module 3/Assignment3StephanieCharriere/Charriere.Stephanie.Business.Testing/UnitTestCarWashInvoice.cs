using System;
using Charriere.Stephanie.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Charriere.Stephanie.Business.Testing
{
    [TestClass]
    public class UnitTestInvoice
    {
        //   public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        [TestMethod]
        public void Constructor_ProvincialSalesTaxRate_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            PrivateObject privateInvoice = new PrivateObject(
                carWashInvoice,
                new PrivateType(typeof(Invoice))
            );

            decimal expectedProvincialSalesTaxRate = 0.1M;
            decimal actualProvincialSalesTaxRate = (decimal)
                privateInvoice.GetField("provincialSalesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void Constructor_GoodsAndServicesTaxRate_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            PrivateObject privateInvoice = new PrivateObject(
                carWashInvoice,
                new PrivateType(typeof(Invoice))
            );

            decimal expectedGoodsAndServicesTaxRate = 0.2M;
            decimal actualGoodsAndServicesTaxRate = (decimal)
                privateInvoice.GetField("goodsAndServicesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void GetProvincialSalesTaxRate_Method_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            decimal expectedProvincialSalesTaxRate = 0.1M;
            decimal actualProvincialSalesTaxRate = carWashInvoice.ProvincialSalesTaxRate;

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_Method_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            carWashInvoice.ProvincialSalesTaxRate = 0.5M;

            decimal expectedProvincialSalesTaxRate = 0.5M;
            decimal actualProvincialSalesTaxRate = carWashInvoice.ProvincialSalesTaxRate;

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void SetProvincialSalesTax_LessThanZero_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            try
            {
                carWashInvoice.ProvincialSalesTaxRate = -0.5M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);

                decimal expectedProvincialSalesTaxRate = 0.1M;
                decimal actualProvincialSalesTaxRate = carWashInvoice.ProvincialSalesTaxRate;
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_GreaterThanOne_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                carWashInvoice.ProvincialSalesTaxRate = 5M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);

                decimal expectedProvincialSalesTaxRate = 0.1M;
                decimal actualProvincialSalesTaxRate = carWashInvoice.ProvincialSalesTaxRate;
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void GetGoodsAndServicesTaxRate_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                decimal expected = 0.2M;
                decimal actual = carWashInvoice.GoodsAndServicesTaxRate;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Caught unexpected Error: " + error.Message);
            }
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_LessThenZero_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                carWashInvoice.GoodsAndServicesTaxRate = -5M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);

                decimal expected = 0.2M;
                decimal actual = carWashInvoice.GoodsAndServicesTaxRate;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_GreaterThanOne_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                carWashInvoice.GoodsAndServicesTaxRate = 5M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);

                decimal expected = 0.2M;
                decimal actual = carWashInvoice.GoodsAndServicesTaxRate;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_Valid_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                carWashInvoice.GoodsAndServicesTaxRate = 0.12M;

                decimal expected = 0.12M;
                decimal actual = carWashInvoice.GoodsAndServicesTaxRate;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception", error);
            }
        }

        // total

        [TestMethod]
        public void GetTotal_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;
            decimal packageCost = 100M;
            decimal fragranceCost = 50M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );
            try
            {
                decimal expected = 180M;
                decimal actual = carWashInvoice.Total;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception", error);
            }
        }
    }

    [TestClass]
    public class UnitTestCarWashInvoice
    {
        [TestMethod]
        public void Constructor_PackageCost_InitializeDefault()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 1M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            PrivateObject target = new PrivateObject(carWashInvoice);

            decimal expectedPackageCost = 0M;
            decimal actualPackageCost = (decimal)target.GetField("packageCost");

            try
            {
                //  Assert
                Assert.AreEqual(expectedPackageCost, actualPackageCost);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void Constructor_FragranceCost_InitializeDefault()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 1M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );

            PrivateObject target = new PrivateObject(carWashInvoice);

            decimal expectedFragranceCost = 0M;
            decimal actualFragranceCost = (decimal)target.GetField("fragranceCost");

            try
            {
                //  Assert
                Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_ProvincialSalesTaxRate_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            PrivateObject privateInvoice = new PrivateObject(
                carWashInvoice,
                new PrivateType(typeof(Invoice))
            );

            decimal expectedProvincialSalesTaxRate = 0.1M;
            decimal actualProvincialSalesTaxRate = (decimal)
                privateInvoice.GetField("provincialSalesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_GoodsAndServicesTaxRate_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            PrivateObject privateInvoice = new PrivateObject(
                carWashInvoice,
                new PrivateType(typeof(Invoice))
            );

            decimal expectedProvincialSalesTaxRate = 0M;
            decimal actualProvincialSalesTaxRate = (decimal)
                privateInvoice.GetField("goodsAndServicesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_PackageCost_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            PrivateObject privateInvoice = new PrivateObject(carWashInvoice);

            decimal expectedProvincialSalesTaxRate = 1M;
            decimal actualProvincialSalesTaxRate = (decimal)privateInvoice.GetField("packageCost");

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_FragranceCost_Initialize()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            PrivateObject privateInvoice = new PrivateObject(carWashInvoice);

            decimal expectedProvincialSalesTaxRate = 2M;
            decimal actualProvincialSalesTaxRate = (decimal)
                privateInvoice.GetField("fragranceCost");

            try
            {
                //  Assert
                Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        // Properties

        [TestMethod]
        public void GetPackageCost_Valid_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            decimal expected = 1M;
            decimal actual = carWashInvoice.PackageCost;

            try
            {
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void SetPackageCost_LessThanZero_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            try
            {
                carWashInvoice.PackageCost = -1M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                decimal expected = 1M;
                decimal actual = carWashInvoice.PackageCost;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void SetPackageCost_Valid_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            try
            {
                carWashInvoice.PackageCost = 10M;

                decimal expected = 10M;
                decimal actual = carWashInvoice.PackageCost;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFragranceCost_LessThanZero_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            try
            {
                carWashInvoice.FragranceCost = -1M;

                Assert.Fail("Should have thrown exception");
            }
            catch (ArgumentOutOfRangeException error)
            {
                decimal expected = 2M;
                decimal actual = carWashInvoice.FragranceCost;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void SetFragranceCost_Valid_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );

            try
            {
                carWashInvoice.FragranceCost = 10M;

                decimal expected = 10M;
                decimal actual = carWashInvoice.FragranceCost;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception: " + error.Message);
            }
        }

        [TestMethod]
        public void GetProvincialSalesTaxCharged_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                decimal expected = 0.0M; // default return value
                decimal actual = carWashInvoice.ProvincialSalesTaxCharged;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void GetSubTotal_DefaultValue_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0.2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate
            );
            try
            {
                var a = carWashInvoice.PackageCost;
                var b = carWashInvoice.FragranceCost;

                decimal expected = 0.0M;
                decimal actual = carWashInvoice.SubTotal;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }

        [TestMethod]
        public void GetSubTotal_Value_Test()
        {
            //  Arrange
            decimal provincialSalesTaxRate = 0.1M;
            decimal goodsAndServicesTaxRate = 0;
            decimal packageCost = 1M;
            decimal fragranceCost = 2M;

            //  Act
            CarWashInvoice carWashInvoice = new CarWashInvoice(
                provincialSalesTaxRate,
                goodsAndServicesTaxRate,
                packageCost,
                fragranceCost
            );
            try
            {
                var a = carWashInvoice.PackageCost;
                var b = carWashInvoice.FragranceCost;

                decimal expected = 3.0M;
                decimal actual = carWashInvoice.SubTotal;
                //  Assert
                Assert.AreEqual(expected, actual);
            }
            catch (Exception error)
            {
                Assert.Fail("Should not have thrown exception" + error);
            }
        }
    }
}
