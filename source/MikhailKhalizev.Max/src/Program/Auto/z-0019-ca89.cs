using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ca89-ba2becdb")]
        public void Method_0019_ca89()
        {
            ii(0x19_ca89, 4); enter(0x2c, 0);                           /* enter 0x2c, 0x0 */
            ii(0x19_ca8d, 1); push(di);                                 /* push di */
            ii(0x19_ca8e, 1); push(si);                                 /* push si */
            ii(0x19_ca8f, 5); mov(memw[ss, bp - 38], 0xffff);           /* mov word [bp-0x26], 0xffff */
            ii(0x19_ca94, 5); mov(memw[ss, bp - 36], 0xffff);           /* mov word [bp-0x24], 0xffff */
            ii(0x19_ca99, 2); sub(si, si);                              /* sub si, si */
            ii(0x19_ca9b, 2); jmp(0x19_ca9e, 1); goto l_0x19_ca9e;      /* jmp 0xca9e */
        l_0x19_ca9d:
            ii(0x19_ca9d, 1); inc(si);                                  /* inc si */
        l_0x19_ca9e:
            ii(0x19_ca9e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_caa0, 4); cmp(ax, memw[ds, 0x2162]);                /* cmp ax, [0x2162] */
            ii(0x19_caa4, 2); if(ja(0x19_cacb, 0x25)) goto l_0x19_cacb; /* ja 0xcacb */
            ii(0x19_caa6, 2); if(jb(0x19_caae, 6)) goto l_0x19_caae;    /* jb 0xcaae */
            ii(0x19_caa8, 4); cmp(si, memw[ds, 0x2160]);                /* cmp si, [0x2160] */
            ii(0x19_caac, 2); if(jae(0x19_cacb, 0x1d)) goto l_0x19_cacb; /* jae 0xcacb */
        l_0x19_caae:
            ii(0x19_caae, 3); mov(cx, memw[ss, bp + 8]);                /* mov cx, [bp+0x8] */
            ii(0x19_cab1, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x19_cab4, 3); imul(bx, si, 0xc);                        /* imul bx, si, 0xc */
            ii(0x19_cab7, 4); cmp(memw[ds, bx + 8548], cx);             /* cmp [bx+0x2164], cx */
            ii(0x19_cabb, 2); if(jnz(0x19_ca9d, -0x20)) goto l_0x19_ca9d; /* jnz 0xca9d */
            ii(0x19_cabd, 4); cmp(memw[ds, bx + 8550], dx);             /* cmp [bx+0x2166], dx */
            ii(0x19_cac1, 2); if(jnz(0x19_ca9d, -0x26)) goto l_0x19_ca9d; /* jnz 0xca9d */
            ii(0x19_cac3, 3); mov(memw[ss, bp - 38], si);               /* mov [bp-0x26], si */
            ii(0x19_cac6, 3); mov(memw[ss, bp - 36], ax);               /* mov [bp-0x24], ax */
            ii(0x19_cac9, 2); jmp(0x19_ca9d, -0x2e); goto l_0x19_ca9d;  /* jmp 0xca9d */
        l_0x19_cacb:
            ii(0x19_cacb, 4); cmp(memw[ss, bp - 38], -1 /* 0xff */);    /* cmp word [bp-0x26], 0xffff */
            ii(0x19_cacf, 2); if(jnz(0x19_cada, 9)) goto l_0x19_cada;   /* jnz 0xcada */
            ii(0x19_cad1, 4); cmp(memw[ss, bp - 36], -1 /* 0xff */);    /* cmp word [bp-0x24], 0xffff */
            ii(0x19_cad5, 2); if(jnz(0x19_cada, 3)) goto l_0x19_cada;   /* jnz 0xcada */
            ii(0x19_cad7, 3); jmp(0x19_cbc7, 0xed); goto l_0x19_cbc7;   /* jmp 0xcbc7 */
        l_0x19_cada:
            ii(0x19_cada, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_cadd, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x19_cae0, 2); mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x19_cae2, 5); call_far_abs(0x80, 0x4378);               /* call word 0x80:0x4378 */
            ii(0x19_cae7, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_caea, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_caec, 3); mov(memw[ss, bp - 40], ax);               /* mov [bp-0x28], ax */
            ii(0x19_caef, 3); mov(memw[ss, bp - 42], ax);               /* mov [bp-0x2a], ax */
            ii(0x19_caf2, 3); lea(ax, memw[ss, bp - 34]);               /* lea ax, [bp-0x22] */
            ii(0x19_caf5, 1); push(ss);                                 /* push ss */
            ii(0x19_caf6, 1); push(ax);                                 /* push ax */
            ii(0x19_caf7, 2); push(1);                                  /* push 0x1 */
            ii(0x19_caf9, 2); push(0);                                  /* push 0x0 */
            ii(0x19_cafb, 2); push(0);                                  /* push 0x0 */
            ii(0x19_cafd, 4); imul(bx, memw[ss, bp - 38], 0xc);         /* imul bx, [bp-0x26], 0xc */
            ii(0x19_cb01, 4); mov(ax, memw[ds, bx + 8556]);             /* mov ax, [bx+0x216c] */
            ii(0x19_cb05, 4); mov(dx, memw[ds, bx + 8558]);             /* mov dx, [bx+0x216e] */
            ii(0x19_cb09, 3); mov(memw[ss, bp - 38], ax);               /* mov [bp-0x26], ax */
            ii(0x19_cb0c, 3); mov(memw[ss, bp - 36], dx);               /* mov [bp-0x24], dx */
            ii(0x19_cb0f, 1); push(dx);                                 /* push dx */
            ii(0x19_cb10, 1); push(ax);                                 /* push ax */
            ii(0x19_cb11, 1); nop();                                    /* nop */
            ii(0x19_cb12, 1); push(cs);                                 /* push cs */
            ii(0x19_cb13, 3); call(0x19_d9a7, 0xe91);                   /* call 0xd9a7 */
            ii(0x19_cb16, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x19_cb19, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_cb1b, 2); if(jz(0x19_cb93, 0x76)) goto l_0x19_cb93; /* jz 0xcb93 */
        l_0x19_cb1d:
            ii(0x19_cb1d, 4); cmp(memw[ss, bp - 2], 0);                 /* cmp word [bp-0x2], 0x0 */
            ii(0x19_cb21, 2); if(jnz(0x19_cb26, 3)) goto l_0x19_cb26;   /* jnz 0xcb26 */
            ii(0x19_cb23, 3); jmp(0x19_cbc4, 0x9e); goto l_0x19_cbc4;   /* jmp 0xcbc4 */
        l_0x19_cb26:
            ii(0x19_cb26, 3); lea(ax, memw[ss, bp - 34]);               /* lea ax, [bp-0x22] */
            ii(0x19_cb29, 1); push(ss);                                 /* push ss */
            ii(0x19_cb2a, 1); push(ax);                                 /* push ax */
            ii(0x19_cb2b, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_cb2e, 3); cmp(ax, 0x10);                            /* cmp ax, 0x10 */
            ii(0x19_cb31, 2); if(jbe(0x19_cb36, 3)) goto l_0x19_cb36;   /* jbe 0xcb36 */
            ii(0x19_cb33, 3); mov(ax, 0x10);                            /* mov ax, 0x10 */
        l_0x19_cb36:
            ii(0x19_cb36, 3); mov(memw[ss, bp - 44], ax);               /* mov [bp-0x2c], ax */
            ii(0x19_cb39, 1); push(ax);                                 /* push ax */
            ii(0x19_cb3a, 3); push(memw[ss, bp - 40]);                  /* push word [bp-0x28] */
            ii(0x19_cb3d, 3); push(memw[ss, bp - 42]);                  /* push word [bp-0x2a] */
            ii(0x19_cb40, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x19_cb43, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x19_cb46, 1); nop();                                    /* nop */
            ii(0x19_cb47, 1); push(cs);                                 /* push cs */
            ii(0x19_cb48, 3); call(0x19_d9a7, 0xe5c);                   /* call 0xd9a7 */
            ii(0x19_cb4b, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x19_cb4e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_cb50, 2); if(jz(0x19_cb80, 0x2e)) goto l_0x19_cb80; /* jz 0xcb80 */
            ii(0x19_cb52, 2); sub(si, si);                              /* sub si, si */
            ii(0x19_cb54, 2); jmp(0x19_cb5f, 9); goto l_0x19_cb5f;      /* jmp 0xcb5f */
        l_0x19_cb56:
            ii(0x19_cb56, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_cb58, 2); shl(di, 1);                               /* shl di, 1 */
            ii(0x19_cb5a, 4); and(memb[ss, bp + di - 34], -2 /* 0xfe */); /* and byte [bp+di-0x22], 0xfe */
            ii(0x19_cb5e, 1); inc(si);                                  /* inc si */
        l_0x19_cb5f:
            ii(0x19_cb5f, 3); cmp(memw[ss, bp - 44], si);               /* cmp [bp-0x2c], si */
            ii(0x19_cb62, 2); if(ja(0x19_cb56, -0xe)) goto l_0x19_cb56; /* ja 0xcb56 */
            ii(0x19_cb64, 3); lea(ax, memw[ss, bp - 34]);               /* lea ax, [bp-0x22] */
            ii(0x19_cb67, 1); push(ss);                                 /* push ss */
            ii(0x19_cb68, 1); push(ax);                                 /* push ax */
            ii(0x19_cb69, 3); push(memw[ss, bp - 44]);                  /* push word [bp-0x2c] */
            ii(0x19_cb6c, 3); push(memw[ss, bp - 40]);                  /* push word [bp-0x28] */
            ii(0x19_cb6f, 3); push(memw[ss, bp - 42]);                  /* push word [bp-0x2a] */
            ii(0x19_cb72, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x19_cb75, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x19_cb78, 1); nop();                                    /* nop */
            ii(0x19_cb79, 1); push(cs);                                 /* push cs */
            ii(0x19_cb7a, 3); call(0x19_d9d0, 0xe53);                   /* call 0xd9d0 */
            ii(0x19_cb7d, 3); add(sp, 0xe);                             /* add sp, 0xe */
        l_0x19_cb80:
            ii(0x19_cb80, 3); mov(ax, memw[ss, bp - 44]);               /* mov ax, [bp-0x2c] */
            ii(0x19_cb83, 3); sub(memw[ss, bp - 2], ax);                /* sub [bp-0x2], ax */
            ii(0x19_cb86, 3); shl(ax, 0xc);                             /* shl ax, 0xc */
            ii(0x19_cb89, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_cb8b, 3); add(memw[ss, bp - 42], ax);               /* add [bp-0x2a], ax */
            ii(0x19_cb8e, 3); adc(memw[ss, bp - 40], dx);               /* adc [bp-0x28], dx */
            ii(0x19_cb91, 2); jmp(0x19_cb1d, -0x76); goto l_0x19_cb1d;  /* jmp 0xcb1d */
        l_0x19_cb93:
            ii(0x19_cb93, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_cb96, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x19_cb99, 2); mov(cl, 2);                               /* mov cl, 0x2 */
            ii(0x19_cb9b, 5); call_far_abs(0x80, 0x4378);               /* call word 0x80:0x4378 */
            ii(0x19_cba0, 1); push(dx);                                 /* push dx */
            ii(0x19_cba1, 1); push(ax);                                 /* push ax */
            ii(0x19_cba2, 3); push(0xccf0);                             /* push 0xccf0 */
            ii(0x19_cba5, 3); push(0xccf0);                             /* push 0xccf0 */
            ii(0x19_cba8, 4); push(memw[ds, 0x19e6]);                   /* push word [0x19e6] */
            ii(0x19_cbac, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x19_cbaf, 3); mov(dx, memw[ss, bp + 10]);               /* mov dx, [bp+0xa] */
            ii(0x19_cbb2, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_cbb6, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
            ii(0x19_cbba, 1); push(dx);                                 /* push dx */
            ii(0x19_cbbb, 1); push(ax);                                 /* push ax */
            ii(0x19_cbbc, 1); nop();                                    /* nop */
            ii(0x19_cbbd, 1); push(cs);                                 /* push cs */
            ii(0x19_cbbe, 3); call(0x19_d9d8, 0xe17);                   /* call 0xd9d8 */
            ii(0x19_cbc1, 3); add(sp, 0xe);                             /* add sp, 0xe */
        l_0x19_cbc4:
            ii(0x19_cbc4, 3); mov(ax, 1);                               /* mov ax, 0x1 */
        l_0x19_cbc7:
            ii(0x19_cbc7, 1); pop(si);                                  /* pop si */
            ii(0x19_cbc8, 1); pop(di);                                  /* pop di */
            ii(0x19_cbc9, 1); leave();                                  /* leave */
            ii(0x19_cbca, 3); ret(8);                                   /* ret 0x8 */
        }
    }
}
