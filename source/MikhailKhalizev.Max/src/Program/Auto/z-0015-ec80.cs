using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("887afbae-b9cf-41bd-b616-d7613c673f64")]
        public void Method_0015_ec80()
        {
            ii(0x15_ec80, 4); enterw(0x2e, 0);                          /* enter 0x2e, 0x0 */
            ii(0x15_ec84, 1); pushw(di);                                /* push di */
            ii(0x15_ec85, 1); pushw(si);                                /* push si */
            ii(0x15_ec86, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ec89, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x15_ec8d, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x15_ec90, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ec93, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x15_ec97, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_ec9a, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ec9d, 4); mov(ax, memw_a16[es, bx + 0x24]);         /* mov ax, [es:bx+0x24] */
            ii(0x15_eca1, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x15_eca4, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_eca7, 4); mov(ax, memw_a16[es, bx + 0x20]);         /* mov ax, [es:bx+0x20] */
            ii(0x15_ecab, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x15_ecae, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ecb1, 4); mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x15_ecb5, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_ecb8, 3); mov(ax, memw_a16[ss, bp - 0x24]);         /* mov ax, [bp-0x24] */
            ii(0x15_ecbb, 3); jmpw(0x15_ef87, 0x2c9); goto l_0x15_ef87; /* jmp 0xef87 */
        l_0x15_ecbe:
            ii(0x15_ecbe, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_ecc1, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_ecc6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_ecc9, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_eccc, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_eccf, 2); if(jnzw(0x15_ecd4, 0x3)) goto l_0x15_ecd4; /* jnz 0xecd4 */
            ii(0x15_ecd1, 3); jmpw(0x15_ecf2, 0x1e); goto l_0x15_ecf2;  /* jmp 0xecf2 */
        l_0x15_ecd4:
            ii(0x15_ecd4, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ecd7, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x15_ecdb, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x15_ecdf, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_ece2, 1); nop();                                    /* nop */
            ii(0x15_ece3, 1); pushw(cs);                                /* push cs */
            ii(0x15_ece4, 3); callw(0x15_789c, -0x744b);                /* call 0x789c */
            ii(0x15_ece7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ecea, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_eced, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
        l_0x15_ecf2:
            ii(0x15_ecf2, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x15_ecf5, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_ecf7, 1); pushw(ax);                                /* push ax */
            ii(0x15_ecf8, 1); pushw(cx);                                /* push cx */
            ii(0x15_ecf9, 5); callw_far_abs(0x80, 0x5066);              /* call word 0x80:0x5066 */
            ii(0x15_ecfe, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_ed01, 3); sub(ax, memw_a16[ss, bp - 0x2a]);         /* sub ax, [bp-0x2a] */
            ii(0x15_ed04, 1); inc(ax);                                  /* inc ax */
            ii(0x15_ed05, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x15_ed08, 4); cmp(memw_a16[ss, bp - 0x2e], 0);          /* cmp word [bp-0x2e], 0x0 */
            ii(0x15_ed0c, 2); if(jnzw(0x15_ed11, 0x3)) goto l_0x15_ed11; /* jnz 0xed11 */
            ii(0x15_ed0e, 3); jmpw(0x15_ed1a, 0x9); goto l_0x15_ed1a;   /* jmp 0xed1a */
        l_0x15_ed11:
            ii(0x15_ed11, 4); cmp(memw_a16[ss, bp - 0x2e], 0x40);       /* cmp word [bp-0x2e], 0x40 */
            ii(0x15_ed15, 2); if(jaw(0x15_ed1a, 0x3)) goto l_0x15_ed1a; /* ja 0xed1a */
            ii(0x15_ed17, 3); jmpw(0x15_ed1f, 0x5); goto l_0x15_ed1f;   /* jmp 0xed1f */
        l_0x15_ed1a:
            ii(0x15_ed1a, 5); mov(memw_a16[ss, bp - 0x2e], 0x40);       /* mov word [bp-0x2e], 0x40 */
        l_0x15_ed1f:
            ii(0x15_ed1f, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_ed22, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_ed25, 3); mov(dx, memw_a16[ss, bp - 0x20]);         /* mov dx, [bp-0x20] */
            ii(0x15_ed28, 1); pushw(dx);                                /* push dx */
            ii(0x15_ed29, 1); pushw(ax);                                /* push ax */
            ii(0x15_ed2a, 4); pushw(memw_a16[ds, 0x48fc]);              /* push word [0x48fc] */
            ii(0x15_ed2e, 4); pushw(memw_a16[ds, 0x48fa]);              /* push word [0x48fa] */
            ii(0x15_ed32, 5); callw_far_abs(0x80, 0x4d94);              /* call word 0x80:0x4d94 */
            ii(0x15_ed37, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ed3a, 4); cmp(memw_a16[ss, bp - 0x2c], 0);          /* cmp word [bp-0x2c], 0x0 */
            ii(0x15_ed3e, 2); if(jnzw(0x15_ed43, 0x3)) goto l_0x15_ed43; /* jnz 0xed43 */
            ii(0x15_ed40, 3); jmpw(0x15_ed48, 0x5); goto l_0x15_ed48;   /* jmp 0xed48 */
        l_0x15_ed43:
            ii(0x15_ed43, 1); nop();                                    /* nop */
            ii(0x15_ed44, 1); pushw(cs);                                /* push cs */
            ii(0x15_ed45, 3); callw(0x15_78c6, -0x7482);                /* call 0x78c6 */
        l_0x15_ed48:
            ii(0x15_ed48, 5); mov(memw_a16[ss, bp - 0xc], 0x9);         /* mov word [bp-0xc], 0x9 */
            ii(0x15_ed4d, 3); mov(ax, memw_a16[ss, bp - 0x26]);         /* mov ax, [bp-0x26] */
            ii(0x15_ed50, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x15_ed53, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_ed56, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_ed59, 5); mov(memw_a16[ss, bp - 0x10], 0x20);       /* mov word [bp-0x10], 0x20 */
            ii(0x15_ed5e, 3); mov(ax, memw_a16[ds, 0x4900]);            /* mov ax, [0x4900] */
            ii(0x15_ed61, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_ed64, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x15_ed67, 1); pushw(ss);                                /* push ss */
            ii(0x15_ed68, 1); pushw(ax);                                /* push ax */
            ii(0x15_ed69, 1); pushw(ss);                                /* push ss */
            ii(0x15_ed6a, 1); pushw(ax);                                /* push ax */
            ii(0x15_ed6b, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_ed6d, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x15_ed72, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ed75, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ed78, 3); jmpw(0x15_efd0, 0x255); goto l_0x15_efd0; /* jmp 0xefd0 */
        l_0x15_ed7b:
            ii(0x15_ed7b, 5); cmp(memw_a16[ds, 0x2e04], 0);             /* cmp word [0x2e04], 0x0 */
            ii(0x15_ed80, 2); if(jzw(0x15_ed85, 0x3)) goto l_0x15_ed85; /* jz 0xed85 */
            ii(0x15_ed82, 3); jmpw(0x15_ed98, 0x13); goto l_0x15_ed98;  /* jmp 0xed98 */
        l_0x15_ed85:
            ii(0x15_ed85, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ed88, 5); or(memw_a16[es, bx + 0x3a], 0x1);         /* or word [es:bx+0x3a], 0x1 */
            ii(0x15_ed8d, 5); or(memw_a16[es, bx + 0x3c], 0);           /* or word [es:bx+0x3c], 0x0 */
            ii(0x15_ed92, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ed95, 3); jmpw(0x15_efd0, 0x238); goto l_0x15_efd0; /* jmp 0xefd0 */
        l_0x15_ed98:
            ii(0x15_ed98, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_ed9b, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_eda0, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_eda3, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_eda6, 2); if(jnzw(0x15_edab, 0x3)) goto l_0x15_edab; /* jnz 0xedab */
            ii(0x15_eda8, 3); jmpw(0x15_edd1, 0x26); goto l_0x15_edd1;  /* jmp 0xedd1 */
        l_0x15_edab:
            ii(0x15_edab, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_edae, 4); mov(ax, memw_a16[es, bx + 0x20]);         /* mov ax, [es:bx+0x20] */
            ii(0x15_edb2, 4); mov(dx, memw_a16[es, bx + 0x22]);         /* mov dx, [es:bx+0x22] */
            ii(0x15_edb6, 3); mov(memw_a16[ds, 0x2ddc], ax);            /* mov [0x2ddc], ax */
            ii(0x15_edb9, 4); mov(memw_a16[ds, 0x2dde], dx);            /* mov [0x2dde], dx */
            ii(0x15_edbd, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x15_edc0, 3); mov(memw_a16[ds, 0x2de0], ax);            /* mov [0x2de0], ax */
            ii(0x15_edc3, 6); mov(memw_a16[ds, 0x2de2], 0);             /* mov word [0x2de2], 0x0 */
            ii(0x15_edc9, 5); mov(memb_a16[ds, 0x2dc8], 0x1);           /* mov byte [0x2dc8], 0x1 */
            ii(0x15_edce, 3); jmpw(0x15_ede3, 0x12); goto l_0x15_ede3;  /* jmp 0xede3 */
        l_0x15_edd1:
            ii(0x15_edd1, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x15_edd4, 3); mov(cx, memw_a16[ss, bp - 0x2a]);         /* mov cx, [bp-0x2a] */
            ii(0x15_edd7, 4); mov(memw_a16[ds, 0x2dcc], cx);            /* mov [0x2dcc], cx */
            ii(0x15_eddb, 3); mov(memw_a16[ds, 0x2dce], ax);            /* mov [0x2dce], ax */
            ii(0x15_edde, 5); mov(memb_a16[ds, 0x2dc8], 0);             /* mov byte [0x2dc8], 0x0 */
        l_0x15_ede3:
            ii(0x15_ede3, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_ede6, 3); mov(memw_a16[ds, 0x2dfc], ax);            /* mov [0x2dfc], ax */
            ii(0x15_ede9, 5); mov(memw_a16[ss, bp - 0xc], 0xc);         /* mov word [bp-0xc], 0xc */
            ii(0x15_edee, 3); mov(ax, memw_a16[ss, bp - 0x28]);         /* mov ax, [bp-0x28] */
            ii(0x15_edf1, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_edf4, 3); mov(ax, memw_a16[ds, 0x2e06]);            /* mov ax, [0x2e06] */
            ii(0x15_edf7, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_edfa, 3); mov(ax, memw_a16[ds, 0x2e04]);            /* mov ax, [0x2e04] */
            ii(0x15_edfd, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_ee00, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x15_ee03, 1); pushw(ss);                                /* push ss */
            ii(0x15_ee04, 1); pushw(ax);                                /* push ax */
            ii(0x15_ee05, 1); pushw(ss);                                /* push ss */
            ii(0x15_ee06, 1); pushw(ax);                                /* push ax */
            ii(0x15_ee07, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_ee09, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x15_ee0e, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ee11, 4); cmp(memw_a16[ss, bp - 0x24], 0xc);        /* cmp word [bp-0x24], 0xc */
            ii(0x15_ee15, 2); if(jzw(0x15_ee1a, 0x3)) goto l_0x15_ee1a; /* jz 0xee1a */
            ii(0x15_ee17, 3); jmpw(0x15_ee20, 0x6); goto l_0x15_ee20;   /* jmp 0xee20 */
        l_0x15_ee1a:
            ii(0x15_ee1a, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ee1d, 3); jmpw(0x15_efd0, 0x1b0); goto l_0x15_efd0; /* jmp 0xefd0 */
        l_0x15_ee20:
            ii(0x15_ee20, 3); mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x15_ee23, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ee26, 4); mov(memw_a16[es, bx + 0x24], ax);         /* mov [es:bx+0x24], ax */
            ii(0x15_ee2a, 6); mov(memw_a16[es, bx + 0x26], 0);          /* mov word [es:bx+0x26], 0x0 */
            ii(0x15_ee30, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x15_ee33, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ee36, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x15_ee3a, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_ee3d, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ee40, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x15_ee44, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x15_ee4a, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ee4d, 3); jmpw(0x15_efd0, 0x180); goto l_0x15_efd0; /* jmp 0xefd0 */
        l_0x15_ee50:
            ii(0x15_ee50, 3); mov(ax, memw_a16[ds, 0x2dce]);            /* mov ax, [0x2dce] */
            ii(0x15_ee53, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_ee56, 3); mov(ax, memw_a16[ds, 0x2dcc]);            /* mov ax, [0x2dcc] */
            ii(0x15_ee59, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_ee5c, 3); mov(ax, memw_a16[ds, 0x2dfc]);            /* mov ax, [0x2dfc] */
            ii(0x15_ee5f, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x15_ee62, 3); jmpw(0x15_ed7b, -0xea); goto l_0x15_ed7b; /* jmp 0xed7b */
        l_0x15_ee65:
            ii(0x15_ee65, 5); mov(memw_a16[ss, bp - 0xc], 0x16);        /* mov word [bp-0xc], 0x16 */
            ii(0x15_ee6a, 5); mov(memw_a16[ss, bp - 0x10], 0x20);       /* mov word [bp-0x10], 0x20 */
            ii(0x15_ee6f, 3); mov(ax, memw_a16[ds, 0x4900]);            /* mov ax, [0x4900] */
            ii(0x15_ee72, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_ee75, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x15_ee78, 1); pushw(ss);                                /* push ss */
            ii(0x15_ee79, 1); pushw(ax);                                /* push ax */
            ii(0x15_ee7a, 1); pushw(ss);                                /* push ss */
            ii(0x15_ee7b, 1); pushw(ax);                                /* push ax */
            ii(0x15_ee7c, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_ee7e, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x15_ee83, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ee86, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_ee89, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_ee8e, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_ee91, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_ee94, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_ee97, 2); if(jnzw(0x15_ee9c, 0x3)) goto l_0x15_ee9c; /* jnz 0xee9c */
            ii(0x15_ee99, 3); jmpw(0x15_eeba, 0x1e); goto l_0x15_eeba;  /* jmp 0xeeba */
        l_0x15_ee9c:
            ii(0x15_ee9c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ee9f, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x15_eea3, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x15_eea7, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_eeaa, 1); nop();                                    /* nop */
            ii(0x15_eeab, 1); pushw(cs);                                /* push cs */
            ii(0x15_eeac, 3); callw(0x15_789c, -0x7613);                /* call 0x789c */
            ii(0x15_eeaf, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_eeb2, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_eeb5, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
        l_0x15_eeba:
            ii(0x15_eeba, 4); pushw(memw_a16[ds, 0x48f8]);              /* push word [0x48f8] */
            ii(0x15_eebe, 4); pushw(memw_a16[ds, 0x48fc]);              /* push word [0x48fc] */
            ii(0x15_eec2, 4); pushw(memw_a16[ds, 0x48fa]);              /* push word [0x48fa] */
            ii(0x15_eec6, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_eec9, 3); mov(dx, memw_a16[ss, bp - 0x20]);         /* mov dx, [bp-0x20] */
            ii(0x15_eecc, 1); pushw(dx);                                /* push dx */
            ii(0x15_eecd, 1); pushw(ax);                                /* push ax */
            ii(0x15_eece, 5); callw_far_abs(0x80, 0x4d94);              /* call word 0x80:0x4d94 */
            ii(0x15_eed3, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_eed6, 4); cmp(memw_a16[ss, bp - 0x2c], 0);          /* cmp word [bp-0x2c], 0x0 */
            ii(0x15_eeda, 2); if(jnzw(0x15_eedf, 0x3)) goto l_0x15_eedf; /* jnz 0xeedf */
            ii(0x15_eedc, 3); jmpw(0x15_eee4, 0x5); goto l_0x15_eee4;   /* jmp 0xeee4 */
        l_0x15_eedf:
            ii(0x15_eedf, 1); nop();                                    /* nop */
            ii(0x15_eee0, 1); pushw(cs);                                /* push cs */
            ii(0x15_eee1, 3); callw(0x15_78c6, -0x761e);                /* call 0x78c6 */
        l_0x15_eee4:
            ii(0x15_eee4, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_eee7, 3); jmpw(0x15_efd0, 0xe6); goto l_0x15_efd0;  /* jmp 0xefd0 */
        l_0x15_eeea:
            ii(0x15_eeea, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_eeed, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_eef2, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_eef5, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_eef8, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_eefb, 2); if(jnzw(0x15_ef00, 0x3)) goto l_0x15_ef00; /* jnz 0xef00 */
            ii(0x15_eefd, 3); jmpw(0x15_ef1e, 0x1e); goto l_0x15_ef1e;  /* jmp 0xef1e */
        l_0x15_ef00:
            ii(0x15_ef00, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ef03, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x15_ef07, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x15_ef0b, 3); pushw(memw_a16[ss, bp - 0x20]);           /* push word [bp-0x20] */
            ii(0x15_ef0e, 1); nop();                                    /* nop */
            ii(0x15_ef0f, 1); pushw(cs);                                /* push cs */
            ii(0x15_ef10, 3); callw(0x15_789c, -0x7677);                /* call 0x789c */
            ii(0x15_ef13, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_ef16, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_ef19, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
        l_0x15_ef1e:
            ii(0x15_ef1e, 4); pushw(memw_a16[ds, 0x48f8]);              /* push word [0x48f8] */
            ii(0x15_ef22, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_ef25, 3); mov(dx, memw_a16[ss, bp - 0x20]);         /* mov dx, [bp-0x20] */
            ii(0x15_ef28, 1); pushw(dx);                                /* push dx */
            ii(0x15_ef29, 1); pushw(ax);                                /* push ax */
            ii(0x15_ef2a, 4); pushw(memw_a16[ds, 0x48fc]);              /* push word [0x48fc] */
            ii(0x15_ef2e, 4); pushw(memw_a16[ds, 0x48fa]);              /* push word [0x48fa] */
            ii(0x15_ef32, 5); callw_far_abs(0x80, 0x4d94);              /* call word 0x80:0x4d94 */
            ii(0x15_ef37, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ef3a, 4); cmp(memw_a16[ss, bp - 0x2c], 0);          /* cmp word [bp-0x2c], 0x0 */
            ii(0x15_ef3e, 2); if(jnzw(0x15_ef43, 0x3)) goto l_0x15_ef43; /* jnz 0xef43 */
            ii(0x15_ef40, 3); jmpw(0x15_ef48, 0x5); goto l_0x15_ef48;   /* jmp 0xef48 */
        l_0x15_ef43:
            ii(0x15_ef43, 1); nop();                                    /* nop */
            ii(0x15_ef44, 1); pushw(cs);                                /* push cs */
            ii(0x15_ef45, 3); callw(0x15_78c6, -0x7682);                /* call 0x78c6 */
        l_0x15_ef48:
            ii(0x15_ef48, 5); mov(memw_a16[ss, bp - 0xc], 0x17);        /* mov word [bp-0xc], 0x17 */
            ii(0x15_ef4d, 5); mov(memw_a16[ss, bp - 0x10], 0x20);       /* mov word [bp-0x10], 0x20 */
            ii(0x15_ef52, 3); mov(ax, memw_a16[ds, 0x4900]);            /* mov ax, [0x4900] */
            ii(0x15_ef55, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_ef58, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x15_ef5b, 1); pushw(ss);                                /* push ss */
            ii(0x15_ef5c, 1); pushw(ax);                                /* push ax */
            ii(0x15_ef5d, 1); pushw(ss);                                /* push ss */
            ii(0x15_ef5e, 1); pushw(ax);                                /* push ax */
            ii(0x15_ef5f, 2); pushw(0x33);                              /* push 0x33 */
            ii(0x15_ef61, 5); callw_far_abs(0x80, 0x570e);              /* call word 0x80:0x570e */
            ii(0x15_ef66, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_ef69, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ef6c, 3); jmpw(0x15_efd0, 0x61); goto l_0x15_efd0;  /* jmp 0xefd0 */
        l_0x15_ef6f:
            ii(0x15_ef6f, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_ef72, 6); mov(memw_a16[es, bx + 0x28], 0xffff);     /* mov word [es:bx+0x28], 0xffff */
            ii(0x15_ef78, 6); mov(memw_a16[es, bx + 0x2a], 0);          /* mov word [es:bx+0x2a], 0x0 */
            ii(0x15_ef7e, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_ef81, 3); jmpw(0x15_efd0, 0x4c); goto l_0x15_efd0;  /* jmp 0xefd0 */
        //    ii(0x15_ef84, 3); jmpw(0x15_efca, 0x43); goto l_0x15_efca;  /* jmp 0xefca */
        l_0x15_ef87:
            ii(0x15_ef87, 3); sub(ax, 0x9);                             /* sub ax, 0x9 */
            ii(0x15_ef8a, 3); cmp(ax, 0x17);                            /* cmp ax, 0x17 */
            ii(0x15_ef8d, 2); if(jbew(0x15_ef92, 0x3)) goto l_0x15_ef92; /* jbe 0xef92 */
            ii(0x15_ef8f, 3); jmpw(0x15_efca, 0x38); goto l_0x15_efca;  /* jmp 0xefca */
        l_0x15_ef92:
            ii(0x15_ef92, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_ef94, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x15_ef95, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx - 0x6486]))
            {
                case 0x15_ecbe:
                    goto l_0x15_ecbe;
                case 0x15_ed7b:
                    goto l_0x15_ed7b;
                case 0x15_ee50:
                    goto l_0x15_ee50;
                case 0x15_ee65:
                    goto l_0x15_ee65;
                case 0x15_eeea:
                    goto l_0x15_eeea;
                case 0x15_ef6f:
                    goto l_0x15_ef6f;
                case 0x15_efca:
                    goto l_0x15_efca;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx-0x6486] */
        //    ii(0x15_ef9a, 48); /* Служебная область с абсолютными адресами переходов. {0x15_ecbe, 0x15_efca, 0x15_efca, 0x15_ed7b, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_ee50, 0x15_efca, 0x15_ee65, 0x15_eeea, 0x15_ef6f, 0x15_ef6f, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_efca, 0x15_ef6f, 0x15_ef6f}. */
        l_0x15_efca:
            ii(0x15_efca, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_efcd, 3); jmpw(0x15_efd0, 0); goto l_0x15_efd0;     /* jmp 0xefd0 */
        l_0x15_efd0:
            ii(0x15_efd0, 1); popw(si);                                 /* pop si */
            ii(0x15_efd1, 1); popw(di);                                 /* pop di */
            ii(0x15_efd2, 1); leavew();                                 /* leave */
            ii(0x15_efd3, 1); retfw(); return;                          /* retf */
        }
    }
}
