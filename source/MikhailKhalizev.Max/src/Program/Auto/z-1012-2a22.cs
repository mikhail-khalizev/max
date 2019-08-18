using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("151ecc7f-9de5-4b12-abf9-6edd439ab7c6")]
        public void Method_1012_2a22()
        {
            ii(0x1012_2a22, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a25, 4); cmp(memd_a32[ds, eax + 0x42], 0);       /* cmp dword [eax+0x42], 0x0 */
            ii(0x1012_2a29, 2); if(jzd(0x1012_2a3b, 0x10)) goto l_0x1012_2a3b; /* jz 0x10122a3b */
            ii(0x1012_2a2b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_2a2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a31, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_2a34, 5); calld(0x100e_b283, -0x3_77b6);          /* call 0x100eb283 */
            ii(0x1012_2a39, 2); jmpd(0x1012_2a7d, 0x42); goto l_0x1012_2a7d; /* jmp 0x10122a7d */
        l_0x1012_2a3b:
            ii(0x1012_2a3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a3e, 6); cmp(memw_a32[ds, eax + 0x40], 0x6c1);   /* cmp word [eax+0x40], 0x6c1 */
            ii(0x1012_2a44, 2); if(jnzd(0x1012_2a56, 0x10)) goto l_0x1012_2a56; /* jnz 0x10122a56 */
            ii(0x1012_2a46, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_2a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2a4a, 5); mov(eax, 0x18);                         /* mov eax, 0x18 */
            ii(0x1012_2a4f, 5); calld(0x1010_5b00, -0x1_cf54);          /* call 0x10105b00 */
            ii(0x1012_2a54, 2); jmpd(0x1012_2a7d, 0x27); goto l_0x1012_2a7d; /* jmp 0x10122a7d */
        l_0x1012_2a56:
            ii(0x1012_2a56, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_2a5d, 2); if(jnzd(0x1012_2a65, 0x6)) goto l_0x1012_2a65; /* jnz 0x10122a65 */
            ii(0x1012_2a5f, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1012_2a63, 2); jmpd(0x1012_2a69, 0x4); goto l_0x1012_2a69; /* jmp 0x10122a69 */
        l_0x1012_2a65:
            ii(0x1012_2a65, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
        l_0x1012_2a69:
            ii(0x1012_2a69, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_2a6b, 3); mov(bl, memb_a32[ss, ebp - 0x1c]);      /* mov bl, [ebp-0x1c] */
            ii(0x1012_2a6e, 5); mov(edx, 0x26);                         /* mov edx, 0x26 */
            ii(0x1012_2a73, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x1012_2a78, 5); calld(0x1010_5b00, -0x1_cf7d);          /* call 0x10105b00 */
        l_0x1012_2a7d:
            ii(0x1012_2a7d, 5); if(jmpd_func(0x1012_31ce, 0x74c)) return; /* jmp 0x101231ce */
        }
    }
}
