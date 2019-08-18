using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7e34-f6bb8c22")]
        public void Method_100e_7e34()
        {
            ii(0x100e_7e34, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_7e39, 5); calld(Definitions.sys_check_available_stack_size, 0x7_df14); /* call 0x10165d52 */
            ii(0x100e_7e3e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7e3f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7e40, 1); pushd(edx);                             /* push edx */
            ii(0x100e_7e41, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7e42, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7e43, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7e44, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7e46, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_7e4c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_7e4f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e52, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x100e_7e58, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e5b, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x100e_7e62, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e65, 7); mov(memd_a32[ds, eax + 0xc], 0);        /* mov dword [eax+0xc], 0x0 */
            ii(0x100e_7e6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e6f, 7); mov(memd_a32[ds, eax + 0x8], 0);        /* mov dword [eax+0x8], 0x0 */
            ii(0x100e_7e76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e79, 7); mov(memd_a32[ds, eax + 0x10], 0);       /* mov dword [eax+0x10], 0x0 */
            ii(0x100e_7e80, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7e83, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_7e86, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_7e89, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7e8b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7e8c, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7e8d, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7e8e, 1); popd(edx);                              /* pop edx */
            ii(0x100e_7e8f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7e90, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7e91, 1); retd(); return;                         /* ret */
        }
    }
}
