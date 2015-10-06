using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duckhunt2.objects
{
    interface CollisionObject
    {
        void Accept(CollisionVisitor dv);
    }
}
