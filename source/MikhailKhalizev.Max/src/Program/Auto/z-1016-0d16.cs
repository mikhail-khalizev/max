using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_0d16-c9242224")]
        public void Method_1016_0d16()
        {
            ii(0x1016_0d16, 5); push(0x40);                             /* push 0x40 */
            ii(0x1016_0d1b, 5); call(Definitions.sys_check_available_stack_size, 0x5032); /* call 0x10165d52 */
            ii(0x1016_0d20, 1); push(ebx);                              /* push ebx */
            ii(0x1016_0d21, 1); push(ecx);                              /* push ecx */
            ii(0x1016_0d22, 1); push(edx);                              /* push edx */
            ii(0x1016_0d23, 1); push(esi);                              /* push esi */
            ii(0x1016_0d24, 1); push(edi);                              /* push edi */
            ii(0x1016_0d25, 1); push(ebp);                              /* push ebp */
            ii(0x1016_0d26, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_0d28, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1016_0d2e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1016_0d31, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d34, 4); test(memb[ds, eax + 0x15], 2);          /* test byte [eax+0x15], 0x2 */
            ii(0x1016_0d38, 2); if(jz(0x1016_0d45, 0xb)) goto l_0x1016_0d45; /* jz 0x10160d45 */
            ii(0x1016_0d3a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d3d, 3); mov(al, memb[ds, eax + 0x2e]);          /* mov al, [eax+0x2e] */
            ii(0x1016_0d40, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1016_0d43, 2); jmp(0x1016_0d4e, 9); goto l_0x1016_0d4e; /* jmp 0x10160d4e */
        l_0x1016_0d45:
            ii(0x1016_0d45, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d48, 3); mov(al, memb[ds, eax + 0x29]);          /* mov al, [eax+0x29] */
            ii(0x1016_0d4b, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1016_0d4e:
            ii(0x1016_0d4e, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1016_0d51, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1016_0d54, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d57, 4); mov(ax, memw[ds, eax + 0x41]);          /* mov ax, [eax+0x41] */
            ii(0x1016_0d5b, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_0d5e, 4); sub(ax, memw[ds, edx + 0x1a]);          /* sub ax, [edx+0x1a] */
            ii(0x1016_0d62, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1016_0d65, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d68, 4); mov(ax, memw[ds, eax + 0x43]);          /* mov ax, [eax+0x43] */
            ii(0x1016_0d6c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_0d6f, 4); sub(ax, memw[ds, edx + 0x1c]);          /* sub ax, [edx+0x1c] */
            ii(0x1016_0d73, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1016_0d76, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1016_0d7a, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1016_0d7e, 5); call(0x1015_c339, -0x4a4a);             /* call 0x1015c339 */
            ii(0x1016_0d83, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1016_0d86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_0d88, 3); mov(dl, memb[ss, ebp - 8]);             /* mov dl, [ebp-0x8] */
            ii(0x1016_0d8b, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1016_0d8f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_0d91, 6); if(jnz(0x1016_0e43, 0xac)) goto l_0x1016_0e43; /* jnz 0x10160e43 */
            ii(0x1016_0d97, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0d9a, 4); mov(memb[ds, eax + 0x3e], 8);           /* mov byte [eax+0x3e], 0x8 */
            ii(0x1016_0d9e, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1016_0da5, 2); jmp(0x1016_0dad, 6); goto l_0x1016_0dad; /* jmp 0x10160dad */
        l_0x1016_0da7:
            ii(0x1016_0da7, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1016_0daa, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1016_0dad:
            ii(0x1016_0dad, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1016_0db1, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1016_0db4, 6); if(jge(0x1016_0e37, 0x7d)) goto l_0x1016_0e37; /* jge 0x10160e37 */
            ii(0x1016_0dba, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0dbd, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1016_0dc0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0dc5, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1016_0dc9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_0dcb, 2); if(jz(0x1016_0de6, 0x19)) goto l_0x1016_0de6; /* jz 0x10160de6 */
            ii(0x1016_0dcd, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1016_0dd1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0dd7, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1016_0ddd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0de2, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0de4, 2); if(jnz(0x1016_0de8, 2)) goto l_0x1016_0de8; /* jnz 0x10160de8 */
        l_0x1016_0de6:
            ii(0x1016_0de6, 2); jmp(0x1016_0e24, 0x3c); goto l_0x1016_0e24; /* jmp 0x10160e24 */
        l_0x1016_0de8:
            ii(0x1016_0de8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0deb, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1016_0dee, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_0df1, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1016_0df6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_0df9, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1016_0dfc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0dff, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1016_0e02, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_0e05, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_0e07, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1016_0e0b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_0e11, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1016_0e17, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_0e19, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1016_0e1b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_0e20, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_0e22, 2); if(jnz(0x1016_0e26, 2)) goto l_0x1016_0e26; /* jnz 0x10160e26 */
        l_0x1016_0e24:
            ii(0x1016_0e24, 2); jmp(0x1016_0e32, 0xc); goto l_0x1016_0e32; /* jmp 0x10160e32 */
        l_0x1016_0e26:
            ii(0x1016_0e26, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1016_0e2a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0e2d, 5); call(0x1014_f634, -0x1_17fe);           /* call 0x1014f634 */
        l_0x1016_0e32:
            ii(0x1016_0e32, 5); jmp(0x1016_0da7, -0x90); goto l_0x1016_0da7; /* jmp 0x10160da7 */
        l_0x1016_0e37:
            ii(0x1016_0e37, 7); mov(memd[ss, ebp - 0x20], 1);           /* mov dword [ebp-0x20], 0x1 */
            ii(0x1016_0e3e, 5); jmp(0x1016_0eb7, 0x74); goto l_0x1016_0eb7; /* jmp 0x10160eb7 */
        l_0x1016_0e43:
            ii(0x1016_0e43, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0e45, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_0e48, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1016_0e4b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_0e4d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_0e4f, 5); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1016_0e54, 5); and(eax, 7);                            /* and eax, 0x7 */
            ii(0x1016_0e59, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1016_0e5c, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1016_0e60, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1016_0e63, 2); if(jle(0x1016_0e6e, 9)) goto l_0x1016_0e6e; /* jle 0x10160e6e */
            ii(0x1016_0e65, 7); mov(memd[ss, ebp - 0x14], 0xffff_ffff); /* mov dword [ebp-0x14], 0xffffffff */
            ii(0x1016_0e6c, 2); jmp(0x1016_0e75, 7); goto l_0x1016_0e75; /* jmp 0x10160e75 */
        l_0x1016_0e6e:
            ii(0x1016_0e6e, 7); mov(memd[ss, ebp - 0x14], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1016_0e75:
            ii(0x1016_0e75, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_0e78, 3); add(al, memb[ss, ebp - 0x14]);          /* add al, [ebp-0x14] */
            ii(0x1016_0e7b, 2); and(al, 7);                             /* and al, 0x7 */
            ii(0x1016_0e7d, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1016_0e80, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0e83, 4); test(memb[ds, eax + 0x15], 2);          /* test byte [eax+0x15], 0x2 */
            ii(0x1016_0e87, 2); if(jz(0x1016_0ea0, 0x17)) goto l_0x1016_0ea0; /* jz 0x10160ea0 */
            ii(0x1016_0e89, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_0e8e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0e90, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_0e93, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0e96, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0e99, 5); call(0x1014_e788, -0x1_2716);           /* call 0x1014e788 */
            ii(0x1016_0e9e, 2); jmp(0x1016_0eb0, 0x10); goto l_0x1016_0eb0; /* jmp 0x10160eb0 */
        l_0x1016_0ea0:
            ii(0x1016_0ea0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_0ea2, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_0ea5, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_0ea8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_0eab, 5); call(0x1014_9fe6, -0x1_6eca);           /* call 0x10149fe6 */
        l_0x1016_0eb0:
            ii(0x1016_0eb0, 7); mov(memd[ss, ebp - 0x20], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1016_0eb7:
            ii(0x1016_0eb7, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1016_0eba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_0ebc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_0ebd, 1); pop(edi);                               /* pop edi */
            ii(0x1016_0ebe, 1); pop(esi);                               /* pop esi */
            ii(0x1016_0ebf, 1); pop(edx);                               /* pop edx */
            ii(0x1016_0ec0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_0ec1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_0ec2, 1); ret();                                  /* ret */
        }
    }
}
