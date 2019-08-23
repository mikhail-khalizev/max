using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a998-fcb7ee50")]
        public void Method_1008_a998()
        {
            ii(0x1008_a998, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1008_a99d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b3b0); /* call 0x10165d52 */
            ii(0x1008_a9a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a9a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a9a4, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a9a5, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a9a6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a9a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a9a9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a9af, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a9b2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a9b5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a9b8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a9bb, 5); add(eax, 0x82);                         /* add eax, 0x82 */
            ii(0x1008_a9c0, 5); calld(0x1007_6630, -0x1_4395);          /* call 0x10076630 */
            ii(0x1008_a9c5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a9c7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a9c8, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a9c9, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a9ca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a9cb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a9cc, 1); retd();                                 /* ret */
        }
    }
}
