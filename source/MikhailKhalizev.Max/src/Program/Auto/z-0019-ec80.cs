using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ec80-26271326")]
        public void Method_0019_ec80()
        {
            ii(0x19_ec80, 4);  enter(0x2e, 0);                         /* enter 0x2e, 0x0 */
            ii(0x19_ec84, 1);  push(di);                               /* push di */
            ii(0x19_ec85, 1);  push(si);                               /* push si */
            ii(0x19_ec86, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ec89, 4);  mov(ax, memw[es, bx + 40]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_ec8d, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x19_ec90, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ec93, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x19_ec97, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x19_ec9a, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ec9d, 4);  mov(ax, memw[es, bx + 36]);             /* mov ax, [es:bx+0x24] */
            ii(0x19_eca1, 3);  mov(memw[ss, bp - 40], ax);             /* mov [bp-0x28], ax */
            ii(0x19_eca4, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_eca7, 4);  mov(ax, memw[es, bx + 32]);             /* mov ax, [es:bx+0x20] */
            ii(0x19_ecab, 3);  mov(memw[ss, bp - 42], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_ecae, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ecb1, 4);  mov(ax, memw[es, bx + 6]);              /* mov ax, [es:bx+0x6] */
            ii(0x19_ecb5, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_ecb8, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x19_ecbb, 3);  jmp(0x19_ef87, 0x2c9); goto l_0x19_ef87;/* jmp 0xef87 */
        l_0x19_ecbe:
            ii(0x19_ecbe, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_ecc1, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_ecc6, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_ecc9, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_eccc, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_eccf, 2);  if(jnz(0x19_ecd4, 3)) goto l_0x19_ecd4; /* jnz 0xecd4 */
            ii(0x19_ecd1, 3);  jmp(0x19_ecf2, 0x1e); goto l_0x19_ecf2; /* jmp 0xecf2 */
        l_0x19_ecd4:
            ii(0x19_ecd4, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ecd7, 4);  push(memw[es, bx + 34]);                /* push word [es:bx+0x22] */
            ii(0x19_ecdb, 4);  push(memw[es, bx + 32]);                /* push word [es:bx+0x20] */
            ii(0x19_ecdf, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_ece2, 1);  nop();                                  /* nop */
            ii(0x19_ece3, 1);  push(cs);                               /* push cs */
            ii(0x19_ece4, 3);  call(0x19_789c, -0x744b);               /* call 0x789c */
            ii(0x19_ece7, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_ecea, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_eced, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
        l_0x19_ecf2:
            ii(0x19_ecf2, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x19_ecf5, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_ecf7, 1);  push(ax);                               /* push ax */
            ii(0x19_ecf8, 1);  push(cx);                               /* push cx */
            ii(0x19_ecf9, 5);  call_far_abs(0x80, 0x5066);             /* call word 0x80:0x5066 */
            ii(0x19_ecfe, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_ed01, 3);  sub(ax, memw[ss, bp - 42]);             /* sub ax, [bp-0x2a] */
            ii(0x19_ed04, 1);  inc(ax);                                /* inc ax */
            ii(0x19_ed05, 3);  mov(memw[ss, bp - 46], ax);             /* mov [bp-0x2e], ax */
            ii(0x19_ed08, 4);  cmp(memw[ss, bp - 46], 0);              /* cmp word [bp-0x2e], 0x0 */
            ii(0x19_ed0c, 2);  if(jnz(0x19_ed11, 3)) goto l_0x19_ed11; /* jnz 0xed11 */
            ii(0x19_ed0e, 3);  jmp(0x19_ed1a, 9); goto l_0x19_ed1a;    /* jmp 0xed1a */
        l_0x19_ed11:
            ii(0x19_ed11, 4);  cmp(memw[ss, bp - 46], 0x40);           /* cmp word [bp-0x2e], 0x40 */
            ii(0x19_ed15, 2);  if(ja(0x19_ed1a, 3)) goto l_0x19_ed1a;  /* ja 0xed1a */
            ii(0x19_ed17, 3);  jmp(0x19_ed1f, 5); goto l_0x19_ed1f;    /* jmp 0xed1f */
        l_0x19_ed1a:
            ii(0x19_ed1a, 5);  mov(memw[ss, bp - 46], 0x40);           /* mov word [bp-0x2e], 0x40 */
        l_0x19_ed1f:
            ii(0x19_ed1f, 3);  push(memw[ss, bp - 46]);                /* push word [bp-0x2e] */
            ii(0x19_ed22, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_ed25, 3);  mov(dx, memw[ss, bp - 32]);             /* mov dx, [bp-0x20] */
            ii(0x19_ed28, 1);  push(dx);                               /* push dx */
            ii(0x19_ed29, 1);  push(ax);                               /* push ax */
            ii(0x19_ed2a, 4);  push(memw[ds, 0x48fc]);                 /* push word [0x48fc] */
            ii(0x19_ed2e, 4);  push(memw[ds, 0x48fa]);                 /* push word [0x48fa] */
            ii(0x19_ed32, 5);  call_far_abs(0x80, 0x4d94);             /* call word 0x80:0x4d94 */
            ii(0x19_ed37, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ed3a, 4);  cmp(memw[ss, bp - 44], 0);              /* cmp word [bp-0x2c], 0x0 */
            ii(0x19_ed3e, 2);  if(jnz(0x19_ed43, 3)) goto l_0x19_ed43; /* jnz 0xed43 */
            ii(0x19_ed40, 3);  jmp(0x19_ed48, 5); goto l_0x19_ed48;    /* jmp 0xed48 */
        l_0x19_ed43:
            ii(0x19_ed43, 1);  nop();                                  /* nop */
            ii(0x19_ed44, 1);  push(cs);                               /* push cs */
            ii(0x19_ed45, 3);  call(0x19_78c6, -0x7482);               /* call 0x78c6 */
        l_0x19_ed48:
            ii(0x19_ed48, 5);  mov(memw[ss, bp - 12], 9);              /* mov word [bp-0xc], 0x9 */
            ii(0x19_ed4d, 3);  mov(ax, memw[ss, bp - 38]);             /* mov ax, [bp-0x26] */
            ii(0x19_ed50, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x19_ed53, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_ed56, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_ed59, 5);  mov(memw[ss, bp - 16], 0x20);           /* mov word [bp-0x10], 0x20 */
            ii(0x19_ed5e, 3);  mov(ax, memw[ds, 0x4900]);              /* mov ax, [0x4900] */
            ii(0x19_ed61, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_ed64, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x19_ed67, 1);  push(ss);                               /* push ss */
            ii(0x19_ed68, 1);  push(ax);                               /* push ax */
            ii(0x19_ed69, 1);  push(ss);                               /* push ss */
            ii(0x19_ed6a, 1);  push(ax);                               /* push ax */
            ii(0x19_ed6b, 2);  push(0x33);                             /* push 0x33 */
            ii(0x19_ed6d, 5);  call_far_abs(0x80, 0x570e);             /* call word 0x80:0x570e */
            ii(0x19_ed72, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ed75, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ed78, 3);  jmp(0x19_efd0, 0x255); goto l_0x19_efd0;/* jmp 0xefd0 */
        l_0x19_ed7b:
            ii(0x19_ed7b, 5);  cmp(memw[ds, 0x2e04], 0);               /* cmp word [0x2e04], 0x0 */
            ii(0x19_ed80, 2);  if(jz(0x19_ed85, 3)) goto l_0x19_ed85;  /* jz 0xed85 */
            ii(0x19_ed82, 3);  jmp(0x19_ed98, 0x13); goto l_0x19_ed98; /* jmp 0xed98 */
        l_0x19_ed85:
            ii(0x19_ed85, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ed88, 5);  or(memw[es, bx + 58], 1);               /* or word [es:bx+0x3a], 0x1 */
            ii(0x19_ed8d, 5);  or(memw[es, bx + 60], 0);               /* or word [es:bx+0x3c], 0x0 */
            ii(0x19_ed92, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ed95, 3);  jmp(0x19_efd0, 0x238); goto l_0x19_efd0;/* jmp 0xefd0 */
        l_0x19_ed98:
            ii(0x19_ed98, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_ed9b, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_eda0, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_eda3, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_eda6, 2);  if(jnz(0x19_edab, 3)) goto l_0x19_edab; /* jnz 0xedab */
            ii(0x19_eda8, 3);  jmp(0x19_edd1, 0x26); goto l_0x19_edd1; /* jmp 0xedd1 */
        l_0x19_edab:
            ii(0x19_edab, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_edae, 4);  mov(ax, memw[es, bx + 32]);             /* mov ax, [es:bx+0x20] */
            ii(0x19_edb2, 4);  mov(dx, memw[es, bx + 34]);             /* mov dx, [es:bx+0x22] */
            ii(0x19_edb6, 3);  mov(memw[ds, 0x2ddc], ax);              /* mov [0x2ddc], ax */
            ii(0x19_edb9, 4);  mov(memw[ds, 0x2dde], dx);              /* mov [0x2dde], dx */
            ii(0x19_edbd, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x19_edc0, 3);  mov(memw[ds, 0x2de0], ax);              /* mov [0x2de0], ax */
            ii(0x19_edc3, 6);  mov(memw[ds, 0x2de2], 0);               /* mov word [0x2de2], 0x0 */
            ii(0x19_edc9, 5);  mov(memb[ds, 0x2dc8], 1);               /* mov byte [0x2dc8], 0x1 */
            ii(0x19_edce, 3);  jmp(0x19_ede3, 0x12); goto l_0x19_ede3; /* jmp 0xede3 */
        l_0x19_edd1:
            ii(0x19_edd1, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x19_edd4, 3);  mov(cx, memw[ss, bp - 42]);             /* mov cx, [bp-0x2a] */
            ii(0x19_edd7, 4);  mov(memw[ds, 0x2dcc], cx);              /* mov [0x2dcc], cx */
            ii(0x19_eddb, 3);  mov(memw[ds, 0x2dce], ax);              /* mov [0x2dce], ax */
            ii(0x19_edde, 5);  mov(memb[ds, 0x2dc8], 0);               /* mov byte [0x2dc8], 0x0 */
        l_0x19_ede3:
            ii(0x19_ede3, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_ede6, 3);  mov(memw[ds, 0x2dfc], ax);              /* mov [0x2dfc], ax */
            ii(0x19_ede9, 5);  mov(memw[ss, bp - 12], 0xc);            /* mov word [bp-0xc], 0xc */
            ii(0x19_edee, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x19_edf1, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_edf4, 3);  mov(ax, memw[ds, 0x2e06]);              /* mov ax, [0x2e06] */
            ii(0x19_edf7, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_edfa, 3);  mov(ax, memw[ds, 0x2e04]);              /* mov ax, [0x2e04] */
            ii(0x19_edfd, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_ee00, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x19_ee03, 1);  push(ss);                               /* push ss */
            ii(0x19_ee04, 1);  push(ax);                               /* push ax */
            ii(0x19_ee05, 1);  push(ss);                               /* push ss */
            ii(0x19_ee06, 1);  push(ax);                               /* push ax */
            ii(0x19_ee07, 2);  push(0x33);                             /* push 0x33 */
            ii(0x19_ee09, 5);  call_far_abs(0x80, 0x570e);             /* call word 0x80:0x570e */
            ii(0x19_ee0e, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ee11, 4);  cmp(memw[ss, bp - 36], 0xc);            /* cmp word [bp-0x24], 0xc */
            ii(0x19_ee15, 2);  if(jz(0x19_ee1a, 3)) goto l_0x19_ee1a;  /* jz 0xee1a */
            ii(0x19_ee17, 3);  jmp(0x19_ee20, 6); goto l_0x19_ee20;    /* jmp 0xee20 */
        l_0x19_ee1a:
            ii(0x19_ee1a, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ee1d, 3);  jmp(0x19_efd0, 0x1b0); goto l_0x19_efd0;/* jmp 0xefd0 */
        l_0x19_ee20:
            ii(0x19_ee20, 3);  mov(ax, memw[ss, bp - 34]);             /* mov ax, [bp-0x22] */
            ii(0x19_ee23, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ee26, 4);  mov(memw[es, bx + 36], ax);             /* mov [es:bx+0x24], ax */
            ii(0x19_ee2a, 6);  mov(memw[es, bx + 38], 0);              /* mov word [es:bx+0x26], 0x0 */
            ii(0x19_ee30, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x19_ee33, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ee36, 4);  mov(memw[es, bx + 6], ax);              /* mov [es:bx+0x6], ax */
            ii(0x19_ee3a, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_ee3d, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ee40, 4);  mov(memw[es, bx + 32], ax);             /* mov [es:bx+0x20], ax */
            ii(0x19_ee44, 6);  mov(memw[es, bx + 34], 0);              /* mov word [es:bx+0x22], 0x0 */
            ii(0x19_ee4a, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ee4d, 3);  jmp(0x19_efd0, 0x180); goto l_0x19_efd0;/* jmp 0xefd0 */
        l_0x19_ee50:
            ii(0x19_ee50, 3);  mov(ax, memw[ds, 0x2dce]);              /* mov ax, [0x2dce] */
            ii(0x19_ee53, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_ee56, 3);  mov(ax, memw[ds, 0x2dcc]);              /* mov ax, [0x2dcc] */
            ii(0x19_ee59, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_ee5c, 3);  mov(ax, memw[ds, 0x2dfc]);              /* mov ax, [0x2dfc] */
            ii(0x19_ee5f, 3);  mov(memw[ss, bp - 34], ax);             /* mov [bp-0x22], ax */
            ii(0x19_ee62, 3);  jmp(0x19_ed7b, -0xea); goto l_0x19_ed7b;/* jmp 0xed7b */
        l_0x19_ee65:
            ii(0x19_ee65, 5);  mov(memw[ss, bp - 12], 0x16);           /* mov word [bp-0xc], 0x16 */
            ii(0x19_ee6a, 5);  mov(memw[ss, bp - 16], 0x20);           /* mov word [bp-0x10], 0x20 */
            ii(0x19_ee6f, 3);  mov(ax, memw[ds, 0x4900]);              /* mov ax, [0x4900] */
            ii(0x19_ee72, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_ee75, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x19_ee78, 1);  push(ss);                               /* push ss */
            ii(0x19_ee79, 1);  push(ax);                               /* push ax */
            ii(0x19_ee7a, 1);  push(ss);                               /* push ss */
            ii(0x19_ee7b, 1);  push(ax);                               /* push ax */
            ii(0x19_ee7c, 2);  push(0x33);                             /* push 0x33 */
            ii(0x19_ee7e, 5);  call_far_abs(0x80, 0x570e);             /* call word 0x80:0x570e */
            ii(0x19_ee83, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ee86, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_ee89, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_ee8e, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_ee91, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_ee94, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_ee97, 2);  if(jnz(0x19_ee9c, 3)) goto l_0x19_ee9c; /* jnz 0xee9c */
            ii(0x19_ee99, 3);  jmp(0x19_eeba, 0x1e); goto l_0x19_eeba; /* jmp 0xeeba */
        l_0x19_ee9c:
            ii(0x19_ee9c, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ee9f, 4);  push(memw[es, bx + 34]);                /* push word [es:bx+0x22] */
            ii(0x19_eea3, 4);  push(memw[es, bx + 32]);                /* push word [es:bx+0x20] */
            ii(0x19_eea7, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_eeaa, 1);  nop();                                  /* nop */
            ii(0x19_eeab, 1);  push(cs);                               /* push cs */
            ii(0x19_eeac, 3);  call(0x19_789c, -0x7613);               /* call 0x789c */
            ii(0x19_eeaf, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_eeb2, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_eeb5, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
        l_0x19_eeba:
            ii(0x19_eeba, 4);  push(memw[ds, 0x48f8]);                 /* push word [0x48f8] */
            ii(0x19_eebe, 4);  push(memw[ds, 0x48fc]);                 /* push word [0x48fc] */
            ii(0x19_eec2, 4);  push(memw[ds, 0x48fa]);                 /* push word [0x48fa] */
            ii(0x19_eec6, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_eec9, 3);  mov(dx, memw[ss, bp - 32]);             /* mov dx, [bp-0x20] */
            ii(0x19_eecc, 1);  push(dx);                               /* push dx */
            ii(0x19_eecd, 1);  push(ax);                               /* push ax */
            ii(0x19_eece, 5);  call_far_abs(0x80, 0x4d94);             /* call word 0x80:0x4d94 */
            ii(0x19_eed3, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_eed6, 4);  cmp(memw[ss, bp - 44], 0);              /* cmp word [bp-0x2c], 0x0 */
            ii(0x19_eeda, 2);  if(jnz(0x19_eedf, 3)) goto l_0x19_eedf; /* jnz 0xeedf */
            ii(0x19_eedc, 3);  jmp(0x19_eee4, 5); goto l_0x19_eee4;    /* jmp 0xeee4 */
        l_0x19_eedf:
            ii(0x19_eedf, 1);  nop();                                  /* nop */
            ii(0x19_eee0, 1);  push(cs);                               /* push cs */
            ii(0x19_eee1, 3);  call(0x19_78c6, -0x761e);               /* call 0x78c6 */
        l_0x19_eee4:
            ii(0x19_eee4, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_eee7, 3);  jmp(0x19_efd0, 0xe6); goto l_0x19_efd0; /* jmp 0xefd0 */
        l_0x19_eeea:
            ii(0x19_eeea, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_eeed, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_eef2, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_eef5, 3);  mov(memw[ss, bp - 44], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_eef8, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_eefb, 2);  if(jnz(0x19_ef00, 3)) goto l_0x19_ef00; /* jnz 0xef00 */
            ii(0x19_eefd, 3);  jmp(0x19_ef1e, 0x1e); goto l_0x19_ef1e; /* jmp 0xef1e */
        l_0x19_ef00:
            ii(0x19_ef00, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ef03, 4);  push(memw[es, bx + 34]);                /* push word [es:bx+0x22] */
            ii(0x19_ef07, 4);  push(memw[es, bx + 32]);                /* push word [es:bx+0x20] */
            ii(0x19_ef0b, 3);  push(memw[ss, bp - 32]);                /* push word [bp-0x20] */
            ii(0x19_ef0e, 1);  nop();                                  /* nop */
            ii(0x19_ef0f, 1);  push(cs);                               /* push cs */
            ii(0x19_ef10, 3);  call(0x19_789c, -0x7677);               /* call 0x789c */
            ii(0x19_ef13, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_ef16, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x19_ef19, 5);  mov(memw[ss, bp - 42], 0);              /* mov word [bp-0x2a], 0x0 */
        l_0x19_ef1e:
            ii(0x19_ef1e, 4);  push(memw[ds, 0x48f8]);                 /* push word [0x48f8] */
            ii(0x19_ef22, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x19_ef25, 3);  mov(dx, memw[ss, bp - 32]);             /* mov dx, [bp-0x20] */
            ii(0x19_ef28, 1);  push(dx);                               /* push dx */
            ii(0x19_ef29, 1);  push(ax);                               /* push ax */
            ii(0x19_ef2a, 4);  push(memw[ds, 0x48fc]);                 /* push word [0x48fc] */
            ii(0x19_ef2e, 4);  push(memw[ds, 0x48fa]);                 /* push word [0x48fa] */
            ii(0x19_ef32, 5);  call_far_abs(0x80, 0x4d94);             /* call word 0x80:0x4d94 */
            ii(0x19_ef37, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ef3a, 4);  cmp(memw[ss, bp - 44], 0);              /* cmp word [bp-0x2c], 0x0 */
            ii(0x19_ef3e, 2);  if(jnz(0x19_ef43, 3)) goto l_0x19_ef43; /* jnz 0xef43 */
            ii(0x19_ef40, 3);  jmp(0x19_ef48, 5); goto l_0x19_ef48;    /* jmp 0xef48 */
        l_0x19_ef43:
            ii(0x19_ef43, 1);  nop();                                  /* nop */
            ii(0x19_ef44, 1);  push(cs);                               /* push cs */
            ii(0x19_ef45, 3);  call(0x19_78c6, -0x7682);               /* call 0x78c6 */
        l_0x19_ef48:
            ii(0x19_ef48, 5);  mov(memw[ss, bp - 12], 0x17);           /* mov word [bp-0xc], 0x17 */
            ii(0x19_ef4d, 5);  mov(memw[ss, bp - 16], 0x20);           /* mov word [bp-0x10], 0x20 */
            ii(0x19_ef52, 3);  mov(ax, memw[ds, 0x4900]);              /* mov ax, [0x4900] */
            ii(0x19_ef55, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_ef58, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x19_ef5b, 1);  push(ss);                               /* push ss */
            ii(0x19_ef5c, 1);  push(ax);                               /* push ax */
            ii(0x19_ef5d, 1);  push(ss);                               /* push ss */
            ii(0x19_ef5e, 1);  push(ax);                               /* push ax */
            ii(0x19_ef5f, 2);  push(0x33);                             /* push 0x33 */
            ii(0x19_ef61, 5);  call_far_abs(0x80, 0x570e);             /* call word 0x80:0x570e */
            ii(0x19_ef66, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_ef69, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ef6c, 3);  jmp(0x19_efd0, 0x61); goto l_0x19_efd0; /* jmp 0xefd0 */
        l_0x19_ef6f:
            ii(0x19_ef6f, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_ef72, 6);  mov(memw[es, bx + 40], 0xffff);         /* mov word [es:bx+0x28], 0xffff */
            ii(0x19_ef78, 6);  mov(memw[es, bx + 42], 0);              /* mov word [es:bx+0x2a], 0x0 */
            ii(0x19_ef7e, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_ef81, 3);  jmp(0x19_efd0, 0x4c); goto l_0x19_efd0; /* jmp 0xefd0 */
        //  ii(0x19_ef84, 3);  jmp(0x19_efca, 0x43); goto l_0x19_efca; /* jmp 0xefca */
        l_0x19_ef87:
            ii(0x19_ef87, 3);  sub(ax, 9);                             /* sub ax, 0x9 */
            ii(0x19_ef8a, 3);  cmp(ax, 0x17);                          /* cmp ax, 0x17 */
            ii(0x19_ef8d, 2);  if(jbe(0x19_ef92, 3)) goto l_0x19_ef92; /* jbe 0xef92 */
            ii(0x19_ef8f, 3);  jmp(0x19_efca, 0x38); goto l_0x19_efca; /* jmp 0xefca */
        l_0x19_ef92:
            ii(0x19_ef92, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_ef94, 1);  xchg(bx, ax);                           /* xchg bx, ax */
            ii(0x19_ef95, 5);  
            switch (jmp_abs_switch(memw[cs, bx - 0x6486]))
            {
                case 0x19_ecbe:
                    goto l_0x19_ecbe;
                case 0x19_ed7b:
                    goto l_0x19_ed7b;
                case 0x19_ee50:
                    goto l_0x19_ee50;
                case 0x19_ee65:
                    goto l_0x19_ee65;
                case 0x19_eeea:
                    goto l_0x19_eeea;
                case 0x19_ef6f:
                    goto l_0x19_ef6f;
                case 0x19_efca:
                    goto l_0x19_efca;
                default:
                    throw new NotImplementedException();
            }/* jmp word [cs:bx-0x6486] */
        //  ii(0x19_ef9a, 48);  /* Служебная область с абсолютными адресами переходов. (0x19_ecbe, 0x19_efca, 0x19_efca, 0x19_ed7b, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_ee50, 0x19_efca, 0x19_ee65, 0x19_eeea, 0x19_ef6f, 0x19_ef6f, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_efca, 0x19_ef6f, 0x19_ef6f). */
        l_0x19_efca:
            ii(0x19_efca, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_efcd, 3);  jmp(0x19_efd0, 0); goto l_0x19_efd0;    /* jmp 0xefd0 */
        l_0x19_efd0:
            ii(0x19_efd0, 1);  pop(si);                                /* pop si */
            ii(0x19_efd1, 1);  pop(di);                                /* pop di */
            ii(0x19_efd2, 1);  leave();                                /* leave */
            ii(0x19_efd3, 1);  retf();                                 /* retf */
        }
    }
}
