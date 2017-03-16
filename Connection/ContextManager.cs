using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Connection
{
    class ContextManager
    {
        private static readonly ContextManager instance = new ContextManager();
        private readonly Context context;

        private ContextManager()
        {
            context = new Context();
        }
        public static ContextManager Instance
        {
            get
            {
                return instance;
            }
        }

        public Context Context
        {
            get
            {
                return context;
            }
        }

    }
}
