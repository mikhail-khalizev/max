using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9990c8c-9275-40ad-b3e7-d256455e744a")]
        public void Method_0015_bbb4()
        {
            ii(0x15_bbb4, 4); enterw(0x36, 0);                          /* enter 0x36, 0x0 */
            ii(0x15_bbb8, 1); pushw(si);                                /* push si */
            ii(0x15_bbb9, 3); mov(ax, memw_a16[ss, bp + 0x12]);         /* mov ax, [bp+0x12] */
            ii(0x15_bbbc, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
        l_0x15_bbbf:
            ii(0x15_bbbf, 3); mov(ax, memw_a16[ss, bp + 0xe]);          /* mov ax, [bp+0xe] */
            ii(0x15_bbc2, 3); or(ax, memw_a16[ss, bp + 0xc]);           /* or ax, [bp+0xc] */
            ii(0x15_bbc5, 2); if(jnzw(0x15_bbca, 0x3)) goto l_0x15_bbca; /* jnz 0xbbca */
            ii(0x15_bbc7, 3); jmpw(0x15_c1ed, 0x623); goto l_0x15_c1ed; /* jmp 0xc1ed */
        l_0x15_bbca:
            ii(0x15_bbca, 5); mov(memw_a16[ss, bp - 0x28], 0);          /* mov word [bp-0x28], 0x0 */
            ii(0x15_bbcf, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_bbd1, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x15_bbd4, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_bbd7, 3); mov(ax, memw_a16[ss, bp + 0x10]);         /* mov ax, [bp+0x10] */
            ii(0x15_bbda, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_bbdd, 3); les(bx, ss, bp - 0x10);                   /* les bx, [bp-0x10] */
            ii(0x15_bbe0, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_bbe3, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x15_bbe5, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x15_bbe8, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_bbeb, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x15_bbed, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x15_bbf0, 3); cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0x15_bbf3, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x15_bbf5, 1); inc(cx);                                  /* inc cx */
            ii(0x15_bbf6, 3); mov(memw_a16[ss, bp - 0x32], cx);         /* mov [bp-0x32], cx */
            ii(0x15_bbf9, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x15_bbfc, 4); mov(cl, memb_a16[es, bx + 0x1]);          /* mov cl, [es:bx+0x1] */
            ii(0x15_bc00, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x15_bc02, 3); and(cx, 0x4);                             /* and cx, 0x4 */
            ii(0x15_bc05, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_bc08, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
            ii(0x15_bc0d, 3); and(dl, 0x10);                            /* and dl, 0x10 */
            ii(0x15_bc10, 3); mov(memb_a16[ss, bp - 0x2], dl);          /* mov [bp-0x2], dl */
            ii(0x15_bc13, 3); mov(memw_a16[ss, bp - 0x36], bx);         /* mov [bp-0x36], bx */
            ii(0x15_bc16, 3); cmp(ax, 0x2);                             /* cmp ax, 0x2 */
            ii(0x15_bc19, 2); if(jnzw(0x15_bc1f, 0x4)) goto l_0x15_bc1f; /* jnz 0xbc1f */
            ii(0x15_bc1b, 2); mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x15_bc1d, 2); jmpw(0x15_bc21, 0x2); goto l_0x15_bc21;   /* jmp 0xbc21 */
        l_0x15_bc1f:
            ii(0x15_bc1f, 2); sub(al, al);                              /* sub al, al */
        l_0x15_bc21:
            ii(0x15_bc21, 3); mov(memb_a16[ss, bp - 0x6], al);          /* mov [bp-0x6], al */
            ii(0x15_bc24, 3); mov(al, memb_a16[ss, bp - 0x36]);         /* mov al, [bp-0x36] */
            ii(0x15_bc27, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bc29, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x15_bc2c, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_bc2e, 3); mov(memw_a16[ss, bp - 0x1c], cx);         /* mov [bp-0x1c], cx */
            ii(0x15_bc31, 3); mov(memw_a16[ss, bp - 0x1e], cx);         /* mov [bp-0x1e], cx */
            ii(0x15_bc34, 3); and(ax, 0x3);                             /* and ax, 0x3 */
            ii(0x15_bc37, 2); if(jzw(0x15_bc6f, 0x36)) goto l_0x15_bc6f; /* jz 0xbc6f */
            ii(0x15_bc39, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_bc3c, 2); if(jbw(0x15_bc4c, 0xe)) goto l_0x15_bc4c; /* jb 0xbc4c */
            ii(0x15_bc3e, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x15_bc41, 2); if(jaw(0x15_bc46, 0x3)) goto l_0x15_bc46; /* ja 0xbc46 */
            ii(0x15_bc43, 3); jmpw(0x15_bded, 0x1a7); goto l_0x15_bded; /* jmp 0xbded */
        l_0x15_bc46:
            ii(0x15_bc46, 1); dec(ax);                                  /* dec ax */
            ii(0x15_bc47, 2); if(jnzw(0x15_bc4c, 0x3)) goto l_0x15_bc4c; /* jnz 0xbc4c */
            ii(0x15_bc49, 3); jmpw(0x15_c07c, 0x430); goto l_0x15_c07c; /* jmp 0xc07c */
        l_0x15_bc4c:
            ii(0x15_bc4c, 1); pushw(ds);                                /* push ds */
            ii(0x15_bc4d, 3); pushw(0x213e);                            /* push 0x213e */
            ii(0x15_bc50, 3); pushw(0xce8);                             /* push 0xce8 */
            ii(0x15_bc53, 3); callw(0x16_1056, 0x5400);                 /* call 0x1056 */
            ii(0x15_bc56, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_bc59, 5); mov(memw_a16[ss, bp - 0x28], 0);          /* mov word [bp-0x28], 0x0 */
            ii(0x15_bc5e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_bc60, 3); mov(memw_a16[ss, bp - 0x24], ax);         /* mov [bp-0x24], ax */
            ii(0x15_bc63, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_bc66, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_bc69, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bc6c, 3); jmpw(0x15_bddf, 0x170); goto l_0x15_bddf; /* jmp 0xbddf */
        l_0x15_bc6f:
            ii(0x15_bc6f, 4); test(memb_a16[ss, bp - 0x34], 0x40);      /* test byte [bp-0x34], 0x40 */
            ii(0x15_bc73, 2); if(jnzw(0x15_bc78, 0x3)) goto l_0x15_bc78; /* jnz 0xbc78 */
            ii(0x15_bc75, 3); jmpw(0x15_bd26, 0xae); goto l_0x15_bd26;  /* jmp 0xbd26 */
        l_0x15_bc78:
            ii(0x15_bc78, 3); cmp(memw_a16[ss, bp - 0x32], cx);         /* cmp [bp-0x32], cx */
            ii(0x15_bc7b, 2); if(jzw(0x15_bcd3, 0x56)) goto l_0x15_bcd3; /* jz 0xbcd3 */
            ii(0x15_bc7d, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bc80, 4); mov(ax, memw_a16[es, bx + 0x3]);          /* mov ax, [es:bx+0x3] */
            ii(0x15_bc84, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_bc87, 4); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_bc8b, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bc8d, 1); dec(ax);                                  /* dec ax */
            ii(0x15_bc8e, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_bc91, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x15_bc95, 2); if(jzw(0x15_bcab, 0x14)) goto l_0x15_bcab; /* jz 0xbcab */
            ii(0x15_bc97, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_bc99, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_bc9c, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bc9f, 3); lea(ax, bx + 0x5);                        /* lea ax, [bx+0x5] */
        l_0x15_bca2:
            ii(0x15_bca2, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bca5, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_bca8, 3); jmpw(0x15_bdc4, 0x119); goto l_0x15_bdc4; /* jmp 0xbdc4 */
        l_0x15_bcab:
            ii(0x15_bcab, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bcaf, 2); if(jzw(0x15_bcc4, 0x13)) goto l_0x15_bcc4; /* jz 0xbcc4 */
            ii(0x15_bcb1, 4); mov(ax, memw_a16[es, bx + 0x5]);          /* mov ax, [es:bx+0x5] */
            ii(0x15_bcb5, 4); mov(dx, memw_a16[es, bx + 0x7]);          /* mov dx, [es:bx+0x7] */
            ii(0x15_bcb9, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bcbc, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x15_bcbf, 3); lea(ax, bx + 0x9);                        /* lea ax, [bx+0x9] */
            ii(0x15_bcc2, 2); jmpw(0x15_bca2, -0x22); goto l_0x15_bca2; /* jmp 0xbca2 */
        l_0x15_bcc4:
            ii(0x15_bcc4, 4); mov(ax, memw_a16[es, bx + 0x5]);          /* mov ax, [es:bx+0x5] */
            ii(0x15_bcc8, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bccb, 3); mov(memw_a16[ss, bp - 0x18], cx);         /* mov [bp-0x18], cx */
            ii(0x15_bcce, 3); lea(ax, bx + 0x7);                        /* lea ax, [bx+0x7] */
            ii(0x15_bcd1, 2); jmpw(0x15_bca2, -0x31); goto l_0x15_bca2; /* jmp 0xbca2 */
        l_0x15_bcd3:
            ii(0x15_bcd3, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bcd6, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_bcda, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_bcdd, 3); lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x15_bce0, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bce3, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_bce6, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x15_bcea, 2); if(jzw(0x15_bcf7, 0xb)) goto l_0x15_bcf7; /* jz 0xbcf7 */
        l_0x15_bcec:
            ii(0x15_bcec, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_bcee, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_bcf1, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bcf4, 3); jmpw(0x15_bdc4, 0xcd); goto l_0x15_bdc4;  /* jmp 0xbdc4 */
        l_0x15_bcf7:
            ii(0x15_bcf7, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_bcfa, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_bcfc, 3); add(ax, 0x6);                             /* add ax, 0x6 */
            ii(0x15_bcff, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bd02, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x15_bd05, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bd09, 2); if(jnzw(0x15_bd0e, 0x3)) goto l_0x15_bd0e; /* jnz 0xbd0e */
            ii(0x15_bd0b, 3); jmpw(0x15_bdb2, 0xa4); goto l_0x15_bdb2;  /* jmp 0xbdb2 */
        l_0x15_bd0e:
            ii(0x15_bd0e, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_bd10, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_bd13, 4); mov(si, memw_a16[es, bx + 0x2]);          /* mov si, [es:bx+0x2] */
            ii(0x15_bd17, 3); mov(memw_a16[ss, bp - 0x1a], cx);         /* mov [bp-0x1a], cx */
            ii(0x15_bd1a, 3); mov(memw_a16[ss, bp - 0x18], si);         /* mov [bp-0x18], si */
            ii(0x15_bd1d, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_bd20, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bd23, 3); jmpw(0x15_bdc4, 0x9e); goto l_0x15_bdc4;  /* jmp 0xbdc4 */
        l_0x15_bd26:
            ii(0x15_bd26, 3); cmp(memw_a16[ss, bp - 0x32], cx);         /* cmp [bp-0x32], cx */
            ii(0x15_bd29, 2); if(jzw(0x15_bd7d, 0x52)) goto l_0x15_bd7d; /* jz 0xbd7d */
            ii(0x15_bd2b, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bd2e, 4); mov(al, memb_a16[es, bx + 0x3]);          /* mov al, [es:bx+0x3] */
            ii(0x15_bd32, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bd34, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_bd37, 4); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_bd3b, 1); dec(ax);                                  /* dec ax */
            ii(0x15_bd3c, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_bd3f, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x15_bd43, 2); if(jzw(0x15_bd53, 0xe)) goto l_0x15_bd53; /* jz 0xbd53 */
            ii(0x15_bd45, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_bd47, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_bd4a, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bd4d, 3); lea(ax, bx + 0x4);                        /* lea ax, [bx+0x4] */
            ii(0x15_bd50, 3); jmpw(0x15_bca2, -0xb1); goto l_0x15_bca2; /* jmp 0xbca2 */
        l_0x15_bd53:
            ii(0x15_bd53, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bd57, 2); if(jzw(0x15_bd6d, 0x14)) goto l_0x15_bd6d; /* jz 0xbd6d */
            ii(0x15_bd59, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_bd5d, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_bd61, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bd64, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x15_bd67, 3); lea(ax, bx + 0x8);                        /* lea ax, [bx+0x8] */
            ii(0x15_bd6a, 3); jmpw(0x15_bca2, -0xcb); goto l_0x15_bca2; /* jmp 0xbca2 */
        l_0x15_bd6d:
            ii(0x15_bd6d, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_bd71, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bd74, 3); mov(memw_a16[ss, bp - 0x18], cx);         /* mov [bp-0x18], cx */
            ii(0x15_bd77, 3); lea(ax, bx + 0x6);                        /* lea ax, [bx+0x6] */
            ii(0x15_bd7a, 3); jmpw(0x15_bca2, -0xdb); goto l_0x15_bca2; /* jmp 0xbca2 */
        l_0x15_bd7d:
            ii(0x15_bd7d, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bd80, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x15_bd84, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bd86, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_bd89, 3); lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x15_bd8c, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bd8f, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_bd92, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x15_bd96, 2); if(jzw(0x15_bd9b, 0x3)) goto l_0x15_bd9b; /* jz 0xbd9b */
            ii(0x15_bd98, 3); jmpw(0x15_bcec, -0xaf); goto l_0x15_bcec; /* jmp 0xbcec */
        l_0x15_bd9b:
            ii(0x15_bd9b, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_bd9e, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_bda0, 3); add(ax, 0x5);                             /* add ax, 0x5 */
            ii(0x15_bda3, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bda6, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x15_bda9, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bdad, 2); if(jzw(0x15_bdb2, 0x3)) goto l_0x15_bdb2; /* jz 0xbdb2 */
            ii(0x15_bdaf, 3); jmpw(0x15_bd0e, -0xa4); goto l_0x15_bd0e; /* jmp 0xbd0e */
        l_0x15_bdb2:
            ii(0x15_bdb2, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_bdb5, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
            ii(0x15_bdb9, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_bdbc, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_bdbf, 5); mov(memw_a16[ss, bp - 0x18], 0);          /* mov word [bp-0x18], 0x0 */
        l_0x15_bdc4:
            ii(0x15_bdc4, 3); pushw(memw_a16[ss, bp + 0x16]);           /* push word [bp+0x16] */
            ii(0x15_bdc7, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_bdca, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x15_bdcd, 3); pushw(memw_a16[ss, bp - 0x18]);           /* push word [bp-0x18] */
            ii(0x15_bdd0, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x15_bdd3, 3); lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x15_bdd6, 1); pushw(ss);                                /* push ss */
            ii(0x15_bdd7, 1); pushw(ax);                                /* push ax */
            ii(0x15_bdd8, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x15_bddb, 1); pushw(ax);                                /* push ax */
            ii(0x15_bddc, 3); callw(0x15_d0ec, 0x130d);                 /* call 0xd0ec */
        l_0x15_bddf:
            ii(0x15_bddf, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x15_bde2, 3); or(ax, memw_a16[ss, bp - 0xc]);           /* or ax, [bp-0xc] */
            ii(0x15_bde5, 2); if(jzw(0x15_bdea, 0x3)) goto l_0x15_bdea; /* jz 0xbdea */
            ii(0x15_bde7, 3); jmpw(0x15_c153, 0x369); goto l_0x15_c153; /* jmp 0xc153 */
        l_0x15_bdea:
            ii(0x15_bdea, 3); jmpw(0x15_c1ed, 0x400); goto l_0x15_c1ed; /* jmp 0xc1ed */
        l_0x15_bded:
            ii(0x15_bded, 4); test(memb_a16[ss, bp - 0x34], 0x40);      /* test byte [bp-0x34], 0x40 */
            ii(0x15_bdf1, 2); if(jnzw(0x15_bdf6, 0x3)) goto l_0x15_bdf6; /* jnz 0xbdf6 */
            ii(0x15_bdf3, 3); jmpw(0x15_befa, 0x104); goto l_0x15_befa; /* jmp 0xbefa */
        l_0x15_bdf6:
            ii(0x15_bdf6, 3); cmp(memw_a16[ss, bp - 0x32], cx);         /* cmp [bp-0x32], cx */
            ii(0x15_bdf9, 2); if(jnzw(0x15_bdfe, 0x3)) goto l_0x15_bdfe; /* jnz 0xbdfe */
            ii(0x15_bdfb, 3); jmpw(0x15_be84, 0x86); goto l_0x15_be84;  /* jmp 0xbe84 */
        l_0x15_bdfe:
            ii(0x15_bdfe, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_be01, 4); mov(ax, memw_a16[es, bx + 0x3]);          /* mov ax, [es:bx+0x3] */
            ii(0x15_be05, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_be08, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x15_be0b, 4); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_be0f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_be11, 1); dec(ax);                                  /* dec ax */
            ii(0x15_be12, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_be15, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_be19, 2); if(jzw(0x15_be55, 0x3a)) goto l_0x15_be55; /* jz 0xbe55 */
            ii(0x15_be1b, 4); mov(ax, memw_a16[es, bx + 0x5]);          /* mov ax, [es:bx+0x5] */
            ii(0x15_be1f, 4); mov(dx, memw_a16[es, bx + 0x7]);          /* mov dx, [es:bx+0x7] */
            ii(0x15_be23, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_be26, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_be29, 3); lea(ax, bx + 0x9);                        /* lea ax, [bx+0x9] */
            ii(0x15_be2c, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_be2f, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_be32, 3); mov(cx, memw_a16[ss, bp - 0x2a]);         /* mov cx, [bp-0x2a] */
            ii(0x15_be35, 3); or(cx, memw_a16[ss, bp - 0x2c]);          /* or cx, [bp-0x2c] */
            ii(0x15_be38, 2); if(jnzw(0x15_be3d, 0x3)) goto l_0x15_be3d; /* jnz 0xbe3d */
            ii(0x15_be3a, 3); jmpw(0x15_c01e, 0x1e1); goto l_0x15_c01e; /* jmp 0xc01e */
        l_0x15_be3d:
            ii(0x15_be3d, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_be3f, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_be42, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_be46, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_be49, 3); mov(memw_a16[ss, bp - 0x2a], dx);         /* mov [bp-0x2a], dx */
            ii(0x15_be4c, 3); add(ax, 0x4);                             /* add ax, 0x4 */
        l_0x15_be4f:
            ii(0x15_be4f, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_be52, 3); jmpw(0x15_c01e, 0x1c9); goto l_0x15_c01e; /* jmp 0xc01e */
        l_0x15_be55:
            ii(0x15_be55, 4); mov(ax, memw_a16[es, bx + 0x5]);          /* mov ax, [es:bx+0x5] */
            ii(0x15_be59, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_be5c, 3); mov(memw_a16[ss, bp - 0x2e], cx);         /* mov [bp-0x2e], cx */
            ii(0x15_be5f, 3); lea(ax, bx + 0x7);                        /* lea ax, [bx+0x7] */
            ii(0x15_be62, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_be65, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_be68, 3); mov(cx, memw_a16[ss, bp - 0x2a]);         /* mov cx, [bp-0x2a] */
            ii(0x15_be6b, 3); or(cx, memw_a16[ss, bp - 0x2c]);          /* or cx, [bp-0x2c] */
            ii(0x15_be6e, 2); if(jnzw(0x15_be73, 0x3)) goto l_0x15_be73; /* jnz 0xbe73 */
            ii(0x15_be70, 3); jmpw(0x15_c01e, 0x1ab); goto l_0x15_c01e; /* jmp 0xc01e */
        l_0x15_be73:
            ii(0x15_be73, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_be75, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_be78, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_be7b, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
            ii(0x15_be80, 1); inc(ax);                                  /* inc ax */
            ii(0x15_be81, 1); inc(ax);                                  /* inc ax */
            ii(0x15_be82, 2); jmpw(0x15_be4f, -0x35); goto l_0x15_be4f; /* jmp 0xbe4f */
        l_0x15_be84:
            ii(0x15_be84, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_be87, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_be8b, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_be8e, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x15_be91, 3); lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x15_be94, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_be97, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_be9a, 3); lea(ax, bx + 0x6);                        /* lea ax, [bx+0x6] */
            ii(0x15_be9d, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bea0, 3); mov(memw_a16[ss, bp - 0x1c], es);         /* mov [bp-0x1c], es */
            ii(0x15_bea3, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bea7, 2); if(jzw(0x15_bec0, 0x17)) goto l_0x15_bec0; /* jz 0xbec0 */
            ii(0x15_bea9, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_beab, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_beae, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_beb2, 3); mov(memw_a16[ss, bp - 0x30], cx);         /* mov [bp-0x30], cx */
            ii(0x15_beb5, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_beb8, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_bebb, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bebe, 2); jmpw(0x15_bed2, 0x12); goto l_0x15_bed2;  /* jmp 0xbed2 */
        l_0x15_bec0:
            ii(0x15_bec0, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_bec3, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
            ii(0x15_bec7, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_beca, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_becd, 5); mov(memw_a16[ss, bp - 0x2e], 0);          /* mov word [bp-0x2e], 0x0 */
        l_0x15_bed2:
            ii(0x15_bed2, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_bed5, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_bed8, 2); if(jzw(0x15_bee0, 0x6)) goto l_0x15_bee0; /* jz 0xbee0 */
            ii(0x15_beda, 4); test(memb_a16[ss, bp - 0x34], 0x20);      /* test byte [bp-0x34], 0x20 */
            ii(0x15_bede, 2); if(jnzw(0x15_bee3, 0x3)) goto l_0x15_bee3; /* jnz 0xbee3 */
        l_0x15_bee0:
            ii(0x15_bee0, 3); jmpw(0x15_c004, 0x121); goto l_0x15_c004; /* jmp 0xc004 */
        l_0x15_bee3:
            ii(0x15_bee3, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_bee6, 4); add(memw_a16[ss, bp - 0x1e], 0x4);        /* add word [bp-0x1e], 0x4 */
        l_0x15_beea:
            ii(0x15_beea, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_beed, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_bef1, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_bef4, 3); mov(memw_a16[ss, bp - 0x2a], dx);         /* mov [bp-0x2a], dx */
            ii(0x15_bef7, 3); jmpw(0x15_c01e, 0x124); goto l_0x15_c01e; /* jmp 0xc01e */
        l_0x15_befa:
            ii(0x15_befa, 3); cmp(memw_a16[ss, bp - 0x32], cx);         /* cmp [bp-0x32], cx */
            ii(0x15_befd, 2); if(jnzw(0x15_bf02, 0x3)) goto l_0x15_bf02; /* jnz 0xbf02 */
            ii(0x15_beff, 3); jmpw(0x15_bf89, 0x87); goto l_0x15_bf89;  /* jmp 0xbf89 */
        l_0x15_bf02:
            ii(0x15_bf02, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bf05, 4); mov(al, memb_a16[es, bx + 0x3]);          /* mov al, [es:bx+0x3] */
            ii(0x15_bf09, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bf0b, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_bf0e, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x15_bf11, 4); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_bf15, 1); dec(ax);                                  /* dec ax */
            ii(0x15_bf16, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_bf19, 4); test(memb_a16[ss, bp - 0x34], 0x80);      /* test byte [bp-0x34], 0x80 */
            ii(0x15_bf1d, 2); if(jzw(0x15_bf30, 0x11)) goto l_0x15_bf30; /* jz 0xbf30 */
            ii(0x15_bf1f, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x15_bf23, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bf25, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_bf28, 3); mov(memw_a16[ss, bp - 0x2e], cx);         /* mov [bp-0x2e], cx */
            ii(0x15_bf2b, 3); lea(ax, bx + 0x5);                        /* lea ax, [bx+0x5] */
            ii(0x15_bf2e, 2); jmpw(0x15_bf56, 0x26); goto l_0x15_bf56;  /* jmp 0xbf56 */
        l_0x15_bf30:
            ii(0x15_bf30, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bf34, 2); if(jzw(0x15_bf49, 0x13)) goto l_0x15_bf49; /* jz 0xbf49 */
            ii(0x15_bf36, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_bf3a, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_bf3e, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_bf41, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_bf44, 3); lea(ax, bx + 0x8);                        /* lea ax, [bx+0x8] */
            ii(0x15_bf47, 2); jmpw(0x15_bf56, 0xd); goto l_0x15_bf56;   /* jmp 0xbf56 */
        l_0x15_bf49:
            ii(0x15_bf49, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_bf4d, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_bf50, 3); mov(memw_a16[ss, bp - 0x2e], cx);         /* mov [bp-0x2e], cx */
            ii(0x15_bf53, 3); lea(ax, bx + 0x6);                        /* lea ax, [bx+0x6] */
        l_0x15_bf56:
            ii(0x15_bf56, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bf59, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_bf5c, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_bf5f, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_bf62, 2); if(jzw(0x15_bf74, 0x10)) goto l_0x15_bf74; /* jz 0xbf74 */
            ii(0x15_bf64, 4); test(memb_a16[ss, bp - 0x34], 0x20);      /* test byte [bp-0x34], 0x20 */
            ii(0x15_bf68, 2); if(jzw(0x15_bf74, 0xa)) goto l_0x15_bf74; /* jz 0xbf74 */
            ii(0x15_bf6a, 3); mov(bx, memw_a16[ss, bp - 0xc]);          /* mov bx, [bp-0xc] */
            ii(0x15_bf6d, 4); add(memw_a16[ss, bp - 0xc], 0x4);         /* add word [bp-0xc], 0x4 */
            ii(0x15_bf71, 3); jmpw(0x15_beea, -0x8a); goto l_0x15_beea; /* jmp 0xbeea */
        l_0x15_bf74:
            ii(0x15_bf74, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_bf77, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_bf7a, 2); if(jnzw(0x15_bf7f, 0x3)) goto l_0x15_bf7f; /* jnz 0xbf7f */
            ii(0x15_bf7c, 3); jmpw(0x15_c01e, 0x9f); goto l_0x15_c01e;  /* jmp 0xc01e */
        l_0x15_bf7f:
            ii(0x15_bf7f, 3); les(bx, ss, bp - 0xc);                    /* les bx, [bp-0xc] */
            ii(0x15_bf82, 4); add(memw_a16[ss, bp - 0xc], 0x2);         /* add word [bp-0xc], 0x2 */
            ii(0x15_bf86, 3); jmpw(0x15_c013, 0x8a); goto l_0x15_c013;  /* jmp 0xc013 */
        l_0x15_bf89:
            ii(0x15_bf89, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_bf8c, 4); mov(al, memb_a16[es, bx + 0x4]);          /* mov al, [es:bx+0x4] */
            ii(0x15_bf90, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_bf92, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x15_bf95, 3); mov(memw_a16[ss, bp - 0x12], cx);         /* mov [bp-0x12], cx */
            ii(0x15_bf98, 3); lea(ax, bx + 0x2);                        /* lea ax, [bx+0x2] */
            ii(0x15_bf9b, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_bf9e, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_bfa1, 3); lea(ax, bx + 0x5);                        /* lea ax, [bx+0x5] */
            ii(0x15_bfa4, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bfa7, 3); mov(memw_a16[ss, bp - 0x1c], es);         /* mov [bp-0x1c], es */
            ii(0x15_bfaa, 4); test(memb_a16[ss, bp - 0x34], 0x80);      /* test byte [bp-0x34], 0x80 */
            ii(0x15_bfae, 2); if(jzw(0x15_bfc5, 0x15)) goto l_0x15_bfc5; /* jz 0xbfc5 */
            ii(0x15_bfb0, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_bfb2, 3); mov(cl, memb_a16[es, bx]);                /* mov cl, [es:bx] */
            ii(0x15_bfb5, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x15_bfb7, 3); mov(memw_a16[ss, bp - 0x30], cx);         /* mov [bp-0x30], cx */
            ii(0x15_bfba, 5); mov(memw_a16[ss, bp - 0x2e], 0);          /* mov word [bp-0x2e], 0x0 */
            ii(0x15_bfbf, 1); inc(ax);                                  /* inc ax */
            ii(0x15_bfc0, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_bfc3, 2); jmpw(0x15_bff3, 0x2e); goto l_0x15_bff3;  /* jmp 0xbff3 */
        l_0x15_bfc5:
            ii(0x15_bfc5, 4); test(memb_a16[ss, bp - 0x34], 0x10);      /* test byte [bp-0x34], 0x10 */
            ii(0x15_bfc9, 2); if(jzw(0x15_bfe1, 0x16)) goto l_0x15_bfe1; /* jz 0xbfe1 */
            ii(0x15_bfcb, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_bfce, 4); add(memw_a16[ss, bp - 0x1e], 0x4);        /* add word [bp-0x1e], 0x4 */
            ii(0x15_bfd2, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_bfd5, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_bfd9, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_bfdc, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
            ii(0x15_bfdf, 2); jmpw(0x15_bff3, 0x12); goto l_0x15_bff3;  /* jmp 0xbff3 */
        l_0x15_bfe1:
            ii(0x15_bfe1, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_bfe4, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
            ii(0x15_bfe8, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_bfeb, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_bfee, 5); mov(memw_a16[ss, bp - 0x2e], 0);          /* mov word [bp-0x2e], 0x0 */
        l_0x15_bff3:
            ii(0x15_bff3, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_bff6, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_bff9, 2); if(jzw(0x15_c004, 0x9)) goto l_0x15_c004; /* jz 0xc004 */
            ii(0x15_bffb, 4); test(memb_a16[ss, bp - 0x34], 0x20);      /* test byte [bp-0x34], 0x20 */
            ii(0x15_bfff, 2); if(jzw(0x15_c004, 0x3)) goto l_0x15_c004; /* jz 0xc004 */
            ii(0x15_c001, 3); jmpw(0x15_bee3, -0x121); goto l_0x15_bee3; /* jmp 0xbee3 */
        l_0x15_c004:
            ii(0x15_c004, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_c007, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_c00a, 2); if(jzw(0x15_c01e, 0x12)) goto l_0x15_c01e; /* jz 0xc01e */
            ii(0x15_c00c, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_c00f, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
        l_0x15_c013:
            ii(0x15_c013, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_c016, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_c019, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
        l_0x15_c01e:
            ii(0x15_c01e, 4); test(memb_a16[ss, bp - 0x34], 0x80);      /* test byte [bp-0x34], 0x80 */
            ii(0x15_c022, 2); if(jzw(0x15_c031, 0xd)) goto l_0x15_c031; /* jz 0xc031 */
            ii(0x15_c024, 3); mov(al, memb_a16[ss, bp - 0x30]);         /* mov al, [bp-0x30] */
            ii(0x15_c027, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_c029, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_c02c, 5); mov(memw_a16[ss, bp - 0x2e], 0);          /* mov word [bp-0x2e], 0x0 */
        l_0x15_c031:
            ii(0x15_c031, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_c034, 2); and(al, 0x3);                             /* and al, 0x3 */
            ii(0x15_c036, 2); cmp(al, 0x1);                             /* cmp al, 0x1 */
            ii(0x15_c038, 2); if(jnzw(0x15_c05b, 0x21)) goto l_0x15_c05b; /* jnz 0xc05b */
            ii(0x15_c03a, 3); pushw(memw_a16[ss, bp + 0x16]);           /* push word [bp+0x16] */
            ii(0x15_c03d, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_c040, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x15_c043, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_c046, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_c049, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_c04c, 3); lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x15_c04f, 1); pushw(ss);                                /* push ss */
            ii(0x15_c050, 1); pushw(ax);                                /* push ax */
            ii(0x15_c051, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x15_c054, 1); pushw(ax);                                /* push ax */
            ii(0x15_c055, 3); callw(0x15_d3d8, 0x1380);                 /* call 0xd3d8 */
            ii(0x15_c058, 3); jmpw(0x15_bddf, -0x27c); goto l_0x15_bddf; /* jmp 0xbddf */
        l_0x15_c05b:
            ii(0x15_c05b, 3); pushw(memw_a16[ss, bp + 0x16]);           /* push word [bp+0x16] */
            ii(0x15_c05e, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_c061, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x15_c064, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x15_c067, 3); pushw(memw_a16[ss, bp - 0x2e]);           /* push word [bp-0x2e] */
            ii(0x15_c06a, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_c06d, 3); lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x15_c070, 1); pushw(ss);                                /* push ss */
            ii(0x15_c071, 1); pushw(ax);                                /* push ax */
            ii(0x15_c072, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x15_c075, 1); pushw(ax);                                /* push ax */
            ii(0x15_c076, 3); callw(0x15_d295, 0x121c);                 /* call 0xd295 */
            ii(0x15_c079, 3); jmpw(0x15_bddf, -0x29d); goto l_0x15_bddf; /* jmp 0xbddf */
        l_0x15_c07c:
            ii(0x15_c07c, 3); cmp(memw_a16[ss, bp - 0x32], cx);         /* cmp [bp-0x32], cx */
            ii(0x15_c07f, 2); if(jzw(0x15_c0d4, 0x53)) goto l_0x15_c0d4; /* jz 0xc0d4 */
            ii(0x15_c081, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_c084, 4); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_c088, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_c08a, 1); dec(ax);                                  /* dec ax */
            ii(0x15_c08b, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x15_c08e, 4); mov(al, memb_a16[es, bx + 0x3]);          /* mov al, [es:bx+0x3] */
            ii(0x15_c092, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_c094, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x15_c097, 3); mov(memw_a16[ss, bp - 0x2e], cx);         /* mov [bp-0x2e], cx */
            ii(0x15_c09a, 3); lea(ax, bx + 0x4);                        /* lea ax, [bx+0x4] */
            ii(0x15_c09d, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_c0a0, 3); mov(memw_a16[ss, bp - 0xa], es);          /* mov [bp-0xa], es */
            ii(0x15_c0a3, 3); mov(cx, memw_a16[ss, bp - 0x2a]);         /* mov cx, [bp-0x2a] */
            ii(0x15_c0a6, 3); or(cx, memw_a16[ss, bp - 0x2c]);          /* or cx, [bp-0x2c] */
            ii(0x15_c0a9, 2); if(jnzw(0x15_c0ae, 0x3)) goto l_0x15_c0ae; /* jnz 0xc0ae */
            ii(0x15_c0ab, 3); jmpw(0x15_c13f, 0x91); goto l_0x15_c13f;  /* jmp 0xc13f */
        l_0x15_c0ae:
            ii(0x15_c0ae, 4); test(memb_a16[ss, bp - 0x34], 0x20);      /* test byte [bp-0x34], 0x20 */
            ii(0x15_c0b2, 2); if(jzw(0x15_c0cb, 0x17)) goto l_0x15_c0cb; /* jz 0xc0cb */
            ii(0x15_c0b4, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_c0b6, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_c0b9, 4); mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x15_c0bd, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_c0c0, 3); mov(memw_a16[ss, bp - 0x2a], dx);         /* mov [bp-0x2a], dx */
            ii(0x15_c0c3, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_c0c6, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_c0c9, 2); jmpw(0x15_c13f, 0x74); goto l_0x15_c13f;  /* jmp 0xc13f */
        l_0x15_c0cb:
            ii(0x15_c0cb, 3); les(bx, ss, bp - 0xc);                    /* les bx, [bp-0xc] */
            ii(0x15_c0ce, 4); add(memw_a16[ss, bp - 0xc], 0x2);         /* add word [bp-0xc], 0x2 */
            ii(0x15_c0d2, 2); jmpw(0x15_c134, 0x60); goto l_0x15_c134;  /* jmp 0xc134 */
        l_0x15_c0d4:
            ii(0x15_c0d4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_c0d7, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x15_c0d9, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c0da, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c0db, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_c0de, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x15_c0e1, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_c0e4, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_c0e7, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_c0ea, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x15_c0ed, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_c0ef, 3); mov(cl, memb_a16[es, bx]);                /* mov cl, [es:bx] */
            ii(0x15_c0f2, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x15_c0f4, 3); mov(memw_a16[ss, bp - 0x30], cx);         /* mov [bp-0x30], cx */
            ii(0x15_c0f7, 5); mov(memw_a16[ss, bp - 0x2e], 0);          /* mov word [bp-0x2e], 0x0 */
            ii(0x15_c0fc, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c0fd, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_c100, 3); mov(cx, memw_a16[ss, bp - 0x2a]);         /* mov cx, [bp-0x2a] */
            ii(0x15_c103, 3); or(cx, memw_a16[ss, bp - 0x2c]);          /* or cx, [bp-0x2c] */
            ii(0x15_c106, 2); if(jzw(0x15_c125, 0x1d)) goto l_0x15_c125; /* jz 0xc125 */
            ii(0x15_c108, 4); test(memb_a16[ss, bp - 0x34], 0x20);      /* test byte [bp-0x34], 0x20 */
            ii(0x15_c10c, 2); if(jzw(0x15_c125, 0x17)) goto l_0x15_c125; /* jz 0xc125 */
            ii(0x15_c10e, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_c110, 3); mov(cx, memw_a16[es, bx]);                /* mov cx, [es:bx] */
            ii(0x15_c113, 4); mov(si, memw_a16[es, bx + 0x2]);          /* mov si, [es:bx+0x2] */
            ii(0x15_c117, 3); mov(memw_a16[ss, bp - 0x2c], cx);         /* mov [bp-0x2c], cx */
            ii(0x15_c11a, 3); mov(memw_a16[ss, bp - 0x2a], si);         /* mov [bp-0x2a], si */
            ii(0x15_c11d, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_c120, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_c123, 2); jmpw(0x15_c13f, 0x1a); goto l_0x15_c13f;  /* jmp 0xc13f */
        l_0x15_c125:
            ii(0x15_c125, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x15_c128, 3); or(ax, memw_a16[ss, bp - 0x2c]);          /* or ax, [bp-0x2c] */
            ii(0x15_c12b, 2); if(jzw(0x15_c13f, 0x12)) goto l_0x15_c13f; /* jz 0xc13f */
            ii(0x15_c12d, 3); les(bx, ss, bp - 0x1e);                   /* les bx, [bp-0x1e] */
            ii(0x15_c130, 4); add(memw_a16[ss, bp - 0x1e], 0x2);        /* add word [bp-0x1e], 0x2 */
        l_0x15_c134:
            ii(0x15_c134, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_c137, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
            ii(0x15_c13a, 5); mov(memw_a16[ss, bp - 0x2a], 0);          /* mov word [bp-0x2a], 0x0 */
        l_0x15_c13f:
            ii(0x15_c13f, 3); pushw(memw_a16[ss, bp + 0x16]);           /* push word [bp+0x16] */
            ii(0x15_c142, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_c145, 3); pushw(memw_a16[ss, bp - 0x30]);           /* push word [bp-0x30] */
            ii(0x15_c148, 3); lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x15_c14b, 1); pushw(ss);                                /* push ss */
            ii(0x15_c14c, 1); pushw(ax);                                /* push ax */
            ii(0x15_c14d, 3); callw(0x15_ce70, 0xd20);                  /* call 0xce70 */
            ii(0x15_c150, 3); jmpw(0x15_bddf, -0x374); goto l_0x15_bddf; /* jmp 0xbddf */
        l_0x15_c153:
            ii(0x15_c153, 3); mov(ax, memw_a16[ss, bp - 0x24]);         /* mov ax, [bp-0x24] */
            ii(0x15_c156, 3); or(ax, memw_a16[ss, bp - 0x26]);          /* or ax, [bp-0x26] */
            ii(0x15_c159, 2); if(jnzw(0x15_c167, 0xc)) goto l_0x15_c167; /* jnz 0xc167 */
            ii(0x15_c15b, 4); cmp(memw_a16[ss, bp - 0x28], 0);          /* cmp word [bp-0x28], 0x0 */
            ii(0x15_c15f, 2); if(jnzw(0x15_c167, 0x6)) goto l_0x15_c167; /* jnz 0xc167 */
            ii(0x15_c161, 3); mov(ax, 0x521);                           /* mov ax, 0x521 */
            ii(0x15_c164, 3); jmpw(0x15_c1ef, 0x88); goto l_0x15_c1ef;  /* jmp 0xc1ef */
        l_0x15_c167:
            ii(0x15_c167, 3); mov(ax, memw_a16[ss, bp - 0x2c]);         /* mov ax, [bp-0x2c] */
            ii(0x15_c16a, 3); mov(dx, memw_a16[ss, bp - 0x2a]);         /* mov dx, [bp-0x2a] */
            ii(0x15_c16d, 3); add(memw_a16[ss, bp - 0x26], ax);         /* add [bp-0x26], ax */
            ii(0x15_c170, 3); adc(memw_a16[ss, bp - 0x24], dx);         /* adc [bp-0x24], dx */
            ii(0x15_c173, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_c176, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x15_c179, 3); inc(memw_a16[ss, bp - 0x32]);             /* inc word [bp-0x32] */
            ii(0x15_c17c, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x15_c17f, 1); pushw(ax);                                /* push ax */
            ii(0x15_c180, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_c183, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_c186, 3); pushw(memw_a16[ss, bp - 0x28]);           /* push word [bp-0x28] */
            ii(0x15_c189, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_c18c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_c18f, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_c192, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_c195, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_c198, 1); pushw(cs);                                /* push cs */
            ii(0x15_c199, 3); callw(0x15_ba47, -0x755);                 /* call 0xba47 */
            ii(0x15_c19c, 3); add(sp, 0x16);                            /* add sp, 0x16 */
            ii(0x15_c19f, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_c1a2, 3); sub(ax, memw_a16[ss, bp - 0x10]);         /* sub ax, [bp-0x10] */
            ii(0x15_c1a5, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x15_c1a8, 4); cmp(memw_a16[ss, bp - 0x8], 0);           /* cmp word [bp-0x8], 0x0 */
            ii(0x15_c1ac, 2); if(jzw(0x15_c1b7, 0x9)) goto l_0x15_c1b7; /* jz 0xc1b7 */
            ii(0x15_c1ae, 3); mov(cx, memw_a16[ss, bp - 0x32]);         /* mov cx, [bp-0x32] */
            ii(0x15_c1b1, 2); shl(cx, 0x1);                             /* shl cx, 1 */
            ii(0x15_c1b3, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x15_c1b5, 2); jmpw(0x15_c1d9, 0x22); goto l_0x15_c1d9;  /* jmp 0xc1d9 */
        l_0x15_c1b7:
            ii(0x15_c1b7, 3); mov(ax, memw_a16[ss, bp - 0x1c]);         /* mov ax, [bp-0x1c] */
            ii(0x15_c1ba, 3); or(ax, memw_a16[ss, bp - 0x1e]);          /* or ax, [bp-0x1e] */
            ii(0x15_c1bd, 2); if(jnzw(0x15_c1d3, 0x14)) goto l_0x15_c1d3; /* jnz 0xc1d3 */
            ii(0x15_c1bf, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_c1c2, 3); and(ax, 0x40);                            /* and ax, 0x40 */
            ii(0x15_c1c5, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x15_c1c8, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_c1ca, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c1cb, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c1cc, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c1cd, 1); inc(ax);                                  /* inc ax */
            ii(0x15_c1ce, 3); add(memw_a16[ss, bp - 0x20], ax);         /* add [bp-0x20], ax */
            ii(0x15_c1d1, 2); jmpw(0x15_c1dc, 0x9); goto l_0x15_c1dc;   /* jmp 0xc1dc */
        l_0x15_c1d3:
            ii(0x15_c1d3, 3); mov(ax, memw_a16[ss, bp - 0x1e]);         /* mov ax, [bp-0x1e] */
            ii(0x15_c1d6, 3); sub(ax, memw_a16[ss, bp - 0x10]);         /* sub ax, [bp-0x10] */
        l_0x15_c1d9:
            ii(0x15_c1d9, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
        l_0x15_c1dc:
            ii(0x15_c1dc, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x15_c1df, 3); add(memw_a16[ss, bp + 0x10], ax);         /* add [bp+0x10], ax */
            ii(0x15_c1e2, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_c1e4, 3); sub(memw_a16[ss, bp + 0xc], ax);          /* sub [bp+0xc], ax */
            ii(0x15_c1e7, 3); sbb(memw_a16[ss, bp + 0xe], dx);          /* sbb [bp+0xe], dx */
            ii(0x15_c1ea, 3); jmpw(0x15_bbbf, -0x62e); goto l_0x15_bbbf; /* jmp 0xbbbf */
        l_0x15_c1ed:
            ii(0x15_c1ed, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_c1ef:
            ii(0x15_c1ef, 1); popw(si);                                 /* pop si */
            ii(0x15_c1f0, 1); leavew();                                 /* leave */
            ii(0x15_c1f1, 3); retw(0x14); return;                       /* ret 0x14 */
        }
    }
}
