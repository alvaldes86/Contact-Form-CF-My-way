using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_and_Menus
{
    class Item
    {
        #region Fields
        /// <summary>
        /// The class will hold the fields desciption, price, and units
        /// </summary>
        private string _description;
        private decimal _price;
        private string _units;
        #endregion


        #region Properties
        /// <summary>
        /// The class will hold the properties desciption, price, and units
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value.Trim(); }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Units
        {
            get { return _units; }
            set { _units = value.Trim(); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructors and destructor of the class
        /// </summary>
        public Item()
        {

        }

        public Item(string pDescription, decimal pPrice, string pUnits)
        {
            Description = pDescription;
            Price = pPrice;
            Units = pUnits;
        }

        ~Item()
        {
            _description = null;
            _price = 0;
            _units = 0;
        }
        #endregion

        #region Methods
        public string override ToString()
        {
            string message;


            return message;
        }
        #endregion
    }
}
