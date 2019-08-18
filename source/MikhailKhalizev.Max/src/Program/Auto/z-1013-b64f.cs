using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b64f-4c4017da")]
        public void Method_1013_b64f()
        {
            ii(0x1013_b64f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_b654, 5); calld(Definitions.sys_check_available_stack_size, 0x2_a6f9); /* call 0x10165d52 */
            ii(0x1013_b659, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_b65a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_b65b, 1); pushd(esi);                             /* push esi */
            ii(0x1013_b65c, 1); pushd(edi);                             /* push edi */
            ii(0x1013_b65d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_b65e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b660, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b666, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_b669, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_b66c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_b66f, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1013_b673, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_b676, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x1013_b67a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_b67d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_b680, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b682, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_b683, 1); popd(edi);                              /* pop edi */
            ii(0x1013_b684, 1); popd(esi);                              /* pop esi */
            ii(0x1013_b685, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_b686, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_b687, 1); retd(); return;                         /* ret */
        }
    }
}
