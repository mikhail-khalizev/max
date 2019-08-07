using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a962233-6791-42dd-99b5-be15b31d2308")]
        public void Method_0015_cc1a()
        {
            ii(0x15_cc1a, 4); enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x15_cc1e, 4); cmp(memw_a16[ss, bp + 0x8], 0xf);         /* cmp word [bp+0x8], 0xf */
            ii(0x15_cc22, 2); if(jbw(0x15_cc3e, 0x1a)) goto l_0x15_cc3e; /* jb 0xcc3e */
            ii(0x15_cc24, 2); if(jaw(0x15_cc2c, 0x6)) goto l_0x15_cc2c; /* ja 0xcc2c */
            ii(0x15_cc26, 4); cmp(memw_a16[ss, bp + 0x6], -0x1 /* 0xff */); /* cmp word [bp+0x6], 0xffff */
            ii(0x15_cc2a, 2); if(jbew(0x15_cc3e, 0x12)) goto l_0x15_cc3e; /* jbe 0xcc3e */
        l_0x15_cc2c:
            ii(0x15_cc2c, 2); pushw(0xc);                               /* push 0xc */
            ii(0x15_cc2e, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x15_cc31, 1); pushw(ss);                                /* push ss */
            ii(0x15_cc32, 1); pushw(ax);                                /* push ax */
            ii(0x15_cc33, 5); callw_far_abs(0x80, 0x4232);              /* call word 0x80:0x4232 */
            ii(0x15_cc38, 4); mov(memb_a16[ss, bp - 0x8], 0x80);        /* mov byte [bp-0x8], 0x80 */
            ii(0x15_cc3c, 2); jmpw(0x15_cc42, 0x4); goto l_0x15_cc42;   /* jmp 0xcc42 */
        l_0x15_cc3e:
            ii(0x15_cc3e, 4); mov(memb_a16[ss, bp - 0x8], 0);           /* mov byte [bp-0x8], 0x0 */
        l_0x15_cc42:
            ii(0x15_cc42, 3); lea(ax, bp - 0x1a);                       /* lea ax, [bp-0x1a] */
            ii(0x15_cc45, 1); pushw(ss);                                /* push ss */
            ii(0x15_cc46, 1); pushw(ax);                                /* push ax */
            ii(0x15_cc47, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_cc4a, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x15_cc4f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_cc52, 3); mov(al, memb_a16[ss, bp - 0x15]);         /* mov al, [bp-0x15] */
            ii(0x15_cc55, 2); and(al, 0x60);                            /* and al, 0x60 */
            ii(0x15_cc57, 3); mov(memb_a16[ss, bp - 0xa], al);          /* mov [bp-0xa], al */
            ii(0x15_cc5a, 3); or(al, memb_a16[ss, bp + 0x4]);           /* or al, [bp+0x4] */
            ii(0x15_cc5d, 3); mov(memb_a16[ss, bp - 0x15], al);         /* mov [bp-0x15], al */
            ii(0x15_cc60, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_cc63, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_cc66, 3); mov(al, memb_a16[ss, bp + 0xc]);          /* mov al, [bp+0xc] */
            ii(0x15_cc69, 3); mov(memb_a16[ss, bp - 0x16], al);         /* mov [bp-0x16], al */
            ii(0x15_cc6c, 3); mov(al, memb_a16[ss, bp + 0xd]);          /* mov al, [bp+0xd] */
            ii(0x15_cc6f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_cc71, 3); mov(memb_a16[ss, bp - 0x13], al);         /* mov [bp-0x13], al */
            ii(0x15_cc74, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_cc77, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_cc7a, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x15_cc7d, 3); xor(al, memb_a16[ss, bp - 0x14]);         /* xor al, [bp-0x14] */
            ii(0x15_cc80, 2); and(al, 0xf);                             /* and al, 0xf */
            ii(0x15_cc82, 3); xor(memb_a16[ss, bp - 0x14], al);         /* xor [bp-0x14], al */
            ii(0x15_cc85, 4); and(memb_a16[ss, bp - 0x14], 0x7f);       /* and byte [bp-0x14], 0x7f */
            ii(0x15_cc89, 3); mov(al, memb_a16[ss, bp - 0x8]);          /* mov al, [bp-0x8] */
            ii(0x15_cc8c, 2); or(al, 0x40);                             /* or al, 0x40 */
            ii(0x15_cc8e, 3); or(memb_a16[ss, bp - 0x14], al);          /* or [bp-0x14], al */
            ii(0x15_cc91, 3); lea(ax, bp - 0x1a);                       /* lea ax, [bp-0x1a] */
            ii(0x15_cc94, 1); pushw(ss);                                /* push ss */
            ii(0x15_cc95, 1); pushw(ax);                                /* push ax */
            ii(0x15_cc96, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_cc99, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x15_cc9e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_cca1, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x15_cca6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_cca8, 2); if(jzw(0x15_ccf5, 0x4b)) goto l_0x15_ccf5; /* jz 0xccf5 */
            ii(0x15_ccaa, 4); cmp(memb_a16[ss, bp - 0x8], 0);           /* cmp byte [bp-0x8], 0x0 */
            ii(0x15_ccae, 2); if(jzw(0x15_ccbd, 0xd)) goto l_0x15_ccbd; /* jz 0xccbd */
            ii(0x15_ccb0, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x15_ccb3, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x15_ccb5, 3); mov(bx, memw_a16[ss, bp + 0xe]);          /* mov bx, [bp+0xe] */
            ii(0x15_ccb8, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x15_ccbb, 2); @int(0x31);                               /* int 0x31 */
        l_0x15_ccbd:
            ii(0x15_ccbd, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_ccc0, 1); nop();                                    /* nop */
            ii(0x15_ccc1, 1); pushw(cs);                                /* push cs */
            ii(0x15_ccc2, 3); callw(0x16_100b, 0x4346);                 /* call 0x100b */
            ii(0x15_ccc5, 1); popw(bx);                                 /* pop bx */
            ii(0x15_ccc6, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_ccc9, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x15_cccc, 2); mov(cl, 0x8);                             /* mov cl, 0x8 */
            ii(0x15_ccce, 5); callw_far_abs(0x80, 0x4378);              /* call word 0x80:0x4378 */
            ii(0x15_ccd3, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x15_ccd5, 3); xor(al, memb_a16[ss, bp + 0x4]);          /* xor al, [bp+0x4] */
            ii(0x15_ccd8, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x15_ccdb, 2); xor(cx, ax);                              /* xor cx, ax */
            ii(0x15_ccdd, 3); mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x15_cce0, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_cce2, 2); or(cx, ax);                               /* or cx, ax */
            ii(0x15_cce4, 3); or(ch, 0x40);                             /* or ch, 0x40 */
            ii(0x15_cce7, 3); mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0x15_ccea, 3); mov(ax, 0x9);                             /* mov ax, 0x9 */
            ii(0x15_cced, 3); mov(bx, memw_a16[ss, bp + 0xe]);          /* mov bx, [bp+0xe] */
            ii(0x15_ccf0, 3); mov(cx, memw_a16[ss, bp - 0x2]);          /* mov cx, [bp-0x2] */
            ii(0x15_ccf3, 2); @int(0x31);                               /* int 0x31 */
        l_0x15_ccf5:
            ii(0x15_ccf5, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x15_ccf8, 1); leavew();                                 /* leave */
            ii(0x15_ccf9, 3); retw(0xc); return;                        /* ret 0xc */
        }
    }
}
