using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashPaymentControl.xaml
    /// </summary>
    public partial class CashPaymentControl : UserControl
    {
        /// <summary>
        /// Keeping track of the Order, the border displaying the screen, and the view model for calculating the money drawer.
        /// </summary>
        Order orderedItems;
        Border purchaseWindow;
        CashDrawerViewModel viewModel;

        /// <summary>
        /// Constructor for the class.
        /// </summary>
        /// <param name="oI">the ordered items</param>
        /// <param name="pW">the display border</param>
        public CashPaymentControl(Order oI, Border pW)
        {
            InitializeComponent();
            orderedItems = oI;
            purchaseWindow = pW;
            viewModel = new CashDrawerViewModel(orderedItems);
            DataContext = viewModel;

        }

        /// <summary>
        /// Button for returning to the beginning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void return_Click(object sender, RoutedEventArgs e)
        {
            purchaseWindow.Child = null;
        }

        /// <summary>
        /// Button for finalizing the order and printing the receipt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void finalize_Click(object sender, RoutedEventArgs e)
        {
            ReceiptControl pR = new ReceiptControl(purchaseWindow, orderedItems, "Cash", viewModel.Change);
        }


    }
}
