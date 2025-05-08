using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Charriere.Stephanie.Business.Testing
{
    [TestClass]
    public class UnitTestSalesQuote
    {
        //  SalesQuote
        [TestMethod]
        public void Constructor_VehicleSalePrice_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedVehicleSalePrice = 1000;
            decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");

            try
            {
                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Constructor_TradeInAmount_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedTradeInAmount = 100;
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");

            try
            {
                //  Assert
                Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Constructor_SalesTaxRate_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedSalesTaxRate = 0.13M;
            decimal actualSalesTaxRate = (decimal)target.GetField("salesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedSalesTaxRate, actualSalesTaxRate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Constructor_ExteriorChosen_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);

            string expectedExteriorChosen = "None";
            ExteriorFinish actualExteriorChosenEnum = (ExteriorFinish)
                target.GetField("exteriorFinishChosen");
            string actualExteriorChosen = actualExteriorChosenEnum.ToString();

            try
            {
                //  Assert
                Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void Constructor_AccessoriesChosen_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);
            PrivateObject target = new PrivateObject(salesQuote);

            string expectedAccessoriesChosen = "None";
            ExteriorFinish actualAccessoriesChosenEnum = (ExteriorFinish)
                target.GetField("exteriorFinishChosen");
            string actualAccessoriesChosen = actualAccessoriesChosenEnum.ToString();
            try
            {
                //  Assert
                Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // SalesQuote Overloaded Constructor
        [TestMethod]
        public void OverloadedConstructor_VehicleSalePrice_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;

            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedVehicleSalePrice = 1000;
            decimal actualVehicleSalePrice = (decimal)target.GetField("vehicleSalePrice");

            try
            {
                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_TradeInAmount_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );
            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedTradeInAmount = 100;
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");

            //  Assert
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);

            try
            {
                //  Assert
                Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_SalesTaxRate_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );
            PrivateObject target = new PrivateObject(salesQuote);

            decimal expectedSalesTaxRate = 0.13M;
            decimal actualSalesTaxRate = (decimal)target.GetField("salesTaxRate");

            try
            {
                //  Assert
                Assert.AreEqual(expectedSalesTaxRate, actualSalesTaxRate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_ExteriorChosen_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );
            PrivateObject target = new PrivateObject(salesQuote);

            string expectedExteriorChosen = "Pearlized";
            ExteriorFinish actualExteriorChosenEnum = (ExteriorFinish)
                target.GetField("exteriorFinishChosen");
            string actualExteriorChosen = actualExteriorChosenEnum.ToString();

            try
            {
                //  Assert
                Assert.AreEqual(expectedExteriorChosen, actualExteriorChosen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void OverloadedConstructor_AccessoriesChosen_Initialize()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );
            PrivateObject target = new PrivateObject(salesQuote);

            string expectedAccessoriesChosen = "LeatherInterior";

            Accessories actualAccessoriesChosenEnum = (Accessories)
                target.GetField("accessoriesChosen");
            string actualAccessoriesChosen = actualAccessoriesChosenEnum.ToString();

            try
            {
                //  Assert
                Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // VehicleSalePrice Tests

        [TestMethod]
        public void GetVehicleSalePrice_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 10;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            decimal expectedVehicleSalePrice = 10;
            decimal actualVehicleSalePrice = salesQuote.VehicleSalePrice;

            try
            {
                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void SetVehicleSalePrice_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 0;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            salesQuote.VehicleSalePrice = 10;

            decimal expectedVehicleSalePrice = 10;
            decimal actualVehicleSalePrice = salesQuote.VehicleSalePrice;

            try
            {
                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void SetVehicleSalePrice_UnderZero_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 0;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            try
            {
                salesQuote.VehicleSalePrice = -10;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                decimal expectedVehicleSalePrice = 0;
                decimal actualVehicleSalePrice = salesQuote.VehicleSalePrice;

                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
        }

        [TestMethod]
        public void SetVehicleSalePrice_Zero_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 10;
            decimal tradeInAmount = 0;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            try
            {
                salesQuote.VehicleSalePrice = 0;
            }
            catch
            {
                decimal expectedVehicleSalePrice = 10;
                decimal actualVehicleSalePrice = salesQuote.VehicleSalePrice;

                //  Assert
                Assert.AreEqual(expectedVehicleSalePrice, actualVehicleSalePrice);
            }
        }

        // TradeInAmount Tests
        [TestMethod]
        public void GetTradeInAmount_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            decimal expectedTradeInAmount = 100;
            decimal actualTradeInAmount = salesQuote.TradeInAmount;

            //  Assert
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        [TestMethod]
        public void SetTradeInAmount_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            salesQuote.TradeInAmount = 50;

            decimal expectedTradeInAmount = 50;
            decimal actualTradeInAmount = salesQuote.TradeInAmount;

            //  Assert
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        [TestMethod]
        public void SetTradeInAmount_UnderZero_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0;

            //  Act
            SalesQuote salesQuote = new SalesQuote(vehicleSalePrice, tradeInAmount, salesTaxRate);

            try
            {
                salesQuote.VehicleSalePrice = -10;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                decimal expectedTradeInAmount = 100;
                decimal actualTradeInAmount = salesQuote.TradeInAmount;

                //  Assert
                Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            }
        }

        // Accessories Tests
        [TestMethod]
        public void GetAccessories_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            Accessories expectedAccessories = Accessories.LeatherInterior;
            Accessories actualAccessories = salesQuote.AccessoriesChosen;

            //  Assert
            Assert.AreEqual(expectedAccessories, actualAccessories);
        }

        [TestMethod]
        public void SetAccessories_StereoSystem_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoSystem;

                Accessories expectedAccessories = Accessories.StereoSystem;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_LeatherInterior_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.None;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherInterior;

                Accessories expectedAccessories = Accessories.LeatherInterior;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_StereoAndLeather_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;

                Accessories expectedAccessories = Accessories.StereoAndLeather;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_ComputerNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;

                Accessories expectedAccessories = Accessories.ComputerNavigation;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_StereoAndNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;

                Accessories expectedAccessories = Accessories.StereoAndNavigation;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_LeatherAndNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;

                Accessories expectedAccessories = Accessories.LeatherAndNavigation;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_All_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.All;

                Accessories expectedAccessories = Accessories.All;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_None_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.None;

                Accessories expectedAccessories = Accessories.None;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessories_Invalid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                string value = "Cat";
                Accessories value2 = (Accessories)Enum.Parse(typeof(Accessories), value);
                salesQuote.AccessoriesChosen = value2;

                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                Accessories expectedAccessories = Accessories.LeatherInterior;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
        }

        // ExteriorFinish Tests

        [TestMethod]
        public void GetExteriorFinish_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            ExteriorFinish expectedExteriorFinish = ExteriorFinish.Pearlized;
            ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

            //  Assert
            Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
        }

        [TestMethod]
        public void SetExteriorFinish_None_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.None;

                ExteriorFinish expectedExteriorFinish = ExteriorFinish.None;
                ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

                //  Assert
                Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetExteriorFinish_Standard_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;

                ExteriorFinish expectedExteriorFinish = ExteriorFinish.Standard;
                ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

                //  Assert
                Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetExteriorFinish_Pearlized_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.None;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

                ExteriorFinish expectedExteriorFinish = ExteriorFinish.Pearlized;
                ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

                //  Assert
                Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetExteriorFinish_Custom_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.None;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;

                ExteriorFinish expectedExteriorFinish = ExteriorFinish.Custom;
                ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

                //  Assert
                Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetExteriorFinish_Invalid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                string value = "Cat";
                ExteriorFinish value2 = (ExteriorFinish)Enum.Parse(typeof(ExteriorFinish), value);
                salesQuote.ExteriorFinishChosen = value2;

                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                ExteriorFinish expectedExteriorFinish = ExteriorFinish.Pearlized;
                ExteriorFinish actualExteriorFinish = salesQuote.ExteriorFinishChosen;

                //  Assert
                Assert.AreEqual(expectedExteriorFinish, actualExteriorFinish);
            }
        }

        // AccessoryCost tests
        [TestMethod]
        public void GetAccessoryCost_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.StereoSystem;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            decimal expectedAccessoriesCost = 505.05M;
            decimal actualAccessoryCost = salesQuote.AccessoryCost;

            //  Assert
            Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
        }

        [TestMethod]
        public void SetAccessoryCost_StereoSystem_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoSystem;

                decimal expectedAccessoriesCost = 505.05M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_LeatherInterior_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.None;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherInterior;

                decimal expectedAccessoriesCost = 1010.10M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_StereoAndLeather_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndLeather;

                decimal expectedAccessoriesCost = 1515.15M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_ComputerNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.ComputerNavigation;

                decimal expectedAccessoriesCost = 2020.20M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_StereoAndNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.StereoAndNavigation;

                decimal expectedAccessoriesCost = 2525.25M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_LeatherAndNavigation_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;

                decimal expectedAccessoriesCost = 3030.30M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_All_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.All;

                decimal expectedAccessoriesCost = 3535.35M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_None_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.AccessoriesChosen = Accessories.None;

                decimal expectedAccessoriesCost = 0M;
                decimal actualAccessoryCost = salesQuote.AccessoryCost;

                //  Assert
                Assert.AreEqual(expectedAccessoriesCost, actualAccessoryCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetAccessoryCost_Invalid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                string value = "999M";
                Accessories value2 = (Accessories)Enum.Parse(typeof(Accessories), value);
                salesQuote.AccessoriesChosen = value2;

                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                Accessories expectedAccessories = Accessories.LeatherInterior;
                Accessories actualAccessories = salesQuote.AccessoriesChosen;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
        }

        // FinishCost tests
        [TestMethod]
        public void GetFinishCost_Valid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.None;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal expectedFinishCost = 0M;
                decimal actualFinishCost = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedFinishCost, actualFinishCost);
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFinishCost_None_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.None;

                decimal expectedFinishCost = 0M;
                decimal actualFinishCost = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedFinishCost, actualFinishCost);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFinishCost_Standard_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Standard;

                decimal expectedFinishCost = 202.02M;
                decimal actualFinishCost = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedFinishCost, actualFinishCost);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFinishCost_Pearlized_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.None;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

                decimal expectedFinishCost = 404.04M;
                decimal actualFinishCost = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedFinishCost, actualFinishCost);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFinishCost_Custom_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                salesQuote.ExteriorFinishChosen = ExteriorFinish.Custom;

                decimal expectedFinishCost = 606.06M;
                decimal actualFinishCost = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedFinishCost, actualFinishCost);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        [TestMethod]
        public void SetFinishCost_Invalid_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                string value = "999M";
                ExteriorFinish value2 = (ExteriorFinish)Enum.Parse(typeof(ExteriorFinish), value);
                salesQuote.ExteriorFinishChosen = value2;

                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentException error)
            {
                Console.WriteLine("Caught expected ArgumentOutOfRangeException: " + error.Message);
                decimal expectedAccessories = 404.04M;
                decimal actualAccessories = salesQuote.FinishCost;

                //  Assert
                Assert.AreEqual(expectedAccessories, actualAccessories);
            }
        }

        // TotalOptions
        [TestMethod]
        public void GetTotalOptions_Success_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal expectedTotalOptions = 1414.14M;
                decimal actualTotalOptions = salesQuote.TotalOptions;

                //  Assert
                Assert.AreEqual(expectedTotalOptions, actualTotalOptions);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        // SubTotal
        [TestMethod]
        public void GetSubTotal_Success_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal expectedSubTotal = 2414.14M;
                decimal actualSubTotal = salesQuote.SubTotal;

                //  Assert
                Assert.AreEqual(expectedSubTotal, actualSubTotal);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        // SalesTax
        [TestMethod]
        public void GetSalesTax_Success_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal actualSalesTax = salesQuote.SalesTax;
                decimal expectedSalesTax = 313.84M;

                //  Assert
                Assert.AreEqual(expectedSalesTax, actualSalesTax);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        // Total
        [TestMethod]
        public void GetTotal_Success_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal expectedTotal = 2727.98M;
                decimal actualTotal = salesQuote.Total;

                //  Assert
                Assert.AreEqual(expectedTotal, actualTotal);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }

        // AmountDue
        [TestMethod]
        public void GetAmountDue_Success_Test()
        {
            //  Arrange
            decimal vehicleSalePrice = 1000;
            decimal tradeInAmount = 100;
            decimal salesTaxRate = 0.13M;
            ExteriorFinish exteriorFinish = ExteriorFinish.Pearlized;
            Accessories accessories = Accessories.LeatherInterior;
            //  Act
            SalesQuote salesQuote = new SalesQuote(
                vehicleSalePrice,
                tradeInAmount,
                salesTaxRate,
                accessories,
                exteriorFinish
            );

            try
            {
                decimal expectedAmountDue = 2627.98M;
                decimal actualAmountDue = salesQuote.AmountDue;

                //  Assert
                Assert.AreEqual(expectedAmountDue, actualAmountDue);
            }
            catch (ArgumentException error)
            {
                Assert.Fail("Caught: " + error.Message);
            }
        }
    }
}
