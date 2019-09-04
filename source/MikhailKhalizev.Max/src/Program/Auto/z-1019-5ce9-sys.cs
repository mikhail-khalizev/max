using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5ce9-df11b1ff")]
        public void /* sys */ Method_1019_5ce9()
        {
            ii(0x1019_5ce9, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1019_5ceb, 3); mov(edx, memd[ds, ebx + 2]);            /* mov edx, [ebx+0x2] */
            ii(0x1019_5cee, 5); call(/* sys */ 0x1019_b4cc, 0x57d9);    /* call 0x1019b4cc */
            ii(0x1019_5cf3, 2); test(al, al);                           /* test al, al */
            ii(0x1019_5cf5, 2); if(jz(0x1019_5cfc, 5)) goto l_0x1019_5cfc; /* jz 0x10195cfc */
            ii(0x1019_5cf7, 3); mov(ecx, memd[ds, ebx + 6]);            /* mov ecx, [ebx+0x6] */
            ii(0x1019_5cfa, 2); if(jmp_func(0x1019_5ca0, -0x5c)) return; /* jmp 0x10195ca0 */
        l_0x1019_5cfc:
            ii(0x1019_5cfc, 3); mov(ecx, memd[ds, ebx + 10]);           /* mov ecx, [ebx+0xa] */
            ii(0x1019_5cff, 2); if(jmp_func(0x1019_5ca0, -0x61)) return; /* jmp 0x10195ca0 */
        }
    }
}
