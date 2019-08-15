using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc74d7f8-5f5b-48b0-9729-122d3bf9c11e")]
        public void Method_100e_acb0()
        {
            ii(0x100e_acb0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_acb5, 5); calld(Definitions.sys_check_available_stack_size, 0x7_b098); /* call 0x10165d52 */
            ii(0x100e_acba, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_acbb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_acbc, 1); pushd(edx);                             /* push edx */
            ii(0x100e_acbd, 1); pushd(esi);                             /* push esi */
            ii(0x100e_acbe, 1); pushd(edi);                             /* push edi */
            ii(0x100e_acbf, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_acc0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_acc2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_acc8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_accb, 5); calld(0x100e_aecc, 0x1fc);              /* call 0x100eaecc */
            ii(0x100e_acd0, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_acd3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_acd6, 5); calld(0x100e_ae78, 0x19d);              /* call 0x100eae78 */
            ii(0x100e_acdb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_acde, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_ace1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ace3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_ace4, 1); popd(edi);                              /* pop edi */
            ii(0x100e_ace5, 1); popd(esi);                              /* pop esi */
            ii(0x100e_ace6, 1); popd(edx);                              /* pop edx */
            ii(0x100e_ace7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_ace8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_ace9, 1); retd(); return;                         /* ret */
        }
    }
}
