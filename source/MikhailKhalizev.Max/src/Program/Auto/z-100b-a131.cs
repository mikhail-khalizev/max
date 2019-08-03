using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cf06b176-27cf-48ad-bc6f-ced146a89c95")]
        public void Method_100b_a131()
        {
            ii(0x100b_a131, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_a136, 5); calld(Definitions.sys_check_available_stack_size, 0xabc17); /* call 0x10165d52 */
            ii(0x100b_a13b, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_a13c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a13d, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a13e, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a13f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a140, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a142, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_a148, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_a14b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_a14e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a151, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100b_a154, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_a157, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a15a, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100b_a15d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_a160, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_a163, 5); calld(0x1007_6aac, -0x436bc);           /* call 0x10076aac */
            ii(0x100b_a168, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_a16b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_a16d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_a16f, 5); calld(0x100b_9da4, -0x3d0);             /* call 0x100b9da4 */
            ii(0x100b_a174, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_a177, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a17a, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100b_a17d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_a180, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_a183, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
            ii(0x100b_a186, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a188, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a189, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a18a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a18b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a18c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a18d, 1); retd(); return;                         /* ret */
        }
    }
}
