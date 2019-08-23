using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_afa0-fa4866d7")]
        public void Method_100c_afa0()
        {
            ii(0x100c_afa0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_afa5, 5); calld(Definitions.sys_check_available_stack_size, 0x9_ada8); /* call 0x10165d52 */
            ii(0x100c_afaa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_afab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_afac, 1); pushd(esi);                             /* push esi */
            ii(0x100c_afad, 1); pushd(edi);                             /* push edi */
            ii(0x100c_afae, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_afaf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_afb1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_afb7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_afba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_afbd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_afc0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_afc3, 5); calld(0x1013_a5af, 0x6_f5e7);           /* call 0x1013a5af */
            ii(0x100c_afc8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_afca, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_afcb, 1); popd(edi);                              /* pop edi */
            ii(0x100c_afcc, 1); popd(esi);                              /* pop esi */
            ii(0x100c_afcd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_afce, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_afcf, 1); retd();                                 /* ret */
        }
    }
}
