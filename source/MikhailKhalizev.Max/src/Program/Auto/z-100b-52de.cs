using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_52de-3a84cbbe")]
        public void Method_100b_52de()
        {
            ii(0x100b_52de, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_52e3, 5); calld(Definitions.sys_check_available_stack_size, 0xb_0a6a); /* call 0x10165d52 */
            ii(0x100b_52e8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_52e9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_52ea, 1); pushd(edx);                             /* push edx */
            ii(0x100b_52eb, 1); pushd(esi);                             /* push esi */
            ii(0x100b_52ec, 1); pushd(edi);                             /* push edi */
            ii(0x100b_52ed, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_52ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_52f0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100b_52f6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_52f9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_52fb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_52fe, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5301, 5); calld(0x1013_ad71, 0x8_5a6b);           /* call 0x1013ad71 */
            ii(0x100b_5306, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5308, 2); if(jzd(0x100b_532a, 0x20)) goto l_0x100b_532a; /* jz 0x100b532a */
            ii(0x100b_530a, 5); calld(0x1008_a79c, -0x2_ab73);          /* call 0x1008a79c */
            ii(0x100b_530f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_5311, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100b_5313, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_5316, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5319, 5); calld(0x1007_65d0, -0x3_ed4e);          /* call 0x100765d0 */
            ii(0x100b_531e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5320, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_5325, 5); calld(0x100a_53ac, -0xff7e);            /* call 0x100a53ac */
        l_0x100b_532a:
            ii(0x100b_532a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_532c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_532f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5332, 5); calld(0x1007_6630, -0x3_ed07);          /* call 0x10076630 */
            ii(0x100b_5337, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5339, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_533c, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100b_533f, 5); calld(0x1008_afe4, -0x2_a360);          /* call 0x1008afe4 */
            ii(0x100b_5344, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_5347, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_534c, 5); calld(0x100a_5e27, -0xf52a);            /* call 0x100a5e27 */
            ii(0x100b_5351, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5353, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_5354, 1); popd(edi);                              /* pop edi */
            ii(0x100b_5355, 1); popd(esi);                              /* pop esi */
            ii(0x100b_5356, 1); popd(edx);                              /* pop edx */
            ii(0x100b_5357, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_5358, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_5359, 1); retd(); return;                         /* ret */
        }
    }
}
