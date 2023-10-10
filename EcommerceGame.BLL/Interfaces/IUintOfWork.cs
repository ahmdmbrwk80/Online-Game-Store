using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IUintOfWork: IDisposable
    {
        /// <summary>
        /// property signatur for all interface repository  
        /// </summary>
        // like public IEmployeeRepository EmployeeRepository { get; set; }
      

        int Complete();


    }
}
