using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ffb90d2a-3d9b-4ed7-9cf8-db58890edd68")]
        public void Method_1012_0bc0()
        {
            ii(0x1012_0bc0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1012_0bc5, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5188); /* call 0x10165d52 */
            ii(0x1012_0bca, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0bcb, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0bcc, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0bcd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0bce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0bd0, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0bd6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0bd9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_0bdc, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_0bdf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0be2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_0be5, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x1012_0be9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_0bec, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_0bef, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x1012_0bf3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0bf5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0bf6, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0bf7, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0bf8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0bf9, 1); retd(); return;                         /* ret */
        }
    }
}
