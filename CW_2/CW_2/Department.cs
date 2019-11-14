using System;

namespace CW_2
{
    /// <summary>
    /// Class for University
    /// </summary>
    class Department
    {
        #region Properties
        /// <summary>
        /// contains address of Department
        /// </summary>
        public Address address { get; set; }=new Address();
        /// <summary>
        /// Name of Department
        /// </summary>
        public string name { get; set; } = String.Empty;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with 4 args
        /// </summary>
        /// <param name="name">name of department</param>
        /// <param name="city">city of department</param>
        /// <param name="street">street of department</param>
        /// <param name="house">house of department</param>
        public Department(string name, string city,string street, string house)
        {
            this.name = name;
            address.city = city;
            address.street = street;
            address.house = house;
        }
        /// <summary>
        /// No args constructor
        /// </summary>
        public Department()
        {
            address=new Address();
        }
        #endregion
        /// <summary>
        /// Compares this department and the other department
        /// </summary>
        /// <param name="obj">2nd department</param>
        /// <returns></returns>
        public bool IsEqual(Department obj)
        {
            return (address.Equals(obj.address) && this.GetType() == obj.GetType());
        }
    }
}
