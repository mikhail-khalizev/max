using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e4eb-397b5480")]
        public void Method_1009_e4eb()
        {
            ii(0x1009_e4eb, 5); push(0x84);                             /* push 0x84 */
            ii(0x1009_e4f0, 5); call(Definitions.sys_check_available_stack_size, 0xc_785d); /* call 0x10165d52 */
            ii(0x1009_e4f5, 1); push(ebx);                              /* push ebx */
            ii(0x1009_e4f6, 1); push(ecx);                              /* push ecx */
            ii(0x1009_e4f7, 1); push(esi);                              /* push esi */
            ii(0x1009_e4f8, 1); push(edi);                              /* push edi */
            ii(0x1009_e4f9, 1); push(ebp);                              /* push ebp */
            ii(0x1009_e4fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_e4fc, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x1009_e502, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_e505, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_e508, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_e50b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e50e, 5); call(0x1015_2a52, 0xb_453f);            /* call 0x10152a52 */
            ii(0x1009_e513, 2); test(al, al);                           /* test al, al */
            ii(0x1009_e515, 2); if(jnz(0x1009_e520, 0x9)) goto l_0x1009_e520; /* jnz 0x1009e520 */
            ii(0x1009_e517, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_e51b, 5); jmp(0x1009_e839, 0x319); goto l_0x1009_e839; /* jmp 0x1009e839 */
        l_0x1009_e520:
            ii(0x1009_e520, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e523, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1009_e526, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_e52b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_e52d, 2); if(jnz(0x1009_e538, 0x9)) goto l_0x1009_e538; /* jnz 0x1009e538 */
            ii(0x1009_e52f, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_e533, 5); jmp(0x1009_e839, 0x301); goto l_0x1009_e839; /* jmp 0x1009e839 */
        l_0x1009_e538:
            ii(0x1009_e538, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_e53c, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_e53f, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_7a54); /* call 0x10076af0 */
            ii(0x1009_e544, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_e547, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_7a5c); /* call 0x10076af0 */
            ii(0x1009_e54c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e54f, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_e552, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e555, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_e55b, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1009_e561, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_e564, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_e567, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1009_e56e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e571, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1009_e574, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e577, 3); lea(edx, memd[ds, eax - 0x5]);          /* lea edx, [eax-0x5] */
            ii(0x1009_e57a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_e57f, 5); call(0x1007_6e7c, -0x2_7708);           /* call 0x10076e7c */
            ii(0x1009_e584, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1009_e587, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e58a, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1009_e58d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e590, 3); lea(edx, memd[ds, eax + 0x6]);          /* lea edx, [eax+0x6] */
            ii(0x1009_e593, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1009_e598, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e59b, 1); dec(eax);                               /* dec eax */
            ii(0x1009_e59c, 5); call(Definitions.my_min, -0x1_4e1d);    /* call 0x10089784 */
            ii(0x1009_e5a1, 3); mov(memd[ss, ebp - 0x3c], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_e5a4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e5a7, 3); mov(edx, memd[ds, edx + 0x1a]);         /* mov edx, [edx+0x1a] */
            ii(0x1009_e5aa, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_e5ad, 3); sub(edx, 0x5);                          /* sub edx, 0x5 */
            ii(0x1009_e5b0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_e5b5, 5); call(0x1007_6e7c, -0x2_773e);           /* call 0x10076e7c */
            ii(0x1009_e5ba, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1009_e5bd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e5c0, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1009_e5c3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e5c6, 3); lea(edx, memd[ds, eax + 0x6]);          /* lea edx, [eax+0x6] */
            ii(0x1009_e5c9, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_e5ce, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e5d1, 1); dec(eax);                               /* dec eax */
            ii(0x1009_e5d2, 5); call(Definitions.my_min, -0x1_4e53);    /* call 0x10089784 */
            ii(0x1009_e5d7, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1009_e5da, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1009_e5df, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_e5e4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e5e7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e5ea, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_e5ed, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e5f0, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1009_e5f6, 5); mov(esi, 0x101c_31c4);                  /* mov esi, 0x101c31c4 */
            ii(0x1009_e5fb, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1009_e5fd, 5); call(0x100c_1fd4, 0x2_39d2);            /* call 0x100c1fd4 */
            ii(0x1009_e602, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1009_e605, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x1009_e608, 4); mov(memw[ss, ebp - 0x30], ax);          /* mov [ebp-0x30], ax */
            ii(0x1009_e60c, 2); jmp(0x1009_e615, 0x7); goto l_0x1009_e615; /* jmp 0x1009e615 */
        l_0x1009_e60e:
            ii(0x1009_e60e, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_e611, 4); inc(memw[ss, ebp - 0x30]);              /* inc word [ebp-0x30] */
        l_0x1009_e615:
            ii(0x1009_e615, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_e619, 3); cmp(eax, memd[ss, ebp - 0x3c]);         /* cmp eax, [ebp-0x3c] */
            ii(0x1009_e61c, 6); if(jge(0x1009_e79a, 0x178)) goto l_0x1009_e79a; /* jge 0x1009e79a */
            ii(0x1009_e622, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_e625, 4); mov(memw[ss, ebp - 0x2e], ax);          /* mov [ebp-0x2e], ax */
            ii(0x1009_e629, 2); jmp(0x1009_e632, 0x7); goto l_0x1009_e632; /* jmp 0x1009e632 */
        l_0x1009_e62b:
            ii(0x1009_e62b, 3); mov(eax, memd[ss, ebp - 0x2e]);         /* mov eax, [ebp-0x2e] */
            ii(0x1009_e62e, 4); inc(memw[ss, ebp - 0x2e]);              /* inc word [ebp-0x2e] */
        l_0x1009_e632:
            ii(0x1009_e632, 4); movsx(eax, memw[ss, ebp - 0x2e]);       /* movsx eax, word [ebp-0x2e] */
            ii(0x1009_e636, 3); cmp(eax, memd[ss, ebp - 0x38]);         /* cmp eax, [ebp-0x38] */
            ii(0x1009_e639, 6); if(jge(0x1009_e795, 0x156)) goto l_0x1009_e795; /* jge 0x1009e795 */
            ii(0x1009_e63f, 4); movsx(edx, memw[ss, ebp - 0x2e]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_e643, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1009_e648, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e64b, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_e64e, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_e652, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e654, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_e656, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x1009_e65c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e65e, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_e661, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_e664, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1009_e668, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_e66c, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_e66e, 2); if(jz(0x1009_e678, 0x8)) goto l_0x1009_e678; /* jz 0x1009e678 */
            ii(0x1009_e670, 6); test(memw[ss, ebp - 0x20], 0x1f);       /* test word [ebp-0x20], 0x1f */
            ii(0x1009_e676, 2); if(jnz(0x1009_e67d, 0x5)) goto l_0x1009_e67d; /* jnz 0x1009e67d */
        l_0x1009_e678:
            ii(0x1009_e678, 5); jmp(0x1009_e790, 0x113); goto l_0x1009_e790; /* jmp 0x1009e790 */
        l_0x1009_e67d:
            ii(0x1009_e67d, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x1009_e680, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_e683, 5); call(0x1007_5e64, -0x2_8824);           /* call 0x10075e64 */
            ii(0x1009_e688, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_e68b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_e68d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_e68f, 5); call(0x1007_0ca1, -0x2_d9f3);           /* call 0x10070ca1 */
            ii(0x1009_e694, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_e697, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1009_e69b, 2); if(jz(0x1009_e6a6, 0x9)) goto l_0x1009_e6a6; /* jz 0x1009e6a6 */
            ii(0x1009_e69d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_e6a0, 4); cmp(ax, memw[ss, ebp - 0x1c]);          /* cmp ax, [ebp-0x1c] */
            ii(0x1009_e6a4, 2); if(jle(0x1009_e6c1, 0x1b)) goto l_0x1009_e6c1; /* jle 0x1009e6c1 */
        l_0x1009_e6a6:
            ii(0x1009_e6a6, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_e6aa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_e6ad, 3); add(eax, memd[ss, ebp - 0x34]);         /* add eax, [ebp-0x34] */
            ii(0x1009_e6b0, 4); movsx(edx, memw[ss, ebp - 0x2e]);       /* movsx edx, word [ebp-0x2e] */
            ii(0x1009_e6b4, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1009_e6b6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_e6b8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e6ba, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_e6bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_e6bf, 2); if(jle(0x1009_e6c3, 0x2)) goto l_0x1009_e6c3; /* jle 0x1009e6c3 */
        l_0x1009_e6c1:
            ii(0x1009_e6c1, 2); jmp(0x1009_e6e9, 0x26); goto l_0x1009_e6e9; /* jmp 0x1009e6e9 */
        l_0x1009_e6c3:
            ii(0x1009_e6c3, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_e6c8, 1); push(eax);                              /* push eax */
            ii(0x1009_e6c9, 4); movsx(ecx, memw[ss, ebp - 0x2e]);       /* movsx ecx, word [ebp-0x2e] */
            ii(0x1009_e6cd, 4); movsx(ebx, memw[ss, ebp - 0x30]);       /* movsx ebx, word [ebp-0x30] */
            ii(0x1009_e6d1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e6d4, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1009_e6d7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_e6da, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x1009_e6df, 5); call(0x1007_02b9, -0x2_e42b);           /* call 0x100702b9 */
            ii(0x1009_e6e4, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1009_e6e7, 2); if(jnz(0x1009_e6ee, 0x5)) goto l_0x1009_e6ee; /* jnz 0x1009e6ee */
        l_0x1009_e6e9:
            ii(0x1009_e6e9, 5); jmp(0x1009_e790, 0xa2); goto l_0x1009_e790; /* jmp 0x1009e790 */
        l_0x1009_e6ee:
            ii(0x1009_e6ee, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_e6f1, 1); dec(eax);                               /* dec eax */
            ii(0x1009_e6f2, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_e6f5, 2); jmp(0x1009_e6fd, 0x6); goto l_0x1009_e6fd; /* jmp 0x1009e6fd */
        l_0x1009_e6f7:
            ii(0x1009_e6f7, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_e6fa, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
        l_0x1009_e6fd:
            ii(0x1009_e6fd, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1009_e701, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1009_e705, 1); inc(eax);                               /* inc eax */
            ii(0x1009_e706, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_e708, 6); if(jg(0x1009_e790, 0x82)) goto l_0x1009_e790; /* jg 0x1009e790 */
            ii(0x1009_e70e, 3); mov(eax, memd[ss, ebp - 0x2e]);         /* mov eax, [ebp-0x2e] */
            ii(0x1009_e711, 1); dec(eax);                               /* dec eax */
            ii(0x1009_e712, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_e715, 2); jmp(0x1009_e71d, 0x6); goto l_0x1009_e71d; /* jmp 0x1009e71d */
        l_0x1009_e717:
            ii(0x1009_e717, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_e71a, 3); inc(memd[ss, ebp - 0x28]);              /* inc dword [ebp-0x28] */
        l_0x1009_e71d:
            ii(0x1009_e71d, 4); movsx(eax, memw[ss, ebp - 0x2e]);       /* movsx eax, word [ebp-0x2e] */
            ii(0x1009_e721, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_e725, 1); inc(eax);                               /* inc eax */
            ii(0x1009_e726, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_e728, 2); if(jg(0x1009_e78b, 0x61)) goto l_0x1009_e78b; /* jg 0x1009e78b */
            ii(0x1009_e72a, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_e72e, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1009_e733, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e736, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1009_e739, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1009_e73d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e73f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_e741, 6); mov(edx, memd[ds, 0x101c_811c]);        /* mov edx, [0x101c811c] */
            ii(0x1009_e747, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_e749, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1009_e74c, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_e74f, 4); movsx(edx, memw[ss, ebp - 0x20]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1009_e753, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_e757, 2); test(edx, eax);                         /* test edx, eax */
            ii(0x1009_e759, 2); if(jnz(0x1009_e772, 0x17)) goto l_0x1009_e772; /* jnz 0x1009e772 */
            ii(0x1009_e75b, 4); movsx(edx, memw[ss, ebp - 0x28]);       /* movsx edx, word [ebp-0x28] */
            ii(0x1009_e75f, 4); movsx(eax, memw[ss, ebp - 0x24]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1009_e763, 5); call(0x1007_3cfd, -0x2_aa6b);           /* call 0x10073cfd */
            ii(0x1009_e768, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_e76d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_e770, 2); if(jnz(0x1009_e774, 0x2)) goto l_0x1009_e774; /* jnz 0x1009e774 */
        l_0x1009_e772:
            ii(0x1009_e772, 2); jmp(0x1009_e789, 0x15); goto l_0x1009_e789; /* jmp 0x1009e789 */
        l_0x1009_e774:
            ii(0x1009_e774, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_e778, 3); lea(edx, memd[ss, ebp - 0x30]);         /* lea edx, [ebp-0x30] */
            ii(0x1009_e77b, 3); lea(eax, memd[ss, ebp - 0x2c]);         /* lea eax, [ebp-0x2c] */
            ii(0x1009_e77e, 5); call(0x1008_8b44, -0x1_5c3f);           /* call 0x10088b44 */
            ii(0x1009_e783, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_e786, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
        l_0x1009_e789:
            ii(0x1009_e789, 2); jmp(0x1009_e717, -0x74); goto l_0x1009_e717; /* jmp 0x1009e717 */
        l_0x1009_e78b:
            ii(0x1009_e78b, 5); jmp(0x1009_e6f7, -0x99); goto l_0x1009_e6f7; /* jmp 0x1009e6f7 */
        l_0x1009_e790:
            ii(0x1009_e790, 5); jmp(0x1009_e62b, -0x16a); goto l_0x1009_e62b; /* jmp 0x1009e62b */
        l_0x1009_e795:
            ii(0x1009_e795, 5); jmp(0x1009_e60e, -0x18c); goto l_0x1009_e60e; /* jmp 0x1009e60e */
        l_0x1009_e79a:
            ii(0x1009_e79a, 4); cmp(memb[ss, ebp - 0xc], 0);            /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1009_e79e, 6); if(jz(0x1009_e825, 0x81)) goto l_0x1009_e825; /* jz 0x1009e825 */
            ii(0x1009_e7a4, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1009_e7a9, 5); call(Definitions.sys_new, 0xc_7652);    /* call 0x10165e00 */
            ii(0x1009_e7ae, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1009_e7b1, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1009_e7b4, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1009_e7b7, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x1009_e7bb, 2); if(jz(0x1009_e7f0, 0x33)) goto l_0x1009_e7f0; /* jz 0x1009e7f0 */
            ii(0x1009_e7bd, 5); mov(eax, 0x1009_e844);                  /* mov eax, 0x1009e844 */
            ii(0x1009_e7c2, 1); push(eax);                              /* push eax */
            ii(0x1009_e7c3, 3); lea(edx, memd[ss, ebp - 0x2c]);         /* lea edx, [ebp-0x2c] */
            ii(0x1009_e7c6, 3); lea(eax, memd[ss, ebp - 0x54]);         /* lea eax, [ebp-0x54] */
            ii(0x1009_e7c9, 5); call(0x1007_5e64, -0x2_896a);           /* call 0x10075e64 */
            ii(0x1009_e7ce, 1); push(eax);                              /* push eax */
            ii(0x1009_e7cf, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1009_e7d4, 1); push(eax);                              /* push eax */
            ii(0x1009_e7d5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1009_e7d7, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1009_e7da, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e7dd, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1009_e7e0, 5); call(0x100a_c220, 0xda3b);              /* call 0x100ac220 */
            ii(0x1009_e7e5, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x1009_e7e8, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1009_e7eb, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1009_e7ee, 2); jmp(0x1009_e7f6, 0x6); goto l_0x1009_e7f6; /* jmp 0x1009e7f6 */
        l_0x1009_e7f0:
            ii(0x1009_e7f0, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x1009_e7f3, 3); mov(memd[ss, ebp - 0x5c], eax);         /* mov [ebp-0x5c], eax */
        l_0x1009_e7f6:
            ii(0x1009_e7f6, 3); mov(edx, memd[ss, ebp - 0x5c]);         /* mov edx, [ebp-0x5c] */
            ii(0x1009_e7f9, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x1009_e7fc, 5); call(0x1008_b060, -0x1_37a1);           /* call 0x1008b060 */
            ii(0x1009_e801, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x1009_e804, 5); call(0x1008_af84, -0x1_3885);           /* call 0x1008af84 */
            ii(0x1009_e809, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_e80b, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_e810, 5); call(0x100a_4d50, 0x653b);              /* call 0x100a4d50 */
            ii(0x1009_e815, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x1009_e819, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_e81b, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x1009_e81e, 5); call(0x1008_8b7c, -0x1_5ca7);           /* call 0x10088b7c */
            ii(0x1009_e823, 2); jmp(0x1009_e839, 0x14); goto l_0x1009_e839; /* jmp 0x1009e839 */
        l_0x1009_e825:
            ii(0x1009_e825, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1009_e82a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e82d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e830, 5); call(0x1009_d066, -0x17cf);             /* call 0x1009d066 */
            ii(0x1009_e835, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
        l_0x1009_e839:
            ii(0x1009_e839, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1009_e83c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e83e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_e83f, 1); pop(edi);                               /* pop edi */
            ii(0x1009_e840, 1); pop(esi);                               /* pop esi */
            ii(0x1009_e841, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_e842, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_e843, 1); ret();                                  /* ret */
        }
    }
}
