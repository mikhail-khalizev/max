using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a31fba4-28a0-4745-becd-28f723624869")]
        public void Method_100d_7bdc()
        {
            ii(0x100d_7bdc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_7be1, 5); calld(Definitions.sys_check_available_stack_size, 0x8e16c); /* call 0x10165d52 */
            ii(0x100d_7be6, 1); pushd(esi);                             /* push esi */
            ii(0x100d_7be7, 1); pushd(edi);                             /* push edi */
            ii(0x100d_7be8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_7be9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7beb, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_7bf1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_7bf4, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_7bf7, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100d_7bfa, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100d_7bfd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_7c00, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7c03, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100d_7c07, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7c0a, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7c0d, 4); mov(memw_a32[ds, edx + 0x6], ax);       /* mov [edx+0x6], ax */
            ii(0x100d_7c11, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7c14, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7c17, 4); mov(memw_a32[ds, edx + 0x8], ax);       /* mov [edx+0x8], ax */
            ii(0x100d_7c1b, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100d_7c1e, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_7c21, 4); mov(memw_a32[ds, edx + 0xa], ax);       /* mov [edx+0xa], ax */
            ii(0x100d_7c25, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7c28, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100d_7c2b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7c2e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7c31, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100d_7c34, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7c37, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_7c3a, 5); calld(Definitions.sys_new_arr, 0x8e3d1); /* call 0x10166010 */
            ii(0x100d_7c3f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_7c41, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7c44, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x100d_7c46, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7c49, 4); mov(memb_a32[ds, eax + 0xc], 0x1);      /* mov byte [eax+0xc], 0x1 */
            ii(0x100d_7c4d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_7c50, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_7c53, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_7c56, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7c58, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_7c59, 1); popd(edi);                              /* pop edi */
            ii(0x100d_7c5a, 1); popd(esi);                              /* pop esi */
            ii(0x100d_7c5b, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
