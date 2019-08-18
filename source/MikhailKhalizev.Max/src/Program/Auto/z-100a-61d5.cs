using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_61d5-9749c26d")]
        public void Method_100a_61d5()
        {
            ii(0x100a_61d5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_61da, 5); calld(Definitions.sys_check_available_stack_size, 0xb_fb73); /* call 0x10165d52 */
            ii(0x100a_61df, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_61e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_61e1, 1); pushd(edx);                             /* push edx */
            ii(0x100a_61e2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_61e3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_61e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_61e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_61e7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_61ed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_61f0, 4); mov(memb_a32[ss, ebp - 0x8], 0x19);     /* mov byte [ebp-0x8], 0x19 */
            ii(0x100a_61f4, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_61f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_61f9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_61fa, 1); popd(edi);                              /* pop edi */
            ii(0x100a_61fb, 1); popd(esi);                              /* pop esi */
            ii(0x100a_61fc, 1); popd(edx);                              /* pop edx */
            ii(0x100a_61fd, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_61fe, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_61ff, 1); retd(); return;                         /* ret */
        }
    }
}
