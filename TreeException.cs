using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedTreeLab
{
    public class TreeException : Exception
    {
        public TreeException() { }
        public TreeException(string message) : base(message) { }
    }

    public class TreeModificationDenial : TreeException
    {
        public TreeModificationDenial() { }
        public TreeModificationDenial(string message) : base(message) { }
    }

    public class TreeElementRemovalDenial : TreeException
    {
        public TreeElementRemovalDenial() { }
        public TreeElementRemovalDenial(string message) : base(message) { }
    }

    public class TreeCreationException : TreeException
    {
        public TreeCreationException() { }
        public TreeCreationException(string message) : base(message) { }
    }

}
