using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b7b4-f49f31f6")]
        public void Method_100c_b7b4()
        {
            ii(0x100c_b7b4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_b7b9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a594); /* call 0x10165d52 */
            ii(0x100c_b7be, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b7bf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b7c0, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b7c1, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b7c2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b7c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b7c5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b7cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b7ce, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100c_b7d1, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100c_b7d4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_b7d7, 3); mov(memb_a32[ds, edx + 0x23], al);      /* mov [edx+0x23], al */
            ii(0x100c_b7da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b7dc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b7dd, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b7de, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b7df, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b7e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b7e1, 1); retd();                                 /* ret */
        }
    }
}
