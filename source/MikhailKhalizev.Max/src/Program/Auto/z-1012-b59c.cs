using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83e5fcb3-f819-4034-82ad-0025005c9c0e")]
        public void Method_1012_b59c()
        {
            ii(0x1012_b59c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_b5a1, 5); calld(Definitions.sys_check_available_stack_size, 0x3a7ac); /* call 0x10165d52 */
            ii(0x1012_b5a6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_b5a7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_b5a8, 1); pushd(edx);                             /* push edx */
            ii(0x1012_b5a9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b5aa, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b5ab, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b5ac, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b5ae, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_b5b4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_b5b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_b5ba, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1012_b5bd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_b5c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b5c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b5c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b5c6, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b5c7, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b5c8, 1); popd(edx);                              /* pop edx */
            ii(0x1012_b5c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_b5ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_b5cb, 1); retd(); return;                         /* ret */
        }
    }
}
