using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopRncapsulation;
public class Plant
{
     private void Private() => Console.WriteLine("Private");
        
        protected void Protected()=> Console.WriteLine("Protected");

        private protected void Proteected() => Console.WriteLine("Private Protected");

        public void Public() => Console.WriteLine("Public");

        //trong cùng 1 project được quyền sài
        internal void Internal() => Console.WriteLine("Internal");

        protected internal void ProtectedInternal() =>Console.WriteLine("ProtectedInternal");
        
}
