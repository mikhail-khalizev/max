using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("260555d8-4e64-4caa-9940-9b1573ae2fd3")]
        public void Method_100c_ef64()
        {
            ii(0x100c_ef64, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100c_ef69, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6de4); /* call 0x10165d52 */
            ii(0x100c_ef6e, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ef6f, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ef70, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ef71, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ef73, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100c_ef79, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_ef7c, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_ef7f, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_ef82, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100c_ef85, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_ef8c, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_ef93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ef96, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_ef99, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_ef9c, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_efa0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_efa2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_efa5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_efa8, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_efab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_efae, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_efb2, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_efb4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_efb7, 3); mov(edx, memd_a32[ss, ebp + 0x1c]);     /* mov edx, [ebp+0x1c] */
            ii(0x100c_efba, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100c_efbd, 5); calld(0x100d_4d78, 0x5db6);             /* call 0x100d4d78 */
            ii(0x100c_efc2, 1); pushd(eax);                             /* push eax */
            ii(0x100c_efc3, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x100c_efc6, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_efc9, 5); calld(0x100d_4d78, 0x5daa);             /* call 0x100d4d78 */
            ii(0x100c_efce, 1); pushd(eax);                             /* push eax */
            ii(0x100c_efcf, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x100c_efd2, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_efd5, 5); calld(0x100d_4d78, 0x5d9e);             /* call 0x100d4d78 */
            ii(0x100c_efda, 1); pushd(eax);                             /* push eax */
            ii(0x100c_efdb, 3); mov(edx, memd_a32[ss, ebp + 0x10]);     /* mov edx, [ebp+0x10] */
            ii(0x100c_efde, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_efe1, 5); calld(0x100d_4d78, 0x5d92);             /* call 0x100d4d78 */
            ii(0x100c_efe6, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_efe8, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x100c_efeb, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_efee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_eff1, 5); calld(0x100c_edcd, -0x229);             /* call 0x100cedcd */
            ii(0x100c_eff6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_eff8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_eff9, 1); popd(edi);                              /* pop edi */
            ii(0x100c_effa, 1); popd(esi);                              /* pop esi */
            ii(0x100c_effb, 3); retd(0x10); return;                     /* ret 0x10 */
        }
    }
}
