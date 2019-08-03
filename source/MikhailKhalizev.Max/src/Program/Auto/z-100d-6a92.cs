using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("936e3b61-0ab7-4e08-93be-6ccfe5a4cfd4")]
        public void Method_100d_6a92()
        {
            ii(0x100d_6a92, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_6a97, 5); calld(Definitions.sys_check_available_stack_size, 0x8f2b6); /* call 0x10165d52 */
            ii(0x100d_6a9c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6a9d, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6a9e, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6a9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6aa0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6aa2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_6aa8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_6aab, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_6aae, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100d_6ab1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_6ab4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6ab7, 5); calld(/* sys */ 0x1016_c298, 0x957dc);  /* call 0x1016c298 */
            ii(0x100d_6abc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_6abf, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100d_6ac2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6ac5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6ac8, 2); sub(memd_a32[ds, eax], edx);            /* sub [eax], edx */
            ii(0x100d_6aca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_6acd, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100d_6ad0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6ad3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6ad6, 2); sub(memd_a32[ds, eax], edx);            /* sub [eax], edx */
            ii(0x100d_6ad8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6ada, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6adb, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6adc, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6add, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6ade, 1); retd(); return;                         /* ret */
        }
    }
}
