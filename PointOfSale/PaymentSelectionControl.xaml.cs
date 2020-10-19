using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentSelectionControl.xaml
    /// </summary>
    public partial class PaymentSelectionControl : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Keeping track of the main border displaying the screen and the Order being paid for.
        /// </summary>
        Border purchaseWindow;
        Order orderedItems;

        /// <summary>
        /// Contructor for the class.
        /// </summary>
        /// <param name="pW"></param>
        /// <param name="oI"></param>
        public PaymentSelectionControl(Border pW, Order oI)
        {
            InitializeComponent();
            purchaseWindow = pW;
            orderedItems = oI;
        }

        /// <summary>
        /// The button for returning to the beginning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void return_Click(object sender, RoutedEventArgs e)
        {
            purchaseWindow.Child = null;
        }

        /// <summary>
        /// The button for paying with cash.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cash_Click(object sender, RoutedEventArgs e)
        {
            purchaseWindow.Child = new CashPaymentControl(orderedItems, purchaseWindow);
        }

        /// <summary>
        /// The button for paying with credit or debit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void card_Click(object sender, RoutedEventArgs e)
        {
            CardTransactionResult cardResult = CardReader.RunCard(orderedItems.Total);

            if (cardResult == CardTransactionResult.Approved)
            {
                MessageBox.Show("Card Approved.");
                ReceiptControl pR = new ReceiptControl(purchaseWindow, orderedItems, "Credit/Debit", 0.00);
            }
            else if (cardResult == CardTransactionResult.Declined)
            {
                MessageBox.Show("Card Declined.");
            }
            else if (cardResult == CardTransactionResult.ReadError)
            {
                MessageBox.Show("Read Error, try swiping slower.");
            }
            else if (cardResult == CardTransactionResult.InsufficientFunds)
            {
                MessageBox.Show("Dang... you're too poor.");
            }
            else if (cardResult == CardTransactionResult.IncorrectPin)
            {
                MessageBox.Show("Incorrect PIN.");
            }

            purchaseWindow.Child = null;
        }


    }
}
