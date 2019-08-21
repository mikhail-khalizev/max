using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a21c-ab813c46")]
        public void Method_100f_a21c()
        {
            ii(0x100f_a21c, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a221, 5); calld(0x1007_6574, -0x8_3cb2);          /* call 0x10076574 */
            ii(0x100f_a226, 5); calld(0x1007_611c, -0x8_410f);          /* call 0x1007611c */
            ii(0x100f_a22b, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100f_a22e, 7); mov(dx, memw_a32[ds, 0x101c_3908]);     /* mov dx, [0x101c3908] */
            ii(0x100f_a235, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a238, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100f_a23c, 7); mov(dx, memw_a32[ds, 0x101c_390a]);     /* mov dx, [0x101c390a] */
            ii(0x100f_a243, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a246, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100f_a24a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a24f, 5); calld(0x1007_6600, -0x8_3c54);          /* call 0x10076600 */
            ii(0x100f_a254, 3); mov(ebx, memd_a32[ss, ebp - 0x68]);     /* mov ebx, [ebp-0x68] */
            ii(0x100f_a257, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_a259, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_a25b, 5); calld(0x1008_a998, -0x6_f8c8);          /* call 0x1008a998 */
            ii(0x100f_a260, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_a265, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100f_a26a, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x100f_a26d, 5); calld(0x1016_3053, 0x6_8de1);           /* call 0x10163053 */
            ii(0x100f_a272, 5); if(jmpd_func(0x100f_a75d, 0x4e6)) return; /* jmp 0x100fa75d */
        }
    }
}
