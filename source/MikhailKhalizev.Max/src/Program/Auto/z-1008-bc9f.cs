using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("608135b2-7045-48e8-b9d1-412ae8caa8d1")]
        public void Method_1008_bc9f()
        {
            ii(0x1008_bc9f, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_bca4, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a0a9); /* call 0x10165d52 */
            ii(0x1008_bca9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_bcaa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_bcab, 1); pushd(esi);                             /* push esi */
            ii(0x1008_bcac, 1); pushd(edi);                             /* push edi */
            ii(0x1008_bcad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_bcae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_bcb0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_bcb6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_bcb9, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_bcbc, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_bcc3, 2); jmpd(0x1008_bccb, 0x6); goto l_0x1008_bccb; /* jmp 0x1008bccb */
        l_0x1008_bcc5:
            ii(0x1008_bcc5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_bcc8, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x1008_bccb:
            ii(0x1008_bccb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_bcce, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_bcd1, 4); cmp(ax, memw_a32[ds, edx + 0x4]);       /* cmp ax, [edx+0x4] */
            ii(0x1008_bcd5, 2); if(jged(0x1008_bcf0, 0x19)) goto l_0x1008_bcf0; /* jge 0x1008bcf0 */
            ii(0x1008_bcd7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1008_bcdb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_bcde, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_bce0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bce3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_bce5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_bce7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_bce9, 5); calld(Definitions.sys_delete, 0xd_a276); /* call 0x10165f64 */
            ii(0x1008_bcee, 2); jmpd(0x1008_bcc5, -0x2b); goto l_0x1008_bcc5; /* jmp 0x1008bcc5 */
        l_0x1008_bcf0:
            ii(0x1008_bcf0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bcf3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_bcf5, 5); calld(Definitions.sys_delete, 0xd_a26a); /* call 0x10165f64 */
            ii(0x1008_bcfa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_bcfd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_bd00, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_bd03, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bd05, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_bd06, 1); popd(edi);                              /* pop edi */
            ii(0x1008_bd07, 1); popd(esi);                              /* pop esi */
            ii(0x1008_bd08, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_bd09, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_bd0a, 1); retd(); return;                         /* ret */
        }
    }
}
