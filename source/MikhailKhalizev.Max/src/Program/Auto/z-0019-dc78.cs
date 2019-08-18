using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_dc78-a8d86685")]
        public void Method_0019_dc78()
        {
            ii(0x19_dc78, 4); enterw(0x24, 0);                          /* enter 0x24, 0x0 */
            ii(0x19_dc7c, 1); pushw(di);                                /* push di */
            ii(0x19_dc7d, 1); pushw(si);                                /* push si */
            ii(0x19_dc7e, 3); les(bx, ss, bp + 0x14);                   /* les bx, [bp+0x14] */
            ii(0x19_dc81, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x19_dc85, 3); mov(memw_a16[ss, bp - 0x1a], si);         /* mov [bp-0x1a], si */
            ii(0x19_dc88, 3); mov(memw_a16[ss, bp - 0x18], es);         /* mov [bp-0x18], es */
            ii(0x19_dc8b, 5); cmp(memw_a16[es, si], 0x584c);            /* cmp word [es:si], 0x584c */
            ii(0x19_dc90, 2); if(jnzw(0x19_dc96, 0x4)) goto l_0x19_dc96; /* jnz 0xdc96 */
            ii(0x19_dc92, 2); mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x19_dc94, 2); jmpw(0x19_dc98, 0x2); goto l_0x19_dc98;   /* jmp 0xdc98 */
        l_0x19_dc96:
            ii(0x19_dc96, 2); sub(al, al);                              /* sub al, al */
        l_0x19_dc98:
            ii(0x19_dc98, 3); mov(es, memw_a16[ss, bp + 0x16]);         /* mov es, [bp+0x16] */
            ii(0x19_dc9b, 4); mov(cx, memw_a16[es, bx + 0x40]);         /* mov cx, [es:bx+0x40] */
            ii(0x19_dc9f, 4); mov(dx, memw_a16[es, bx + 0x42]);         /* mov dx, [es:bx+0x42] */
            ii(0x19_dca3, 3); mov(es, memw_a16[ss, bp - 0x18]);         /* mov es, [bp-0x18] */
            ii(0x19_dca6, 4); mov(bx, memw_a16[es, si + 0x28]);         /* mov bx, [es:si+0x28] */
            ii(0x19_dcaa, 4); mov(di, memw_a16[es, si + 0x2a]);         /* mov di, [es:si+0x2a] */
            ii(0x19_dcae, 3); mov(memw_a16[ss, bp - 0xe], bx);          /* mov [bp-0xe], bx */
            ii(0x19_dcb1, 3); mov(memw_a16[ss, bp - 0xc], di);          /* mov [bp-0xc], di */
            ii(0x19_dcb4, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_dcb6, 4); imul(bx, memw_a16[ss, bp + 0x12], 0x18);  /* imul bx, [bp+0x12], 0x18 */
            ii(0x19_dcba, 3); mov(memw_a16[ss, bp - 0x1c], bx);         /* mov [bp-0x1c], bx */
            ii(0x19_dcbd, 3); les(bx, ss, bp + 0x14);                   /* les bx, [bp+0x14] */
            ii(0x19_dcc0, 4); les(bx, es, bx + 0x3c);                   /* les bx, [es:bx+0x3c] */
            ii(0x19_dcc4, 3); mov(memw_a16[ss, bp - 0x20], si);         /* mov [bp-0x20], si */
            ii(0x19_dcc7, 3); mov(memw_a16[ss, bp - 0x1e], di);         /* mov [bp-0x1e], di */
            ii(0x19_dcca, 3); mov(si, memw_a16[ss, bp - 0x1c]);         /* mov si, [bp-0x1c] */
            ii(0x19_dccd, 4); mov(bx, memw_a16[es, bx + si + 0xc]);     /* mov bx, [es:bx+si+0xc] */
            ii(0x19_dcd1, 3); add(bx, memw_a16[ss, bp + 0x10]);         /* add bx, [bp+0x10] */
            ii(0x19_dcd4, 1); dec(bx);                                  /* dec bx */
            ii(0x19_dcd5, 3); mov(memw_a16[ss, bp - 0x16], bx);         /* mov [bp-0x16], bx */
            ii(0x19_dcd8, 2); or(al, al);                               /* or al, al */
            ii(0x19_dcda, 2); if(jzw(0x19_dd42, 0x66)) goto l_0x19_dd42; /* jz 0xdd42 */
            ii(0x19_dcdc, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x19_dcdf, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_dce1, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x19_dce3, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x19_dce6, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x19_dcea, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x19_dcec, 3); les(di, ss, bp - 0x1a);                   /* les di, [bp-0x1a] */
            ii(0x19_dcef, 3); mov(memw_a16[ss, bp - 0x24], si);         /* mov [bp-0x24], si */
            ii(0x19_dcf2, 3); mov(memw_a16[ss, bp - 0x22], cx);         /* mov [bp-0x22], cx */
            ii(0x19_dcf5, 4); mov(cl, memb_a16[es, di + 0x2c]);         /* mov cl, [es:di+0x2c] */
            ii(0x19_dcf9, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_dcfb, 5); callw_far_abs(0x80, 0x4324);              /* call word 0x80:0x4324 */
            ii(0x19_dd00, 5); add(ax, memw_a16[es, di + 0x80]);         /* add ax, [es:di+0x80] */
            ii(0x19_dd05, 5); adc(dx, memw_a16[es, di + 0x82]);         /* adc dx, [es:di+0x82] */
            ii(0x19_dd0a, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_dd0d, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_dd10, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x19_dd14, 3); add(si, memw_a16[ss, bp - 0x24]);         /* add si, [bp-0x24] */
            ii(0x19_dd17, 3); mov(es, memw_a16[ss, bp - 0x22]);         /* mov es, [bp-0x22] */
            ii(0x19_dd1a, 4); mov(ax, memw_a16[es, si + 0x6]);          /* mov ax, [es:si+0x6] */
            ii(0x19_dd1e, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_dd21, 4); mov(ax, memw_a16[es, si + 0x4]);          /* mov ax, [es:si+0x4] */
            ii(0x19_dd25, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_dd27, 3); cmp(dx, memw_a16[ss, bp - 0x1e]);         /* cmp dx, [bp-0x1e] */
            ii(0x19_dd2a, 2); if(jaew(0x19_dd2f, 0x3)) goto l_0x19_dd2f; /* jae 0xdd2f */
            ii(0x19_dd2c, 3); jmpw(0x19_ddcf, 0xa0); goto l_0x19_ddcf;  /* jmp 0xddcf */
        l_0x19_dd2f:
            ii(0x19_dd2f, 2); if(jaw(0x19_dd39, 0x8)) goto l_0x19_dd39; /* ja 0xdd39 */
            ii(0x19_dd31, 3); cmp(ax, memw_a16[ss, bp - 0x20]);         /* cmp ax, [bp-0x20] */
            ii(0x19_dd34, 2); if(jaw(0x19_dd39, 0x3)) goto l_0x19_dd39; /* ja 0xdd39 */
            ii(0x19_dd36, 3); jmpw(0x19_ddcf, 0x96); goto l_0x19_ddcf;  /* jmp 0xddcf */
        l_0x19_dd39:
            ii(0x19_dd39, 3); mov(dx, memw_a16[ss, bp - 0x1e]);         /* mov dx, [bp-0x1e] */
            ii(0x19_dd3c, 3); mov(ax, memw_a16[ss, bp - 0x20]);         /* mov ax, [bp-0x20] */
            ii(0x19_dd3f, 3); jmpw(0x19_ddcf, 0x8d); goto l_0x19_ddcf;  /* jmp 0xddcf */
        l_0x19_dd42:
            ii(0x19_dd42, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_dd45, 2); add(bx, cx);                              /* add bx, cx */
            ii(0x19_dd47, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_dd49, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_dd4c, 4); mov(cl, memb_a16[es, bx + 0x2]);          /* mov cl, [es:bx+0x2] */
            ii(0x19_dd50, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x19_dd52, 4); mov(ah, memb_a16[es, bx + 0x1]);          /* mov ah, [es:bx+0x1] */
            ii(0x19_dd56, 2); sub(al, al);                              /* sub al, al */
            ii(0x19_dd58, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
            ii(0x19_dd5b, 1); cwd();                                    /* cwd */
            ii(0x19_dd5c, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x19_dd5e, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x19_dd60, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_dd63, 3); mov(cl, memb_a16[ss, bp - 0x24]);         /* mov cl, [bp-0x24] */
            ii(0x19_dd66, 2); sub(si, si);                              /* sub si, si */
            ii(0x19_dd68, 2); add(ax, si);                              /* add ax, si */
            ii(0x19_dd6a, 2); adc(dx, cx);                              /* adc dx, cx */
            ii(0x19_dd6c, 1); pushw(di);                                /* push di */
            ii(0x19_dd6d, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x19_dd70, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_dd72, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x19_dd74, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x19_dd77, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x19_dd7a, 1); pushw(dx);                                /* push dx */
            ii(0x19_dd7b, 1); pushw(ax);                                /* push ax */
            ii(0x19_dd7c, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x19_dd7e, 3); mov(memw_a16[ss, bp - 0x20], bx);         /* mov [bp-0x20], bx */
            ii(0x19_dd81, 3); mov(memw_a16[ss, bp - 0x1e], es);         /* mov [bp-0x1e], es */
            ii(0x19_dd84, 5); callw_far_abs(0x80, 0x4252);              /* call word 0x80:0x4252 */
            ii(0x19_dd89, 3); les(bx, ss, bp + 0x14);                   /* les bx, [bp+0x14] */
            ii(0x19_dd8c, 4); les(bx, es, bx + 0x1c);                   /* les bx, [es:bx+0x1c] */
            ii(0x19_dd90, 5); add(ax, memw_a16[es, bx + 0x80]);         /* add ax, [es:bx+0x80] */
            ii(0x19_dd95, 5); adc(dx, memw_a16[es, bx + 0x82]);         /* adc dx, [es:bx+0x82] */
            ii(0x19_dd9a, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x19_dd9c, 3); mov(memw_a16[ss, bp - 0x1a], cx);         /* mov [bp-0x1a], cx */
            ii(0x19_dd9f, 3); mov(memw_a16[ss, bp - 0x18], es);         /* mov [bp-0x18], es */
            ii(0x19_dda2, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_dda5, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_dda8, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x19_ddac, 3); les(bx, ss, bp - 0x20);                   /* les bx, [bp-0x20] */
            ii(0x19_ddaf, 4); mov(al, memb_a16[es, bx + 0x3]);          /* mov al, [es:bx+0x3] */
            ii(0x19_ddb3, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_ddb5, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_ddb8, 3); les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x19_ddbb, 4); cmp(di, memw_a16[es, bx + 0x14]);         /* cmp di, [es:bx+0x14] */
            ii(0x19_ddbf, 2); if(jnzw(0x19_ddd5, 0x14)) goto l_0x19_ddd5; /* jnz 0xddd5 */
            ii(0x19_ddc1, 4); cmp(si, memw_a16[es, bx + 0x16]);         /* cmp si, [es:bx+0x16] */
            ii(0x19_ddc5, 2); if(jnzw(0x19_ddd5, 0xe)) goto l_0x19_ddd5; /* jnz 0xddd5 */
            ii(0x19_ddc7, 4); mov(ax, memw_a16[es, bx + 0x2c]);         /* mov ax, [es:bx+0x2c] */
            ii(0x19_ddcb, 4); mov(dx, memw_a16[es, bx + 0x2e]);         /* mov dx, [es:bx+0x2e] */
        l_0x19_ddcf:
            ii(0x19_ddcf, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x19_ddd2, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
        l_0x19_ddd5:
            ii(0x19_ddd5, 3); mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x19_ddd8, 3); mov(dx, memw_a16[ss, bp - 0xc]);          /* mov dx, [bp-0xc] */
            ii(0x19_dddb, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x19_ddde, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_dde1, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x19_dde5, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x19_dde8, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_ddeb, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_ddee, 6); mov(memw_a16[es, bx + 0x2], 0);           /* mov word [es:bx+0x2], 0x0 */
            ii(0x19_ddf4, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x19_ddf7, 1); popw(si);                                 /* pop si */
            ii(0x19_ddf8, 1); popw(di);                                 /* pop di */
            ii(0x19_ddf9, 1); leavew();                                 /* leave */
            ii(0x19_ddfa, 3); retw(0x14); return;                       /* ret 0x14 */
        }
    }
}
