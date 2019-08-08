using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1392a58c-2bed-4444-b5f6-b6cae0312268")]
        public void Method_100c_7115()
        {
            ii(0x100c_7115, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_7119, 2); if(jnzd(0x100c_7143, 0x28)) goto l_0x100c_7143; /* jnz 0x100c7143 */
            ii(0x100c_711b, 5); calld(0x100c_aef4, 0x3dd4);             /* call 0x100caef4 */
            ii(0x100c_7120, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_7122, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_7124, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_7127, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100c_712a, 5); calld(0x100c_ae64, 0x3d35);             /* call 0x100cae64 */
            ii(0x100c_712f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_7131, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_7134, 5); calld(0x100c_7177, 0x3e);               /* call 0x100c7177 */
            ii(0x100c_7139, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_713b, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100c_713e, 5); calld(0x100c_a6a0, 0x355d);             /* call 0x100ca6a0 */
        l_0x100c_7143:
            ii(0x100c_7143, 5); calld(0x100c_aef4, 0x3dac);             /* call 0x100caef4 */
            ii(0x100c_7148, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_714a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_714c, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_714f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7152, 5); calld(0x100c_ae64, 0x3d0d);             /* call 0x100cae64 */
            ii(0x100c_7157, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_7159, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_715c, 5); calld(0x100c_a6a0, 0x353f);             /* call 0x100ca6a0 */
            ii(0x100c_7161, 2); jmpd(0x100c_716d, 0xa); goto l_0x100c_716d; /* jmp 0x100c716d */
        //    ii(0x100c_7163, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100c_7165, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100c_7168, 5); calld(0x100c_a6a0, 0x3533);             /* call 0x100ca6a0 */
        l_0x100c_716d:
            ii(0x100c_716d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_7170, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_7172, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_7173, 1); popd(edi);                              /* pop edi */
            ii(0x100c_7174, 1); popd(esi);                              /* pop esi */
            ii(0x100c_7175, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_7176, 1); retd(); return;                         /* ret */
        }
    }
}
