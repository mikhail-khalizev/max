using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5487454b-163c-475c-a22c-f3d5c7d18ca7")]
        public void Method_100a_39d5()
        {
            ii(0x100a_39d5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_39da, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2373); /* call 0x10165d52 */
            ii(0x100a_39df, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_39e0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_39e1, 1); pushd(edx);                             /* push edx */
            ii(0x100a_39e2, 1); pushd(esi);                             /* push esi */
            ii(0x100a_39e3, 1); pushd(edi);                             /* push edi */
            ii(0x100a_39e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_39e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_39e7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_39ed, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_39f0, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x100a_39f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_39fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_39fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_39fd, 1); popd(edi);                              /* pop edi */
            ii(0x100a_39fe, 1); popd(esi);                              /* pop esi */
            ii(0x100a_39ff, 1); popd(edx);                              /* pop edx */
            ii(0x100a_3a00, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_3a01, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_3a02, 1); retd(); return;                         /* ret */
        }
    }
}
