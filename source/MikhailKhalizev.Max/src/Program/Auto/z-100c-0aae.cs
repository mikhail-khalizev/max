using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_0aae-af78e86b")]
        public void Method_100c_0aae()
        {
            ii(0x100c_0aae, 5); push(0x4c);                             /* push 0x4c */
            ii(0x100c_0ab3, 5); call(Definitions.sys_check_available_stack_size, 0xa_529a); /* call 0x10165d52 */
            ii(0x100c_0ab8, 1); push(esi);                              /* push esi */
            ii(0x100c_0ab9, 1); push(edi);                              /* push edi */
            ii(0x100c_0aba, 1); push(ebp);                              /* push ebp */
            ii(0x100c_0abb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_0abd, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100c_0ac3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_0ac6, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100c_0ac9, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x100c_0acc, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x100c_0acf, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_0ad2, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x100c_0ad5, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100c_0ad8, 2); if(jle(0x100c_0ae3, 9)) goto l_0x100c_0ae3; /* jle 0x100c0ae3 */
            ii(0x100c_0ada, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x100c_0add, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_0ae0, 3); mov(memd[ss, ebp + 0x14], eax);         /* mov [ebp+0x14], eax */
        l_0x100c_0ae3:
            ii(0x100c_0ae3, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_0ae6, 3); mov(edx, memd[ss, ebp + 0x18]);         /* mov edx, [ebp+0x18] */
            ii(0x100c_0ae9, 3); sub(memw[ds, edx], ax);                 /* sub [edx], ax */
            ii(0x100c_0aec, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100c_0aef, 4); imul(eax, memd[ss, ebp + 0x14]);        /* imul eax, [ebp+0x14] */
            ii(0x100c_0af3, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_0af6, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100c_0afa, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x100c_0afc, 6); if(jle(0x100c_0c27, 0x125)) goto l_0x100c_0c27; /* jle 0x100c0c27 */
            ii(0x100c_0b02, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_0b05, 5); cmp(memw[ds, eax + 8], 0x47);           /* cmp word [eax+0x8], 0x47 */
            ii(0x100c_0b0a, 2); if(jz(0x100c_0b16, 0xa)) goto l_0x100c_0b16; /* jz 0x100c0b16 */
            ii(0x100c_0b0c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_0b0f, 5); cmp(memw[ds, eax + 8], 0x45);           /* cmp word [eax+0x8], 0x45 */
            ii(0x100c_0b14, 2); if(jnz(0x100c_0b1c, 6)) goto l_0x100c_0b1c; /* jnz 0x100c0b1c */
        l_0x100c_0b16:
            ii(0x100c_0b16, 4); mov(memb[ss, ebp - 0x1c], 1);           /* mov byte [ebp-0x1c], 0x1 */
            ii(0x100c_0b1a, 2); jmp(0x100c_0b20, 4); goto l_0x100c_0b20; /* jmp 0x100c0b20 */
        l_0x100c_0b1c:
            ii(0x100c_0b1c, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
        l_0x100c_0b20:
            ii(0x100c_0b20, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x100c_0b23, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x100c_0b26, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x100c_0b2a, 6); if(jz(0x100c_0bde, 0xae)) goto l_0x100c_0bde; /* jz 0x100c0bde */
            ii(0x100c_0b30, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_0b34, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_0b37, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100c_0b3a, 5); call(0x1007_5e64, -0x4_acdb);           /* call 0x10075e64 */
            ii(0x100c_0b3f, 3); lea(ecx, memd[ss, ebp - 0x30]);         /* lea ecx, [ebp-0x30] */
            ii(0x100c_0b42, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0b44, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_0b46, 5); call(0x100a_95c1, -0x1_758a);           /* call 0x100a95c1 */
        l_0x100c_0b4b:
            ii(0x100c_0b4b, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0b4e, 5); call(0x1008_982c, -0x3_7327);           /* call 0x1008982c */
            ii(0x100c_0b53, 1); cwde();                                 /* cwde */
            ii(0x100c_0b54, 6); mov(edx, memd[ds, 0x101c_8170]);        /* mov edx, [0x101c8170] */
            ii(0x100c_0b5a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_0b5d, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_0b60, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0b63, 5); call(0x1008_9860, -0x3_7308);           /* call 0x10089860 */
            ii(0x100c_0b68, 1); cwde();                                 /* cwde */
            ii(0x100c_0b69, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_0b6b, 6); mov(edx, memd[ds, 0x101c_9454]);        /* mov edx, [0x101c9454] */
            ii(0x100c_0b71, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_0b73, 3); test(memb[ds, eax], 6);                 /* test byte [eax], 0x6 */
            ii(0x100c_0b76, 2); if(jz(0x100c_0bcc, 0x54)) goto l_0x100c_0bcc; /* jz 0x100c0bcc */
            ii(0x100c_0b78, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0b7b, 5); call(0x1008_9860, -0x3_7320);           /* call 0x10089860 */
            ii(0x100c_0b80, 1); cwde();                                 /* cwde */
            ii(0x100c_0b81, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_0b84, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100c_0b87, 3); mov(edx, memd[ds, edx + 4]);            /* mov edx, [edx+0x4] */
            ii(0x100c_0b8a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_0b8c, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0b8f, 5); call(0x1008_982c, -0x3_7368);           /* call 0x1008982c */
            ii(0x100c_0b94, 1); cwde();                                 /* cwde */
            ii(0x100c_0b95, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_0b97, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_0b99, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_0b9b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_0b9e, 3); add(memw[ds, edx], ax);                 /* add [edx], ax */
            ii(0x100c_0ba1, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0ba4, 5); call(0x1008_9860, -0x3_7349);           /* call 0x10089860 */
            ii(0x100c_0ba9, 1); cwde();                                 /* cwde */
            ii(0x100c_0baa, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_0bad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0baf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0bb2, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_0bb5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_0bb7, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0bba, 5); call(0x1008_982c, -0x3_7393);           /* call 0x1008982c */
            ii(0x100c_0bbf, 1); cwde();                                 /* cwde */
            ii(0x100c_0bc0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_0bc2, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_0bc4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_0bc6, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x100c_0bc9, 3); add(memw[ds, edx], ax);                 /* add [edx], ax */
        l_0x100c_0bcc:
            ii(0x100c_0bcc, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_0bcf, 5); call(0x100a_96db, -0x1_74f9);           /* call 0x100a96db */
            ii(0x100c_0bd4, 2); test(al, al);                           /* test al, al */
            ii(0x100c_0bd6, 6); if(jnz(0x100c_0b4b, -0x91)) goto l_0x100c_0b4b; /* jnz 0x100c0b4b */
            ii(0x100c_0bdc, 2); jmp(0x100c_0c27, 0x49); goto l_0x100c_0c27; /* jmp 0x100c0c27 */
        l_0x100c_0bde:
            ii(0x100c_0bde, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0be0, 3); mov(al, memb[ss, ebp + 0x1c]);          /* mov al, [ebp+0x1c] */
            ii(0x100c_0be3, 1); push(eax);                              /* push eax */
            ii(0x100c_0be4, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x100c_0be8, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_0bec, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_0bef, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_0bf2, 5); call(0x1007_5e64, -0x4_ad93);           /* call 0x10075e64 */
            ii(0x100c_0bf7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0bf9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0bfc, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100c_0bff, 5); call(0x100c_093a, -0x2ca);              /* call 0x100c093a */
            ii(0x100c_0c04, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_0c06, 1); push(eax);                              /* push eax */
            ii(0x100c_0c07, 4); movsx(ecx, memw[ss, ebp + 0x14]);       /* movsx ecx, word [ebp+0x14] */
            ii(0x100c_0c0b, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_0c0f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_0c12, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100c_0c15, 5); call(0x1007_5e64, -0x4_adb6);           /* call 0x10075e64 */
            ii(0x100c_0c1a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_0c1c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0c1f, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_0c22, 5); call(0x100c_093a, -0x2ed);              /* call 0x100c093a */
        l_0x100c_0c27:
            ii(0x100c_0c27, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_0c29, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_0c2a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_0c2b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_0c2c, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}
