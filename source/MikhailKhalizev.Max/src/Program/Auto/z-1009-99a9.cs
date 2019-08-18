using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_99a9-ddf20ca9")]
        public void Method_1009_99a9()
        {
            ii(0x1009_99a9, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_99ae, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c39f); /* call 0x10165d52 */
            ii(0x1009_99b3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_99b4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_99b5, 1); pushd(edx);                             /* push edx */
            ii(0x1009_99b6, 1); pushd(esi);                             /* push esi */
            ii(0x1009_99b7, 1); pushd(edi);                             /* push edi */
            ii(0x1009_99b8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_99b9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_99bb, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1009_99c1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_99c4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_99c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_99c9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_99cc, 5); calld(0x1009_c44c, 0x2a7b);             /* call 0x1009c44c */
            ii(0x1009_99d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_99d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_99d6, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_99d9, 5); calld(0x1008_afe4, -0xe9fa);            /* call 0x1008afe4 */
            ii(0x1009_99de, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_99e1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_99e6, 5); calld(0x100a_5e27, 0xc43c);             /* call 0x100a5e27 */
            ii(0x1009_99eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_99ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_99ee, 1); popd(edi);                              /* pop edi */
            ii(0x1009_99ef, 1); popd(esi);                              /* pop esi */
            ii(0x1009_99f0, 1); popd(edx);                              /* pop edx */
            ii(0x1009_99f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_99f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_99f3, 1); retd(); return;                         /* ret */
        }
    }
}
