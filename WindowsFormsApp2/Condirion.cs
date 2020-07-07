using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Возможные состояния клетки
    /// </summary>
    public enum Condition
    {
        NotAlieved = 0,
        Alived = 1,
        Stable = 2,
        Infectious = 3
    }
}
