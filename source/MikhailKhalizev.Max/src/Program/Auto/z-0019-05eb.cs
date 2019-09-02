using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_05eb-c5c75e58")]
        public void Method_0019_05eb()
        {
            ii(0x19_05eb, 4); enter(0x1e, 0);                           /* enter 0x1e, 0x0 */
            ii(0x19_05ef, 1); push(ds);                                 /* push ds */
            ii(0x19_05f0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_05f3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_05f5, 5); cmp(memb[ds, 0x188e], 0);                 /* cmp byte [0x188e], 0x0 */
            ii(0x19_05fa, 2); if(jz(0x19_0603, 7)) goto l_0x19_0603;    /* jz 0x603 */
            ii(0x19_05fc, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_05fe:
            ii(0x19_05fe, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_0600, 1); pop(ds);                                  /* pop ds */
            ii(0x19_0601, 1); leave();                                  /* leave */
            ii(0x19_0602, 1); retf(); return;                           /* retf */
        l_0x19_0603:
            ii(0x19_0603, 1); push(ds);                                 /* push ds */
            ii(0x19_0604, 3); push(0x18a6);                             /* push 0x18a6 */
            ii(0x19_0607, 1); nop();                                    /* nop */
            ii(0x19_0608, 1); push(cs);                                 /* push cs */
            ii(0x19_0609, 3); call(0x19_155c, 0xf50);                   /* call 0x155c */
            ii(0x19_060c, 1); push(ds);                                 /* push ds */
            ii(0x19_060d, 3); push(0x18ac);                             /* push 0x18ac */
            ii(0x19_0610, 1); nop();                                    /* nop */
            ii(0x19_0611, 1); push(cs);                                 /* push cs */
            ii(0x19_0612, 3); call(0x19_5030, 0x4a1b);                  /* call 0x5030 */
            ii(0x19_0615, 1); pop(bx);                                  /* pop bx */
            ii(0x19_0616, 1); pop(bx);                                  /* pop bx */
            ii(0x19_0617, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_061a, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_061d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_061f, 2); if(jnz(0x19_0626, 5)) goto l_0x19_0626;   /* jnz 0x626 */
        l_0x19_0621:
            ii(0x19_0621, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_0624, 2); jmp(0x19_05fe, -0x28); goto l_0x19_05fe;  /* jmp 0x5fe */
        l_0x19_0626:
            ii(0x19_0626, 1); push(ds);                                 /* push ds */
            ii(0x19_0627, 3); push(0x18b5);                             /* push 0x18b5 */
            ii(0x19_062a, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_062d, 1); push(ax);                                 /* push ax */
            ii(0x19_062e, 1); nop();                                    /* nop */
            ii(0x19_062f, 1); push(cs);                                 /* push cs */
            ii(0x19_0630, 3); call(0x19_4eb0, 0x487d);                  /* call 0x4eb0 */
            ii(0x19_0633, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_0636, 3); mov(memw[ds, 0x1896], ax);                /* mov [0x1896], ax */
            ii(0x19_0639, 4); mov(memw[ds, 0x1898], dx);                /* mov [0x1898], dx */
            ii(0x19_063d, 1); push(ds);                                 /* push ds */
            ii(0x19_063e, 3); push(0x18c3);                             /* push 0x18c3 */
            ii(0x19_0641, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_0644, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_0647, 1); nop();                                    /* nop */
            ii(0x19_0648, 1); push(cs);                                 /* push cs */
            ii(0x19_0649, 3); call(0x19_4eb0, 0x4864);                  /* call 0x4eb0 */
            ii(0x19_064c, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_064f, 3); mov(memw[ds, 0x189a], ax);                /* mov [0x189a], ax */
            ii(0x19_0652, 4); mov(memw[ds, 0x189c], dx);                /* mov [0x189c], dx */
            ii(0x19_0656, 1); push(ds);                                 /* push ds */
            ii(0x19_0657, 3); push(0x18d1);                             /* push 0x18d1 */
            ii(0x19_065a, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_065d, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_0660, 1); nop();                                    /* nop */
            ii(0x19_0661, 1); push(cs);                                 /* push cs */
            ii(0x19_0662, 3); call(0x19_4eb0, 0x484b);                  /* call 0x4eb0 */
            ii(0x19_0665, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_0668, 3); mov(memw[ds, 0x1892], ax);                /* mov [0x1892], ax */
            ii(0x19_066b, 4); mov(memw[ds, 0x1894], dx);                /* mov [0x1894], dx */
            ii(0x19_066f, 3); mov(ax, memw[ds, 0x1898]);                /* mov ax, [0x1898] */
            ii(0x19_0672, 4); or(ax, memw[ds, 0x1896]);                 /* or ax, [0x1896] */
            ii(0x19_0676, 2); if(jz(0x19_0689, 0x11)) goto l_0x19_0689; /* jz 0x689 */
            ii(0x19_0678, 3); mov(ax, memw[ds, 0x189c]);                /* mov ax, [0x189c] */
            ii(0x19_067b, 4); or(ax, memw[ds, 0x189a]);                 /* or ax, [0x189a] */
            ii(0x19_067f, 2); if(jz(0x19_0689, 8)) goto l_0x19_0689;    /* jz 0x689 */
            ii(0x19_0681, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_0683, 4); or(ax, memw[ds, 0x1892]);                 /* or ax, [0x1892] */
            ii(0x19_0687, 2); if(jnz(0x19_068f, 6)) goto l_0x19_068f;   /* jnz 0x68f */
        l_0x19_0689:
            ii(0x19_0689, 3); mov(ax, 2);                               /* mov ax, 0x2 */
            ii(0x19_068c, 3); jmp(0x19_05fe, -0x91); goto l_0x19_05fe;  /* jmp 0x5fe */
        l_0x19_068f:
            ii(0x19_068f, 1); push(ds);                                 /* push ds */
            ii(0x19_0690, 3); push(0x18df);                             /* push 0x18df */
            ii(0x19_0693, 1); nop();                                    /* nop */
            ii(0x19_0694, 1); push(cs);                                 /* push cs */
            ii(0x19_0695, 3); call(0x19_5030, 0x4998);                  /* call 0x5030 */
            ii(0x19_0698, 1); pop(bx);                                  /* pop bx */
            ii(0x19_0699, 1); pop(bx);                                  /* pop bx */
            ii(0x19_069a, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_069d, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_06a0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_06a2, 2); if(jnz(0x19_06aa, 6)) goto l_0x19_06aa;   /* jnz 0x6aa */
            ii(0x19_06a4, 3); mov(ax, 3);                               /* mov ax, 0x3 */
            ii(0x19_06a7, 3); jmp(0x19_05fe, -0xac); goto l_0x19_05fe;  /* jmp 0x5fe */
        l_0x19_06aa:
            ii(0x19_06aa, 1); push(ds);                                 /* push ds */
            ii(0x19_06ab, 3); push(0x18ea);                             /* push 0x18ea */
            ii(0x19_06ae, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_06b1, 1); push(ax);                                 /* push ax */
            ii(0x19_06b2, 1); nop();                                    /* nop */
            ii(0x19_06b3, 1); push(cs);                                 /* push cs */
            ii(0x19_06b4, 3); call(0x19_4eb0, 0x47f9);                  /* call 0x4eb0 */
            ii(0x19_06b7, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_06ba, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x19_06bd, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x19_06c0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_06c2, 2); if(jz(0x19_06d1, 0xd)) goto l_0x19_06d1;  /* jz 0x6d1 */
            ii(0x19_06c4, 3); call_far_ind(memw[ss, bp - 0xc]);         /* call far word [bp-0xc] */
            ii(0x19_06c7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_06c9, 2); if(jz(0x19_06d1, 6)) goto l_0x19_06d1;    /* jz 0x6d1 */
            ii(0x19_06cb, 3); mov(ax, 4);                               /* mov ax, 0x4 */
            ii(0x19_06ce, 3); jmp(0x19_05fe, -0xd3); goto l_0x19_05fe;  /* jmp 0x5fe */
        l_0x19_06d1:
            ii(0x19_06d1, 1); push(ds);                                 /* push ds */
            ii(0x19_06d2, 3); push(0x18ef);                             /* push 0x18ef */
            ii(0x19_06d5, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_06d8, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_06db, 1); nop();                                    /* nop */
            ii(0x19_06dc, 1); push(cs);                                 /* push cs */
            ii(0x19_06dd, 3); call(0x19_4eb0, 0x47d0);                  /* call 0x4eb0 */
            ii(0x19_06e0, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_06e3, 3); mov(memw[ds, 0x189e], ax);                /* mov [0x189e], ax */
            ii(0x19_06e6, 4); mov(memw[ds, 0x18a0], dx);                /* mov [0x18a0], dx */
            ii(0x19_06ea, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_06ec, 4); or(ax, memw[ds, 0x189e]);                 /* or ax, [0x189e] */
            ii(0x19_06f0, 2); if(jnz(0x19_06f8, 6)) goto l_0x19_06f8;   /* jnz 0x6f8 */
            ii(0x19_06f2, 3); mov(ax, 5);                               /* mov ax, 0x5 */
            ii(0x19_06f5, 3); jmp(0x19_05fe, -0xfa); goto l_0x19_05fe;  /* jmp 0x5fe */
        l_0x19_06f8:
            ii(0x19_06f8, 1); push(ds);                                 /* push ds */
            ii(0x19_06f9, 3); push(0x1905);                             /* push 0x1905 */
            ii(0x19_06fc, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_06ff, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_0702, 1); nop();                                    /* nop */
            ii(0x19_0703, 1); push(cs);                                 /* push cs */
            ii(0x19_0704, 3); call(0x19_4eb0, 0x47a9);                  /* call 0x4eb0 */
            ii(0x19_0707, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_070a, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_070d, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x19_0710, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_0712, 2); if(jz(0x19_072f, 0x1b)) goto l_0x19_072f; /* jz 0x72f */
            ii(0x19_0714, 1); push(ds);                                 /* push ds */
            ii(0x19_0715, 3); push(0x190a);                             /* push 0x190a */
            ii(0x19_0718, 3); call_far_ind(memw[ss, bp - 8]);           /* call far word [bp-0x8] */
            ii(0x19_071b, 1); push(dx);                                 /* push dx */
            ii(0x19_071c, 1); push(ax);                                 /* push ax */
            ii(0x19_071d, 1); nop();                                    /* nop */
            ii(0x19_071e, 1); push(cs);                                 /* push cs */
            ii(0x19_071f, 3); call(0x19_3a50, 0x332e);                  /* call 0x3a50 */
            ii(0x19_0722, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_0725, 3); cmp(ax, 1);                               /* cmp ax, 0x1 */
            ii(0x19_0728, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x19_072a, 2); inc(al);                                  /* inc al */
            ii(0x19_072c, 3); mov(memb[ds, 0x185e], al);                /* mov [0x185e], al */
        l_0x19_072f:
            ii(0x19_072f, 2); push(0);                                  /* push 0x0 */
            ii(0x19_0731, 2); push(0);                                  /* push 0x0 */
            ii(0x19_0733, 2); push(0);                                  /* push 0x0 */
            ii(0x19_0735, 1); nop();                                    /* nop */
            ii(0x19_0736, 1); push(cs);                                 /* push cs */
            ii(0x19_0737, 3); call(0x19_4abc, 0x4382);                  /* call 0x4abc */
            ii(0x19_073a, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_073d, 4); mov(es, memw[ds, 0x3fba]);                /* mov es, [0x3fba] */
            ii(0x19_0741, 4); mov(memw[es, 0x19d6], ax);                /* mov [es:0x19d6], ax */
            ii(0x19_0745, 5); mov(memw[es, 0x19d8], dx);                /* mov [es:0x19d8], dx */
            ii(0x19_074a, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_074c, 5); or(ax, memw[es, 0x19d6]);                 /* or ax, [es:0x19d6] */
            ii(0x19_0751, 2); if(jnz(0x19_0756, 3)) goto l_0x19_0756;   /* jnz 0x756 */
            ii(0x19_0753, 3); jmp(0x19_0621, -0x135); goto l_0x19_0621; /* jmp 0x621 */
        l_0x19_0756:
            ii(0x19_0756, 3); mov(ax, 9);                               /* mov ax, 0x9 */
            ii(0x19_0759, 4); mov(bx, memw[ds, 0x19d8]);                /* mov bx, [0x19d8] */
            ii(0x19_075d, 4); lar(ecx, bx);                             /* lar ecx, bx */
            ii(0x19_0761, 4); shr(ecx, 8);                              /* shr ecx, 0x8 */
            ii(0x19_0765, 3); and(ch, 0xbf);                            /* and ch, 0xbf */
            ii(0x19_0768, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_076a, 1); nop();                                    /* nop */
            ii(0x19_076b, 1); push(cs);                                 /* push cs */
            ii(0x19_076c, 3); call(0x19_4638, 0x3ec9);                  /* call 0x4638 */
            ii(0x19_076f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_0771, 2); if(jz(0x19_077b, 8)) goto l_0x19_077b;    /* jz 0x77b */
            ii(0x19_0773, 3); mov(ax, 0x1420);                          /* mov ax, 0x1420 */
            ii(0x19_0776, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
            ii(0x19_0779, 2); jmp(0x19_077e, 3); goto l_0x19_077e;      /* jmp 0x77e */
        l_0x19_077b:
            ii(0x19_077b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_077d, 1); cwd();                                    /* cwd */
        l_0x19_077e:
            ii(0x19_077e, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_0781, 3); mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x19_0784, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_0786, 2); if(jz(0x19_07cb, 0x43)) goto l_0x19_07cb; /* jz 0x7cb */
            ii(0x19_0788, 3); mov(ax, memw[ss, bp - 0xe]);              /* mov ax, [bp-0xe] */
            ii(0x19_078b, 3); mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x19_078e, 3); mov(ax, memw[ss, bp - 0x10]);             /* mov ax, [bp-0x10] */
            ii(0x19_0791, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x19_0794, 5); mov(memw[ss, bp - 0x14], 0);              /* mov word [bp-0x14], 0x0 */
            ii(0x19_0799, 1); push(ds);                                 /* push ds */
            ii(0x19_079a, 3); push(0x1917);                             /* push 0x1917 */
            ii(0x19_079d, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x19_07a0, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x19_07a3, 1); nop();                                    /* nop */
            ii(0x19_07a4, 1); push(cs);                                 /* push cs */
            ii(0x19_07a5, 3); call(0x19_4eb0, 0x4708);                  /* call 0x4eb0 */
            ii(0x19_07a8, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_07ab, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_07ae, 3); mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x19_07b1, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_07b3, 2); if(jz(0x19_0818, 0x63)) goto l_0x19_0818; /* jz 0x818 */
            ii(0x19_07b5, 3); lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x19_07b8, 1); push(ss);                                 /* push ss */
            ii(0x19_07b9, 1); push(ax);                                 /* push ax */
            ii(0x19_07ba, 2); push(0x31);                               /* push 0x31 */
            ii(0x19_07bc, 3); call_far_ind(memw[ss, bp - 0x1a]);        /* call far word [bp-0x1a] */
            ii(0x19_07bf, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_07c2, 3); mov(memw[ds, 0x1890], ax);                /* mov [0x1890], ax */
            ii(0x19_07c5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_07c7, 2); if(jz(0x19_0818, 0x4f)) goto l_0x19_0818; /* jz 0x818 */
            ii(0x19_07c9, 2); jmp(0x19_0813, 0x48); goto l_0x19_0813;   /* jmp 0x813 */
        l_0x19_07cb:
            ii(0x19_07cb, 3); push(0x80);                               /* push 0x80 */
            ii(0x19_07ce, 3); push(0x1478);                             /* push 0x1478 */
            ii(0x19_07d1, 2); push(3);                                  /* push 0x3 */
            ii(0x19_07d3, 1); push(cs);                                 /* push cs */
            ii(0x19_07d4, 3); call(0x19_0588, -0x24f);                  /* call 0x588 */
            ii(0x19_07d7, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_07da, 3); mov(memw[ds, 0x185a], ax);                /* mov [0x185a], ax */
            ii(0x19_07dd, 4); mov(memw[ds, 0x185c], dx);                /* mov [0x185c], dx */
            ii(0x19_07e1, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_07e3, 4); or(ax, memw[ds, 0x185a]);                 /* or ax, [0x185a] */
            ii(0x19_07e7, 2); if(jnz(0x19_07ef, 6)) goto l_0x19_07ef;   /* jnz 0x7ef */
            ii(0x19_07e9, 3); mov(ax, 8);                               /* mov ax, 0x8 */
            ii(0x19_07ec, 3); jmp(0x19_05fe, -0x1f1); goto l_0x19_05fe; /* jmp 0x5fe */
        l_0x19_07ef:
            ii(0x19_07ef, 3); push(0x80);                               /* push 0x80 */
            ii(0x19_07f2, 3); push(0x14ac);                             /* push 0x14ac */
            ii(0x19_07f5, 2); push(0xa);                                /* push 0xa */
            ii(0x19_07f7, 1); push(cs);                                 /* push cs */
            ii(0x19_07f8, 3); call(0x19_0588, -0x273);                  /* call 0x588 */
            ii(0x19_07fb, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_07fe, 3); mov(memw[ds, 0x1856], ax);                /* mov [0x1856], ax */
            ii(0x19_0801, 4); mov(memw[ds, 0x1858], dx);                /* mov [0x1858], dx */
            ii(0x19_0805, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_0807, 4); or(ax, memw[ds, 0x1856]);                 /* or ax, [0x1856] */
            ii(0x19_080b, 2); if(jnz(0x19_0813, 6)) goto l_0x19_0813;   /* jnz 0x813 */
            ii(0x19_080d, 3); mov(ax, 7);                               /* mov ax, 0x7 */
            ii(0x19_0810, 3); jmp(0x19_05fe, -0x215); goto l_0x19_05fe; /* jmp 0x5fe */
        l_0x19_0813:
            ii(0x19_0813, 5); mov(memb[ds, 0x188e], 1);                 /* mov byte [0x188e], 0x1 */
        l_0x19_0818:
            ii(0x19_0818, 5); cmp(memb[ds, 0x188e], 1);                 /* cmp byte [0x188e], 0x1 */
            ii(0x19_081d, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_081f, 3); and(ax, 8);                               /* and ax, 0x8 */
            ii(0x19_0822, 1); cwd();                                    /* cwd */
            ii(0x19_0823, 1); pop(ds);                                  /* pop ds */
            ii(0x19_0824, 1); leave();                                  /* leave */
            ii(0x19_0825, 1); retf();                                   /* retf */
        }
    }
}
