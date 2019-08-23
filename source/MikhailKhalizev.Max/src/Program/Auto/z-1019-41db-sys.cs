using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_41db-c7f066c3")]
        public void /* sys */ Method_1019_41db()
        {
            ii(0x1019_41db, 1); push(ebp);                              /* push ebp */
            ii(0x1019_41dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_41de, 1); push(ebp);                              /* push ebp */
            ii(0x1019_41df, 1); push(esi);                              /* push esi */
            ii(0x1019_41e0, 1); push(edi);                              /* push edi */
            ii(0x1019_41e1, 1); push(ebx);                              /* push ebx */
            ii(0x1019_41e2, 3); mov(eax, memd[ss, ebp + 0x8]);          /* mov eax, [ebp+0x8] */
            ii(0x1019_41e5, 2); @int(0x10);                             /* int 0x10 */
            ii(0x1019_41e7, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_41e8, 1); pop(edi);                               /* pop edi */
            ii(0x1019_41e9, 1); pop(esi);                               /* pop esi */
            ii(0x1019_41ea, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_41eb, 1); leave();                                /* leave */
            ii(0x1019_41ec, 1); ret();                                  /* ret */
        }
    }
}
