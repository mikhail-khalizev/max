using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_74bb-7a9226e9")]
        public void Method_100d_74bb()
        {
            ii(0x100d_74bb, 5); push(0x34);                             /* push 0x34 */
            ii(0x100d_74c0, 5); call(Definitions.sys_check_available_stack_size, 0x8_e88d); /* call 0x10165d52 */
            ii(0x100d_74c5, 1); push(ebx);                              /* push ebx */
            ii(0x100d_74c6, 1); push(ecx);                              /* push ecx */
            ii(0x100d_74c7, 1); push(esi);                              /* push esi */
            ii(0x100d_74c8, 1); push(edi);                              /* push edi */
            ii(0x100d_74c9, 1); push(ebp);                              /* push ebp */
            ii(0x100d_74ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_74cc, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_74d2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_74d5, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_74d8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_74db, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_74de, 3); cmp(eax, memd[ds, edx + 0x10]);         /* cmp eax, [edx+0x10] */
            ii(0x100d_74e1, 2); if(jnz(0x100d_750e, 0x2b)) goto l_0x100d_750e; /* jnz 0x100d750e */
            ii(0x100d_74e3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_74e6, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x100d_74ea, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_74ed, 3); cmp(dx, memw[ds, eax]);                 /* cmp dx, [eax] */
            ii(0x100d_74f0, 2); if(jge(0x100d_7505, 0x13)) goto l_0x100d_7505; /* jge 0x100d7505 */
            ii(0x100d_74f2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_74f5, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x100d_74f9, 1); inc(eax);                               /* inc eax */
            ii(0x100d_74fa, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_74fd, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7500, 5); call(0x100d_7431, -0xd4);               /* call 0x100d7431 */
        l_0x100d_7505:
            ii(0x100d_7505, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_7509, 5); jmp(0x100d_7677, 0x169); goto l_0x100d_7677; /* jmp 0x100d7677 */
        l_0x100d_750e:
            ii(0x100d_750e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7511, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_7514, 3); cmp(eax, memd[ds, edx + 0x14]);         /* cmp eax, [edx+0x14] */
            ii(0x100d_7517, 2); if(jnz(0x100d_7545, 0x2c)) goto l_0x100d_7545; /* jnz 0x100d7545 */
            ii(0x100d_7519, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_751c, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x100d_7520, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7523, 4); cmp(dx, memw[ds, eax + 0x2]);           /* cmp dx, [eax+0x2] */
            ii(0x100d_7527, 2); if(jle(0x100d_753c, 0x13)) goto l_0x100d_753c; /* jle 0x100d753c */
            ii(0x100d_7529, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_752c, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x100d_7530, 1); dec(eax);                               /* dec eax */
            ii(0x100d_7531, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7534, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7537, 5); call(0x100d_7431, -0x10b);              /* call 0x100d7431 */
        l_0x100d_753c:
            ii(0x100d_753c, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_7540, 5); jmp(0x100d_7677, 0x132); goto l_0x100d_7677; /* jmp 0x100d7677 */
        l_0x100d_7545:
            ii(0x100d_7545, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7548, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_754b, 3); cmp(eax, memd[ds, edx + 0x18]);         /* cmp eax, [edx+0x18] */
            ii(0x100d_754e, 6); if(jnz(0x100d_7673, 0x11f)) goto l_0x100d_7673; /* jnz 0x100d7673 */
            ii(0x100d_7554, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100d_7557, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100d_755a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_755d, 3); mov(eax, memd[ds, eax + 0x20]);         /* mov eax, [eax+0x20] */
            ii(0x100d_7560, 5); call(0x100d_6a92, -0xad3);              /* call 0x100d6a92 */
            ii(0x100d_7565, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7568, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100d_756b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_756e, 4); sub(ax, memw[ds, edx + 0x2]);           /* sub ax, [edx+0x2] */
            ii(0x100d_7572, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_7575, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7578, 4); cmp(memb[ds, eax + 0x26], 0);           /* cmp byte [eax+0x26], 0x0 */
            ii(0x100d_757c, 2); if(jz(0x100d_75e7, 0x69)) goto l_0x100d_75e7; /* jz 0x100d75e7 */
            ii(0x100d_757e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7581, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_7584, 5); call(0x100d_4ebc, -0x26cd);             /* call 0x100d4ebc */
            ii(0x100d_7589, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_758c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_758f, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_7592, 5); call(0x100d_4f24, -0x2673);             /* call 0x100d4f24 */
            ii(0x100d_7597, 1); cwde();                                 /* cwde */
            ii(0x100d_7598, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_759a, 3); sub(eax, memd[ss, ebp - 0x10]);         /* sub eax, [ebp-0x10] */
            ii(0x100d_759d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_75a0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_75a3, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_75a6, 5); call(0x100d_4f24, -0x2687);             /* call 0x100d4f24 */
            ii(0x100d_75ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_75ae, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_75b0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_75b3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_75b5, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_75b7, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100d_75bb, 4); imul(edx, memd[ss, ebp - 0x10]);        /* imul edx, [ebp-0x10] */
            ii(0x100d_75bf, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_75c1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_75c4, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_75c7, 5); call(0x100d_4f24, -0x26a8);             /* call 0x100d4f24 */
            ii(0x100d_75cc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_75cf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_75d1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_75d4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_75d6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_75d8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_75db, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_75dd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_75e0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_75e2, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_75e5, 2); jmp(0x100d_763b, 0x54); goto l_0x100d_763b; /* jmp 0x100d763b */
        l_0x100d_75e7:
            ii(0x100d_75e7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_75ea, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_75ed, 5); call(0x100d_4ef0, -0x2702);             /* call 0x100d4ef0 */
            ii(0x100d_75f2, 1); cwde();                                 /* cwde */
            ii(0x100d_75f3, 3); sub(memd[ss, ebp - 0x14], eax);         /* sub [ebp-0x14], eax */
            ii(0x100d_75f6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_75f9, 3); mov(eax, memd[ds, edx + 0x6]);          /* mov eax, [edx+0x6] */
            ii(0x100d_75fc, 5); call(0x100d_4f58, -0x26a9);             /* call 0x100d4f58 */
            ii(0x100d_7601, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7604, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7606, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_7609, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_760b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_760d, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100d_7611, 4); imul(edx, memd[ss, ebp - 0x14]);        /* imul edx, [ebp-0x14] */
            ii(0x100d_7615, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_7617, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_761a, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100d_761d, 5); call(0x100d_4f58, -0x26ca);             /* call 0x100d4f58 */
            ii(0x100d_7622, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_7625, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7627, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_762a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_762c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_762e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7631, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_7633, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7636, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_7638, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x100d_763b:
            ii(0x100d_763b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_763e, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x100d_7640, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_7643, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_7647, 5); call(0x1007_6e7c, -0x6_07d0);           /* call 0x10076e7c */
            ii(0x100d_764c, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_764f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7652, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100d_7655, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_7659, 5); call(Definitions.my_min, -0x4_deda);    /* call 0x10089784 */
            ii(0x100d_765e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_7661, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_7665, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7668, 5); call(0x100d_7431, -0x23c);              /* call 0x100d7431 */
            ii(0x100d_766d, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_7671, 2); jmp(0x100d_7677, 0x4); goto l_0x100d_7677; /* jmp 0x100d7677 */
        l_0x100d_7673:
            ii(0x100d_7673, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x100d_7677:
            ii(0x100d_7677, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100d_767a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_767c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_767d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_767e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_767f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_7680, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_7681, 1); ret();                                  /* ret */
        }
    }
}
