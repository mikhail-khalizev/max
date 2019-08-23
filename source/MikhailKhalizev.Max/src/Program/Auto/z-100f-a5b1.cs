using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a5b1-c84e5352")]
        public void Method_100f_a5b1()
        {
            ii(0x100f_a5b1, 6); mov(ecx, memd[ds, 0x101c_3908]);        /* mov ecx, [0x101c3908] */
            ii(0x100f_a5b7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a5ba, 6); mov(ebx, memd[ds, 0x101c_3906]);        /* mov ebx, [0x101c3906] */
            ii(0x100f_a5c0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a5c3, 6); mov(edx, memd[ds, 0x101c_3894]);        /* mov edx, [0x101c3894] */
            ii(0x100f_a5c9, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a5ce, 5); call(0x1007_65d0, -0x8_4003);           /* call 0x100765d0 */
            ii(0x100f_a5d3, 5); call(0x100f_9465, -0x1173);             /* call 0x100f9465 */
            ii(0x100f_a5d8, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a5da, 2); if(jz(0x100f_a5f1, 0x15)) goto l_0x100f_a5f1; /* jz 0x100fa5f1 */
            ii(0x100f_a5dc, 6); mov(edx, memd[ds, 0x101c_3894]);        /* mov edx, [0x101c3894] */
            ii(0x100f_a5e2, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a5e7, 5); call(0x1008_abbc, -0x6_fa30);           /* call 0x1008abbc */
            ii(0x100f_a5ec, 5); call(0x100f_8d4a, -0x18a7);             /* call 0x100f8d4a */
        l_0x100f_a5f1:
            ii(0x100f_a5f1, 5); if(jmp_func(0x100f_a75d, 0x167)) return; /* jmp 0x100fa75d */
        }
    }
}
