using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("67e0ee0e-09e4-408e-8600-19f19280d932")]
        public void Method_1008_8b44()
        {
            ii(0x1008_8b44, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8b49, 5); calld(Definitions.sys_check_available_stack_size, 0xd_d204); /* call 0x10165d52 */
            ii(0x1008_8b4e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8b4f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8b50, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8b51, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8b52, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8b53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8b55, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8b5b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8b5e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8b61, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8b64, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1008_8b66, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8b69, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1008_8b6b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8b6e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8b71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8b74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8b76, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8b77, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8b78, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8b79, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8b7a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8b7b, 1); retd(); return;                         /* ret */
        }
    }
}
