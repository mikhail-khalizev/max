using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_de46-d33c90d5")]
        public void Method_0019_de46()
        {
            ii(0x19_de46, 4); enter(0x30, 0);                           /* enter 0x30, 0x0 */
            ii(0x19_de4a, 1); push(si);                                 /* push si */
            ii(0x19_de4b, 5); mov(memw[ss, bp - 0x16], 0);              /* mov word [bp-0x16], 0x0 */
            ii(0x19_de50, 4); mov(memb[ss, bp - 0x1e], 0);              /* mov byte [bp-0x1e], 0x0 */
            ii(0x19_de54, 4); mov(es, memw[ds, 0x3fc8]);                /* mov es, [0x3fc8] */
            ii(0x19_de58, 4); mov(ax, memw[es, 0x3b84]);                /* mov ax, [es:0x3b84] */
            ii(0x19_de5c, 5); mov(memw[ss, bp - 0x1c], 0);              /* mov word [bp-0x1c], 0x0 */
            ii(0x19_de61, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_de64, 4); mov(ax, memw[es, 0x3b72]);                /* mov ax, [es:0x3b72] */
            ii(0x19_de68, 5); mov(memw[ss, bp - 0x24], 0);              /* mov word [bp-0x24], 0x0 */
            ii(0x19_de6d, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x19_de70, 5); test(memw[ss, bp + 0x6], 0xffff);         /* test word [bp+0x6], 0xffff */
            ii(0x19_de75, 2); if(jz(0x19_de7d, 0x6)) goto l_0x19_de7d;  /* jz 0xde7d */
        l_0x19_de77:
            ii(0x19_de77, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_de79, 1); cwd();                                    /* cwd */
            ii(0x19_de7a, 3); jmp(0x19_df73, 0xf6); goto l_0x19_df73;   /* jmp 0xdf73 */
        l_0x19_de7d:
            ii(0x19_de7d, 4); cmp(memw[ss, bp + 0xc], 0);               /* cmp word [bp+0xc], 0x0 */
            ii(0x19_de81, 2); if(jz(0x19_debe, 0x3b)) goto l_0x19_debe; /* jz 0xdebe */
            ii(0x19_de83, 4); cmp(memw[ss, bp + 0xe], 0);               /* cmp word [bp+0xe], 0x0 */
            ii(0x19_de87, 2); if(jl(0x19_debe, 0x35)) goto l_0x19_debe; /* jl 0xdebe */
            ii(0x19_de89, 4); mov(es, memw[ds, 0x3fca]);                /* mov es, [0x3fca] */
            ii(0x19_de8d, 4); mov(ax, memw[es, 0x32ae]);                /* mov ax, [es:0x32ae] */
            ii(0x19_de91, 5); or(ax, memw[es, 0x32ac]);                 /* or ax, [es:0x32ac] */
            ii(0x19_de96, 2); if(jz(0x19_debe, 0x26)) goto l_0x19_debe; /* jz 0xdebe */
            ii(0x19_de98, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_de9b, 3); push(0x108);                              /* push 0x108 */
            ii(0x19_de9e, 2); push(0);                                  /* push 0x0 */
            ii(0x19_dea0, 2); push(0xf);                                /* push 0xf */
            ii(0x19_dea2, 5); call_far_ind(memw[es, 0x32ac]);           /* call far word [es:0x32ac] */
            ii(0x19_dea7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_deaa, 3); mov(memw[ss, bp - 0x28], ax);             /* mov [bp-0x28], ax */
            ii(0x19_dead, 3); mov(memw[ss, bp - 0x26], dx);             /* mov [bp-0x26], dx */
            ii(0x19_deb0, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_deb2, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x19_deb5, 3); inc(memb[ss, bp - 0x1e]);                 /* inc byte [bp-0x1e] */
            ii(0x19_deb8, 1); push(ax);                                 /* push ax */
            ii(0x19_deb9, 3); call(0x19_ddfd, -0xbf);                   /* call 0xddfd */
            ii(0x19_debc, 2); jmp(0x19_dec8, 0xa); goto l_0x19_dec8;    /* jmp 0xdec8 */
        l_0x19_debe:
            ii(0x19_debe, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_dec0, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_dec2, 1); inc(cx);                                  /* inc cx */
            ii(0x19_dec3, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_dec5, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
        l_0x19_dec8:
            ii(0x19_dec8, 4); cmp(memw[ss, bp - 0x16], 0);              /* cmp word [bp-0x16], 0x0 */
            ii(0x19_decc, 2); if(jz(0x19_de77, -0x57)) goto l_0x19_de77; /* jz 0xde77 */
            ii(0x19_dece, 3); lea(ax, memw[ss, bp - 0x30]);             /* lea ax, [bp-0x30] */
            ii(0x19_ded1, 1); push(ss);                                 /* push ss */
            ii(0x19_ded2, 1); push(ax);                                 /* push ax */
            ii(0x19_ded3, 3); push(memw[ss, bp - 0x16]);                /* push word [bp-0x16] */
            ii(0x19_ded6, 5); call_far_abs(0x80, 0x4f82);               /* call word 0x80:0x4f82 */
            ii(0x19_dedb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_dede, 3); mov(al, memb[ss, bp - 0x2b]);             /* mov al, [bp-0x2b] */
            ii(0x19_dee1, 2); and(al, 0x60);                            /* and al, 0x60 */
            ii(0x19_dee3, 3); mov(memb[ss, bp - 0x18], al);             /* mov [bp-0x18], al */
            ii(0x19_dee6, 3); mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0x19_dee9, 3); mov(bx, memw[ss, bp - 0x16]);             /* mov bx, [bp-0x16] */
            ii(0x19_deec, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x19_deef, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x19_def2, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_def4, 1); inc(ax);                                  /* inc ax */
            ii(0x19_def5, 3); mov(cx, memw[ss, bp + 0x6]);              /* mov cx, [bp+0x6] */
            ii(0x19_def8, 3); mov(dx, memw[ss, bp + 0x4]);              /* mov dx, [bp+0x4] */
            ii(0x19_defb, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_defd, 1); inc(ax);                                  /* inc ax */
            ii(0x19_defe, 3); mov(cx, 0x92);                            /* mov cx, 0x92 */
            ii(0x19_df01, 3); or(cx, memw[ss, bp - 0x18]);              /* or cx, [bp-0x18] */
            ii(0x19_df04, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_df06, 4); cmp(memb[ss, bp - 0x1e], 0);              /* cmp byte [bp-0x1e], 0x0 */
            ii(0x19_df0a, 2); if(jz(0x19_df6e, 0x62)) goto l_0x19_df6e; /* jz 0xdf6e */
            ii(0x19_df0c, 3); mov(ax, memw[ds, 0x3292]);                /* mov ax, [0x3292] */
            ii(0x19_df0f, 4); or(ax, memw[ds, 0x3290]);                 /* or ax, [0x3290] */
            ii(0x19_df13, 2); if(jz(0x19_df6e, 0x59)) goto l_0x19_df6e; /* jz 0xdf6e */
            ii(0x19_df15, 4); cmp(memw[ss, bp + 0xe], 0);               /* cmp word [bp+0xe], 0x0 */
            ii(0x19_df19, 2); if(jl(0x19_df6e, 0x53)) goto l_0x19_df6e; /* jl 0xdf6e */
            ii(0x19_df1b, 4); cmp(memw[ss, bp + 0xc], 0x2);             /* cmp word [bp+0xc], 0x2 */
            ii(0x19_df1f, 2); if(jz(0x19_df6e, 0x4d)) goto l_0x19_df6e; /* jz 0xdf6e */
            ii(0x19_df21, 3); mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x19_df24, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_df26, 1); push(ax);                                 /* push ax */
            ii(0x19_df27, 1); push(cx);                                 /* push cx */
            ii(0x19_df28, 3); lea(ax, memw[ss, bp + 0xe]);              /* lea ax, [bp+0xe] */
            ii(0x19_df2b, 1); push(ss);                                 /* push ss */
            ii(0x19_df2c, 1); push(ax);                                 /* push ax */
            ii(0x19_df2d, 2); push(0x6);                                /* push 0x6 */
            ii(0x19_df2f, 4); call_far_ind(memw[ds, 0x3290]);           /* call far word [0x3290] */
            ii(0x19_df33, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_df36, 3); mov(memw[ss, bp - 0x20], ax);             /* mov [bp-0x20], ax */
            ii(0x19_df39, 3); mov(bx, memw[ss, bp - 0x16]);             /* mov bx, [bp-0x16] */
            ii(0x19_df3c, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x19_df3f, 3); les(si, memw[ss, bp - 0x1c]);             /* les si, [bp-0x1c] */
            ii(0x19_df42, 3); mov(al, memb[es, bx + si]);               /* mov al, [es:bx+si] */
            ii(0x19_df45, 1); cbw();                                    /* cbw */
            ii(0x19_df46, 1); push(ax);                                 /* push ax */
            ii(0x19_df47, 3); mov(bx, memw[ss, bp - 0x16]);             /* mov bx, [bp-0x16] */
            ii(0x19_df4a, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x19_df4d, 3); les(si, memw[ss, bp - 0x24]);             /* les si, [bp-0x24] */
            ii(0x19_df50, 4); push(memw[es, bx + si + 0x6]);            /* push word [es:bx+si+0x6] */
            ii(0x19_df54, 4); push(memw[es, bx + si + 0x4]);            /* push word [es:bx+si+0x4] */
            ii(0x19_df58, 4); push(memw[es, bx + si + 0x2]);            /* push word [es:bx+si+0x2] */
            ii(0x19_df5c, 3); push(memw[es, bx + si]);                  /* push word [es:bx+si] */
            ii(0x19_df5f, 3); push(memw[ss, bp - 0x16]);                /* push word [bp-0x16] */
            ii(0x19_df62, 4); mov(es, memw[ds, 0x3fcc]);                /* mov es, [0x3fcc] */
            ii(0x19_df66, 5); call_far_ind(memw[es, 0x32b0]);           /* call far word [es:0x32b0] */
            ii(0x19_df6b, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_df6e:
            ii(0x19_df6e, 3); mov(dx, memw[ss, bp - 0x16]);             /* mov dx, [bp-0x16] */
            ii(0x19_df71, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_df73:
            ii(0x19_df73, 1); pop(si);                                  /* pop si */
            ii(0x19_df74, 1); leave();                                  /* leave */
            ii(0x19_df75, 3); ret(0xc);                                 /* ret 0xc */
        }
    }
}
