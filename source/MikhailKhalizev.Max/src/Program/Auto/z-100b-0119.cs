using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0119-9298c9b7")]
        public void Method_100b_0119()
        {
            ii(0x100b_0119, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_011e, 5); calld(Definitions.sys_check_available_stack_size, 0xb_5c2f); /* call 0x10165d52 */
            ii(0x100b_0123, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0124, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0125, 1); pushd(edx);                             /* push edx */
            ii(0x100b_0126, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0127, 1); pushd(edi);                             /* push edi */
            ii(0x100b_0128, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_0129, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_012b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_0131, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_0134, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0136, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0139, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_013c, 5); calld(0x1013_ad71, 0x8_ac30);           /* call 0x1013ad71 */
            ii(0x100b_0141, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0143, 2); if(jzd(0x100b_0165, 0x20)) goto l_0x100b_0165; /* jz 0x100b0165 */
            ii(0x100b_0145, 5); calld(0x1008_a79c, -0x2_59ae);          /* call 0x1008a79c */
            ii(0x100b_014a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_014c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_014e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0151, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_0154, 5); calld(0x1007_65d0, -0x3_9b89);          /* call 0x100765d0 */
            ii(0x100b_0159, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_015b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_0160, 5); calld(0x100a_53ac, -0xadb9);            /* call 0x100a53ac */
        l_0x100b_0165:
            ii(0x100b_0165, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0167, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_016a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_016d, 5); calld(0x1007_6630, -0x3_9b42);          /* call 0x10076630 */
            ii(0x100b_0172, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0174, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0177, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_017a, 5); calld(0x100b_7cfc, 0x7b7d);             /* call 0x100b7cfc */
            ii(0x100b_017f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0181, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0184, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_0187, 5); calld(0x1008_afe4, -0x2_51a8);          /* call 0x1008afe4 */
            ii(0x100b_018c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_018f, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_0194, 5); calld(0x100a_5e27, -0xa372);            /* call 0x100a5e27 */
            ii(0x100b_0199, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_019b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_019c, 1); popd(edi);                              /* pop edi */
            ii(0x100b_019d, 1); popd(esi);                              /* pop esi */
            ii(0x100b_019e, 1); popd(edx);                              /* pop edx */
            ii(0x100b_019f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_01a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_01a1, 1); retd(); return;                         /* ret */
        }
    }
}
