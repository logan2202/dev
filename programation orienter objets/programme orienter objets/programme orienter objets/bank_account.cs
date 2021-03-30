using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace programme_orienter_objets
{
    /// <summary>
    /// 
    /// </summary>
    public class Bank_account
    {

        #region Aggregations


        #endregion

        #region Compositions


        #endregion

        #region Attributes

        /// <summary>
        /// 
        /// </summary>
        public string holder;


        /// <summary>
        /// 
        /// </summary>
        public double balance;


        /// <summary>
        /// 
        /// </summary>
        public string device;



        #endregion


        #region Public methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public void credit(double amount)
        {
            
            balance += amount;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public void debit(double amount)
        {
            
            balance -= amount;
        }

        #endregion


        #region Protected methods

        #endregion


        #region Private methods

        #endregion


    }
}
