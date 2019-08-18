using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ba0578c7-ab42-44af-a14a-c9c636356d2c")]
        public void my_ctor_c10()
        {
            ii(0x100e_9096, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_909b, 5); calld(Definitions.sys_check_available_stack_size, 0x7_ccb2); /* call 0x10165d52 */
            ii(0x100e_90a0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_90a1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_90a2, 1); pushd(edx);                             /* push edx */
            ii(0x100e_90a3, 1); pushd(esi);                             /* push esi */
            ii(0x100e_90a4, 1); pushd(edi);                             /* push edi */
            ii(0x100e_90a5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_90a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_90a8, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_90ae, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_90b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_90b4, 7); mov(memd_a32[ds, eax + 0x27], 0);       /* mov dword [eax+0x27], 0x0 */
            ii(0x100e_90bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_90be, 7); mov(memd_a32[ds, eax + 0x2b], 0);       /* mov dword [eax+0x2b], 0x0 */
            ii(0x100e_90c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_90c8, 7); mov(memd_a32[ds, eax + 0x2f], 0);       /* mov dword [eax+0x2f], 0x0 */
            ii(0x100e_90cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_90d2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_90d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_90d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_90da, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_90db, 1); popd(edi);                              /* pop edi */
            ii(0x100e_90dc, 1); popd(esi);                              /* pop esi */
            ii(0x100e_90dd, 1); popd(edx);                              /* pop edx */
            ii(0x100e_90de, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_90df, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_90e0, 1); retd(); return;                         /* ret */
        }
    }
}
