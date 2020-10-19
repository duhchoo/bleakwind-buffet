using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    /// <summary>
    /// This view model is the in-between for the CashPaymentControl.xaml and for the RoundRegister.dll
    /// </summary>
    public class CashDrawerViewModel
    {
        /// <summary>
        /// Keeps track of the ordered items.
        /// </summary>
        Order orderedItems;

        /// <summary>
        /// Contructor for the class.
        /// </summary>
        /// <param name="oI">the ordered items.</param>
        public CashDrawerViewModel(Order oI)
        {
            orderedItems = oI;
        }

        /// <summary>
        /// Keeps track of leftover change.
        /// </summary>
        double change = 0;
        public double Change
        {
            get => change;
        }

        /// <summary>
        /// Keeps track of hundred dollar bills.
        /// </summary>
        int hundreds = 0;
        public int Hundreds
        {
            get => hundreds;
        }

        /// <summary>
        /// Keeps track of fifty dollar bills.
        /// </summary>
        int fifties = 0;
        public int Fifties
        {
            get => fifties;
        }

        /// <summary>
        /// Twenty dollar bills.
        /// </summary>
        int twenties = 0;
        public int Twenties
        {
            get => twenties;
        }

        /// <summary>
        /// Ten dollar bills.
        /// </summary>
        int tens = 0;
        public int Tens
        {
            get => tens;
        }

        /// <summary>
        /// Five dollar bills.
        /// </summary>
        int fives = 0;
        public int Fives
        {
            get => fives;
        }

        /// <summary>
        /// Two dollar bills.
        /// </summary>
        int twos = 0;
        public int Twos
        {
            get => twos;
        }

        /// <summary>
        /// One dollar bills.
        /// </summary>
        int ones = 0;
        public int Ones
        {
            get => ones;
        }

        /// <summary>
        /// Fifty cents.
        /// </summary>
        int fiftyCent = 0;
        public int FiftyCent
        {
            get => fiftyCent;
        }

        /// <summary>
        /// Twenty cents.
        /// </summary>
        int twentyFiveCent = 0;
        public int TwentyFiveCent
        {
            get => twentyFiveCent;
        }

        /// <summary>
        /// Ten cents.
        /// </summary>
        int tenCent = 0;
        public int TenCent
        {
            get => tenCent;
        }

        /// <summary>
        /// Five cents.
        /// </summary>
        int fiveCent = 0;
        public int FiveCent
        {
            get => fiveCent;
        }

        /// <summary>
        /// One cents.
        /// </summary>
        int oneCent = 0;
        public int OneCent
        {
            get => oneCent;
        }

    }
}
