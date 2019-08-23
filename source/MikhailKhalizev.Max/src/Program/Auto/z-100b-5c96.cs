using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5c96-bf058702")]
        public void Method_100b_5c96()
        {
            ii(0x100b_5c96, 5); push(0x38);                             /* push 0x38 */
            ii(0x100b_5c9b, 5); call(Definitions.sys_check_available_stack_size, 0xb_00b2); /* call 0x10165d52 */
            ii(0x100b_5ca0, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5ca1, 1); push(esi);                              /* push esi */
            ii(0x100b_5ca2, 1); push(edi);                              /* push edi */
            ii(0x100b_5ca3, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5ca4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5ca6, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100b_5cac, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_5caf, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100b_5cb2, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100b_5cb5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5cb8, 5); call(0x1007_6338, -0x3_f985);           /* call 0x10076338 */
            ii(0x100b_5cbd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5cbf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5cc2, 5); call(0x1007_64b8, -0x3_f80f);           /* call 0x100764b8 */
            ii(0x100b_5cc7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_5cca, 5); call(Definitions.my_ctor_0x101b_4184, -0x3_f1df); /* call 0x10076af0 */
            ii(0x100b_5ccf, 2); jmp(0x100b_5cd9, 0x8); goto l_0x100b_5cd9; /* jmp 0x100b5cd9 */
        l_0x100b_5cd1:
            ii(0x100b_5cd1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5cd4, 5); call(0x1007_6bf8, -0x3_f0e1);           /* call 0x10076bf8 */
        l_0x100b_5cd9:
            ii(0x100b_5cd9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5cdb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5cde, 5); call(0x1013_ad71, 0x8_508e);            /* call 0x1013ad71 */
            ii(0x100b_5ce3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_5ce5, 6); if(jz(0x100b_5d74, 0x89)) goto l_0x100b_5d74; /* jz 0x100b5d74 */
            ii(0x100b_5ceb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5cee, 5); call(0x1007_63a0, -0x3_f953);           /* call 0x100763a0 */
            ii(0x100b_5cf3, 4); cmp(memb[ds, eax + 0x3d], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100b_5cf7, 2); if(jz(0x100b_5d12, 0x19)) goto l_0x100b_5d12; /* jz 0x100b5d12 */
            ii(0x100b_5cf9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5cfc, 5); call(0x1007_6408, -0x3_f8f9);           /* call 0x10076408 */
            ii(0x100b_5d01, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_5d03, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_5d06, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_5d09, 5); call(0x1007_6600, -0x3_f70e);           /* call 0x10076600 */
            ii(0x100b_5d0e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_5d10, 2); if(jnz(0x100b_5d14, 0x2)) goto l_0x100b_5d14; /* jnz 0x100b5d14 */
        l_0x100b_5d12:
            ii(0x100b_5d12, 2); jmp(0x100b_5d6f, 0x5b); goto l_0x100b_5d6f; /* jmp 0x100b5d6f */
        l_0x100b_5d14:
            ii(0x100b_5d14, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x100b_5d17, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5d1a, 5); call(0x1007_63a0, -0x3_f97f);           /* call 0x100763a0 */
            ii(0x100b_5d1f, 5); call(0x1015_2532, 0x9_c80e);            /* call 0x10152532 */
            ii(0x100b_5d24, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100b_5d27, 4); mov(memw[ss, ebp - 0x10], ax);          /* mov [ebp-0x10], ax */
            ii(0x100b_5d2b, 2); jmp(0x100b_5d34, 0x7); goto l_0x100b_5d34; /* jmp 0x100b5d34 */
        l_0x100b_5d2d:
            ii(0x100b_5d2d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_5d30, 4); inc(memw[ss, ebp - 0x10]);              /* inc word [ebp-0x10] */
        l_0x100b_5d34:
            ii(0x100b_5d34, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_5d38, 3); cmp(eax, memd[ss, ebp - 0x1c]);         /* cmp eax, [ebp-0x1c] */
            ii(0x100b_5d3b, 2); if(jge(0x100b_5d6f, 0x32)) goto l_0x100b_5d6f; /* jge 0x100b5d6f */
            ii(0x100b_5d3d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100b_5d40, 4); mov(memw[ss, ebp - 0xe], ax);           /* mov [ebp-0xe], ax */
            ii(0x100b_5d44, 2); jmp(0x100b_5d4d, 0x7); goto l_0x100b_5d4d; /* jmp 0x100b5d4d */
        l_0x100b_5d46:
            ii(0x100b_5d46, 3); mov(eax, memd[ss, ebp - 0xe]);          /* mov eax, [ebp-0xe] */
            ii(0x100b_5d49, 4); inc(memw[ss, ebp - 0xe]);               /* inc word [ebp-0xe] */
        l_0x100b_5d4d:
            ii(0x100b_5d4d, 4); movsx(eax, memw[ss, ebp - 0xe]);        /* movsx eax, word [ebp-0xe] */
            ii(0x100b_5d51, 3); cmp(eax, memd[ss, ebp - 0x18]);         /* cmp eax, [ebp-0x18] */
            ii(0x100b_5d54, 2); if(jge(0x100b_5d6d, 0x17)) goto l_0x100b_5d6d; /* jge 0x100b5d6d */
            ii(0x100b_5d56, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100b_5d5a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_5d5d, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x100b_5d60, 4); movsx(edx, memw[ss, ebp - 0xe]);        /* movsx edx, word [ebp-0xe] */
            ii(0x100b_5d64, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_5d66, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_5d68, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x100b_5d6b, 2); jmp(0x100b_5d46, -0x27); goto l_0x100b_5d46; /* jmp 0x100b5d46 */
        l_0x100b_5d6d:
            ii(0x100b_5d6d, 2); jmp(0x100b_5d2d, -0x42); goto l_0x100b_5d2d; /* jmp 0x100b5d2d */
        l_0x100b_5d6f:
            ii(0x100b_5d6f, 5); jmp(0x100b_5cd1, -0xa3); goto l_0x100b_5cd1; /* jmp 0x100b5cd1 */
        l_0x100b_5d74:
            ii(0x100b_5d74, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_5d76, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_5d79, 5); call(0x1007_5f6c, -0x3_fe12);           /* call 0x10075f6c */
            ii(0x100b_5d7e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5d80, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5d81, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5d82, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5d83, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5d84, 1); ret();                                  /* ret */
        }
    }
}
