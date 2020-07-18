using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a63b-954e17aa")]
        public void Method_100f_a63b()
        {
            ii(0x100f_a63b, 6);  mov(ecx, memd[ds, 0x101c_3908]);      /* mov ecx, [0x101c3908] */
            ii(0x100f_a641, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100f_a644, 6);  mov(ebx, memd[ds, 0x101c_3906]);      /* mov ebx, [0x101c3906] */
            ii(0x100f_a64a, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100f_a64d, 6);  mov(edx, memd[ds, 0x101c_3894]);      /* mov edx, [0x101c3894] */
            ii(0x100f_a653, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a658, 5);  call(0x1007_65d0, -0x8_408d);         /* call 0x100765d0 */
            ii(0x100f_a65d, 5);  call(0x100f_9465, -0x11fd);           /* call 0x100f9465 */
            ii(0x100f_a662, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_a664, 2);  if(jz(0x100f_a67b, 0x15)) goto l_0x100f_a67b;/* jz 0x100fa67b */
            ii(0x100f_a666, 6);  mov(edx, memd[ds, 0x101c_3894]);      /* mov edx, [0x101c3894] */
            ii(0x100f_a66c, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x100f_a671, 5);  call(0x1007_65d0, -0x8_40a6);         /* call 0x100765d0 */
            ii(0x100f_a676, 5);  call(0x100f_8f46, -0x1735);           /* call 0x100f8f46 */
        l_0x100f_a67b:
            ii(0x100f_a67b, 5);  jmp_func(0x100f_a75d, 0xdd);          /* jmp 0x100fa75d */
        }
    }
}
