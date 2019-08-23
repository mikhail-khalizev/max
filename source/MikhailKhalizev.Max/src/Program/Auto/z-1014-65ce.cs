using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_65ce-231159dd")]
        public void Method_1014_65ce()
        {
            ii(0x1014_65ce, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1014_65d3, 5); call(Definitions.sys_check_available_stack_size, 0x1_f77a); /* call 0x10165d52 */
            ii(0x1014_65d8, 1); push(ebx);                              /* push ebx */
            ii(0x1014_65d9, 1); push(ecx);                              /* push ecx */
            ii(0x1014_65da, 1); push(esi);                              /* push esi */
            ii(0x1014_65db, 1); push(edi);                              /* push edi */
            ii(0x1014_65dc, 1); push(ebp);                              /* push ebp */
            ii(0x1014_65dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_65df, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1014_65e5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_65e8, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_65eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_65ee, 5); call(0x1014_66df, 0xec);                /* call 0x101466df */
            ii(0x1014_65f3, 5); mov(edx, StringDefinitions.Rt6);        /* mov edx, 0x101ad01c */
            ii(0x1014_65f8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_65fb, 5); call(Definitions.sys_fopen, 0x2_bd7a);  /* call 0x1017237a */
            ii(0x1014_6600, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6602, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6605, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1014_6607, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_660a, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1014_660d, 2); if(jnz(0x1014_6618, 0x9)) goto l_0x1014_6618; /* jnz 0x10146618 */
            ii(0x1014_660f, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1014_6613, 5); jmp(0x1014_66d4, 0xbc); goto l_0x1014_66d4; /* jmp 0x101466d4 */
        l_0x1014_6618:
            ii(0x1014_6618, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1014_661d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_661f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6622, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_6624, 5); call(Definitions.sys_fseek, 0x2_be47);  /* call 0x10172470 */
            ii(0x1014_6629, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_662c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_662e, 5); call(Definitions.sys_ftell, 0x2_c114);  /* call 0x10172747 */
            ii(0x1014_6633, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6635, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6638, 3); mov(memd[ds, eax + 0x20], edx);         /* mov [eax+0x20], edx */
            ii(0x1014_663b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_663d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_663f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6642, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_6644, 5); call(Definitions.sys_fseek, 0x2_be27);  /* call 0x10172470 */
            ii(0x1014_6649, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_664c, 7); mov(memd[ds, eax + 0x16], 0);           /* mov dword [eax+0x16], 0x0 */
            ii(0x1014_6653, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6656, 6); mov(memw[ds, eax + 0x1a], 0);           /* mov word [eax+0x1a], 0x0 */
            ii(0x1014_665c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_665f, 7); mov(memd[ds, eax + 0x1c], 0x20);        /* mov dword [eax+0x1c], 0x20 */
            ii(0x1014_6666, 5); mov(eax, 0x28);                         /* mov eax, 0x28 */
            ii(0x1014_666b, 5); call(Definitions.sys_new, 0x1_f790);    /* call 0x10165e00 */
            ii(0x1014_6670, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_6673, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_6676, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_6679, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_667d, 2); if(jz(0x1014_66b2, 0x33)) goto l_0x1014_66b2; /* jz 0x101466b2 */
            ii(0x1014_667f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6682, 1); push(eax);                              /* push eax */
            ii(0x1014_6683, 5); mov(ecx, 0x7d);                         /* mov ecx, 0x7d */
            ii(0x1014_6688, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_668b, 3); add(ebx, 0x12);                         /* add ebx, 0x12 */
            ii(0x1014_668e, 5); mov(edx, StringDefinitions.Empty12);    /* mov edx, 0x101ad01f */
            ii(0x1014_6693, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_6696, 5); call(Definitions.my_string_ctor_char_ptr, -0x4c60); /* call 0x10141a3b */
            ii(0x1014_669b, 3); mov(esi, memd[ss, ebp - 0x10]);         /* mov esi, [ebp-0x10] */
            ii(0x1014_669e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_66a0, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1014_66a2, 5); call(0x1014_5a6b, -0xc3c);              /* call 0x10145a6b */
            ii(0x1014_66a7, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_66aa, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_66ad, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_66b0, 2); jmp(0x1014_66b8, 0x6); goto l_0x1014_66b8; /* jmp 0x101466b8 */
        l_0x1014_66b2:
            ii(0x1014_66b2, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_66b5, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
        l_0x1014_66b8:
            ii(0x1014_66b8, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x1014_66bb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_66be, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_66c1, 5); call(0x1014_7b94, 0x14ce);              /* call 0x10147b94 */
            ii(0x1014_66c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_66c8, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1014_66cb, 5); call(Definitions.my_string_dtor, -0x4ba6); /* call 0x10141b2a */
            ii(0x1014_66d0, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
        l_0x1014_66d4:
            ii(0x1014_66d4, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1014_66d7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_66d9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_66da, 1); pop(edi);                               /* pop edi */
            ii(0x1014_66db, 1); pop(esi);                               /* pop esi */
            ii(0x1014_66dc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_66dd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_66de, 1); ret();                                  /* ret */
        }
    }
}
