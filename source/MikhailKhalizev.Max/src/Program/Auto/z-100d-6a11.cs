using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1b98ab27-1dcf-48b9-81e3-f367f5dd7ffd")]
        public void Method_100d_6a11()
        {
            ii(0x100d_6a11, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_6a16, 5); calld(Definitions.sys_check_available_stack_size, 0x8f337); /* call 0x10165d52 */
            ii(0x100d_6a1b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6a1c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6a1d, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6a1e, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6a1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6a20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6a22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_6a28, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6a2b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6a2e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a31, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100d_6a33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a36, 3); mov(memd_a32[ds, eax + 0x12], edx);     /* mov [eax+0x12], edx */
            ii(0x100d_6a39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a3c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_6a3e, 5); calld(/* sys */ 0x1016_7dd4, 0x91391);  /* call 0x10167dd4 */
            ii(0x100d_6a43, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_6a45, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a48, 3); mov(memd_a32[ds, eax + 0x16], edx);     /* mov [eax+0x16], edx */
            ii(0x100d_6a4b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a4e, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x100d_6a54, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a57, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x100d_6a5e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a61, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_6a64, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6a67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a6a, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x100d_6a6d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a70, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x100d_6a73, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_6a76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a79, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x100d_6a7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a7f, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x100d_6a83, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6a86, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x100d_6a8a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6a8c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6a8d, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6a8e, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6a8f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6a90, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6a91, 1); retd(); return;                         /* ret */
        }
    }
}
