using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_af46-3d8c80fd")]
        public void Method_0017_af46()
        {
            ii(0x17_af46, 4); enter(0x12, 0);                           /* enter 0x12, 0x0 */
            ii(0x17_af4a, 1); push(ds);                                 /* push ds */
            ii(0x17_af4b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_af4e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_af50, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_af53, 4); mov(dx, memw[es, bx + 8]);                /* mov dx, [es:bx+0x8] */
            ii(0x17_af57, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_af59, 4); mov(cx, memw[es, bx + 4]);                /* mov cx, [es:bx+0x4] */
            ii(0x17_af5d, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x17_af5f, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_af62, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_af64, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_af66, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_af68, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_af6a, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_af6c, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_af6e, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_af70, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_af72, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_af74, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_af76, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_af78, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_af7a, 3); mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x17_af7d, 3); mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0x17_af80, 4); test(cx, 0xfff);                          /* test cx, 0xfff */
            ii(0x17_af84, 2); if(jz(0x17_af92, 0xc)) goto l_0x17_af92;  /* jz 0xaf92 */
            ii(0x17_af86, 3); add(ax, 1);                               /* add ax, 0x1 */
            ii(0x17_af89, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_af8c, 3); mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0x17_af8f, 3); mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
        l_0x17_af92:
            ii(0x17_af92, 4); mov(ax, memw[es, bx + 0x14]);             /* mov ax, [es:bx+0x14] */
            ii(0x17_af96, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_af98, 4); add(cx, memw[es, bx + 0x1c]);             /* add cx, [es:bx+0x1c] */
            ii(0x17_af9c, 3); adc(ax, 0);                               /* adc ax, 0x0 */
            ii(0x17_af9f, 3); mov(memw[ss, bp - 4], cx);                /* mov [bp-0x4], cx */
            ii(0x17_afa2, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x17_afa5, 3); cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x17_afa8, 2); if(jb(0x17_afbf, 0x15)) goto l_0x17_afbf; /* jb 0xafbf */
            ii(0x17_afaa, 2); if(ja(0x17_afac, 0)) goto l_0x17_afac;    /* ja 0xafac */
        l_0x17_afac:
            ii(0x17_afac, 3); add(cx, memw[ss, bp - 0x12]);             /* add cx, [bp-0x12] */
            ii(0x17_afaf, 2); adc(ax, dx);                              /* adc ax, dx */
            ii(0x17_afb1, 4); cmp(ax, memw[ds, 0x4fda]);                /* cmp ax, [0x4fda] */
            ii(0x17_afb5, 2); if(jb(0x17_afc2, 0xb)) goto l_0x17_afc2;  /* jb 0xafc2 */
            ii(0x17_afb7, 2); if(ja(0x17_afbf, 6)) goto l_0x17_afbf;    /* ja 0xafbf */
            ii(0x17_afb9, 4); cmp(cx, memw[ds, 0x4fd8]);                /* cmp cx, [0x4fd8] */
            ii(0x17_afbd, 2); if(jbe(0x17_afc2, 3)) goto l_0x17_afc2;   /* jbe 0xafc2 */
        l_0x17_afbf:
            ii(0x17_afbf, 1); pop(ds);                                  /* pop ds */
            ii(0x17_afc0, 1); leave();                                  /* leave */
            ii(0x17_afc1, 1); retf(); return;                           /* retf */
        l_0x17_afc2:
            ii(0x17_afc2, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_afc5, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_afc8, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_afca, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_afcc, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_afce, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_afd0, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_afd2, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_afd4, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_afd6, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_afd8, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_afda, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_afdc, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_afde, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_afe0, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x17_afe3, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x17_afe6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_afe8, 3); mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x17_afeb, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x17_afee, 2); jmp(0x17_b000, 0x10); goto l_0x17_b000;   /* jmp 0xb000 */
        l_0x17_aff0:
            ii(0x17_aff0, 4); add(memw[ss, bp - 0xc], 1);               /* add word [bp-0xc], 0x1 */
            ii(0x17_aff4, 4); adc(memw[ss, bp - 0xa], 0);               /* adc word [bp-0xa], 0x0 */
            ii(0x17_aff8, 4); add(memw[ss, bp - 8], 1);                 /* add word [bp-0x8], 0x1 */
            ii(0x17_affc, 4); adc(memw[ss, bp - 6], 0);                 /* adc word [bp-0x6], 0x0 */
        l_0x17_b000:
            ii(0x17_b000, 3); mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x17_b003, 3); mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0x17_b006, 3); cmp(memw[ss, bp - 0x10], dx);             /* cmp [bp-0x10], dx */
            ii(0x17_b009, 2); if(jb(0x17_b034, 0x29)) goto l_0x17_b034; /* jb 0xb034 */
            ii(0x17_b00b, 2); if(ja(0x17_b012, 5)) goto l_0x17_b012;    /* ja 0xb012 */
            ii(0x17_b00d, 3); cmp(memw[ss, bp - 0x12], ax);             /* cmp [bp-0x12], ax */
            ii(0x17_b010, 2); if(jbe(0x17_b034, 0x22)) goto l_0x17_b034; /* jbe 0xb034 */
        l_0x17_b012:
            ii(0x17_b012, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x17_b015, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x17_b018, 1); nop();                                    /* nop */
            ii(0x17_b019, 1); push(cs);                                 /* push cs */
            ii(0x17_b01a, 3); call(0x17_901a, -0x2003);                 /* call 0x901a */
            ii(0x17_b01d, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_b020, 3); mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x17_b023, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_b026, 2); if(jz(0x17_b031, 9)) goto l_0x17_b031;    /* jz 0xb031 */
            ii(0x17_b028, 1); push(ax);                                 /* push ax */
            ii(0x17_b029, 1); nop();                                    /* nop */
            ii(0x17_b02a, 1); push(cs);                                 /* push cs */
            ii(0x17_b02b, 3); call(0x17_7ee6, -0x3148);                 /* call 0x7ee6 */
            ii(0x17_b02e, 3); add(sp, 2);                               /* add sp, 0x2 */
        l_0x17_b031:
            ii(0x17_b031, 2); jmp(0x17_aff0, -0x43); goto l_0x17_aff0;  /* jmp 0xaff0 */
        //  ii(0x17_b033, 1); nop();                                    /* nop */
        l_0x17_b034:
            ii(0x17_b034, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_b037, 5); and(memb[es, bx + 0x2c], -2 /* 0xfe */);  /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_b03c, 1); pop(ds);                                  /* pop ds */
            ii(0x17_b03d, 1); leave();                                  /* leave */
            ii(0x17_b03e, 1); retf();                                   /* retf */
        }
    }
}
