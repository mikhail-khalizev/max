using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4c9ef720-e716-42d7-8e36-d84c60320b18")]
        public void Method_1009_acc7()
        {
            ii(0x1009_acc7, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_accc, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b081); /* call 0x10165d52 */
            ii(0x1009_acd1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_acd2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_acd3, 1); pushd(edx);                             /* push edx */
            ii(0x1009_acd4, 1); pushd(esi);                             /* push esi */
            ii(0x1009_acd5, 1); pushd(edi);                             /* push edi */
            ii(0x1009_acd6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_acd7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_acd9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_acdf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_ace2, 4); mov(memb_a32[ss, ebp - 0x8], 0x22);     /* mov byte [ebp-0x8], 0x22 */
            ii(0x1009_ace6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1009_ace9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_aceb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_acec, 1); popd(edi);                              /* pop edi */
            ii(0x1009_aced, 1); popd(esi);                              /* pop esi */
            ii(0x1009_acee, 1); popd(edx);                              /* pop edx */
            ii(0x1009_acef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_acf0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_acf1, 1); retd(); return;                         /* ret */
        }
    }
}
