using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5e131832-0795-4b55-b38a-b77ca5d4e482")]
        public void /* sys */ Method_1019_5b64()
        {
            ii(0x1019_5b64, 7); cmp(memb_a32[ds, 0x101c_1b5c], 0);      /* cmp byte [0x101c1b5c], 0x0 */
            ii(0x1019_5b6b, 2); if(jzd(0x1019_5b87, 0x1a)) goto l_0x1019_5b87; /* jz 0x10195b87 */
            ii(0x1019_5b6d, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1019_5b73, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5b74, 1); pushd(eax);                             /* push eax */
            ii(0x1019_5b75, 1); int3();                                 /* int3 */
            ii(0x1019_5b76, 2); jmpd(0x1019_5b7e, 0x6); goto l_0x1019_5b7e; /* jmp 0x10195b7e */
        //  ii(0x1019_5b78, 6); Недостижимый код.
l_0x1019_5b7e:
            ii(0x1019_5b7e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_5b83, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_5b86, 1); retd(); return;                         /* ret */
        l_0x1019_5b87:
            ii(0x1019_5b87, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_5b89, 1); retd(); return;                         /* ret */
        }
    }
}