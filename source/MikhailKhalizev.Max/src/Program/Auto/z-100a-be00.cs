using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0844bd2c-b025-4f92-a4af-e45ab56c83a5")]
        public void Method_100a_be00()
        {
            ii(0x100a_be00, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_be05, 5); calld(Definitions.sys_check_available_stack_size, 0xb_9f48); /* call 0x10165d52 */
            ii(0x100a_be0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_be0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_be0c, 1); pushd(edx);                             /* push edx */
            ii(0x100a_be0d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_be0e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_be0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_be10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_be12, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_be18, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_be1b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_be1d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_be20, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_be23, 5); calld(0x1013_ad71, 0x8_ef49);           /* call 0x1013ad71 */
            ii(0x100a_be28, 2); test(al, al);                           /* test al, al */
            ii(0x100a_be2a, 2); if(jzd(0x100a_be3c, 0x10)) goto l_0x100a_be3c; /* jz 0x100abe3c */
            ii(0x100a_be2c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_be2f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_be32, 5); calld(0x100b_7f74, 0xc13d);             /* call 0x100b7f74 */
            ii(0x100a_be37, 5); calld(0x1011_fdf6, 0x7_3fba);           /* call 0x1011fdf6 */
        l_0x100a_be3c:
            ii(0x100a_be3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_be3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_be41, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_be44, 5); calld(0x100b_7fa4, 0xc15b);             /* call 0x100b7fa4 */
            ii(0x100a_be49, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_be4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_be4e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_be51, 5); calld(0x1008_afe4, -0x2_0e72);          /* call 0x1008afe4 */
            ii(0x100a_be56, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_be59, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_be5e, 5); calld(0x100a_5e27, -0x603c);            /* call 0x100a5e27 */
            ii(0x100a_be63, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_be65, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_be66, 1); popd(edi);                              /* pop edi */
            ii(0x100a_be67, 1); popd(esi);                              /* pop esi */
            ii(0x100a_be68, 1); popd(edx);                              /* pop edx */
            ii(0x100a_be69, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_be6a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_be6b, 1); retd(); return;                         /* ret */
        }
    }
}
