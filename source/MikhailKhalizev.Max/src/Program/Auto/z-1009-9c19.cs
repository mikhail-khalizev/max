using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9c19-da383c6")]
        public void Method_1009_9c19()
        {
            ii(0x1009_9c19, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_9c1e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c12f); /* call 0x10165d52 */
            ii(0x1009_9c23, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9c24, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9c25, 1); pushd(edx);                             /* push edx */
            ii(0x1009_9c26, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9c27, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9c28, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9c29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9c2b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_9c31, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_9c34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9c36, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9c39, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_9c3c, 5); calld(0x1008_afe4, -0xec5d);            /* call 0x1008afe4 */
            ii(0x1009_9c41, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9c43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9c46, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9c49, 5); calld(0x1009_c44c, 0x27fe);             /* call 0x1009c44c */
            ii(0x1009_9c4e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_9c51, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_9c56, 5); calld(0x100a_5e27, 0xc1cc);             /* call 0x100a5e27 */
            ii(0x1009_9c5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9c5d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9c5e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9c5f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9c60, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9c61, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9c62, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9c63, 1); retd(); return;                         /* ret */
        }
    }
}
