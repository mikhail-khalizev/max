using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6776162a-2dc4-42c4-9679-ff4186f2ac0f")]
        public void Method_1011_aca3()
        {
            ii(0x1011_aca3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_aca8, 5); calld(Definitions.sys_check_available_stack_size, 0x4b0a5); /* call 0x10165d52 */
            ii(0x1011_acad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_acae, 1); pushd(esi);                             /* push esi */
            ii(0x1011_acaf, 1); pushd(edi);                             /* push edi */
            ii(0x1011_acb0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_acb1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_acb3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_acb9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_acbc, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_acbf, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_acc2, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1011_acc5, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1011_acc8, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_accb, 3); mov(memb_a32[ss, ebp - 0xf], al);       /* mov [ebp-0xf], al */
            ii(0x1011_acce, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1011_acd1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_acd4, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_acd7, 5); calld(0x1012_0b08, 0x5e2c);             /* call 0x10120b08 */
            ii(0x1011_acdc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_acde, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_acdf, 1); popd(edi);                              /* pop edi */
            ii(0x1011_ace0, 1); popd(esi);                              /* pop esi */
            ii(0x1011_ace1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_ace2, 1); retd(); return;                         /* ret */
        }
    }
}