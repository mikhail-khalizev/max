using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("814337bd-b983-4453-933b-cbe55364e425")]
        public void Method_100c_ed1b()
        {
            ii(0x100c_ed1b, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100c_ed20, 5); calld(Definitions.sys_check_available_stack_size, 0x9702d); /* call 0x10165d52 */
            ii(0x100c_ed25, 1); pushd(esi);                             /* push esi */
            ii(0x100c_ed26, 1); pushd(edi);                             /* push edi */
            ii(0x100c_ed27, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_ed28, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ed2a, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100c_ed30, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_ed33, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100c_ed36, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_ed39, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100c_ed3c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed3f, 5); calld(0x100c_e71f, -0x625);             /* call 0x100ce71f */
            ii(0x100c_ed44, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed47, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100c_ed4b, 4); mov(memw_a32[ss, ebp - 0x1c], ax);      /* mov [ebp-0x1c], ax */
            ii(0x100c_ed4f, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x100c_ed56, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100c_ed59, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100c_ed5c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed5f, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100c_ed62, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_ed65, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_ed68, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed6b, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_ed6e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_ed71, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_ed74, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed77, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_ed7a, 5); calld(0x100d_4e8c, 0x610d);             /* call 0x100d4e8c */
            ii(0x100c_ed7f, 3); mov(memd_a32[ss, ebp - 0x16], eax);     /* mov [ebp-0x16], eax */
            ii(0x100c_ed82, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_ed85, 1); pushd(eax);                             /* push eax */
            ii(0x100c_ed86, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100c_ed8b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_ed8f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_ed93, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_ed97, 5); calld(0x100e_8ef1, 0x1a155);            /* call 0x100e8ef1 */
            ii(0x100c_ed9c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_ed9f, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x100c_eda2, 5); calld(0x100d_4e8c, 0x60e5);             /* call 0x100d4e8c */
            ii(0x100c_eda7, 3); mov(memd_a32[ss, ebp - 0x16], eax);     /* mov [ebp-0x16], eax */
            ii(0x100c_edaa, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100c_edad, 1); pushd(eax);                             /* push eax */
            ii(0x100c_edae, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100c_edb3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_edb7, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x100c_edba, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100c_edbe, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100c_edc2, 5); calld(0x100e_8ef1, 0x1a12a);            /* call 0x100e8ef1 */
            ii(0x100c_edc7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_edc9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_edca, 1); popd(edi);                              /* pop edi */
            ii(0x100c_edcb, 1); popd(esi);                              /* pop esi */
            ii(0x100c_edcc, 1); retd(); return;                         /* ret */
        }
    }
}
