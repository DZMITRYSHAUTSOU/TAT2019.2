using System;
using System.Collections.Generic;

namespace CW_2
{
    /// <summary>
    /// University class
    /// </summary>
    class University
    {
        /// <summary>
        /// Contains list of departments
        /// </summary>
        private List<Department> departments = new List<Department>();

        #region Methods
        /// <summary>
        /// Adds department
        /// </summary>
        /// <param name="department"></param>
        public void AddDepartment(Department department)
        {
            bool toAdd = true;
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].IsEqual(department))
                {
                    toAdd = false;
                    break;
                }
            }

            if (toAdd)
            {
                departments.Add(department);
            }
        }
        /// <summary>
        /// Displays all of departments in University
        /// </summary>
        public void DisplayDepartments()
        {
            foreach (var department in departments)
            {
                Console.WriteLine(department.name + "   " + department.address.city + "   " +
                                  department.address.street +
                                  "   " + department.address.house);
            }
        }
        #endregion

    }
}
