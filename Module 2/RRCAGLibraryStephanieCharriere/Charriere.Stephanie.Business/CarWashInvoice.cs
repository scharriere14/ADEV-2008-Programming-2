using System;

namespace Charriere.Stephanie.Business
{
    /// <summary>
    /// This class contains functionality that supports the business process of creating an invoice for the car wash department.
    /// The CarWashInvoice class derives from the Invoice class.
    /// </summary>
    public class CarWashInvoice : Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        public decimal PackageCost
        {
            get { return packageCost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                packageCost = value;
            }
        }

        /// <summary>
        /// Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        public decimal FragranceCost
        {
            get { return fragranceCost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                fragranceCost = value;
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get { return 0; }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer (Rounded to 2 decimal places).
        /// The tax is calculated by multiplying the tax rate by the subtotal.
        /// </summary>
        public override decimal GoodsAndServicesTaxCharged
        {
            get { return Math.Round(GoodsAndServicesTaxRate * SubTotal, 2); }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice. The subtotal is the sum of the package and fragrance cost.
        /// </summary>
        public override decimal SubTotal
        {
            get { return PackageCost + FragranceCost; }
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates.
        /// The package cost and fragrance cost are zero.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        public CarWashInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            PackageCost = 0;
            FragranceCost = 0;

            this.ProvincialSalesTaxRate = provincialSalesTaxRate;

            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods, services tax rate, package cost and fragrance cost.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        public CarWashInvoice(
            decimal provincialSalesTaxRate,
            decimal goodsAndServicesTaxRate,
            decimal packageCost,
            decimal fragranceCost
        )
            : base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            this.ProvincialSalesTaxRate = provincialSalesTaxRate;

            this.GoodsAndServicesTaxRate = goodsAndServicesTaxRate;

            this.PackageCost = packageCost;

            this.FragranceCost = fragranceCost;
        }
    }
}
