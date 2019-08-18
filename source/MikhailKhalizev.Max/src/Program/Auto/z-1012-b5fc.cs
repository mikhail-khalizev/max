using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c933979-db08-422d-a215-163844b94e1e")]
        public void Method_1012_b5fc()
        {
            ii(0x1012_b5fc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_b601, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a74c); /* call 0x10165d52 */
            ii(0x1012_b606, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b607, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b608, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b609, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b60b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1012_b611, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_b614, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_b617, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1012_b61a, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1012_b61d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_b620, 6); calld_abs(memd_a32[ds, 0x101b_ddf4]);   /* call dword [0x101bddf4] */
            ii(0x1012_b626, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_b629, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_b62c, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1012_b62f, 2); if(jled(0x1012_b637, 0x6)) goto l_0x1012_b637; /* jle 0x1012b637 */
            ii(0x1012_b631, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_b634, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
        l_0x1012_b637:
            ii(0x1012_b637, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1012_b63a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b63b, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1012_b63e, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1012_b641, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_b644, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b647, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x1012_b64a, 6); calld_abs(memd_a32[ds, 0x101b_ddec]);   /* call dword [0x101bddec] */
            ii(0x1012_b650, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b652, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b653, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b654, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b655, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
