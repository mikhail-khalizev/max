using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_00c4-aca3d48e")]
        public void Method_1014_00c4()
        {
            ii(0x1014_00c4, 5); push(0x34);                             /* push 0x34 */
            ii(0x1014_00c9, 5); call(Definitions.sys_check_available_stack_size, 0x2_5c84); /* call 0x10165d52 */
            ii(0x1014_00ce, 1); push(esi);                              /* push esi */
            ii(0x1014_00cf, 1); push(edi);                              /* push edi */
            ii(0x1014_00d0, 1); push(ebp);                              /* push ebp */
            ii(0x1014_00d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_00d3, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1014_00d9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_00dc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_00df, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1014_00e2, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x1014_00e5, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_00ea, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1014_00ee, 5); call(0x100c_defa, -0x7_21f9);           /* call 0x100cdefa */
            ii(0x1014_00f3, 1); cwde();                                 /* cwde */
            ii(0x1014_00f4, 5); call(0x1007_1e00, -0xc_e2f9);           /* call 0x10071e00 */
            ii(0x1014_00f9, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_00fc, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_00ff, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1014_0102, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1014_0107, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1014_010b, 5); call(0x100c_defa, -0x7_2216);           /* call 0x100cdefa */
            ii(0x1014_0110, 1); cwde();                                 /* cwde */
            ii(0x1014_0111, 5); call(0x1007_1e00, -0xc_e316);           /* call 0x10071e00 */
            ii(0x1014_0116, 3); mov(edx, memd[ss, ebp + 0x10]);         /* mov edx, [ebp+0x10] */
            ii(0x1014_0119, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_011c, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1014_011f, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1014_0123, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1014_0126, 2); if(jge(0x1014_012f, 7)) goto l_0x1014_012f; /* jge 0x1014012f */
            ii(0x1014_0128, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1014_012f:
            ii(0x1014_012f, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1014_0133, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1014_0136, 2); if(jge(0x1014_013f, 7)) goto l_0x1014_013f; /* jge 0x1014013f */
            ii(0x1014_0138, 7); mov(memd[ss, ebp - 0x18], 1);           /* mov dword [ebp-0x18], 0x1 */
        l_0x1014_013f:
            ii(0x1014_013f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_0141, 1); push(eax);                              /* push eax */
            ii(0x1014_0142, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1014_0146, 1); push(eax);                              /* push eax */
            ii(0x1014_0147, 4); movsx(ecx, memw[ss, ebp + 0x1c]);       /* movsx ecx, word [ebp+0x1c] */
            ii(0x1014_014b, 5); mov(ebx, StringDefinitions.Cost);       /* mov ebx, 0x101ace09 */
            ii(0x1014_0150, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_0154, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0157, 5); call(0x1013_f4b0, -0xcac);              /* call 0x1013f4b0 */
            ii(0x1014_015c, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1014_0160, 1); push(eax);                              /* push eax */
            ii(0x1014_0161, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1014_0165, 1); push(eax);                              /* push eax */
            ii(0x1014_0166, 4); movsx(eax, memw[ss, ebp + 0x18]);       /* movsx eax, word [ebp+0x18] */
            ii(0x1014_016a, 1); push(eax);                              /* push eax */
            ii(0x1014_016b, 4); movsx(ecx, memw[ss, ebp + 0x14]);       /* movsx ecx, word [ebp+0x14] */
            ii(0x1014_016f, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1014_0172, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1014_0175, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_0178, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_017c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_017f, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1014_0182, 5); call(0x1013_f629, -0xb5e);              /* call 0x1013f629 */
            ii(0x1014_0187, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_0189, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_018a, 1); pop(edi);                               /* pop edi */
            ii(0x1014_018b, 1); pop(esi);                               /* pop esi */
            ii(0x1014_018c, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}
