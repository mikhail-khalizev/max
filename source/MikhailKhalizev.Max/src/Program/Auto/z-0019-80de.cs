using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_80de-e5c82c38")]
        public void Method_0019_80de()
        {
            ii(0x19_80de, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_80e2, 1); pushw(di);                                /* push di */
            ii(0x19_80e3, 1); pushw(si);                                /* push si */
            ii(0x19_80e4, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x19_80e6, 1); pushw(ds);                                /* push ds */
            ii(0x19_80e7, 3); pushw(0x48a0);                            /* push 0x48a0 */
            ii(0x19_80ea, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_80ed, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x19_80f1, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_80f4, 4); pushw(memw_a16[es, bx + 0x34]);           /* push word [es:bx+0x34] */
            ii(0x19_80f8, 4); pushw(memw_a16[es, bx + 0x32]);           /* push word [es:bx+0x32] */
            ii(0x19_80fc, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x19_8101, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_8104, 3); mov(al, memb_a16[ds, 0x48a0]);            /* mov al, [0x48a0] */
            ii(0x19_8107, 3); mov(memb_a16[ds, 0x48a2], al);            /* mov [0x48a2], al */
            ii(0x19_810a, 5); cmp(memb_a16[ds, 0x48a2], 0x7);           /* cmp byte [0x48a2], 0x7 */
            ii(0x19_810f, 2); if(jzw(0x19_8114, 0x3)) goto l_0x19_8114; /* jz 0x8114 */
            ii(0x19_8111, 3); jmpw(0x19_8143, 0x2f); goto l_0x19_8143;  /* jmp 0x8143 */
        l_0x19_8114:
            ii(0x19_8114, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_8117, 6); mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
        l_0x19_811d:
            ii(0x19_811d, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x19_811f, 1); pushw(ds);                                /* push ds */
            ii(0x19_8120, 3); pushw(0x16a8);                            /* push 0x16a8 */
            ii(0x19_8123, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_8126, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_812a, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_812d, 4); pushw(memw_a16[es, bx + 0x1a]);           /* push word [es:bx+0x1a] */
            ii(0x19_8131, 4); pushw(memw_a16[es, bx + 0x18]);           /* push word [es:bx+0x18] */
            ii(0x19_8135, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x19_813a, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_813d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_8140, 3); jmpw(0x19_8216, 0xd3); goto l_0x19_8216;  /* jmp 0x8216 */
        l_0x19_8143:
            ii(0x19_8143, 5); cmp(memb_a16[ds, 0x48a2], 0x1f);          /* cmp byte [0x48a2], 0x1f */
            ii(0x19_8148, 2); if(jzw(0x19_814d, 0x3)) goto l_0x19_814d; /* jz 0x814d */
            ii(0x19_814a, 3); jmpw(0x19_8159, 0xc); goto l_0x19_8159;   /* jmp 0x8159 */
        l_0x19_814d:
            ii(0x19_814d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_8150, 6); mov(memw_a16[es, bx + 0x4], 0);           /* mov word [es:bx+0x4], 0x0 */
            ii(0x19_8156, 3); jmpw(0x19_811d, -0x3c); goto l_0x19_811d; /* jmp 0x811d */
        l_0x19_8159:
            ii(0x19_8159, 6); cmp(memw_a16[ds, 0x48a0], 0xa10f);        /* cmp word [0x48a0], 0xa10f */
            ii(0x19_815f, 2); if(jzw(0x19_8164, 0x3)) goto l_0x19_8164; /* jz 0x8164 */
            ii(0x19_8161, 3); jmpw(0x19_8170, 0xc); goto l_0x19_8170;   /* jmp 0x8170 */
        l_0x19_8164:
            ii(0x19_8164, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_8167, 6); mov(memw_a16[es, bx + 0x8], 0);           /* mov word [es:bx+0x8], 0x0 */
            ii(0x19_816d, 3); jmpw(0x19_811d, -0x53); goto l_0x19_811d; /* jmp 0x811d */
        l_0x19_8170:
            ii(0x19_8170, 6); cmp(memw_a16[ds, 0x48a0], 0xa90f);        /* cmp word [0x48a0], 0xa90f */
            ii(0x19_8176, 2); if(jzw(0x19_817b, 0x3)) goto l_0x19_817b; /* jz 0x817b */
            ii(0x19_8178, 3); jmpw(0x19_8187, 0xc); goto l_0x19_8187;   /* jmp 0x8187 */
        l_0x19_817b:
            ii(0x19_817b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_817e, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x19_8184, 3); jmpw(0x19_811d, -0x6a); goto l_0x19_811d; /* jmp 0x811d */
        l_0x19_8187:
            ii(0x19_8187, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_818a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_818d, 4); pushw(memw_a16[ds, 0x48a0]);              /* push word [0x48a0] */
            ii(0x19_8191, 1); nop();                                    /* nop */
            ii(0x19_8192, 1); pushw(cs);                                /* push cs */
            ii(0x19_8193, 3); callw(0x19_7ecf, -0x2c7);                 /* call 0x7ecf */
            ii(0x19_8196, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_8199, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_819c, 2); if(jnzw(0x19_81a1, 0x3)) goto l_0x19_81a1; /* jnz 0x81a1 */
            ii(0x19_819e, 3); jmpw(0x19_81a7, 0x6); goto l_0x19_81a7;   /* jmp 0x81a7 */
        l_0x19_81a1:
            ii(0x19_81a1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_81a4, 3); jmpw(0x19_8216, 0x6f); goto l_0x19_8216;  /* jmp 0x8216 */
        l_0x19_81a7:
            ii(0x19_81a7, 5); cmp(memb_a16[ds, 0xd7e], 0);              /* cmp byte [0xd7e], 0x0 */
            ii(0x19_81ac, 2); if(jnzw(0x19_81b1, 0x3)) goto l_0x19_81b1; /* jnz 0x81b1 */
            ii(0x19_81ae, 3); jmpw(0x19_8210, 0x5f); goto l_0x19_8210;  /* jmp 0x8210 */
        l_0x19_81b1:
            ii(0x19_81b1, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x19_81b6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81b9, 5); cmp(memw_a16[es, bx + 0x6], 0x34);        /* cmp word [es:bx+0x6], 0x34 */
            ii(0x19_81be, 2); if(jzw(0x19_81c3, 0x3)) goto l_0x19_81c3; /* jz 0x81c3 */
            ii(0x19_81c0, 3); jmpw(0x19_81cf, 0xc); goto l_0x19_81cf;   /* jmp 0x81cf */
        l_0x19_81c3:
            ii(0x19_81c3, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81c6, 6); mov(memw_a16[es, bx + 0x6], 0x38);        /* mov word [es:bx+0x6], 0x38 */
            ii(0x19_81cc, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_81cf:
            ii(0x19_81cf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81d2, 5); cmp(memw_a16[es, bx + 0x8], 0x34);        /* cmp word [es:bx+0x8], 0x34 */
            ii(0x19_81d7, 2); if(jzw(0x19_81dc, 0x3)) goto l_0x19_81dc; /* jz 0x81dc */
            ii(0x19_81d9, 3); jmpw(0x19_81e8, 0xc); goto l_0x19_81e8;   /* jmp 0x81e8 */
        l_0x19_81dc:
            ii(0x19_81dc, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81df, 6); mov(memw_a16[es, bx + 0x8], 0x38);        /* mov word [es:bx+0x8], 0x38 */
            ii(0x19_81e5, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_81e8:
            ii(0x19_81e8, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81eb, 5); cmp(memw_a16[es, bx + 0xa], 0x34);        /* cmp word [es:bx+0xa], 0x34 */
            ii(0x19_81f0, 2); if(jzw(0x19_81f5, 0x3)) goto l_0x19_81f5; /* jz 0x81f5 */
            ii(0x19_81f2, 3); jmpw(0x19_8201, 0xc); goto l_0x19_8201;   /* jmp 0x8201 */
        l_0x19_81f5:
            ii(0x19_81f5, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_81f8, 6); mov(memw_a16[es, bx + 0xa], 0x38);        /* mov word [es:bx+0xa], 0x38 */
            ii(0x19_81fe, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_8201:
            ii(0x19_8201, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x19_8205, 2); if(jnzw(0x19_820a, 0x3)) goto l_0x19_820a; /* jnz 0x820a */
            ii(0x19_8207, 3); jmpw(0x19_8210, 0x6); goto l_0x19_8210;   /* jmp 0x8210 */
        l_0x19_820a:
            ii(0x19_820a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_820d, 3); jmpw(0x19_8216, 0x6); goto l_0x19_8216;   /* jmp 0x8216 */
        l_0x19_8210:
            ii(0x19_8210, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8213, 3); jmpw(0x19_8216, 0); goto l_0x19_8216;     /* jmp 0x8216 */
        l_0x19_8216:
            ii(0x19_8216, 1); popw(si);                                 /* pop si */
            ii(0x19_8217, 1); popw(di);                                 /* pop di */
            ii(0x19_8218, 1); leavew();                                 /* leave */
            ii(0x19_8219, 1); retfw(); return;                          /* retf */
        }
    }
}
