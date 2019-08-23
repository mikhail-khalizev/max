using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2930-31ac411e")]
        public void Method_1014_2930()
        {
            ii(0x1014_2930, 5); push(0x44);                             /* push 0x44 */
            ii(0x1014_2935, 5); call(Definitions.sys_check_available_stack_size, 0x2_3418); /* call 0x10165d52 */
            ii(0x1014_293a, 1); push(esi);                              /* push esi */
            ii(0x1014_293b, 1); push(edi);                              /* push edi */
            ii(0x1014_293c, 1); push(ebp);                              /* push ebp */
            ii(0x1014_293d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_293f, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1014_2945, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_2948, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1014_294b, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_294e, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_2951, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1014_2955, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1014_295b, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x1014_2960, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_2962, 3); mov(memd[ss, ebp - 0x28], edx);         /* mov [ebp-0x28], edx */
            ii(0x1014_2965, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x1014_296a, 5); call(0x100e_883d, -0x5_a132);           /* call 0x100e883d */
            ii(0x1014_296f, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1014_2972, 5); mov(eax, memd[ds, 0x101c_38ec]);        /* mov eax, [0x101c38ec] */
            ii(0x1014_2977, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1014_297a, 6); mov(edx, memd[ds, 0x101c_38d8]);        /* mov edx, [0x101c38d8] */
            ii(0x1014_2980, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_2983, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_2985, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1014_2989, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_298b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_298e, 5); mov(eax, memd[ds, 0x101c_38f0]);        /* mov eax, [0x101c38f0] */
            ii(0x1014_2993, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1014_2996, 6); mov(edx, memd[ds, 0x101c_38da]);        /* mov edx, [0x101c38da] */
            ii(0x1014_299c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_299f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_29a1, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1014_29a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_29a7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_29aa, 5); mov(eax, memd[ds, 0x101c_38ec]);        /* mov eax, [0x101c38ec] */
            ii(0x1014_29af, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x1014_29b2, 6); mov(edx, memd[ds, 0x101c_38d8]);        /* mov edx, [0x101c38d8] */
            ii(0x1014_29b8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_29bb, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_29bd, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_29c1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_29c3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_29c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_29c9, 1); inc(eax);                               /* inc eax */
            ii(0x1014_29ca, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_29cd, 7); cmp(memb[ds, 0x101c_3910], 0);          /* cmp byte [0x101c3910], 0x0 */
            ii(0x1014_29d4, 2); if(jz(0x1014_29df, 0x9)) goto l_0x1014_29df; /* jz 0x101429df */
            ii(0x1014_29d6, 7); mov(memd[ss, ebp - 0x30], 0xffff);      /* mov dword [ebp-0x30], 0xffff */
            ii(0x1014_29dd, 2); jmp(0x1014_29e6, 0x7); goto l_0x1014_29e6; /* jmp 0x101429e6 */
        l_0x1014_29df:
            ii(0x1014_29df, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x1014_29e6:
            ii(0x1014_29e6, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1014_29e9, 6); mov(eax, memd[ds, eax + 0xfa]);         /* mov eax, [eax+0xfa] */
            ii(0x1014_29ef, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_29f2, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_29f7, 3); or(eax, memd[ss, ebp - 0x30]);          /* or eax, [ebp-0x30] */
            ii(0x1014_29fa, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1014_29fd, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1014_2a01, 5); mov(eax, memd[ds, 0x101c_38d8]);        /* mov eax, [0x101c38d8] */
            ii(0x1014_2a06, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2a09, 5); call(0x1007_6e7c, -0xc_bb92);           /* call 0x10076e7c */
            ii(0x1014_2a0e, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_2a11, 2); jmp(0x1014_2a19, 0x6); goto l_0x1014_2a19; /* jmp 0x10142a19 */
        l_0x1014_2a13:
            ii(0x1014_2a13, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_2a16, 3); inc(memd[ss, ebp - 0x20]);              /* inc dword [ebp-0x20] */
        l_0x1014_2a19:
            ii(0x1014_2a19, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_2a1d, 5); mov(eax, memd[ds, 0x101c_38dc]);        /* mov eax, [0x101c38dc] */
            ii(0x1014_2a22, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2a25, 1); inc(eax);                               /* inc eax */
            ii(0x1014_2a26, 5); call(Definitions.my_min, -0xb_92a7);    /* call 0x10089784 */
            ii(0x1014_2a2b, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2a2f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_2a31, 6); if(jge(0x1014_2b12, 0xdb)) goto l_0x1014_2b12; /* jge 0x10142b12 */
            ii(0x1014_2a37, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1014_2a3b, 5); mov(eax, memd[ds, 0x101c_38da]);        /* mov eax, [0x101c38da] */
            ii(0x1014_2a40, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2a43, 5); call(0x1007_6e7c, -0xc_bbcc);           /* call 0x10076e7c */
            ii(0x1014_2a48, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_2a4b, 2); jmp(0x1014_2a53, 0x6); goto l_0x1014_2a53; /* jmp 0x10142a53 */
        l_0x1014_2a4d:
            ii(0x1014_2a4d, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_2a50, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x1014_2a53:
            ii(0x1014_2a53, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1014_2a57, 5); mov(eax, memd[ds, 0x101c_38de]);        /* mov eax, [0x101c38de] */
            ii(0x1014_2a5c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2a5f, 1); inc(eax);                               /* inc eax */
            ii(0x1014_2a60, 5); call(Definitions.my_min, -0xb_92e1);    /* call 0x10089784 */
            ii(0x1014_2a65, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1014_2a69, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_2a6b, 6); if(jge(0x1014_2b0d, 0x9c)) goto l_0x1014_2b0d; /* jge 0x10142b0d */
            ii(0x1014_2a71, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1014_2a75, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1014_2a79, 5); call(0x1007_3d48, -0xc_ed36);           /* call 0x10073d48 */
            ii(0x1014_2a7e, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_2a83, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1014_2a86, 2); if(jz(0x1014_2a91, 0x9)) goto l_0x1014_2a91; /* jz 0x10142a91 */
            ii(0x1014_2a88, 7); mov(memd[ss, ebp - 0x34], 0x1);         /* mov dword [ebp-0x34], 0x1 */
            ii(0x1014_2a8f, 2); jmp(0x1014_2a98, 0x7); goto l_0x1014_2a98; /* jmp 0x10142a98 */
        l_0x1014_2a91:
            ii(0x1014_2a91, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
        l_0x1014_2a98:
            ii(0x1014_2a98, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1014_2a9c, 2); if(jz(0x1014_2acc, 0x2e)) goto l_0x1014_2acc; /* jz 0x10142acc */
            ii(0x1014_2a9e, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1014_2aa2, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1014_2aa7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2aaa, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1014_2aad, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1014_2ab1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2ab3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_2ab5, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x1014_2abb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2abd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_2abf, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1014_2ac2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_2ac4, 4); mov(ax, memw[ss, ebp - 0x24]);          /* mov ax, [ebp-0x24] */
            ii(0x1014_2ac8, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1014_2aca, 2); if(jnz(0x1014_2ace, 0x2)) goto l_0x1014_2ace; /* jnz 0x10142ace */
        l_0x1014_2acc:
            ii(0x1014_2acc, 2); jmp(0x1014_2b08, 0x3a); goto l_0x1014_2b08; /* jmp 0x10142b08 */
        l_0x1014_2ace:
            ii(0x1014_2ace, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x1014_2ad2, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1014_2ad7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_2ada, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1014_2add, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2ae1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2ae3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_2ae5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_2ae7, 5); mov(eax, memd[ds, 0x101c_811c]);        /* mov eax, [0x101c811c] */
            ii(0x1014_2aec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_2aee, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1014_2af1, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_2af4, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x1014_2af8, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1014_2afc, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1014_2b00, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1014_2b03, 5); call(0x1014_2590, -0x578);              /* call 0x10142590 */
        l_0x1014_2b08:
            ii(0x1014_2b08, 5); jmp(0x1014_2a4d, -0xc0); goto l_0x1014_2a4d; /* jmp 0x10142a4d */
        l_0x1014_2b0d:
            ii(0x1014_2b0d, 5); jmp(0x1014_2a13, -0xff); goto l_0x1014_2a13; /* jmp 0x10142a13 */
        l_0x1014_2b12:
            ii(0x1014_2b12, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2b14, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2b15, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2b16, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2b17, 1); ret();                                  /* ret */
        }
    }
}
