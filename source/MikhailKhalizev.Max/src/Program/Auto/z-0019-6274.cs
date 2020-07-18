using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6274-30babdc1")]
        public void Method_0019_6274()
        {
            ii(0x19_6274, 4);  enter(0xe2, 0);                         /* enter 0xe2, 0x0 */
            ii(0x19_6278, 1);  push(di);                               /* push di */
            ii(0x19_6279, 1);  push(si);                               /* push si */
            ii(0x19_627a, 1);  push(ds);                               /* push ds */
            ii(0x19_627b, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_627e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_6280, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_6283, 4);  mov(ax, memw[es, bx + 40]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_6287, 4);  mov(dx, memw[es, bx + 42]);             /* mov dx, [es:bx+0x2a] */
            ii(0x19_628b, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x19_628d, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x19_628f, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x19_6291, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x19_6293, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6295, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_6298, 3);  mov(bx, memw[ss, bp - 4]);              /* mov bx, [bp-0x4] */
            ii(0x19_629b, 4);  mov(al, memb[ds, bx + 0x1456]);         /* mov al, [bx+0x1456] */
            ii(0x19_629f, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_62a1, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_62a4, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_62a7, 4);  push(memw[es, bx + 54]);                /* push word [es:bx+0x36] */
            ii(0x19_62ab, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_62b0, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_62b3, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_62b6, 2);  if(jnz(0x19_62bb, 3)) goto l_0x19_62bb; /* jnz 0x62bb */
            ii(0x19_62b8, 3);  jmp(0x19_62c4, 9); goto l_0x19_62c4;    /* jmp 0x62c4 */
        l_0x19_62bb:
            ii(0x19_62bb, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_62be, 3);  mov(dx, 0xffff);                        /* mov dx, 0xffff */
            ii(0x19_62c1, 3);  jmp(0x19_62ca, 6); goto l_0x19_62ca;    /* jmp 0x62ca */
        l_0x19_62c4:
            ii(0x19_62c4, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_62c7, 3);  mov(dx, 0);                             /* mov dx, 0x0 */
        l_0x19_62ca:
            ii(0x19_62ca, 3);  mov(memw[ss, bp - 22], ax);             /* mov [bp-0x16], ax */
            ii(0x19_62cd, 3);  mov(memw[ss, bp - 20], dx);             /* mov [bp-0x14], dx */
            ii(0x19_62d0, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x19_62d3, 3);  or(ax, memw[ss, bp - 22]);              /* or ax, [bp-0x16] */
            ii(0x19_62d6, 2);  if(jnz(0x19_62db, 3)) goto l_0x19_62db; /* jnz 0x62db */
            ii(0x19_62d8, 3);  jmp(0x19_62e4, 9); goto l_0x19_62e4;    /* jmp 0x62e4 */
        l_0x19_62db:
            ii(0x19_62db, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
            ii(0x19_62de, 3);  mov(dx, 0xffff);                        /* mov dx, 0xffff */
            ii(0x19_62e1, 3);  jmp(0x19_62ea, 6); goto l_0x19_62ea;    /* jmp 0x62ea */
        l_0x19_62e4:
            ii(0x19_62e4, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
            ii(0x19_62e7, 3);  mov(dx, 0);                             /* mov dx, 0x0 */
        l_0x19_62ea:
            ii(0x19_62ea, 3);  mov(memw[ss, bp - 96], ax);             /* mov [bp-0x60], ax */
            ii(0x19_62ed, 3);  mov(memw[ss, bp - 94], dx);             /* mov [bp-0x5e], dx */
            ii(0x19_62f0, 4);  mov(es, memw[ds, 0x3f96]);              /* mov es, [0x3f96] */
            ii(0x19_62f4, 6);  cmp(memb[es, 0x308a], 0);               /* cmp byte [es:0x308a], 0x0 */
            ii(0x19_62fa, 2);  if(jnz(0x19_62ff, 3)) goto l_0x19_62ff; /* jnz 0x62ff */
            ii(0x19_62fc, 3);  jmp(0x19_6319, 0x1a); goto l_0x19_6319; /* jmp 0x6319 */
        l_0x19_62ff:
            ii(0x19_62ff, 6);  mov(memb[es, 0x308a], 0);               /* mov byte [es:0x308a], 0x0 */
            ii(0x19_6305, 5);  mov(memw[ss, bp - 4], 0x4c);            /* mov word [bp-0x4], 0x4c */
            ii(0x19_630a, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_630d, 6);  mov(memw[es, bx + 40], 0x4c01);         /* mov word [es:bx+0x28], 0x4c01 */
            ii(0x19_6313, 6);  mov(memw[es, bx + 42], 0);              /* mov word [es:bx+0x2a], 0x0 */
        l_0x19_6319:
            ii(0x19_6319, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x19_631c, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x19_631f, 1);  push(ds);                               /* push ds */
            ii(0x19_6320, 3);  lea(di, memw[ss, bp - 92]);             /* lea di, [bp-0x5c] */
            ii(0x19_6323, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_6325, 1);  push(ss);                               /* push ss */
            ii(0x19_6326, 1);  pop(es);                                /* pop es */
            ii(0x19_6327, 2);  mov(ds, dx);                            /* mov ds, dx */
            ii(0x19_6329, 3);  mov(cx, 0x1f);                          /* mov cx, 0x1f */
            ii(0x19_632c, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x19_632e, 1);  pop(ds);                                /* pop ds */
            ii(0x19_632f, 3);  mov(bx, memw[ss, bp - 4]);              /* mov bx, [bp-0x4] */
            ii(0x19_6332, 4);  mov(al, memb[ds, bx + 0x1356]);         /* mov al, [bx+0x1356] */
            ii(0x19_6336, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6338, 3);  jmp(0x19_77d5, 0x149a); goto l_0x19_77d5;/* jmp 0x77d5 */
        l_0x19_633b:
            ii(0x19_633b, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_633e, 1);  push(ss);                               /* push ss */
            ii(0x19_633f, 1);  push(ax);                               /* push ax */
            ii(0x19_6340, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_6343, 3);  if(call_up(0x19_61c1, -0x185)) return;  /* call 0x61c1 */
            ii(0x19_6346, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6349, 3);  jmp(0x19_7817, 0x14cb); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_634c:
            ii(0x19_634c, 5);  cmp(memw[ss, bp - 52], 0xff00);         /* cmp word [bp-0x34], 0xff00 */
            ii(0x19_6351, 2);  if(jz(0x19_6356, 3)) goto l_0x19_6356;  /* jz 0x6356 */
            ii(0x19_6353, 3);  jmp(0x19_6374, 0x1e); goto l_0x19_6374; /* jmp 0x6374 */
        l_0x19_6356:
            ii(0x19_6356, 4);  cmp(memw[ss, bp - 60], 0x78);           /* cmp word [bp-0x3c], 0x78 */
            ii(0x19_635a, 2);  if(jz(0x19_635f, 3)) goto l_0x19_635f;  /* jz 0x635f */
            ii(0x19_635c, 3);  jmp(0x19_6374, 0x15); goto l_0x19_6374; /* jmp 0x6374 */
        l_0x19_635f:
            ii(0x19_635f, 5);  mov(memw[ss, bp - 52], 0xffff);         /* mov word [bp-0x34], 0xffff */
            ii(0x19_6364, 5);  mov(memw[ss, bp - 50], 0x4734);         /* mov word [bp-0x32], 0x4734 */
            ii(0x19_6369, 4);  and(memw[ss, bp - 34], -2 /* 0xfe */);  /* and word [bp-0x22], 0xfffe */
            ii(0x19_636d, 4);  and(memw[ss, bp - 32], -1 /* 0xff */);  /* and word [bp-0x20], 0xffff */
            ii(0x19_6371, 3);  jmp(0x19_7817, 0x14a3); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6374:
            ii(0x19_6374, 5);  cmp(memb[ds, 0xd8a], 0);                /* cmp byte [0xd8a], 0x0 */
            ii(0x19_6379, 2);  if(jnz(0x19_637e, 3)) goto l_0x19_637e; /* jnz 0x637e */
            ii(0x19_637b, 3);  jmp(0x19_642d, 0xaf); goto l_0x19_642d; /* jmp 0x642d */
        l_0x19_637e:
            ii(0x19_637e, 4);  cmp(memb[ss, bp - 51], -1 /* 0xff */);  /* cmp byte [bp-0x33], 0xff */
            ii(0x19_6382, 2);  if(jz(0x19_6387, 3)) goto l_0x19_6387;  /* jz 0x6387 */
            ii(0x19_6384, 3);  jmp(0x19_642d, 0xa6); goto l_0x19_642d; /* jmp 0x642d */
        l_0x19_6387:
            ii(0x19_6387, 4);  cmp(memw[ss, bp - 60], 6);              /* cmp word [bp-0x3c], 0x6 */
            ii(0x19_638b, 2);  if(jz(0x19_6390, 3)) goto l_0x19_6390;  /* jz 0x6390 */
            ii(0x19_638d, 3);  jmp(0x19_63bc, 0x2c); goto l_0x19_63bc; /* jmp 0x63bc */
        l_0x19_6390:
            ii(0x19_6390, 3);  mov(al, memb[ss, bp - 60]);             /* mov al, [bp-0x3c] */
            ii(0x19_6393, 3);  mov(memb[ds, 0x1271], al);              /* mov [0x1271], al */
            ii(0x19_6396, 4);  and(memw[ss, bp - 52], 0);              /* and word [bp-0x34], 0x0 */
            ii(0x19_639a, 4);  and(memw[ss, bp - 50], -1 /* 0xff */);  /* and word [bp-0x32], 0xffff */
            ii(0x19_639e, 3);  mov(al, memb[ds, 0x1272]);              /* mov al, [0x1272] */
            ii(0x19_63a1, 1);  cbw();                                  /* cbw */
            ii(0x19_63a2, 1);  cwd();                                  /* cwd */
            ii(0x19_63a3, 3);  or(memw[ss, bp - 52], ax);              /* or [bp-0x34], ax */
            ii(0x19_63a6, 3);  or(memw[ss, bp - 50], dx);              /* or [bp-0x32], dx */
            ii(0x19_63a9, 4);  and(memw[ss, bp - 34], -2 /* 0xfe */);  /* and word [bp-0x22], 0xfffe */
            ii(0x19_63ad, 4);  and(memw[ss, bp - 32], -1 /* 0xff */);  /* and word [bp-0x20], 0xffff */
            ii(0x19_63b1, 5);  mov(memb[ds, 0x1272], 6);               /* mov byte [0x1272], 0x6 */
            ii(0x19_63b6, 3);  jmp(0x19_7817, 0x145e); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_63b9, 3);  Недостижимый код.
        l_0x19_63bc:
            ii(0x19_63bc, 4);  test(memb[ss, bp - 59], 0xff);          /* test byte [bp-0x3b], 0xff */
            ii(0x19_63c0, 2);  if(jz(0x19_63c5, 3)) goto l_0x19_63c5;  /* jz 0x63c5 */
            ii(0x19_63c2, 3);  jmp(0x19_642d, 0x68); goto l_0x19_642d; /* jmp 0x642d */
        l_0x19_63c5:
            ii(0x19_63c5, 3);  mov(al, memb[ss, bp - 60]);             /* mov al, [bp-0x3c] */
            ii(0x19_63c8, 3);  mov(memb[ds, 0x1272], al);              /* mov [0x1272], al */
            ii(0x19_63cb, 4);  mov(memb[ss, bp - 11], 0);              /* mov byte [bp-0xb], 0x0 */
            ii(0x19_63cf, 3);  mov(al, memb[ss, bp - 60]);             /* mov al, [bp-0x3c] */
            ii(0x19_63d2, 3);  mov(memb[ss, bp - 12], al);             /* mov [bp-0xc], al */
            ii(0x19_63d5, 4);  mov(memb[ss, bp - 17], 0xff);           /* mov byte [bp-0x11], 0xff */
            ii(0x19_63d9, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_63dc, 3);  mov(memw[ss, bp - 24], ax);             /* mov [bp-0x18], ax */
            ii(0x19_63df, 3);  mov(memw[ss, bp - 30], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_63e2, 3);  lea(ax, memw[ss, bp - 30]);             /* lea ax, [bp-0x1e] */
            ii(0x19_63e5, 1);  push(ss);                               /* push ss */
            ii(0x19_63e6, 1);  push(ax);                               /* push ax */
            ii(0x19_63e7, 3);  lea(ax, memw[ss, bp - 18]);             /* lea ax, [bp-0x12] */
            ii(0x19_63ea, 1);  push(ss);                               /* push ss */
            ii(0x19_63eb, 1);  push(ax);                               /* push ax */
            ii(0x19_63ec, 1);  push(ss);                               /* push ss */
            ii(0x19_63ed, 1);  push(ax);                               /* push ax */
            ii(0x19_63ee, 4);  call_far_ind(memw[ds, 0x1286]);         /* call far word [0x1286] */
            ii(0x19_63f2, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_63f5, 4);  and(memw[ss, bp - 52], 0);              /* and word [bp-0x34], 0x0 */
            ii(0x19_63f9, 4);  and(memw[ss, bp - 50], -1 /* 0xff */);  /* and word [bp-0x32], 0xffff */
            ii(0x19_63fd, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x19_6400, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6402, 3);  or(memw[ss, bp - 52], ax);              /* or [bp-0x34], ax */
            ii(0x19_6405, 3);  or(memw[ss, bp - 50], dx);              /* or [bp-0x32], dx */
            ii(0x19_6408, 5);  cmp(memb[ds, 0x1271], 0);               /* cmp byte [0x1271], 0x0 */
            ii(0x19_640d, 2);  if(jnz(0x19_6412, 3)) goto l_0x19_6412; /* jnz 0x6412 */
            ii(0x19_640f, 3);  jmp(0x19_642a, 0x18); goto l_0x19_642a; /* jmp 0x642a */
        l_0x19_6412:
            ii(0x19_6412, 4);  and(memw[ss, bp - 52], 0);              /* and word [bp-0x34], 0x0 */
            ii(0x19_6416, 4);  and(memw[ss, bp - 50], -1 /* 0xff */);  /* and word [bp-0x32], 0xffff */
            ii(0x19_641a, 3);  mov(al, memb[ds, 0x1271]);              /* mov al, [0x1271] */
            ii(0x19_641d, 1);  cbw();                                  /* cbw */
            ii(0x19_641e, 1);  cwd();                                  /* cwd */
            ii(0x19_641f, 3);  or(memw[ss, bp - 52], ax);              /* or [bp-0x34], ax */
            ii(0x19_6422, 3);  or(memw[ss, bp - 50], dx);              /* or [bp-0x32], dx */
            ii(0x19_6425, 5);  mov(memb[ds, 0x1271], 0);               /* mov byte [0x1271], 0x0 */
        l_0x19_642a:
            ii(0x19_642a, 3);  jmp(0x19_7817, 0x13ea); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_642d:
            ii(0x19_642d, 3);  jmp(0x19_633b, -0xf5); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6430:
            ii(0x19_6430, 4);  test(memb[ss, bp - 52], 1);             /* test byte [bp-0x34], 0x1 */
            ii(0x19_6434, 2);  if(jnz(0x19_6439, 3)) goto l_0x19_6439; /* jnz 0x6439 */
            ii(0x19_6436, 3);  jmp(0x19_643f, 6); goto l_0x19_643f;    /* jmp 0x643f */
        l_0x19_6439:
            ii(0x19_6439, 3);  jmp(0x19_633b, -0x101); goto l_0x19_633b;/* jmp 0x633b */
        //  ii(0x19_643c, 3);  Недостижимый код.
        l_0x19_643f:
            ii(0x19_643f, 3);  jmp(0x19_6442, 0); goto l_0x19_6442;    /* jmp 0x6442 */
        l_0x19_6442:
            ii(0x19_6442, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_6445, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_6448, 3);  and(ax, memw[ss, bp - 60]);             /* and ax, [bp-0x3c] */
            ii(0x19_644b, 3);  and(dx, memw[ss, bp - 58]);             /* and dx, [bp-0x3a] */
            ii(0x19_644e, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_6450, 2);  if(jnz(0x19_6455, 3)) goto l_0x19_6455; /* jnz 0x6455 */
            ii(0x19_6452, 3);  jmp(0x19_64c2, 0x6d); goto l_0x19_64c2; /* jmp 0x64c2 */
        l_0x19_6455:
            ii(0x19_6455, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_6458, 3);  mov(memw[ss, bp - 98], ax);             /* mov [bp-0x62], ax */
            ii(0x19_645b, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_645e, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_6461, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_6464, 3);  mov(memw[ss, bp - 100], dx);            /* mov [bp-0x64], dx */
            ii(0x19_6467, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_646a, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_646d, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_6470, 1);  nop();                                  /* nop */
            ii(0x19_6471, 1);  push(cs);                               /* push cs */
            ii(0x19_6472, 3);  call(0x19_789c, 0x1427);                /* call 0x789c */
            ii(0x19_6475, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6478, 3);  mov(memw[ss, bp - 104], ax);            /* mov [bp-0x68], ax */
            ii(0x19_647b, 3);  mov(ax, memw[ss, bp - 104]);            /* mov ax, [bp-0x68] */
            ii(0x19_647e, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_6481, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_6483, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_6486, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6489, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_648c, 1);  push(ss);                               /* push ss */
            ii(0x19_648d, 1);  push(ax);                               /* push ax */
            ii(0x19_648e, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_6491, 3);  call(0x19_61c1, -0x2d3);                /* call 0x61c1 */
            ii(0x19_6494, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6497, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_649b, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_649e, 3);  cmp(memw[ss, bp - 104], ax);            /* cmp [bp-0x68], ax */
            ii(0x19_64a1, 2);  if(jz(0x19_64a6, 3)) goto l_0x19_64a6;  /* jz 0x64a6 */
            ii(0x19_64a3, 3);  jmp(0x19_64ac, 6); goto l_0x19_64ac;    /* jmp 0x64ac */
        l_0x19_64a6:
            ii(0x19_64a6, 3);  mov(ax, memw[ss, bp - 98]);             /* mov ax, [bp-0x62] */
            ii(0x19_64a9, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
        l_0x19_64ac:
            ii(0x19_64ac, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_64af, 1);  cwd();                                  /* cwd */
            ii(0x19_64b0, 3);  add(ax, memw[ss, bp - 102]);            /* add ax, [bp-0x66] */
            ii(0x19_64b3, 3);  adc(dx, memw[ss, bp - 100]);            /* adc dx, [bp-0x64] */
            ii(0x19_64b6, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_64b9, 3);  mov(memw[ss, bp - 58], dx);             /* mov [bp-0x3a], dx */
            ii(0x19_64bc, 3);  jmp(0x19_7817, 0x1358); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_64bf, 3);  Недостижимый код.
        l_0x19_64c2:
            ii(0x19_64c2, 3);  jmp(0x19_633b, -0x18a); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_64c5:
            ii(0x19_64c5, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_64c8, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_64cb, 3);  and(ax, memw[ss, bp - 60]);             /* and ax, [bp-0x3c] */
            ii(0x19_64ce, 3);  and(dx, memw[ss, bp - 58]);             /* and dx, [bp-0x3a] */
            ii(0x19_64d1, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_64d3, 2);  if(jnz(0x19_64d8, 3)) goto l_0x19_64d8; /* jnz 0x64d8 */
            ii(0x19_64d5, 3);  jmp(0x19_654a, 0x72); goto l_0x19_654a; /* jmp 0x654a */
        l_0x19_64d8:
            ii(0x19_64d8, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_64db, 3);  mov(memw[ds, 0x4894], ax);              /* mov [0x4894], ax */
            ii(0x19_64de, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_64e1, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_64e4, 3);  mov(memw[ds, 0x4890], ax);              /* mov [0x4890], ax */
            ii(0x19_64e7, 4);  mov(memw[ds, 0x4892], dx);              /* mov [0x4892], dx */
            ii(0x19_64eb, 6);  mov(memw[ds, 0x489a], 1);               /* mov word [0x489a], 0x1 */
            ii(0x19_64f1, 4);  push(memw[ds, 0x4896]);                 /* push word [0x4896] */
            ii(0x19_64f5, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_64f8, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_64fb, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_64fe, 3);  call(0x19_78d4, 0x13d3);                /* call 0x78d4 */
            ii(0x19_6501, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_6504, 3);  mov(ax, memw[ds, 0x4896]);              /* mov ax, [0x4896] */
            ii(0x19_6507, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_650a, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_650c, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_650f, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6512, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_6515, 1);  push(ss);                               /* push ss */
            ii(0x19_6516, 1);  push(ax);                               /* push ax */
            ii(0x19_6517, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_651a, 3);  call(0x19_61c1, -0x35c);                /* call 0x61c1 */
            ii(0x19_651d, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6520, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_6523, 4);  cmp(memw[ds, 0x4896], ax);              /* cmp [0x4896], ax */
            ii(0x19_6527, 2);  if(jz(0x19_652c, 3)) goto l_0x19_652c;  /* jz 0x652c */
            ii(0x19_6529, 3);  jmp(0x19_6532, 6); goto l_0x19_6532;    /* jmp 0x6532 */
        l_0x19_652c:
            ii(0x19_652c, 3);  mov(ax, memw[ds, 0x4894]);              /* mov ax, [0x4894] */
            ii(0x19_652f, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
        l_0x19_6532:
            ii(0x19_6532, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_6535, 1);  cwd();                                  /* cwd */
            ii(0x19_6536, 4);  add(ax, memw[ds, 0x4890]);              /* add ax, [0x4890] */
            ii(0x19_653a, 4);  adc(dx, memw[ds, 0x4892]);              /* adc dx, [0x4892] */
            ii(0x19_653e, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6541, 3);  mov(memw[ss, bp - 58], dx);             /* mov [bp-0x3a], dx */
            ii(0x19_6544, 3);  jmp(0x19_7817, 0x12d0); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_6547, 3);  Недостижимый код.
        l_0x19_654a:
            ii(0x19_654a, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_654d, 4);  cmp(memw[ds, 0x4896], ax);              /* cmp [0x4896], ax */
            ii(0x19_6551, 2);  if(jnz(0x19_6556, 3)) goto l_0x19_6556; /* jnz 0x6556 */
            ii(0x19_6553, 3);  jmp(0x19_655c, 6); goto l_0x19_655c;    /* jmp 0x655c */
        l_0x19_6556:
            ii(0x19_6556, 6);  mov(memw[ds, 0x489a], 0);               /* mov word [0x489a], 0x0 */
        l_0x19_655c:
            ii(0x19_655c, 3);  jmp(0x19_633b, -0x224); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_655f:
            ii(0x19_655f, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_6562, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6564, 3);  mov(memw[ss, bp - 106], ax);            /* mov [bp-0x6a], ax */
            ii(0x19_6567, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_656a, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_656d, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_6570, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_6573, 3);  mov(memw[ss, bp - 110], ax);            /* mov [bp-0x6e], ax */
            ii(0x19_6576, 3);  mov(memw[ss, bp - 108], dx);            /* mov [bp-0x6c], dx */
            ii(0x19_6579, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_657c, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_6581, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6584, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6587, 2);  if(jz(0x19_658c, 3)) goto l_0x19_658c;  /* jz 0x658c */
            ii(0x19_6589, 3);  jmp(0x19_65ce, 0x42); goto l_0x19_65ce; /* jmp 0x65ce */
        l_0x19_658c:
            ii(0x19_658c, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_658f, 4);  cmp(memw[ds, 0x1280], ax);              /* cmp [0x1280], ax */
            ii(0x19_6593, 2);  if(jz(0x19_6598, 3)) goto l_0x19_6598;  /* jz 0x6598 */
            ii(0x19_6595, 3);  jmp(0x19_65ad, 0x15); goto l_0x19_65ad; /* jmp 0x65ad */
        l_0x19_6598:
            ii(0x19_6598, 3);  mov(ax, memw[ds, 0x127e]);              /* mov ax, [0x127e] */
            ii(0x19_659b, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_659d, 3);  cmp(ax, memw[ss, bp - 110]);            /* cmp ax, [bp-0x6e] */
            ii(0x19_65a0, 2);  if(jz(0x19_65a5, 3)) goto l_0x19_65a5;  /* jz 0x65a5 */
            ii(0x19_65a2, 3);  jmp(0x19_65ad, 8); goto l_0x19_65ad;    /* jmp 0x65ad */
        l_0x19_65a5:
            ii(0x19_65a5, 3);  cmp(dx, memw[ss, bp - 108]);            /* cmp dx, [bp-0x6c] */
            ii(0x19_65a8, 2);  if(jnz(0x19_65ad, 3)) goto l_0x19_65ad; /* jnz 0x65ad */
            ii(0x19_65aa, 3);  jmp(0x19_65ce, 0x21); goto l_0x19_65ce; /* jmp 0x65ce */
        l_0x19_65ad:
            ii(0x19_65ad, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_65b0, 4);  cmp(memw[ds, 0x1284], ax);              /* cmp [0x1284], ax */
            ii(0x19_65b4, 2);  if(jz(0x19_65b9, 3)) goto l_0x19_65b9;  /* jz 0x65b9 */
            ii(0x19_65b6, 3);  jmp(0x19_65d6, 0x1d); goto l_0x19_65d6; /* jmp 0x65d6 */
        l_0x19_65b9:
            ii(0x19_65b9, 3);  mov(ax, memw[ds, 0x1282]);              /* mov ax, [0x1282] */
            ii(0x19_65bc, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_65be, 3);  cmp(ax, memw[ss, bp - 110]);            /* cmp ax, [bp-0x6e] */
            ii(0x19_65c1, 2);  if(jz(0x19_65c6, 3)) goto l_0x19_65c6;  /* jz 0x65c6 */
            ii(0x19_65c3, 3);  jmp(0x19_65d6, 0x10); goto l_0x19_65d6; /* jmp 0x65d6 */
        l_0x19_65c6:
            ii(0x19_65c6, 3);  cmp(dx, memw[ss, bp - 108]);            /* cmp dx, [bp-0x6c] */
            ii(0x19_65c9, 2);  if(jz(0x19_65ce, 3)) goto l_0x19_65ce;  /* jz 0x65ce */
            ii(0x19_65cb, 3);  jmp(0x19_65d6, 8); goto l_0x19_65d6;    /* jmp 0x65d6 */
        l_0x19_65ce:
            ii(0x19_65ce, 5);  mov(memw[ss, bp - 104], 1);             /* mov word [bp-0x68], 0x1 */
            ii(0x19_65d3, 3);  jmp(0x19_65db, 5); goto l_0x19_65db;    /* jmp 0x65db */
        l_0x19_65d6:
            ii(0x19_65d6, 5);  mov(memw[ss, bp - 104], 0);             /* mov word [bp-0x68], 0x0 */
        l_0x19_65db:
            ii(0x19_65db, 4);  cmp(memw[ss, bp - 104], 0);             /* cmp word [bp-0x68], 0x0 */
            ii(0x19_65df, 2);  if(jz(0x19_65e4, 3)) goto l_0x19_65e4;  /* jz 0x65e4 */
            ii(0x19_65e1, 3);  jmp(0x19_65ef, 0xb); goto l_0x19_65ef;  /* jmp 0x65ef */
        l_0x19_65e4:
            ii(0x19_65e4, 3);  mov(ax, memw[ss, bp - 110]);            /* mov ax, [bp-0x6e] */
            ii(0x19_65e7, 3);  mov(memw[ss, bp - 110], ax);            /* mov [bp-0x6e], ax */
            ii(0x19_65ea, 5);  mov(memw[ss, bp - 108], 0);             /* mov word [bp-0x6c], 0x0 */
        l_0x19_65ef:
            ii(0x19_65ef, 4);  cmp(memw[ss, bp - 106], 7);             /* cmp word [bp-0x6a], 0x7 */
            ii(0x19_65f3, 2);  if(jnz(0x19_65f8, 3)) goto l_0x19_65f8; /* jnz 0x65f8 */
            ii(0x19_65f5, 3);  jmp(0x19_6601, 9); goto l_0x19_6601;    /* jmp 0x6601 */
        l_0x19_65f8:
            ii(0x19_65f8, 4);  cmp(memw[ss, bp - 106], 0x10);          /* cmp word [bp-0x6a], 0x10 */
            ii(0x19_65fc, 2);  if(jz(0x19_6601, 3)) goto l_0x19_6601;  /* jz 0x6601 */
            ii(0x19_65fe, 3);  jmp(0x19_6668, 0x67); goto l_0x19_6668; /* jmp 0x6668 */
        l_0x19_6601:
            ii(0x19_6601, 4);  cmp(memw[ss, bp - 106], 7);             /* cmp word [bp-0x6a], 0x7 */
            ii(0x19_6605, 2);  if(jz(0x19_660a, 3)) goto l_0x19_660a;  /* jz 0x660a */
            ii(0x19_6607, 3);  jmp(0x19_6649, 0x3f); goto l_0x19_6649; /* jmp 0x6649 */
        l_0x19_660a:
            ii(0x19_660a, 5);  call_far_abs(0x80, 0x51a8);             /* call word 0x80:0x51a8 */
            ii(0x19_660f, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6612, 2);  if(jz(0x19_6617, 3)) goto l_0x19_6617;  /* jz 0x6617 */
            ii(0x19_6614, 3);  jmp(0x19_6649, 0x32); goto l_0x19_6649; /* jmp 0x6649 */
        l_0x19_6617:
            ii(0x19_6617, 4);  mov(es, memw[ds, 0x3f94]);              /* mov es, [0x3f94] */
            ii(0x19_661b, 3);  mov(ax, 0x38);                          /* mov ax, 0x38 */
            ii(0x19_661e, 5);  mov(dx, memw[es, 0x3b74]);              /* mov dx, [es:0x3b74] */
            ii(0x19_6623, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_6626, 3);  mov(memw[ss, bp - 124], dx);            /* mov [bp-0x7c], dx */
            ii(0x19_6629, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_662c, 3);  les(bx, memw[ss, bp - 126]);            /* les bx, [bp-0x7e] */
            ii(0x19_662f, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_6633, 3);  mov(ax, memw[ss, bp - 110]);            /* mov ax, [bp-0x6e] */
            ii(0x19_6636, 3);  les(bx, memw[ss, bp - 126]);            /* les bx, [bp-0x7e] */
            ii(0x19_6639, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_663c, 3);  mov(ax, memw[ss, bp - 108]);            /* mov ax, [bp-0x6c] */
            ii(0x19_663f, 3);  les(bx, memw[ss, bp - 126]);            /* les bx, [bp-0x7e] */
            ii(0x19_6642, 4);  mov(memw[es, bx + 6], ax);              /* mov [es:bx+0x6], ax */
            ii(0x19_6646, 3);  jmp(0x19_6668, 0x1f); goto l_0x19_6668; /* jmp 0x6668 */
        l_0x19_6649:
            ii(0x19_6649, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_664c, 3);  push(memw[ss, bp - 108]);               /* push word [bp-0x6c] */
            ii(0x19_664f, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_6652, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6655, 5);  call_far_abs(0x80, 0xaf2);              /* call word 0x80:0xaf2 */
            ii(0x19_665a, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_665d, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6660, 5);  call_far_abs(0x80, 0xb0c);              /* call word 0x80:0xb0c */
            ii(0x19_6665, 3);  add(sp, 2);                             /* add sp, 0x2 */
        l_0x19_6668:
            ii(0x19_6668, 4);  cmp(memw[ss, bp - 104], 0);             /* cmp word [bp-0x68], 0x0 */
            ii(0x19_666c, 2);  if(jz(0x19_6671, 3)) goto l_0x19_6671;  /* jz 0x6671 */
            ii(0x19_666e, 3);  jmp(0x19_671a, 0xa9); goto l_0x19_671a; /* jmp 0x671a */
        l_0x19_6671:
            ii(0x19_6671, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_6674, 1);  push(ss);                               /* push ss */
            ii(0x19_6675, 1);  push(ax);                               /* push ax */
            ii(0x19_6676, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6679, 1);  nop();                                  /* nop */
            ii(0x19_667a, 1);  push(cs);                               /* push cs */
            ii(0x19_667b, 3);  call(0x19_8a8a, 0x240c);                /* call 0x8a8a */
            ii(0x19_667e, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6681, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6684, 2);  if(jnz(0x19_6689, 3)) goto l_0x19_6689; /* jnz 0x6689 */
            ii(0x19_6686, 3);  jmp(0x19_668f, 6); goto l_0x19_668f;    /* jmp 0x668f */
        l_0x19_6689:
            ii(0x19_6689, 3);  jmp(0x19_7817, 0x118b); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_668c, 3);  Недостижимый код.
        l_0x19_668f:
            ii(0x19_668f, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6692, 1);  nop();                                  /* nop */
            ii(0x19_6693, 1);  push(cs);                               /* push cs */
            ii(0x19_6694, 3);  call(0x19_6183, -0x514);                /* call 0x6183 */
            ii(0x19_6697, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_669a, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_669d, 2);  if(jnz(0x19_66a2, 3)) goto l_0x19_66a2; /* jnz 0x66a2 */
            ii(0x19_669f, 3);  jmp(0x19_671a, 0x78); goto l_0x19_671a; /* jmp 0x671a */
        l_0x19_66a2:
            ii(0x19_66a2, 4);  mov(es, memw[ds, 0x3f94]);              /* mov es, [0x3f94] */
            ii(0x19_66a6, 6);  cmp(memw[es, 0x3b72], 0);               /* cmp word [es:0x3b72], 0x0 */
            ii(0x19_66ac, 2);  if(jnz(0x19_66b1, 3)) goto l_0x19_66b1; /* jnz 0x66b1 */
            ii(0x19_66ae, 3);  jmp(0x19_670d, 0x5c); goto l_0x19_670d; /* jmp 0x670d */
        l_0x19_66b1:
            ii(0x19_66b1, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_66b4, 1);  push(ds);                               /* push ds */
            ii(0x19_66b5, 3);  push(0x12f3);                           /* push 0x12f3 */
            ii(0x19_66b8, 3);  call(0x19_1066, -0x5655);               /* call 0x1066 */
            ii(0x19_66bb, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_66be, 3);  push(memw[ss, bp - 90]);                /* push word [bp-0x5a] */
            ii(0x19_66c1, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_66c4, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_66c7, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_66ca, 1);  nop();                                  /* nop */
            ii(0x19_66cb, 1);  push(cs);                               /* push cs */
            ii(0x19_66cc, 3);  call(0x19_6131, -0x59e);                /* call 0x6131 */
            ii(0x19_66cf, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_66d2, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_66d5, 3);  push(memw[ss, bp - 108]);               /* push word [bp-0x6c] */
            ii(0x19_66d8, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_66db, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_66de, 5);  call_far_abs(0x80, 0xaf2);              /* call word 0x80:0xaf2 */
            ii(0x19_66e3, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_66e6, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_66e9, 3);  shl(ax, 3);                             /* shl ax, 0x3 */
            ii(0x19_66ec, 3);  add(ax, 5);                             /* add ax, 0x5 */
            ii(0x19_66ef, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_66f1, 3);  mov(cx, 0x10);                          /* mov cx, 0x10 */
            ii(0x19_66f4, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_66f6, 4);  mov(memb[es, bx], 0x86);                /* mov byte [es:bx], 0x86 */
            ii(0x19_66fa, 2);  push(1);                                /* push 0x1 */
            ii(0x19_66fc, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_66ff, 1);  nop();                                  /* nop */
            ii(0x19_6700, 1);  push(cs);                               /* push cs */
            ii(0x19_6701, 3);  call(0x19_606f, -0x695);                /* call 0x606f */
            ii(0x19_6704, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6707, 3);  jmp(0x19_7817, 0x110d); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_670a, 3);  Недостижимый код.
        l_0x19_670d:
            ii(0x19_670d, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6710, 1);  push(ds);                               /* push ds */
            ii(0x19_6711, 3);  push(0x1315);                           /* push 0x1315 */
            ii(0x19_6714, 3);  call(0x19_1066, -0x56b1);               /* call 0x1066 */
            ii(0x19_6717, 3);  add(sp, 6);                             /* add sp, 0x6 */
        l_0x19_671a:
            ii(0x19_671a, 5);  mov(memw[ss, bp - 98], 0);              /* mov word [bp-0x62], 0x0 */
            ii(0x19_671f, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_6722, 4);  cmp(memw[ds, 0x1278], ax);              /* cmp [0x1278], ax */
            ii(0x19_6726, 2);  if(jz(0x19_672b, 3)) goto l_0x19_672b;  /* jz 0x672b */
            ii(0x19_6728, 3);  jmp(0x19_6740, 0x15); goto l_0x19_6740; /* jmp 0x6740 */
        l_0x19_672b:
            ii(0x19_672b, 3);  mov(ax, memw[ds, 0x1276]);              /* mov ax, [0x1276] */
            ii(0x19_672e, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6730, 3);  cmp(ax, memw[ss, bp - 110]);            /* cmp ax, [bp-0x6e] */
            ii(0x19_6733, 2);  if(jz(0x19_6738, 3)) goto l_0x19_6738;  /* jz 0x6738 */
            ii(0x19_6735, 3);  jmp(0x19_6740, 8); goto l_0x19_6740;    /* jmp 0x6740 */
        l_0x19_6738:
            ii(0x19_6738, 3);  cmp(dx, memw[ss, bp - 108]);            /* cmp dx, [bp-0x6c] */
            ii(0x19_673b, 2);  if(jnz(0x19_6740, 3)) goto l_0x19_6740; /* jnz 0x6740 */
            ii(0x19_673d, 3);  jmp(0x19_6761, 0x21); goto l_0x19_6761; /* jmp 0x6761 */
        l_0x19_6740:
            ii(0x19_6740, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_6743, 4);  cmp(memw[ds, 0x127c], ax);              /* cmp [0x127c], ax */
            ii(0x19_6747, 2);  if(jz(0x19_674c, 3)) goto l_0x19_674c;  /* jz 0x674c */
            ii(0x19_6749, 3);  jmp(0x19_67b3, 0x67); goto l_0x19_67b3; /* jmp 0x67b3 */
        l_0x19_674c:
            ii(0x19_674c, 3);  mov(ax, memw[ds, 0x127a]);              /* mov ax, [0x127a] */
            ii(0x19_674f, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6751, 3);  cmp(ax, memw[ss, bp - 110]);            /* cmp ax, [bp-0x6e] */
            ii(0x19_6754, 2);  if(jz(0x19_6759, 3)) goto l_0x19_6759;  /* jz 0x6759 */
            ii(0x19_6756, 3);  jmp(0x19_67b3, 0x5a); goto l_0x19_67b3; /* jmp 0x67b3 */
        l_0x19_6759:
            ii(0x19_6759, 3);  cmp(dx, memw[ss, bp - 108]);            /* cmp dx, [bp-0x6c] */
            ii(0x19_675c, 2);  if(jz(0x19_6761, 3)) goto l_0x19_6761;  /* jz 0x6761 */
            ii(0x19_675e, 3);  jmp(0x19_67b3, 0x52); goto l_0x19_67b3; /* jmp 0x67b3 */
        l_0x19_6761:
            ii(0x19_6761, 2);  push(0);                                /* push 0x0 */
            ii(0x19_6763, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6766, 1);  nop();                                  /* nop */
            ii(0x19_6767, 1);  push(cs);                               /* push cs */
            ii(0x19_6768, 3);  call(0x19_606f, -0x6fc);                /* call 0x606f */
            ii(0x19_676b, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_676e, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6771, 5);  call_far_abs(0x80, 0x1040);             /* call word 0x80:0x1040 */
            ii(0x19_6776, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6779, 1);  push(ax);                               /* push ax */
            ii(0x19_677a, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_677d, 1);  nop();                                  /* nop */
            ii(0x19_677e, 1);  push(cs);                               /* push cs */
            ii(0x19_677f, 3);  call(0x19_7dc0, 0x163e);                /* call 0x7dc0 */
            ii(0x19_6782, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6785, 4);  cmp(memw[ss, bp - 106], 0x20);          /* cmp word [bp-0x6a], 0x20 */
            ii(0x19_6789, 2);  if(jb(0x19_678e, 3)) goto l_0x19_678e;  /* jb 0x678e */
            ii(0x19_678b, 3);  jmp(0x19_67ad, 0x1f); goto l_0x19_67ad; /* jmp 0x67ad */
        l_0x19_678e:
            ii(0x19_678e, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_6791, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_6794, 1);  push(ax);                               /* push ax */
            ii(0x19_6795, 5);  call_far_abs(0x80, 0x1040);             /* call word 0x80:0x1040 */
            ii(0x19_679a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_679d, 1);  push(ax);                               /* push ax */
            ii(0x19_679e, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_67a1, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_67a4, 1);  push(ax);                               /* push ax */
            ii(0x19_67a5, 1);  nop();                                  /* nop */
            ii(0x19_67a6, 1);  push(cs);                               /* push cs */
            ii(0x19_67a7, 3);  call(0x19_7dc0, 0x1616);                /* call 0x7dc0 */
            ii(0x19_67aa, 3);  add(sp, 4);                             /* add sp, 0x4 */
        l_0x19_67ad:
            ii(0x19_67ad, 3);  inc(memw[ss, bp - 98]);                 /* inc word [bp-0x62] */
            ii(0x19_67b0, 3);  jmp(0x19_6824, 0x71); goto l_0x19_6824; /* jmp 0x6824 */
        l_0x19_67b3:
            ii(0x19_67b3, 3);  push(memw[ss, bp - 108]);               /* push word [bp-0x6c] */
            ii(0x19_67b6, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_67b9, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_67bc, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_67bf, 5);  call_far_abs(0x80, 0xfc1);              /* call word 0x80:0xfc1 */
            ii(0x19_67c4, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_67c7, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_67ca, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_67cd, 2);  if(jnz(0x19_67d2, 3)) goto l_0x19_67d2; /* jnz 0x67d2 */
            ii(0x19_67cf, 3);  jmp(0x19_67e3, 0x11); goto l_0x19_67e3; /* jmp 0x67e3 */
        l_0x19_67d2:
            ii(0x19_67d2, 3);  push(memw[ss, bp - 112]);               /* push word [bp-0x70] */
            ii(0x19_67d5, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_67d8, 1);  nop();                                  /* nop */
            ii(0x19_67d9, 1);  push(cs);                               /* push cs */
            ii(0x19_67da, 3);  call(0x19_7dc0, 0x15e3);                /* call 0x7dc0 */
            ii(0x19_67dd, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_67e0, 3);  inc(memw[ss, bp - 98]);                 /* inc word [bp-0x62] */
        l_0x19_67e3:
            ii(0x19_67e3, 4);  cmp(memw[ss, bp - 106], 0x20);          /* cmp word [bp-0x6a], 0x20 */
            ii(0x19_67e7, 2);  if(jb(0x19_67ec, 3)) goto l_0x19_67ec;  /* jb 0x67ec */
            ii(0x19_67e9, 3);  jmp(0x19_6824, 0x38); goto l_0x19_6824; /* jmp 0x6824 */
        l_0x19_67ec:
            ii(0x19_67ec, 3);  push(memw[ss, bp - 108]);               /* push word [bp-0x6c] */
            ii(0x19_67ef, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_67f2, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_67f5, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_67f8, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_67fb, 1);  push(ax);                               /* push ax */
            ii(0x19_67fc, 5);  call_far_abs(0x80, 0xfc1);              /* call word 0x80:0xfc1 */
            ii(0x19_6801, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_6804, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_6807, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_680a, 2);  if(jnz(0x19_680f, 3)) goto l_0x19_680f; /* jnz 0x680f */
            ii(0x19_680c, 3);  jmp(0x19_6824, 0x15); goto l_0x19_6824; /* jmp 0x6824 */
        l_0x19_680f:
            ii(0x19_680f, 3);  push(memw[ss, bp - 112]);               /* push word [bp-0x70] */
            ii(0x19_6812, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_6815, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_6818, 1);  push(ax);                               /* push ax */
            ii(0x19_6819, 1);  nop();                                  /* nop */
            ii(0x19_681a, 1);  push(cs);                               /* push cs */
            ii(0x19_681b, 3);  call(0x19_7dc0, 0x15a2);                /* call 0x7dc0 */
            ii(0x19_681e, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6821, 3);  inc(memw[ss, bp - 98]);                 /* inc word [bp-0x62] */
        l_0x19_6824:
            ii(0x19_6824, 4);  cmp(memw[ss, bp - 98], 0);              /* cmp word [bp-0x62], 0x0 */
            ii(0x19_6828, 2);  if(jnz(0x19_682d, 3)) goto l_0x19_682d; /* jnz 0x682d */
            ii(0x19_682a, 3);  jmp(0x19_6830, 3); goto l_0x19_6830;    /* jmp 0x6830 */
        l_0x19_682d:
            ii(0x19_682d, 3);  jmp(0x19_7817, 0xfe7); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6830:
            ii(0x19_6830, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6833, 5);  call_far_abs(0x80, 0x1040);             /* call word 0x80:0x1040 */
            ii(0x19_6838, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_683b, 1);  push(ax);                               /* push ax */
            ii(0x19_683c, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_683f, 1);  nop();                                  /* nop */
            ii(0x19_6840, 1);  push(cs);                               /* push cs */
            ii(0x19_6841, 3);  call(0x19_7dc0, 0x157c);                /* call 0x7dc0 */
            ii(0x19_6844, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6847, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_684a, 3);  mov(memw[ss, bp - 118], ax);            /* mov [bp-0x76], ax */
            ii(0x19_684d, 3);  mov(ax, memw[ss, bp - 110]);            /* mov ax, [bp-0x6e] */
            ii(0x19_6850, 3);  mov(dx, memw[ss, bp - 108]);            /* mov dx, [bp-0x6c] */
            ii(0x19_6853, 3);  mov(memw[ss, bp - 122], ax);            /* mov [bp-0x7a], ax */
            ii(0x19_6856, 3);  mov(memw[ss, bp - 120], dx);            /* mov [bp-0x78], dx */
            ii(0x19_6859, 3);  lea(ax, memw[ss, bp - 122]);            /* lea ax, [bp-0x7a] */
            ii(0x19_685c, 1);  push(ss);                               /* push ss */
            ii(0x19_685d, 1);  push(ax);                               /* push ax */
            ii(0x19_685e, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6861, 5);  call_far_abs(0x80, 0xb38);              /* call word 0x80:0xb38 */
            ii(0x19_6866, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6869, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_686c, 3);  mov(al, memb[ss, bp - 104]);            /* mov al, [bp-0x68] */
            ii(0x19_686f, 2);  add(al, 2);                             /* add al, 0x2 */
            ii(0x19_6871, 3);  mov(si, memw[ss, bp - 112]);            /* mov si, [bp-0x70] */
            ii(0x19_6874, 3);  and(si, -8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x19_6877, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_687b, 5);  les(bx, memw[es, 0x122]);               /* les bx, [es:0x122] */
            ii(0x19_6880, 3);  mov(memb[es, bx + si], al);             /* mov [es:bx+si], al */
            ii(0x19_6883, 4);  cmp(memw[ss, bp - 106], 0x20);          /* cmp word [bp-0x6a], 0x20 */
            ii(0x19_6887, 2);  if(jb(0x19_688c, 3)) goto l_0x19_688c;  /* jb 0x688c */
            ii(0x19_6889, 3);  jmp(0x19_68d5, 0x49); goto l_0x19_68d5; /* jmp 0x68d5 */
        l_0x19_688c:
            ii(0x19_688c, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_688f, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_6892, 1);  push(ax);                               /* push ax */
            ii(0x19_6893, 5);  call_far_abs(0x80, 0x1040);             /* call word 0x80:0x1040 */
            ii(0x19_6898, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_689b, 1);  push(ax);                               /* push ax */
            ii(0x19_689c, 3);  mov(ax, memw[ss, bp - 106]);            /* mov ax, [bp-0x6a] */
            ii(0x19_689f, 3);  add(ax, 0x100);                         /* add ax, 0x100 */
            ii(0x19_68a2, 1);  push(ax);                               /* push ax */
            ii(0x19_68a3, 1);  nop();                                  /* nop */
            ii(0x19_68a4, 1);  push(cs);                               /* push cs */
            ii(0x19_68a5, 3);  call(0x19_7dc0, 0x1518);                /* call 0x7dc0 */
            ii(0x19_68a8, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_68ab, 3);  lea(ax, memw[ss, bp - 122]);            /* lea ax, [bp-0x7a] */
            ii(0x19_68ae, 1);  push(ss);                               /* push ss */
            ii(0x19_68af, 1);  push(ax);                               /* push ax */
            ii(0x19_68b0, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_68b3, 5);  call_far_abs(0x80, 0xb53);              /* call word 0x80:0xb53 */
            ii(0x19_68b8, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_68bb, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_68be, 3);  mov(al, memb[ss, bp - 104]);            /* mov al, [bp-0x68] */
            ii(0x19_68c1, 2);  add(al, 2);                             /* add al, 0x2 */
            ii(0x19_68c3, 3);  mov(si, memw[ss, bp - 112]);            /* mov si, [bp-0x70] */
            ii(0x19_68c6, 3);  and(si, -8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x19_68c9, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_68cd, 5);  les(bx, memw[es, 0x122]);               /* les bx, [es:0x122] */
            ii(0x19_68d2, 3);  mov(memb[es, bx + si], al);             /* mov [es:bx+si], al */
        l_0x19_68d5:
            ii(0x19_68d5, 4);  cmp(memw[ss, bp - 104], 0);             /* cmp word [bp-0x68], 0x0 */
            ii(0x19_68d9, 2);  if(jz(0x19_68de, 3)) goto l_0x19_68de;  /* jz 0x68de */
            ii(0x19_68db, 3);  jmp(0x19_68fb, 0x1d); goto l_0x19_68fb; /* jmp 0x68fb */
        l_0x19_68de:
            ii(0x19_68de, 4);  cmp(memw[ss, bp - 106], 0);             /* cmp word [bp-0x6a], 0x0 */
            ii(0x19_68e2, 2);  if(ja(0x19_68e7, 3)) goto l_0x19_68e7;  /* ja 0x68e7 */
            ii(0x19_68e4, 3);  jmp(0x19_68fb, 0x14); goto l_0x19_68fb; /* jmp 0x68fb */
        l_0x19_68e7:
            ii(0x19_68e7, 3);  push(memw[ss, bp - 90]);                /* push word [bp-0x5a] */
            ii(0x19_68ea, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_68ed, 3);  push(memw[ss, bp - 102]);               /* push word [bp-0x66] */
            ii(0x19_68f0, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_68f3, 1);  nop();                                  /* nop */
            ii(0x19_68f4, 1);  push(cs);                               /* push cs */
            ii(0x19_68f5, 3);  call(0x19_6131, -0x7c7);                /* call 0x6131 */
            ii(0x19_68f8, 3);  add(sp, 8);                             /* add sp, 0x8 */
        l_0x19_68fb:
            ii(0x19_68fb, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_68fe, 1);  nop();                                  /* nop */
            ii(0x19_68ff, 1);  push(cs);                               /* push cs */
            ii(0x19_6900, 3);  call(0x19_60d4, -0x82f);                /* call 0x60d4 */
            ii(0x19_6903, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6906, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6909, 3);  mov(memw[ss, bp - 114], dx);            /* mov [bp-0x72], dx */
            ii(0x19_690c, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_690e, 2);  if(jnz(0x19_6913, 3)) goto l_0x19_6913; /* jnz 0x6913 */
            ii(0x19_6910, 3);  jmp(0x19_6920, 0xd); goto l_0x19_6920;  /* jmp 0x6920 */
        l_0x19_6913:
            ii(0x19_6913, 2);  push(1);                                /* push 0x1 */
            ii(0x19_6915, 3);  push(memw[ss, bp - 106]);               /* push word [bp-0x6a] */
            ii(0x19_6918, 1);  nop();                                  /* nop */
            ii(0x19_6919, 1);  push(cs);                               /* push cs */
            ii(0x19_691a, 3);  call(0x19_606f, -0x8ae);                /* call 0x606f */
            ii(0x19_691d, 3);  add(sp, 4);                             /* add sp, 0x4 */
        l_0x19_6920:
            ii(0x19_6920, 3);  jmp(0x19_7817, 0xef4); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6923:
            ii(0x19_6923, 5);  cmp(memw[ds, 0x489a], 0);               /* cmp word [0x489a], 0x0 */
            ii(0x19_6928, 2);  if(jnz(0x19_692d, 3)) goto l_0x19_692d; /* jnz 0x692d */
            ii(0x19_692a, 3);  jmp(0x19_6966, 0x39); goto l_0x19_6966; /* jmp 0x6966 */
        l_0x19_692d:
            ii(0x19_692d, 3);  mov(ax, memw[ds, 0x4894]);              /* mov ax, [0x4894] */
            ii(0x19_6930, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_6933, 3);  mov(ax, memw[ss, bp - 96]);             /* mov ax, [bp-0x60] */
            ii(0x19_6936, 3);  mov(dx, memw[ss, bp - 94]);             /* mov dx, [bp-0x5e] */
            ii(0x19_6939, 2);  not(ax);                                /* not ax */
            ii(0x19_693b, 2);  not(dx);                                /* not dx */
            ii(0x19_693d, 3);  and(ax, memw[ss, bp - 64]);             /* and ax, [bp-0x40] */
            ii(0x19_6940, 3);  and(dx, memw[ss, bp - 62]);             /* and dx, [bp-0x3e] */
            ii(0x19_6943, 4);  mov(cx, memw[ds, 0x4890]);              /* mov cx, [0x4890] */
            ii(0x19_6947, 4);  mov(bx, memw[ds, 0x4892]);              /* mov bx, [0x4892] */
            ii(0x19_694b, 3);  and(cx, memw[ss, bp - 96]);             /* and cx, [bp-0x60] */
            ii(0x19_694e, 3);  and(bx, memw[ss, bp - 94]);             /* and bx, [bp-0x5e] */
            ii(0x19_6951, 2);  or(ax, cx);                             /* or ax, cx */
            ii(0x19_6953, 2);  or(dx, bx);                             /* or dx, bx */
            ii(0x19_6955, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_6958, 3);  mov(memw[ss, bp - 62], dx);             /* mov [bp-0x3e], dx */
            ii(0x19_695b, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_6960, 3);  jmp(0x19_7817, 0xeb4); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_6963, 3);  Недостижимый код.
        l_0x19_6966:
            ii(0x19_6966, 3);  jmp(0x19_633b, -0x62e); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6969:
            ii(0x19_6969, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_696c, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_696f, 3);  and(ax, memw[ss, bp - 76]);             /* and ax, [bp-0x4c] */
            ii(0x19_6972, 3);  and(dx, memw[ss, bp - 74]);             /* and dx, [bp-0x4a] */
            ii(0x19_6975, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_6977, 2);  if(jz(0x19_697c, 3)) goto l_0x19_697c;  /* jz 0x697c */
            ii(0x19_6979, 3);  jmp(0x19_698f, 0x13); goto l_0x19_698f; /* jmp 0x698f */
        l_0x19_697c:
            ii(0x19_697c, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_697f, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_6982, 3);  and(ax, memw[ss, bp - 80]);             /* and ax, [bp-0x50] */
            ii(0x19_6985, 3);  and(dx, memw[ss, bp - 78]);             /* and dx, [bp-0x4e] */
            ii(0x19_6988, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_698a, 2);  if(jnz(0x19_698f, 3)) goto l_0x19_698f; /* jnz 0x698f */
            ii(0x19_698c, 3);  jmp(0x19_6a4a, 0xbb); goto l_0x19_6a4a; /* jmp 0x6a4a */
        l_0x19_698f:
            ii(0x19_698f, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_6992, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6995, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6998, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_699b, 3);  mov(ax, memw[ss, bp - 76]);             /* mov ax, [bp-0x4c] */
            ii(0x19_699e, 3);  mov(dx, memw[ss, bp - 74]);             /* mov dx, [bp-0x4a] */
            ii(0x19_69a1, 3);  mov(memw[ss, bp - 110], ax);            /* mov [bp-0x6e], ax */
            ii(0x19_69a4, 3);  mov(memw[ss, bp - 108], dx);            /* mov [bp-0x6c], dx */
            ii(0x19_69a7, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_69aa, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_69ad, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_69b0, 3);  mov(memw[ss, bp - 100], dx);            /* mov [bp-0x64], dx */
            ii(0x19_69b3, 3);  push(memw[ss, bp - 74]);                /* push word [bp-0x4a] */
            ii(0x19_69b6, 3);  push(memw[ss, bp - 76]);                /* push word [bp-0x4c] */
            ii(0x19_69b9, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_69bc, 1);  nop();                                  /* nop */
            ii(0x19_69bd, 1);  push(cs);                               /* push cs */
            ii(0x19_69be, 3);  call(0x19_789c, 0xedb);                 /* call 0x789c */
            ii(0x19_69c1, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_69c4, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_69c7, 3);  push(memw[ss, bp - 78]);                /* push word [bp-0x4e] */
            ii(0x19_69ca, 3);  push(memw[ss, bp - 80]);                /* push word [bp-0x50] */
            ii(0x19_69cd, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_69d0, 1);  nop();                                  /* nop */
            ii(0x19_69d1, 1);  push(cs);                               /* push cs */
            ii(0x19_69d2, 3);  call(0x19_789c, 0xec7);                 /* call 0x789c */
            ii(0x19_69d5, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_69d8, 3);  mov(memw[ss, bp - 122], ax);            /* mov [bp-0x7a], ax */
            ii(0x19_69db, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_69de, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_69e1, 3);  mov(ax, memw[ss, bp - 122]);            /* mov ax, [bp-0x7a] */
            ii(0x19_69e4, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_69e7, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_69e9, 3);  mov(memw[ss, bp - 74], ax);             /* mov [bp-0x4a], ax */
            ii(0x19_69ec, 3);  mov(memw[ss, bp - 76], ax);             /* mov [bp-0x4c], ax */
            ii(0x19_69ef, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_69f1, 3);  mov(memw[ss, bp - 78], ax);             /* mov [bp-0x4e], ax */
            ii(0x19_69f4, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_69f7, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_69fa, 1);  push(ss);                               /* push ss */
            ii(0x19_69fb, 1);  push(ax);                               /* push ax */
            ii(0x19_69fc, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_69ff, 3);  call(0x19_61c1, -0x841);                /* call 0x61c1 */
            ii(0x19_6a02, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6a05, 5);  sub(memw[ds, 0x1274], 2);               /* sub word [0x1274], 0x2 */
            ii(0x19_6a0a, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_6a0d, 3);  cmp(memw[ss, bp - 126], ax);            /* cmp [bp-0x7e], ax */
            ii(0x19_6a10, 2);  if(jz(0x19_6a15, 3)) goto l_0x19_6a15;  /* jz 0x6a15 */
            ii(0x19_6a12, 3);  jmp(0x19_6a27, 0x12); goto l_0x19_6a27; /* jmp 0x6a27 */
        l_0x19_6a15:
            ii(0x19_6a15, 3);  mov(ax, memw[ss, bp - 116]);            /* mov ax, [bp-0x74] */
            ii(0x19_6a18, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_6a1b, 3);  mov(ax, memw[ss, bp - 110]);            /* mov ax, [bp-0x6e] */
            ii(0x19_6a1e, 3);  mov(dx, memw[ss, bp - 108]);            /* mov dx, [bp-0x6c] */
            ii(0x19_6a21, 3);  add(memw[ss, bp - 76], ax);             /* add [bp-0x4c], ax */
            ii(0x19_6a24, 3);  adc(memw[ss, bp - 74], dx);             /* adc [bp-0x4a], dx */
        l_0x19_6a27:
            ii(0x19_6a27, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6a2a, 3);  cmp(memw[ss, bp - 122], ax);            /* cmp [bp-0x7a], ax */
            ii(0x19_6a2d, 2);  if(jz(0x19_6a32, 3)) goto l_0x19_6a32;  /* jz 0x6a32 */
            ii(0x19_6a2f, 3);  jmp(0x19_6a44, 0x12); goto l_0x19_6a44; /* jmp 0x6a44 */
        l_0x19_6a32:
            ii(0x19_6a32, 3);  mov(ax, memw[ss, bp - 112]);            /* mov ax, [bp-0x70] */
            ii(0x19_6a35, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_6a38, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_6a3b, 3);  mov(dx, memw[ss, bp - 100]);            /* mov dx, [bp-0x64] */
            ii(0x19_6a3e, 3);  add(memw[ss, bp - 80], ax);             /* add [bp-0x50], ax */
            ii(0x19_6a41, 3);  adc(memw[ss, bp - 78], dx);             /* adc [bp-0x4e], dx */
        l_0x19_6a44:
            ii(0x19_6a44, 3);  jmp(0x19_7817, 0xdd0); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_6a47, 3);  Недостижимый код.
        l_0x19_6a4a:
            ii(0x19_6a4a, 3);  jmp(0x19_633b, -0x712); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6a4d:
            ii(0x19_6a4d, 1);  push(ds);                               /* push ds */
            ii(0x19_6a4e, 3);  push(0x133a);                           /* push 0x133a */
            ii(0x19_6a51, 3);  push(0x3f6);                            /* push 0x3f6 */
            ii(0x19_6a54, 3);  call(0x19_1046, -0x5a11);               /* call 0x1046 */
            ii(0x19_6a57, 3);  add(sp, 6);                             /* add sp, 0x6 */
        l_0x19_6a5a:
            ii(0x19_6a5a, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_6a5d, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6a5f, 3);  mov(memw[ss, bp - 122], ax);            /* mov [bp-0x7a], ax */
            ii(0x19_6a62, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_6a65, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_6a6a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6a6d, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_6a70, 4);  mov(es, memw[ds, 0x3f9a]);              /* mov es, [0x3f9a] */
            ii(0x19_6a74, 3);  mov(bx, memw[ss, bp - 122]);            /* mov bx, [bp-0x7a] */
            ii(0x19_6a77, 5);  mov(al, memb[es, bx + 2]);              /* mov al, [es:bx+0x2] */
            ii(0x19_6a7c, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6a7e, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_6a80, 3);  jmp(0x19_6a99, 0x16); goto l_0x19_6a99; /* jmp 0x6a99 */
        l_0x19_6a83:
            ii(0x19_6a83, 2);  mov(bx, si);                            /* mov bx, si */
            ii(0x19_6a85, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x19_6a88, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_6a8c, 5);  les(di, memw[es, 0x122]);               /* les di, [es:0x122] */
            ii(0x19_6a91, 4);  mov(al, memb[es, bx + di + 1]);         /* mov al, [es:bx+di+0x1] */
            ii(0x19_6a95, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6a97, 2);  mov(si, ax);                            /* mov si, ax */
        l_0x19_6a99:
            ii(0x19_6a99, 3);  cmp(si, 1);                             /* cmp si, 0x1 */
            ii(0x19_6a9c, 2);  if(jnz(0x19_6aa1, 3)) goto l_0x19_6aa1; /* jnz 0x6aa1 */
            ii(0x19_6a9e, 3);  jmp(0x19_6ac5, 0x24); goto l_0x19_6ac5; /* jmp 0x6ac5 */
        l_0x19_6aa1:
            ii(0x19_6aa1, 2);  mov(di, si);                            /* mov di, si */
            ii(0x19_6aa3, 3);  shl(di, 3);                             /* shl di, 0x3 */
            ii(0x19_6aa6, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_6aaa, 5);  les(bx, memw[es, 0x122]);               /* les bx, [es:0x122] */
            ii(0x19_6aaf, 3);  mov(al, memb[es, bx + di]);             /* mov al, [es:bx+di] */
            ii(0x19_6ab2, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6ab4, 3);  sub(ax, memw[ss, bp - 126]);            /* sub ax, [bp-0x7e] */
            ii(0x19_6ab7, 3);  cmp(ax, 2);                             /* cmp ax, 0x2 */
            ii(0x19_6aba, 2);  if(jz(0x19_6abf, 3)) goto l_0x19_6abf;  /* jz 0x6abf */
            ii(0x19_6abc, 3);  jmp(0x19_6ac2, 3); goto l_0x19_6ac2;    /* jmp 0x6ac2 */
        l_0x19_6abf:
            ii(0x19_6abf, 3);  jmp(0x19_6ac5, 3); goto l_0x19_6ac5;    /* jmp 0x6ac5 */
        l_0x19_6ac2:
            ii(0x19_6ac2, 3);  jmp(0x19_6a83, -0x42); goto l_0x19_6a83;/* jmp 0x6a83 */
        l_0x19_6ac5:
            ii(0x19_6ac5, 3);  cmp(si, 1);                             /* cmp si, 0x1 */
            ii(0x19_6ac8, 2);  if(jz(0x19_6acd, 3)) goto l_0x19_6acd;  /* jz 0x6acd */
            ii(0x19_6aca, 3);  jmp(0x19_6af8, 0x2b); goto l_0x19_6af8; /* jmp 0x6af8 */
        l_0x19_6acd:
            ii(0x19_6acd, 3);  mov(ax, memw[ds, 0x127c]);              /* mov ax, [0x127c] */
            ii(0x19_6ad0, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_6ad3, 4);  cmp(memw[ss, bp - 126], 0);             /* cmp word [bp-0x7e], 0x0 */
            ii(0x19_6ad7, 2);  if(jnz(0x19_6adc, 3)) goto l_0x19_6adc; /* jnz 0x6adc */
            ii(0x19_6ad9, 3);  jmp(0x19_6aea, 0xe); goto l_0x19_6aea;  /* jmp 0x6aea */
        l_0x19_6adc:
            ii(0x19_6adc, 3);  mov(ax, memw[ds, 0x127a]);              /* mov ax, [0x127a] */
            ii(0x19_6adf, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6ae2, 5);  mov(memw[ss, bp - 114], 0);             /* mov word [bp-0x72], 0x0 */
            ii(0x19_6ae7, 3);  jmp(0x19_6af5, 0xb); goto l_0x19_6af5;  /* jmp 0x6af5 */
        l_0x19_6aea:
            ii(0x19_6aea, 3);  mov(ax, memw[ds, 0x1276]);              /* mov ax, [0x1276] */
            ii(0x19_6aed, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6af0, 5);  mov(memw[ss, bp - 114], 0);             /* mov word [bp-0x72], 0x0 */
        l_0x19_6af5:
            ii(0x19_6af5, 3);  jmp(0x19_6b29, 0x31); goto l_0x19_6b29; /* jmp 0x6b29 */
        l_0x19_6af8:
            ii(0x19_6af8, 2);  mov(bx, si);                            /* mov bx, si */
            ii(0x19_6afa, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x19_6afd, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_6b01, 5);  les(di, memw[es, 0x122]);               /* les di, [es:0x122] */
            ii(0x19_6b06, 4);  mov(ax, memw[es, bx + di + 6]);         /* mov ax, [es:bx+di+0x6] */
            ii(0x19_6b0a, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_6b0d, 2);  mov(bx, si);                            /* mov bx, si */
            ii(0x19_6b0f, 3);  shl(bx, 3);                             /* shl bx, 0x3 */
            ii(0x19_6b12, 4);  mov(es, memw[ds, 0x3f98]);              /* mov es, [0x3f98] */
            ii(0x19_6b16, 5);  les(di, memw[es, 0x122]);               /* les di, [es:0x122] */
            ii(0x19_6b1b, 4);  mov(ax, memw[es, bx + di + 2]);         /* mov ax, [es:bx+di+0x2] */
            ii(0x19_6b1f, 4);  mov(dx, memw[es, bx + di + 4]);         /* mov dx, [es:bx+di+0x4] */
            ii(0x19_6b23, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6b26, 3);  mov(memw[ss, bp - 114], dx);            /* mov [bp-0x72], dx */
        l_0x19_6b29:
            ii(0x19_6b29, 4);  cmp(memw[ss, bp - 126], 0);             /* cmp word [bp-0x7e], 0x0 */
            ii(0x19_6b2d, 2);  if(jnz(0x19_6b32, 3)) goto l_0x19_6b32; /* jnz 0x6b32 */
            ii(0x19_6b2f, 3);  jmp(0x19_6b46, 0x14); goto l_0x19_6b46; /* jmp 0x6b46 */
        l_0x19_6b32:
            ii(0x19_6b32, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_6b37, 3);  mov(ax, memw[ss, bp - 116]);            /* mov ax, [bp-0x74] */
            ii(0x19_6b3a, 3);  mov(dx, memw[ss, bp - 114]);            /* mov dx, [bp-0x72] */
            ii(0x19_6b3d, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_6b40, 3);  mov(memw[ss, bp - 62], dx);             /* mov [bp-0x3e], dx */
            ii(0x19_6b43, 3);  jmp(0x19_6b6c, 0x26); goto l_0x19_6b6c; /* jmp 0x6b6c */
        l_0x19_6b46:
            ii(0x19_6b46, 3);  mov(ax, memw[ss, bp - 96]);             /* mov ax, [bp-0x60] */
            ii(0x19_6b49, 3);  mov(dx, memw[ss, bp - 94]);             /* mov dx, [bp-0x5e] */
            ii(0x19_6b4c, 2);  not(ax);                                /* not ax */
            ii(0x19_6b4e, 2);  not(dx);                                /* not dx */
            ii(0x19_6b50, 3);  and(ax, memw[ss, bp - 64]);             /* and ax, [bp-0x40] */
            ii(0x19_6b53, 3);  and(dx, memw[ss, bp - 62]);             /* and dx, [bp-0x3e] */
            ii(0x19_6b56, 3);  mov(cx, memw[ss, bp - 116]);            /* mov cx, [bp-0x74] */
            ii(0x19_6b59, 3);  mov(bx, memw[ss, bp - 114]);            /* mov bx, [bp-0x72] */
            ii(0x19_6b5c, 3);  and(cx, memw[ss, bp - 96]);             /* and cx, [bp-0x60] */
            ii(0x19_6b5f, 3);  and(bx, memw[ss, bp - 94]);             /* and bx, [bp-0x5e] */
            ii(0x19_6b62, 2);  or(ax, cx);                             /* or ax, cx */
            ii(0x19_6b64, 2);  or(dx, bx);                             /* or dx, bx */
            ii(0x19_6b66, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_6b69, 3);  mov(memw[ss, bp - 62], dx);             /* mov [bp-0x3e], dx */
        l_0x19_6b6c:
            ii(0x19_6b6c, 3);  jmp(0x19_7817, 0xca8); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6b6f:
            ii(0x19_6b6f, 4);  cmp(memw[ss, bp - 60], -1 /* 0xff */);  /* cmp word [bp-0x3c], 0xffff */
            ii(0x19_6b73, 2);  if(jz(0x19_6b78, 3)) goto l_0x19_6b78;  /* jz 0x6b78 */
            ii(0x19_6b75, 3);  jmp(0x19_6b8c, 0x14); goto l_0x19_6b8c; /* jmp 0x6b8c */
        l_0x19_6b78:
            ii(0x19_6b78, 4);  cmp(memw[ss, bp - 58], -1 /* 0xff */);  /* cmp word [bp-0x3a], 0xffff */
            ii(0x19_6b7c, 2);  if(jz(0x19_6b81, 3)) goto l_0x19_6b81;  /* jz 0x6b81 */
            ii(0x19_6b7e, 3);  jmp(0x19_6b8c, 0xb); goto l_0x19_6b8c;  /* jmp 0x6b8c */
        l_0x19_6b81:
            ii(0x19_6b81, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_6b86, 3);  jmp(0x19_633b, -0x84e); goto l_0x19_633b;/* jmp 0x633b */
        //  ii(0x19_6b89, 3);  Недостижимый код.
        l_0x19_6b8c:
            ii(0x19_6b8c, 3);  jmp(0x19_6442, -0x74d); goto l_0x19_6442;/* jmp 0x6442 */
        l_0x19_6b8f:
            ii(0x19_6b8f, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_6b92, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_6b95, 3);  and(ax, memw[ss, bp - 56]);             /* and ax, [bp-0x38] */
            ii(0x19_6b98, 3);  and(dx, memw[ss, bp - 54]);             /* and dx, [bp-0x36] */
            ii(0x19_6b9b, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_6b9d, 2);  if(jz(0x19_6ba2, 3)) goto l_0x19_6ba2;  /* jz 0x6ba2 */
            ii(0x19_6b9f, 3);  jmp(0x19_6bbb, 0x19); goto l_0x19_6bbb; /* jmp 0x6bbb */
        l_0x19_6ba2:
            ii(0x19_6ba2, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x19_6ba5, 3);  mov(dx, memw[ss, bp - 54]);             /* mov dx, [bp-0x36] */
            ii(0x19_6ba8, 3);  add(ax, memw[ss, bp - 60]);             /* add ax, [bp-0x3c] */
            ii(0x19_6bab, 3);  adc(dx, memw[ss, bp - 58]);             /* adc dx, [bp-0x3a] */
            ii(0x19_6bae, 3);  and(ax, memw[ss, bp - 22]);             /* and ax, [bp-0x16] */
            ii(0x19_6bb1, 3);  and(dx, memw[ss, bp - 20]);             /* and dx, [bp-0x14] */
            ii(0x19_6bb4, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_6bb6, 2);  if(jnz(0x19_6bbb, 3)) goto l_0x19_6bbb; /* jnz 0x6bbb */
            ii(0x19_6bb8, 3);  jmp(0x19_6d0b, 0x150); goto l_0x19_6d0b;/* jmp 0x6d0b */
        l_0x19_6bbb:
            ii(0x19_6bbb, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_6bbe, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_6bc1, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_6bc4, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_6bc7, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_6bcb, 4);  mov(memw[ss, bp - 132], dx);            /* mov [bp-0x84], dx */
            ii(0x19_6bcf, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x19_6bd2, 3);  mov(dx, memw[ss, bp - 54]);             /* mov dx, [bp-0x36] */
            ii(0x19_6bd5, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_6bd8, 3);  mov(memw[ss, bp - 100], dx);            /* mov [bp-0x64], dx */
            ii(0x19_6bdb, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_6bde, 3);  mov(dx, memw[ss, bp - 100]);            /* mov dx, [bp-0x64] */
            ii(0x19_6be1, 3);  mov(memw[ss, bp - 122], ax);            /* mov [bp-0x7a], ax */
            ii(0x19_6be4, 3);  mov(memw[ss, bp - 120], dx);            /* mov [bp-0x78], dx */
            ii(0x19_6be7, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_6beb, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_6bef, 3);  mov(memw[ss, bp - 110], ax);            /* mov [bp-0x6e], ax */
            ii(0x19_6bf2, 3);  mov(memw[ss, bp - 108], dx);            /* mov [bp-0x6c], dx */
            ii(0x19_6bf5, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_6bf7, 3);  mov(memw[ss, bp - 128], ax);            /* mov [bp-0x80], ax */
            ii(0x19_6bfa, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
        l_0x19_6bfe:
            ii(0x19_6bfe, 3);  mov(ax, memw[ss, bp - 122]);            /* mov ax, [bp-0x7a] */
            ii(0x19_6c01, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
            ii(0x19_6c04, 3);  mov(ah, memb[ss, bp - 4]);              /* mov ah, [bp-0x4] */
            ii(0x19_6c07, 2);  sub(al, al);                            /* sub al, al */
            ii(0x19_6c09, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_6c0c, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6c11, 3);  push(memw[ss, bp - 108]);               /* push word [bp-0x6c] */
            ii(0x19_6c14, 3);  push(memw[ss, bp - 110]);               /* push word [bp-0x6e] */
            ii(0x19_6c17, 3);  push(memw[ss, bp - 126]);               /* push word [bp-0x7e] */
            ii(0x19_6c1a, 1);  nop();                                  /* nop */
            ii(0x19_6c1b, 1);  push(cs);                               /* push cs */
            ii(0x19_6c1c, 3);  call(0x19_789c, 0xc7d);                 /* call 0x789c */
            ii(0x19_6c1f, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6c22, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_6c25, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_6c28, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_6c2a, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_6c2d, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6c30, 3);  mov(ax, memw[ds, 0x4898]);              /* mov ax, [0x4898] */
            ii(0x19_6c33, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6c35, 3);  cmp(dx, memw[ss, bp - 120]);            /* cmp dx, [bp-0x78] */
            ii(0x19_6c38, 2);  if(jbe(0x19_6c3d, 3)) goto l_0x19_6c3d; /* jbe 0x6c3d */
            ii(0x19_6c3a, 3);  jmp(0x19_6c71, 0x34); goto l_0x19_6c71; /* jmp 0x6c71 */
        l_0x19_6c3d:
            ii(0x19_6c3d, 2);  if(jae(0x19_6c42, 3)) goto l_0x19_6c42; /* jae 0x6c42 */
            ii(0x19_6c3f, 3);  jmp(0x19_6c4a, 8); goto l_0x19_6c4a;    /* jmp 0x6c4a */
        l_0x19_6c42:
            ii(0x19_6c42, 3);  cmp(ax, memw[ss, bp - 122]);            /* cmp ax, [bp-0x7a] */
            ii(0x19_6c45, 2);  if(jb(0x19_6c4a, 3)) goto l_0x19_6c4a;  /* jb 0x6c4a */
            ii(0x19_6c47, 3);  jmp(0x19_6c71, 0x27); goto l_0x19_6c71; /* jmp 0x6c71 */
        l_0x19_6c4a:
            ii(0x19_6c4a, 4);  cmp(memw[ss, bp - 112], 0);             /* cmp word [bp-0x70], 0x0 */
            ii(0x19_6c4e, 2);  if(jz(0x19_6c53, 3)) goto l_0x19_6c53;  /* jz 0x6c53 */
            ii(0x19_6c50, 3);  jmp(0x19_6c58, 5); goto l_0x19_6c58;    /* jmp 0x6c58 */
        l_0x19_6c53:
            ii(0x19_6c53, 5);  sub(memw[ss, bp - 112], 0x200);         /* sub word [bp-0x70], 0x200 */
        l_0x19_6c58:
            ii(0x19_6c58, 3);  mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x19_6c5b, 3);  mov(bx, memw[ss, bp - 116]);            /* mov bx, [bp-0x74] */
            ii(0x19_6c5e, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_6c60, 3);  add(dx, memw[ss, bp - 122]);            /* add dx, [bp-0x7a] */
            ii(0x19_6c63, 3);  adc(cx, memw[ss, bp - 120]);            /* adc cx, [bp-0x78] */
            ii(0x19_6c66, 3);  cmp(cx, 0x10);                          /* cmp cx, 0x10 */
            ii(0x19_6c69, 2);  if(jb(0x19_6c71, 6)) goto l_0x19_6c71;  /* jb 0x6c71 */
            ii(0x19_6c6b, 3);  mov(ax, memw[ds, 0x4898]);              /* mov ax, [0x4898] */
            ii(0x19_6c6e, 3);  mov(memw[ss, bp - 112], ax);            /* mov [bp-0x70], ax */
        l_0x19_6c71:
            ii(0x19_6c71, 3);  mov(ax, memw[ss, bp - 112]);            /* mov ax, [bp-0x70] */
            ii(0x19_6c74, 3);  mov(memw[ss, bp - 56], ax);             /* mov [bp-0x38], ax */
            ii(0x19_6c77, 5);  mov(memw[ss, bp - 54], 0);              /* mov word [bp-0x36], 0x0 */
            ii(0x19_6c7c, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_6c7f, 1);  push(ss);                               /* push ss */
            ii(0x19_6c80, 1);  push(ax);                               /* push ax */
            ii(0x19_6c81, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_6c84, 3);  if(call_up(0x19_61c1, -0xac6)) return;  /* call 0x61c1 */
            ii(0x19_6c87, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6c8a, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_6c8e, 4);  test(memb[ss, bp - 34], 1);             /* test byte [bp-0x22], 0x1 */
            ii(0x19_6c92, 2);  if(jnz(0x19_6c97, 3)) goto l_0x19_6c97; /* jnz 0x6c97 */
            ii(0x19_6c94, 3);  jmp(0x19_6c9a, 3); goto l_0x19_6c9a;    /* jmp 0x6c9a */
        l_0x19_6c97:
            ii(0x19_6c97, 3);  jmp(0x19_6cc7, 0x2d); goto l_0x19_6cc7; /* jmp 0x6cc7 */
        l_0x19_6c9a:
            ii(0x19_6c9a, 3);  mov(ax, memw[ss, bp - 112]);            /* mov ax, [bp-0x70] */
            ii(0x19_6c9d, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6c9f, 3);  add(memw[ss, bp - 110], ax);            /* add [bp-0x6e], ax */
            ii(0x19_6ca2, 3);  adc(memw[ss, bp - 108], dx);            /* adc [bp-0x6c], dx */
            ii(0x19_6ca5, 3);  mov(ax, memw[ss, bp - 112]);            /* mov ax, [bp-0x70] */
            ii(0x19_6ca8, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6caa, 3);  sub(memw[ss, bp - 122], ax);            /* sub [bp-0x7a], ax */
            ii(0x19_6cad, 3);  sbb(memw[ss, bp - 120], dx);            /* sbb [bp-0x78], dx */
            ii(0x19_6cb0, 3);  mov(ax, memw[ss, bp - 52]);             /* mov ax, [bp-0x34] */
            ii(0x19_6cb3, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6cb5, 4);  add(memw[ss, bp - 130], ax);            /* add [bp-0x82], ax */
            ii(0x19_6cb9, 3);  adc(memw[ss, bp - 128], dx);            /* adc [bp-0x80], dx */
            ii(0x19_6cbc, 3);  mov(ax, memw[ss, bp - 120]);            /* mov ax, [bp-0x78] */
            ii(0x19_6cbf, 3);  or(ax, memw[ss, bp - 122]);             /* or ax, [bp-0x7a] */
            ii(0x19_6cc2, 2);  if(jz(0x19_6cc7, 3)) goto l_0x19_6cc7;  /* jz 0x6cc7 */
            ii(0x19_6cc4, 3);  jmp(0x19_6bfe, -0xc9); goto l_0x19_6bfe;/* jmp 0x6bfe */
        l_0x19_6cc7:
            ii(0x19_6cc7, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_6cca, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_6ccd, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_6cd1, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_6cd5, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_6cd8, 3);  mov(memw[ss, bp - 58], dx);             /* mov [bp-0x3a], dx */
            ii(0x19_6cdb, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_6cde, 3);  mov(dx, memw[ss, bp - 100]);            /* mov dx, [bp-0x64] */
            ii(0x19_6ce1, 3);  mov(memw[ss, bp - 56], ax);             /* mov [bp-0x38], ax */
            ii(0x19_6ce4, 3);  mov(memw[ss, bp - 54], dx);             /* mov [bp-0x36], dx */
            ii(0x19_6ce7, 4);  test(memb[ss, bp - 34], 1);             /* test byte [bp-0x22], 0x1 */
            ii(0x19_6ceb, 2);  if(jnz(0x19_6cf0, 3)) goto l_0x19_6cf0; /* jnz 0x6cf0 */
            ii(0x19_6ced, 3);  jmp(0x19_6cf3, 3); goto l_0x19_6cf3;    /* jmp 0x6cf3 */
        l_0x19_6cf0:
            ii(0x19_6cf0, 3);  jmp(0x19_7817, 0xb24); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6cf3:
            ii(0x19_6cf3, 4);  mov(ax, memw[ss, bp - 130]);            /* mov ax, [bp-0x82] */
            ii(0x19_6cf7, 3);  mov(dx, memw[ss, bp - 128]);            /* mov dx, [bp-0x80] */
            ii(0x19_6cfa, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_6cfd, 3);  mov(memw[ss, bp - 50], dx);             /* mov [bp-0x32], dx */
            ii(0x19_6d00, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_6d05, 3);  jmp(0x19_7817, 0xb0f); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_6d08, 3);  Недостижимый код.
        l_0x19_6d0b:
            ii(0x19_6d0b, 3);  jmp(0x19_633b, -0x9d3); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6d0e:
            ii(0x19_6d0e, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_6d11, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6d13, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_6d17, 5);  cmp(memw[ss, bp - 134], 0x10);          /* cmp word [bp-0x86], 0x10 */
            ii(0x19_6d1c, 2);  if(jb(0x19_6d21, 3)) goto l_0x19_6d21;  /* jb 0x6d21 */
            ii(0x19_6d1e, 3);  jmp(0x19_6d2e, 0xd); goto l_0x19_6d2e;  /* jmp 0x6d2e */
        l_0x19_6d21:
            ii(0x19_6d21, 4);  mov(bx, memw[ss, bp - 134]);            /* mov bx, [bp-0x86] */
            ii(0x19_6d25, 4);  mov(al, memb[ds, bx + 0x1566]);         /* mov al, [bx+0x1566] */
            ii(0x19_6d29, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_6d2b, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
        l_0x19_6d2e:
            ii(0x19_6d2e, 5);  cmp(memw[ss, bp - 134], 0x10);          /* cmp word [bp-0x86], 0x10 */
            ii(0x19_6d33, 2);  if(jb(0x19_6d38, 3)) goto l_0x19_6d38;  /* jb 0x6d38 */
            ii(0x19_6d35, 3);  jmp(0x19_6d4c, 0x14); goto l_0x19_6d4c; /* jmp 0x6d4c */
        l_0x19_6d38:
            ii(0x19_6d38, 4);  mov(bx, memw[ss, bp - 134]);            /* mov bx, [bp-0x86] */
            ii(0x19_6d3c, 5);  cmp(memb[ds, bx + 0x1556], 0);          /* cmp byte [bx+0x1556], 0x0 */
            ii(0x19_6d41, 2);  if(jnz(0x19_6d46, 3)) goto l_0x19_6d46; /* jnz 0x6d46 */
            ii(0x19_6d43, 3);  jmp(0x19_6d4c, 6); goto l_0x19_6d4c;    /* jmp 0x6d4c */
        l_0x19_6d46:
            ii(0x19_6d46, 3);  jmp(0x19_6442, -0x907); goto l_0x19_6442;/* jmp 0x6442 */
        //  ii(0x19_6d49, 3);  Недостижимый код.
        l_0x19_6d4c:
            ii(0x19_6d4c, 3);  jmp(0x19_633b, -0xa14); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6d4f:
            ii(0x19_6d4f, 5);  mov(memw[ss, bp - 126], 0);             /* mov word [bp-0x7e], 0x0 */
            ii(0x19_6d54, 3);  mov(ax, memw[ss, bp - 64]);             /* mov ax, [bp-0x40] */
            ii(0x19_6d57, 3);  mov(dx, memw[ss, bp - 62]);             /* mov dx, [bp-0x3e] */
            ii(0x19_6d5a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6d5c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6d5e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6d60, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6d62, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6d64, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6d66, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6d68, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6d6a, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_6d6e, 4);  mov(memw[ss, bp - 132], dx);            /* mov [bp-0x84], dx */
            ii(0x19_6d72, 4);  mov(ax, memw[ss, bp - 132]);            /* mov ax, [bp-0x84] */
            ii(0x19_6d76, 4);  or(ax, memw[ss, bp - 134]);             /* or ax, [bp-0x86] */
            ii(0x19_6d7a, 2);  if(jz(0x19_6d7f, 3)) goto l_0x19_6d7f;  /* jz 0x6d7f */
            ii(0x19_6d7c, 3);  jmp(0x19_6d82, 3); goto l_0x19_6d82;    /* jmp 0x6d82 */
        l_0x19_6d7f:
            ii(0x19_6d7f, 3);  jmp(0x19_6e04, 0x82); goto l_0x19_6e04; /* jmp 0x6e04 */
        l_0x19_6d82:
            ii(0x19_6d82, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_6d85, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_6d8a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6d8d, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6d90, 2);  if(jz(0x19_6d95, 3)) goto l_0x19_6d95;  /* jz 0x6d95 */
            ii(0x19_6d92, 3);  jmp(0x19_6de5, 0x50); goto l_0x19_6de5; /* jmp 0x6de5 */
        l_0x19_6d95:
            ii(0x19_6d95, 5);  cmp(memb[ds, 0x1271], 0);               /* cmp byte [0x1271], 0x0 */
            ii(0x19_6d9a, 2);  if(jz(0x19_6d9f, 3)) goto l_0x19_6d9f;  /* jz 0x6d9f */
            ii(0x19_6d9c, 3);  jmp(0x19_6da2, 3); goto l_0x19_6da2;    /* jmp 0x6da2 */
        l_0x19_6d9f:
            ii(0x19_6d9f, 3);  jmp(0x19_633b, -0xa67); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6da2:
            ii(0x19_6da2, 3);  mov(ax, memw[ss, bp - 64]);             /* mov ax, [bp-0x40] */
            ii(0x19_6da5, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x19_6da7, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6da9, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6dab, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6dad, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6daf, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6db1, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6db3, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6db5, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6db7, 1);  push(dx);                               /* push dx */
            ii(0x19_6db8, 1);  push(ax);                               /* push ax */
            ii(0x19_6db9, 1);  nop();                                  /* nop */
            ii(0x19_6dba, 1);  push(cs);                               /* push cs */
            ii(0x19_6dbb, 3);  call(0x19_79c1, 0xc03);                 /* call 0x79c1 */
            ii(0x19_6dbe, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6dc1, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_6dc4, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6dc7, 2);  if(jz(0x19_6dcc, 3)) goto l_0x19_6dcc;  /* jz 0x6dcc */
            ii(0x19_6dc9, 3);  jmp(0x19_6dcf, 3); goto l_0x19_6dcf;    /* jmp 0x6dcf */
        l_0x19_6dcc:
            ii(0x19_6dcc, 3);  jmp(0x19_6e04, 0x35); goto l_0x19_6e04; /* jmp 0x6e04 */
        l_0x19_6dcf:
            ii(0x19_6dcf, 4);  and(memw[ss, bp - 34], -2 /* 0xfe */);  /* and word [bp-0x22], 0xfffe */
            ii(0x19_6dd3, 4);  and(memw[ss, bp - 32], -1 /* 0xff */);  /* and word [bp-0x20], 0xffff */
            ii(0x19_6dd7, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_6dda, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_6ddd, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6de2, 3);  jmp(0x19_7817, 0xa32); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6de5:
            ii(0x19_6de5, 5);  cmp(memw[ss, bp - 132], 1);             /* cmp word [bp-0x84], 0x1 */
            ii(0x19_6dea, 2);  if(jbe(0x19_6def, 3)) goto l_0x19_6def; /* jbe 0x6def */
            ii(0x19_6dec, 3);  jmp(0x19_6e01, 0x12); goto l_0x19_6e01; /* jmp 0x6e01 */
        l_0x19_6def:
            ii(0x19_6def, 2);  if(jae(0x19_6df4, 3)) goto l_0x19_6df4; /* jae 0x6df4 */
            ii(0x19_6df1, 3);  jmp(0x19_6dfe, 0xa); goto l_0x19_6dfe;  /* jmp 0x6dfe */
        l_0x19_6df4:
            ii(0x19_6df4, 5);  cmp(memw[ss, bp - 134], 0);             /* cmp word [bp-0x86], 0x0 */
            ii(0x19_6df9, 2);  if(jb(0x19_6dfe, 3)) goto l_0x19_6dfe;  /* jb 0x6dfe */
            ii(0x19_6dfb, 3);  jmp(0x19_6e01, 3); goto l_0x19_6e01;    /* jmp 0x6e01 */
        l_0x19_6dfe:
            ii(0x19_6dfe, 3);  jmp(0x19_633b, -0xac6); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6e01:
            ii(0x19_6e01, 3);  jmp(0x19_6e04, 0); goto l_0x19_6e04;    /* jmp 0x6e04 */
        l_0x19_6e04:
            ii(0x19_6e04, 5);  mov(memw[ss, bp - 52], 8);              /* mov word [bp-0x34], 0x8 */
            ii(0x19_6e09, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6e0e, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_6e10, 3);  mov(memw[ss, bp - 62], ax);             /* mov [bp-0x3e], ax */
            ii(0x19_6e13, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_6e16, 4);  or(memw[ss, bp - 34], 1);               /* or word [bp-0x22], 0x1 */
            ii(0x19_6e1a, 4);  or(memw[ss, bp - 32], 0);               /* or word [bp-0x20], 0x0 */
            ii(0x19_6e1e, 3);  jmp(0x19_7817, 0x9f6); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6e21:
            ii(0x19_6e21, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_6e24, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_6e29, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6e2c, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6e2f, 2);  if(jnz(0x19_6e34, 3)) goto l_0x19_6e34; /* jnz 0x6e34 */
            ii(0x19_6e31, 3);  jmp(0x19_6e7b, 0x47); goto l_0x19_6e7b; /* jmp 0x6e7b */
        l_0x19_6e34:
            ii(0x19_6e34, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6e37, 4);  lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x19_6e3b, 5);  mov(memd[ss, bp - 134], eax);           /* mov [bp-0x86], eax */
            ii(0x19_6e40, 5);  add(memw[ss, bp - 134], 1);             /* add word [bp-0x86], 0x1 */
            ii(0x19_6e45, 5);  adc(memw[ss, bp - 132], 0);             /* adc word [bp-0x84], 0x0 */
            ii(0x19_6e4a, 5);  cmp(memw[ss, bp - 132], 1);             /* cmp word [bp-0x84], 0x1 */
            ii(0x19_6e4f, 2);  if(jbe(0x19_6e54, 3)) goto l_0x19_6e54; /* jbe 0x6e54 */
            ii(0x19_6e51, 3);  jmp(0x19_6e66, 0x12); goto l_0x19_6e66; /* jmp 0x6e66 */
        l_0x19_6e54:
            ii(0x19_6e54, 2);  if(jae(0x19_6e59, 3)) goto l_0x19_6e59; /* jae 0x6e59 */
            ii(0x19_6e56, 3);  jmp(0x19_6e63, 0xa); goto l_0x19_6e63;  /* jmp 0x6e63 */
        l_0x19_6e59:
            ii(0x19_6e59, 5);  cmp(memw[ss, bp - 134], 0);             /* cmp word [bp-0x86], 0x0 */
            ii(0x19_6e5e, 2);  if(jb(0x19_6e63, 3)) goto l_0x19_6e63;  /* jb 0x6e63 */
            ii(0x19_6e60, 3);  jmp(0x19_6e66, 3); goto l_0x19_6e66;    /* jmp 0x6e66 */
        l_0x19_6e63:
            ii(0x19_6e63, 3);  jmp(0x19_633b, -0xb2b); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6e66:
            ii(0x19_6e66, 5);  mov(memw[ss, bp - 52], 9);              /* mov word [bp-0x34], 0x9 */
            ii(0x19_6e6b, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6e70, 4);  or(memw[ss, bp - 34], 1);               /* or word [bp-0x22], 0x1 */
            ii(0x19_6e74, 4);  or(memw[ss, bp - 32], 0);               /* or word [bp-0x20], 0x0 */
            ii(0x19_6e78, 3);  jmp(0x19_7817, 0x99c); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6e7b:
            ii(0x19_6e7b, 3);  mov(ax, memw[ds, 0x1290]);              /* mov ax, [0x1290] */
            ii(0x19_6e7e, 4);  or(ax, memw[ds, 0x128e]);               /* or ax, [0x128e] */
            ii(0x19_6e82, 2);  if(jz(0x19_6e87, 3)) goto l_0x19_6e87;  /* jz 0x6e87 */
            ii(0x19_6e84, 3);  jmp(0x19_6e8a, 3); goto l_0x19_6e8a;    /* jmp 0x6e8a */
        l_0x19_6e87:
            ii(0x19_6e87, 3);  jmp(0x19_633b, -0xb4f); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6e8a:
            ii(0x19_6e8a, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6e8d, 3);  shr(ax, 3);                             /* shr ax, 0x3 */
            ii(0x19_6e90, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_6e92, 3);  mov(cx, 0x50);                          /* mov cx, 0x50 */
            ii(0x19_6e95, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_6e97, 4);  test(memb[es, bx], 1);                  /* test byte [es:bx], 0x1 */
            ii(0x19_6e9b, 2);  if(jz(0x19_6ea0, 3)) goto l_0x19_6ea0;  /* jz 0x6ea0 */
            ii(0x19_6e9d, 3);  jmp(0x19_6ea3, 3); goto l_0x19_6ea3;    /* jmp 0x6ea3 */
        l_0x19_6ea0:
            ii(0x19_6ea0, 3);  jmp(0x19_633b, -0xb68); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6ea3:
            ii(0x19_6ea3, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6ea6, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_6ea8, 1);  push(ax);                               /* push ax */
            ii(0x19_6ea9, 1);  push(cx);                               /* push cx */
            ii(0x19_6eaa, 5);  call_far_abs(0x80, 0x55dc);             /* call word 0x80:0x55dc */
            ii(0x19_6eaf, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6eb2, 1);  push(dx);                               /* push dx */
            ii(0x19_6eb3, 1);  push(ax);                               /* push ax */
            ii(0x19_6eb4, 4);  call_far_ind(memw[ds, 0x128e]);         /* call far word [0x128e] */
            ii(0x19_6eb8, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6ebb, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_6ebf, 5);  cmp(memw[ss, bp - 130], 0);             /* cmp word [bp-0x82], 0x0 */
            ii(0x19_6ec4, 2);  if(jg(0x19_6ec9, 3)) goto l_0x19_6ec9;  /* jg 0x6ec9 */
            ii(0x19_6ec6, 3);  jmp(0x19_6ecc, 3); goto l_0x19_6ecc;    /* jmp 0x6ecc */
        l_0x19_6ec9:
            ii(0x19_6ec9, 3);  jmp(0x19_633b, -0xb91); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6ecc:
            ii(0x19_6ecc, 5);  cmp(memw[ss, bp - 130], 0);             /* cmp word [bp-0x82], 0x0 */
            ii(0x19_6ed1, 2);  if(jl(0x19_6ed6, 3)) goto l_0x19_6ed6;  /* jl 0x6ed6 */
            ii(0x19_6ed3, 3);  jmp(0x19_6eee, 0x18); goto l_0x19_6eee; /* jmp 0x6eee */
        l_0x19_6ed6:
            ii(0x19_6ed6, 4);  or(memw[ss, bp - 34], 1);               /* or word [bp-0x22], 0x1 */
            ii(0x19_6eda, 4);  or(memw[ss, bp - 32], 0);               /* or word [bp-0x20], 0x0 */
            ii(0x19_6ede, 5);  mov(memw[ss, bp - 52], 9);              /* mov word [bp-0x34], 0x9 */
            ii(0x19_6ee3, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_6ee8, 3);  jmp(0x19_6f4c, 0x61); goto l_0x19_6f4c; /* jmp 0x6f4c */
        //  ii(0x19_6eeb, 3);  Недостижимый код.
        l_0x19_6eee:
            ii(0x19_6eee, 4);  and(memw[ss, bp - 34], -2 /* 0xfe */);  /* and word [bp-0x22], 0xfffe */
            ii(0x19_6ef2, 4);  and(memw[ss, bp - 32], -1 /* 0xff */);  /* and word [bp-0x20], 0xffff */
            ii(0x19_6ef6, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6ef9, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_6efd, 4);  mov(ax, memw[ss, bp - 130]);            /* mov ax, [bp-0x82] */
            ii(0x19_6f01, 3);  sar(ax, 3);                             /* sar ax, 0x3 */
            ii(0x19_6f04, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_6f06, 3);  mov(cx, 0x50);                          /* mov cx, 0x50 */
            ii(0x19_6f09, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_6f0b, 4);  mov(memb[es, bx], 0);                   /* mov byte [es:bx], 0x0 */
            ii(0x19_6f0f, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_6f12, 4);  mov(bx, memw[ss, bp - 130]);            /* mov bx, [bp-0x82] */
            ii(0x19_6f16, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_6f18, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6f1b, 3);  shr(ax, 3);                             /* shr ax, 0x3 */
            ii(0x19_6f1e, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_6f20, 3);  mov(cx, 0x50);                          /* mov cx, 0x50 */
            ii(0x19_6f23, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_6f25, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_6f28, 1);  cbw();                                  /* cbw */
            ii(0x19_6f29, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_6f2d, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6f30, 3);  shr(ax, 3);                             /* shr ax, 0x3 */
            ii(0x19_6f33, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_6f35, 3);  mov(cx, 0x50);                          /* mov cx, 0x50 */
            ii(0x19_6f38, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x19_6f3a, 4);  mov(memb[es, bx], 0);                   /* mov byte [es:bx], 0x0 */
            ii(0x19_6f3e, 4);  add(memw[ss, bp - 86], 8);              /* add word [bp-0x56], 0x8 */
            ii(0x19_6f42, 5);  test(memb[ss, bp - 130], 2);            /* test byte [bp-0x82], 0x2 */
            ii(0x19_6f47, 2);  if(jz(0x19_6f4c, 3)) goto l_0x19_6f4c;  /* jz 0x6f4c */
            ii(0x19_6f49, 3);  jmp(0x19_6e8a, -0xc2); goto l_0x19_6e8a;/* jmp 0x6e8a */
        l_0x19_6f4c:
            ii(0x19_6f4c, 5);  mov(memw[ss, bp - 86], 0);              /* mov word [bp-0x56], 0x0 */
            ii(0x19_6f51, 3);  jmp(0x19_7817, 0x8c3); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6f54:
            ii(0x19_6f54, 3);  mov(ax, memw[ss, bp - 64]);             /* mov ax, [bp-0x40] */
            ii(0x19_6f57, 3);  mov(dx, memw[ss, bp - 62]);             /* mov dx, [bp-0x3e] */
            ii(0x19_6f5a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6f5c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6f5e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6f60, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6f62, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6f64, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6f66, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_6f68, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_6f6a, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_6f6e, 4);  mov(memw[ss, bp - 132], dx);            /* mov [bp-0x84], dx */
            ii(0x19_6f72, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6f75, 4);  lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x19_6f79, 4);  mov(memd[ss, bp - 126], eax);           /* mov [bp-0x7e], eax */
            ii(0x19_6f7d, 4);  add(memw[ss, bp - 126], 1);             /* add word [bp-0x7e], 0x1 */
            ii(0x19_6f81, 4);  adc(memw[ss, bp - 124], 0);             /* adc word [bp-0x7c], 0x0 */
            ii(0x19_6f85, 4);  mov(ax, memw[ss, bp - 132]);            /* mov ax, [bp-0x84] */
            ii(0x19_6f89, 4);  or(ax, memw[ss, bp - 134]);             /* or ax, [bp-0x86] */
            ii(0x19_6f8d, 2);  if(jz(0x19_6f92, 3)) goto l_0x19_6f92;  /* jz 0x6f92 */
            ii(0x19_6f8f, 3);  jmp(0x19_6f95, 3); goto l_0x19_6f95;    /* jmp 0x6f95 */
        l_0x19_6f92:
            ii(0x19_6f92, 3);  jmp(0x19_71ee, 0x259); goto l_0x19_71ee;/* jmp 0x71ee */
        l_0x19_6f95:
            ii(0x19_6f95, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_6f98, 3);  mov(dx, memw[ss, bp - 124]);            /* mov dx, [bp-0x7c] */
            ii(0x19_6f9b, 4);  cmp(memw[ss, bp - 134], ax);            /* cmp [bp-0x86], ax */
            ii(0x19_6f9f, 2);  if(jz(0x19_6fa4, 3)) goto l_0x19_6fa4;  /* jz 0x6fa4 */
            ii(0x19_6fa1, 3);  jmp(0x19_6fb8, 0x14); goto l_0x19_6fb8; /* jmp 0x6fb8 */
        l_0x19_6fa4:
            ii(0x19_6fa4, 4);  cmp(memw[ss, bp - 132], dx);            /* cmp [bp-0x84], dx */
            ii(0x19_6fa8, 2);  if(jz(0x19_6fad, 3)) goto l_0x19_6fad;  /* jz 0x6fad */
            ii(0x19_6faa, 3);  jmp(0x19_6fb8, 0xb); goto l_0x19_6fb8;  /* jmp 0x6fb8 */
        l_0x19_6fad:
            ii(0x19_6fad, 4);  and(memw[ss, bp - 34], -2 /* 0xfe */);  /* and word [bp-0x22], 0xfffe */
            ii(0x19_6fb1, 4);  and(memw[ss, bp - 32], -1 /* 0xff */);  /* and word [bp-0x20], 0xffff */
            ii(0x19_6fb5, 3);  jmp(0x19_7817, 0x85f); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_6fb8:
            ii(0x19_6fb8, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x19_6fbb, 5);  call_far_abs(0x80, 0xf64);              /* call word 0x80:0xf64 */
            ii(0x19_6fc0, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_6fc3, 3);  cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x19_6fc6, 2);  if(jz(0x19_6fcb, 3)) goto l_0x19_6fcb;  /* jz 0x6fcb */
            ii(0x19_6fc8, 3);  jmp(0x19_6fce, 3); goto l_0x19_6fce;    /* jmp 0x6fce */
        l_0x19_6fcb:
            ii(0x19_6fcb, 3);  jmp(0x19_633b, -0xc93); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_6fce:
            ii(0x19_6fce, 3);  mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x19_6fd1, 3);  mov(bx, memw[ss, bp - 86]);             /* mov bx, [bp-0x56] */
            ii(0x19_6fd4, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_6fd6, 2);  if(jb(0x19_6f92, -0x46)) goto l_0x19_6f92;/* jb 0x6f92 */
            ii(0x19_6fd8, 3);  mov(memw[ss, bp - 122], dx);            /* mov [bp-0x7a], dx */
            ii(0x19_6fdb, 3);  mov(memw[ss, bp - 120], cx);            /* mov [bp-0x78], cx */
            ii(0x19_6fde, 2);  or(dx, cx);                             /* or dx, cx */
            ii(0x19_6fe0, 2);  if(jz(0x19_6f92, -0x50)) goto l_0x19_6f92;/* jz 0x6f92 */
            ii(0x19_6fe2, 3);  mov(ax, memw[ds, 0x1294]);              /* mov ax, [0x1294] */
            ii(0x19_6fe5, 4);  or(ax, memw[ds, 0x1292]);               /* or ax, [0x1292] */
            ii(0x19_6fe9, 2);  if(jnz(0x19_6fee, 3)) goto l_0x19_6fee; /* jnz 0x6fee */
            ii(0x19_6feb, 3);  jmp(0x19_71ee, 0x200); goto l_0x19_71ee;/* jmp 0x71ee */
        l_0x19_6fee:
            ii(0x19_6fee, 4);  lea(ax, memw[ss, bp - 196]);            /* lea ax, [bp-0xc4] */
            ii(0x19_6ff2, 1);  push(ss);                               /* push ss */
            ii(0x19_6ff3, 1);  push(ax);                               /* push ax */
            ii(0x19_6ff4, 4);  call_far_ind(memw[ds, 0x1292]);         /* call far word [0x1292] */
            ii(0x19_6ff8, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_6ffb, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_6ffe, 4);  cmp(memw[ss, bp - 142], ax);            /* cmp [bp-0x8e], ax */
            ii(0x19_7002, 2);  if(jz(0x19_7007, 3)) goto l_0x19_7007;  /* jz 0x7007 */
            ii(0x19_7004, 3);  jmp(0x19_703b, 0x34); goto l_0x19_703b; /* jmp 0x703b */
        l_0x19_7007:
            ii(0x19_7007, 4);  mov(ax, memw[ss, bp - 192]);            /* mov ax, [bp-0xc0] */
            ii(0x19_700b, 4);  lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x19_700f, 4);  mov(memd[ss, bp - 126], eax);           /* mov [bp-0x7e], eax */
            ii(0x19_7013, 4);  add(memw[ss, bp - 126], 1);             /* add word [bp-0x7e], 0x1 */
            ii(0x19_7017, 4);  adc(memw[ss, bp - 124], 0);             /* adc word [bp-0x7c], 0x0 */
            ii(0x19_701b, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_701e, 3);  mov(dx, memw[ss, bp - 124]);            /* mov dx, [bp-0x7c] */
            ii(0x19_7021, 4);  cmp(memw[ss, bp - 132], dx);            /* cmp [bp-0x84], dx */
            ii(0x19_7025, 2);  if(jae(0x19_702a, 3)) goto l_0x19_702a; /* jae 0x702a */
            ii(0x19_7027, 3);  jmp(0x19_703b, 0x11); goto l_0x19_703b; /* jmp 0x703b */
        l_0x19_702a:
            ii(0x19_702a, 2);  if(jbe(0x19_702f, 3)) goto l_0x19_702f; /* jbe 0x702f */
            ii(0x19_702c, 3);  jmp(0x19_7038, 9); goto l_0x19_7038;    /* jmp 0x7038 */
        l_0x19_702f:
            ii(0x19_702f, 4);  cmp(memw[ss, bp - 134], ax);            /* cmp [bp-0x86], ax */
            ii(0x19_7033, 2);  if(ja(0x19_7038, 3)) goto l_0x19_7038;  /* ja 0x7038 */
            ii(0x19_7035, 3);  jmp(0x19_703b, 3); goto l_0x19_703b;    /* jmp 0x703b */
        l_0x19_7038:
            ii(0x19_7038, 3);  jmp(0x19_71ee, 0x1b3); goto l_0x19_71ee;/* jmp 0x71ee */
        l_0x19_703b:
            ii(0x19_703b, 4);  mov(ax, memw[ss, bp - 156]);            /* mov ax, [bp-0x9c] */
            ii(0x19_703f, 4);  mov(cx, memw[ss, bp - 168]);            /* mov cx, [bp-0xa8] */
            ii(0x19_7043, 4);  mov(memw[ss, bp - 200], cx);            /* mov [bp-0xc8], cx */
            ii(0x19_7047, 4);  mov(memw[ss, bp - 198], ax);            /* mov [bp-0xc6], ax */
            ii(0x19_704b, 5);  mov(memw[ss, bp - 116], 0);             /* mov word [bp-0x74], 0x0 */
            ii(0x19_7050, 3);  jmp(0x19_7056, 3); goto l_0x19_7056;    /* jmp 0x7056 */
        l_0x19_7053:
            ii(0x19_7053, 3);  inc(memw[ss, bp - 116]);                /* inc word [bp-0x74] */
        l_0x19_7056:
            ii(0x19_7056, 3);  mov(ax, memw[ss, bp - 116]);            /* mov ax, [bp-0x74] */
            ii(0x19_7059, 1);  cwd();                                  /* cwd */
            ii(0x19_705a, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_705e, 4);  cmp(memw[es, bx + 2], dx);              /* cmp [es:bx+0x2], dx */
            ii(0x19_7062, 2);  if(jae(0x19_7067, 3)) goto l_0x19_7067; /* jae 0x7067 */
            ii(0x19_7064, 3);  jmp(0x19_71ee, 0x187); goto l_0x19_71ee;/* jmp 0x71ee */
        l_0x19_7067:
            ii(0x19_7067, 2);  if(jbe(0x19_706c, 3)) goto l_0x19_706c; /* jbe 0x706c */
            ii(0x19_7069, 3);  jmp(0x19_7074, 8); goto l_0x19_7074;    /* jmp 0x7074 */
        l_0x19_706c:
            ii(0x19_706c, 3);  cmp(memw[es, bx], ax);                  /* cmp [es:bx], ax */
            ii(0x19_706f, 2);  if(ja(0x19_7074, 3)) goto l_0x19_7074;  /* ja 0x7074 */
            ii(0x19_7071, 3);  jmp(0x19_71ee, 0x17a); goto l_0x19_71ee;/* jmp 0x71ee */
        l_0x19_7074:
            ii(0x19_7074, 3);  mov(ax, memw[ss, bp - 122]);            /* mov ax, [bp-0x7a] */
            ii(0x19_7077, 3);  mov(dx, memw[ss, bp - 120]);            /* mov dx, [bp-0x78] */
            ii(0x19_707a, 3);  mov(si, memw[ss, bp - 116]);            /* mov si, [bp-0x74] */
            ii(0x19_707d, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x19_707f, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x19_7081, 2);  add(si, cx);                            /* add si, cx */
            ii(0x19_7083, 3);  shl(si, 2);                             /* shl si, 0x2 */
            ii(0x19_7086, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_708a, 4);  cmp(memw[es, bx + si + 4], ax);         /* cmp [es:bx+si+0x4], ax */
            ii(0x19_708e, 2);  if(jz(0x19_7093, 3)) goto l_0x19_7093;  /* jz 0x7093 */
            ii(0x19_7090, 3);  jmp(0x19_71eb, 0x158); goto l_0x19_71eb;/* jmp 0x71eb */
        l_0x19_7093:
            ii(0x19_7093, 4);  cmp(memw[es, bx + si + 6], dx);         /* cmp [es:bx+si+0x6], dx */
            ii(0x19_7097, 2);  if(jz(0x19_709c, 3)) goto l_0x19_709c;  /* jz 0x709c */
            ii(0x19_7099, 3);  jmp(0x19_71eb, 0x14f); goto l_0x19_71eb;/* jmp 0x71eb */
        l_0x19_709c:
            ii(0x19_709c, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_709f, 4);  cmp(memw[ss, bp - 142], ax);            /* cmp [bp-0x8e], ax */
            ii(0x19_70a3, 2);  if(jz(0x19_70a8, 3)) goto l_0x19_70a8;  /* jz 0x70a8 */
            ii(0x19_70a5, 3);  jmp(0x19_70b8, 0x10); goto l_0x19_70b8; /* jmp 0x70b8 */
        l_0x19_70a8:
            ii(0x19_70a8, 3);  mov(ax, memw[ss, bp - 122]);            /* mov ax, [bp-0x7a] */
            ii(0x19_70ab, 3);  mov(dx, memw[ss, bp - 120]);            /* mov dx, [bp-0x78] */
            ii(0x19_70ae, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_70b2, 3);  mov(memw[ss, bp - 128], dx);            /* mov [bp-0x80], dx */
            ii(0x19_70b5, 3);  jmp(0x19_716e, 0xb6); goto l_0x19_716e; /* jmp 0x716e */
        l_0x19_70b8:
            ii(0x19_70b8, 3);  mov(si, memw[ss, bp - 116]);            /* mov si, [bp-0x74] */
            ii(0x19_70bb, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x19_70bd, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x19_70bf, 2);  add(si, ax);                            /* add si, ax */
            ii(0x19_70c1, 3);  shl(si, 2);                             /* shl si, 0x2 */
            ii(0x19_70c4, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_70c8, 4);  mov(ax, memw[es, bx + si + 12]);        /* mov ax, [es:bx+si+0xc] */
            ii(0x19_70cc, 4);  mov(dx, memw[es, bx + si + 14]);        /* mov dx, [es:bx+si+0xe] */
            ii(0x19_70d0, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_70d3, 3);  mov(memw[ss, bp - 100], dx);            /* mov [bp-0x64], dx */
            ii(0x19_70d6, 1);  push(si);                               /* push si */
            ii(0x19_70d7, 1);  push(di);                               /* push di */
            ii(0x19_70d8, 3);  mov(ax, 0x503);                         /* mov ax, 0x503 */
            ii(0x19_70db, 4);  mov(bx, memw[ss, bp - 132]);            /* mov bx, [bp-0x84] */
            ii(0x19_70df, 4);  mov(cx, memw[ss, bp - 134]);            /* mov cx, [bp-0x86] */
            ii(0x19_70e3, 3);  mov(si, memw[ss, bp - 100]);            /* mov si, [bp-0x64] */
            ii(0x19_70e6, 3);  mov(di, memw[ss, bp - 102]);            /* mov di, [bp-0x66] */
            ii(0x19_70e9, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_70eb, 3);  mov(memw[ss, bp - 108], si);            /* mov [bp-0x6c], si */
            ii(0x19_70ee, 3);  mov(memw[ss, bp - 110], di);            /* mov [bp-0x6e], di */
            ii(0x19_70f1, 1);  pop(di);                                /* pop di */
            ii(0x19_70f2, 1);  pop(si);                                /* pop si */
            ii(0x19_70f3, 2);  if(jae(0x19_710a, 0x15)) goto l_0x19_710a;/* jae 0x710a */
            ii(0x19_70f5, 5);  mov(memw[ss, bp - 52], 8);              /* mov word [bp-0x34], 0x8 */
            ii(0x19_70fa, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_70ff, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_7101, 3);  mov(memw[ss, bp - 62], ax);             /* mov [bp-0x3e], ax */
            ii(0x19_7104, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_7107, 3);  jmp(0x19_71f8, 0xee); goto l_0x19_71f8; /* jmp 0x71f8 */
        l_0x19_710a:
            ii(0x19_710a, 3);  mov(memw[ss, bp - 128], bx);            /* mov [bp-0x80], bx */
            ii(0x19_710d, 4);  mov(memw[ss, bp - 130], cx);            /* mov [bp-0x82], cx */
            ii(0x19_7111, 4);  mov(ax, memw[ss, bp - 130]);            /* mov ax, [bp-0x82] */
            ii(0x19_7115, 3);  mov(dx, memw[ss, bp - 128]);            /* mov dx, [bp-0x80] */
            ii(0x19_7118, 3);  mov(si, memw[ss, bp - 116]);            /* mov si, [bp-0x74] */
            ii(0x19_711b, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x19_711d, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x19_711f, 2);  add(si, cx);                            /* add si, cx */
            ii(0x19_7121, 3);  shl(si, 2);                             /* shl si, 0x2 */
            ii(0x19_7124, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_7128, 4);  mov(memw[es, bx + si + 4], ax);         /* mov [es:bx+si+0x4], ax */
            ii(0x19_712c, 4);  mov(memw[es, bx + si + 6], dx);         /* mov [es:bx+si+0x6], dx */
            ii(0x19_7130, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_7134, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_7138, 3);  mov(si, memw[ss, bp - 116]);            /* mov si, [bp-0x74] */
            ii(0x19_713b, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x19_713d, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x19_713f, 2);  add(si, cx);                            /* add si, cx */
            ii(0x19_7141, 3);  shl(si, 2);                             /* shl si, 0x2 */
            ii(0x19_7144, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_7148, 4);  mov(memw[es, bx + si + 8], ax);         /* mov [es:bx+si+0x8], ax */
            ii(0x19_714c, 4);  mov(memw[es, bx + si + 10], dx);        /* mov [es:bx+si+0xa], dx */
            ii(0x19_7150, 3);  mov(ax, memw[ss, bp - 110]);            /* mov ax, [bp-0x6e] */
            ii(0x19_7153, 3);  mov(dx, memw[ss, bp - 108]);            /* mov dx, [bp-0x6c] */
            ii(0x19_7156, 3);  mov(si, memw[ss, bp - 116]);            /* mov si, [bp-0x74] */
            ii(0x19_7159, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x19_715b, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x19_715d, 2);  add(si, cx);                            /* add si, cx */
            ii(0x19_715f, 3);  shl(si, 2);                             /* shl si, 0x2 */
            ii(0x19_7162, 4);  les(bx, memw[ss, bp - 200]);            /* les bx, [bp-0xc8] */
            ii(0x19_7166, 4);  mov(memw[es, bx + si + 12], ax);        /* mov [es:bx+si+0xc], ax */
            ii(0x19_716a, 4);  mov(memw[es, bx + si + 14], dx);        /* mov [es:bx+si+0xe], dx */
        l_0x19_716e:
            ii(0x19_716e, 3);  push(memw[ss, bp - 128]);               /* push word [bp-0x80] */
            ii(0x19_7171, 4);  push(memw[ss, bp - 130]);               /* push word [bp-0x82] */
            ii(0x19_7175, 4);  push(memw[ss, bp - 132]);               /* push word [bp-0x84] */
            ii(0x19_7179, 4);  push(memw[ss, bp - 134]);               /* push word [bp-0x86] */
            ii(0x19_717d, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_7180, 3);  call(0x19_61f0, -0xf93);                /* call 0x61f0 */
            ii(0x19_7183, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x19_7186, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_7189, 4);  cmp(memw[ss, bp - 192], ax);            /* cmp [bp-0xc0], ax */
            ii(0x19_718d, 2);  if(jz(0x19_7192, 3)) goto l_0x19_7192;  /* jz 0x7192 */
            ii(0x19_718f, 3);  jmp(0x19_71e8, 0x56); goto l_0x19_71e8; /* jmp 0x71e8 */
        l_0x19_7192:
            ii(0x19_7192, 4);  mov(ax, memw[ss, bp - 142]);            /* mov ax, [bp-0x8e] */
            ii(0x19_7196, 4);  lsl(eax, ax);                           /* lsl eax, ax */
            ii(0x19_719a, 4);  mov(memd[ss, bp - 126], eax);           /* mov [bp-0x7e], eax */
            ii(0x19_719e, 4);  add(memw[ss, bp - 126], 1);             /* add word [bp-0x7e], 0x1 */
            ii(0x19_71a2, 4);  adc(memw[ss, bp - 124], 0);             /* adc word [bp-0x7c], 0x0 */
            ii(0x19_71a6, 3);  mov(ax, memw[ss, bp - 126]);            /* mov ax, [bp-0x7e] */
            ii(0x19_71a9, 3);  mov(dx, memw[ss, bp - 124]);            /* mov dx, [bp-0x7c] */
            ii(0x19_71ac, 4);  cmp(memw[ss, bp - 132], dx);            /* cmp [bp-0x84], dx */
            ii(0x19_71b0, 2);  if(jbe(0x19_71b5, 3)) goto l_0x19_71b5; /* jbe 0x71b5 */
            ii(0x19_71b2, 3);  jmp(0x19_71d1, 0x1c); goto l_0x19_71d1; /* jmp 0x71d1 */
        l_0x19_71b5:
            ii(0x19_71b5, 2);  if(jae(0x19_71ba, 3)) goto l_0x19_71ba; /* jae 0x71ba */
            ii(0x19_71b7, 3);  jmp(0x19_71c3, 9); goto l_0x19_71c3;    /* jmp 0x71c3 */
        l_0x19_71ba:
            ii(0x19_71ba, 4);  cmp(memw[ss, bp - 134], ax);            /* cmp [bp-0x86], ax */
            ii(0x19_71be, 2);  if(jb(0x19_71c3, 3)) goto l_0x19_71c3;  /* jb 0x71c3 */
            ii(0x19_71c0, 3);  jmp(0x19_71d1, 0xe); goto l_0x19_71d1;  /* jmp 0x71d1 */
        l_0x19_71c3:
            ii(0x19_71c3, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_71c7, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_71cb, 3);  mov(memw[ss, bp - 126], ax);            /* mov [bp-0x7e], ax */
            ii(0x19_71ce, 3);  mov(memw[ss, bp - 124], dx);            /* mov [bp-0x7c], dx */
        l_0x19_71d1:
            ii(0x19_71d1, 3);  push(memw[ss, bp - 128]);               /* push word [bp-0x80] */
            ii(0x19_71d4, 4);  push(memw[ss, bp - 130]);               /* push word [bp-0x82] */
            ii(0x19_71d8, 3);  push(memw[ss, bp - 124]);               /* push word [bp-0x7c] */
            ii(0x19_71db, 3);  push(memw[ss, bp - 126]);               /* push word [bp-0x7e] */
            ii(0x19_71de, 4);  push(memw[ss, bp - 142]);               /* push word [bp-0x8e] */
            ii(0x19_71e2, 3);  call(0x19_61f0, -0xff5);                /* call 0x61f0 */
            ii(0x19_71e5, 3);  add(sp, 0xa);                           /* add sp, 0xa */
        l_0x19_71e8:
            ii(0x19_71e8, 3);  jmp(0x19_6fad, -0x23e); goto l_0x19_6fad;/* jmp 0x6fad */
        l_0x19_71eb:
            ii(0x19_71eb, 3);  jmp(0x19_7053, -0x19b); goto l_0x19_7053;/* jmp 0x7053 */
        l_0x19_71ee:
            ii(0x19_71ee, 5);  mov(memw[ss, bp - 52], 9);              /* mov word [bp-0x34], 0x9 */
            ii(0x19_71f3, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
        l_0x19_71f8:
            ii(0x19_71f8, 4);  or(memw[ss, bp - 34], 1);               /* or word [bp-0x22], 0x1 */
            ii(0x19_71fc, 4);  or(memw[ss, bp - 32], 0);               /* or word [bp-0x20], 0x0 */
            ii(0x19_7200, 3);  jmp(0x19_7817, 0x614); goto l_0x19_7817;/* jmp 0x7817 */
        l_0x19_7203:
            ii(0x19_7203, 2);  push(0);                                /* push 0x0 */
            ii(0x19_7205, 1);  nop();                                  /* nop */
            ii(0x19_7206, 1);  push(cs);                               /* push cs */
            ii(0x19_7207, 3);  call(0x18_f896, -0x7974);               /* call 0xf896 */
            ii(0x19_720a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_720d, 2);  push(0);                                /* push 0x0 */
            ii(0x19_720f, 2);  push(0x24);                             /* push 0x24 */
            ii(0x19_7211, 1);  nop();                                  /* nop */
            ii(0x19_7212, 1);  push(cs);                               /* push cs */
            ii(0x19_7213, 3);  call(0x19_606f, -0x11a7);               /* call 0x606f */
            ii(0x19_7216, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_7219, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_721c, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_721f, 3);  and(ax, memw[ss, bp - 60]);             /* and ax, [bp-0x3c] */
            ii(0x19_7222, 3);  and(dx, memw[ss, bp - 58]);             /* and dx, [bp-0x3a] */
            ii(0x19_7225, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_7227, 2);  if(jz(0x19_722c, 3)) goto l_0x19_722c;  /* jz 0x722c */
            ii(0x19_7229, 3);  jmp(0x19_723f, 0x13); goto l_0x19_723f; /* jmp 0x723f */
        l_0x19_722c:
            ii(0x19_722c, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_722f, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_7232, 3);  and(ax, memw[ss, bp - 64]);             /* and ax, [bp-0x40] */
            ii(0x19_7235, 3);  and(dx, memw[ss, bp - 62]);             /* and dx, [bp-0x3e] */
            ii(0x19_7238, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_723a, 2);  if(jnz(0x19_723f, 3)) goto l_0x19_723f; /* jnz 0x723f */
            ii(0x19_723c, 3);  jmp(0x19_7403, 0x1c4); goto l_0x19_7403;/* jmp 0x7403 */
        l_0x19_723f:
            ii(0x19_723f, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_7242, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_7246, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_7249, 3);  mov(memw[ss, bp - 122], ax);            /* mov [bp-0x7a], ax */
            ii(0x19_724c, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_724f, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_7252, 3);  mov(memw[ss, bp - 102], ax);            /* mov [bp-0x66], ax */
            ii(0x19_7255, 3);  mov(memw[ss, bp - 100], dx);            /* mov [bp-0x64], dx */
            ii(0x19_7258, 3);  mov(ax, memw[ss, bp - 64]);             /* mov ax, [bp-0x40] */
            ii(0x19_725b, 3);  mov(dx, memw[ss, bp - 62]);             /* mov dx, [bp-0x3e] */
            ii(0x19_725e, 3);  mov(memw[ss, bp - 116], ax);            /* mov [bp-0x74], ax */
            ii(0x19_7261, 3);  mov(memw[ss, bp - 114], dx);            /* mov [bp-0x72], dx */
            ii(0x19_7264, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_7267, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_726a, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_726d, 1);  nop();                                  /* nop */
            ii(0x19_726e, 1);  push(cs);                               /* push cs */
            ii(0x19_726f, 3);  call(0x19_789c, 0x62a);                 /* call 0x789c */
            ii(0x19_7272, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7275, 4);  mov(memw[ss, bp - 200], ax);            /* mov [bp-0xc8], ax */
            ii(0x19_7279, 3);  push(memw[ss, bp - 62]);                /* push word [bp-0x3e] */
            ii(0x19_727c, 3);  push(memw[ss, bp - 64]);                /* push word [bp-0x40] */
            ii(0x19_727f, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_7282, 1);  nop();                                  /* nop */
            ii(0x19_7283, 1);  push(cs);                               /* push cs */
            ii(0x19_7284, 3);  call(0x19_789c, 0x615);                 /* call 0x789c */
            ii(0x19_7287, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_728a, 4);  mov(memw[ss, bp - 196], ax);            /* mov [bp-0xc4], ax */
            ii(0x19_728e, 6);  mov(memw[ss, bp - 134], 0);             /* mov word [bp-0x86], 0x0 */
            ii(0x19_7294, 4);  mov(ax, memw[ss, bp - 196]);            /* mov ax, [bp-0xc4] */
            ii(0x19_7298, 5);  mov(memw[ss, bp - 110], 0);             /* mov word [bp-0x6e], 0x0 */
            ii(0x19_729d, 3);  mov(memw[ss, bp - 108], ax);            /* mov [bp-0x6c], ax */
            ii(0x19_72a0, 4);  lea(ax, memw[ss, bp - 214]);            /* lea ax, [bp-0xd6] */
            ii(0x19_72a4, 4);  mov(memw[ss, bp - 218], ax);            /* mov [bp-0xda], ax */
            ii(0x19_72a8, 4);  mov(memw[ss, bp - 216], ss);            /* mov [bp-0xd8], ss */
            ii(0x19_72ac, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_72af, 4);  mov(cx, memw[es, bx + 4]);              /* mov cx, [es:bx+0x4] */
            ii(0x19_72b3, 4);  mov(memw[ss, bp - 214], cx);            /* mov [bp-0xd6], cx */
            ii(0x19_72b7, 3);  cmp(cx, 0);                             /* cmp cx, 0x0 */
            ii(0x19_72ba, 2);  if(jnz(0x19_72bf, 3)) goto l_0x19_72bf; /* jnz 0x72bf */
            ii(0x19_72bc, 3);  jmp(0x19_732e, 0x6f); goto l_0x19_732e; /* jmp 0x732e */
        l_0x19_72bf:
            ii(0x19_72bf, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_72c2, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_72c6, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_72c9, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_72cc, 4);  push(memw[es, bx + 4]);                 /* push word [es:bx+0x4] */
            ii(0x19_72d0, 1);  nop();                                  /* nop */
            ii(0x19_72d1, 1);  push(cs);                               /* push cs */
            ii(0x19_72d2, 3);  call(0x19_789c, 0x5c7);                 /* call 0x789c */
            ii(0x19_72d5, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_72d8, 4);  mov(memw[ss, bp - 214], ax);            /* mov [bp-0xd6], ax */
            ii(0x19_72dc, 4);  mov(ax, memw[ss, bp - 214]);            /* mov ax, [bp-0xd6] */
            ii(0x19_72e0, 5);  mov(memw[ss, bp - 126], 0);             /* mov word [bp-0x7e], 0x0 */
            ii(0x19_72e5, 3);  mov(memw[ss, bp - 124], ax);            /* mov [bp-0x7c], ax */
        l_0x19_72e8:
            ii(0x19_72e8, 3);  les(bx, memw[ss, bp - 126]);            /* les bx, [bp-0x7e] */
            ii(0x19_72eb, 4);  mov(si, memw[ss, bp - 134]);            /* mov si, [bp-0x86] */
            ii(0x19_72ef, 4);  cmp(memw[es, bx + si], 0);              /* cmp word [es:bx+si], 0x0 */
            ii(0x19_72f3, 2);  if(jnz(0x19_72f8, 3)) goto l_0x19_72f8; /* jnz 0x72f8 */
            ii(0x19_72f5, 3);  jmp(0x19_72ff, 7); goto l_0x19_72ff;    /* jmp 0x72ff */
        l_0x19_72f8:
            ii(0x19_72f8, 4);  inc(memw[ss, bp - 134]);                /* inc word [bp-0x86] */
            ii(0x19_72fc, 3);  jmp(0x19_72e8, -0x17); goto l_0x19_72e8;/* jmp 0x72e8 */
        l_0x19_72ff:
            ii(0x19_72ff, 4);  lea(ax, memw[ss, bp - 226]);            /* lea ax, [bp-0xe2] */
            ii(0x19_7303, 1);  push(ss);                               /* push ss */
            ii(0x19_7304, 1);  push(ax);                               /* push ax */
            ii(0x19_7305, 4);  push(memw[ss, bp - 214]);               /* push word [bp-0xd6] */
            ii(0x19_7309, 5);  call_far_abs(0x80, 0x4f82);             /* call word 0x80:0x4f82 */
            ii(0x19_730e, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7311, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_7315, 3);  add(ax, 2);                             /* add ax, 0x2 */
            ii(0x19_7318, 4);  mov(memw[ss, bp - 226], ax);            /* mov [bp-0xe2], ax */
            ii(0x19_731c, 4);  lea(ax, memw[ss, bp - 226]);            /* lea ax, [bp-0xe2] */
            ii(0x19_7320, 1);  push(ss);                               /* push ss */
            ii(0x19_7321, 1);  push(ax);                               /* push ax */
            ii(0x19_7322, 4);  push(memw[ss, bp - 214]);               /* push word [bp-0xd6] */
            ii(0x19_7326, 5);  call_far_abs(0x80, 0x4ff4);             /* call word 0x80:0x4ff4 */
            ii(0x19_732b, 3);  add(sp, 6);                             /* add sp, 0x6 */
        l_0x19_732e:
            ii(0x19_732e, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_7331, 4);  push(memw[es, bx + 8]);                 /* push word [es:bx+0x8] */
            ii(0x19_7335, 4);  push(memw[es, bx + 6]);                 /* push word [es:bx+0x6] */
            ii(0x19_7339, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_733c, 4);  push(memw[es, bx + 10]);                /* push word [es:bx+0xa] */
            ii(0x19_7340, 1);  nop();                                  /* nop */
            ii(0x19_7341, 1);  push(cs);                               /* push cs */
            ii(0x19_7342, 3);  call(0x19_789c, 0x557);                 /* call 0x789c */
            ii(0x19_7345, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7348, 6);  mov(memw[ss, bp - 212], 0);             /* mov word [bp-0xd4], 0x0 */
            ii(0x19_734e, 4);  mov(memw[ss, bp - 210], ax);            /* mov [bp-0xd2], ax */
            ii(0x19_7352, 6);  mov(memw[ss, bp - 208], 0x1296);        /* mov word [bp-0xd0], 0x1296 */
            ii(0x19_7358, 4);  mov(memw[ss, bp - 206], ds);            /* mov [bp-0xce], ds */
            ii(0x19_735c, 6);  mov(memw[ss, bp - 204], 0x1296);        /* mov word [bp-0xcc], 0x1296 */
            ii(0x19_7362, 4);  mov(memw[ss, bp - 202], ds);            /* mov [bp-0xca], ds */
            ii(0x19_7366, 4);  mov(ax, memw[ss, bp - 200]);            /* mov ax, [bp-0xc8] */
            ii(0x19_736a, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_736d, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_736f, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_7372, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_7375, 4);  mov(ax, memw[ss, bp - 216]);            /* mov ax, [bp-0xd8] */
            ii(0x19_7379, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_737c, 4);  mov(ax, memw[ss, bp - 218]);            /* mov ax, [bp-0xda] */
            ii(0x19_7380, 3);  mov(memw[ss, bp - 64], ax);             /* mov [bp-0x40], ax */
            ii(0x19_7383, 5);  mov(memw[ss, bp - 62], 0);              /* mov word [bp-0x3e], 0x0 */
            ii(0x19_7388, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_738b, 1);  push(ss);                               /* push ss */
            ii(0x19_738c, 1);  push(ax);                               /* push ax */
            ii(0x19_738d, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_7390, 3);  call(0x19_61c1, -0x11d2);               /* call 0x61c1 */
            ii(0x19_7393, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7396, 3);  les(bx, memw[ss, bp - 110]);            /* les bx, [bp-0x6e] */
            ii(0x19_7399, 5);  cmp(memw[es, bx + 4], 1);               /* cmp word [es:bx+0x4], 0x1 */
            ii(0x19_739e, 2);  sbb(ax, ax);                            /* sbb ax, ax */
            ii(0x19_73a0, 3);  and(ax, 0xffff);                        /* and ax, 0xffff */
            ii(0x19_73a3, 3);  add(ax, 4);                             /* add ax, 0x4 */
            ii(0x19_73a6, 4);  sub(memw[ds, 0x1274], ax);              /* sub [0x1274], ax */
            ii(0x19_73aa, 4);  mov(ax, memw[ss, bp - 200]);            /* mov ax, [bp-0xc8] */
            ii(0x19_73ae, 3);  cmp(memw[ss, bp - 88], ax);             /* cmp [bp-0x58], ax */
            ii(0x19_73b1, 2);  if(jz(0x19_73b6, 3)) goto l_0x19_73b6;  /* jz 0x73b6 */
            ii(0x19_73b3, 3);  jmp(0x19_73c9, 0x13); goto l_0x19_73c9; /* jmp 0x73c9 */
        l_0x19_73b6:
            ii(0x19_73b6, 4);  mov(ax, memw[ss, bp - 130]);            /* mov ax, [bp-0x82] */
            ii(0x19_73ba, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_73bd, 3);  mov(ax, memw[ss, bp - 102]);            /* mov ax, [bp-0x66] */
            ii(0x19_73c0, 3);  mov(dx, memw[ss, bp - 100]);            /* mov dx, [bp-0x64] */
            ii(0x19_73c3, 3);  add(memw[ss, bp - 60], ax);             /* add [bp-0x3c], ax */
            ii(0x19_73c6, 3);  adc(memw[ss, bp - 58], dx);             /* adc [bp-0x3a], dx */
        l_0x19_73c9:
            ii(0x19_73c9, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_73cc, 4);  cmp(memw[ss, bp - 216], ax);            /* cmp [bp-0xd8], ax */
            ii(0x19_73d0, 2);  if(jz(0x19_73d5, 3)) goto l_0x19_73d5;  /* jz 0x73d5 */
            ii(0x19_73d2, 3);  jmp(0x19_73e7, 0x12); goto l_0x19_73e7; /* jmp 0x73e7 */
        l_0x19_73d5:
            ii(0x19_73d5, 3);  mov(ax, memw[ss, bp - 122]);            /* mov ax, [bp-0x7a] */
            ii(0x19_73d8, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_73db, 3);  mov(ax, memw[ss, bp - 116]);            /* mov ax, [bp-0x74] */
            ii(0x19_73de, 3);  mov(dx, memw[ss, bp - 114]);            /* mov dx, [bp-0x72] */
            ii(0x19_73e1, 3);  add(memw[ss, bp - 64], ax);             /* add [bp-0x40], ax */
            ii(0x19_73e4, 3);  adc(memw[ss, bp - 62], dx);             /* adc [bp-0x3e], dx */
        l_0x19_73e7:
            ii(0x19_73e7, 2);  push(0);                                /* push 0x0 */
            ii(0x19_73e9, 1);  nop();                                  /* nop */
            ii(0x19_73ea, 1);  push(cs);                               /* push cs */
            ii(0x19_73eb, 3);  call(0x18_f850, -0x7b9e);               /* call 0xf850 */
            ii(0x19_73ee, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_73f1, 2);  push(1);                                /* push 0x1 */
            ii(0x19_73f3, 2);  push(0x24);                             /* push 0x24 */
            ii(0x19_73f5, 1);  nop();                                  /* nop */
            ii(0x19_73f6, 1);  push(cs);                               /* push cs */
            ii(0x19_73f7, 3);  call(0x19_606f, -0x138b);               /* call 0x606f */
            ii(0x19_73fa, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_73fd, 3);  jmp(0x19_7817, 0x417); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_7400, 3);  Недостижимый код.
        l_0x19_7403:
            ii(0x19_7403, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_7406, 1);  push(ss);                               /* push ss */
            ii(0x19_7407, 1);  push(ax);                               /* push ax */
            ii(0x19_7408, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_740b, 3);  call(0x19_61c1, -0x124d);               /* call 0x61c1 */
            ii(0x19_740e, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7411, 3);  jmp(0x19_73e7, -0x2d); goto l_0x19_73e7;/* jmp 0x73e7 */
        //  ii(0x19_7414, 3);  Недостижимый код.
        l_0x19_7417:
            ii(0x19_7417, 1);  nop();                                  /* nop */
            ii(0x19_7418, 1);  push(cs);                               /* push cs */
            ii(0x19_7419, 3);  call(0x19_5ec8, -0x1554);               /* call 0x5ec8 */
            ii(0x19_741c, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_741f, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_7422, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_7425, 3);  jmp(0x19_633b, -0x10ed); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_7428:
            ii(0x19_7428, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_742b, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_742e, 3);  and(ax, memw[ss, bp - 60]);             /* and ax, [bp-0x3c] */
            ii(0x19_7431, 3);  and(dx, memw[ss, bp - 58]);             /* and dx, [bp-0x3a] */
            ii(0x19_7434, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_7436, 2);  if(jz(0x19_743b, 3)) goto l_0x19_743b;  /* jz 0x743b */
            ii(0x19_7438, 3);  jmp(0x19_744e, 0x13); goto l_0x19_744e; /* jmp 0x744e */
        l_0x19_743b:
            ii(0x19_743b, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_743e, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_7441, 3);  and(ax, memw[ss, bp - 80]);             /* and ax, [bp-0x50] */
            ii(0x19_7444, 3);  and(dx, memw[ss, bp - 78]);             /* and dx, [bp-0x4e] */
            ii(0x19_7447, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_7449, 2);  if(jnz(0x19_744e, 3)) goto l_0x19_744e; /* jnz 0x744e */
            ii(0x19_744b, 3);  jmp(0x19_751b, 0xcd); goto l_0x19_751b; /* jmp 0x751b */
        l_0x19_744e:
            ii(0x19_744e, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_7451, 4);  mov(memw[ss, bp - 214], ax);            /* mov [bp-0xd6], ax */
            ii(0x19_7455, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_7458, 4);  mov(memw[ss, bp - 200], ax);            /* mov [bp-0xc8], ax */
            ii(0x19_745c, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_745f, 3);  mov(dx, memw[ss, bp - 58]);             /* mov dx, [bp-0x3a] */
            ii(0x19_7462, 4);  mov(memw[ss, bp - 196], ax);            /* mov [bp-0xc4], ax */
            ii(0x19_7466, 4);  mov(memw[ss, bp - 194], dx);            /* mov [bp-0xc2], dx */
            ii(0x19_746a, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_746d, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_7470, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_7474, 4);  mov(memw[ss, bp - 132], dx);            /* mov [bp-0x84], dx */
            ii(0x19_7478, 3);  push(memw[ss, bp - 58]);                /* push word [bp-0x3a] */
            ii(0x19_747b, 3);  push(memw[ss, bp - 60]);                /* push word [bp-0x3c] */
            ii(0x19_747e, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_7481, 1);  nop();                                  /* nop */
            ii(0x19_7482, 1);  push(cs);                               /* push cs */
            ii(0x19_7483, 3);  call(0x19_789c, 0x416);                 /* call 0x789c */
            ii(0x19_7486, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7489, 4);  mov(memw[ss, bp - 226], ax);            /* mov [bp-0xe2], ax */
            ii(0x19_748d, 3);  push(memw[ss, bp - 78]);                /* push word [bp-0x4e] */
            ii(0x19_7490, 3);  push(memw[ss, bp - 80]);                /* push word [bp-0x50] */
            ii(0x19_7493, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_7496, 1);  nop();                                  /* nop */
            ii(0x19_7497, 1);  push(cs);                               /* push cs */
            ii(0x19_7498, 3);  call(0x19_789c, 0x401);                 /* call 0x789c */
            ii(0x19_749b, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_749e, 4);  mov(memw[ss, bp - 218], ax);            /* mov [bp-0xda], ax */
            ii(0x19_74a2, 4);  mov(ax, memw[ss, bp - 226]);            /* mov ax, [bp-0xe2] */
            ii(0x19_74a6, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_74a9, 4);  mov(ax, memw[ss, bp - 218]);            /* mov ax, [bp-0xda] */
            ii(0x19_74ad, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_74b0, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_74b2, 3);  mov(memw[ss, bp - 58], ax);             /* mov [bp-0x3a], ax */
            ii(0x19_74b5, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_74b8, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_74ba, 3);  mov(memw[ss, bp - 78], ax);             /* mov [bp-0x4e], ax */
            ii(0x19_74bd, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_74c0, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_74c3, 1);  push(ss);                               /* push ss */
            ii(0x19_74c4, 1);  push(ax);                               /* push ax */
            ii(0x19_74c5, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_74c8, 3);  call(0x19_61c1, -0x130a);               /* call 0x61c1 */
            ii(0x19_74cb, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_74ce, 5);  sub(memw[ds, 0x1274], 2);               /* sub word [0x1274], 0x2 */
            ii(0x19_74d3, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_74d6, 4);  cmp(memw[ss, bp - 226], ax);            /* cmp [bp-0xe2], ax */
            ii(0x19_74da, 2);  if(jz(0x19_74df, 3)) goto l_0x19_74df;  /* jz 0x74df */
            ii(0x19_74dc, 3);  jmp(0x19_74f4, 0x15); goto l_0x19_74f4; /* jmp 0x74f4 */
        l_0x19_74df:
            ii(0x19_74df, 4);  mov(ax, memw[ss, bp - 214]);            /* mov ax, [bp-0xd6] */
            ii(0x19_74e3, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_74e6, 4);  mov(ax, memw[ss, bp - 196]);            /* mov ax, [bp-0xc4] */
            ii(0x19_74ea, 4);  mov(dx, memw[ss, bp - 194]);            /* mov dx, [bp-0xc2] */
            ii(0x19_74ee, 3);  add(memw[ss, bp - 60], ax);             /* add [bp-0x3c], ax */
            ii(0x19_74f1, 3);  adc(memw[ss, bp - 58], dx);             /* adc [bp-0x3a], dx */
        l_0x19_74f4:
            ii(0x19_74f4, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_74f7, 4);  cmp(memw[ss, bp - 218], ax);            /* cmp [bp-0xda], ax */
            ii(0x19_74fb, 2);  if(jz(0x19_7500, 3)) goto l_0x19_7500;  /* jz 0x7500 */
            ii(0x19_74fd, 3);  jmp(0x19_7515, 0x15); goto l_0x19_7515; /* jmp 0x7515 */
        l_0x19_7500:
            ii(0x19_7500, 4);  mov(ax, memw[ss, bp - 200]);            /* mov ax, [bp-0xc8] */
            ii(0x19_7504, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_7507, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_750b, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_750f, 3);  add(memw[ss, bp - 80], ax);             /* add [bp-0x50], ax */
            ii(0x19_7512, 3);  adc(memw[ss, bp - 78], dx);             /* adc [bp-0x4e], dx */
        l_0x19_7515:
            ii(0x19_7515, 3);  jmp(0x19_7817, 0x2ff); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_7518, 3);  Недостижимый код.
        l_0x19_751b:
            ii(0x19_751b, 3);  jmp(0x19_633b, -0x11e3); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_751e:
            ii(0x19_751e, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_7521, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_7524, 3);  and(ax, memw[ss, bp - 76]);             /* and ax, [bp-0x4c] */
            ii(0x19_7527, 3);  and(dx, memw[ss, bp - 74]);             /* and dx, [bp-0x4a] */
            ii(0x19_752a, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_752c, 2);  if(jnz(0x19_7531, 3)) goto l_0x19_7531; /* jnz 0x7531 */
            ii(0x19_752e, 3);  jmp(0x19_75a7, 0x76); goto l_0x19_75a7; /* jmp 0x75a7 */
        l_0x19_7531:
            ii(0x19_7531, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_7534, 4);  mov(memw[ss, bp - 226], ax);            /* mov [bp-0xe2], ax */
            ii(0x19_7538, 3);  mov(ax, memw[ss, bp - 76]);             /* mov ax, [bp-0x4c] */
            ii(0x19_753b, 3);  mov(dx, memw[ss, bp - 74]);             /* mov dx, [bp-0x4a] */
            ii(0x19_753e, 4);  mov(memw[ss, bp - 218], ax);            /* mov [bp-0xda], ax */
            ii(0x19_7542, 4);  mov(memw[ss, bp - 216], dx);            /* mov [bp-0xd8], dx */
            ii(0x19_7546, 3);  push(memw[ss, bp - 74]);                /* push word [bp-0x4a] */
            ii(0x19_7549, 3);  push(memw[ss, bp - 76]);                /* push word [bp-0x4c] */
            ii(0x19_754c, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_754f, 1);  nop();                                  /* nop */
            ii(0x19_7550, 1);  push(cs);                               /* push cs */
            ii(0x19_7551, 3);  call(0x19_789c, 0x348);                 /* call 0x789c */
            ii(0x19_7554, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7557, 4);  mov(memw[ss, bp - 214], ax);            /* mov [bp-0xd6], ax */
            ii(0x19_755b, 4);  mov(ax, memw[ss, bp - 214]);            /* mov ax, [bp-0xd6] */
            ii(0x19_755f, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_7562, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_7564, 3);  mov(memw[ss, bp - 74], ax);             /* mov [bp-0x4a], ax */
            ii(0x19_7567, 3);  mov(memw[ss, bp - 76], ax);             /* mov [bp-0x4c], ax */
            ii(0x19_756a, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_756d, 1);  push(ss);                               /* push ss */
            ii(0x19_756e, 1);  push(ax);                               /* push ax */
            ii(0x19_756f, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_7572, 3);  call(0x19_61c1, -0x13b4);               /* call 0x61c1 */
            ii(0x19_7575, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_7578, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_757c, 4);  mov(ax, memw[ss, bp - 214]);            /* mov ax, [bp-0xd6] */
            ii(0x19_7580, 3);  cmp(memw[ss, bp - 88], ax);             /* cmp [bp-0x58], ax */
            ii(0x19_7583, 2);  if(jz(0x19_7588, 3)) goto l_0x19_7588;  /* jz 0x7588 */
            ii(0x19_7585, 3);  jmp(0x19_758f, 7); goto l_0x19_758f;    /* jmp 0x758f */
        l_0x19_7588:
            ii(0x19_7588, 4);  mov(ax, memw[ss, bp - 226]);            /* mov ax, [bp-0xe2] */
            ii(0x19_758c, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
        l_0x19_758f:
            ii(0x19_758f, 3);  mov(ax, memw[ss, bp - 76]);             /* mov ax, [bp-0x4c] */
            ii(0x19_7592, 1);  cwd();                                  /* cwd */
            ii(0x19_7593, 4);  add(ax, memw[ss, bp - 218]);            /* add ax, [bp-0xda] */
            ii(0x19_7597, 4);  adc(dx, memw[ss, bp - 216]);            /* adc dx, [bp-0xd8] */
            ii(0x19_759b, 3);  mov(memw[ss, bp - 76], ax);             /* mov [bp-0x4c], ax */
            ii(0x19_759e, 3);  mov(memw[ss, bp - 74], dx);             /* mov [bp-0x4a], dx */
            ii(0x19_75a1, 3);  jmp(0x19_7817, 0x273); goto l_0x19_7817;/* jmp 0x7817 */
        //  ii(0x19_75a4, 3);  Недостижимый код.
        l_0x19_75a7:
            ii(0x19_75a7, 3);  jmp(0x19_633b, -0x126f); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_75aa:
            ii(0x19_75aa, 4);  cmp(memb[ss, bp - 52], 6);              /* cmp byte [bp-0x34], 0x6 */
            ii(0x19_75ae, 2);  if(jz(0x19_75b3, 3)) goto l_0x19_75b3;  /* jz 0x75b3 */
            ii(0x19_75b0, 3);  jmp(0x19_75bb, 8); goto l_0x19_75bb;    /* jmp 0x75bb */
        l_0x19_75b3:
            ii(0x19_75b3, 5);  mov(memw[ss, bp - 2], 0x40);            /* mov word [bp-0x2], 0x40 */
            ii(0x19_75b8, 3);  jmp(0x19_633b, -0x1280); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_75bb:
            ii(0x19_75bb, 4);  cmp(memb[ss, bp - 52], 0xa);            /* cmp byte [bp-0x34], 0xa */
            ii(0x19_75bf, 2);  if(jz(0x19_75c4, 3)) goto l_0x19_75c4;  /* jz 0x75c4 */
            ii(0x19_75c1, 3);  jmp(0x19_75c7, 3); goto l_0x19_75c7;    /* jmp 0x75c7 */
        l_0x19_75c4:
            ii(0x19_75c4, 3);  jmp(0x19_751e, -0xa9); goto l_0x19_751e;/* jmp 0x751e */
        l_0x19_75c7:
            ii(0x19_75c7, 3);  jmp(0x19_633b, -0x128f); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_75ca:
            ii(0x19_75ca, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_75cd, 2);  sub(ah, ah);                            /* sub ah, ah */
            ii(0x19_75cf, 3);  jmp(0x19_75e3, 0x11); goto l_0x19_75e3; /* jmp 0x75e3 */
        l_0x19_75d2:
            ii(0x19_75d2, 3);  jmp(0x19_6442, -0x1193); goto l_0x19_6442;/* jmp 0x6442 */
        l_0x19_75d5:
            ii(0x19_75d5, 3);  jmp(0x19_751e, -0xba); goto l_0x19_751e;/* jmp 0x751e */
        l_0x19_75d8:
            ii(0x19_75d8, 5);  mov(memw[ss, bp - 2], 2);               /* mov word [bp-0x2], 0x2 */
            ii(0x19_75dd, 3);  jmp(0x19_7746, 0x166); goto l_0x19_7746;/* jmp 0x7746 */
        //  ii(0x19_75e0, 3);  Недостижимый код.
        l_0x19_75e3:
            ii(0x19_75e3, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_75e5, 2);  if(jge(0x19_75ea, 3)) goto l_0x19_75ea; /* jge 0x75ea */
            ii(0x19_75e7, 3);  jmp(0x19_75ff, 0x15); goto l_0x19_75ff; /* jmp 0x75ff */
        l_0x19_75ea:
            ii(0x19_75ea, 1);  dec(ax);                                /* dec ax */
            ii(0x19_75eb, 2);  if(jg(0x19_75f0, 3)) goto l_0x19_75f0;  /* jg 0x75f0 */
            ii(0x19_75ed, 3);  jmp(0x19_75d2, -0x1e); goto l_0x19_75d2;/* jmp 0x75d2 */
        l_0x19_75f0:
            ii(0x19_75f0, 1);  dec(ax);                                /* dec ax */
            ii(0x19_75f1, 2);  if(jnz(0x19_75f6, 3)) goto l_0x19_75f6; /* jnz 0x75f6 */
            ii(0x19_75f3, 3);  jmp(0x19_75d5, -0x21); goto l_0x19_75d5;/* jmp 0x75d5 */
        l_0x19_75f6:
            ii(0x19_75f6, 1);  dec(ax);                                /* dec ax */
            ii(0x19_75f7, 2);  if(jnz(0x19_75fc, 3)) goto l_0x19_75fc; /* jnz 0x75fc */
            ii(0x19_75f9, 3);  jmp(0x19_75d8, -0x24); goto l_0x19_75d8;/* jmp 0x75d8 */
        l_0x19_75fc:
            ii(0x19_75fc, 3);  jmp(0x19_75ff, 0); goto l_0x19_75ff;    /* jmp 0x75ff */
        l_0x19_75ff:
            ii(0x19_75ff, 3);  jmp(0x19_633b, -0x12c7); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_7602:
            ii(0x19_7602, 3);  mov(al, memb[ss, bp - 52]);             /* mov al, [bp-0x34] */
            ii(0x19_7605, 4);  mov(memb[ss, bp - 226], al);            /* mov [bp-0xe2], al */
            ii(0x19_7609, 4);  cmp(memb[ss, bp - 51], 0x60);           /* cmp byte [bp-0x33], 0x60 */
            ii(0x19_760d, 2);  if(jz(0x19_7612, 3)) goto l_0x19_7612;  /* jz 0x7612 */
            ii(0x19_760f, 3);  jmp(0x19_761a, 8); goto l_0x19_761a;    /* jmp 0x761a */
        l_0x19_7612:
            ii(0x19_7612, 5);  mov(memb[ss, bp - 226], 2);             /* mov byte [bp-0xe2], 0x2 */
            ii(0x19_7617, 3);  jmp(0x19_7636, 0x1c); goto l_0x19_7636; /* jmp 0x7636 */
        l_0x19_761a:
            ii(0x19_761a, 5);  cmp(memb[ss, bp - 226], 4);             /* cmp byte [bp-0xe2], 0x4 */
            ii(0x19_761f, 2);  if(jz(0x19_7624, 3)) goto l_0x19_7624;  /* jz 0x7624 */
            ii(0x19_7621, 3);  jmp(0x19_7627, 3); goto l_0x19_7627;    /* jmp 0x7627 */
        l_0x19_7624:
            ii(0x19_7624, 3);  jmp(0x19_751e, -0x109); goto l_0x19_751e;/* jmp 0x751e */
        l_0x19_7627:
            ii(0x19_7627, 5);  cmp(memb[ss, bp - 226], 2);             /* cmp byte [bp-0xe2], 0x2 */
            ii(0x19_762c, 2);  if(jz(0x19_7631, 3)) goto l_0x19_7631;  /* jz 0x7631 */
            ii(0x19_762e, 3);  jmp(0x19_7636, 5); goto l_0x19_7636;    /* jmp 0x7636 */
        l_0x19_7631:
            ii(0x19_7631, 5);  mov(memw[ss, bp - 2], 2);               /* mov word [bp-0x2], 0x2 */
        l_0x19_7636:
            ii(0x19_7636, 5);  cmp(memb[ss, bp - 226], 2);             /* cmp byte [bp-0xe2], 0x2 */
            ii(0x19_763b, 2);  if(jnz(0x19_7640, 3)) goto l_0x19_7640; /* jnz 0x7640 */
            ii(0x19_763d, 3);  jmp(0x19_764a, 0xa); goto l_0x19_764a;  /* jmp 0x764a */
        l_0x19_7640:
            ii(0x19_7640, 5);  cmp(memb[ss, bp - 226], 3);             /* cmp byte [bp-0xe2], 0x3 */
            ii(0x19_7645, 2);  if(jz(0x19_764a, 3)) goto l_0x19_764a;  /* jz 0x764a */
            ii(0x19_7647, 3);  jmp(0x19_7738, 0xee); goto l_0x19_7738; /* jmp 0x7738 */
        l_0x19_764a:
            ii(0x19_764a, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_764d, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_7650, 3);  and(ax, memw[ss, bp - 76]);             /* and ax, [bp-0x4c] */
            ii(0x19_7653, 3);  and(dx, memw[ss, bp - 74]);             /* and dx, [bp-0x4a] */
            ii(0x19_7656, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_7658, 2);  if(jz(0x19_765d, 3)) goto l_0x19_765d;  /* jz 0x765d */
            ii(0x19_765a, 3);  jmp(0x19_7670, 0x13); goto l_0x19_7670; /* jmp 0x7670 */
        l_0x19_765d:
            ii(0x19_765d, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_7660, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_7663, 3);  and(ax, memw[ss, bp - 80]);             /* and ax, [bp-0x50] */
            ii(0x19_7666, 3);  and(dx, memw[ss, bp - 78]);             /* and dx, [bp-0x4e] */
            ii(0x19_7669, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_766b, 2);  if(jnz(0x19_7670, 3)) goto l_0x19_7670; /* jnz 0x7670 */
            ii(0x19_766d, 3);  jmp(0x19_7738, 0xc8); goto l_0x19_7738; /* jmp 0x7738 */
        l_0x19_7670:
            ii(0x19_7670, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_7673, 4);  mov(memw[ss, bp - 200], ax);            /* mov [bp-0xc8], ax */
            ii(0x19_7677, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_767a, 4);  mov(memw[ss, bp - 196], ax);            /* mov [bp-0xc4], ax */
            ii(0x19_767e, 3);  mov(ax, memw[ss, bp - 76]);             /* mov ax, [bp-0x4c] */
            ii(0x19_7681, 3);  mov(dx, memw[ss, bp - 74]);             /* mov dx, [bp-0x4a] */
            ii(0x19_7684, 4);  mov(memw[ss, bp - 134], ax);            /* mov [bp-0x86], ax */
            ii(0x19_7688, 4);  mov(memw[ss, bp - 132], dx);            /* mov [bp-0x84], dx */
            ii(0x19_768c, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_768f, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_7692, 4);  mov(memw[ss, bp - 130], ax);            /* mov [bp-0x82], ax */
            ii(0x19_7696, 3);  mov(memw[ss, bp - 128], dx);            /* mov [bp-0x80], dx */
            ii(0x19_7699, 3);  push(memw[ss, bp - 74]);                /* push word [bp-0x4a] */
            ii(0x19_769c, 3);  push(memw[ss, bp - 76]);                /* push word [bp-0x4c] */
            ii(0x19_769f, 3);  push(memw[ss, bp - 88]);                /* push word [bp-0x58] */
            ii(0x19_76a2, 1);  nop();                                  /* nop */
            ii(0x19_76a3, 1);  push(cs);                               /* push cs */
            ii(0x19_76a4, 3);  call(0x19_789c, 0x1f5);                 /* call 0x789c */
            ii(0x19_76a7, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_76aa, 4);  mov(memw[ss, bp - 218], ax);            /* mov [bp-0xda], ax */
            ii(0x19_76ae, 3);  push(memw[ss, bp - 78]);                /* push word [bp-0x4e] */
            ii(0x19_76b1, 3);  push(memw[ss, bp - 80]);                /* push word [bp-0x50] */
            ii(0x19_76b4, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_76b7, 1);  nop();                                  /* nop */
            ii(0x19_76b8, 1);  push(cs);                               /* push cs */
            ii(0x19_76b9, 3);  call(0x19_789c, 0x1e0);                 /* call 0x789c */
            ii(0x19_76bc, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_76bf, 4);  mov(memw[ss, bp - 214], ax);            /* mov [bp-0xd6], ax */
            ii(0x19_76c3, 4);  mov(ax, memw[ss, bp - 218]);            /* mov ax, [bp-0xda] */
            ii(0x19_76c7, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_76ca, 4);  mov(ax, memw[ss, bp - 214]);            /* mov ax, [bp-0xd6] */
            ii(0x19_76ce, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_76d1, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_76d3, 3);  mov(memw[ss, bp - 74], ax);             /* mov [bp-0x4a], ax */
            ii(0x19_76d6, 3);  mov(memw[ss, bp - 76], ax);             /* mov [bp-0x4c], ax */
            ii(0x19_76d9, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_76db, 3);  mov(memw[ss, bp - 78], ax);             /* mov [bp-0x4e], ax */
            ii(0x19_76de, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_76e1, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_76e4, 1);  push(ss);                               /* push ss */
            ii(0x19_76e5, 1);  push(ax);                               /* push ax */
            ii(0x19_76e6, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_76e9, 3);  call(0x19_61c1, -0x152b);               /* call 0x61c1 */
            ii(0x19_76ec, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_76ef, 5);  sub(memw[ds, 0x1274], 2);               /* sub word [0x1274], 0x2 */
            ii(0x19_76f4, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_76f7, 4);  cmp(memw[ss, bp - 218], ax);            /* cmp [bp-0xda], ax */
            ii(0x19_76fb, 2);  if(jz(0x19_7700, 3)) goto l_0x19_7700;  /* jz 0x7700 */
            ii(0x19_76fd, 3);  jmp(0x19_7715, 0x15); goto l_0x19_7715; /* jmp 0x7715 */
        l_0x19_7700:
            ii(0x19_7700, 4);  mov(ax, memw[ss, bp - 200]);            /* mov ax, [bp-0xc8] */
            ii(0x19_7704, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
            ii(0x19_7707, 4);  mov(ax, memw[ss, bp - 134]);            /* mov ax, [bp-0x86] */
            ii(0x19_770b, 4);  mov(dx, memw[ss, bp - 132]);            /* mov dx, [bp-0x84] */
            ii(0x19_770f, 3);  add(memw[ss, bp - 76], ax);             /* add [bp-0x4c], ax */
            ii(0x19_7712, 3);  adc(memw[ss, bp - 74], dx);             /* adc [bp-0x4a], dx */
        l_0x19_7715:
            ii(0x19_7715, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_7718, 4);  cmp(memw[ss, bp - 214], ax);            /* cmp [bp-0xd6], ax */
            ii(0x19_771c, 2);  if(jz(0x19_7721, 3)) goto l_0x19_7721;  /* jz 0x7721 */
            ii(0x19_771e, 3);  jmp(0x19_7735, 0x14); goto l_0x19_7735; /* jmp 0x7735 */
        l_0x19_7721:
            ii(0x19_7721, 4);  mov(ax, memw[ss, bp - 196]);            /* mov ax, [bp-0xc4] */
            ii(0x19_7725, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_7728, 4);  mov(ax, memw[ss, bp - 130]);            /* mov ax, [bp-0x82] */
            ii(0x19_772c, 3);  mov(dx, memw[ss, bp - 128]);            /* mov dx, [bp-0x80] */
            ii(0x19_772f, 3);  add(memw[ss, bp - 80], ax);             /* add [bp-0x50], ax */
            ii(0x19_7732, 3);  adc(memw[ss, bp - 78], dx);             /* adc [bp-0x4e], dx */
        l_0x19_7735:
            ii(0x19_7735, 3);  jmp(0x19_7817, 0xdf); goto l_0x19_7817; /* jmp 0x7817 */
        l_0x19_7738:
            ii(0x19_7738, 3);  jmp(0x19_633b, -0x1400); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_773b:
            ii(0x19_773b, 3);  jmp(0x19_7743, 5); goto l_0x19_7743;    /* jmp 0x7743 */
        //  ii(0x19_773e, 5);  Недостижимый код.
        l_0x19_7743:
            ii(0x19_7743, 3);  jmp(0x19_633b, -0x140b); goto l_0x19_633b;/* jmp 0x633b */
        l_0x19_7746:
            ii(0x19_7746, 3);  mov(ax, memw[ss, bp - 22]);             /* mov ax, [bp-0x16] */
            ii(0x19_7749, 3);  mov(dx, memw[ss, bp - 20]);             /* mov dx, [bp-0x14] */
            ii(0x19_774c, 3);  and(ax, memw[ss, bp - 80]);             /* and ax, [bp-0x50] */
            ii(0x19_774f, 3);  and(dx, memw[ss, bp - 78]);             /* and dx, [bp-0x4e] */
            ii(0x19_7752, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_7754, 2);  if(jnz(0x19_7759, 3)) goto l_0x19_7759; /* jnz 0x7759 */
            ii(0x19_7756, 3);  jmp(0x19_77cf, 0x76); goto l_0x19_77cf; /* jmp 0x77cf */
        l_0x19_7759:
            ii(0x19_7759, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_775c, 4);  mov(memw[ss, bp - 218], ax);            /* mov [bp-0xda], ax */
            ii(0x19_7760, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_7763, 3);  mov(dx, memw[ss, bp - 78]);             /* mov dx, [bp-0x4e] */
            ii(0x19_7766, 4);  mov(memw[ss, bp - 214], ax);            /* mov [bp-0xd6], ax */
            ii(0x19_776a, 4);  mov(memw[ss, bp - 212], dx);            /* mov [bp-0xd4], dx */
            ii(0x19_776e, 3);  push(memw[ss, bp - 78]);                /* push word [bp-0x4e] */
            ii(0x19_7771, 3);  push(memw[ss, bp - 80]);                /* push word [bp-0x50] */
            ii(0x19_7774, 3);  push(memw[ss, bp - 86]);                /* push word [bp-0x56] */
            ii(0x19_7777, 1);  nop();                                  /* nop */
            ii(0x19_7778, 1);  push(cs);                               /* push cs */
            ii(0x19_7779, 3);  call(0x19_789c, 0x120);                 /* call 0x789c */
            ii(0x19_777c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_777f, 4);  mov(memw[ss, bp - 226], ax);            /* mov [bp-0xe2], ax */
            ii(0x19_7783, 4);  mov(ax, memw[ss, bp - 226]);            /* mov ax, [bp-0xe2] */
            ii(0x19_7787, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
            ii(0x19_778a, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_778c, 3);  mov(memw[ss, bp - 78], ax);             /* mov [bp-0x4e], ax */
            ii(0x19_778f, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_7792, 3);  lea(ax, memw[ss, bp - 92]);             /* lea ax, [bp-0x5c] */
            ii(0x19_7795, 1);  push(ss);                               /* push ss */
            ii(0x19_7796, 1);  push(ax);                               /* push ax */
            ii(0x19_7797, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_779a, 3);  call(0x19_61c1, -0x15dc);               /* call 0x61c1 */
            ii(0x19_779d, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_77a0, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_77a4, 3);  mov(ax, memw[ss, bp - 86]);             /* mov ax, [bp-0x56] */
            ii(0x19_77a7, 4);  cmp(memw[ss, bp - 226], ax);            /* cmp [bp-0xe2], ax */
            ii(0x19_77ab, 2);  if(jz(0x19_77b0, 3)) goto l_0x19_77b0;  /* jz 0x77b0 */
            ii(0x19_77ad, 3);  jmp(0x19_77b7, 7); goto l_0x19_77b7;    /* jmp 0x77b7 */
        l_0x19_77b0:
            ii(0x19_77b0, 4);  mov(ax, memw[ss, bp - 218]);            /* mov ax, [bp-0xda] */
            ii(0x19_77b4, 3);  mov(memw[ss, bp - 86], ax);             /* mov [bp-0x56], ax */
        l_0x19_77b7:
            ii(0x19_77b7, 3);  mov(ax, memw[ss, bp - 80]);             /* mov ax, [bp-0x50] */
            ii(0x19_77ba, 1);  cwd();                                  /* cwd */
            ii(0x19_77bb, 4);  add(ax, memw[ss, bp - 214]);            /* add ax, [bp-0xd6] */
            ii(0x19_77bf, 4);  adc(dx, memw[ss, bp - 212]);            /* adc dx, [bp-0xd4] */
            ii(0x19_77c3, 3);  mov(memw[ss, bp - 80], ax);             /* mov [bp-0x50], ax */
            ii(0x19_77c6, 3);  mov(memw[ss, bp - 78], dx);             /* mov [bp-0x4e], dx */
            ii(0x19_77c9, 3);  jmp(0x19_7817, 0x4b); goto l_0x19_7817; /* jmp 0x7817 */
        //  ii(0x19_77cc, 3);  Недостижимый код.
        l_0x19_77cf:
            ii(0x19_77cf, 3);  jmp(0x19_633b, -0x1497); goto l_0x19_633b;/* jmp 0x633b */
        //  ii(0x19_77d2, 3);  Недостижимый код.
        l_0x19_77d5:
            ii(0x19_77d5, 3);  cmp(ax, 0x18);                          /* cmp ax, 0x18 */
            ii(0x19_77d8, 2);  if(jbe(0x19_77dd, 3)) goto l_0x19_77dd; /* jbe 0x77dd */
            ii(0x19_77da, 3);  jmp(0x19_7817, 0x3a); goto l_0x19_7817; /* jmp 0x7817 */
        l_0x19_77dd:
            ii(0x19_77dd, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_77df, 1);  xchg(bx, ax);                           /* xchg bx, ax */
            ii(0x19_77e0, 5);  /* jmp word [cs:bx+0x23c5] */
            switch (jmp_abs_switch(memw[cs, bx + 0x23c5]))
            {
                case 0x19_633b:
                    goto l_0x19_633b;
                case 0x19_634c:
                    goto l_0x19_634c;
                case 0x19_6430:
                    goto l_0x19_6430;
                case 0x19_6442:
                    goto l_0x19_6442;
                case 0x19_64c5:
                    goto l_0x19_64c5;
                case 0x19_655f:
                    goto l_0x19_655f;
                case 0x19_6923:
                    goto l_0x19_6923;
                case 0x19_6969:
                    goto l_0x19_6969;
                case 0x19_6a4d:
                    goto l_0x19_6a4d;
                case 0x19_6a5a:
                    goto l_0x19_6a5a;
                case 0x19_6b6f:
                    goto l_0x19_6b6f;
                case 0x19_6b8f:
                    goto l_0x19_6b8f;
                case 0x19_6d0e:
                    goto l_0x19_6d0e;
                case 0x19_6d4f:
                    goto l_0x19_6d4f;
                case 0x19_6e21:
                    goto l_0x19_6e21;
                case 0x19_6f54:
                    goto l_0x19_6f54;
                case 0x19_7203:
                    goto l_0x19_7203;
                case 0x19_7417:
                    goto l_0x19_7417;
                case 0x19_7428:
                    goto l_0x19_7428;
                case 0x19_751e:
                    goto l_0x19_751e;
                case 0x19_75aa:
                    goto l_0x19_75aa;
                case 0x19_75ca:
                    goto l_0x19_75ca;
                case 0x19_7602:
                    goto l_0x19_7602;
                case 0x19_773b:
                    goto l_0x19_773b;
                case 0x19_7746:
                    goto l_0x19_7746;
                default:
                    throw new NotImplementedException();
            }
        //  ii(0x19_77e5, 50);  Недостижимый код.
        l_0x19_7817:
            ii(0x19_7817, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x19_781a, 3);  or(ax, memw[ss, bp - 22]);              /* or ax, [bp-0x16] */
            ii(0x19_781d, 2);  if(jnz(0x19_7822, 3)) goto l_0x19_7822; /* jnz 0x7822 */
            ii(0x19_781f, 3);  jmp(0x19_7839, 0x17); goto l_0x19_7839; /* jmp 0x7839 */
        l_0x19_7822:
            ii(0x19_7822, 4);  test(memb[ss, bp - 34], 1);             /* test byte [bp-0x22], 0x1 */
            ii(0x19_7826, 2);  if(jnz(0x19_782b, 3)) goto l_0x19_782b; /* jnz 0x782b */
            ii(0x19_7828, 3);  jmp(0x19_7839, 0xe); goto l_0x19_7839;  /* jmp 0x7839 */
        l_0x19_782b:
            ii(0x19_782b, 3);  mov(ax, memw[ss, bp - 52]);             /* mov ax, [bp-0x34] */
            ii(0x19_782e, 3);  mov(memw[ss, bp - 52], ax);             /* mov [bp-0x34], ax */
            ii(0x19_7831, 5);  mov(memw[ss, bp - 50], 0);              /* mov word [bp-0x32], 0x0 */
            ii(0x19_7836, 3);  jmp(0x19_7880, 0x47); goto l_0x19_7880; /* jmp 0x7880 */
        l_0x19_7839:
            ii(0x19_7839, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x19_783c, 3);  or(ax, memw[ss, bp - 22]);              /* or ax, [bp-0x16] */
            ii(0x19_783f, 2);  if(jnz(0x19_7844, 3)) goto l_0x19_7844; /* jnz 0x7844 */
            ii(0x19_7841, 3);  jmp(0x19_7880, 0x3c); goto l_0x19_7880; /* jmp 0x7880 */
        l_0x19_7844:
            ii(0x19_7844, 3);  lea(ax, memw[ss, bp - 52]);             /* lea ax, [bp-0x34] */
            ii(0x19_7847, 4);  mov(memw[ss, bp - 226], ax);            /* mov [bp-0xe2], ax */
            ii(0x19_784b, 4);  mov(memw[ss, bp - 224], ss);            /* mov [bp-0xe0], ss */
        l_0x19_784f:
            ii(0x19_784f, 4);  cmp(memw[ss, bp - 2], 0);               /* cmp word [bp-0x2], 0x0 */
            ii(0x19_7853, 2);  if(jnz(0x19_7858, 3)) goto l_0x19_7858; /* jnz 0x7858 */
            ii(0x19_7855, 3);  jmp(0x19_7880, 0x28); goto l_0x19_7880; /* jmp 0x7880 */
        l_0x19_7858:
            ii(0x19_7858, 4);  test(memb[ss, bp - 2], 1);              /* test byte [bp-0x2], 0x1 */
            ii(0x19_785c, 2);  if(jnz(0x19_7861, 3)) goto l_0x19_7861; /* jnz 0x7861 */
            ii(0x19_785e, 3);  jmp(0x19_7875, 0x14); goto l_0x19_7875; /* jmp 0x7875 */
        l_0x19_7861:
            ii(0x19_7861, 4);  les(bx, memw[ss, bp - 226]);            /* les bx, [bp-0xe2] */
            ii(0x19_7865, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_7868, 4);  les(bx, memw[ss, bp - 226]);            /* les bx, [bp-0xe2] */
            ii(0x19_786c, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_786f, 6);  mov(memw[es, bx + 2], 0);               /* mov word [es:bx+0x2], 0x0 */
        l_0x19_7875:
            ii(0x19_7875, 5);  sub(memw[ss, bp - 226], 4);             /* sub word [bp-0xe2], 0x4 */
            ii(0x19_787a, 3);  shr(memw[ss, bp - 2], 1);               /* shr word [bp-0x2], 1 */
            ii(0x19_787d, 3);  jmp(0x19_784f, -0x31); goto l_0x19_784f;/* jmp 0x784f */
        l_0x19_7880:
            ii(0x19_7880, 1);  push(ds);                               /* push ds */
            ii(0x19_7881, 3);  lea(si, memw[ss, bp - 92]);             /* lea si, [bp-0x5c] */
            ii(0x19_7884, 2);  mov(ax, ss);                            /* mov ax, ss */
            ii(0x19_7886, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_7888, 3);  les(di, memw[ss, bp + 8]);              /* les di, [bp+0x8] */
            ii(0x19_788b, 3);  mov(cx, 0x1f);                          /* mov cx, 0x1f */
            ii(0x19_788e, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x19_7890, 1);  pop(ds);                                /* pop ds */
            ii(0x19_7891, 3);  mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x19_7894, 3);  jmp(0x19_7897, 0); goto l_0x19_7897;    /* jmp 0x7897 */
        l_0x19_7897:
            ii(0x19_7897, 1);  pop(ds);                                /* pop ds */
            ii(0x19_7898, 1);  pop(si);                                /* pop si */
            ii(0x19_7899, 1);  pop(di);                                /* pop di */
            ii(0x19_789a, 1);  leave();                                /* leave */
            ii(0x19_789b, 1);  retf();                                 /* retf */
        }
    }
}
