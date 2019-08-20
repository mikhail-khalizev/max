using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_360a-c72c666a")]
        public void Method_1013_360a()
        {
            ii(0x1013_360a, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1013_360d, 4); cmp(ax, memw_a32[ss, ebp - 0x48]);      /* cmp ax, [ebp-0x48] */
            ii(0x1013_3611, 2); if(jzd(0x1013_365e, 0x4b)) goto l_0x1013_365e; /* jz 0x1013365e */
            ii(0x1013_3613, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x1013_3616, 3); sub(edx, memd_a32[ss, ebp - 0x48]);     /* sub edx, [ebp-0x48] */
            ii(0x1013_3619, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_361c, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x1013_361f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3622, 5); calld(0x1007_6730, -0xb_cef7);          /* call 0x10076730 */
            ii(0x1013_3627, 5); calld(0x100c_b7e4, -0x6_7e48);          /* call 0x100cb7e4 */
            ii(0x1013_362c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_362e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3631, 5); calld(0x1007_6730, -0xb_cf06);          /* call 0x10076730 */
            ii(0x1013_3636, 5); calld(0x100c_b7b4, -0x6_7e87);          /* call 0x100cb7b4 */
            ii(0x1013_363b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_363e, 5); calld(0x100c_b74c, -0x6_7ef7);          /* call 0x100cb74c */
            ii(0x1013_3643, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_3645, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x1013_3649, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_364d, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3653, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_3659, 5); calld(0x100c_b63c, -0x6_8022);          /* call 0x100cb63c */
        l_0x1013_365e:
            ii(0x1013_365e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3660, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1013_3663, 5); calld(0x1007_5eec, -0xb_d77c);          /* call 0x10075eec */
            ii(0x1013_3668, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_366a, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1013_366d, 5); calld(0x1007_5eec, -0xb_d786);          /* call 0x10075eec */
            ii(0x1013_3672, 5); if(jmpd_func(0x1013_3386, -0x2f1)) return; /* jmp 0x10133386 */
        }
    }
}
