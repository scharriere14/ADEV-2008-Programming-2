using System;
using System.ComponentModel;

namespace Charriere.Stephanie.Business
{
    public class SalesQuote
    {
        private decimal vehicleSalePrice;
        private decimal tradeInAmount;
        private decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        // Properties

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
        /// <param name="value">The value of the vehicle sale price.</param>"
        /// <exception cref=" ArgumentOutOfRangeException">Thrown when the property is set to less than or equal to 0.</exception>
        public decimal VehicleSalePrice
        {
            get { return this.vehicleSalePrice; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "The value cannot be less than or equal to 0."
                    );
                }
                this.vehicleSalePrice = value;
            }
        }

        /// <summary>
        /// Gets and sets the trade in amount.
        /// </summary>
        /// ArgumentOutOfRangeException - Thrown when the property is set to less than 0. Message: “The value cannot be less than 0.”
        /// Parameter Name: “value”
        public decimal TradeInAmount
        {
            get { return this.tradeInAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                this.tradeInAmount = value;
            }
        }

        /// <summary>  Gets and sets the accessories that were chosen.
        /// </summary>
        public Accessories AccessoriesChosen
        {
            get { return this.accessoriesChosen; }
            set
            {
                if (!Enum.IsDefined(typeof(Accessories), value))
                {
                    throw new InvalidEnumArgumentException(
                        "The value is an invalid enumeration value"
                    );
                }
                this.accessoriesChosen = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        public ExteriorFinish ExteriorFinishChosen
        {
            get { return this.exteriorFinishChosen; }
            set
            {
                if (Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    this.exteriorFinishChosen = value;
                }
                else
                {
                    throw new System.ComponentModel.InvalidEnumArgumentException(
                        "The value is an invalid enumeration value"
                    );
                }
            }
        }

        /// <summary>
        ///  Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal stereoSystem = 505.05M;
                decimal leatherInterior = 1010.10M;
                decimal computerNavigation = 2020.20M;
                decimal none = 0;

                if (this.accessoriesChosen == Accessories.StereoSystem)
                {
                    return stereoSystem;
                }
                else if (accessoriesChosen == Accessories.LeatherInterior)
                {
                    return leatherInterior;
                }
                else if (accessoriesChosen == Accessories.StereoAndLeather)
                {
                    return stereoSystem + leatherInterior;
                }
                else if (accessoriesChosen == Accessories.ComputerNavigation)
                {
                    return computerNavigation;
                }
                else if (accessoriesChosen == Accessories.StereoAndNavigation)
                {
                    return stereoSystem + computerNavigation;
                }
                else if (accessoriesChosen == Accessories.LeatherAndNavigation)
                {
                    return leatherInterior + computerNavigation;
                }
                else if (accessoriesChosen == Accessories.All)
                {
                    return stereoSystem + leatherInterior + computerNavigation;
                }
                else 
                {
                    return none;
                }
            }
        }

        public decimal FinishCost
        {
            get
            {
                decimal standard = 202.02M;
                decimal pearlized = 404.04M;
                decimal custom = 606.06M;
                decimal none = 0;

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
                    return none;
                }
            }
        }

        /// <summary> Gets the sum of the cost of the chosen accessories and exterior finish (rounded to two decimal places). </summary>
        public decimal TotalOptions
        {
            get { return Math.Round(FinishCost + AccessoryCost, 2); }
        }

        /// <summary>
        ///  Gets the sum of the vehicle’s sale price and the Accessory and Finish Cost (rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get { return Math.Round(VehicleSalePrice + TotalOptions, 2); }
        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        public decimal SalesTax
        {
            get
            {

                return Math.Round(SubTotal * salesTaxRate, 2) ;
            }
        }

        /// <summary>
        /// Gets the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get { return SalesTax + SubTotal; }
        }

        /// <summary>
        /// Gets the result of subtracting the trade-in amount from the total (rounded to two decimal places).
        /// </summary>
        public decimal AmountDue
        {
            get { return Math.Round(Total - TradeInAmount, 2); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesQuote"/> class with all parameters specified.
        /// </summary>
        /// <param name="vehicleSalePrice">The sale price of the vehicle. Must be greater than 0.</param>
        /// <param name="tradeInAmount">The trade-in value of the vehicle. Must be 0 or greater.</param>
        /// <param name="salesTaxRate">The applicable sales tax rate as a decimal (e.g., 0.07 for 7%).</param>
        /// <param name="accessoriesChosen">The selected accessories for the vehicle.</param>
        /// <param name="exteriorFinishChosen">The chosen exterior finish.</param>
        /// <exception cref="InvalidEnumArgumentException">
        /// Thrown when <paramref name="vehicleSalePrice"/> is less than or equal to 0,
        /// or when <paramref name="tradeInAmount"/> is less than 0.
        /// </exception>
        public SalesQuote(
            decimal vehicleSalePrice,
            decimal tradeInAmount,
            decimal salesTaxRate,
            Accessories accessoriesChosen,
            ExteriorFinish exteriorFinishChosen
        )
        {
            this.VehicleSalePrice = vehicleSalePrice;

            this.TradeInAmount = tradeInAmount;

            this.salesTaxRate = salesTaxRate;

            this.AccessoriesChosen = accessoriesChosen;

            this.ExteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesQuote"/> class with basic parameters, 
        /// defaulting accessories and exterior finish to <see cref="Accessories.None"/> and <see cref="ExteriorFinish.None"/>.
        /// </summary>
        /// <param name="vehicleSalePrice">The sale price of the vehicle. Must be greater than 0.</param>
        /// <param name="tradeInAmount">The trade-in value of the vehicle. Must be 0 or greater.</param>
        /// <param name="salesTaxRate">The applicable sales tax rate as a decimal (e.g., 0.07 for 7%).</param>
        /// <exception cref="InvalidEnumArgumentException">
        /// Thrown when <paramref name="vehicleSalePrice"/> is less than or equal to 0,
        /// or when <paramref name="tradeInAmount"/> is less than 0.
        /// </exception>
        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
        {
            exteriorFinishChosen = ExteriorFinish.None;
            accessoriesChosen = Accessories.None;

            this.VehicleSalePrice = vehicleSalePrice;

            this.TradeInAmount = tradeInAmount;

            this.salesTaxRate = salesTaxRate;
        }
    }
}
