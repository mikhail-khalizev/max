using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c1d0574-e608-4f96-af29-084556022408")]
        public void Method_100e_f2e8()
        {
            ii(0x100e_f2e8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_f2ed, 5); calld(Definitions.sys_check_available_stack_size, 0x76a60); /* call 0x10165d52 */
            ii(0x100e_f2f2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_f2f3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_f2f4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_f2f5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_f2f6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_f2f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_f2f9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_f2ff, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_f302, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100e_f305, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_f308, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_f30b, 3); mov(memb_a32[ds, edx + 0x12], al);      /* mov [edx+0x12], al */
            ii(0x100e_f30e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_f310, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_f311, 1); popd(edi);                              /* pop edi */
            ii(0x100e_f312, 1); popd(esi);                              /* pop esi */
            ii(0x100e_f313, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_f314, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_f315, 1); retd(); return;                         /* ret */
        }
    }
}
