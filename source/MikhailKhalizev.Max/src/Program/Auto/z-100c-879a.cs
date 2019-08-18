using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b3246ac-ae16-4ddc-a91d-60ff002fad22")]
        public void Method_100c_879a()
        {
            ii(0x100c_879a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_879f, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d5ae); /* call 0x10165d52 */
            ii(0x100c_87a4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_87a5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_87a6, 1); pushd(edx);                             /* push edx */
            ii(0x100c_87a7, 1); pushd(esi);                             /* push esi */
            ii(0x100c_87a8, 1); pushd(edi);                             /* push edi */
            ii(0x100c_87a9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_87aa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_87ac, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_87b2, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_87b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_87b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_87ba, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100c_87bd, 5); calld(0x1008_afe4, -0x3_d7de);          /* call 0x1008afe4 */
            ii(0x100c_87c2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_87c5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_87ca, 5); calld(0x100a_5e27, -0x2_29a8);          /* call 0x100a5e27 */
            ii(0x100c_87cf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_87d1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_87d2, 1); popd(edi);                              /* pop edi */
            ii(0x100c_87d3, 1); popd(esi);                              /* pop esi */
            ii(0x100c_87d4, 1); popd(edx);                              /* pop edx */
            ii(0x100c_87d5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_87d6, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_87d7, 1); retd(); return;                         /* ret */
        }
    }
}
