using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a9f8-d1206bd7")]
        public void Method_100a_a9f8()
        {
            ii(0x100a_a9f8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_a9fd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_b350); /* call 0x10165d52 */
            ii(0x100a_aa02, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_aa03, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_aa04, 1); pushd(edx);                             /* push edx */
            ii(0x100a_aa05, 1); pushd(esi);                             /* push esi */
            ii(0x100a_aa06, 1); pushd(edi);                             /* push edi */
            ii(0x100a_aa07, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_aa08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aa0a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_aa10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_aa13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_aa16, 3); mov(al, memb_a32[ds, eax + 0x1e]);      /* mov al, [eax+0x1e] */
            ii(0x100a_aa19, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100a_aa1c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_aa1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aa21, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_aa22, 1); popd(edi);                              /* pop edi */
            ii(0x100a_aa23, 1); popd(esi);                              /* pop esi */
            ii(0x100a_aa24, 1); popd(edx);                              /* pop edx */
            ii(0x100a_aa25, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_aa26, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_aa27, 1); retd();                                 /* ret */
        }
    }
}
