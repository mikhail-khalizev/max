using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb0c9225-1a8b-4adf-a3b1-aa0a8c2e970d")]
        public void Method_1011_db8c()
        {
            ii(0x1011_db8c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_db91, 5); calld(Definitions.sys_check_available_stack_size, 0x4_81bc); /* call 0x10165d52 */
            ii(0x1011_db96, 1); pushd(esi);                             /* push esi */
            ii(0x1011_db97, 1); pushd(edi);                             /* push edi */
            ii(0x1011_db98, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_db99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_db9b, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_dba1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_dba4, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1011_dba7, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1011_dbaa, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_dbad, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_dbb1, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_dbb4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_dbb7, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x1011_dbba, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_dbbc, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1011_dbc0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_dbc2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_dbc4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_dbc7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dbca, 3); sub(memd_a32[ss, ebp - 0x4], eax);      /* sub [ebp-0x4], eax */
        l_0x1011_dbcd:
            ii(0x1011_dbcd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_dbd0, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x1011_dbd3, 1); cwde();                                 /* cwde */
            ii(0x1011_dbd4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_dbd6, 2); if(jled(0x1011_dbe3, 0xb)) goto l_0x1011_dbe3; /* jle 0x1011dbe3 */
            ii(0x1011_dbd8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_dbdb, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x1011_dbde, 3); or(memb_a32[ds, eax], 0x20);            /* or byte [eax], 0x20 */
            ii(0x1011_dbe1, 2); jmpd(0x1011_dbcd, -0x16); goto l_0x1011_dbcd; /* jmp 0x1011dbcd */
        l_0x1011_dbe3:
            ii(0x1011_dbe3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_dbe5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_dbe6, 1); popd(edi);                              /* pop edi */
            ii(0x1011_dbe7, 1); popd(esi);                              /* pop esi */
            ii(0x1011_dbe8, 1); retd(); return;                         /* ret */
        }
    }
}
