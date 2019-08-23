using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_65a4-3ecb6c66")]
        public void Method_1013_65a4()
        {
            ii(0x1013_65a4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_65a9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_f7a4); /* call 0x10165d52 */
            ii(0x1013_65ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_65af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_65b0, 1); pushd(edx);                             /* push edx */
            ii(0x1013_65b1, 1); pushd(esi);                             /* push esi */
            ii(0x1013_65b2, 1); pushd(edi);                             /* push edi */
            ii(0x1013_65b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_65b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_65b6, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_65bc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_65bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_65c2, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x1013_65c7, 5); calld(0x1013_a6f4, 0x4128);             /* call 0x1013a6f4 */
            ii(0x1013_65cc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_65ce, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_65cf, 1); popd(edi);                              /* pop edi */
            ii(0x1013_65d0, 1); popd(esi);                              /* pop esi */
            ii(0x1013_65d1, 1); popd(edx);                              /* pop edx */
            ii(0x1013_65d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_65d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_65d4, 1); retd();                                 /* ret */
        }
    }
}
