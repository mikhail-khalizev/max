using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4d10-3a7b6d1e")]
        public void Method_1013_4d10()
        {
            ii(0x1013_4d10, 5); push(0x38);                             /* push 0x38 */
            ii(0x1013_4d15, 5); call(Definitions.sys_check_available_stack_size, 0x3_1038); /* call 0x10165d52 */
            ii(0x1013_4d1a, 1); push(esi);                              /* push esi */
            ii(0x1013_4d1b, 1); push(edi);                              /* push edi */
            ii(0x1013_4d1c, 1); push(ebp);                              /* push ebp */
            ii(0x1013_4d1d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_4d1f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1013_4d25, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_4d28, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_4d2b, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_4d2e, 3); mov(memd[ss, ebp - 0x10], ecx);         /* mov [ebp-0x10], ecx */
            ii(0x1013_4d31, 5); mov(eax, 0x45);                         /* mov eax, 0x45 */
            ii(0x1013_4d36, 5); call(0x1007_5fdc, -0xb_ed5f);           /* call 0x10075fdc */
            ii(0x1013_4d3b, 5); add(eax, 0x76e);                        /* add eax, 0x76e */
            ii(0x1013_4d40, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_4d43, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_4d47, 5); cmp(eax, 0x76e);                        /* cmp eax, 0x76e */
            ii(0x1013_4d4c, 2); if(jl(0x1013_4d59, 0xb)) goto l_0x1013_4d59; /* jl 0x10134d59 */
            ii(0x1013_4d4e, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_4d52, 5); cmp(eax, 0x773);                        /* cmp eax, 0x773 */
            ii(0x1013_4d57, 2); if(jle(0x1013_4d5b, 0x2)) goto l_0x1013_4d5b; /* jle 0x10134d5b */
        l_0x1013_4d59:
            ii(0x1013_4d59, 2); jmp(0x1013_4d64, 0x9); goto l_0x1013_4d64; /* jmp 0x10134d64 */
        l_0x1013_4d5b:
            ii(0x1013_4d5b, 7); mov(memd[ss, ebp - 0x18], 0x3f);        /* mov dword [ebp-0x18], 0x3f */
            ii(0x1013_4d62, 2); jmp(0x1013_4d6b, 0x7); goto l_0x1013_4d6b; /* jmp 0x10134d6b */
        l_0x1013_4d64:
            ii(0x1013_4d64, 7); mov(memd[ss, ebp - 0x18], 0x1f);        /* mov dword [ebp-0x18], 0x1f */
        l_0x1013_4d6b:
            ii(0x1013_4d6b, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_4d72, 2); jmp(0x1013_4d78, 0x4); goto l_0x1013_4d78; /* jmp 0x10134d78 */
        l_0x1013_4d74:
            ii(0x1013_4d74, 4); add(memd[ss, ebp - 0x1c], 0x3);         /* add dword [ebp-0x1c], 0x3 */
        l_0x1013_4d78:
            ii(0x1013_4d78, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_4d7c, 5); cmp(eax, 0x300);                        /* cmp eax, 0x300 */
            ii(0x1013_4d81, 6); if(jge(0x1013_4e53, 0xcc)) goto l_0x1013_4e53; /* jge 0x10134e53 */
            ii(0x1013_4d87, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_4d8b, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_4d91, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4d93, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4d95, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1013_4d97, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_4d9a, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_4d9e, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_4da4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4da6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4da8, 3); mov(al, memb[ds, edx + 0x1]);           /* mov al, [edx+0x1] */
            ii(0x1013_4dab, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_4dae, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_4db2, 6); mov(edx, memd[ds, Definitions.ptr_to_pallete]); /* mov edx, [0x101c9464] */
            ii(0x1013_4db8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_4dba, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_4dbc, 3); mov(al, memb[ds, edx + 0x2]);           /* mov al, [edx+0x2] */
            ii(0x1013_4dbf, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_4dc2, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1013_4dc6, 3); sar(edx, 0x2);                          /* sar edx, 0x2 */
            ii(0x1013_4dc9, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_4dcd, 5); call(0x1007_6e7c, -0xb_df56);           /* call 0x10076e7c */
            ii(0x1013_4dd2, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1013_4dd6, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_4dd9, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1013_4ddd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_4ddf, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_4de2, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_4de4, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_4de7, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_4deb, 3); sar(edx, 0x2);                          /* sar edx, 0x2 */
            ii(0x1013_4dee, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_4df2, 5); call(0x1007_6e7c, -0xb_df7b);           /* call 0x10076e7c */
            ii(0x1013_4df7, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_4dfb, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_4dfe, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1013_4e02, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_4e04, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_4e07, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_4e09, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_4e0c, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_4e10, 3); sar(edx, 0x2);                          /* sar edx, 0x2 */
            ii(0x1013_4e13, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1013_4e17, 5); call(0x1007_6e7c, -0xb_dfa0);           /* call 0x10076e7c */
            ii(0x1013_4e1c, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_4e20, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1013_4e23, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1013_4e27, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_4e29, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_4e2c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_4e2e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_4e31, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_4e33, 4); movsx(ebx, memw[ss, ebp - 0x28]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1013_4e37, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_4e3b, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1013_4e3f, 5); call(0x1013_3a88, -0x13bc);             /* call 0x10133a88 */
            ii(0x1013_4e44, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_4e46, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_4e49, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x1013_4e4c, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1013_4e4e, 5); jmp(0x1013_4d74, -0xdf); goto l_0x1013_4d74; /* jmp 0x10134d74 */
        l_0x1013_4e53:
            ii(0x1013_4e53, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_4e55, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_4e56, 1); pop(edi);                               /* pop edi */
            ii(0x1013_4e57, 1); pop(esi);                               /* pop esi */
            ii(0x1013_4e58, 1); ret();                                  /* ret */
        }
    }
}
