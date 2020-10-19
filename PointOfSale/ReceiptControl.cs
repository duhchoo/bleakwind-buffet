using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// The class that prints out all the receipt information.
    /// </summary>
    public class ReceiptControl
    {
        Border purchaseWindow;
        Order orderedItems;
        
        /// <summary>
        /// This is the constructor, but it also prints out everything when it is initialized.
        /// </summary>
        /// <param name="pW">the display border.</param>
        /// <param name="oI"> the ordered items </param>
        /// <param name="paymentMethod">the payment method</param>
        /// <param name="change">the amount of leftover change</param>
        public ReceiptControl(Border pW, Order oI, string paymentMethod, double change)
        {
            purchaseWindow = pW;
            orderedItems = oI;

            RoundRegister.RecieptPrinter.PrintLine("Order Number: " + Convert.ToString(orderedItems.Number) );
            RoundRegister.RecieptPrinter.PrintLine(DateTime.Now.ToString() );
            RoundRegister.RecieptPrinter.PrintLine("");

            // this loops through all the food items and their special instructions.
            foreach ( IOrderItem item in orderedItems.orderItemsList )
            {
                RoundRegister.RecieptPrinter.PrintLine("$" + item.Price + " - " + item.ToString() );

                foreach (string instruction in item.SpecialInstructions)
                {
                    RoundRegister.RecieptPrinter.PrintLine("   -" + instruction);
                }
                RoundRegister.RecieptPrinter.PrintLine("");
            }

            RoundRegister.RecieptPrinter.PrintLine("Subtotal: $" + Convert.ToString(orderedItems.Subtotal) );
            RoundRegister.RecieptPrinter.PrintLine("Tax: $" + Convert.ToString(orderedItems.Tax) );
            RoundRegister.RecieptPrinter.PrintLine("Total: $" + Convert.ToString(orderedItems.Total) );
            RoundRegister.RecieptPrinter.PrintLine("");
            RoundRegister.RecieptPrinter.PrintLine( "Paid with " + paymentMethod );
            RoundRegister.RecieptPrinter.PrintLine( "Change: $" + Convert.ToString(change) );

            //Finishes the receipt and cuts it.
            RoundRegister.RecieptPrinter.CutTape();
            System.Windows.MessageBox.Show("Receipt for Order " + Convert.ToString(orderedItems.Number) + " has been printed.");
        }

    }
}
