﻿using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;

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
        /// ArgumentOutOfRangeException - Thrown when the property is set to less than 0. Message: “The value cannot be less than 0.”
        /// Parameter Name: “value”
        public Accessories AccessoriesChosen
        {
            get { return this.accessoriesChosen; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                this.accessoriesChosen = value;
            }
        }

        /// <summary>
        /// Gets and sets the accessories that were chosen.
        /// </summary>
        /// System.ComponentModel.InvalidEnumArgumentException - Thrown when the property is set to an invalid value. Message: “The value is an invalid enumeration value”.
        public ExteriorFinish ExteriorFinishChosen
        {
            get { return this.exteriorFinishChosen; }
            set
            {
                if (Enum.IsDefined(typeof(ExteriorFinish), value))
                {
                    this.exteriorFinishChosen = value;
                }
                throw new System.ComponentModel.InvalidEnumArgumentException(
                    "The value is an invalid enumeration value"
                );
            }
        }

        /// <summary>
        ///  Gets the cost of accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {

                if (this.accessoriesChosen == Accessories.StereoSystem)
                {
                    return 505.05m;
                }
                else if (accessoriesChosen == Accessories.LeatherInterior)
                {
                    return 1010.10m;
                }
                else if (accessoriesChosen == Accessories.StereoAndLeather)
                {
                    return 1515.15m;
                }
                else if (accessoriesChosen == Accessories.ComputerNavigation)
                {
                    return 2020.20m;
                }
                else if (accessoriesChosen == Accessories.StereoAndNavigation)
                {
                    return 2525.25m;
                }
                else if (accessoriesChosen == Accessories.LeatherAndNavigation)
                {
                    return 3030.30m;
                }
                else if (accessoriesChosen == Accessories.All)
                {
                    return 4545.45m;
                }
                else // if (accessoriesChosen == Accessories.None)
                {
                    return 0;
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
        }

        /// <summary> Gets the sum of the cost of the chosen accessories and exterior finish (rounded to two decimal places). </summary>
        public decimal TotalOptions
        {
            get { return FinishCost + AccessoryCost; }
        }

        /// <summary>
        ///  Gets the sum of the vehicle’s sale price and the Accessory and Finish Cost (rounded to two decimal places).
        /// </summary>
        public decimal SubTotal
        {
            get { return VehicleSalePrice + TotalOptions; }
        }

        /// <summary>
        /// Gets the amount of tax to charge based on the subtotal (rounded to two decimal places).
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                if (this.salesTaxRate <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "The value cannot be less than or equal to 0."
                    );
                }
                return SubTotal * salesTaxRate;
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
            get { return Total - TradeInAmount; }
        }

        //             ArgumentOutOfRangeException - Thrown when the vehicle sale price is less than or equal to 0.Message: “The argument cannot be less than or equal to 0.” Parameter name: “vehicleSalePrice”.
        //             ArgumentOutOfRangeException - Thrown when the trade in amount is less than 0.Message: “The argument cannot be less than 0.” Parameter name: “tradeInAmount”.
        //            ArgumentOutOfRangeException - Thrown when the sales tax rate is less than 0.Message: “The argument cannot be less than 0.” Parameter name: “salesTaxRate”.
        //            ArgumentOutOfRangeException - Thrown when the sales tax rate is greater than 1.Message: “The argument cannot be greater than 1.” Parameter name: “salesTaxRate”.
        //             System.ComponentModel.InvalidEnumArgumentException - Thrown when the accessories chosen is an invalid argument.Message: “The argument is an invalid enumeration value”.
        //             System.ComponentModel.InvalidEnumArgumentException - Thrown when the exterior finish chosen is an invalid argument.Message: “The argument is an invalid enumeration value”.

        public SalesQuote(
            decimal vehicleSalePrice,
            decimal tradeInAmount,
            decimal salesTaxRate,
            Accessories accessoriesChosen,
            ExteriorFinish exteriorFinishChosen
        )
        {
            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be less than or equal to 0."
                );
                
            }
            this.vehicleSalePrice = vehicleSalePrice;

            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            this.tradeInAmount = tradeInAmount;

            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.");
            }
            this.salesTaxRate = salesTaxRate;

                
            if (!Enum.IsDefined(typeof(Accessories), accessoriesChosen))
            {
                throw new System.ComponentModel.InvalidEnumArgumentException(
                    "The argument is an invalid enumeration value"
                );
            }

            this.accessoriesChosen = accessoriesChosen;

            if ( 

                !Enum.IsDefined(typeof(ExteriorFinish), exteriorFinishChosen))
            {
                throw new System.ComponentModel.InvalidEnumArgumentException(
                    "The argument is an invalid enumeration value"
                );
            }
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        //        ArgumentOutOfRangeException - Thrown when the vehicle sale price is less than or equal to 0.Message: “The argument cannot be less than or equal to 0.” Parameter name: “vehicleSalePrice”.
        //ArgumentOutOfRangeException - Thrown when the trade in amount is less than 0.Message: “The argument cannot be less than 0.” Parameter name: “tradeInAmount”.
        //ArgumentOutOfRangeException - Thrown when the sales tax rate is less than 0.Message: “The argument cannot be less than 0.” Parameter name: “salesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the sales tax rate is greater than 1.Message: “The argument cannot be greater than 1.” Parameter name: “salesTaxRate”.

        public SalesQuote(decimal vehicleSalePrice, decimal tradeInAmount, decimal salesTaxRate)
        {
            exteriorFinishChosen = ExteriorFinish.None;
            accessoriesChosen = Accessories.None;

            if (vehicleSalePrice <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    "The argument cannot be less than or equal to 0."
                );
            }
            this.vehicleSalePrice = vehicleSalePrice;


            if (tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            this.tradeInAmount = tradeInAmount;

            if (salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }

            if (salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.");
            }

            this.salesTaxRate = salesTaxRate;

        }
    }
}
