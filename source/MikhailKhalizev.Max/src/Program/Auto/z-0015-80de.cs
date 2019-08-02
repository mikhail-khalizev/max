using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ee5fc9c-106b-4d7d-b418-442f4b65335c")]
        public void Method_0015_80de()
        {
            ii(0x15_80de, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x15_80e2, 1); pushw(di);                                /* push di */
            ii(0x15_80e3, 1); pushw(si);                                /* push si */
            ii(0x15_80e4, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_80e6, 1); pushw(ds);                                /* push ds */
            ii(0x15_80e7, 3); pushw(0x48a0);                            /* push 0x48a0 */
            ii(0x15_80ea, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_80ed, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_80f1, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_80f4, 4); pushw(memw_a16[es, bx + 0x34]);           /* push word [es:bx+0x34] */
            ii(0x15_80f8, 4); pushw(memw_a16[es, bx + 0x32]);           /* push word [es:bx+0x32] */
            ii(0x15_80fc, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x15_8101, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_8104, 3); mov(al, memb_a16[ds, 0x48a0]);            /* mov al, [0x48a0] */
            ii(0x15_8107, 3); mov(memb_a16[ds, 0x48a2], al);            /* mov [0x48a2], al */
            ii(0x15_810a, 5); cmp(memb_a16[ds, 0x48a2], 0x7);           /* cmp byte [0x48a2], 0x7 */
            ii(0x15_810f, 2); if(jzw(0x15_8114, 0x3)) goto l_0x15_8114; /* jz 0x8114 */
            ii(0x15_8111, 3); jmpw(0x15_8143, 0x2f); goto l_0x15_8143;  /* jmp 0x8143 */
        l_0x15_8114:
            ii(0x15_8114, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8117, 6); mov(memw_a16[es, bx + 0x6], 0);           /* mov word [es:bx+0x6], 0x0 */
        l_0x15_811d:
            ii(0x15_811d, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_811f, 1); pushw(ds);                                /* push ds */
            ii(0x15_8120, 3); pushw(0x16a8);                            /* push 0x16a8 */
            ii(0x15_8123, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8126, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_812a, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_812d, 4); pushw(memw_a16[es, bx + 0x1a]);           /* push word [es:bx+0x1a] */
            ii(0x15_8131, 4); pushw(memw_a16[es, bx + 0x18]);           /* push word [es:bx+0x18] */
            ii(0x15_8135, 5); callw_far_abs(0x80, 0x1566);              /* call word 0x80:0x1566 */
            ii(0x15_813a, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_813d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_8140, 3); jmpw(0x15_8216, 0xd3); goto l_0x15_8216;  /* jmp 0x8216 */
        l_0x15_8143:
            ii(0x15_8143, 5); cmp(memb_a16[ds, 0x48a2], 0x1f);          /* cmp byte [0x48a2], 0x1f */
            ii(0x15_8148, 2); if(jzw(0x15_814d, 0x3)) goto l_0x15_814d; /* jz 0x814d */
            ii(0x15_814a, 3); jmpw(0x15_8159, 0xc); goto l_0x15_8159;   /* jmp 0x8159 */
        l_0x15_814d:
            ii(0x15_814d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8150, 6); mov(memw_a16[es, bx + 0x4], 0);           /* mov word [es:bx+0x4], 0x0 */
            ii(0x15_8156, 3); jmpw(0x15_811d, -0x3c); goto l_0x15_811d; /* jmp 0x811d */
        l_0x15_8159:
            ii(0x15_8159, 6); cmp(memw_a16[ds, 0x48a0], 0xa10f);        /* cmp word [0x48a0], 0xa10f */
            ii(0x15_815f, 2); if(jzw(0x15_8164, 0x3)) goto l_0x15_8164; /* jz 0x8164 */
            ii(0x15_8161, 3); jmpw(0x15_8170, 0xc); goto l_0x15_8170;   /* jmp 0x8170 */
        l_0x15_8164:
            ii(0x15_8164, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8167, 6); mov(memw_a16[es, bx + 0x8], 0);           /* mov word [es:bx+0x8], 0x0 */
            ii(0x15_816d, 3); jmpw(0x15_811d, -0x53); goto l_0x15_811d; /* jmp 0x811d */
        l_0x15_8170:
            ii(0x15_8170, 6); cmp(memw_a16[ds, 0x48a0], 0xa90f);        /* cmp word [0x48a0], 0xa90f */
            ii(0x15_8176, 2); if(jzw(0x15_817b, 0x3)) goto l_0x15_817b; /* jz 0x817b */
            ii(0x15_8178, 3); jmpw(0x15_8187, 0xc); goto l_0x15_8187;   /* jmp 0x8187 */
        l_0x15_817b:
            ii(0x15_817b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_817e, 6); mov(memw_a16[es, bx + 0xa], 0);           /* mov word [es:bx+0xa], 0x0 */
            ii(0x15_8184, 3); jmpw(0x15_811d, -0x6a); goto l_0x15_811d; /* jmp 0x811d */
        l_0x15_8187:
            ii(0x15_8187, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_818a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_818d, 4); pushw(memw_a16[ds, 0x48a0]);              /* push word [0x48a0] */
            ii(0x15_8191, 1); nop();                                    /* nop */
            ii(0x15_8192, 1); pushw(cs);                                /* push cs */
            ii(0x15_8193, 3); callw(0x15_7ecf, -0x2c7);                 /* call 0x7ecf */
            ii(0x15_8196, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_8199, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_819c, 2); if(jnzw(0x15_81a1, 0x3)) goto l_0x15_81a1; /* jnz 0x81a1 */
            ii(0x15_819e, 3); jmpw(0x15_81a7, 0x6); goto l_0x15_81a7;   /* jmp 0x81a7 */
        l_0x15_81a1:
            ii(0x15_81a1, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_81a4, 3); jmpw(0x15_8216, 0x6f); goto l_0x15_8216;  /* jmp 0x8216 */
        l_0x15_81a7:
            ii(0x15_81a7, 5); cmp(memb_a16[ds, 0xd7e], 0);              /* cmp byte [0xd7e], 0x0 */
            ii(0x15_81ac, 2); if(jnzw(0x15_81b1, 0x3)) goto l_0x15_81b1; /* jnz 0x81b1 */
            ii(0x15_81ae, 3); jmpw(0x15_8210, 0x5f); goto l_0x15_8210;  /* jmp 0x8210 */
        l_0x15_81b1:
            ii(0x15_81b1, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_81b6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81b9, 5); cmp(memw_a16[es, bx + 0x6], 0x34);        /* cmp word [es:bx+0x6], 0x34 */
            ii(0x15_81be, 2); if(jzw(0x15_81c3, 0x3)) goto l_0x15_81c3; /* jz 0x81c3 */
            ii(0x15_81c0, 3); jmpw(0x15_81cf, 0xc); goto l_0x15_81cf;   /* jmp 0x81cf */
        l_0x15_81c3:
            ii(0x15_81c3, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81c6, 6); mov(memw_a16[es, bx + 0x6], 0x38);        /* mov word [es:bx+0x6], 0x38 */
            ii(0x15_81cc, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_81cf:
            ii(0x15_81cf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81d2, 5); cmp(memw_a16[es, bx + 0x8], 0x34);        /* cmp word [es:bx+0x8], 0x34 */
            ii(0x15_81d7, 2); if(jzw(0x15_81dc, 0x3)) goto l_0x15_81dc; /* jz 0x81dc */
            ii(0x15_81d9, 3); jmpw(0x15_81e8, 0xc); goto l_0x15_81e8;   /* jmp 0x81e8 */
        l_0x15_81dc:
            ii(0x15_81dc, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81df, 6); mov(memw_a16[es, bx + 0x8], 0x38);        /* mov word [es:bx+0x8], 0x38 */
            ii(0x15_81e5, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_81e8:
            ii(0x15_81e8, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81eb, 5); cmp(memw_a16[es, bx + 0xa], 0x34);        /* cmp word [es:bx+0xa], 0x34 */
            ii(0x15_81f0, 2); if(jzw(0x15_81f5, 0x3)) goto l_0x15_81f5; /* jz 0x81f5 */
            ii(0x15_81f2, 3); jmpw(0x15_8201, 0xc); goto l_0x15_8201;   /* jmp 0x8201 */
        l_0x15_81f5:
            ii(0x15_81f5, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_81f8, 6); mov(memw_a16[es, bx + 0xa], 0x38);        /* mov word [es:bx+0xa], 0x38 */
            ii(0x15_81fe, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x15_8201:
            ii(0x15_8201, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x15_8205, 2); if(jnzw(0x15_820a, 0x3)) goto l_0x15_820a; /* jnz 0x820a */
            ii(0x15_8207, 3); jmpw(0x15_8210, 0x6); goto l_0x15_8210;   /* jmp 0x8210 */
        l_0x15_820a:
            ii(0x15_820a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_820d, 3); jmpw(0x15_8216, 0x6); goto l_0x15_8216;   /* jmp 0x8216 */
        l_0x15_8210:
            ii(0x15_8210, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_8213, 3); jmpw(0x15_8216, 0); goto l_0x15_8216;     /* jmp 0x8216 */
        l_0x15_8216:
            ii(0x15_8216, 1); popw(si);                                 /* pop si */
            ii(0x15_8217, 1); popw(di);                                 /* pop di */
            ii(0x15_8218, 1); leavew();                                 /* leave */
            ii(0x15_8219, 1); retfw(); return;                          /* retf */
        }
    }
}
