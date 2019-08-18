using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c7d9c04-0e51-48d2-ab95-6a3b0a09d2da")]
        public void Method_1013_1d00()
        {
            ii(0x1013_1d00, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1d05, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4048); /* call 0x10165d52 */
            ii(0x1013_1d0a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1d0b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1d0c, 1); pushd(edx);                             /* push edx */
            ii(0x1013_1d0d, 1); pushd(esi);                             /* push esi */
            ii(0x1013_1d0e, 1); pushd(edi);                             /* push edi */
            ii(0x1013_1d0f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_1d10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1d12, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1d18, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_1d1b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d1e, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1013_1d24, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d27, 4); mov(memb_a32[ds, eax + 0x4], 0xff);     /* mov byte [eax+0x4], 0xff */
            ii(0x1013_1d2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d2e, 6); mov(memw_a32[ds, eax + 0x5], 0);        /* mov word [eax+0x5], 0x0 */
            ii(0x1013_1d34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d37, 7); mov(memd_a32[ds, eax + 0x7], 0);        /* mov dword [eax+0x7], 0x0 */
            ii(0x1013_1d3e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d41, 7); mov(memd_a32[ds, eax + 0xb], 0);        /* mov dword [eax+0xb], 0x0 */
            ii(0x1013_1d48, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d4b, 7); mov(memd_a32[ds, eax + 0xf], 0);        /* mov dword [eax+0xf], 0x0 */
            ii(0x1013_1d52, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d55, 7); mov(memd_a32[ds, eax + 0x13], 0);       /* mov dword [eax+0x13], 0x0 */
            ii(0x1013_1d5c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d5f, 7); mov(memd_a32[ds, eax + 0x17], 0);       /* mov dword [eax+0x17], 0x0 */
            ii(0x1013_1d66, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d69, 7); mov(memd_a32[ds, eax + 0x1b], 0);       /* mov dword [eax+0x1b], 0x0 */
            ii(0x1013_1d70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_1d73, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_1d76, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_1d79, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1d7b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_1d7c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_1d7d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_1d7e, 1); popd(edx);                              /* pop edx */
            ii(0x1013_1d7f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_1d80, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_1d81, 1); retd(); return;                         /* ret */
        }
    }
}
