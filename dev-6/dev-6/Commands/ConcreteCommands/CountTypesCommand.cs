using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_6
{
    class CountTypesCommand : ICommand
    {
        CarsDataBase carsDataBase;

        public CountTypesCommand(CarsDataBase carsDataBase)
        {
            this.carsDataBase = carsDataBase;
        }

        public void Execute()
        {
            carsDataBase.DisplayTypesCount();
        }
    }
}
