using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_d801-2ee31f38")]
        public void Method_1011_d801()
        {
            ii(0x1011_d801, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_d806, 5); calld(Definitions.sys_check_available_stack_size, 0x4_8547); /* call 0x10165d52 */
            ii(0x1011_d80b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_d80c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_d80d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_d80e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_d80f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_d810, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_d812, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_d818, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_d81b, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1011_d81e, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_d821, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_d824, 3); mov(memb_a32[ds, edx + 0x13], al);      /* mov [edx+0x13], al */
            ii(0x1011_d827, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_d829, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_d82a, 1); popd(edi);                              /* pop edi */
            ii(0x1011_d82b, 1); popd(esi);                              /* pop esi */
            ii(0x1011_d82c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_d82d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_d82e, 1); retd();                                 /* ret */
        }
    }
}
