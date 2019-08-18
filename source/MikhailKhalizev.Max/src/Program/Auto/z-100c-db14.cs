using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d374f2e2-a8eb-4582-9d40-a6203a0ad796")]
        public void Method_100c_db14()
        {
            ii(0x100c_db14, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_db19, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8234); /* call 0x10165d52 */
            ii(0x100c_db1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_db1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_db20, 1); pushd(esi);                             /* push esi */
            ii(0x100c_db21, 1); pushd(edi);                             /* push edi */
            ii(0x100c_db22, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_db23, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_db25, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_db2b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_db2e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_db31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_db34, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_db37, 4); cmp(ax, memw_a32[ds, edx + 0x2]);       /* cmp ax, [edx+0x2] */
            ii(0x100c_db3b, 2); if(jged(0x100c_db9d, 0x60)) goto l_0x100c_db9d; /* jge 0x100cdb9d */
            ii(0x100c_db3d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db40, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_db42, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_db45, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_db49, 1); dec(eax);                               /* dec eax */
            ii(0x100c_db4a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_db4c, 2); if(jged(0x100c_db96, 0x48)) goto l_0x100c_db96; /* jge 0x100cdb96 */
            ii(0x100c_db4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db51, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100c_db53, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_db56, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100c_db5a, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100c_db5c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db5f, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x100c_db62, 1); dec(edx);                               /* dec edx */
            ii(0x100c_db63, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100c_db66, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_db6a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db6d, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_db70, 1); inc(edx);                               /* inc edx */
            ii(0x100c_db71, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_db74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db77, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_db7a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_db7c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db7f, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_db82, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100c_db86, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x100c_db89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db8c, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100c_db8f, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_db91, 5); calld(Definitions.sys_memcpy, 0x9_82b5); /* call 0x10165e4b */
        l_0x100c_db96:
            ii(0x100c_db96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_db99, 4); dec(memw_a32[ds, eax + 0x2]);           /* dec word [eax+0x2] */
        l_0x100c_db9d:
            ii(0x100c_db9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_db9f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_dba0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_dba1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_dba2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_dba3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_dba4, 1); retd(); return;                         /* ret */
        }
    }
}
