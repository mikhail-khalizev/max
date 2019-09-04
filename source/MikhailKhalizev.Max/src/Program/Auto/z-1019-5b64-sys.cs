using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5b64-c0389fb9")]
        public void /* sys */ Method_1019_5b64()
        {
            ii(0x1019_5b64, 7); cmp(memb[ds, 0x101c_1b5c], 0);          /* cmp byte [0x101c1b5c], 0x0 */
            ii(0x1019_5b6b, 2); if(jz(0x1019_5b87, 0x1a)) goto l_0x1019_5b87; /* jz 0x10195b87 */
            ii(0x1019_5b6d, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1019_5b73, 1); push(edx);                              /* push edx */
            ii(0x1019_5b74, 1); push(eax);                              /* push eax */
            ii(0x1019_5b75, 1); int3();                                 /* int3 */
            ii(0x1019_5b76, 2); jmp(0x1019_5b7e, 6); goto l_0x1019_5b7e; /* jmp 0x10195b7e */
        //  ii(0x1019_5b78, 1); push(edi);                              /* push edi */
        //  ii(0x1019_5b79, 1); push(esi);                              /* push esi */
        //  ii(0x1019_5b7a, 1); dec(ecx);                               /* dec ecx */
        //  ii(0x1019_5b7b, 1); inc(esp);                               /* inc esp */
        //  ii(0x1019_5b7c, 1); inc(ebp);                               /* inc ebp */
        //  ii(0x1019_5b7d, 1); dec(edi);                               /* dec edi */
        l_0x1019_5b7e:
            ii(0x1019_5b7e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1019_5b83, 3); add(esp, 8);                            /* add esp, 0x8 */
            ii(0x1019_5b86, 1); ret(); return;                          /* ret */
        l_0x1019_5b87:
            ii(0x1019_5b87, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_5b89, 1); ret();                                  /* ret */
        }
    }
}
