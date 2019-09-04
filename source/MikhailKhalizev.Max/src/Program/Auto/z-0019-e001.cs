using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e001-89fb8de6")]
        public void Method_0019_e001()
        {
            ii(0x19_e001, 4); enter(0x4e, 0);                           /* enter 0x4e, 0x0 */
            ii(0x19_e005, 1); push(di);                                 /* push di */
            ii(0x19_e006, 1); push(si);                                 /* push si */
            ii(0x19_e007, 1); push(ds);                                 /* push ds */
            ii(0x19_e008, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_e00b, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_e00d, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x19_e010, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x19_e013, 2); mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x19_e015, 5); call_far_abs(0x80, 0x4324);               /* call word 0x80:0x4324 */
            ii(0x19_e01a, 3); mov(memw[ss, bp - 70], ax);               /* mov [bp-0x46], ax */
            ii(0x19_e01d, 3); mov(memw[ss, bp - 68], dx);               /* mov [bp-0x44], dx */
            ii(0x19_e020, 3); lea(ax, memw[ss, bp - 50]);               /* lea ax, [bp-0x32] */
            ii(0x19_e023, 1); push(ss);                                 /* push ss */
            ii(0x19_e024, 1); push(ax);                                 /* push ax */
            ii(0x19_e025, 3); call(0x19_e2de, 0x2b6);                   /* call 0xe2de */
            ii(0x19_e028, 4); inc(memb[ds, 0x2bf2]);                    /* inc byte [0x2bf2] */
            ii(0x19_e02c, 4); cmp(memw[ss, bp + 20], 0);                /* cmp word [bp+0x14], 0x0 */
            ii(0x19_e030, 2); if(jz(0x19_e04d, 0x1b)) goto l_0x19_e04d; /* jz 0xe04d */
            ii(0x19_e032, 4); test(memb[ss, bp + 22], 0x40);            /* test byte [bp+0x16], 0x40 */
            ii(0x19_e036, 2); if(jnz(0x19_e03b, 3)) goto l_0x19_e03b;   /* jnz 0xe03b */
            ii(0x19_e038, 3); jmp(0x19_e28d, 0x252); goto l_0x19_e28d;  /* jmp 0xe28d */
        l_0x19_e03b:
            ii(0x19_e03b, 3); lea(ax, memw[ss, bp - 50]);               /* lea ax, [bp-0x32] */
            ii(0x19_e03e, 1); push(ss);                                 /* push ss */
            ii(0x19_e03f, 1); push(ax);                                 /* push ax */
            ii(0x19_e040, 3); call(0x19_e33a, 0x2f7);                   /* call 0xe33a */
            ii(0x19_e043, 4); dec(memb[ds, 0x2bf2]);                    /* dec byte [0x2bf2] */
            ii(0x19_e047, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_e04a, 3); jmp(0x19_e29b, 0x24e); goto l_0x19_e29b;  /* jmp 0xe29b */
        l_0x19_e04d:
            ii(0x19_e04d, 5); mov(memw[ss, bp - 52], 0);                /* mov word [bp-0x34], 0x0 */
            ii(0x19_e052, 3); jmp(0x19_e265, 0x210); goto l_0x19_e265;  /* jmp 0xe265 */
        l_0x19_e055:
            ii(0x19_e055, 4); imul(bx, si, 0x134);                      /* imul bx, si, 0x134 */
            ii(0x19_e059, 4); add(bx, memw[ds, 0x1f1a]);                /* add bx, [0x1f1a] */
            ii(0x19_e05d, 3); add(bx, 0x12);                            /* add bx, 0x12 */
            ii(0x19_e060, 3); mov(memw[ss, bp + 16], bx);               /* mov [bp+0x10], bx */
            ii(0x19_e063, 3); mov(memw[ss, bp + 18], es);               /* mov [bp+0x12], es */
            ii(0x19_e066, 4); mov(ax, memw[es, bx + 60]);               /* mov ax, [es:bx+0x3c] */
            ii(0x19_e06a, 4); mov(dx, memw[es, bx + 62]);               /* mov dx, [es:bx+0x3e] */
            ii(0x19_e06e, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x19_e071, 3); mov(memw[ss, bp - 14], dx);               /* mov [bp-0xe], dx */
            ii(0x19_e074, 5); mov(memw[ss, bp - 54], 0);                /* mov word [bp-0x36], 0x0 */
            ii(0x19_e079, 3); jmp(0x19_e223, 0x1a7); goto l_0x19_e223;  /* jmp 0xe223 */
        l_0x19_e07c:
            ii(0x19_e07c, 4); imul(si, memw[ss, bp - 54], 0x18);        /* imul si, [bp-0x36], 0x18 */
            ii(0x19_e080, 3); mov(bx, memw[ss, bp - 16]);               /* mov bx, [bp-0x10] */
            ii(0x19_e083, 4); mov(ax, memw[es, bx + si + 4]);           /* mov ax, [es:bx+si+0x4] */
            ii(0x19_e087, 4); mov(dx, memw[es, bx + si + 6]);           /* mov dx, [es:bx+si+0x6] */
        l_0x19_e08b:
            ii(0x19_e08b, 3); mov(memw[ss, bp - 66], ax);               /* mov [bp-0x42], ax */
            ii(0x19_e08e, 3); mov(memw[ss, bp - 64], dx);               /* mov [bp-0x40], dx */
            ii(0x19_e091, 3); mov(ax, memw[ss, bp - 70]);               /* mov ax, [bp-0x46] */
            ii(0x19_e094, 3); mov(dx, memw[ss, bp - 68]);               /* mov dx, [bp-0x44] */
            ii(0x19_e097, 3); cmp(memw[ss, bp - 64], dx);               /* cmp [bp-0x40], dx */
            ii(0x19_e09a, 2); if(jbe(0x19_e09f, 3)) goto l_0x19_e09f;   /* jbe 0xe09f */
            ii(0x19_e09c, 3); jmp(0x19_e220, 0x181); goto l_0x19_e220;  /* jmp 0xe220 */
        l_0x19_e09f:
            ii(0x19_e09f, 2); if(jb(0x19_e0a6, 5)) goto l_0x19_e0a6;    /* jb 0xe0a6 */
            ii(0x19_e0a1, 3); cmp(memw[ss, bp - 66], ax);               /* cmp [bp-0x42], ax */
            ii(0x19_e0a4, 2); if(ja(0x19_e0be, 0x18)) goto l_0x19_e0be; /* ja 0xe0be */
        l_0x19_e0a6:
            ii(0x19_e0a6, 4); imul(bx, memw[ss, bp - 54], 0x18);        /* imul bx, [bp-0x36], 0x18 */
            ii(0x19_e0aa, 3); les(si, memw[ss, bp - 16]);               /* les si, [bp-0x10] */
            ii(0x19_e0ad, 3); mov(cx, memw[es, bx + si]);               /* mov cx, [es:bx+si] */
            ii(0x19_e0b0, 4); mov(di, memw[es, bx + si + 2]);           /* mov di, [es:bx+si+0x2] */
            ii(0x19_e0b4, 3); add(cx, memw[ss, bp - 66]);               /* add cx, [bp-0x42] */
            ii(0x19_e0b7, 3); adc(di, memw[ss, bp - 64]);               /* adc di, [bp-0x40] */
            ii(0x19_e0ba, 2); cmp(di, dx);                              /* cmp di, dx */
            ii(0x19_e0bc, 2); if(jae(0x19_e0c1, 3)) goto l_0x19_e0c1;   /* jae 0xe0c1 */
        l_0x19_e0be:
            ii(0x19_e0be, 3); jmp(0x19_e220, 0x15f); goto l_0x19_e220;  /* jmp 0xe220 */
        l_0x19_e0c1:
            ii(0x19_e0c1, 2); if(ja(0x19_e0ca, 7)) goto l_0x19_e0ca;    /* ja 0xe0ca */
            ii(0x19_e0c3, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x19_e0c5, 2); if(ja(0x19_e0ca, 3)) goto l_0x19_e0ca;    /* ja 0xe0ca */
            ii(0x19_e0c7, 3); jmp(0x19_e220, 0x156); goto l_0x19_e220;  /* jmp 0xe220 */
        l_0x19_e0ca:
            ii(0x19_e0ca, 3); push(memw[ss, bp + 18]);                  /* push word [bp+0x12] */
            ii(0x19_e0cd, 3); push(memw[ss, bp + 16]);                  /* push word [bp+0x10] */
            ii(0x19_e0d0, 3); push(memw[ss, bp - 54]);                  /* push word [bp-0x36] */
            ii(0x19_e0d3, 3); sub(ax, memw[ss, bp - 66]);               /* sub ax, [bp-0x42] */
            ii(0x19_e0d6, 3); sbb(dx, memw[ss, bp - 64]);               /* sbb dx, [bp-0x40] */
            ii(0x19_e0d9, 2); mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x19_e0db, 5); call_far_abs(0x80, 0x4378);               /* call word 0x80:0x4378 */
            ii(0x19_e0e0, 3); mov(memw[ss, bp - 56], ax);               /* mov [bp-0x38], ax */
            ii(0x19_e0e3, 1); push(ax);                                 /* push ax */
            ii(0x19_e0e4, 3); lea(cx, memw[ss, bp - 74]);               /* lea cx, [bp-0x4a] */
            ii(0x19_e0e7, 1); push(ss);                                 /* push ss */
            ii(0x19_e0e8, 1); push(cx);                                 /* push cx */
            ii(0x19_e0e9, 3); lea(dx, memw[ss, bp - 60]);               /* lea dx, [bp-0x3c] */
            ii(0x19_e0ec, 1); push(ss);                                 /* push ss */
            ii(0x19_e0ed, 1); push(dx);                                 /* push dx */
            ii(0x19_e0ee, 3); lea(bx, memw[ss, bp - 78]);               /* lea bx, [bp-0x4e] */
            ii(0x19_e0f1, 1); push(ss);                                 /* push ss */
            ii(0x19_e0f2, 1); push(bx);                                 /* push bx */
            ii(0x19_e0f3, 3); call(0x19_dc78, -0x47e);                  /* call 0xdc78 */
            ii(0x19_e0f6, 3); push(memw[ss, bp - 58]);                  /* push word [bp-0x3a] */
            ii(0x19_e0f9, 3); push(memw[ss, bp - 60]);                  /* push word [bp-0x3c] */
            ii(0x19_e0fc, 3); push(memw[ss, bp - 56]);                  /* push word [bp-0x38] */
            ii(0x19_e0ff, 3); push(memw[ss, bp - 54]);                  /* push word [bp-0x36] */
            ii(0x19_e102, 3); mov(ax, memw[ss, bp + 16]);               /* mov ax, [bp+0x10] */
            ii(0x19_e105, 3); mov(dx, memw[ss, bp + 18]);               /* mov dx, [bp+0x12] */
            ii(0x19_e108, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x19_e10b, 1); push(dx);                                 /* push dx */
            ii(0x19_e10c, 1); push(ax);                                 /* push ax */
            ii(0x19_e10d, 3); push(memw[ss, bp - 68]);                  /* push word [bp-0x44] */
            ii(0x19_e110, 3); push(memw[ss, bp - 70]);                  /* push word [bp-0x46] */
            ii(0x19_e113, 1); push(ds);                                 /* push ds */
            ii(0x19_e114, 3); push(0x2bf3);                             /* push 0x2bf3 */
            ii(0x19_e117, 3); call(0x1a_1066, 0x2f4c);                  /* call 0x1066 */
            ii(0x19_e11a, 3); add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0x19_e11d, 3); les(bx, memw[ss, bp + 16]);               /* les bx, [bp+0x10] */
            ii(0x19_e120, 4); mov(ax, memw[es, bx + 56]);               /* mov ax, [es:bx+0x38] */
            ii(0x19_e124, 4); mov(dx, memw[es, bx + 58]);               /* mov dx, [es:bx+0x3a] */
            ii(0x19_e128, 3); add(ax, 6);                               /* add ax, 0x6 */
            ii(0x19_e12b, 1); push(dx);                                 /* push dx */
            ii(0x19_e12c, 1); push(ax);                                 /* push ax */
            ii(0x19_e12d, 3); call(0x19_e33a, 0x20a);                   /* call 0xe33a */
            ii(0x19_e130, 2); push(0);                                  /* push 0x0 */
            ii(0x19_e132, 3); push(memw[ss, bp - 58]);                  /* push word [bp-0x3a] */
            ii(0x19_e135, 3); push(memw[ss, bp - 60]);                  /* push word [bp-0x3c] */
            ii(0x19_e138, 3); les(bx, memw[ss, bp + 16]);               /* les bx, [bp+0x10] */
            ii(0x19_e13b, 4); les(si, memw[es, bx + 56]);               /* les si, [es:bx+0x38] */
            ii(0x19_e13f, 4); push(memw[es, si + 4]);                   /* push word [es:si+0x4] */
            ii(0x19_e143, 3); push(memw[ss, bp - 68]);                  /* push word [bp-0x44] */
            ii(0x19_e146, 3); push(memw[ss, bp - 70]);                  /* push word [bp-0x46] */
            ii(0x19_e149, 4); call_far_ind(memw[ds, 0x1a08]);           /* call far word [0x1a08] */
            ii(0x19_e14d, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_e150, 3); les(bx, memw[ss, bp + 16]);               /* les bx, [bp+0x10] */
            ii(0x19_e153, 4); mov(ax, memw[es, bx + 84]);               /* mov ax, [es:bx+0x54] */
            ii(0x19_e157, 4); mov(dx, memw[es, bx + 86]);               /* mov dx, [es:bx+0x56] */
            ii(0x19_e15b, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_e15e, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x19_e161, 3); mov(si, memw[ss, bp - 78]);               /* mov si, [bp-0x4e] */
            ii(0x19_e164, 3); shl(si, 3);                               /* shl si, 0x3 */
            ii(0x19_e167, 2); add(si, ax);                              /* add si, ax */
            ii(0x19_e169, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_e16b, 4); mov(ax, memw[es, si + 4]);                /* mov ax, [es:si+0x4] */
            ii(0x19_e16f, 4); mov(dx, memw[es, si + 6]);                /* mov dx, [es:si+0x6] */
            ii(0x19_e173, 3); sub(ax, memw[es, si]);                    /* sub ax, [es:si] */
            ii(0x19_e176, 4); sbb(dx, memw[es, si + 2]);                /* sbb dx, [es:si+0x2] */
            ii(0x19_e17a, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x19_e17d, 3); mov(memw[ss, bp - 10], dx);               /* mov [bp-0xa], dx */
            ii(0x19_e180, 3); mov(es, memw[ss, bp + 18]);               /* mov es, [bp+0x12] */
            ii(0x19_e183, 4); mov(ax, memw[es, bx + 72]);               /* mov ax, [es:bx+0x48] */
            ii(0x19_e187, 4); mov(dx, memw[es, bx + 74]);               /* mov dx, [es:bx+0x4a] */
            ii(0x19_e18b, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_e18e, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_e191, 4); push(memw[ds, 0x19fc]);                   /* push word [0x19fc] */
            ii(0x19_e195, 3); push(memw[ss, bp - 68]);                  /* push word [bp-0x44] */
            ii(0x19_e198, 3); push(memw[ss, bp - 70]);                  /* push word [bp-0x46] */
            ii(0x19_e19b, 3); push(0x1000);                             /* push 0x1000 */
            ii(0x19_e19e, 3); call(0x19_e2a0, 0xff);                    /* call 0xe2a0 */
            ii(0x19_e1a1, 4); cmp(memw[ss, bp - 72], 0);                /* cmp word [bp-0x48], 0x0 */
            ii(0x19_e1a5, 2); if(jnz(0x19_e1ca, 0x23)) goto l_0x19_e1ca; /* jnz 0xe1ca */
            ii(0x19_e1a7, 5); cmp(memw[ss, bp - 74], 0x1000);           /* cmp word [bp-0x4a], 0x1000 */
            ii(0x19_e1ac, 2); if(jae(0x19_e1ca, 0x1c)) goto l_0x19_e1ca; /* jae 0xe1ca */
            ii(0x19_e1ae, 2); push(0);                                  /* push 0x0 */
            ii(0x19_e1b0, 3); mov(ax, 0x1000);                          /* mov ax, 0x1000 */
            ii(0x19_e1b3, 3); mov(cx, memw[ss, bp - 74]);               /* mov cx, [bp-0x4a] */
            ii(0x19_e1b6, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x19_e1b8, 1); push(ax);                                 /* push ax */
            ii(0x19_e1b9, 4); add(cx, memw[ds, 0x19fa]);                /* add cx, [0x19fa] */
            ii(0x19_e1bd, 3); mov(ax, memw[ds, 0x19fc]);                /* mov ax, [0x19fc] */
            ii(0x19_e1c0, 1); push(ax);                                 /* push ax */
            ii(0x19_e1c1, 1); push(cx);                                 /* push cx */
            ii(0x19_e1c2, 1); nop();                                    /* nop */
            ii(0x19_e1c3, 1); push(cs);                                 /* push cs */
            ii(0x19_e1c4, 3); call(0x1a_0faf, 0x2de8);                  /* call 0xfaf */
            ii(0x19_e1c7, 3); add(sp, 8);                               /* add sp, 0x8 */
        l_0x19_e1ca:
            ii(0x19_e1ca, 4); push(memw[ds, 0x19f8]);                   /* push word [0x19f8] */
            ii(0x19_e1ce, 3); mov(bx, memw[ss, bp - 78]);               /* mov bx, [bp-0x4e] */
            ii(0x19_e1d1, 3); shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x19_e1d4, 3); les(si, memw[ss, bp - 8]);                /* les si, [bp-0x8] */
            ii(0x19_e1d7, 3); mov(ax, memw[es, bx + si]);               /* mov ax, [es:bx+si] */
            ii(0x19_e1da, 4); mov(dx, memw[es, bx + si + 2]);           /* mov dx, [es:bx+si+0x2] */
            ii(0x19_e1de, 3); add(ax, memw[ss, bp - 4]);                /* add ax, [bp-0x4] */
            ii(0x19_e1e1, 3); adc(dx, memw[ss, bp - 2]);                /* adc dx, [bp-0x2] */
            ii(0x19_e1e4, 1); push(dx);                                 /* push dx */
            ii(0x19_e1e5, 1); push(ax);                                 /* push ax */
            ii(0x19_e1e6, 3); push(memw[ss, bp - 12]);                  /* push word [bp-0xc] */
            ii(0x19_e1e9, 3); call(0x19_e2a0, 0xb4);                    /* call 0xe2a0 */
            ii(0x19_e1ec, 3); push(memw[ss, bp + 18]);                  /* push word [bp+0x12] */
            ii(0x19_e1ef, 3); push(memw[ss, bp + 16]);                  /* push word [bp+0x10] */
            ii(0x19_e1f2, 4); push(memw[ds, 0x19f8]);                   /* push word [0x19f8] */
            ii(0x19_e1f6, 4); push(memw[ds, 0x19f6]);                   /* push word [0x19f6] */
            ii(0x19_e1fa, 3); push(memw[ss, bp - 10]);                  /* push word [bp-0xa] */
            ii(0x19_e1fd, 3); push(memw[ss, bp - 12]);                  /* push word [bp-0xc] */
            ii(0x19_e200, 4); push(memw[ds, 0x19fc]);                   /* push word [0x19fc] */
            ii(0x19_e204, 4); push(memw[ds, 0x19fa]);                   /* push word [0x19fa] */
            ii(0x19_e208, 3); mov(ax, memw[ss, bp - 70]);               /* mov ax, [bp-0x46] */
            ii(0x19_e20b, 3); mov(dx, memw[ss, bp - 68]);               /* mov dx, [bp-0x44] */
            ii(0x19_e20e, 4); sub(ax, memw[ds, 0x19ea]);                /* sub ax, [0x19ea] */
            ii(0x19_e212, 4); sbb(dx, memw[ds, 0x19ec]);                /* sbb dx, [0x19ec] */
            ii(0x19_e216, 1); push(dx);                                 /* push dx */
            ii(0x19_e217, 1); push(ax);                                 /* push ax */
            ii(0x19_e218, 3); call(0x19_bbb4, -0x2667);                 /* call 0xbbb4 */
            ii(0x19_e21b, 3); mov(memw[ss, bp - 62], ax);               /* mov [bp-0x3e], ax */
            ii(0x19_e21e, 2); jmp(0x19_e28d, 0x6d); goto l_0x19_e28d;   /* jmp 0xe28d */
        l_0x19_e220:
            ii(0x19_e220, 3); inc(memw[ss, bp - 54]);                   /* inc word [bp-0x36] */
        l_0x19_e223:
            ii(0x19_e223, 3); mov(ax, memw[ss, bp - 54]);               /* mov ax, [bp-0x36] */
            ii(0x19_e226, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_e228, 3); les(bx, memw[ss, bp + 16]);               /* les bx, [bp+0x10] */
            ii(0x19_e22b, 4); les(bx, memw[es, bx + 28]);               /* les bx, [es:bx+0x1c] */
            ii(0x19_e22f, 4); cmp(memw[es, bx + 70], dx);               /* cmp [es:bx+0x46], dx */
            ii(0x19_e233, 2); if(jb(0x19_e262, 0x2d)) goto l_0x19_e262; /* jb 0xe262 */
            ii(0x19_e235, 2); if(ja(0x19_e23d, 6)) goto l_0x19_e23d;    /* ja 0xe23d */
            ii(0x19_e237, 4); cmp(memw[es, bx + 68], ax);               /* cmp [es:bx+0x44], ax */
            ii(0x19_e23b, 2); if(jbe(0x19_e262, 0x25)) goto l_0x19_e262; /* jbe 0xe262 */
        l_0x19_e23d:
            ii(0x19_e23d, 3); imul(bx, ax, 0x18);                       /* imul bx, ax, 0x18 */
            ii(0x19_e240, 3); add(bx, memw[ss, bp - 16]);               /* add bx, [bp-0x10] */
            ii(0x19_e243, 3); mov(es, memw[ss, bp - 14]);               /* mov es, [bp-0xe] */
            ii(0x19_e246, 5); test(memb[es, bx + 9], 0x10);             /* test byte [es:bx+0x9], 0x10 */
            ii(0x19_e24b, 2); if(jnz(0x19_e250, 3)) goto l_0x19_e250;   /* jnz 0xe250 */
            ii(0x19_e24d, 3); jmp(0x19_e07c, -0x1d4); goto l_0x19_e07c; /* jmp 0xe07c */
        l_0x19_e250:
            ii(0x19_e250, 4); mov(ax, memw[es, bx + 20]);               /* mov ax, [es:bx+0x14] */
            ii(0x19_e254, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_e256, 1); push(ax);                                 /* push ax */
            ii(0x19_e257, 1); push(cx);                                 /* push cx */
            ii(0x19_e258, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_e25d, 1); pop(bx);                                  /* pop bx */
            ii(0x19_e25e, 1); pop(bx);                                  /* pop bx */
            ii(0x19_e25f, 3); jmp(0x19_e08b, -0x1d7); goto l_0x19_e08b; /* jmp 0xe08b */
        l_0x19_e262:
            ii(0x19_e262, 3); inc(memw[ss, bp - 52]);                   /* inc word [bp-0x34] */
        l_0x19_e265:
            ii(0x19_e265, 4); cmp(memw[ss, bp - 52], 0x10);             /* cmp word [bp-0x34], 0x10 */
            ii(0x19_e269, 2); if(ja(0x19_e28d, 0x22)) goto l_0x19_e28d; /* ja 0xe28d */
            ii(0x19_e26b, 3); mov(bx, memw[ss, bp - 52]);               /* mov bx, [bp-0x34] */
            ii(0x19_e26e, 2); shl(bx, 1);                               /* shl bx, 1 */
            ii(0x19_e270, 5); cmp(memw[ds, bx + 0x1f24], 0);            /* cmp word [bx+0x1f24], 0x0 */
            ii(0x19_e275, 2); if(jz(0x19_e262, -0x15)) goto l_0x19_e262; /* jz 0xe262 */
            ii(0x19_e277, 4); les(bx, memw[ds, 0x1f1a]);                /* les bx, [0x1f1a] */
            ii(0x19_e27b, 4); add(bx, 0x1352);                          /* add bx, 0x1352 */
            ii(0x19_e27f, 3); mov(si, memw[ss, bp - 52]);               /* mov si, [bp-0x34] */
            ii(0x19_e282, 4); cmp(memb[es, bx + si], 0);                /* cmp byte [es:bx+si], 0x0 */
            ii(0x19_e286, 2); if(jz(0x19_e28b, 3)) goto l_0x19_e28b;    /* jz 0xe28b */
            ii(0x19_e288, 3); jmp(0x19_e055, -0x236); goto l_0x19_e055; /* jmp 0xe055 */
        l_0x19_e28b:
            ii(0x19_e28b, 2); jmp(0x19_e262, -0x2b); goto l_0x19_e262;  /* jmp 0xe262 */
        l_0x19_e28d:
            ii(0x19_e28d, 3); lea(ax, memw[ss, bp - 50]);               /* lea ax, [bp-0x32] */
            ii(0x19_e290, 1); push(ss);                                 /* push ss */
            ii(0x19_e291, 1); push(ax);                                 /* push ax */
            ii(0x19_e292, 3); call(0x19_e33a, 0xa5);                    /* call 0xe33a */
            ii(0x19_e295, 4); dec(memb[ds, 0x2bf2]);                    /* dec byte [0x2bf2] */
            ii(0x19_e299, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_e29b:
            ii(0x19_e29b, 1); pop(ds);                                  /* pop ds */
            ii(0x19_e29c, 1); pop(si);                                  /* pop si */
            ii(0x19_e29d, 1); pop(di);                                  /* pop di */
            ii(0x19_e29e, 1); leave();                                  /* leave */
            ii(0x19_e29f, 1); retf();                                   /* retf */
        }
    }
}
