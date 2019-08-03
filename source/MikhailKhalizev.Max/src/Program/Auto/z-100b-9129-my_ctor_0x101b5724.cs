using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c68e63a7-1a45-4eae-ad99-3c2087644bbf")]
        public void my_ctor_0x101b5724()
        {
            ii(0x100b_9129, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_912e, 5); calld(Definitions.sys_check_available_stack_size, 0xacc1f); /* call 0x10165d52 */
            ii(0x100b_9133, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_9134, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_9135, 1); pushd(edx);                             /* push edx */
            ii(0x100b_9136, 1); pushd(esi);                             /* push esi */
            ii(0x100b_9137, 1); pushd(edi);                             /* push edi */
            ii(0x100b_9138, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_9139, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_913b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_9141, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_9144, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9147, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x100b_914e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9151, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x100b_9158, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_915b, 6); mov(memw_a32[ds, eax + 0xc], 0);        /* mov word [eax+0xc], 0x0 */
            ii(0x100b_9161, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9164, 6); mov(memw_a32[ds, eax + 0x2], 0);        /* mov word [eax+0x2], 0x0 */
            ii(0x100b_916a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_916d, 4); mov(memb_a32[ds, eax + 0x10], 0);       /* mov byte [eax+0x10], 0x0 */
            ii(0x100b_9171, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_9174, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_9177, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_917a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_917c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_917d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_917e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_917f, 1); popd(edx);                              /* pop edx */
            ii(0x100b_9180, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_9181, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_9182, 1); retd(); return;                         /* ret */
        }
    }
}
