using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ca8e-b7f85ec5")]
        public void Method_0018_ca8e()
        {
            ii(0x18_ca8e, 4); enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x18_ca92, 1); pushw(di);                                /* push di */
            ii(0x18_ca93, 1); pushw(si);                                /* push si */
            ii(0x18_ca94, 6); mov(memw_a16[ds, 0x38], 0);               /* mov word [0x38], 0x0 */
            ii(0x18_ca9a, 4); mov(memb_a16[ss, bp - 0x6], 0);           /* mov byte [bp-0x6], 0x0 */
            ii(0x18_ca9e, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_caa1, 6); mov(memw_a16[es, bx + 0x16], 0x1);        /* mov word [es:bx+0x16], 0x1 */
            ii(0x18_caa7, 4); mov(di, memw_a16[es, bx + 0x10]);         /* mov di, [es:bx+0x10] */
            ii(0x18_caab, 4); cmp(di, 0x1000);                          /* cmp di, 0x1000 */
            ii(0x18_caaf, 2); if(jaw(0x18_cad6, 0x25)) goto l_0x18_cad6; /* ja 0xcad6 */
            ii(0x18_cab1, 2); or(di, di);                               /* or di, di */
            ii(0x18_cab3, 2); if(jzw(0x18_cad6, 0x21)) goto l_0x18_cad6; /* jz 0xcad6 */
            ii(0x18_cab5, 4); mov(ax, memw_a16[es, bx + 0x6]);          /* mov ax, [es:bx+0x6] */
            ii(0x18_cab9, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x18_cabc, 4); cmp(ax, memw_a16[ds, 0x97c]);             /* cmp ax, [0x97c] */
            ii(0x18_cac0, 2); if(jaew(0x18_cad6, 0x14)) goto l_0x18_cad6; /* jae 0xcad6 */
            ii(0x18_cac2, 3); lea(cx, bp - 0x18);                       /* lea cx, [bp-0x18] */
            ii(0x18_cac5, 1); pushw(cx);                                /* push cx */
            ii(0x18_cac6, 1); pushw(ax);                                /* push ax */
            ii(0x18_cac7, 3); callw(0x18_dc8e, 0x11c4);                 /* call 0xdc8e */
            ii(0x18_caca, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cacb, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cacc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_cace, 2); if(jzw(0x18_cad6, 0x6)) goto l_0x18_cad6; /* jz 0xcad6 */
            ii(0x18_cad0, 4); test(memb_a16[ss, bp - 0x10], 0x10);      /* test byte [bp-0x10], 0x10 */
            ii(0x18_cad4, 2); if(jnzw(0x18_cad9, 0x3)) goto l_0x18_cad9; /* jnz 0xcad9 */
        l_0x18_cad6:
            ii(0x18_cad6, 3); jmpw(0x18_ccf3, 0x21a); goto l_0x18_ccf3; /* jmp 0xccf3 */
        l_0x18_cad9:
            ii(0x18_cad9, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x18_cadc, 3); callw(0x18_daf7, 0x1018);                 /* call 0xdaf7 */
            ii(0x18_cadf, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cae0, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_cae2, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x18_cae5, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x18_cae8, 3); callw(0x18_dbbc, 0x10d1);                 /* call 0xdbbc */
            ii(0x18_caeb, 1); popw(bx);                                 /* pop bx */
            ii(0x18_caec, 1); popw(bx);                                 /* pop bx */
            ii(0x18_caed, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x18_caf0, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x18_caf3, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_caf6, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_caf9, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_cafb, 2); if(jzw(0x18_cb14, 0x17)) goto l_0x18_cb14; /* jz 0xcb14 */
            ii(0x18_cafd, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x18_cb00, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_cb03, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x18_cb07, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x18_cb0b, 4); test(memb_a16[es, bx], 0x1);              /* test byte [es:bx], 0x1 */
            ii(0x18_cb0f, 2); if(jnzw(0x18_cb14, 0x3)) goto l_0x18_cb14; /* jnz 0xcb14 */
            ii(0x18_cb11, 3); jmpw(0x18_ccf3, 0x1df); goto l_0x18_ccf3; /* jmp 0xccf3 */
        l_0x18_cb14:
            ii(0x18_cb14, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_cb17, 6); mov(memw_a16[es, bx + 0x16], 0x8);        /* mov word [es:bx+0x16], 0x8 */
            ii(0x18_cb1d, 6); mov(memw_a16[es, bx + 0x10], 0);          /* mov word [es:bx+0x10], 0x0 */
            ii(0x18_cb23, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x18_cb26, 3); or(ax, memw_a16[ss, bp - 0xa]);           /* or ax, [bp-0xa] */
            ii(0x18_cb29, 2); if(jnzw(0x18_cb32, 0x7)) goto l_0x18_cb32; /* jnz 0xcb32 */
            ii(0x18_cb2b, 5); cmp(memb_a16[ds, 0x980], 0x3);            /* cmp byte [0x980], 0x3 */
            ii(0x18_cb30, 2); if(jlw(0x18_cb3b, 0x9)) goto l_0x18_cb3b; /* jl 0xcb3b */
        l_0x18_cb32:
            ii(0x18_cb32, 4); cmp(memw_a16[ss, bp - 0x16], 0x10);       /* cmp word [bp-0x16], 0x10 */
            ii(0x18_cb36, 2); if(jaew(0x18_cb3b, 0x3)) goto l_0x18_cb3b; /* jae 0xcb3b */
            ii(0x18_cb38, 3); jmpw(0x18_cc1e, 0xe3); goto l_0x18_cc1e;  /* jmp 0xcc1e */
        l_0x18_cb3b:
            ii(0x18_cb3b, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x18_cb3d, 2); if(jnzw(0x18_cb5d, 0x1e)) goto l_0x18_cb5d; /* jnz 0xcb5d */
            ii(0x18_cb3f, 5); cmp(memb_a16[ds, 0x980], 0x3);            /* cmp byte [0x980], 0x3 */
            ii(0x18_cb44, 2); if(jlw(0x18_cb5d, 0x17)) goto l_0x18_cb5d; /* jl 0xcb5d */
            ii(0x18_cb46, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_cb49, 3); callw(0x18_b058, -0x1af4);                /* call 0xb058 */
            ii(0x18_cb4c, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cb4d, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_cb50, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_cb53, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_cb55, 3); or(ax, memw_a16[ss, bp - 0xa]);           /* or ax, [bp-0xa] */
            ii(0x18_cb58, 2); if(jnzw(0x18_cbd3, 0x79)) goto l_0x18_cbd3; /* jnz 0xcbd3 */
            ii(0x18_cb5a, 3); jmpw(0x18_ccf3, 0x196); goto l_0x18_ccf3; /* jmp 0xccf3 */
        l_0x18_cb5d:
            ii(0x18_cb5d, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x18_cb5f, 2); if(jbew(0x18_cb7c, 0x1b)) goto l_0x18_cb7c; /* jbe 0xcb7c */
            ii(0x18_cb61, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x18_cb63, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x18_cb65, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x18_cb67, 2); sub(ax, di);                              /* sub ax, di */
            ii(0x18_cb69, 2); sbb(dx, cx);                              /* sbb dx, cx */
            ii(0x18_cb6b, 1); pushw(dx);                                /* push dx */
            ii(0x18_cb6c, 1); pushw(ax);                                /* push ax */
            ii(0x18_cb6d, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_cb6f, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x18_cb71, 3); add(ax, memw_a16[ss, bp - 0xe]);          /* add ax, [bp-0xe] */
            ii(0x18_cb74, 3); adc(dx, memw_a16[ss, bp - 0xc]);          /* adc dx, [bp-0xc] */
            ii(0x18_cb77, 1); pushw(dx);                                /* push dx */
            ii(0x18_cb78, 1); pushw(ax);                                /* push ax */
            ii(0x18_cb79, 3); jmpw(0x18_cbfe, 0x82); goto l_0x18_cbfe;  /* jmp 0xcbfe */
        l_0x18_cb7c:
            ii(0x18_cb7c, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x18_cb7e, 2); if(jbw(0x18_cb83, 0x3)) goto l_0x18_cb83; /* jb 0xcb83 */
            ii(0x18_cb80, 3); jmpw(0x18_cc3f, 0xbc); goto l_0x18_cc3f;  /* jmp 0xcc3f */
        l_0x18_cb83:
            ii(0x18_cb83, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_cb85, 1); pushw(di);                                /* push di */
            ii(0x18_cb86, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_cb88, 1); pushw(si);                                /* push si */
            ii(0x18_cb89, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_cb8c, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x18_cb8f, 3); callw(0x18_c29c, -0x8f6);                 /* call 0xc29c */
            ii(0x18_cb92, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x18_cb95, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_cb97, 2); if(jzw(0x18_cb9c, 0x3)) goto l_0x18_cb9c; /* jz 0xcb9c */
            ii(0x18_cb99, 3); jmpw(0x18_cc3f, 0xa3); goto l_0x18_cc3f;  /* jmp 0xcc3f */
        l_0x18_cb9c:
            ii(0x18_cb9c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_cb9e, 1); pushw(di);                                /* push di */
            ii(0x18_cb9f, 3); callw(0x18_bddb, -0xdc7);                 /* call 0xbddb */
            ii(0x18_cba2, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cba3, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cba4, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_cba7, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_cbaa, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x18_cbac, 2); if(jnzw(0x18_cbd3, 0x25)) goto l_0x18_cbd3; /* jnz 0xcbd3 */
            ii(0x18_cbae, 5); cmp(memb_a16[ds, 0x980], 0x2);            /* cmp byte [0x980], 0x2 */
            ii(0x18_cbb3, 2); if(jzw(0x18_cbd0, 0x1b)) goto l_0x18_cbd0; /* jz 0xcbd0 */
            ii(0x18_cbb5, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x18_cbb9, 3); mov(memw_a16[ds, bx + 0x10], di);         /* mov [bx+0x10], di */
            ii(0x18_cbbc, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_cbbf, 3); callw(0x18_b058, -0x1b6a);                /* call 0xb058 */
            ii(0x18_cbc2, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cbc3, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_cbc6, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_cbc9, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_cbcb, 3); or(ax, memw_a16[ss, bp - 0xa]);           /* or ax, [bp-0xa] */
            ii(0x18_cbce, 2); if(jnzw(0x18_cbd3, 0x3)) goto l_0x18_cbd3; /* jnz 0xcbd3 */
        l_0x18_cbd0:
            ii(0x18_cbd0, 3); jmpw(0x18_ccf3, 0x120); goto l_0x18_ccf3; /* jmp 0xccf3 */
        l_0x18_cbd3:
            ii(0x18_cbd3, 2); or(si, si);                               /* or si, si */
            ii(0x18_cbd5, 2); if(jzw(0x18_cc3f, 0x68)) goto l_0x18_cc3f; /* jz 0xcc3f */
            ii(0x18_cbd7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_cbd9, 3); callw(0x18_a5a9, -0x2633);                /* call 0xa5a9 */
            ii(0x18_cbdc, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cbdd, 3); inc(memb_a16[ss, bp - 0x6]);              /* inc byte [bp-0x6] */
            ii(0x18_cbe0, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_cbe3, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x18_cbe6, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x18_cbe9, 3); callw(0x18_d9ca, 0xdde);                  /* call 0xd9ca */
            ii(0x18_cbec, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_cbef, 4); cmp(memw_a16[ss, bp - 0x16], 0x10);       /* cmp word [bp-0x16], 0x10 */
            ii(0x18_cbf3, 2); if(jbw(0x18_cc06, 0x11)) goto l_0x18_cc06; /* jb 0xcc06 */
            ii(0x18_cbf5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_cbf7, 1); pushw(si);                                /* push si */
            ii(0x18_cbf8, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_cbfb, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
        l_0x18_cbfe:
            ii(0x18_cbfe, 3); callw(0x18_c010, -0xbf1);                 /* call 0xc010 */
            ii(0x18_cc01, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_cc04, 2); jmpw(0x18_cc3f, 0x39); goto l_0x18_cc3f;  /* jmp 0xcc3f */
        l_0x18_cc06:
            ii(0x18_cc06, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x18_cc0a, 5); mov(memw_a16[ds, bx + 0x16], 0x4900);     /* mov word [bx+0x16], 0x4900 */
            ii(0x18_cc0f, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x18_cc12, 3); mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x18_cc15, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_cc18, 3); callw(0x18_b0af, -0x1b6c);                /* call 0xb0af */
            ii(0x18_cc1b, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cc1c, 2); jmpw(0x18_cc3f, 0x21); goto l_0x18_cc3f;  /* jmp 0xcc3f */
        l_0x18_cc1e:
            ii(0x18_cc1e, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x18_cc21, 3); callw(0x18_b0d5, -0x1b4f);                /* call 0xb0d5 */
            ii(0x18_cc24, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cc25, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_cc28, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_cc2b, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x18_cc2d, 3); or(ax, memw_a16[ss, bp - 0xa]);           /* or ax, [bp-0xa] */
            ii(0x18_cc30, 2); if(jnzw(0x18_cc3f, 0xd)) goto l_0x18_cc3f; /* jnz 0xcc3f */
            ii(0x18_cc32, 5); cmp(memb_a16[ds, 0x980], 0x3);            /* cmp byte [0x980], 0x3 */
            ii(0x18_cc37, 2); if(jlw(0x18_cc3c, 0x3)) goto l_0x18_cc3c; /* jl 0xcc3c */
            ii(0x18_cc39, 3); jmpw(0x18_ccf3, 0xb7); goto l_0x18_ccf3;  /* jmp 0xccf3 */
        l_0x18_cc3c:
            ii(0x18_cc3c, 3); jmpw(0x18_cb9c, -0xa3); goto l_0x18_cb9c; /* jmp 0xcb9c */
        l_0x18_cc3f:
            ii(0x18_cc3f, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_cc41, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_cc44, 1); dec(ax);                                  /* dec ax */
            ii(0x18_cc45, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x18_cc48, 3); mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x18_cc4b, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x18_cc4e, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x18_cc51, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x18_cc54, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x18_cc57, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_cc5a, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x18_cc5d, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x18_cc60, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_cc63, 3); mov(cx, memw_a16[ss, bp - 0xa]);          /* mov cx, [bp-0xa] */
            ii(0x18_cc66, 3); shr(cx, 0xc);                             /* shr cx, 0xc */
            ii(0x18_cc69, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x18_cc6b, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x18_cc6e, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x18_cc71, 1); pushw(ax);                                /* push ax */
            ii(0x18_cc72, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_cc75, 3); callw(0x18_dc28, 0xfb0);                  /* call 0xdc28 */
            ii(0x18_cc78, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cc79, 1); popw(bx);                                 /* pop bx */
            ii(0x18_cc7a, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x18_cc7d, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x18_cc80, 4); add(bx, memw_a16[ds, 0xaa0]);             /* add bx, [0xaa0] */
            ii(0x18_cc84, 4); mov(es, memw_a16[ds, 0xaa2]);             /* mov es, [0xaa2] */
            ii(0x18_cc88, 4); or(memb_a16[es, bx], 0x1);                /* or byte [es:bx], 0x1 */
            ii(0x18_cc8c, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x18_cc8f, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x18_cc92, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x18_cc94, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_cc97, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x18_cc99, 1); dec(ax);                                  /* dec ax */
            ii(0x18_cc9a, 1); pushw(ax);                                /* push ax */
            ii(0x18_cc9b, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x18_cc9e, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x18_cca1, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_cca4, 3); mov(memw_a16[ss, bp - 0x1a], cx);         /* mov [bp-0x1a], cx */
            ii(0x18_cca7, 3); callw(0x18_d585, 0x8db);                  /* call 0xd585 */
            ii(0x18_ccaa, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x18_ccad, 2); cmp(si, di);                              /* cmp si, di */
            ii(0x18_ccaf, 2); if(jaew(0x18_ccdb, 0x2a)) goto l_0x18_ccdb; /* jae 0xccdb */
            ii(0x18_ccb1, 3); mov(al, memb_a16[ds, 0x14]);              /* mov al, [0x14] */
            ii(0x18_ccb4, 3); and(ax, 0x60);                            /* and ax, 0x60 */
            ii(0x18_ccb7, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_ccba, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x18_ccbc, 2); if(jzw(0x18_ccdb, 0x1d)) goto l_0x18_ccdb; /* jz 0xccdb */
            ii(0x18_ccbe, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x18_ccc1, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x18_ccc4, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x18_ccc6, 1); pushw(ax);                                /* push ax */
            ii(0x18_ccc7, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_ccc9, 2); sub(ax, si);                              /* sub ax, si */
            ii(0x18_cccb, 3); shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x18_ccce, 1); pushw(ax);                                /* push ax */
            ii(0x18_cccf, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x18_ccd2, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x18_ccd5, 3); callw(0x18_dad3, 0xdfb);                  /* call 0xdad3 */
            ii(0x18_ccd8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x18_ccdb:
            ii(0x18_ccdb, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x18_ccde, 5); and(memb_a16[es, bx + 0x26], -0x2 /* 0xfe */); /* and byte [es:bx+0x26], 0xfe */
            ii(0x18_cce3, 4); mov(memw_a16[es, bx + 0x10], di);         /* mov [es:bx+0x10], di */
            ii(0x18_cce7, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x18_cceb, 2); if(jzw(0x18_ccf3, 0x6)) goto l_0x18_ccf3; /* jz 0xccf3 */
            ii(0x18_cced, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x18_ccef, 3); callw(0x18_a5a9, -0x2749);                /* call 0xa5a9 */
            ii(0x18_ccf2, 1); popw(bx);                                 /* pop bx */
        l_0x18_ccf3:
            ii(0x18_ccf3, 1); popw(si);                                 /* pop si */
            ii(0x18_ccf4, 1); popw(di);                                 /* pop di */
            ii(0x18_ccf5, 1); leavew();                                 /* leave */
            ii(0x18_ccf6, 1); retw();                                   /* ret */
        }
    }
}
