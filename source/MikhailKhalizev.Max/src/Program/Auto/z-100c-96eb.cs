using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_96eb-518a34b3")]
        public void Method_100c_96eb()
        {
            ii(0x100c_96eb, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_96f0, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c65d); /* call 0x10165d52 */
            ii(0x100c_96f5, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_96f6, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_96f7, 1); pushd(edx);                             /* push edx */
            ii(0x100c_96f8, 1); pushd(esi);                             /* push esi */
            ii(0x100c_96f9, 1); pushd(edi);                             /* push edi */
            ii(0x100c_96fa, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_96fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_96fd, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_9703, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_9706, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9708, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_970b, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100c_970e, 5); calld(0x1008_afe4, -0x3_e72f);          /* call 0x1008afe4 */
            ii(0x100c_9713, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_9716, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_971b, 5); calld(0x100a_5e27, -0x2_38f9);          /* call 0x100a5e27 */
            ii(0x100c_9720, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9722, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_9723, 1); popd(edi);                              /* pop edi */
            ii(0x100c_9724, 1); popd(esi);                              /* pop esi */
            ii(0x100c_9725, 1); popd(edx);                              /* pop edx */
            ii(0x100c_9726, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_9727, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_9728, 1); retd(); return;                         /* ret */
        }
    }
}
