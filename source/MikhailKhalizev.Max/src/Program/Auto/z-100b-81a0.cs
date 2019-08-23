using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_81a0-65dd3e6a")]
        public void Method_100b_81a0()
        {
            ii(0x100b_81a0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_81a5, 5); calld(Definitions.sys_check_available_stack_size, 0xa_dba8); /* call 0x10165d52 */
            ii(0x100b_81aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_81ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_81ac, 1); pushd(esi);                             /* push esi */
            ii(0x100b_81ad, 1); pushd(edi);                             /* push edi */
            ii(0x100b_81ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_81af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_81b1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_81b7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_81ba, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100b_81bd, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100b_81c0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_81c3, 3); mov(memb_a32[ds, edx + 0x1e], al);      /* mov [edx+0x1e], al */
            ii(0x100b_81c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_81c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_81c9, 1); popd(edi);                              /* pop edi */
            ii(0x100b_81ca, 1); popd(esi);                              /* pop esi */
            ii(0x100b_81cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_81cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_81cd, 1); retd();                                 /* ret */
        }
    }
}
