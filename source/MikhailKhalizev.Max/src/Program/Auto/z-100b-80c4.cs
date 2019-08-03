using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8798091a-4246-4ade-a155-16140e2990a8")]
        public void Method_100b_80c4()
        {
            ii(0x100b_80c4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_80c9, 5); calld(Definitions.sys_check_available_stack_size, 0xadc84); /* call 0x10165d52 */
            ii(0x100b_80ce, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_80cf, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_80d0, 1); pushd(edx);                             /* push edx */
            ii(0x100b_80d1, 1); pushd(esi);                             /* push esi */
            ii(0x100b_80d2, 1); pushd(edi);                             /* push edi */
            ii(0x100b_80d3, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_80d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_80d6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_80dc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_80df, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_80e2, 3); mov(al, memb_a32[ds, eax + 0x13]);      /* mov al, [eax+0x13] */
            ii(0x100b_80e5, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x100b_80e8, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_80eb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_80ed, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_80ee, 1); popd(edi);                              /* pop edi */
            ii(0x100b_80ef, 1); popd(esi);                              /* pop esi */
            ii(0x100b_80f0, 1); popd(edx);                              /* pop edx */
            ii(0x100b_80f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_80f2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_80f3, 1); retd(); return;                         /* ret */
        }
    }
}
