using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0be84e77-fbe6-4968-be61-76776ab93ec0")]
        public void Method_0018_a99f()
        {
            ii(0x18_a99f, 3); callw(0x18_ab18, 0x176);                  /* call 0xab18 */
            ii(0x18_a9a2, 2); if(jaew(0x18_a9ac, 0x8)) goto l_0x18_a9ac; /* jae 0xa9ac */
            ii(0x18_a9a4, 3); callw(0x18_a893, -0x114);                 /* call 0xa893 */
            ii(0x18_a9a7, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_a9aa, 2); jmpw(0x18_aa14, 0x68); goto l_0x18_aa14;  /* jmp 0xaa14 */
        l_0x18_a9ac:
            ii(0x18_a9ac, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x18_a9af, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
        l_0x18_a9b2:
            ii(0x18_a9b2, 1); sti();                                    /* sti */
            ii(0x18_a9b3, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x18_a9b7, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x18_a9ba, 2); mov(cx, dx);                              /* mov cx, dx */
            ii(0x18_a9bc, 4); cmp(cx, memw_a16[ds, 0xe]);               /* cmp cx, [0xe] */
            ii(0x18_a9c0, 2); if(jbew(0x18_a9c6, 0x4)) goto l_0x18_a9c6; /* jbe 0xa9c6 */
            ii(0x18_a9c2, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
        l_0x18_a9c6:
            ii(0x18_a9c6, 3); mov(memw_a16[ds, bx + 0x14], cx);         /* mov [bx+0x14], cx */
            ii(0x18_a9c9, 3); mov(ax, memw_a16[ss, bp + 0x16]);         /* mov ax, [bp+0x16] */
            ii(0x18_a9cc, 3); mov(memw_a16[ds, bx + 0x16], ax);         /* mov [bx+0x16], ax */
            ii(0x18_a9cf, 1); pushw(cx);                                /* push cx */
            ii(0x18_a9d0, 1); pushw(ds);                                /* push ds */
            ii(0x18_a9d1, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0x18_a9d4, 1); cli();                                    /* cli */
            ii(0x18_a9d5, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x18_a9d7, 1); pushw(si);                                /* push si */
            ii(0x18_a9d8, 2); add(si, cx);                              /* add si, cx */
            ii(0x18_a9da, 1); popw(si);                                 /* pop si */
            ii(0x18_a9db, 2); if(jaew(0x18_a9f0, 0x13)) goto l_0x18_a9f0; /* jae 0xa9f0 */
            ii(0x18_a9dd, 2); if(jzw(0x18_a9f0, 0x11)) goto l_0x18_a9f0; /* jz 0xa9f0 */
            ii(0x18_a9df, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x18_a9e1, 1); pushw(cx);                                /* push cx */
            ii(0x18_a9e2, 2); neg(cx);                                  /* neg cx */
            ii(0x18_a9e4, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_a9e6, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x18_a9e8, 3); add(cx, 0x8);                             /* add cx, 0x8 */
            ii(0x18_a9eb, 2); mov(ds, cx);                              /* mov ds, cx */
            ii(0x18_a9ed, 1); popw(cx);                                 /* pop cx */
            ii(0x18_a9ee, 2); add(cx, ax);                              /* add cx, ax */
        l_0x18_a9f0:
            ii(0x18_a9f0, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x18_a9f2, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x18_a9f4, 2); rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x18_a9f6, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_a9f8, 1); popw(ds);                                 /* pop ds */
            ii(0x18_a9f9, 3); callw(0x18_a893, -0x169);                 /* call 0xa893 */
            ii(0x18_a9fc, 1); sti();                                    /* sti */
            ii(0x18_a9fd, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_aa00, 1); popw(cx);                                 /* pop cx */
            ii(0x18_aa01, 4); test(memb_a16[ds, bx + 0x26], 0x1);       /* test byte [bx+0x26], 0x1 */
            ii(0x18_aa05, 2); if(jnzw(0x18_aa14, 0xd)) goto l_0x18_aa14; /* jnz 0xaa14 */
            ii(0x18_aa07, 2); sub(dx, ax);                              /* sub dx, ax */
            ii(0x18_aa09, 2); if(jzw(0x18_aa0f, 0x4)) goto l_0x18_aa0f; /* jz 0xaa0f */
            ii(0x18_aa0b, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x18_aa0d, 2); if(jzw(0x18_a9b2, -0x5d)) goto l_0x18_a9b2; /* jz 0xa9b2 */
        l_0x18_aa0f:
            ii(0x18_aa0f, 3); mov(ax, memw_a16[ss, bp + 0x14]);         /* mov ax, [bp+0x14] */
            ii(0x18_aa12, 2); sub(ax, dx);                              /* sub ax, dx */
        l_0x18_aa14:
            ii(0x18_aa14, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x18_aa17, 3); if(jmpw_func(0x18_a82f, -0x1eb)) return;  /* jmp 0xa82f */
            ii(0x18_aa1a, 3); callw(0x18_ab18, 0xfb);                   /* call 0xab18 */
            ii(0x18_aa1d, 2); if(jbw(0x18_aa39, 0x1a)) goto l_0x18_aa39; /* jb 0xaa39 */
            ii(0x18_aa1f, 4); mov(cx, memw_a16[ds, 0xe]);               /* mov cx, [0xe] */
            ii(0x18_aa23, 1); dec(cx);                                  /* dec cx */
            ii(0x18_aa24, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x18_aa28, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x18_aa2b, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
            ii(0x18_aa2e, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
        l_0x18_aa31:
            ii(0x18_aa31, 1); lodsb_a16();                              /* lodsb */
            ii(0x18_aa32, 1); stosb_a16();                              /* stosb */
            ii(0x18_aa33, 2); cmp(al, 0x24);                            /* cmp al, 0x24 */
            ii(0x18_aa35, 2); if(loopnew_a16(0x18_aa31, -0x6)) goto l_0x18_aa31; /* loopne 0xaa31 */
            ii(0x18_aa37, 1); pushw(es);                                /* push es */
            ii(0x18_aa38, 1); popw(ds);                                 /* pop ds */
        l_0x18_aa39:
            ii(0x18_aa39, 3); callw(0x18_a893, -0x1a9);                 /* call 0xa893 */
            ii(0x18_aa3c, 3); if(jmpw_func(0x18_a82f, -0x210)) return;  /* jmp 0xa82f */
        l_0x18_aa3f:
            ii(0x18_aa3f, 3); callw(0x18_ab18, 0xd6);                   /* call 0xab18 */
            ii(0x18_aa42, 2); if(jaew(0x18_aa47, 0x3)) goto l_0x18_aa47; /* jae 0xaa47 */
            ii(0x18_aa44, 3); if(jmpw_func(0x18_a81c, -0x22b)) return;  /* jmp 0xa81c */
        l_0x18_aa47:
            ii(0x18_aa47, 4); mov(di, memw_a16[ds, 0xa]);               /* mov di, [0xa] */
            ii(0x18_aa4b, 3); mov(memw_a16[ds, bx + 0x12], di);         /* mov [bx+0x12], di */
            ii(0x18_aa4e, 3); mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0x18_aa51, 3); mov(si, memw_a16[ss, bp + 0x12]);         /* mov si, [bp+0x12] */
            ii(0x18_aa54, 2); mov(cl, memb_a16[ds, si]);                /* mov cl, [si] */
            ii(0x18_aa56, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x18_aa58, 1); inc(cx);                                  /* inc cx */
            ii(0x18_aa59, 1); inc(cx);                                  /* inc cx */
            ii(0x18_aa5a, 1); pushw(ds);                                /* push ds */
            ii(0x18_aa5b, 1); pushw(cx);                                /* push cx */
            ii(0x18_aa5c, 1); pushw(si);                                /* push si */
            ii(0x18_aa5d, 1); pushw(di);                                /* push di */
            ii(0x18_aa5e, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_aa60, 1); pushw(es);                                /* push es */
            ii(0x18_aa61, 1); popw(ds);                                 /* pop ds */
            ii(0x18_aa62, 3); callw(0x18_a893, -0x1d2);                 /* call 0xa893 */
            ii(0x18_aa65, 1); popw(si);                                 /* pop si */
            ii(0x18_aa66, 1); popw(di);                                 /* pop di */
            ii(0x18_aa67, 1); popw(cx);                                 /* pop cx */
            ii(0x18_aa68, 1); popw(es);                                 /* pop es */
            ii(0x18_aa69, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x18_aa6b, 3); if(jmpw_func(0x18_a838, -0x236)) return;  /* jmp 0xa838 */
            ii(0x18_aa6e, 4); cmp(memb_a16[ss, bp + 0x16], 0xa);        /* cmp byte [bp+0x16], 0xa */
            ii(0x18_aa72, 2); if(jzw(0x18_aa3f, -0x35)) goto l_0x18_aa3f; /* jz 0xaa3f */
            ii(0x18_aa74, 3); if(jmpw_func(0x18_a81c, -0x25b)) return;  /* jmp 0xa81c */
            ii(0x18_aa77, 4); dec(memb_a16[ds, 0x10ed]);                /* dec byte [0x10ed] */
            ii(0x18_aa7b, 3); if(jmpw_func(0x18_a81c, -0x262)) return;  /* jmp 0xa81c */
            ii(0x18_aa7e, 5); test(memb_a16[ds, 0x14], 0x4);            /* test byte [0x14], 0x4 */
            ii(0x18_aa83, 2); if(jnzw(0x18_aa97, 0x12)) goto l_0x18_aa97; /* jnz 0xaa97 */
            ii(0x18_aa85, 1); sti();                                    /* sti */
            ii(0x18_aa86, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x18_aa8a, 4); mov(al, memb_a16[es, 0x46c]);             /* mov al, [es:0x46c] */
            ii(0x18_aa8e, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_aa90, 4); xchg(memb_a16[ds, 0x10ed], al);           /* xchg [0x10ed], al */
            ii(0x18_aa94, 2); sub(al, ah);                              /* sub al, ah */
            ii(0x18_aa96, 1); cli();                                    /* cli */
        l_0x18_aa97:
            ii(0x18_aa97, 1); retw(); return;                           /* ret */
        //  ii(0x18_aa98, 61); Недостижимый (и не декодированный) код.
        l_0x18_aad5:
            ii(0x18_aad5, 1); pushw(bx);                                /* push bx */
            ii(0x18_aad6, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x18_aad8, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x18_aadb, 1); pushw(cs);                                /* push cs */
            ii(0x18_aadc, 3); callw(0x18_a3b9, -0x726);                 /* call 0xa3b9 */
            ii(0x18_aadf, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_aae0, 1); popw(bx);                                 /* pop bx */
            ii(0x18_aae1, 2); jmpw(0x18_ab00, 0x1d); goto l_0x18_ab00;  /* jmp 0xab00 */
        //    ii(0x18_aae3, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
        //    ii(0x18_aae8, 2); if(jzw(0x18_aad5, -0x15)) goto l_0x18_aad5; /* jz 0xaad5 */
        //    ii(0x18_aaea, 1); pushw(es);                                /* push es */
        //    ii(0x18_aaeb, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
        //    ii(0x18_aaee, 2); mov(es, ax);                              /* mov es, ax */
        //    ii(0x18_aaf0, 3); and(di, -0x8 /* 0xf8 */);                 /* and di, 0xfff8 */
        //    ii(0x18_aaf3, 4); mov(ax, memw_a16[es, di + 0x2]);          /* mov ax, [es:di+0x2] */
        //    ii(0x18_aaf7, 4); mov(cl, memb_a16[es, di + 0x4]);          /* mov cl, [es:di+0x4] */
        //    ii(0x18_aafb, 4); mov(ch, memb_a16[es, di + 0x7]);          /* mov ch, [es:di+0x7] */
        //    ii(0x18_aaff, 1); popw(es);                                 /* pop es */
        l_0x18_ab00:
            ii(0x18_ab00, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x18_ab03, 2); if(jaew(0x18_ab13, 0xe)) goto l_0x18_ab13; /* jae 0xab13 */
            ii(0x18_ab05, 2); test(al, 0xf);                            /* test al, 0xf */
            ii(0x18_ab07, 2); if(jnzw(0x18_ab13, 0xa)) goto l_0x18_ab13; /* jnz 0xab13 */
            ii(0x18_ab09, 3); shr(ax, 0x4);                             /* shr ax, 0x4 */
            ii(0x18_ab0c, 3); shl(cl, 0x4);                             /* shl cl, 0x4 */
            ii(0x18_ab0f, 2); or(ah, cl);                               /* or ah, cl */
            ii(0x18_ab11, 1); stc();                                    /* stc */
            ii(0x18_ab12, 1); retw(); return;                           /* ret */
        l_0x18_ab13:
            ii(0x18_ab13, 3); mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x18_ab16, 1); clc();                                    /* clc */
            ii(0x18_ab17, 1); retw(); return;                           /* ret */
        }
    }
}
