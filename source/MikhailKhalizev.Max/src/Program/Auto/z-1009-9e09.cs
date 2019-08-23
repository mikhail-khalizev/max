using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9e09-1be103e5")]
        public void Method_1009_9e09()
        {
            ii(0x1009_9e09, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_9e0e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bf3f); /* call 0x10165d52 */
            ii(0x1009_9e13, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9e14, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9e15, 1); pushd(edx);                             /* push edx */
            ii(0x1009_9e16, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9e17, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9e18, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9e19, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9e1b, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_9e21, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_9e24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9e26, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9e29, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_9e2c, 5); calld(0x1008_afe4, -0xee4d);            /* call 0x1008afe4 */
            ii(0x1009_9e31, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9e33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9e36, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9e39, 5); calld(0x1009_c44c, 0x260e);             /* call 0x1009c44c */
            ii(0x1009_9e3e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_9e41, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_9e46, 5); calld(0x100a_5e27, 0xbfdc);             /* call 0x100a5e27 */
            ii(0x1009_9e4b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9e4d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9e4e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9e4f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9e50, 1); popd(edx);                              /* pop edx */
            ii(0x1009_9e51, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9e52, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9e53, 1); retd();                                 /* ret */
        }
    }
}
