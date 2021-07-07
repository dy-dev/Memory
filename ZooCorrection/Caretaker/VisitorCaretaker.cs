using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCorrection
{
    abstract class VisitorCaretaker
    {
        abstract public void visit(Dolphin p_pDolphin);
        abstract public void visit(Lion p_pLion);

    }
}
