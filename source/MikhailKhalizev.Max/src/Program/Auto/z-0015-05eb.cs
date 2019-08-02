using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("649c5457-d7c5-4963-9760-edf257c60bbf")]
        public void Method_0015_05eb()
        {
            ii(0x15_05eb, 4); enterw(0x1e, 0);                          /* enter 0x1e, 0x0 */
            ii(0x15_05ef, 1); pushw(ds);                                /* push ds */
            ii(0x15_05f0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_05f3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_05f5, 5); cmp(memb_a16[ds, 0x188e], 0);             /* cmp byte [0x188e], 0x0 */
            ii(0x15_05fa, 2); if(jzw(0x15_0603, 0x7)) goto l_0x15_0603; /* jz 0x603 */
            ii(0x15_05fc, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_05fe:
            ii(0x15_05fe, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_0600, 1); popw(ds);                                 /* pop ds */
            ii(0x15_0601, 1); leavew();                                 /* leave */
            ii(0x15_0602, 1); retfw(); return;                          /* retf */
        l_0x15_0603:
            ii(0x15_0603, 1); pushw(ds);                                /* push ds */
            ii(0x15_0604, 3); pushw(0x18a6);                            /* push 0x18a6 */
            ii(0x15_0607, 1); nop();                                    /* nop */
            ii(0x15_0608, 1); pushw(cs);                                /* push cs */
            ii(0x15_0609, 3); callw(0x15_155c, 0xf50);                  /* call 0x155c */
            ii(0x15_060c, 1); pushw(ds);                                /* push ds */
            ii(0x15_060d, 3); pushw(0x18ac);                            /* push 0x18ac */
            ii(0x15_0610, 1); nop();                                    /* nop */
            ii(0x15_0611, 1); pushw(cs);                                /* push cs */
            ii(0x15_0612, 3); callw(0x15_5030, 0x4a1b);                 /* call 0x5030 */
            ii(0x15_0615, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0616, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0617, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_061a, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_061d, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_061f, 2); if(jnzw(0x15_0626, 0x5)) goto l_0x15_0626; /* jnz 0x626 */
        l_0x15_0621:
            ii(0x15_0621, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_0624, 2); jmpw(0x15_05fe, -0x28); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_0626:
            ii(0x15_0626, 1); pushw(ds);                                /* push ds */
            ii(0x15_0627, 3); pushw(0x18b5);                            /* push 0x18b5 */
            ii(0x15_062a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_062d, 1); pushw(ax);                                /* push ax */
            ii(0x15_062e, 1); nop();                                    /* nop */
            ii(0x15_062f, 1); pushw(cs);                                /* push cs */
            ii(0x15_0630, 3); callw(0x15_4eb0, 0x487d);                 /* call 0x4eb0 */
            ii(0x15_0633, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_0636, 3); mov(memw_a16[ds, 0x1896], ax);            /* mov [0x1896], ax */
            ii(0x15_0639, 4); mov(memw_a16[ds, 0x1898], dx);            /* mov [0x1898], dx */
            ii(0x15_063d, 1); pushw(ds);                                /* push ds */
            ii(0x15_063e, 3); pushw(0x18c3);                            /* push 0x18c3 */
            ii(0x15_0641, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_0644, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_0647, 1); nop();                                    /* nop */
            ii(0x15_0648, 1); pushw(cs);                                /* push cs */
            ii(0x15_0649, 3); callw(0x15_4eb0, 0x4864);                 /* call 0x4eb0 */
            ii(0x15_064c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_064f, 3); mov(memw_a16[ds, 0x189a], ax);            /* mov [0x189a], ax */
            ii(0x15_0652, 4); mov(memw_a16[ds, 0x189c], dx);            /* mov [0x189c], dx */
            ii(0x15_0656, 1); pushw(ds);                                /* push ds */
            ii(0x15_0657, 3); pushw(0x18d1);                            /* push 0x18d1 */
            ii(0x15_065a, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_065d, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_0660, 1); nop();                                    /* nop */
            ii(0x15_0661, 1); pushw(cs);                                /* push cs */
            ii(0x15_0662, 3); callw(0x15_4eb0, 0x484b);                 /* call 0x4eb0 */
            ii(0x15_0665, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_0668, 3); mov(memw_a16[ds, 0x1892], ax);            /* mov [0x1892], ax */
            ii(0x15_066b, 4); mov(memw_a16[ds, 0x1894], dx);            /* mov [0x1894], dx */
            ii(0x15_066f, 3); mov(ax, memw_a16[ds, 0x1898]);            /* mov ax, [0x1898] */
            ii(0x15_0672, 4); or(ax, memw_a16[ds, 0x1896]);             /* or ax, [0x1896] */
            ii(0x15_0676, 2); if(jzw(0x15_0689, 0x11)) goto l_0x15_0689; /* jz 0x689 */
            ii(0x15_0678, 3); mov(ax, memw_a16[ds, 0x189c]);            /* mov ax, [0x189c] */
            ii(0x15_067b, 4); or(ax, memw_a16[ds, 0x189a]);             /* or ax, [0x189a] */
            ii(0x15_067f, 2); if(jzw(0x15_0689, 0x8)) goto l_0x15_0689; /* jz 0x689 */
            ii(0x15_0681, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_0683, 4); or(ax, memw_a16[ds, 0x1892]);             /* or ax, [0x1892] */
            ii(0x15_0687, 2); if(jnzw(0x15_068f, 0x6)) goto l_0x15_068f; /* jnz 0x68f */
        l_0x15_0689:
            ii(0x15_0689, 3); mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x15_068c, 3); jmpw(0x15_05fe, -0x91); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_068f:
            ii(0x15_068f, 1); pushw(ds);                                /* push ds */
            ii(0x15_0690, 3); pushw(0x18df);                            /* push 0x18df */
            ii(0x15_0693, 1); nop();                                    /* nop */
            ii(0x15_0694, 1); pushw(cs);                                /* push cs */
            ii(0x15_0695, 3); callw(0x15_5030, 0x4998);                 /* call 0x5030 */
            ii(0x15_0698, 1); popw(bx);                                 /* pop bx */
            ii(0x15_0699, 1); popw(bx);                                 /* pop bx */
            ii(0x15_069a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_069d, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_06a0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_06a2, 2); if(jnzw(0x15_06aa, 0x6)) goto l_0x15_06aa; /* jnz 0x6aa */
            ii(0x15_06a4, 3); mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x15_06a7, 3); jmpw(0x15_05fe, -0xac); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_06aa:
            ii(0x15_06aa, 1); pushw(ds);                                /* push ds */
            ii(0x15_06ab, 3); pushw(0x18ea);                            /* push 0x18ea */
            ii(0x15_06ae, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_06b1, 1); pushw(ax);                                /* push ax */
            ii(0x15_06b2, 1); nop();                                    /* nop */
            ii(0x15_06b3, 1); pushw(cs);                                /* push cs */
            ii(0x15_06b4, 3); callw(0x15_4eb0, 0x47f9);                 /* call 0x4eb0 */
            ii(0x15_06b7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_06ba, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_06bd, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_06c0, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_06c2, 2); if(jzw(0x15_06d1, 0xd)) goto l_0x15_06d1; /* jz 0x6d1 */
            ii(0x15_06c4, 3); callw_a16_far_ind(ss, bp - 0xc);          /* call far word [bp-0xc] */
            ii(0x15_06c7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_06c9, 2); if(jzw(0x15_06d1, 0x6)) goto l_0x15_06d1; /* jz 0x6d1 */
            ii(0x15_06cb, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x15_06ce, 3); jmpw(0x15_05fe, -0xd3); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_06d1:
            ii(0x15_06d1, 1); pushw(ds);                                /* push ds */
            ii(0x15_06d2, 3); pushw(0x18ef);                            /* push 0x18ef */
            ii(0x15_06d5, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_06d8, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_06db, 1); nop();                                    /* nop */
            ii(0x15_06dc, 1); pushw(cs);                                /* push cs */
            ii(0x15_06dd, 3); callw(0x15_4eb0, 0x47d0);                 /* call 0x4eb0 */
            ii(0x15_06e0, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_06e3, 3); mov(memw_a16[ds, 0x189e], ax);            /* mov [0x189e], ax */
            ii(0x15_06e6, 4); mov(memw_a16[ds, 0x18a0], dx);            /* mov [0x18a0], dx */
            ii(0x15_06ea, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_06ec, 4); or(ax, memw_a16[ds, 0x189e]);             /* or ax, [0x189e] */
            ii(0x15_06f0, 2); if(jnzw(0x15_06f8, 0x6)) goto l_0x15_06f8; /* jnz 0x6f8 */
            ii(0x15_06f2, 3); mov(ax, 0x5);                             /* mov ax, 0x5 */
            ii(0x15_06f5, 3); jmpw(0x15_05fe, -0xfa); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_06f8:
            ii(0x15_06f8, 1); pushw(ds);                                /* push ds */
            ii(0x15_06f9, 3); pushw(0x1905);                            /* push 0x1905 */
            ii(0x15_06fc, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_06ff, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_0702, 1); nop();                                    /* nop */
            ii(0x15_0703, 1); pushw(cs);                                /* push cs */
            ii(0x15_0704, 3); callw(0x15_4eb0, 0x47a9);                 /* call 0x4eb0 */
            ii(0x15_0707, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_070a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_070d, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x15_0710, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_0712, 2); if(jzw(0x15_072f, 0x1b)) goto l_0x15_072f; /* jz 0x72f */
            ii(0x15_0714, 1); pushw(ds);                                /* push ds */
            ii(0x15_0715, 3); pushw(0x190a);                            /* push 0x190a */
            ii(0x15_0718, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x15_071b, 1); pushw(dx);                                /* push dx */
            ii(0x15_071c, 1); pushw(ax);                                /* push ax */
            ii(0x15_071d, 1); nop();                                    /* nop */
            ii(0x15_071e, 1); pushw(cs);                                /* push cs */
            ii(0x15_071f, 3); callw(0x15_3a50, 0x332e);                 /* call 0x3a50 */
            ii(0x15_0722, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_0725, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x15_0728, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x15_072a, 2); inc(al);                                  /* inc al */
            ii(0x15_072c, 3); mov(memb_a16[ds, 0x185e], al);            /* mov [0x185e], al */
        l_0x15_072f:
            ii(0x15_072f, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_0731, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_0733, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_0735, 1); nop();                                    /* nop */
            ii(0x15_0736, 1); pushw(cs);                                /* push cs */
            ii(0x15_0737, 3); callw(0x15_4abc, 0x4382);                 /* call 0x4abc */
            ii(0x15_073a, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_073d, 4); mov(es, memw_a16[ds, 0x3fba]);            /* mov es, [0x3fba] */
            ii(0x15_0741, 4); mov(memw_a16[es, 0x19d6], ax);            /* mov [es:0x19d6], ax */
            ii(0x15_0745, 5); mov(memw_a16[es, 0x19d8], dx);            /* mov [es:0x19d8], dx */
            ii(0x15_074a, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_074c, 5); or(ax, memw_a16[es, 0x19d6]);             /* or ax, [es:0x19d6] */
            ii(0x15_0751, 2); if(jnzw(0x15_0756, 0x3)) goto l_0x15_0756; /* jnz 0x756 */
            ii(0x15_0753, 3); jmpw(0x15_0621, -0x135); goto l_0x15_0621; /* jmp 0x621 */
        l_0x15_0756:
            ii(0x15_0756, 3); mov(ax, 0x9);                             /* mov ax, 0x9 */
            ii(0x15_0759, 4); mov(bx, memw_a16[ds, 0x19d8]);            /* mov bx, [0x19d8] */
            ii(0x15_075d, 4); lar(ecx, bx);                             /* lar ecx, bx */
            ii(0x15_0761, 4); shr(ecx, 0x8);                            /* shr ecx, 0x8 */
            ii(0x15_0765, 3); and(ch, 0xbf);                            /* and ch, 0xbf */
            ii(0x15_0768, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_076a, 1); nop();                                    /* nop */
            ii(0x15_076b, 1); pushw(cs);                                /* push cs */
            ii(0x15_076c, 3); callw(0x15_4638, 0x3ec9);                 /* call 0x4638 */
            ii(0x15_076f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_0771, 2); if(jzw(0x15_077b, 0x8)) goto l_0x15_077b; /* jz 0x77b */
            ii(0x15_0773, 3); mov(ax, 0x1420);                          /* mov ax, 0x1420 */
            ii(0x15_0776, 3); mov(dx, 0x80);                            /* mov dx, 0x80 */
            ii(0x15_0779, 2); jmpw(0x15_077e, 0x3); goto l_0x15_077e;   /* jmp 0x77e */
        l_0x15_077b:
            ii(0x15_077b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_077d, 1); cwd();                                    /* cwd */
        l_0x15_077e:
            ii(0x15_077e, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_0781, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x15_0784, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_0786, 2); if(jzw(0x15_07cb, 0x43)) goto l_0x15_07cb; /* jz 0x7cb */
            ii(0x15_0788, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x15_078b, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_078e, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_0791, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_0794, 5); mov(memw_a16[ss, bp - 0x14], 0);          /* mov word [bp-0x14], 0x0 */
            ii(0x15_0799, 1); pushw(ds);                                /* push ds */
            ii(0x15_079a, 3); pushw(0x1917);                            /* push 0x1917 */
            ii(0x15_079d, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_07a0, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_07a3, 1); nop();                                    /* nop */
            ii(0x15_07a4, 1); pushw(cs);                                /* push cs */
            ii(0x15_07a5, 3); callw(0x15_4eb0, 0x4708);                 /* call 0x4eb0 */
            ii(0x15_07a8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_07ab, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_07ae, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x15_07b1, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_07b3, 2); if(jzw(0x15_0818, 0x63)) goto l_0x15_0818; /* jz 0x818 */
            ii(0x15_07b5, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x15_07b8, 1); pushw(ss);                                /* push ss */
            ii(0x15_07b9, 1); pushw(ax);                                /* push ax */
            ii(0x15_07ba, 2); pushw(0x31);                              /* push 0x31 */
            ii(0x15_07bc, 3); callw_a16_far_ind(ss, bp - 0x1a);         /* call far word [bp-0x1a] */
            ii(0x15_07bf, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_07c2, 3); mov(memw_a16[ds, 0x1890], ax);            /* mov [0x1890], ax */
            ii(0x15_07c5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_07c7, 2); if(jzw(0x15_0818, 0x4f)) goto l_0x15_0818; /* jz 0x818 */
            ii(0x15_07c9, 2); jmpw(0x15_0813, 0x48); goto l_0x15_0813;  /* jmp 0x813 */
        l_0x15_07cb:
            ii(0x15_07cb, 3); pushw(0x80);                              /* push 0x80 */
            ii(0x15_07ce, 3); pushw(0x1478);                            /* push 0x1478 */
            ii(0x15_07d1, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_07d3, 1); pushw(cs);                                /* push cs */
            ii(0x15_07d4, 3); callw(0x15_0588, -0x24f);                 /* call 0x588 */
            ii(0x15_07d7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_07da, 3); mov(memw_a16[ds, 0x185a], ax);            /* mov [0x185a], ax */
            ii(0x15_07dd, 4); mov(memw_a16[ds, 0x185c], dx);            /* mov [0x185c], dx */
            ii(0x15_07e1, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_07e3, 4); or(ax, memw_a16[ds, 0x185a]);             /* or ax, [0x185a] */
            ii(0x15_07e7, 2); if(jnzw(0x15_07ef, 0x6)) goto l_0x15_07ef; /* jnz 0x7ef */
            ii(0x15_07e9, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x15_07ec, 3); jmpw(0x15_05fe, -0x1f1); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_07ef:
            ii(0x15_07ef, 3); pushw(0x80);                              /* push 0x80 */
            ii(0x15_07f2, 3); pushw(0x14ac);                            /* push 0x14ac */
            ii(0x15_07f5, 2); pushw(0xa);                               /* push 0xa */
            ii(0x15_07f7, 1); pushw(cs);                                /* push cs */
            ii(0x15_07f8, 3); callw(0x15_0588, -0x273);                 /* call 0x588 */
            ii(0x15_07fb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_07fe, 3); mov(memw_a16[ds, 0x1856], ax);            /* mov [0x1856], ax */
            ii(0x15_0801, 4); mov(memw_a16[ds, 0x1858], dx);            /* mov [0x1858], dx */
            ii(0x15_0805, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_0807, 4); or(ax, memw_a16[ds, 0x1856]);             /* or ax, [0x1856] */
            ii(0x15_080b, 2); if(jnzw(0x15_0813, 0x6)) goto l_0x15_0813; /* jnz 0x813 */
            ii(0x15_080d, 3); mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0x15_0810, 3); jmpw(0x15_05fe, -0x215); goto l_0x15_05fe; /* jmp 0x5fe */
        l_0x15_0813:
            ii(0x15_0813, 5); mov(memb_a16[ds, 0x188e], 0x1);           /* mov byte [0x188e], 0x1 */
        l_0x15_0818:
            ii(0x15_0818, 5); cmp(memb_a16[ds, 0x188e], 0x1);           /* cmp byte [0x188e], 0x1 */
            ii(0x15_081d, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_081f, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x15_0822, 1); cwd();                                    /* cwd */
            ii(0x15_0823, 1); popw(ds);                                 /* pop ds */
            ii(0x15_0824, 1); leavew();                                 /* leave */
            ii(0x15_0825, 1); retfw(); return;                          /* retf */
        }
    }
}
