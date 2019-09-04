using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a5f6-6e375a08")]
        public void Method_100f_a5f6()
        {
            ii(0x100f_a5f6, 6);  mov(ecx, memd[ds, 0x101c_3908]);      /* mov ecx, [0x101c3908] */
            ii(0x100f_a5fc, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_a5ff, 6);  mov(ebx, memd[ds, 0x101c_3906]);      /* mov ebx, [0x101c3906] */
            ii(0x100f_a605, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_a608, 6);  mov(edx, memd[ds, 0x101c_3894]);      /* mov edx, [0x101c3894] */
            ii(0x100f_a60e, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a613, 5);  call(0x1007_65d0, -0x8_4048);         /* call 0x100765d0 */
            ii(0x100f_a618, 5);  call(0x100f_9465, -0x11b8);           /* call 0x100f9465 */
            ii(0x100f_a61d, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a61f, 2);  if(jz(0x100f_a636, 0x15)) goto l_0x100f_a636;/* jz 0x100fa636 */
            ii(0x100f_a621, 6);  mov(edx, memd[ds, 0x101c_3894]);      /* mov edx, [0x101c3894] */
            ii(0x100f_a627, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a62c, 5);  call(0x1008_abbc, -0x6_fa75);         /* call 0x1008abbc */
            ii(0x100f_a631, 5);  call(0x100f_8e48, -0x17ee);           /* call 0x100f8e48 */
        l_0x100f_a636:
            ii(0x100f_a636, 5);  if(jmp_func(0x100f_a75d, 0x122)) return;/* jmp 0x100fa75d */
        }
    }
}
