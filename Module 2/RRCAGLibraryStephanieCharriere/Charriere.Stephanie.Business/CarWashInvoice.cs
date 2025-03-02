using System;

namespace Charriere.Stephanie.Business
{
    /// <summary>
    /// This class contains functionality that supports the business process of creating an invoice for the car wash department.
    /// The CarWashInvoice class derives from the Invoice class.
    /// </summary>
    class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        /// <param name="value">The value of the Package Cost</param>"
        /// <exception cref=" ArgumentOutOfRangeException">Thrown when the property is set to less than or greater than 0.</exception>
        public decimal PackageCost
        {
            get { return packageCost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }
                packageCost = value;
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        /// ArgumentOutOfRangeException - Thrown when the property is set to less than 0. Message: “The value cannot be less than 0.” Parameter name: “value”.

        public decimal FragranceCost
        {
            get { return fragranceCost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The value cannot be less than 0.");
                }
                fragranceCost = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public decimal ProvincialSalesTaxCharged { get; }

        /// <summary>
        /// decimal - Gets the amount of goods and services tax charged to the customer (Rounded to 2 decimal places).
        /// The tax is calculated by multiplying the tax rate by the subtotal.
        /// </summary>
        public decimal GoodsAndServicesTaxCharged { get; }

        /// <summary>
        /// Gets the subtotal of the Invoice. The subtotal is the sum of the package and fragrance cost.
        /// </summary>
        public decimal SubTotal { get; }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates.
        /// The package cost and fragrance cost are zero.
        /// </summary>
        /// <param name="provincialSalesTaxRate"> The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate"> The rate of goods and services tax charged to a customer.</param>
        /// <exception cref=" ArgumentOutOfRangeException">Thrown when </exception>
        // ArgumentOutOfRangeException - Thrown when the provincial sales tax rate is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “provincialSalesTaxRate”.
        //        ArgumentOutOfRangeException - Thrown when the provincial sales tax rate is greater than 1. Message: “The argument cannot be greater than 1.” Parameter name: “provincialSalesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the goods and services tax rate is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “goodsAndServicesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the goods and services tax rate is greater than 1. Message: “The argument cannot be greater than 1.” Parameter name: “goodsAndServicesTaxRate”.
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            PackageCost = 0;
            FragranceCost = 0;

            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            }
            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            }

            this.ProvincialSalesTaxRate = provincialSalesTaxRate;

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            }
            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            }

            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate, package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate"></param>
        /// <param name="goodsAndServicesTaxRate"></param>
        /// <param name="packageCost"></param>
        /// <param name="fragranceCost"></param>
        ///

        // Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate, package cost and fragrance cost.
        //        Parameters:
        //provincialSalesTaxRate - The rate of provincial tax charged to a customer.
        //goodsAndServicesTaxRate - The rate of goods and services tax charged to a customer.
        //packageCost - The cost of the chosen package.
        //fragranceCost - The cost of the chosen fragrance.

        // Exceptions:
        // ArgumentOutOfRangeException - Thrown when the provincial sales tax rate is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “provincialSalesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the provincial sales tax rate is greater than 1. Message: “The argument cannot be greater than 1.” Parameter name: “provincialSalesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the goods and services tax rate is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “goodsAndServicesTaxRate”.
                //ArgumentOutOfRangeException - Thrown when the goods and services tax rate is greater than 1. Message: “The argument cannot be greater than 1.” Parameter name: “goodsAndServicesTaxRate”.
        //ArgumentOutOfRangeException - Thrown when the package cost is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “packageCost”.
        //ArgumentOutOfRangeException - Thrown when the fragrance cost is less than 0. Message: “The argument cannot be less than 0.” Parameter name: “fragranceCost”.
        public CarWashInvoice(
            decimal provincialSalesTaxRate,
            decimal goodsAndServicesTaxRate,
            decimal packageCost,
            decimal fragranceCost
        )
        {
            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be less than 0.");
            }

            if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("provincialSalesTaxRate", "The argument cannot be greater than 1.");
            }

            this.ProvincialSalesTaxRate = provincialSalesTaxRate;

            if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be less than 0.");
            }

            if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("goodsAndServicesTaxRate", "The argument cannot be greater than 1.");
            }

            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;

            if (packageCost < 0)
            {
                throw new ArgumentOutOfRangeException("packageCost", "The argument cannot be less than 0.");
            }
            this.PackageCost = packageCost;
            if (fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException("fragranceCost", "The argument cannot be less than 0.");
            }
            this.FragranceCost = fragranceCost;
        }
    }
}
