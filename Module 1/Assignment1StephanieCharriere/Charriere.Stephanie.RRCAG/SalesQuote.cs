using System;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Charreire.Stephanie.Business
{
    /// <summary> This class contains functionality that supports the business process of determining a quote for the sale of a vehicle. </summary>
    public class SalesQuote
    {
        //Fields
        // The selling price of the vehicle being sold.
        private decimal vehicleSalePrice;

        // The amount offered to the customer for the trade in of their vehicle.
        private decimal tradeInAmount;

        // The tax rate applied to the sale of a vehicle.
        private decimal salesTaxRate;

        // The chosen accessories.
        private Accessories accessoriesChosen;

        // The chosen exterior finish.
        private ExteriorFinish exteriorFinishChosen;

        //constructors
        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in value, sales tax rate, accessories chosen and exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish.</param>
        public SalesQuote(
            decimal vehicleSalePrice,
            decimal tradeInAmount,
            decimal salesTaxRate,
            Accessories accessoriesChosen,
            ExteriorFinish exteriorFinishChosen
        )
        {
            this.vehicleSalePrice = vehicleSalePrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price, trade-in amount, sales tax rate, no accessories chosen and no exterior finish chosen.
        /// </summary>
        /// <param name="vehicleSalePrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">he tax rate applied to the sale of a vehicle.</param>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
        {
            this.SetVehicleSalesPrice(vehicleSalePrice);
            this.SetTradeInAmount(tradeInAmount);
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = Accessories.None;
            this.exteriorFinishChosen = ExteriorFinish.None;
        }

        /// <summary>
        /// Gets the sale price of the vehicle.
        /// </summary>
        /// <returns></returns>
        public decimal GetVehicleSalePrice()
        {
            return this.vehicleSalePrice;
        }

        /// <summary>
        /// Sets the sale price of the vehicle
        /// </summary>
        /// <param name="vehicleSalePrice">the selling price of the vehicle.</param>
        public void SetVehicleSalesPrice(decimal vehicleSalePrice)
        {
            this.vehicleSalePrice = vehicleSalePrice;
        }

        /// <summary>
        ///  Gets the trade in amount.
        /// </summary>
        /// <returns></returns>
        public decimal GetTradeInAmount()
        {
            return this.tradeInAmount;
        }

        /// <summary>
        /// Sets the trade in amount.
        /// </summary>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        public void SetTradeInAmount(decimal tradeInAmount)
        {
            this.tradeInAmount = tradeInAmount;
        }

        /// <summary>
        /// Gets the accessories chosen for the vehicle.
        /// </summary>
        /// <returns></returns>
        public Accessories GetAccessoriesChosen()
        {
            return this.accessoriesChosen;
        }

        /// <summary>
        /// Sets the accessories chosen for the vehicle.
        /// </summary>
        /// <param name="accessoriesChosen"> The chosen accessories.</param>
        public void SetAccessoriesChosen(Accessories accessoriesChosen)
        {
            this.accessoriesChosen = accessoriesChosen;
        }

        /// <summary>
        ///  Gets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <returns></returns>
        public ExteriorFinish GetExteriorFinishChosen()
        {
            return this.exteriorFinishChosen;
        }

        /// <summary>
        /// Sets the exterior finish chosen for the vehicle.
        /// </summary>
        /// <param name="exteriorFinishChosen"> The chosen exterior finish.</param>
        public void SetExteriorFinishChosen(ExteriorFinish exteriorFinishChosen)
        {
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Returns the cost of the accessories chosen.
        /// </summary>
        /// <returns></returns>
        public decimal GetAccessoriesCost()
        {
            decimal StereoSystem = 505.05M;
            decimal LeatherInterior = 1010.10M;
            decimal ComputerNavigation = 1515.15M;

            if (accessoriesChosen == Accessories.StereoSystem)
            {
                return StereoSystem;
            }
            else if (accessoriesChosen == Accessories.LeatherInterior)
            {
                return LeatherInterior;
            }
            else if (accessoriesChosen == Accessories.ComputerNavigation)
            {
                return ComputerNavigation;
            }
            else if (accessoriesChosen == Accessories.StereoAndLeather)
            {
                return StereoSystem + LeatherInterior;
            }
            else if (accessoriesChosen == Accessories.StereoAndNavigation)
            {
                return StereoSystem + ComputerNavigation;
            }
            else if (accessoriesChosen == Accessories.LeatherAndNavigation)
            {
                return LeatherInterior + ComputerNavigation;
            }
            else if (accessoriesChosen == Accessories.All)
            {
                return StereoSystem + LeatherInterior + ComputerNavigation;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Returns the cost of the exterior finish chosen.
        /// </summary>
        /// <returns></returns>
        public decimal GetExteriorFinishCost()
        {
            decimal standard = 202.02M;
            decimal pearlized = 404.04M;
            decimal custom = 606.06M;

            if (exteriorFinishChosen == ExteriorFinish.Standard)
            {
                return standard;
            }
            else if (exteriorFinishChosen == ExteriorFinish.Pearlized)
            {
                return pearlized;
            }
            else if (exteriorFinishChosen == ExteriorFinish.Custom)
            {
                return custom;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Return the sum of the cost of accessories chosen and the cost of the exterior finish chosen (rounded to two decimal places).
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalOptions()
        {
            return this.GetAccessoriesCost() + this.GetExteriorFinishCost();
        }

        /// <summary>
        /// Returns the sum of the vehicle’s sale price, accessories and exterior finish costs (rounded to two decimal places).
        /// </summary>
        /// <returns></returns>
        public decimal GetSubTotal()
        {
            return this.GetVehicleSalePrice()
                + this.GetAccessoriesCost()
                + this.GetExteriorFinishCost();
        }

        /// <summary>
        /// Returns the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        /// <returns></returns>
        public decimal GetSalesTax()
        {
            return this.salesTaxRate * this.GetSubTotal();
        }

        /// <summary>
        /// decimal - Returns the sum of the subtotal and taxes.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotal()
        {
            decimal total = (this.GetSubTotal() + this.GetSalesTax());

            return total;
        }

        /// <summary>
        ///  Returns the difference of the total and trade-in amount (rounded to two decimal places).
        /// </summary>
        /// <returns></returns>
        public decimal GetAmountDue()
        {
            return this.GetTotal() - this.GetTradeInAmount();
        }
    }
}
