using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Oops.Inheritance
{
    public interface Parent1
    {

    }

    public interface Parent2
    {

    }

    public class Child : Parent1, Parent2
    {
        
    }  
    

    public class GrandChild : Child
    {

    }
}
