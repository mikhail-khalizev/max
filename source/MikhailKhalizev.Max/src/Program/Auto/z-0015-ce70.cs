using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5f32504b-45fc-4984-8235-1c7ef3aecd1b")]
        public void Method_0015_ce70()
        {
            ii(0x15_ce70, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x15_ce74, 1); pushw(si);                                /* push si */
            ii(0x15_ce75, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x15_ce78, 4); mov(ax, memw_a16[es, bx + 0x34]);         /* mov ax, [es:bx+0x34] */
            ii(0x15_ce7c, 4); mov(dx, memw_a16[es, bx + 0x36]);         /* mov dx, [es:bx+0x36] */
            ii(0x15_ce80, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_ce83, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x15_ce86, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x15_ce8a, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x15_ce8e, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_ce91, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x15_ce94, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_ce97, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_ce99, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x15_ce9d, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_cea1, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_cea4, 3); jmpw(0x15_cfe7, 0x140); goto l_0x15_cfe7; /* jmp 0xcfe7 */
        l_0x15_cea7:
            ii(0x15_cea7, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_ceaa, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_ceac, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_ceaf, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x15_ceb3, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_ceb6, 3); lea(ax, bx + 0x4);                        /* lea ax, [bx+0x4] */
            ii(0x15_ceb9, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_cebc, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x15_cebf, 4); mov(al, memb_a16[es, bx + 0x1]);          /* mov al, [es:bx+0x1] */
            ii(0x15_cec3, 3); and(ax, 0x7f);                            /* and ax, 0x7f */
            ii(0x15_cec6, 2); if(jzw(0x15_ced6, 0xe)) goto l_0x15_ced6; /* jz 0xced6 */
            ii(0x15_cec8, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cec9, 2); if(jzw(0x15_cf26, 0x5b)) goto l_0x15_cf26; /* jz 0xcf26 */
            ii(0x15_cecb, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cecc, 2); if(jzw(0x15_cf2d, 0x5f)) goto l_0x15_cf2d; /* jz 0xcf2d */
            ii(0x15_cece, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cecf, 2); if(jzw(0x15_cf2d, 0x5c)) goto l_0x15_cf2d; /* jz 0xcf2d */
            ii(0x15_ced1, 1); dec(ax);                                  /* dec ax */
            ii(0x15_ced2, 2); if(jzw(0x15_cf34, 0x60)) goto l_0x15_cf34; /* jz 0xcf34 */
            ii(0x15_ced4, 2); jmpw(0x15_cedb, 0x5); goto l_0x15_cedb;   /* jmp 0xcedb */
        l_0x15_ced6:
            ii(0x15_ced6, 5); mov(memw_a16[ss, bp - 0x10], 0);          /* mov word [bp-0x10], 0x0 */
        l_0x15_cedb:
            ii(0x15_cedb, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_cede, 3); cmp(memw_a16[ss, bp - 0x6], ax);          /* cmp [bp-0x6], ax */
            ii(0x15_cee1, 2); if(jaew(0x15_cee6, 0x3)) goto l_0x15_cee6; /* jae 0xcee6 */
            ii(0x15_cee3, 3); jmpw(0x15_cfc3, 0xdd); goto l_0x15_cfc3;  /* jmp 0xcfc3 */
        l_0x15_cee6:
            ii(0x15_cee6, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x15_ceea, 2); if(jnzw(0x15_ceef, 0x3)) goto l_0x15_ceef; /* jnz 0xceef */
            ii(0x15_ceec, 3); jmpw(0x15_cff3, 0x104); goto l_0x15_cff3; /* jmp 0xcff3 */
        l_0x15_ceef:
            ii(0x15_ceef, 4); imul(cx, memw_a16[ss, bp - 0x12], 0x18);  /* imul cx, [bp-0x12], 0x18 */
            ii(0x15_cef3, 3); add(cx, memw_a16[ss, bp - 0xa]);          /* add cx, [bp-0xa] */
            ii(0x15_cef6, 3); mov(dx, memw_a16[ss, bp - 0x8]);          /* mov dx, [bp-0x8] */
            ii(0x15_cef9, 3); sub(cx, 0x18);                            /* sub cx, 0x18 */
            ii(0x15_cefc, 1); pushw(dx);                                /* push dx */
            ii(0x15_cefd, 1); pushw(cx);                                /* push cx */
            ii(0x15_cefe, 3); callw(0x15_cd74, -0x18d);                 /* call 0xcd74 */
            ii(0x15_cf01, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_cf04, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x15_cf07, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_cf0a, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cf0b, 3); mul(memw_a16[ss, bp - 0x10]);             /* mul word [bp-0x10] */
            ii(0x15_cf0e, 3); add(memw_a16[ss, bp - 0x4], ax);          /* add [bp-0x4], ax */
            ii(0x15_cf11, 3); les(bx, ss, bp - 0xe);                    /* les bx, [bp-0xe] */
            ii(0x15_cf14, 4); mov(al, memb_a16[es, bx + 0x1]);          /* mov al, [es:bx+0x1] */
            ii(0x15_cf18, 3); and(ax, 0x7f);                            /* and ax, 0x7f */
            ii(0x15_cf1b, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cf1c, 2); if(jzw(0x15_cf3b, 0x1d)) goto l_0x15_cf3b; /* jz 0xcf3b */
            ii(0x15_cf1e, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cf1f, 2); if(jzw(0x15_cf74, 0x53)) goto l_0x15_cf74; /* jz 0xcf74 */
            ii(0x15_cf21, 1); dec(ax);                                  /* dec ax */
            ii(0x15_cf22, 2); if(jzw(0x15_cf67, 0x43)) goto l_0x15_cf67; /* jz 0xcf67 */
            ii(0x15_cf24, 2); jmpw(0x15_cf83, 0x5d); goto l_0x15_cf83;  /* jmp 0xcf83 */
        l_0x15_cf26:
            ii(0x15_cf26, 5); mov(memw_a16[ss, bp - 0x10], 0x3);        /* mov word [bp-0x10], 0x3 */
            ii(0x15_cf2b, 2); jmpw(0x15_cedb, -0x52); goto l_0x15_cedb; /* jmp 0xcedb */
        l_0x15_cf2d:
            ii(0x15_cf2d, 5); mov(memw_a16[ss, bp - 0x10], 0x5);        /* mov word [bp-0x10], 0x5 */
            ii(0x15_cf32, 2); jmpw(0x15_cedb, -0x59); goto l_0x15_cedb; /* jmp 0xcedb */
        l_0x15_cf34:
            ii(0x15_cf34, 5); mov(memw_a16[ss, bp - 0x10], 0x7);        /* mov word [bp-0x10], 0x7 */
            ii(0x15_cf39, 2); jmpw(0x15_cedb, -0x60); goto l_0x15_cedb; /* jmp 0xcedb */
        l_0x15_cf3b:
            ii(0x15_cf3b, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_cf3e, 4); mov(ax, memw_a16[es, bx + 0x1]);          /* mov ax, [es:bx+0x1] */
            ii(0x15_cf42, 2); sub(dx, dx);                              /* sub dx, dx */
        l_0x15_cf44:
            ii(0x15_cf44, 3); add(memw_a16[ss, bp - 0x16], ax);         /* add [bp-0x16], ax */
            ii(0x15_cf47, 3); adc(memw_a16[ss, bp - 0x14], dx);         /* adc [bp-0x14], dx */
        l_0x15_cf4a:
            ii(0x15_cf4a, 4); cmp(memw_a16[ss, bp - 0x12], 0);          /* cmp word [bp-0x12], 0x0 */
            ii(0x15_cf4e, 2); if(jzw(0x15_cfb0, 0x60)) goto l_0x15_cfb0; /* jz 0xcfb0 */
            ii(0x15_cf50, 4); imul(bx, memw_a16[ss, bp - 0x12], 0x18);  /* imul bx, [bp-0x12], 0x18 */
            ii(0x15_cf54, 3); add(bx, memw_a16[ss, bp - 0xa]);          /* add bx, [bp-0xa] */
            ii(0x15_cf57, 3); mov(es, memw_a16[ss, bp - 0x8]);          /* mov es, [bp-0x8] */
            ii(0x15_cf5a, 5); test(memb_a16[es, bx - 0xf], 0x10);       /* test byte [es:bx-0xf], 0x10 */
            ii(0x15_cf5f, 2); if(jzw(0x15_cf94, 0x33)) goto l_0x15_cf94; /* jz 0xcf94 */
            ii(0x15_cf61, 4); mov(ax, memw_a16[es, bx - 0x4]);          /* mov ax, [es:bx-0x4] */
            ii(0x15_cf65, 2); jmpw(0x15_cfaa, 0x43); goto l_0x15_cfaa;  /* jmp 0xcfaa */
        l_0x15_cf67:
            ii(0x15_cf67, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_cf6a, 4); mov(ax, memw_a16[es, bx + 0x1]);          /* mov ax, [es:bx+0x1] */
            ii(0x15_cf6e, 4); mov(dx, memw_a16[es, bx + 0x3]);          /* mov dx, [es:bx+0x3] */
            ii(0x15_cf72, 2); jmpw(0x15_cf44, -0x30); goto l_0x15_cf44; /* jmp 0xcf44 */
        l_0x15_cf74:
            ii(0x15_cf74, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_cf77, 4); mov(ax, memw_a16[es, bx + 0x1]);          /* mov ax, [es:bx+0x1] */
            ii(0x15_cf7b, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_cf7d, 3); add(memw_a16[ss, bp - 0x16], ax);         /* add [bp-0x16], ax */
            ii(0x15_cf80, 3); adc(memw_a16[ss, bp - 0x14], dx);         /* adc [bp-0x14], dx */
        l_0x15_cf83:
            ii(0x15_cf83, 1); pushw(ds);                                /* push ds */
            ii(0x15_cf84, 3); pushw(0x290a);                            /* push 0x290a */
            ii(0x15_cf87, 3); pushw(0xce5);                             /* push 0xce5 */
            ii(0x15_cf8a, 5); callw_far_abs(0x80, 0x220b);              /* call word 0x80:0x220b */
            ii(0x15_cf8f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_cf92, 2); jmpw(0x15_cf4a, -0x4a); goto l_0x15_cf4a; /* jmp 0xcf4a */
        l_0x15_cf94:
            ii(0x15_cf94, 4); imul(si, memw_a16[ss, bp - 0x12], 0x18);  /* imul si, [bp-0x12], 0x18 */
            ii(0x15_cf98, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x15_cf9b, 5); test(memb_a16[es, bx + si - 0x10], 0x4);  /* test byte [es:bx+si-0x10], 0x4 */
            ii(0x15_cfa0, 2); if(jzw(0x15_cfa7, 0x5)) goto l_0x15_cfa7; /* jz 0xcfa7 */
            ii(0x15_cfa2, 3); mov(ax, memw_a16[ds, 0x19e4]);            /* mov ax, [0x19e4] */
            ii(0x15_cfa5, 2); jmpw(0x15_cfaa, 0x3); goto l_0x15_cfaa;   /* jmp 0xcfaa */
        l_0x15_cfa7:
            ii(0x15_cfa7, 3); mov(ax, memw_a16[ds, 0x19e6]);            /* mov ax, [0x19e6] */
        l_0x15_cfaa:
            ii(0x15_cfaa, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_cfad, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
        l_0x15_cfb0:
            ii(0x15_cfb0, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_cfb3, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_cfb6, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_cfb9, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_cfbd, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x15_cfc1, 2); jmpw(0x15_cff3, 0x30); goto l_0x15_cff3;  /* jmp 0xcff3 */
        l_0x15_cfc3:
            ii(0x15_cfc3, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x15_cfc6, 3); sub(memw_a16[ss, bp + 0x8], ax);          /* sub [bp+0x8], ax */
            ii(0x15_cfc9, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x15_cfcd, 2); if(jnzw(0x15_cfd5, 0x6)) goto l_0x15_cfd5; /* jnz 0xcfd5 */
            ii(0x15_cfcf, 4); add(memw_a16[ss, bp - 0xe], 0x2);         /* add word [bp-0xe], 0x2 */
            ii(0x15_cfd3, 2); jmpw(0x15_cfe7, 0x12); goto l_0x15_cfe7;  /* jmp 0xcfe7 */
        l_0x15_cfd5:
            ii(0x15_cfd5, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_cfd8, 3); mul(memw_a16[ss, bp - 0x6]);              /* mul word [bp-0x6] */
            ii(0x15_cfdb, 3); add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0x15_cfde, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_cfe1, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_cfe4, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
        l_0x15_cfe7:
            ii(0x15_cfe7, 3); les(bx, ss, bp - 0xe);                    /* les bx, [bp-0xe] */
            ii(0x15_cfea, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x15_cfee, 2); if(jzw(0x15_cff3, 0x3)) goto l_0x15_cff3; /* jz 0xcff3 */
            ii(0x15_cff0, 3); jmpw(0x15_cea7, -0x14c); goto l_0x15_cea7; /* jmp 0xcea7 */
        l_0x15_cff3:
            ii(0x15_cff3, 1); popw(si);                                 /* pop si */
            ii(0x15_cff4, 1); leavew();                                 /* leave */
            ii(0x15_cff5, 3); retw(0xa); return;                        /* ret 0xa */
        }
    }
}
