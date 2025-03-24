using System;
using System.Security.Cryptography;

namespace Charriere.Stephanie.Business
{
    /// <summary>
    /// This abstract class contains functionality that supports the business process of creating an invoice.
    /// </summary>
    abstract class Invoice
    {
        // Fields
        // The provincial sales tax rate applied to the invoice.
        decimal provincialSalesTaxRate;
        // The goods and services tax rate applied to the invoice.
        decimal goodsAndServicesTaxRate;

        // Properties

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        /// <param name="value">The value of the provincial sales tax rate</param>"
        /// <exception cref=" ArgumentOutOfRangeException">Thrown when the property is set to less than or greater than 0.</exception>
        public decimal ProvincialSalesTaxRate
        {
            get { return provincialSalesTaxRate; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                else if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.");
                }
                else
                {
                    this.provincialSalesTaxRate = value;
                }
            
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate.
        /// </summary>
        /// <param name="value">The value of the Goods And Services Tax Rate</param>"
        /// <exception cref=" ArgumentOutOfRangeException">Thrown when the property is set to less than or greater than 0.</exception>
        public decimal GoodsAndServicesTaxRate
        {
            get { return goodsAndServicesTaxRate; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                else if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.");
                }
                else
                {
                    this.goodsAndServicesTaxRate = value;
                }

            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer (Rounded to two decimal places).
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer (Rounded to two decimal places).
        /// </summary>
        public abstract decimal GoodsAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        ///  Gets the subtotal of the Invoice.
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice. The total is the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get { return SubTotal + ProvincialSalesTaxCharged + GoodsAndServicesTaxCharged; }
        }

        //Methods
        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            //if (provincialSalesTaxRate < 0)
            //{
            //    throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            //}
            //if (provincialSalesTaxRate > 1)
            //{
            //    throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.");
            //}
            //if (goodsAndServicesTaxRate < 0)
            //{
            //    throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            //}
            // if (goodsAndServicesTaxRate > 1)
            //{
            //    throw new ArgumentOutOfRangeException("The argument cannot be greater than 1.");
            //}
            
            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }
    }
}