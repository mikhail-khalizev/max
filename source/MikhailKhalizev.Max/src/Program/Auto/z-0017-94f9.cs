using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_94f9-be9f53e1")]
        public void Method_0017_94f9()
        {
            ii(0x17_94f9, 1); cli();                                    /* cli */
            ii(0x17_94fa, 1); cld();                                    /* cld */
            ii(0x17_94fb, 1); push(es);                                 /* push es */
            ii(0x17_94fc, 1); push(di);                                 /* push di */
            ii(0x17_94fd, 1); push(ds);                                 /* push ds */
            ii(0x17_94fe, 1); pop(es);                                  /* pop es */
            ii(0x17_94ff, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_9502, 1); push(es);                                 /* push es */
            ii(0x17_9503, 1); push(di);                                 /* push di */
            ii(0x17_9504, 2); push(ebx);                                /* push ebx */
            ii(0x17_9506, 3); mov(edx, ebx);                            /* mov edx, ebx */
            ii(0x17_9509, 4); mov(gs, memw[ds, 0xaa]);                  /* mov gs, [0xaa] */
            ii(0x17_950d, 2); clts();                                   /* clts */
            ii(0x17_950f, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_9511, 4); or(ax, memw[es, di + 0x5a]);              /* or ax, [es:di+0x5a] */
            ii(0x17_9515, 4); if(jz(0x17_951c, 0x3)) goto l_0x17_951c;  /* jz 0x951c */
            ii(0x17_9519, 3); jmp(0x17_95ec, 0xd0); goto l_0x17_95ec;   /* jmp 0x95ec */
        l_0x17_951c:
            ii(0x17_951c, 2); mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x17_951e, 4); xchg(memb[ds, 0x996], al);                /* xchg [0x996], al */
            ii(0x17_9522, 2); or(al, al);                               /* or al, al */
            ii(0x17_9524, 4); if(jz(0x17_952b, 0x3)) goto l_0x17_952b;  /* jz 0x952b */
            ii(0x17_9528, 3); jmp(0x17_95ec, 0xc1); goto l_0x17_95ec;   /* jmp 0x95ec */
        l_0x17_952b:
            ii(0x17_952b, 7); cmp(ebx, 0x1000_0000);                    /* cmp ebx, 0x10000000 */
            ii(0x17_9532, 4); if(jb(0x17_953f, 0x9)) goto l_0x17_953f;  /* jb 0x953f */
            ii(0x17_9536, 5); cmp(ebx, memd[ds, 0x4fd8]);               /* cmp ebx, [0x4fd8] */
            ii(0x17_953b, 4); if(jbe(0x17_9546, 0x7)) goto l_0x17_9546; /* jbe 0x9546 */
        l_0x17_953f:
            ii(0x17_953f, 2); push(ebx);                                /* push ebx */
            ii(0x17_9541, 2); pop(eax);                                 /* pop eax */
            ii(0x17_9543, 3); jmp(0x17_95ec, 0xa6); goto l_0x17_95ec;   /* jmp 0x95ec */
        l_0x17_9546:
            ii(0x17_9546, 7); sub(ebx, 0x1000_0000);                    /* sub ebx, 0x10000000 */
            ii(0x17_954d, 4); shr(ebx, 0xb);                            /* shr ebx, 0xb */
            ii(0x17_9551, 3); and(bl, 0xfe);                            /* and bl, 0xfe */
            ii(0x17_9554, 5); mov(edi, memd[ds, 0x1fa4]);               /* mov edi, [0x1fa4] */
            ii(0x17_9559, 5); mov(ax, memw_a32[gs, edi + ebx]);         /* mov ax, [gs:edi+ebx] */
            ii(0x17_955e, 7); test(memw_a32[gs, edi + ebx], 0xffff);    /* test word [gs:edi+ebx], 0xffff */
            ii(0x17_9565, 2); if(jz(0x17_953f, -0x28)) goto l_0x17_953f; /* jz 0x953f */
            ii(0x17_9567, 1); nop();                                    /* nop */
            ii(0x17_9568, 1); push(cs);                                 /* push cs */
            ii(0x17_9569, 3); call(0x17_7640, -0x1f2c);                 /* call 0x7640 */
            ii(0x17_956c, 1); cli();                                    /* cli */
            ii(0x17_956d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_956f, 4); if(jnz(0x17_95ec, 0x79)) goto l_0x17_95ec; /* jnz 0x95ec */
            ii(0x17_9573, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_9576, 1); push(ds);                                 /* push ds */
            ii(0x17_9577, 1); pop(es);                                  /* pop es */
            ii(0x17_9578, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_957b, 5); mov(eax, memd[es, di + 0x68]);            /* mov eax, [es:di+0x68] */
            ii(0x17_9580, 3); or(eax, eax);                             /* or eax, eax */
            ii(0x17_9583, 4); if(jz(0x17_958f, 0x8)) goto l_0x17_958f;  /* jz 0x958f */
            ii(0x17_9587, 4); les(di, memw[ds, 0x1f54]);                /* les di, [0x1f54] */
            ii(0x17_958b, 4); mov(memd[es, di], eax);                   /* mov [es:di], eax */
        l_0x17_958f:
            ii(0x17_958f, 1); push(ds);                                 /* push ds */
            ii(0x17_9590, 1); pop(es);                                  /* pop es */
            ii(0x17_9591, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_9594, 2); xor(al, al);                              /* xor al, al */
            ii(0x17_9596, 3); mov(memb[ds, 0x996], al);                 /* mov [0x996], al */
            ii(0x17_9599, 5); mov(eax, memd[es, di + 0x28]);            /* mov eax, [es:di+0x28] */
            ii(0x17_959e, 5); mov(ebx, memd[es, di + 0x34]);            /* mov ebx, [es:di+0x34] */
            ii(0x17_95a3, 5); mov(ecx, memd[es, di + 0x2c]);            /* mov ecx, [es:di+0x2c] */
            ii(0x17_95a8, 5); mov(edx, memd[es, di + 0x30]);            /* mov edx, [es:di+0x30] */
            ii(0x17_95ad, 5); mov(esi, memd[es, di + 0x40]);            /* mov esi, [es:di+0x40] */
            ii(0x17_95b2, 5); mov(ebp, memd[es, di + 0x3c]);            /* mov ebp, [es:di+0x3c] */
            ii(0x17_95b7, 4); mov(ds, memw[es, di + 0x54]);             /* mov ds, [es:di+0x54] */
            ii(0x17_95bb, 4); mov(gs, memw[es, di + 0x5c]);             /* mov gs, [es:di+0x5c] */
            ii(0x17_95bf, 4); mov(fs, memw[es, di + 0x58]);             /* mov fs, [es:di+0x58] */
            ii(0x17_95c3, 4); mov(ss, memw[es, di + 0x50]);             /* mov ss, [es:di+0x50] */
            ii(0x17_95c7, 5); mov(esp, memd[es, di + 0x38]);            /* mov esp, [es:di+0x38] */
            ii(0x17_95cc, 5); push(memd[es, di + 0x24]);                /* push dword [es:di+0x24] */
            ii(0x17_95d1, 4); push(memw[es, di + 0x4c]);                /* push word [es:di+0x4c] */
            ii(0x17_95d5, 4); push(memw[es, di + 0x4c]);                /* push word [es:di+0x4c] */
            ii(0x17_95d9, 5); push(memd[es, di + 0x20]);                /* push dword [es:di+0x20] */
            ii(0x17_95de, 4); push(memw[es, di + 0x48]);                /* push word [es:di+0x48] */
            ii(0x17_95e2, 5); mov(edi, memd[es, di + 0x44]);            /* mov edi, [es:di+0x44] */
            ii(0x17_95e7, 1); pop(es);                                  /* pop es */
            ii(0x17_95e8, 2); clts();                                   /* clts */
            ii(0x17_95ea, 2); iretd(); return;                          /* iretd */
        l_0x17_95ec:
            ii(0x17_95ec, 1); cli();                                    /* cli */
            ii(0x17_95ed, 1); cld();                                    /* cld */
            ii(0x17_95ee, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_95f1, 1); push(ds);                                 /* push ds */
            ii(0x17_95f2, 1); pop(es);                                  /* pop es */
            ii(0x17_95f3, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_95f6, 5); mov(eax, memd[es, di + 0x68]);            /* mov eax, [es:di+0x68] */
            ii(0x17_95fb, 3); or(eax, eax);                             /* or eax, eax */
            ii(0x17_95fe, 4); if(jz(0x17_960a, 0x8)) goto l_0x17_960a;  /* jz 0x960a */
            ii(0x17_9602, 4); les(di, memw[ds, 0x1f54]);                /* les di, [0x1f54] */
            ii(0x17_9606, 4); mov(memd[es, di], eax);                   /* mov [es:di], eax */
        l_0x17_960a:
            ii(0x17_960a, 1); cli();                                    /* cli */
            ii(0x17_960b, 1); push(ds);                                 /* push ds */
            ii(0x17_960c, 1); pop(es);                                  /* pop es */
            ii(0x17_960d, 3); mov(di, 0x50c4);                          /* mov di, 0x50c4 */
            ii(0x17_9610, 2); xor(al, al);                              /* xor al, al */
            ii(0x17_9612, 3); mov(memb[ds, 0x996], al);                 /* mov [0x996], al */
            ii(0x17_9615, 5); mov(eax, memd[es, di + 0x28]);            /* mov eax, [es:di+0x28] */
            ii(0x17_961a, 5); mov(ebx, memd[es, di + 0x34]);            /* mov ebx, [es:di+0x34] */
            ii(0x17_961f, 5); mov(ecx, memd[es, di + 0x2c]);            /* mov ecx, [es:di+0x2c] */
            ii(0x17_9624, 5); mov(edx, memd[es, di + 0x30]);            /* mov edx, [es:di+0x30] */
            ii(0x17_9629, 5); mov(esi, memd[es, di + 0x40]);            /* mov esi, [es:di+0x40] */
            ii(0x17_962e, 5); mov(ebp, memd[es, di + 0x3c]);            /* mov ebp, [es:di+0x3c] */
            ii(0x17_9633, 4); mov(ds, memw[es, di + 0x54]);             /* mov ds, [es:di+0x54] */
            ii(0x17_9637, 4); mov(gs, memw[es, di + 0x5c]);             /* mov gs, [es:di+0x5c] */
            ii(0x17_963b, 4); mov(fs, memw[es, di + 0x58]);             /* mov fs, [es:di+0x58] */
            ii(0x17_963f, 4); mov(ss, memw[es, di + 0x50]);             /* mov ss, [es:di+0x50] */
            ii(0x17_9643, 5); mov(esp, memd[es, di + 0x38]);            /* mov esp, [es:di+0x38] */
            ii(0x17_9648, 5); push(memd[es, di + 0x24]);                /* push dword [es:di+0x24] */
            ii(0x17_964d, 4); push(memw[es, di + 0x4c]);                /* push word [es:di+0x4c] */
            ii(0x17_9651, 4); push(memw[es, di + 0x4c]);                /* push word [es:di+0x4c] */
            ii(0x17_9655, 5); push(memd[es, di + 0x20]);                /* push dword [es:di+0x20] */
            ii(0x17_965a, 5); cmp(memw[es, di + 0x5a], 0);              /* cmp word [es:di+0x5a], 0x0 */
            ii(0x17_965f, 4); if(jnz(0x17_9667, 0x4)) goto l_0x17_9667; /* jnz 0x9667 */
            ii(0x17_9663, 2); push(0);                                  /* push 0x0 */
            ii(0x17_9665, 2); push(0x1);                                /* push 0x1 */
        l_0x17_9667:
            ii(0x17_9667, 4); push(memw[es, di + 0x6f]);                /* push word [es:di+0x6f] */
            ii(0x17_966b, 4); push(memw[es, di + 0x6d]);                /* push word [es:di+0x6d] */
            ii(0x17_966f, 4); push(memw[es, di + 0x48]);                /* push word [es:di+0x48] */
            ii(0x17_9673, 5); mov(edi, memd[es, di + 0x44]);            /* mov edi, [es:di+0x44] */
            ii(0x17_9678, 1); pop(es);                                  /* pop es */
            ii(0x17_9679, 2); clts();                                   /* clts */
            ii(0x17_967b, 1); retf();                                   /* retf */
        }
    }
}
