using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_2
{
    class Address
    {
        #region Properties
        /// <summary>
        /// address is basically city, street and house
        /// </summary>
        public string city { get; set; } = String.Empty;
        public string street { get; set; } = String.Empty;
        public string house { get; set; }=String.Empty;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with 3 args
        /// </summary>
        /// <param name="city">value for city field</param>
        /// <param name="street">value for street field</param>
        /// <param name="house">value for house field</param>
        public Address(string city, string street, string house)
        {
            this.city = city;
            this.street = street;
            this.house = house;
        }
        /// <summary>
        /// No params constructor
        /// </summary>
        public Address() { }
        #endregion
        /// <summary>
        /// overrided equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Address buffer = (Address) obj;
            return (buffer.street.Equals(street) && buffer.house.Equals(house) && buffer.city.Equals(city));
        }
    }
}
