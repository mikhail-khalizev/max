using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a5ac-abdc8e33")]
        public void Method_1008_a5ac()
        {
            ii(0x1008_a5ac, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a5b1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b79c); /* call 0x10165d52 */
            ii(0x1008_a5b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a5b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a5b8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a5b9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a5ba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a5bb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a5bd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a5c3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a5c6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a5c9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a5cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a5cf, 5); calld(0x1013_ac03, 0xb_062f);           /* call 0x1013ac03 */
            ii(0x1008_a5d4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a5d7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_a5da, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a5dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a5e0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_a5e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_a5e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a5e8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a5e9, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a5ea, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a5eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a5ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a5ed, 1); retd();                                 /* ret */
        }
    }
}
