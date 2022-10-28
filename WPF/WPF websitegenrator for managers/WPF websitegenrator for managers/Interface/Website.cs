using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_websitegenerator_for_managers
{
    /*
     * Vi skapar ett interface (ett "kontrakt") med de delar som vår klass måste innehålla
     */
    interface Website
    {
        string printPage();
    }
}