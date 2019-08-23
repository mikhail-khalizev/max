using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6ca9-a8b144b7")]
        public void Method_100a_6ca9()
        {
            ii(0x100a_6ca9, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_6cae, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f09f); /* call 0x10165d52 */
            ii(0x100a_6cb3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_6cb4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6cb5, 1); pushd(edx);                             /* push edx */
            ii(0x100a_6cb6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6cb7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6cb8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6cb9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6cbb, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_6cc1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_6cc4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6cc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6cc9, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_6ccc, 5); calld(0x1008_afe4, -0x1_bced);          /* call 0x1008afe4 */
            ii(0x100a_6cd1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6cd4, 5); calld(0x100a_71f8, 0x51f);              /* call 0x100a71f8 */
            ii(0x100a_6cd9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6cdb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6cde, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6ce1, 5); calld(0x1013_ad71, 0x9_408b);           /* call 0x1013ad71 */
            ii(0x100a_6ce6, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6ce8, 2); if(jzd(0x100a_6d06, 0x1c)) goto l_0x100a_6d06; /* jz 0x100a6d06 */
            ii(0x100a_6cea, 5); calld(0x1008_ac50, -0x1_c09f);          /* call 0x1008ac50 */
            ii(0x100a_6cef, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_6cf1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100a_6cf3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6cf6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6cf9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6cfc, 5); calld(0x1007_6574, -0x3_078d);          /* call 0x10076574 */
            ii(0x100a_6d01, 5); calld(0x1015_2962, 0xa_bc5c);           /* call 0x10152962 */
        l_0x100a_6d06:
            ii(0x100a_6d06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6d08, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6d0b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6d0e, 5); calld(0x1007_6630, -0x3_06e3);          /* call 0x10076630 */
            ii(0x100a_6d13, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6d16, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_6d1b, 5); calld(0x100a_5e27, -0xef9);             /* call 0x100a5e27 */
            ii(0x100a_6d20, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6d22, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6d23, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6d24, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6d25, 1); popd(edx);                              /* pop edx */
            ii(0x100a_6d26, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6d27, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_6d28, 1); retd();                                 /* ret */
        }
    }
}
