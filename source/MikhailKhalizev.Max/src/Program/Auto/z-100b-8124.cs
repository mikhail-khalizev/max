using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8124-a98f5a85")]
        public void Method_100b_8124()
        {
            ii(0x100b_8124, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_8129, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dc24); /* call 0x10165d52 */
            ii(0x100b_812e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_812f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_8130, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8131, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8132, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8133, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8135, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_813b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_813e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_8141, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_8144, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8147, 5); calld(0x1013_acc5, 0x8_2b79);           /* call 0x1013acc5 */
            ii(0x100b_814c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_814f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8152, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_8154, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8155, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8156, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8157, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8158, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8159, 1); retd(); return;                         /* ret */
        }
    }
}
