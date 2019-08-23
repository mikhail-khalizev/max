using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_92a2-36338572")]
        public void /* sys */ Method_1017_92a2()
        {
            ii(0x1017_92a2, 1); push(ecx);                              /* push ecx */
            ii(0x1017_92a3, 2); sar(ebx, 0x1);                          /* sar ebx, 1 */
            ii(0x1017_92a5, 2); jmp(0x1017_92b8, 0x11); goto l_0x1017_92b8; /* jmp 0x101792b8 */
        l_0x1017_92a7:
            ii(0x1017_92a7, 2); mov(ch, memb[ds, eax]);                 /* mov ch, [eax] */
            ii(0x1017_92a9, 3); mov(cl, memb[ds, eax + 0x1]);           /* mov cl, [eax+0x1] */
            ii(0x1017_92ac, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_92ad, 2); mov(memb[ds, edx], cl);                 /* mov [edx], cl */
            ii(0x1017_92af, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1017_92b2, 3); mov(memb[ds, edx + 0x1], ch);           /* mov [edx+0x1], ch */
            ii(0x1017_92b5, 3); add(edx, 0x2);                          /* add edx, 0x2 */
        l_0x1017_92b8:
            ii(0x1017_92b8, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_92ba, 2); if(jnz(0x1017_92a7, -0x15)) goto l_0x1017_92a7; /* jnz 0x101792a7 */
            ii(0x1017_92bc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_92bd, 1); ret();                                  /* ret */
        }
    }
}
