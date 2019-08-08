using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3c25e388-5703-4e15-94ad-e4928e9e8b92")]
        public void Method_0015_6274()
        {
            ii(0x15_6274, 4); enterw(0xe2, 0);                          /* enter 0xe2, 0x0 */
            ii(0x15_6278, 1); pushw(di);                                /* push di */
            ii(0x15_6279, 1); pushw(si);                                /* push si */
            ii(0x15_627a, 1); pushw(ds);                                /* push ds */
            ii(0x15_627b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_627e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_6280, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_6283, 4); mov(ax, memw_a16[es, bx + 0x28]);         /* mov ax, [es:bx+0x28] */
            ii(0x15_6287, 4); mov(dx, memw_a16[es, bx + 0x2a]);         /* mov dx, [es:bx+0x2a] */
            ii(0x15_628b, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x15_628d, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x15_628f, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x15_6291, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x15_6293, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6295, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_6298, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_629b, 4); mov(al, memb_a16[ds, bx + 0x1456]);       /* mov al, [bx+0x1456] */
            ii(0x15_629f, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_62a1, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_62a4, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_62a7, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_62ab, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_62b0, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_62b3, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_62b6, 2); if(jnzw(0x15_62bb, 0x3)) goto l_0x15_62bb; /* jnz 0x62bb */
            ii(0x15_62b8, 3); jmpw(0x15_62c4, 0x9); goto l_0x15_62c4;   /* jmp 0x62c4 */
        l_0x15_62bb:
            ii(0x15_62bb, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_62be, 3); mov(dx, 0xffff);                          /* mov dx, 0xffff */
            ii(0x15_62c1, 3); jmpw(0x15_62ca, 0x6); goto l_0x15_62ca;   /* jmp 0x62ca */
        l_0x15_62c4:
            ii(0x15_62c4, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_62c7, 3); mov(dx, 0);                               /* mov dx, 0x0 */
        l_0x15_62ca:
            ii(0x15_62ca, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_62cd, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x15_62d0, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x15_62d3, 3); or(ax, memw_a16[ss, bp - 0x16]);          /* or ax, [bp-0x16] */
            ii(0x15_62d6, 2); if(jnzw(0x15_62db, 0x3)) goto l_0x15_62db; /* jnz 0x62db */
            ii(0x15_62d8, 3); jmpw(0x15_62e4, 0x9); goto l_0x15_62e4;   /* jmp 0x62e4 */
        l_0x15_62db:
            ii(0x15_62db, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x15_62de, 3); mov(dx, 0xffff);                          /* mov dx, 0xffff */
            ii(0x15_62e1, 3); jmpw(0x15_62ea, 0x6); goto l_0x15_62ea;   /* jmp 0x62ea */
        l_0x15_62e4:
            ii(0x15_62e4, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x15_62e7, 3); mov(dx, 0);                               /* mov dx, 0x0 */
        l_0x15_62ea:
            ii(0x15_62ea, 3); mov(memw_a16[ss, bp - 0x60], ax);         /* mov [bp-0x60], ax */
            ii(0x15_62ed, 3); mov(memw_a16[ss, bp - 0x5e], dx);         /* mov [bp-0x5e], dx */
            ii(0x15_62f0, 4); mov(es, memw_a16[ds, 0x3f96]);            /* mov es, [0x3f96] */
            ii(0x15_62f4, 6); cmp(memb_a16[es, 0x308a], 0);             /* cmp byte [es:0x308a], 0x0 */
            ii(0x15_62fa, 2); if(jnzw(0x15_62ff, 0x3)) goto l_0x15_62ff; /* jnz 0x62ff */
            ii(0x15_62fc, 3); jmpw(0x15_6319, 0x1a); goto l_0x15_6319;  /* jmp 0x6319 */
        l_0x15_62ff:
            ii(0x15_62ff, 6); mov(memb_a16[es, 0x308a], 0);             /* mov byte [es:0x308a], 0x0 */
            ii(0x15_6305, 5); mov(memw_a16[ss, bp - 0x4], 0x4c);        /* mov word [bp-0x4], 0x4c */
            ii(0x15_630a, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_630d, 6); mov(memw_a16[es, bx + 0x28], 0x4c01);     /* mov word [es:bx+0x28], 0x4c01 */
            ii(0x15_6313, 6); mov(memw_a16[es, bx + 0x2a], 0);          /* mov word [es:bx+0x2a], 0x0 */
        l_0x15_6319:
            ii(0x15_6319, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_631c, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x15_631f, 1); pushw(ds);                                /* push ds */
            ii(0x15_6320, 3); lea(di, bp - 0x5c);                       /* lea di, [bp-0x5c] */
            ii(0x15_6323, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_6325, 1); pushw(ss);                                /* push ss */
            ii(0x15_6326, 1); popw(es);                                 /* pop es */
            ii(0x15_6327, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x15_6329, 3); mov(cx, 0x1f);                            /* mov cx, 0x1f */
            ii(0x15_632c, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x15_632e, 1); popw(ds);                                 /* pop ds */
            ii(0x15_632f, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x15_6332, 4); mov(al, memb_a16[ds, bx + 0x1356]);       /* mov al, [bx+0x1356] */
            ii(0x15_6336, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6338, 3); jmpw(0x15_77d5, 0x149a); goto l_0x15_77d5; /* jmp 0x77d5 */
        l_0x15_633b:
            ii(0x15_633b, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_633e, 1); pushw(ss);                                /* push ss */
            ii(0x15_633f, 1); pushw(ax);                                /* push ax */
            ii(0x15_6340, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_6343, 3); callw(0x15_61c1, -0x185);                 /* call 0x61c1 */
            ii(0x15_6346, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6349, 3); jmpw(0x15_7817, 0x14cb); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_634c:
            ii(0x15_634c, 5); cmp(memw_a16[ss, bp - 0x34], 0xff00);     /* cmp word [bp-0x34], 0xff00 */
            ii(0x15_6351, 2); if(jzw(0x15_6356, 0x3)) goto l_0x15_6356; /* jz 0x6356 */
            ii(0x15_6353, 3); jmpw(0x15_6374, 0x1e); goto l_0x15_6374;  /* jmp 0x6374 */
        l_0x15_6356:
            ii(0x15_6356, 4); cmp(memw_a16[ss, bp - 0x3c], 0x78);       /* cmp word [bp-0x3c], 0x78 */
            ii(0x15_635a, 2); if(jzw(0x15_635f, 0x3)) goto l_0x15_635f; /* jz 0x635f */
            ii(0x15_635c, 3); jmpw(0x15_6374, 0x15); goto l_0x15_6374;  /* jmp 0x6374 */
        l_0x15_635f:
            ii(0x15_635f, 5); mov(memw_a16[ss, bp - 0x34], 0xffff);     /* mov word [bp-0x34], 0xffff */
            ii(0x15_6364, 5); mov(memw_a16[ss, bp - 0x32], 0x4734);     /* mov word [bp-0x32], 0x4734 */
            ii(0x15_6369, 4); and(memw_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and word [bp-0x22], 0xfffe */
            ii(0x15_636d, 4); and(memw_a16[ss, bp - 0x20], -0x1 /* 0xff */); /* and word [bp-0x20], 0xffff */
            ii(0x15_6371, 3); jmpw(0x15_7817, 0x14a3); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6374:
            ii(0x15_6374, 5); cmp(memb_a16[ds, 0xd8a], 0);              /* cmp byte [0xd8a], 0x0 */
            ii(0x15_6379, 2); if(jnzw(0x15_637e, 0x3)) goto l_0x15_637e; /* jnz 0x637e */
            ii(0x15_637b, 3); jmpw(0x15_642d, 0xaf); goto l_0x15_642d;  /* jmp 0x642d */
        l_0x15_637e:
            ii(0x15_637e, 4); cmp(memb_a16[ss, bp - 0x33], -0x1 /* 0xff */); /* cmp byte [bp-0x33], 0xff */
            ii(0x15_6382, 2); if(jzw(0x15_6387, 0x3)) goto l_0x15_6387; /* jz 0x6387 */
            ii(0x15_6384, 3); jmpw(0x15_642d, 0xa6); goto l_0x15_642d;  /* jmp 0x642d */
        l_0x15_6387:
            ii(0x15_6387, 4); cmp(memw_a16[ss, bp - 0x3c], 0x6);        /* cmp word [bp-0x3c], 0x6 */
            ii(0x15_638b, 2); if(jzw(0x15_6390, 0x3)) goto l_0x15_6390; /* jz 0x6390 */
            ii(0x15_638d, 3); jmpw(0x15_63bc, 0x2c); goto l_0x15_63bc;  /* jmp 0x63bc */
        l_0x15_6390:
            ii(0x15_6390, 3); mov(al, memb_a16[ss, bp - 0x3c]);         /* mov al, [bp-0x3c] */
            ii(0x15_6393, 3); mov(memb_a16[ds, 0x1271], al);            /* mov [0x1271], al */
            ii(0x15_6396, 4); and(memw_a16[ss, bp - 0x34], 0);          /* and word [bp-0x34], 0x0 */
            ii(0x15_639a, 4); and(memw_a16[ss, bp - 0x32], -0x1 /* 0xff */); /* and word [bp-0x32], 0xffff */
            ii(0x15_639e, 3); mov(al, memb_a16[ds, 0x1272]);            /* mov al, [0x1272] */
            ii(0x15_63a1, 1); cbw();                                    /* cbw */
            ii(0x15_63a2, 1); cwd();                                    /* cwd */
            ii(0x15_63a3, 3); or(memw_a16[ss, bp - 0x34], ax);          /* or [bp-0x34], ax */
            ii(0x15_63a6, 3); or(memw_a16[ss, bp - 0x32], dx);          /* or [bp-0x32], dx */
            ii(0x15_63a9, 4); and(memw_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and word [bp-0x22], 0xfffe */
            ii(0x15_63ad, 4); and(memw_a16[ss, bp - 0x20], -0x1 /* 0xff */); /* and word [bp-0x20], 0xffff */
            ii(0x15_63b1, 5); mov(memb_a16[ds, 0x1272], 0x6);           /* mov byte [0x1272], 0x6 */
            ii(0x15_63b6, 3); jmpw(0x15_7817, 0x145e); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_63b9, 3); jmpw(0x15_642d, 0x71); goto l_0x15_642d;  /* jmp 0x642d */
        l_0x15_63bc:
            ii(0x15_63bc, 4); test(memb_a16[ss, bp - 0x3b], 0xff);      /* test byte [bp-0x3b], 0xff */
            ii(0x15_63c0, 2); if(jzw(0x15_63c5, 0x3)) goto l_0x15_63c5; /* jz 0x63c5 */
            ii(0x15_63c2, 3); jmpw(0x15_642d, 0x68); goto l_0x15_642d;  /* jmp 0x642d */
        l_0x15_63c5:
            ii(0x15_63c5, 3); mov(al, memb_a16[ss, bp - 0x3c]);         /* mov al, [bp-0x3c] */
            ii(0x15_63c8, 3); mov(memb_a16[ds, 0x1272], al);            /* mov [0x1272], al */
            ii(0x15_63cb, 4); mov(memb_a16[ss, bp - 0xb], 0);           /* mov byte [bp-0xb], 0x0 */
            ii(0x15_63cf, 3); mov(al, memb_a16[ss, bp - 0x3c]);         /* mov al, [bp-0x3c] */
            ii(0x15_63d2, 3); mov(memb_a16[ss, bp - 0xc], al);          /* mov [bp-0xc], al */
            ii(0x15_63d5, 4); mov(memb_a16[ss, bp - 0x11], 0xff);       /* mov byte [bp-0x11], 0xff */
            ii(0x15_63d9, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_63dc, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_63df, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x15_63e2, 3); lea(ax, bp - 0x1e);                       /* lea ax, [bp-0x1e] */
            ii(0x15_63e5, 1); pushw(ss);                                /* push ss */
            ii(0x15_63e6, 1); pushw(ax);                                /* push ax */
            ii(0x15_63e7, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x15_63ea, 1); pushw(ss);                                /* push ss */
            ii(0x15_63eb, 1); pushw(ax);                                /* push ax */
            ii(0x15_63ec, 1); pushw(ss);                                /* push ss */
            ii(0x15_63ed, 1); pushw(ax);                                /* push ax */
            ii(0x15_63ee, 4); callw_a16_far_ind(ds, 0x1286);            /* call far word [0x1286] */
            ii(0x15_63f2, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_63f5, 4); and(memw_a16[ss, bp - 0x34], 0);          /* and word [bp-0x34], 0x0 */
            ii(0x15_63f9, 4); and(memw_a16[ss, bp - 0x32], -0x1 /* 0xff */); /* and word [bp-0x32], 0xffff */
            ii(0x15_63fd, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x15_6400, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6402, 3); or(memw_a16[ss, bp - 0x34], ax);          /* or [bp-0x34], ax */
            ii(0x15_6405, 3); or(memw_a16[ss, bp - 0x32], dx);          /* or [bp-0x32], dx */
            ii(0x15_6408, 5); cmp(memb_a16[ds, 0x1271], 0);             /* cmp byte [0x1271], 0x0 */
            ii(0x15_640d, 2); if(jnzw(0x15_6412, 0x3)) goto l_0x15_6412; /* jnz 0x6412 */
            ii(0x15_640f, 3); jmpw(0x15_642a, 0x18); goto l_0x15_642a;  /* jmp 0x642a */
        l_0x15_6412:
            ii(0x15_6412, 4); and(memw_a16[ss, bp - 0x34], 0);          /* and word [bp-0x34], 0x0 */
            ii(0x15_6416, 4); and(memw_a16[ss, bp - 0x32], -0x1 /* 0xff */); /* and word [bp-0x32], 0xffff */
            ii(0x15_641a, 3); mov(al, memb_a16[ds, 0x1271]);            /* mov al, [0x1271] */
            ii(0x15_641d, 1); cbw();                                    /* cbw */
            ii(0x15_641e, 1); cwd();                                    /* cwd */
            ii(0x15_641f, 3); or(memw_a16[ss, bp - 0x34], ax);          /* or [bp-0x34], ax */
            ii(0x15_6422, 3); or(memw_a16[ss, bp - 0x32], dx);          /* or [bp-0x32], dx */
            ii(0x15_6425, 5); mov(memb_a16[ds, 0x1271], 0);             /* mov byte [0x1271], 0x0 */
        l_0x15_642a:
            ii(0x15_642a, 3); jmpw(0x15_7817, 0x13ea); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_642d:
            ii(0x15_642d, 3); jmpw(0x15_633b, -0xf5); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6430:
            ii(0x15_6430, 4); test(memb_a16[ss, bp - 0x34], 0x1);       /* test byte [bp-0x34], 0x1 */
            ii(0x15_6434, 2); if(jnzw(0x15_6439, 0x3)) goto l_0x15_6439; /* jnz 0x6439 */
            ii(0x15_6436, 3); jmpw(0x15_643f, 0x6); goto l_0x15_643f;   /* jmp 0x643f */
        l_0x15_6439:
            ii(0x15_6439, 3); jmpw(0x15_633b, -0x101); goto l_0x15_633b; /* jmp 0x633b */
        //    ii(0x15_643c, 3); jmpw(0x15_6442, 0x3); goto l_0x15_6442;   /* jmp 0x6442 */
        l_0x15_643f:
            ii(0x15_643f, 3); jmpw(0x15_6442, 0); goto l_0x15_6442;     /* jmp 0x6442 */
        l_0x15_6442:
            ii(0x15_6442, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_6445, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_6448, 3); and(ax, memw_a16[ss, bp - 0x3c]);         /* and ax, [bp-0x3c] */
            ii(0x15_644b, 3); and(dx, memw_a16[ss, bp - 0x3a]);         /* and dx, [bp-0x3a] */
            ii(0x15_644e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_6450, 2); if(jnzw(0x15_6455, 0x3)) goto l_0x15_6455; /* jnz 0x6455 */
            ii(0x15_6452, 3); jmpw(0x15_64c2, 0x6d); goto l_0x15_64c2;  /* jmp 0x64c2 */
        l_0x15_6455:
            ii(0x15_6455, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_6458, 3); mov(memw_a16[ss, bp - 0x62], ax);         /* mov [bp-0x62], ax */
            ii(0x15_645b, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_645e, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_6461, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_6464, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
            ii(0x15_6467, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_646a, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_646d, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_6470, 1); nop();                                    /* nop */
            ii(0x15_6471, 1); pushw(cs);                                /* push cs */
            ii(0x15_6472, 3); callw(0x15_789c, 0x1427);                 /* call 0x789c */
            ii(0x15_6475, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6478, 3); mov(memw_a16[ss, bp - 0x68], ax);         /* mov [bp-0x68], ax */
            ii(0x15_647b, 3); mov(ax, memw_a16[ss, bp - 0x68]);         /* mov ax, [bp-0x68] */
            ii(0x15_647e, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_6481, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_6483, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_6486, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_6489, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_648c, 1); pushw(ss);                                /* push ss */
            ii(0x15_648d, 1); pushw(ax);                                /* push ax */
            ii(0x15_648e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_6491, 3); callw(0x15_61c1, -0x2d3);                 /* call 0x61c1 */
            ii(0x15_6494, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6497, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x15_649b, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_649e, 3); cmp(memw_a16[ss, bp - 0x68], ax);         /* cmp [bp-0x68], ax */
            ii(0x15_64a1, 2); if(jzw(0x15_64a6, 0x3)) goto l_0x15_64a6; /* jz 0x64a6 */
            ii(0x15_64a3, 3); jmpw(0x15_64ac, 0x6); goto l_0x15_64ac;   /* jmp 0x64ac */
        l_0x15_64a6:
            ii(0x15_64a6, 3); mov(ax, memw_a16[ss, bp - 0x62]);         /* mov ax, [bp-0x62] */
            ii(0x15_64a9, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
        l_0x15_64ac:
            ii(0x15_64ac, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_64af, 1); cwd();                                    /* cwd */
            ii(0x15_64b0, 3); add(ax, memw_a16[ss, bp - 0x66]);         /* add ax, [bp-0x66] */
            ii(0x15_64b3, 3); adc(dx, memw_a16[ss, bp - 0x64]);         /* adc dx, [bp-0x64] */
            ii(0x15_64b6, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_64b9, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x15_64bc, 3); jmpw(0x15_7817, 0x1358); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_64bf, 3); jmpw(0x15_64c5, 0x3); goto l_0x15_64c5;   /* jmp 0x64c5 */
        l_0x15_64c2:
            ii(0x15_64c2, 3); jmpw(0x15_633b, -0x18a); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_64c5:
            ii(0x15_64c5, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_64c8, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_64cb, 3); and(ax, memw_a16[ss, bp - 0x3c]);         /* and ax, [bp-0x3c] */
            ii(0x15_64ce, 3); and(dx, memw_a16[ss, bp - 0x3a]);         /* and dx, [bp-0x3a] */
            ii(0x15_64d1, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_64d3, 2); if(jnzw(0x15_64d8, 0x3)) goto l_0x15_64d8; /* jnz 0x64d8 */
            ii(0x15_64d5, 3); jmpw(0x15_654a, 0x72); goto l_0x15_654a;  /* jmp 0x654a */
        l_0x15_64d8:
            ii(0x15_64d8, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_64db, 3); mov(memw_a16[ds, 0x4894], ax);            /* mov [0x4894], ax */
            ii(0x15_64de, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_64e1, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_64e4, 3); mov(memw_a16[ds, 0x4890], ax);            /* mov [0x4890], ax */
            ii(0x15_64e7, 4); mov(memw_a16[ds, 0x4892], dx);            /* mov [0x4892], dx */
            ii(0x15_64eb, 6); mov(memw_a16[ds, 0x489a], 0x1);           /* mov word [0x489a], 0x1 */
            ii(0x15_64f1, 4); pushw(memw_a16[ds, 0x4896]);              /* push word [0x4896] */
            ii(0x15_64f5, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_64f8, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_64fb, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_64fe, 3); callw(0x15_78d4, 0x13d3);                 /* call 0x78d4 */
            ii(0x15_6501, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_6504, 3); mov(ax, memw_a16[ds, 0x4896]);            /* mov ax, [0x4896] */
            ii(0x15_6507, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_650a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_650c, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_650f, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_6512, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_6515, 1); pushw(ss);                                /* push ss */
            ii(0x15_6516, 1); pushw(ax);                                /* push ax */
            ii(0x15_6517, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_651a, 3); callw(0x15_61c1, -0x35c);                 /* call 0x61c1 */
            ii(0x15_651d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6520, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_6523, 4); cmp(memw_a16[ds, 0x4896], ax);            /* cmp [0x4896], ax */
            ii(0x15_6527, 2); if(jzw(0x15_652c, 0x3)) goto l_0x15_652c; /* jz 0x652c */
            ii(0x15_6529, 3); jmpw(0x15_6532, 0x6); goto l_0x15_6532;   /* jmp 0x6532 */
        l_0x15_652c:
            ii(0x15_652c, 3); mov(ax, memw_a16[ds, 0x4894]);            /* mov ax, [0x4894] */
            ii(0x15_652f, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
        l_0x15_6532:
            ii(0x15_6532, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_6535, 1); cwd();                                    /* cwd */
            ii(0x15_6536, 4); add(ax, memw_a16[ds, 0x4890]);            /* add ax, [0x4890] */
            ii(0x15_653a, 4); adc(dx, memw_a16[ds, 0x4892]);            /* adc dx, [0x4892] */
            ii(0x15_653e, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_6541, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x15_6544, 3); jmpw(0x15_7817, 0x12d0); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_6547, 3); jmpw(0x15_655f, 0x15); goto l_0x15_655f;  /* jmp 0x655f */
        l_0x15_654a:
            ii(0x15_654a, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_654d, 4); cmp(memw_a16[ds, 0x4896], ax);            /* cmp [0x4896], ax */
            ii(0x15_6551, 2); if(jnzw(0x15_6556, 0x3)) goto l_0x15_6556; /* jnz 0x6556 */
            ii(0x15_6553, 3); jmpw(0x15_655c, 0x6); goto l_0x15_655c;   /* jmp 0x655c */
        l_0x15_6556:
            ii(0x15_6556, 6); mov(memw_a16[ds, 0x489a], 0);             /* mov word [0x489a], 0x0 */
        l_0x15_655c:
            ii(0x15_655c, 3); jmpw(0x15_633b, -0x224); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_655f:
            ii(0x15_655f, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_6562, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6564, 3); mov(memw_a16[ss, bp - 0x6a], ax);         /* mov [bp-0x6a], ax */
            ii(0x15_6567, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_656a, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_656d, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_6570, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_6573, 3); mov(memw_a16[ss, bp - 0x6e], ax);         /* mov [bp-0x6e], ax */
            ii(0x15_6576, 3); mov(memw_a16[ss, bp - 0x6c], dx);         /* mov [bp-0x6c], dx */
            ii(0x15_6579, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_657c, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_6581, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6584, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6587, 2); if(jzw(0x15_658c, 0x3)) goto l_0x15_658c; /* jz 0x658c */
            ii(0x15_6589, 3); jmpw(0x15_65ce, 0x42); goto l_0x15_65ce;  /* jmp 0x65ce */
        l_0x15_658c:
            ii(0x15_658c, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_658f, 4); cmp(memw_a16[ds, 0x1280], ax);            /* cmp [0x1280], ax */
            ii(0x15_6593, 2); if(jzw(0x15_6598, 0x3)) goto l_0x15_6598; /* jz 0x6598 */
            ii(0x15_6595, 3); jmpw(0x15_65ad, 0x15); goto l_0x15_65ad;  /* jmp 0x65ad */
        l_0x15_6598:
            ii(0x15_6598, 3); mov(ax, memw_a16[ds, 0x127e]);            /* mov ax, [0x127e] */
            ii(0x15_659b, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_659d, 3); cmp(ax, memw_a16[ss, bp - 0x6e]);         /* cmp ax, [bp-0x6e] */
            ii(0x15_65a0, 2); if(jzw(0x15_65a5, 0x3)) goto l_0x15_65a5; /* jz 0x65a5 */
            ii(0x15_65a2, 3); jmpw(0x15_65ad, 0x8); goto l_0x15_65ad;   /* jmp 0x65ad */
        l_0x15_65a5:
            ii(0x15_65a5, 3); cmp(dx, memw_a16[ss, bp - 0x6c]);         /* cmp dx, [bp-0x6c] */
            ii(0x15_65a8, 2); if(jnzw(0x15_65ad, 0x3)) goto l_0x15_65ad; /* jnz 0x65ad */
            ii(0x15_65aa, 3); jmpw(0x15_65ce, 0x21); goto l_0x15_65ce;  /* jmp 0x65ce */
        l_0x15_65ad:
            ii(0x15_65ad, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_65b0, 4); cmp(memw_a16[ds, 0x1284], ax);            /* cmp [0x1284], ax */
            ii(0x15_65b4, 2); if(jzw(0x15_65b9, 0x3)) goto l_0x15_65b9; /* jz 0x65b9 */
            ii(0x15_65b6, 3); jmpw(0x15_65d6, 0x1d); goto l_0x15_65d6;  /* jmp 0x65d6 */
        l_0x15_65b9:
            ii(0x15_65b9, 3); mov(ax, memw_a16[ds, 0x1282]);            /* mov ax, [0x1282] */
            ii(0x15_65bc, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_65be, 3); cmp(ax, memw_a16[ss, bp - 0x6e]);         /* cmp ax, [bp-0x6e] */
            ii(0x15_65c1, 2); if(jzw(0x15_65c6, 0x3)) goto l_0x15_65c6; /* jz 0x65c6 */
            ii(0x15_65c3, 3); jmpw(0x15_65d6, 0x10); goto l_0x15_65d6;  /* jmp 0x65d6 */
        l_0x15_65c6:
            ii(0x15_65c6, 3); cmp(dx, memw_a16[ss, bp - 0x6c]);         /* cmp dx, [bp-0x6c] */
            ii(0x15_65c9, 2); if(jzw(0x15_65ce, 0x3)) goto l_0x15_65ce; /* jz 0x65ce */
            ii(0x15_65cb, 3); jmpw(0x15_65d6, 0x8); goto l_0x15_65d6;   /* jmp 0x65d6 */
        l_0x15_65ce:
            ii(0x15_65ce, 5); mov(memw_a16[ss, bp - 0x68], 0x1);        /* mov word [bp-0x68], 0x1 */
            ii(0x15_65d3, 3); jmpw(0x15_65db, 0x5); goto l_0x15_65db;   /* jmp 0x65db */
        l_0x15_65d6:
            ii(0x15_65d6, 5); mov(memw_a16[ss, bp - 0x68], 0);          /* mov word [bp-0x68], 0x0 */
        l_0x15_65db:
            ii(0x15_65db, 4); cmp(memw_a16[ss, bp - 0x68], 0);          /* cmp word [bp-0x68], 0x0 */
            ii(0x15_65df, 2); if(jzw(0x15_65e4, 0x3)) goto l_0x15_65e4; /* jz 0x65e4 */
            ii(0x15_65e1, 3); jmpw(0x15_65ef, 0xb); goto l_0x15_65ef;   /* jmp 0x65ef */
        l_0x15_65e4:
            ii(0x15_65e4, 3); mov(ax, memw_a16[ss, bp - 0x6e]);         /* mov ax, [bp-0x6e] */
            ii(0x15_65e7, 3); mov(memw_a16[ss, bp - 0x6e], ax);         /* mov [bp-0x6e], ax */
            ii(0x15_65ea, 5); mov(memw_a16[ss, bp - 0x6c], 0);          /* mov word [bp-0x6c], 0x0 */
        l_0x15_65ef:
            ii(0x15_65ef, 4); cmp(memw_a16[ss, bp - 0x6a], 0x7);        /* cmp word [bp-0x6a], 0x7 */
            ii(0x15_65f3, 2); if(jnzw(0x15_65f8, 0x3)) goto l_0x15_65f8; /* jnz 0x65f8 */
            ii(0x15_65f5, 3); jmpw(0x15_6601, 0x9); goto l_0x15_6601;   /* jmp 0x6601 */
        l_0x15_65f8:
            ii(0x15_65f8, 4); cmp(memw_a16[ss, bp - 0x6a], 0x10);       /* cmp word [bp-0x6a], 0x10 */
            ii(0x15_65fc, 2); if(jzw(0x15_6601, 0x3)) goto l_0x15_6601; /* jz 0x6601 */
            ii(0x15_65fe, 3); jmpw(0x15_6668, 0x67); goto l_0x15_6668;  /* jmp 0x6668 */
        l_0x15_6601:
            ii(0x15_6601, 4); cmp(memw_a16[ss, bp - 0x6a], 0x7);        /* cmp word [bp-0x6a], 0x7 */
            ii(0x15_6605, 2); if(jzw(0x15_660a, 0x3)) goto l_0x15_660a; /* jz 0x660a */
            ii(0x15_6607, 3); jmpw(0x15_6649, 0x3f); goto l_0x15_6649;  /* jmp 0x6649 */
        l_0x15_660a:
            ii(0x15_660a, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x15_660f, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6612, 2); if(jzw(0x15_6617, 0x3)) goto l_0x15_6617; /* jz 0x6617 */
            ii(0x15_6614, 3); jmpw(0x15_6649, 0x32); goto l_0x15_6649;  /* jmp 0x6649 */
        l_0x15_6617:
            ii(0x15_6617, 4); mov(es, memw_a16[ds, 0x3f94]);            /* mov es, [0x3f94] */
            ii(0x15_661b, 3); mov(ax, 0x38);                            /* mov ax, 0x38 */
            ii(0x15_661e, 5); mov(dx, memw_a16[es, 0x3b74]);            /* mov dx, [es:0x3b74] */
            ii(0x15_6623, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_6626, 3); mov(memw_a16[ss, bp - 0x7c], dx);         /* mov [bp-0x7c], dx */
            ii(0x15_6629, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_662c, 3); les(bx, ss, bp - 0x7e);                   /* les bx, [bp-0x7e] */
            ii(0x15_662f, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_6633, 3); mov(ax, memw_a16[ss, bp - 0x6e]);         /* mov ax, [bp-0x6e] */
            ii(0x15_6636, 3); les(bx, ss, bp - 0x7e);                   /* les bx, [bp-0x7e] */
            ii(0x15_6639, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_663c, 3); mov(ax, memw_a16[ss, bp - 0x6c]);         /* mov ax, [bp-0x6c] */
            ii(0x15_663f, 3); les(bx, ss, bp - 0x7e);                   /* les bx, [bp-0x7e] */
            ii(0x15_6642, 4); mov(memw_a16[es, bx + 0x6], ax);          /* mov [es:bx+0x6], ax */
            ii(0x15_6646, 3); jmpw(0x15_6668, 0x1f); goto l_0x15_6668;  /* jmp 0x6668 */
        l_0x15_6649:
            ii(0x15_6649, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_664c, 3); pushw(memw_a16[ss, bp - 0x6c]);           /* push word [bp-0x6c] */
            ii(0x15_664f, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_6652, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6655, 5); callw_far_abs(0x80, 0xaf2);               /* call word 0x80:0xaf2 */
            ii(0x15_665a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_665d, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6660, 5); callw_far_abs(0x80, 0xb0c);               /* call word 0x80:0xb0c */
            ii(0x15_6665, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x15_6668:
            ii(0x15_6668, 4); cmp(memw_a16[ss, bp - 0x68], 0);          /* cmp word [bp-0x68], 0x0 */
            ii(0x15_666c, 2); if(jzw(0x15_6671, 0x3)) goto l_0x15_6671; /* jz 0x6671 */
            ii(0x15_666e, 3); jmpw(0x15_671a, 0xa9); goto l_0x15_671a;  /* jmp 0x671a */
        l_0x15_6671:
            ii(0x15_6671, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_6674, 1); pushw(ss);                                /* push ss */
            ii(0x15_6675, 1); pushw(ax);                                /* push ax */
            ii(0x15_6676, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6679, 1); nop();                                    /* nop */
            ii(0x15_667a, 1); pushw(cs);                                /* push cs */
            ii(0x15_667b, 3); callw(0x15_8a8a, 0x240c);                 /* call 0x8a8a */
            ii(0x15_667e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6681, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6684, 2); if(jnzw(0x15_6689, 0x3)) goto l_0x15_6689; /* jnz 0x6689 */
            ii(0x15_6686, 3); jmpw(0x15_668f, 0x6); goto l_0x15_668f;   /* jmp 0x668f */
        l_0x15_6689:
            ii(0x15_6689, 3); jmpw(0x15_7817, 0x118b); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_668c, 3); jmpw(0x15_671a, 0x8b); goto l_0x15_671a;  /* jmp 0x671a */
        l_0x15_668f:
            ii(0x15_668f, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6692, 1); nop();                                    /* nop */
            ii(0x15_6693, 1); pushw(cs);                                /* push cs */
            ii(0x15_6694, 3); callw(0x15_6183, -0x514);                 /* call 0x6183 */
            ii(0x15_6697, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_669a, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_669d, 2); if(jnzw(0x15_66a2, 0x3)) goto l_0x15_66a2; /* jnz 0x66a2 */
            ii(0x15_669f, 3); jmpw(0x15_671a, 0x78); goto l_0x15_671a;  /* jmp 0x671a */
        l_0x15_66a2:
            ii(0x15_66a2, 4); mov(es, memw_a16[ds, 0x3f94]);            /* mov es, [0x3f94] */
            ii(0x15_66a6, 6); cmp(memw_a16[es, 0x3b72], 0);             /* cmp word [es:0x3b72], 0x0 */
            ii(0x15_66ac, 2); if(jnzw(0x15_66b1, 0x3)) goto l_0x15_66b1; /* jnz 0x66b1 */
            ii(0x15_66ae, 3); jmpw(0x15_670d, 0x5c); goto l_0x15_670d;  /* jmp 0x670d */
        l_0x15_66b1:
            ii(0x15_66b1, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_66b4, 1); pushw(ds);                                /* push ds */
            ii(0x15_66b5, 3); pushw(0x12f3);                            /* push 0x12f3 */
            ii(0x15_66b8, 3); callw(0x15_1066, -0x5655);                /* call 0x1066 */
            ii(0x15_66bb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_66be, 3); pushw(memw_a16[ss, bp - 0x5a]);           /* push word [bp-0x5a] */
            ii(0x15_66c1, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_66c4, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_66c7, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_66ca, 1); nop();                                    /* nop */
            ii(0x15_66cb, 1); pushw(cs);                                /* push cs */
            ii(0x15_66cc, 3); callw(0x15_6131, -0x59e);                 /* call 0x6131 */
            ii(0x15_66cf, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_66d2, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_66d5, 3); pushw(memw_a16[ss, bp - 0x6c]);           /* push word [bp-0x6c] */
            ii(0x15_66d8, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_66db, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_66de, 5); callw_far_abs(0x80, 0xaf2);               /* call word 0x80:0xaf2 */
            ii(0x15_66e3, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_66e6, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_66e9, 3); shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x15_66ec, 3); add(ax, 0x5);                             /* add ax, 0x5 */
            ii(0x15_66ef, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_66f1, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x15_66f4, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_66f6, 4); mov(memb_a16[es, bx], 0x86);              /* mov byte [es:bx], 0x86 */
            ii(0x15_66fa, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_66fc, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_66ff, 1); nop();                                    /* nop */
            ii(0x15_6700, 1); pushw(cs);                                /* push cs */
            ii(0x15_6701, 3); callw(0x15_606f, -0x695);                 /* call 0x606f */
            ii(0x15_6704, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6707, 3); jmpw(0x15_7817, 0x110d); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_670a, 3); jmpw(0x15_671a, 0xd); goto l_0x15_671a;   /* jmp 0x671a */
        l_0x15_670d:
            ii(0x15_670d, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6710, 1); pushw(ds);                                /* push ds */
            ii(0x15_6711, 3); pushw(0x1315);                            /* push 0x1315 */
            ii(0x15_6714, 3); callw(0x15_1066, -0x56b1);                /* call 0x1066 */
            ii(0x15_6717, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_671a:
            ii(0x15_671a, 5); mov(memw_a16[ss, bp - 0x62], 0);          /* mov word [bp-0x62], 0x0 */
            ii(0x15_671f, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_6722, 4); cmp(memw_a16[ds, 0x1278], ax);            /* cmp [0x1278], ax */
            ii(0x15_6726, 2); if(jzw(0x15_672b, 0x3)) goto l_0x15_672b; /* jz 0x672b */
            ii(0x15_6728, 3); jmpw(0x15_6740, 0x15); goto l_0x15_6740;  /* jmp 0x6740 */
        l_0x15_672b:
            ii(0x15_672b, 3); mov(ax, memw_a16[ds, 0x1276]);            /* mov ax, [0x1276] */
            ii(0x15_672e, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6730, 3); cmp(ax, memw_a16[ss, bp - 0x6e]);         /* cmp ax, [bp-0x6e] */
            ii(0x15_6733, 2); if(jzw(0x15_6738, 0x3)) goto l_0x15_6738; /* jz 0x6738 */
            ii(0x15_6735, 3); jmpw(0x15_6740, 0x8); goto l_0x15_6740;   /* jmp 0x6740 */
        l_0x15_6738:
            ii(0x15_6738, 3); cmp(dx, memw_a16[ss, bp - 0x6c]);         /* cmp dx, [bp-0x6c] */
            ii(0x15_673b, 2); if(jnzw(0x15_6740, 0x3)) goto l_0x15_6740; /* jnz 0x6740 */
            ii(0x15_673d, 3); jmpw(0x15_6761, 0x21); goto l_0x15_6761;  /* jmp 0x6761 */
        l_0x15_6740:
            ii(0x15_6740, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_6743, 4); cmp(memw_a16[ds, 0x127c], ax);            /* cmp [0x127c], ax */
            ii(0x15_6747, 2); if(jzw(0x15_674c, 0x3)) goto l_0x15_674c; /* jz 0x674c */
            ii(0x15_6749, 3); jmpw(0x15_67b3, 0x67); goto l_0x15_67b3;  /* jmp 0x67b3 */
        l_0x15_674c:
            ii(0x15_674c, 3); mov(ax, memw_a16[ds, 0x127a]);            /* mov ax, [0x127a] */
            ii(0x15_674f, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6751, 3); cmp(ax, memw_a16[ss, bp - 0x6e]);         /* cmp ax, [bp-0x6e] */
            ii(0x15_6754, 2); if(jzw(0x15_6759, 0x3)) goto l_0x15_6759; /* jz 0x6759 */
            ii(0x15_6756, 3); jmpw(0x15_67b3, 0x5a); goto l_0x15_67b3;  /* jmp 0x67b3 */
        l_0x15_6759:
            ii(0x15_6759, 3); cmp(dx, memw_a16[ss, bp - 0x6c]);         /* cmp dx, [bp-0x6c] */
            ii(0x15_675c, 2); if(jzw(0x15_6761, 0x3)) goto l_0x15_6761; /* jz 0x6761 */
            ii(0x15_675e, 3); jmpw(0x15_67b3, 0x52); goto l_0x15_67b3;  /* jmp 0x67b3 */
        l_0x15_6761:
            ii(0x15_6761, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_6763, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6766, 1); nop();                                    /* nop */
            ii(0x15_6767, 1); pushw(cs);                                /* push cs */
            ii(0x15_6768, 3); callw(0x15_606f, -0x6fc);                 /* call 0x606f */
            ii(0x15_676b, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_676e, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6771, 5); callw_far_abs(0x80, 0x1040);              /* call word 0x80:0x1040 */
            ii(0x15_6776, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6779, 1); pushw(ax);                                /* push ax */
            ii(0x15_677a, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_677d, 1); nop();                                    /* nop */
            ii(0x15_677e, 1); pushw(cs);                                /* push cs */
            ii(0x15_677f, 3); callw(0x15_7dc0, 0x163e);                 /* call 0x7dc0 */
            ii(0x15_6782, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6785, 4); cmp(memw_a16[ss, bp - 0x6a], 0x20);       /* cmp word [bp-0x6a], 0x20 */
            ii(0x15_6789, 2); if(jbw(0x15_678e, 0x3)) goto l_0x15_678e; /* jb 0x678e */
            ii(0x15_678b, 3); jmpw(0x15_67ad, 0x1f); goto l_0x15_67ad;  /* jmp 0x67ad */
        l_0x15_678e:
            ii(0x15_678e, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_6791, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_6794, 1); pushw(ax);                                /* push ax */
            ii(0x15_6795, 5); callw_far_abs(0x80, 0x1040);              /* call word 0x80:0x1040 */
            ii(0x15_679a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_679d, 1); pushw(ax);                                /* push ax */
            ii(0x15_679e, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_67a1, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_67a4, 1); pushw(ax);                                /* push ax */
            ii(0x15_67a5, 1); nop();                                    /* nop */
            ii(0x15_67a6, 1); pushw(cs);                                /* push cs */
            ii(0x15_67a7, 3); callw(0x15_7dc0, 0x1616);                 /* call 0x7dc0 */
            ii(0x15_67aa, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x15_67ad:
            ii(0x15_67ad, 3); inc(memw_a16[ss, bp - 0x62]);             /* inc word [bp-0x62] */
            ii(0x15_67b0, 3); jmpw(0x15_6824, 0x71); goto l_0x15_6824;  /* jmp 0x6824 */
        l_0x15_67b3:
            ii(0x15_67b3, 3); pushw(memw_a16[ss, bp - 0x6c]);           /* push word [bp-0x6c] */
            ii(0x15_67b6, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_67b9, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_67bc, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_67bf, 5); callw_far_abs(0x80, 0xfc1);               /* call word 0x80:0xfc1 */
            ii(0x15_67c4, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_67c7, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_67ca, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_67cd, 2); if(jnzw(0x15_67d2, 0x3)) goto l_0x15_67d2; /* jnz 0x67d2 */
            ii(0x15_67cf, 3); jmpw(0x15_67e3, 0x11); goto l_0x15_67e3;  /* jmp 0x67e3 */
        l_0x15_67d2:
            ii(0x15_67d2, 3); pushw(memw_a16[ss, bp - 0x70]);           /* push word [bp-0x70] */
            ii(0x15_67d5, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_67d8, 1); nop();                                    /* nop */
            ii(0x15_67d9, 1); pushw(cs);                                /* push cs */
            ii(0x15_67da, 3); callw(0x15_7dc0, 0x15e3);                 /* call 0x7dc0 */
            ii(0x15_67dd, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_67e0, 3); inc(memw_a16[ss, bp - 0x62]);             /* inc word [bp-0x62] */
        l_0x15_67e3:
            ii(0x15_67e3, 4); cmp(memw_a16[ss, bp - 0x6a], 0x20);       /* cmp word [bp-0x6a], 0x20 */
            ii(0x15_67e7, 2); if(jbw(0x15_67ec, 0x3)) goto l_0x15_67ec; /* jb 0x67ec */
            ii(0x15_67e9, 3); jmpw(0x15_6824, 0x38); goto l_0x15_6824;  /* jmp 0x6824 */
        l_0x15_67ec:
            ii(0x15_67ec, 3); pushw(memw_a16[ss, bp - 0x6c]);           /* push word [bp-0x6c] */
            ii(0x15_67ef, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_67f2, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_67f5, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_67f8, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_67fb, 1); pushw(ax);                                /* push ax */
            ii(0x15_67fc, 5); callw_far_abs(0x80, 0xfc1);               /* call word 0x80:0xfc1 */
            ii(0x15_6801, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_6804, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_6807, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_680a, 2); if(jnzw(0x15_680f, 0x3)) goto l_0x15_680f; /* jnz 0x680f */
            ii(0x15_680c, 3); jmpw(0x15_6824, 0x15); goto l_0x15_6824;  /* jmp 0x6824 */
        l_0x15_680f:
            ii(0x15_680f, 3); pushw(memw_a16[ss, bp - 0x70]);           /* push word [bp-0x70] */
            ii(0x15_6812, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_6815, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_6818, 1); pushw(ax);                                /* push ax */
            ii(0x15_6819, 1); nop();                                    /* nop */
            ii(0x15_681a, 1); pushw(cs);                                /* push cs */
            ii(0x15_681b, 3); callw(0x15_7dc0, 0x15a2);                 /* call 0x7dc0 */
            ii(0x15_681e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6821, 3); inc(memw_a16[ss, bp - 0x62]);             /* inc word [bp-0x62] */
        l_0x15_6824:
            ii(0x15_6824, 4); cmp(memw_a16[ss, bp - 0x62], 0);          /* cmp word [bp-0x62], 0x0 */
            ii(0x15_6828, 2); if(jnzw(0x15_682d, 0x3)) goto l_0x15_682d; /* jnz 0x682d */
            ii(0x15_682a, 3); jmpw(0x15_6830, 0x3); goto l_0x15_6830;   /* jmp 0x6830 */
        l_0x15_682d:
            ii(0x15_682d, 3); jmpw(0x15_7817, 0xfe7); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6830:
            ii(0x15_6830, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6833, 5); callw_far_abs(0x80, 0x1040);              /* call word 0x80:0x1040 */
            ii(0x15_6838, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_683b, 1); pushw(ax);                                /* push ax */
            ii(0x15_683c, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_683f, 1); nop();                                    /* nop */
            ii(0x15_6840, 1); pushw(cs);                                /* push cs */
            ii(0x15_6841, 3); callw(0x15_7dc0, 0x157c);                 /* call 0x7dc0 */
            ii(0x15_6844, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6847, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_684a, 3); mov(memw_a16[ss, bp - 0x76], ax);         /* mov [bp-0x76], ax */
            ii(0x15_684d, 3); mov(ax, memw_a16[ss, bp - 0x6e]);         /* mov ax, [bp-0x6e] */
            ii(0x15_6850, 3); mov(dx, memw_a16[ss, bp - 0x6c]);         /* mov dx, [bp-0x6c] */
            ii(0x15_6853, 3); mov(memw_a16[ss, bp - 0x7a], ax);         /* mov [bp-0x7a], ax */
            ii(0x15_6856, 3); mov(memw_a16[ss, bp - 0x78], dx);         /* mov [bp-0x78], dx */
            ii(0x15_6859, 3); lea(ax, bp - 0x7a);                       /* lea ax, [bp-0x7a] */
            ii(0x15_685c, 1); pushw(ss);                                /* push ss */
            ii(0x15_685d, 1); pushw(ax);                                /* push ax */
            ii(0x15_685e, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6861, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x15_6866, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6869, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_686c, 3); mov(al, memb_a16[ss, bp - 0x68]);         /* mov al, [bp-0x68] */
            ii(0x15_686f, 2); add(al, 0x2);                             /* add al, 0x2 */
            ii(0x15_6871, 3); mov(si, memw_a16[ss, bp - 0x70]);         /* mov si, [bp-0x70] */
            ii(0x15_6874, 3); and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x15_6877, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_687b, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x15_6880, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
            ii(0x15_6883, 4); cmp(memw_a16[ss, bp - 0x6a], 0x20);       /* cmp word [bp-0x6a], 0x20 */
            ii(0x15_6887, 2); if(jbw(0x15_688c, 0x3)) goto l_0x15_688c; /* jb 0x688c */
            ii(0x15_6889, 3); jmpw(0x15_68d5, 0x49); goto l_0x15_68d5;  /* jmp 0x68d5 */
        l_0x15_688c:
            ii(0x15_688c, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_688f, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_6892, 1); pushw(ax);                                /* push ax */
            ii(0x15_6893, 5); callw_far_abs(0x80, 0x1040);              /* call word 0x80:0x1040 */
            ii(0x15_6898, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_689b, 1); pushw(ax);                                /* push ax */
            ii(0x15_689c, 3); mov(ax, memw_a16[ss, bp - 0x6a]);         /* mov ax, [bp-0x6a] */
            ii(0x15_689f, 3); add(ax, 0x100);                           /* add ax, 0x100 */
            ii(0x15_68a2, 1); pushw(ax);                                /* push ax */
            ii(0x15_68a3, 1); nop();                                    /* nop */
            ii(0x15_68a4, 1); pushw(cs);                                /* push cs */
            ii(0x15_68a5, 3); callw(0x15_7dc0, 0x1518);                 /* call 0x7dc0 */
            ii(0x15_68a8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_68ab, 3); lea(ax, bp - 0x7a);                       /* lea ax, [bp-0x7a] */
            ii(0x15_68ae, 1); pushw(ss);                                /* push ss */
            ii(0x15_68af, 1); pushw(ax);                                /* push ax */
            ii(0x15_68b0, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_68b3, 5); callw_far_abs(0x80, 0xb53);               /* call word 0x80:0xb53 */
            ii(0x15_68b8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_68bb, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_68be, 3); mov(al, memb_a16[ss, bp - 0x68]);         /* mov al, [bp-0x68] */
            ii(0x15_68c1, 2); add(al, 0x2);                             /* add al, 0x2 */
            ii(0x15_68c3, 3); mov(si, memw_a16[ss, bp - 0x70]);         /* mov si, [bp-0x70] */
            ii(0x15_68c6, 3); and(si, -0x8 /* 0xf8 */);                 /* and si, 0xfff8 */
            ii(0x15_68c9, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_68cd, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x15_68d2, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
        l_0x15_68d5:
            ii(0x15_68d5, 4); cmp(memw_a16[ss, bp - 0x68], 0);          /* cmp word [bp-0x68], 0x0 */
            ii(0x15_68d9, 2); if(jzw(0x15_68de, 0x3)) goto l_0x15_68de; /* jz 0x68de */
            ii(0x15_68db, 3); jmpw(0x15_68fb, 0x1d); goto l_0x15_68fb;  /* jmp 0x68fb */
        l_0x15_68de:
            ii(0x15_68de, 4); cmp(memw_a16[ss, bp - 0x6a], 0);          /* cmp word [bp-0x6a], 0x0 */
            ii(0x15_68e2, 2); if(jaw(0x15_68e7, 0x3)) goto l_0x15_68e7; /* ja 0x68e7 */
            ii(0x15_68e4, 3); jmpw(0x15_68fb, 0x14); goto l_0x15_68fb;  /* jmp 0x68fb */
        l_0x15_68e7:
            ii(0x15_68e7, 3); pushw(memw_a16[ss, bp - 0x5a]);           /* push word [bp-0x5a] */
            ii(0x15_68ea, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_68ed, 3); pushw(memw_a16[ss, bp - 0x66]);           /* push word [bp-0x66] */
            ii(0x15_68f0, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_68f3, 1); nop();                                    /* nop */
            ii(0x15_68f4, 1); pushw(cs);                                /* push cs */
            ii(0x15_68f5, 3); callw(0x15_6131, -0x7c7);                 /* call 0x6131 */
            ii(0x15_68f8, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x15_68fb:
            ii(0x15_68fb, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_68fe, 1); nop();                                    /* nop */
            ii(0x15_68ff, 1); pushw(cs);                                /* push cs */
            ii(0x15_6900, 3); callw(0x15_60d4, -0x82f);                 /* call 0x60d4 */
            ii(0x15_6903, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6906, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6909, 3); mov(memw_a16[ss, bp - 0x72], dx);         /* mov [bp-0x72], dx */
            ii(0x15_690c, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_690e, 2); if(jnzw(0x15_6913, 0x3)) goto l_0x15_6913; /* jnz 0x6913 */
            ii(0x15_6910, 3); jmpw(0x15_6920, 0xd); goto l_0x15_6920;   /* jmp 0x6920 */
        l_0x15_6913:
            ii(0x15_6913, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_6915, 3); pushw(memw_a16[ss, bp - 0x6a]);           /* push word [bp-0x6a] */
            ii(0x15_6918, 1); nop();                                    /* nop */
            ii(0x15_6919, 1); pushw(cs);                                /* push cs */
            ii(0x15_691a, 3); callw(0x15_606f, -0x8ae);                 /* call 0x606f */
            ii(0x15_691d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x15_6920:
            ii(0x15_6920, 3); jmpw(0x15_7817, 0xef4); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6923:
            ii(0x15_6923, 5); cmp(memw_a16[ds, 0x489a], 0);             /* cmp word [0x489a], 0x0 */
            ii(0x15_6928, 2); if(jnzw(0x15_692d, 0x3)) goto l_0x15_692d; /* jnz 0x692d */
            ii(0x15_692a, 3); jmpw(0x15_6966, 0x39); goto l_0x15_6966;  /* jmp 0x6966 */
        l_0x15_692d:
            ii(0x15_692d, 3); mov(ax, memw_a16[ds, 0x4894]);            /* mov ax, [0x4894] */
            ii(0x15_6930, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_6933, 3); mov(ax, memw_a16[ss, bp - 0x60]);         /* mov ax, [bp-0x60] */
            ii(0x15_6936, 3); mov(dx, memw_a16[ss, bp - 0x5e]);         /* mov dx, [bp-0x5e] */
            ii(0x15_6939, 2); not(ax);                                  /* not ax */
            ii(0x15_693b, 2); not(dx);                                  /* not dx */
            ii(0x15_693d, 3); and(ax, memw_a16[ss, bp - 0x40]);         /* and ax, [bp-0x40] */
            ii(0x15_6940, 3); and(dx, memw_a16[ss, bp - 0x3e]);         /* and dx, [bp-0x3e] */
            ii(0x15_6943, 4); mov(cx, memw_a16[ds, 0x4890]);            /* mov cx, [0x4890] */
            ii(0x15_6947, 4); mov(bx, memw_a16[ds, 0x4892]);            /* mov bx, [0x4892] */
            ii(0x15_694b, 3); and(cx, memw_a16[ss, bp - 0x60]);         /* and cx, [bp-0x60] */
            ii(0x15_694e, 3); and(bx, memw_a16[ss, bp - 0x5e]);         /* and bx, [bp-0x5e] */
            ii(0x15_6951, 2); or(ax, cx);                               /* or ax, cx */
            ii(0x15_6953, 2); or(dx, bx);                               /* or dx, bx */
            ii(0x15_6955, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_6958, 3); mov(memw_a16[ss, bp - 0x3e], dx);         /* mov [bp-0x3e], dx */
            ii(0x15_695b, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_6960, 3); jmpw(0x15_7817, 0xeb4); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_6963, 3); jmpw(0x15_6969, 0x3); goto l_0x15_6969;   /* jmp 0x6969 */
        l_0x15_6966:
            ii(0x15_6966, 3); jmpw(0x15_633b, -0x62e); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6969:
            ii(0x15_6969, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_696c, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_696f, 3); and(ax, memw_a16[ss, bp - 0x4c]);         /* and ax, [bp-0x4c] */
            ii(0x15_6972, 3); and(dx, memw_a16[ss, bp - 0x4a]);         /* and dx, [bp-0x4a] */
            ii(0x15_6975, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_6977, 2); if(jzw(0x15_697c, 0x3)) goto l_0x15_697c; /* jz 0x697c */
            ii(0x15_6979, 3); jmpw(0x15_698f, 0x13); goto l_0x15_698f;  /* jmp 0x698f */
        l_0x15_697c:
            ii(0x15_697c, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_697f, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_6982, 3); and(ax, memw_a16[ss, bp - 0x50]);         /* and ax, [bp-0x50] */
            ii(0x15_6985, 3); and(dx, memw_a16[ss, bp - 0x4e]);         /* and dx, [bp-0x4e] */
            ii(0x15_6988, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_698a, 2); if(jnzw(0x15_698f, 0x3)) goto l_0x15_698f; /* jnz 0x698f */
            ii(0x15_698c, 3); jmpw(0x15_6a4a, 0xbb); goto l_0x15_6a4a;  /* jmp 0x6a4a */
        l_0x15_698f:
            ii(0x15_698f, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_6992, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6995, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6998, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_699b, 3); mov(ax, memw_a16[ss, bp - 0x4c]);         /* mov ax, [bp-0x4c] */
            ii(0x15_699e, 3); mov(dx, memw_a16[ss, bp - 0x4a]);         /* mov dx, [bp-0x4a] */
            ii(0x15_69a1, 3); mov(memw_a16[ss, bp - 0x6e], ax);         /* mov [bp-0x6e], ax */
            ii(0x15_69a4, 3); mov(memw_a16[ss, bp - 0x6c], dx);         /* mov [bp-0x6c], dx */
            ii(0x15_69a7, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_69aa, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_69ad, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_69b0, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
            ii(0x15_69b3, 3); pushw(memw_a16[ss, bp - 0x4a]);           /* push word [bp-0x4a] */
            ii(0x15_69b6, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_69b9, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_69bc, 1); nop();                                    /* nop */
            ii(0x15_69bd, 1); pushw(cs);                                /* push cs */
            ii(0x15_69be, 3); callw(0x15_789c, 0xedb);                  /* call 0x789c */
            ii(0x15_69c1, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_69c4, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_69c7, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x15_69ca, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x15_69cd, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_69d0, 1); nop();                                    /* nop */
            ii(0x15_69d1, 1); pushw(cs);                                /* push cs */
            ii(0x15_69d2, 3); callw(0x15_789c, 0xec7);                  /* call 0x789c */
            ii(0x15_69d5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_69d8, 3); mov(memw_a16[ss, bp - 0x7a], ax);         /* mov [bp-0x7a], ax */
            ii(0x15_69db, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_69de, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_69e1, 3); mov(ax, memw_a16[ss, bp - 0x7a]);         /* mov ax, [bp-0x7a] */
            ii(0x15_69e4, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_69e7, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_69e9, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x15_69ec, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x15_69ef, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_69f1, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x15_69f4, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_69f7, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_69fa, 1); pushw(ss);                                /* push ss */
            ii(0x15_69fb, 1); pushw(ax);                                /* push ax */
            ii(0x15_69fc, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_69ff, 3); callw(0x15_61c1, -0x841);                 /* call 0x61c1 */
            ii(0x15_6a02, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6a05, 5); sub(memw_a16[ds, 0x1274], 0x2);           /* sub word [0x1274], 0x2 */
            ii(0x15_6a0a, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_6a0d, 3); cmp(memw_a16[ss, bp - 0x7e], ax);         /* cmp [bp-0x7e], ax */
            ii(0x15_6a10, 2); if(jzw(0x15_6a15, 0x3)) goto l_0x15_6a15; /* jz 0x6a15 */
            ii(0x15_6a12, 3); jmpw(0x15_6a27, 0x12); goto l_0x15_6a27;  /* jmp 0x6a27 */
        l_0x15_6a15:
            ii(0x15_6a15, 3); mov(ax, memw_a16[ss, bp - 0x74]);         /* mov ax, [bp-0x74] */
            ii(0x15_6a18, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_6a1b, 3); mov(ax, memw_a16[ss, bp - 0x6e]);         /* mov ax, [bp-0x6e] */
            ii(0x15_6a1e, 3); mov(dx, memw_a16[ss, bp - 0x6c]);         /* mov dx, [bp-0x6c] */
            ii(0x15_6a21, 3); add(memw_a16[ss, bp - 0x4c], ax);         /* add [bp-0x4c], ax */
            ii(0x15_6a24, 3); adc(memw_a16[ss, bp - 0x4a], dx);         /* adc [bp-0x4a], dx */
        l_0x15_6a27:
            ii(0x15_6a27, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6a2a, 3); cmp(memw_a16[ss, bp - 0x7a], ax);         /* cmp [bp-0x7a], ax */
            ii(0x15_6a2d, 2); if(jzw(0x15_6a32, 0x3)) goto l_0x15_6a32; /* jz 0x6a32 */
            ii(0x15_6a2f, 3); jmpw(0x15_6a44, 0x12); goto l_0x15_6a44;  /* jmp 0x6a44 */
        l_0x15_6a32:
            ii(0x15_6a32, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x15_6a35, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_6a38, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_6a3b, 3); mov(dx, memw_a16[ss, bp - 0x64]);         /* mov dx, [bp-0x64] */
            ii(0x15_6a3e, 3); add(memw_a16[ss, bp - 0x50], ax);         /* add [bp-0x50], ax */
            ii(0x15_6a41, 3); adc(memw_a16[ss, bp - 0x4e], dx);         /* adc [bp-0x4e], dx */
        l_0x15_6a44:
            ii(0x15_6a44, 3); jmpw(0x15_7817, 0xdd0); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_6a47, 3); jmpw(0x15_6a4d, 0x3); goto l_0x15_6a4d;   /* jmp 0x6a4d */
        l_0x15_6a4a:
            ii(0x15_6a4a, 3); jmpw(0x15_633b, -0x712); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6a4d:
            ii(0x15_6a4d, 1); pushw(ds);                                /* push ds */
            ii(0x15_6a4e, 3); pushw(0x133a);                            /* push 0x133a */
            ii(0x15_6a51, 3); pushw(0x3f6);                             /* push 0x3f6 */
            ii(0x15_6a54, 3); callw(0x15_1046, -0x5a11);                /* call 0x1046 */
            ii(0x15_6a57, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_6a5a:
            ii(0x15_6a5a, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_6a5d, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6a5f, 3); mov(memw_a16[ss, bp - 0x7a], ax);         /* mov [bp-0x7a], ax */
            ii(0x15_6a62, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_6a65, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_6a6a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6a6d, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_6a70, 4); mov(es, memw_a16[ds, 0x3f9a]);            /* mov es, [0x3f9a] */
            ii(0x15_6a74, 3); mov(bx, memw_a16[ss, bp - 0x7a]);         /* mov bx, [bp-0x7a] */
            ii(0x15_6a77, 5); mov(al, memb_a16[es, bx + 0x2]);          /* mov al, [es:bx+0x2] */
            ii(0x15_6a7c, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6a7e, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_6a80, 3); jmpw(0x15_6a99, 0x16); goto l_0x15_6a99;  /* jmp 0x6a99 */
        l_0x15_6a83:
            ii(0x15_6a83, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x15_6a85, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_6a88, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_6a8c, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x15_6a91, 4); mov(al, memb_a16[es, bx + di + 0x1]);     /* mov al, [es:bx+di+0x1] */
            ii(0x15_6a95, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6a97, 2); mov(si, ax);                              /* mov si, ax */
        l_0x15_6a99:
            ii(0x15_6a99, 3); cmp(si, 0x1);                             /* cmp si, 0x1 */
            ii(0x15_6a9c, 2); if(jnzw(0x15_6aa1, 0x3)) goto l_0x15_6aa1; /* jnz 0x6aa1 */
            ii(0x15_6a9e, 3); jmpw(0x15_6ac5, 0x24); goto l_0x15_6ac5;  /* jmp 0x6ac5 */
        l_0x15_6aa1:
            ii(0x15_6aa1, 2); mov(di, si);                              /* mov di, si */
            ii(0x15_6aa3, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x15_6aa6, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_6aaa, 5); les(bx, es, 0x122);                       /* les bx, [es:0x122] */
            ii(0x15_6aaf, 3); mov(al, memb_a16[es, bx + di]);           /* mov al, [es:bx+di] */
            ii(0x15_6ab2, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6ab4, 3); sub(ax, memw_a16[ss, bp - 0x7e]);         /* sub ax, [bp-0x7e] */
            ii(0x15_6ab7, 3); cmp(ax, 0x2);                             /* cmp ax, 0x2 */
            ii(0x15_6aba, 2); if(jzw(0x15_6abf, 0x3)) goto l_0x15_6abf; /* jz 0x6abf */
            ii(0x15_6abc, 3); jmpw(0x15_6ac2, 0x3); goto l_0x15_6ac2;   /* jmp 0x6ac2 */
        l_0x15_6abf:
            ii(0x15_6abf, 3); jmpw(0x15_6ac5, 0x3); goto l_0x15_6ac5;   /* jmp 0x6ac5 */
        l_0x15_6ac2:
            ii(0x15_6ac2, 3); jmpw(0x15_6a83, -0x42); goto l_0x15_6a83; /* jmp 0x6a83 */
        l_0x15_6ac5:
            ii(0x15_6ac5, 3); cmp(si, 0x1);                             /* cmp si, 0x1 */
            ii(0x15_6ac8, 2); if(jzw(0x15_6acd, 0x3)) goto l_0x15_6acd; /* jz 0x6acd */
            ii(0x15_6aca, 3); jmpw(0x15_6af8, 0x2b); goto l_0x15_6af8;  /* jmp 0x6af8 */
        l_0x15_6acd:
            ii(0x15_6acd, 3); mov(ax, memw_a16[ds, 0x127c]);            /* mov ax, [0x127c] */
            ii(0x15_6ad0, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_6ad3, 4); cmp(memw_a16[ss, bp - 0x7e], 0);          /* cmp word [bp-0x7e], 0x0 */
            ii(0x15_6ad7, 2); if(jnzw(0x15_6adc, 0x3)) goto l_0x15_6adc; /* jnz 0x6adc */
            ii(0x15_6ad9, 3); jmpw(0x15_6aea, 0xe); goto l_0x15_6aea;   /* jmp 0x6aea */
        l_0x15_6adc:
            ii(0x15_6adc, 3); mov(ax, memw_a16[ds, 0x127a]);            /* mov ax, [0x127a] */
            ii(0x15_6adf, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6ae2, 5); mov(memw_a16[ss, bp - 0x72], 0);          /* mov word [bp-0x72], 0x0 */
            ii(0x15_6ae7, 3); jmpw(0x15_6af5, 0xb); goto l_0x15_6af5;   /* jmp 0x6af5 */
        l_0x15_6aea:
            ii(0x15_6aea, 3); mov(ax, memw_a16[ds, 0x1276]);            /* mov ax, [0x1276] */
            ii(0x15_6aed, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6af0, 5); mov(memw_a16[ss, bp - 0x72], 0);          /* mov word [bp-0x72], 0x0 */
        l_0x15_6af5:
            ii(0x15_6af5, 3); jmpw(0x15_6b29, 0x31); goto l_0x15_6b29;  /* jmp 0x6b29 */
        l_0x15_6af8:
            ii(0x15_6af8, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x15_6afa, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_6afd, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_6b01, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x15_6b06, 4); mov(ax, memw_a16[es, bx + di + 0x6]);     /* mov ax, [es:bx+di+0x6] */
            ii(0x15_6b0a, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_6b0d, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x15_6b0f, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x15_6b12, 4); mov(es, memw_a16[ds, 0x3f98]);            /* mov es, [0x3f98] */
            ii(0x15_6b16, 5); les(di, es, 0x122);                       /* les di, [es:0x122] */
            ii(0x15_6b1b, 4); mov(ax, memw_a16[es, bx + di + 0x2]);     /* mov ax, [es:bx+di+0x2] */
            ii(0x15_6b1f, 4); mov(dx, memw_a16[es, bx + di + 0x4]);     /* mov dx, [es:bx+di+0x4] */
            ii(0x15_6b23, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6b26, 3); mov(memw_a16[ss, bp - 0x72], dx);         /* mov [bp-0x72], dx */
        l_0x15_6b29:
            ii(0x15_6b29, 4); cmp(memw_a16[ss, bp - 0x7e], 0);          /* cmp word [bp-0x7e], 0x0 */
            ii(0x15_6b2d, 2); if(jnzw(0x15_6b32, 0x3)) goto l_0x15_6b32; /* jnz 0x6b32 */
            ii(0x15_6b2f, 3); jmpw(0x15_6b46, 0x14); goto l_0x15_6b46;  /* jmp 0x6b46 */
        l_0x15_6b32:
            ii(0x15_6b32, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_6b37, 3); mov(ax, memw_a16[ss, bp - 0x74]);         /* mov ax, [bp-0x74] */
            ii(0x15_6b3a, 3); mov(dx, memw_a16[ss, bp - 0x72]);         /* mov dx, [bp-0x72] */
            ii(0x15_6b3d, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_6b40, 3); mov(memw_a16[ss, bp - 0x3e], dx);         /* mov [bp-0x3e], dx */
            ii(0x15_6b43, 3); jmpw(0x15_6b6c, 0x26); goto l_0x15_6b6c;  /* jmp 0x6b6c */
        l_0x15_6b46:
            ii(0x15_6b46, 3); mov(ax, memw_a16[ss, bp - 0x60]);         /* mov ax, [bp-0x60] */
            ii(0x15_6b49, 3); mov(dx, memw_a16[ss, bp - 0x5e]);         /* mov dx, [bp-0x5e] */
            ii(0x15_6b4c, 2); not(ax);                                  /* not ax */
            ii(0x15_6b4e, 2); not(dx);                                  /* not dx */
            ii(0x15_6b50, 3); and(ax, memw_a16[ss, bp - 0x40]);         /* and ax, [bp-0x40] */
            ii(0x15_6b53, 3); and(dx, memw_a16[ss, bp - 0x3e]);         /* and dx, [bp-0x3e] */
            ii(0x15_6b56, 3); mov(cx, memw_a16[ss, bp - 0x74]);         /* mov cx, [bp-0x74] */
            ii(0x15_6b59, 3); mov(bx, memw_a16[ss, bp - 0x72]);         /* mov bx, [bp-0x72] */
            ii(0x15_6b5c, 3); and(cx, memw_a16[ss, bp - 0x60]);         /* and cx, [bp-0x60] */
            ii(0x15_6b5f, 3); and(bx, memw_a16[ss, bp - 0x5e]);         /* and bx, [bp-0x5e] */
            ii(0x15_6b62, 2); or(ax, cx);                               /* or ax, cx */
            ii(0x15_6b64, 2); or(dx, bx);                               /* or dx, bx */
            ii(0x15_6b66, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_6b69, 3); mov(memw_a16[ss, bp - 0x3e], dx);         /* mov [bp-0x3e], dx */
        l_0x15_6b6c:
            ii(0x15_6b6c, 3); jmpw(0x15_7817, 0xca8); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6b6f:
            ii(0x15_6b6f, 4); cmp(memw_a16[ss, bp - 0x3c], -0x1 /* 0xff */); /* cmp word [bp-0x3c], 0xffff */
            ii(0x15_6b73, 2); if(jzw(0x15_6b78, 0x3)) goto l_0x15_6b78; /* jz 0x6b78 */
            ii(0x15_6b75, 3); jmpw(0x15_6b8c, 0x14); goto l_0x15_6b8c;  /* jmp 0x6b8c */
        l_0x15_6b78:
            ii(0x15_6b78, 4); cmp(memw_a16[ss, bp - 0x3a], -0x1 /* 0xff */); /* cmp word [bp-0x3a], 0xffff */
            ii(0x15_6b7c, 2); if(jzw(0x15_6b81, 0x3)) goto l_0x15_6b81; /* jz 0x6b81 */
            ii(0x15_6b7e, 3); jmpw(0x15_6b8c, 0xb); goto l_0x15_6b8c;   /* jmp 0x6b8c */
        l_0x15_6b81:
            ii(0x15_6b81, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_6b86, 3); jmpw(0x15_633b, -0x84e); goto l_0x15_633b; /* jmp 0x633b */
        //    ii(0x15_6b89, 3); jmpw(0x15_6b8f, 0x3); goto l_0x15_6b8f;   /* jmp 0x6b8f */
        l_0x15_6b8c:
            ii(0x15_6b8c, 3); jmpw(0x15_6442, -0x74d); goto l_0x15_6442; /* jmp 0x6442 */
        l_0x15_6b8f:
            ii(0x15_6b8f, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_6b92, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_6b95, 3); and(ax, memw_a16[ss, bp - 0x38]);         /* and ax, [bp-0x38] */
            ii(0x15_6b98, 3); and(dx, memw_a16[ss, bp - 0x36]);         /* and dx, [bp-0x36] */
            ii(0x15_6b9b, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_6b9d, 2); if(jzw(0x15_6ba2, 0x3)) goto l_0x15_6ba2; /* jz 0x6ba2 */
            ii(0x15_6b9f, 3); jmpw(0x15_6bbb, 0x19); goto l_0x15_6bbb;  /* jmp 0x6bbb */
        l_0x15_6ba2:
            ii(0x15_6ba2, 3); mov(ax, memw_a16[ss, bp - 0x38]);         /* mov ax, [bp-0x38] */
            ii(0x15_6ba5, 3); mov(dx, memw_a16[ss, bp - 0x36]);         /* mov dx, [bp-0x36] */
            ii(0x15_6ba8, 3); add(ax, memw_a16[ss, bp - 0x3c]);         /* add ax, [bp-0x3c] */
            ii(0x15_6bab, 3); adc(dx, memw_a16[ss, bp - 0x3a]);         /* adc dx, [bp-0x3a] */
            ii(0x15_6bae, 3); and(ax, memw_a16[ss, bp - 0x16]);         /* and ax, [bp-0x16] */
            ii(0x15_6bb1, 3); and(dx, memw_a16[ss, bp - 0x14]);         /* and dx, [bp-0x14] */
            ii(0x15_6bb4, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_6bb6, 2); if(jnzw(0x15_6bbb, 0x3)) goto l_0x15_6bbb; /* jnz 0x6bbb */
            ii(0x15_6bb8, 3); jmpw(0x15_6d0b, 0x150); goto l_0x15_6d0b; /* jmp 0x6d0b */
        l_0x15_6bbb:
            ii(0x15_6bbb, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_6bbe, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_6bc1, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_6bc4, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_6bc7, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_6bcb, 4); mov(memw_a16[ss, bp - 0x84], dx);         /* mov [bp-0x84], dx */
            ii(0x15_6bcf, 3); mov(ax, memw_a16[ss, bp - 0x38]);         /* mov ax, [bp-0x38] */
            ii(0x15_6bd2, 3); mov(dx, memw_a16[ss, bp - 0x36]);         /* mov dx, [bp-0x36] */
            ii(0x15_6bd5, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_6bd8, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
            ii(0x15_6bdb, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_6bde, 3); mov(dx, memw_a16[ss, bp - 0x64]);         /* mov dx, [bp-0x64] */
            ii(0x15_6be1, 3); mov(memw_a16[ss, bp - 0x7a], ax);         /* mov [bp-0x7a], ax */
            ii(0x15_6be4, 3); mov(memw_a16[ss, bp - 0x78], dx);         /* mov [bp-0x78], dx */
            ii(0x15_6be7, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_6beb, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_6bef, 3); mov(memw_a16[ss, bp - 0x6e], ax);         /* mov [bp-0x6e], ax */
            ii(0x15_6bf2, 3); mov(memw_a16[ss, bp - 0x6c], dx);         /* mov [bp-0x6c], dx */
            ii(0x15_6bf5, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_6bf7, 3); mov(memw_a16[ss, bp - 0x80], ax);         /* mov [bp-0x80], ax */
            ii(0x15_6bfa, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
        l_0x15_6bfe:
            ii(0x15_6bfe, 3); mov(ax, memw_a16[ss, bp - 0x7a]);         /* mov ax, [bp-0x7a] */
            ii(0x15_6c01, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
            ii(0x15_6c04, 3); mov(ah, memb_a16[ss, bp - 0x4]);          /* mov ah, [bp-0x4] */
            ii(0x15_6c07, 2); sub(al, al);                              /* sub al, al */
            ii(0x15_6c09, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x15_6c0c, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_6c11, 3); pushw(memw_a16[ss, bp - 0x6c]);           /* push word [bp-0x6c] */
            ii(0x15_6c14, 3); pushw(memw_a16[ss, bp - 0x6e]);           /* push word [bp-0x6e] */
            ii(0x15_6c17, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x15_6c1a, 1); nop();                                    /* nop */
            ii(0x15_6c1b, 1); pushw(cs);                                /* push cs */
            ii(0x15_6c1c, 3); callw(0x15_789c, 0xc7d);                  /* call 0x789c */
            ii(0x15_6c1f, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6c22, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_6c25, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_6c28, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_6c2a, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_6c2d, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_6c30, 3); mov(ax, memw_a16[ds, 0x4898]);            /* mov ax, [0x4898] */
            ii(0x15_6c33, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6c35, 3); cmp(dx, memw_a16[ss, bp - 0x78]);         /* cmp dx, [bp-0x78] */
            ii(0x15_6c38, 2); if(jbew(0x15_6c3d, 0x3)) goto l_0x15_6c3d; /* jbe 0x6c3d */
            ii(0x15_6c3a, 3); jmpw(0x15_6c71, 0x34); goto l_0x15_6c71;  /* jmp 0x6c71 */
        l_0x15_6c3d:
            ii(0x15_6c3d, 2); if(jaew(0x15_6c42, 0x3)) goto l_0x15_6c42; /* jae 0x6c42 */
            ii(0x15_6c3f, 3); jmpw(0x15_6c4a, 0x8); goto l_0x15_6c4a;   /* jmp 0x6c4a */
        l_0x15_6c42:
            ii(0x15_6c42, 3); cmp(ax, memw_a16[ss, bp - 0x7a]);         /* cmp ax, [bp-0x7a] */
            ii(0x15_6c45, 2); if(jbw(0x15_6c4a, 0x3)) goto l_0x15_6c4a; /* jb 0x6c4a */
            ii(0x15_6c47, 3); jmpw(0x15_6c71, 0x27); goto l_0x15_6c71;  /* jmp 0x6c71 */
        l_0x15_6c4a:
            ii(0x15_6c4a, 4); cmp(memw_a16[ss, bp - 0x70], 0);          /* cmp word [bp-0x70], 0x0 */
            ii(0x15_6c4e, 2); if(jzw(0x15_6c53, 0x3)) goto l_0x15_6c53; /* jz 0x6c53 */
            ii(0x15_6c50, 3); jmpw(0x15_6c58, 0x5); goto l_0x15_6c58;   /* jmp 0x6c58 */
        l_0x15_6c53:
            ii(0x15_6c53, 5); sub(memw_a16[ss, bp - 0x70], 0x200);      /* sub word [bp-0x70], 0x200 */
        l_0x15_6c58:
            ii(0x15_6c58, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x15_6c5b, 3); mov(bx, memw_a16[ss, bp - 0x74]);         /* mov bx, [bp-0x74] */
            ii(0x15_6c5e, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_6c60, 3); add(dx, memw_a16[ss, bp - 0x7a]);         /* add dx, [bp-0x7a] */
            ii(0x15_6c63, 3); adc(cx, memw_a16[ss, bp - 0x78]);         /* adc cx, [bp-0x78] */
            ii(0x15_6c66, 3); cmp(cx, 0x10);                            /* cmp cx, 0x10 */
            ii(0x15_6c69, 2); if(jbw(0x15_6c71, 0x6)) goto l_0x15_6c71; /* jb 0x6c71 */
            ii(0x15_6c6b, 3); mov(ax, memw_a16[ds, 0x4898]);            /* mov ax, [0x4898] */
            ii(0x15_6c6e, 3); mov(memw_a16[ss, bp - 0x70], ax);         /* mov [bp-0x70], ax */
        l_0x15_6c71:
            ii(0x15_6c71, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x15_6c74, 3); mov(memw_a16[ss, bp - 0x38], ax);         /* mov [bp-0x38], ax */
            ii(0x15_6c77, 5); mov(memw_a16[ss, bp - 0x36], 0);          /* mov word [bp-0x36], 0x0 */
            ii(0x15_6c7c, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_6c7f, 1); pushw(ss);                                /* push ss */
            ii(0x15_6c80, 1); pushw(ax);                                /* push ax */
            ii(0x15_6c81, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_6c84, 3); callw(0x15_61c1, -0xac6);                 /* call 0x61c1 */
            ii(0x15_6c87, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_6c8a, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x15_6c8e, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x15_6c92, 2); if(jnzw(0x15_6c97, 0x3)) goto l_0x15_6c97; /* jnz 0x6c97 */
            ii(0x15_6c94, 3); jmpw(0x15_6c9a, 0x3); goto l_0x15_6c9a;   /* jmp 0x6c9a */
        l_0x15_6c97:
            ii(0x15_6c97, 3); jmpw(0x15_6cc7, 0x2d); goto l_0x15_6cc7;  /* jmp 0x6cc7 */
        l_0x15_6c9a:
            ii(0x15_6c9a, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x15_6c9d, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6c9f, 3); add(memw_a16[ss, bp - 0x6e], ax);         /* add [bp-0x6e], ax */
            ii(0x15_6ca2, 3); adc(memw_a16[ss, bp - 0x6c], dx);         /* adc [bp-0x6c], dx */
            ii(0x15_6ca5, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x15_6ca8, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6caa, 3); sub(memw_a16[ss, bp - 0x7a], ax);         /* sub [bp-0x7a], ax */
            ii(0x15_6cad, 3); sbb(memw_a16[ss, bp - 0x78], dx);         /* sbb [bp-0x78], dx */
            ii(0x15_6cb0, 3); mov(ax, memw_a16[ss, bp - 0x34]);         /* mov ax, [bp-0x34] */
            ii(0x15_6cb3, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6cb5, 4); add(memw_a16[ss, bp - 0x82], ax);         /* add [bp-0x82], ax */
            ii(0x15_6cb9, 3); adc(memw_a16[ss, bp - 0x80], dx);         /* adc [bp-0x80], dx */
            ii(0x15_6cbc, 3); mov(ax, memw_a16[ss, bp - 0x78]);         /* mov ax, [bp-0x78] */
            ii(0x15_6cbf, 3); or(ax, memw_a16[ss, bp - 0x7a]);          /* or ax, [bp-0x7a] */
            ii(0x15_6cc2, 2); if(jzw(0x15_6cc7, 0x3)) goto l_0x15_6cc7; /* jz 0x6cc7 */
            ii(0x15_6cc4, 3); jmpw(0x15_6bfe, -0xc9); goto l_0x15_6bfe; /* jmp 0x6bfe */
        l_0x15_6cc7:
            ii(0x15_6cc7, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_6cca, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_6ccd, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_6cd1, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_6cd5, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_6cd8, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x15_6cdb, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_6cde, 3); mov(dx, memw_a16[ss, bp - 0x64]);         /* mov dx, [bp-0x64] */
            ii(0x15_6ce1, 3); mov(memw_a16[ss, bp - 0x38], ax);         /* mov [bp-0x38], ax */
            ii(0x15_6ce4, 3); mov(memw_a16[ss, bp - 0x36], dx);         /* mov [bp-0x36], dx */
            ii(0x15_6ce7, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x15_6ceb, 2); if(jnzw(0x15_6cf0, 0x3)) goto l_0x15_6cf0; /* jnz 0x6cf0 */
            ii(0x15_6ced, 3); jmpw(0x15_6cf3, 0x3); goto l_0x15_6cf3;   /* jmp 0x6cf3 */
        l_0x15_6cf0:
            ii(0x15_6cf0, 3); jmpw(0x15_7817, 0xb24); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6cf3:
            ii(0x15_6cf3, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x15_6cf7, 3); mov(dx, memw_a16[ss, bp - 0x80]);         /* mov dx, [bp-0x80] */
            ii(0x15_6cfa, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x15_6cfd, 3); mov(memw_a16[ss, bp - 0x32], dx);         /* mov [bp-0x32], dx */
            ii(0x15_6d00, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x15_6d05, 3); jmpw(0x15_7817, 0xb0f); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_6d08, 3); jmpw(0x15_6d0e, 0x3); goto l_0x15_6d0e;   /* jmp 0x6d0e */
        l_0x15_6d0b:
            ii(0x15_6d0b, 3); jmpw(0x15_633b, -0x9d3); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6d0e:
            ii(0x15_6d0e, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_6d11, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6d13, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_6d17, 5); cmp(memw_a16[ss, bp - 0x86], 0x10);       /* cmp word [bp-0x86], 0x10 */
            ii(0x15_6d1c, 2); if(jbw(0x15_6d21, 0x3)) goto l_0x15_6d21; /* jb 0x6d21 */
            ii(0x15_6d1e, 3); jmpw(0x15_6d2e, 0xd); goto l_0x15_6d2e;   /* jmp 0x6d2e */
        l_0x15_6d21:
            ii(0x15_6d21, 4); mov(bx, memw_a16[ss, bp - 0x86]);         /* mov bx, [bp-0x86] */
            ii(0x15_6d25, 4); mov(al, memb_a16[ds, bx + 0x1566]);       /* mov al, [bx+0x1566] */
            ii(0x15_6d29, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_6d2b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x15_6d2e:
            ii(0x15_6d2e, 5); cmp(memw_a16[ss, bp - 0x86], 0x10);       /* cmp word [bp-0x86], 0x10 */
            ii(0x15_6d33, 2); if(jbw(0x15_6d38, 0x3)) goto l_0x15_6d38; /* jb 0x6d38 */
            ii(0x15_6d35, 3); jmpw(0x15_6d4c, 0x14); goto l_0x15_6d4c;  /* jmp 0x6d4c */
        l_0x15_6d38:
            ii(0x15_6d38, 4); mov(bx, memw_a16[ss, bp - 0x86]);         /* mov bx, [bp-0x86] */
            ii(0x15_6d3c, 5); cmp(memb_a16[ds, bx + 0x1556], 0);        /* cmp byte [bx+0x1556], 0x0 */
            ii(0x15_6d41, 2); if(jnzw(0x15_6d46, 0x3)) goto l_0x15_6d46; /* jnz 0x6d46 */
            ii(0x15_6d43, 3); jmpw(0x15_6d4c, 0x6); goto l_0x15_6d4c;   /* jmp 0x6d4c */
        l_0x15_6d46:
            ii(0x15_6d46, 3); jmpw(0x15_6442, -0x907); goto l_0x15_6442; /* jmp 0x6442 */
        //    ii(0x15_6d49, 3); jmpw(0x15_6d4f, 0x3); goto l_0x15_6d4f;   /* jmp 0x6d4f */
        l_0x15_6d4c:
            ii(0x15_6d4c, 3); jmpw(0x15_633b, -0xa14); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6d4f:
            ii(0x15_6d4f, 5); mov(memw_a16[ss, bp - 0x7e], 0);          /* mov word [bp-0x7e], 0x0 */
            ii(0x15_6d54, 3); mov(ax, memw_a16[ss, bp - 0x40]);         /* mov ax, [bp-0x40] */
            ii(0x15_6d57, 3); mov(dx, memw_a16[ss, bp - 0x3e]);         /* mov dx, [bp-0x3e] */
            ii(0x15_6d5a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6d5c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6d5e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6d60, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6d62, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6d64, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6d66, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6d68, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6d6a, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_6d6e, 4); mov(memw_a16[ss, bp - 0x84], dx);         /* mov [bp-0x84], dx */
            ii(0x15_6d72, 4); mov(ax, memw_a16[ss, bp - 0x84]);         /* mov ax, [bp-0x84] */
            ii(0x15_6d76, 4); or(ax, memw_a16[ss, bp - 0x86]);          /* or ax, [bp-0x86] */
            ii(0x15_6d7a, 2); if(jzw(0x15_6d7f, 0x3)) goto l_0x15_6d7f; /* jz 0x6d7f */
            ii(0x15_6d7c, 3); jmpw(0x15_6d82, 0x3); goto l_0x15_6d82;   /* jmp 0x6d82 */
        l_0x15_6d7f:
            ii(0x15_6d7f, 3); jmpw(0x15_6e04, 0x82); goto l_0x15_6e04;  /* jmp 0x6e04 */
        l_0x15_6d82:
            ii(0x15_6d82, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_6d85, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_6d8a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6d8d, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6d90, 2); if(jzw(0x15_6d95, 0x3)) goto l_0x15_6d95; /* jz 0x6d95 */
            ii(0x15_6d92, 3); jmpw(0x15_6de5, 0x50); goto l_0x15_6de5;  /* jmp 0x6de5 */
        l_0x15_6d95:
            ii(0x15_6d95, 5); cmp(memb_a16[ds, 0x1271], 0);             /* cmp byte [0x1271], 0x0 */
            ii(0x15_6d9a, 2); if(jzw(0x15_6d9f, 0x3)) goto l_0x15_6d9f; /* jz 0x6d9f */
            ii(0x15_6d9c, 3); jmpw(0x15_6da2, 0x3); goto l_0x15_6da2;   /* jmp 0x6da2 */
        l_0x15_6d9f:
            ii(0x15_6d9f, 3); jmpw(0x15_633b, -0xa67); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6da2:
            ii(0x15_6da2, 3); mov(ax, memw_a16[ss, bp - 0x40]);         /* mov ax, [bp-0x40] */
            ii(0x15_6da5, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_6da7, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6da9, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6dab, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6dad, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6daf, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6db1, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6db3, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6db5, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6db7, 1); pushw(dx);                                /* push dx */
            ii(0x15_6db8, 1); pushw(ax);                                /* push ax */
            ii(0x15_6db9, 1); nop();                                    /* nop */
            ii(0x15_6dba, 1); pushw(cs);                                /* push cs */
            ii(0x15_6dbb, 3); callw(0x15_79c1, 0xc03);                  /* call 0x79c1 */
            ii(0x15_6dbe, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6dc1, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_6dc4, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6dc7, 2); if(jzw(0x15_6dcc, 0x3)) goto l_0x15_6dcc; /* jz 0x6dcc */
            ii(0x15_6dc9, 3); jmpw(0x15_6dcf, 0x3); goto l_0x15_6dcf;   /* jmp 0x6dcf */
        l_0x15_6dcc:
            ii(0x15_6dcc, 3); jmpw(0x15_6e04, 0x35); goto l_0x15_6e04;  /* jmp 0x6e04 */
        l_0x15_6dcf:
            ii(0x15_6dcf, 4); and(memw_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and word [bp-0x22], 0xfffe */
            ii(0x15_6dd3, 4); and(memw_a16[ss, bp - 0x20], -0x1 /* 0xff */); /* and word [bp-0x20], 0xffff */
            ii(0x15_6dd7, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_6dda, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x15_6ddd, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_6de2, 3); jmpw(0x15_7817, 0xa32); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6de5:
            ii(0x15_6de5, 5); cmp(memw_a16[ss, bp - 0x84], 0x1);        /* cmp word [bp-0x84], 0x1 */
            ii(0x15_6dea, 2); if(jbew(0x15_6def, 0x3)) goto l_0x15_6def; /* jbe 0x6def */
            ii(0x15_6dec, 3); jmpw(0x15_6e01, 0x12); goto l_0x15_6e01;  /* jmp 0x6e01 */
        l_0x15_6def:
            ii(0x15_6def, 2); if(jaew(0x15_6df4, 0x3)) goto l_0x15_6df4; /* jae 0x6df4 */
            ii(0x15_6df1, 3); jmpw(0x15_6dfe, 0xa); goto l_0x15_6dfe;   /* jmp 0x6dfe */
        l_0x15_6df4:
            ii(0x15_6df4, 5); cmp(memw_a16[ss, bp - 0x86], 0);          /* cmp word [bp-0x86], 0x0 */
            ii(0x15_6df9, 2); if(jbw(0x15_6dfe, 0x3)) goto l_0x15_6dfe; /* jb 0x6dfe */
            ii(0x15_6dfb, 3); jmpw(0x15_6e01, 0x3); goto l_0x15_6e01;   /* jmp 0x6e01 */
        l_0x15_6dfe:
            ii(0x15_6dfe, 3); jmpw(0x15_633b, -0xac6); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6e01:
            ii(0x15_6e01, 3); jmpw(0x15_6e04, 0); goto l_0x15_6e04;     /* jmp 0x6e04 */
        l_0x15_6e04:
            ii(0x15_6e04, 5); mov(memw_a16[ss, bp - 0x34], 0x8);        /* mov word [bp-0x34], 0x8 */
            ii(0x15_6e09, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_6e0e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_6e10, 3); mov(memw_a16[ss, bp - 0x3e], ax);         /* mov [bp-0x3e], ax */
            ii(0x15_6e13, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_6e16, 4); or(memw_a16[ss, bp - 0x22], 0x1);         /* or word [bp-0x22], 0x1 */
            ii(0x15_6e1a, 4); or(memw_a16[ss, bp - 0x20], 0);           /* or word [bp-0x20], 0x0 */
            ii(0x15_6e1e, 3); jmpw(0x15_7817, 0x9f6); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6e21:
            ii(0x15_6e21, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_6e24, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_6e29, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6e2c, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6e2f, 2); if(jnzw(0x15_6e34, 0x3)) goto l_0x15_6e34; /* jnz 0x6e34 */
            ii(0x15_6e31, 3); jmpw(0x15_6e7b, 0x47); goto l_0x15_6e7b;  /* jmp 0x6e7b */
        l_0x15_6e34:
            ii(0x15_6e34, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6e37, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x15_6e3b, 5); mov(memd_a16[ss, bp - 0x86], eax);        /* mov [bp-0x86], eax */
            ii(0x15_6e40, 5); add(memw_a16[ss, bp - 0x86], 0x1);        /* add word [bp-0x86], 0x1 */
            ii(0x15_6e45, 5); adc(memw_a16[ss, bp - 0x84], 0);          /* adc word [bp-0x84], 0x0 */
            ii(0x15_6e4a, 5); cmp(memw_a16[ss, bp - 0x84], 0x1);        /* cmp word [bp-0x84], 0x1 */
            ii(0x15_6e4f, 2); if(jbew(0x15_6e54, 0x3)) goto l_0x15_6e54; /* jbe 0x6e54 */
            ii(0x15_6e51, 3); jmpw(0x15_6e66, 0x12); goto l_0x15_6e66;  /* jmp 0x6e66 */
        l_0x15_6e54:
            ii(0x15_6e54, 2); if(jaew(0x15_6e59, 0x3)) goto l_0x15_6e59; /* jae 0x6e59 */
            ii(0x15_6e56, 3); jmpw(0x15_6e63, 0xa); goto l_0x15_6e63;   /* jmp 0x6e63 */
        l_0x15_6e59:
            ii(0x15_6e59, 5); cmp(memw_a16[ss, bp - 0x86], 0);          /* cmp word [bp-0x86], 0x0 */
            ii(0x15_6e5e, 2); if(jbw(0x15_6e63, 0x3)) goto l_0x15_6e63; /* jb 0x6e63 */
            ii(0x15_6e60, 3); jmpw(0x15_6e66, 0x3); goto l_0x15_6e66;   /* jmp 0x6e66 */
        l_0x15_6e63:
            ii(0x15_6e63, 3); jmpw(0x15_633b, -0xb2b); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6e66:
            ii(0x15_6e66, 5); mov(memw_a16[ss, bp - 0x34], 0x9);        /* mov word [bp-0x34], 0x9 */
            ii(0x15_6e6b, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_6e70, 4); or(memw_a16[ss, bp - 0x22], 0x1);         /* or word [bp-0x22], 0x1 */
            ii(0x15_6e74, 4); or(memw_a16[ss, bp - 0x20], 0);           /* or word [bp-0x20], 0x0 */
            ii(0x15_6e78, 3); jmpw(0x15_7817, 0x99c); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6e7b:
            ii(0x15_6e7b, 3); mov(ax, memw_a16[ds, 0x1290]);            /* mov ax, [0x1290] */
            ii(0x15_6e7e, 4); or(ax, memw_a16[ds, 0x128e]);             /* or ax, [0x128e] */
            ii(0x15_6e82, 2); if(jzw(0x15_6e87, 0x3)) goto l_0x15_6e87; /* jz 0x6e87 */
            ii(0x15_6e84, 3); jmpw(0x15_6e8a, 0x3); goto l_0x15_6e8a;   /* jmp 0x6e8a */
        l_0x15_6e87:
            ii(0x15_6e87, 3); jmpw(0x15_633b, -0xb4f); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6e8a:
            ii(0x15_6e8a, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6e8d, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x15_6e90, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_6e92, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x15_6e95, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_6e97, 4); test(memb_a16[es, bx], 0x1);              /* test byte [es:bx], 0x1 */
            ii(0x15_6e9b, 2); if(jzw(0x15_6ea0, 0x3)) goto l_0x15_6ea0; /* jz 0x6ea0 */
            ii(0x15_6e9d, 3); jmpw(0x15_6ea3, 0x3); goto l_0x15_6ea3;   /* jmp 0x6ea3 */
        l_0x15_6ea0:
            ii(0x15_6ea0, 3); jmpw(0x15_633b, -0xb68); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6ea3:
            ii(0x15_6ea3, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6ea6, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x15_6ea8, 1); pushw(ax);                                /* push ax */
            ii(0x15_6ea9, 1); pushw(cx);                                /* push cx */
            ii(0x15_6eaa, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_6eaf, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6eb2, 1); pushw(dx);                                /* push dx */
            ii(0x15_6eb3, 1); pushw(ax);                                /* push ax */
            ii(0x15_6eb4, 4); callw_a16_far_ind(ds, 0x128e);            /* call far word [0x128e] */
            ii(0x15_6eb8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6ebb, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_6ebf, 5); cmp(memw_a16[ss, bp - 0x82], 0);          /* cmp word [bp-0x82], 0x0 */
            ii(0x15_6ec4, 2); if(jgw(0x15_6ec9, 0x3)) goto l_0x15_6ec9; /* jg 0x6ec9 */
            ii(0x15_6ec6, 3); jmpw(0x15_6ecc, 0x3); goto l_0x15_6ecc;   /* jmp 0x6ecc */
        l_0x15_6ec9:
            ii(0x15_6ec9, 3); jmpw(0x15_633b, -0xb91); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6ecc:
            ii(0x15_6ecc, 5); cmp(memw_a16[ss, bp - 0x82], 0);          /* cmp word [bp-0x82], 0x0 */
            ii(0x15_6ed1, 2); if(jlw(0x15_6ed6, 0x3)) goto l_0x15_6ed6; /* jl 0x6ed6 */
            ii(0x15_6ed3, 3); jmpw(0x15_6eee, 0x18); goto l_0x15_6eee;  /* jmp 0x6eee */
        l_0x15_6ed6:
            ii(0x15_6ed6, 4); or(memw_a16[ss, bp - 0x22], 0x1);         /* or word [bp-0x22], 0x1 */
            ii(0x15_6eda, 4); or(memw_a16[ss, bp - 0x20], 0);           /* or word [bp-0x20], 0x0 */
            ii(0x15_6ede, 5); mov(memw_a16[ss, bp - 0x34], 0x9);        /* mov word [bp-0x34], 0x9 */
            ii(0x15_6ee3, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_6ee8, 3); jmpw(0x15_6f4c, 0x61); goto l_0x15_6f4c;  /* jmp 0x6f4c */
        //    ii(0x15_6eeb, 3); jmpw(0x15_6f18, 0x2a); goto l_0x15_6f18;  /* jmp 0x6f18 */
        l_0x15_6eee:
            ii(0x15_6eee, 4); and(memw_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and word [bp-0x22], 0xfffe */
            ii(0x15_6ef2, 4); and(memw_a16[ss, bp - 0x20], -0x1 /* 0xff */); /* and word [bp-0x20], 0xffff */
            ii(0x15_6ef6, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6ef9, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_6efd, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x15_6f01, 3); sar(ax, 0x3);                             /* sar ax, 0x3 */
            ii(0x15_6f04, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_6f06, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x15_6f09, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_6f0b, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x15_6f0f, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_6f12, 4); mov(bx, memw_a16[ss, bp - 0x82]);         /* mov bx, [bp-0x82] */
            ii(0x15_6f16, 2); @int(0x31);                               /* int 0x31 */
        l_0x15_6f18:
            ii(0x15_6f18, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6f1b, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x15_6f1e, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_6f20, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x15_6f23, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_6f25, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_6f28, 1); cbw();                                    /* cbw */
            ii(0x15_6f29, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_6f2d, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6f30, 3); shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x15_6f33, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_6f35, 3); mov(cx, 0x50);                            /* mov cx, 0x50 */
            ii(0x15_6f38, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x15_6f3a, 4); mov(memb_a16[es, bx], 0);                 /* mov byte [es:bx], 0x0 */
            ii(0x15_6f3e, 4); add(memw_a16[ss, bp - 0x56], 0x8);        /* add word [bp-0x56], 0x8 */
            ii(0x15_6f42, 5); test(memb_a16[ss, bp - 0x82], 0x2);       /* test byte [bp-0x82], 0x2 */
            ii(0x15_6f47, 2); if(jzw(0x15_6f4c, 0x3)) goto l_0x15_6f4c; /* jz 0x6f4c */
            ii(0x15_6f49, 3); jmpw(0x15_6e8a, -0xc2); goto l_0x15_6e8a; /* jmp 0x6e8a */
        l_0x15_6f4c:
            ii(0x15_6f4c, 5); mov(memw_a16[ss, bp - 0x56], 0);          /* mov word [bp-0x56], 0x0 */
            ii(0x15_6f51, 3); jmpw(0x15_7817, 0x8c3); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6f54:
            ii(0x15_6f54, 3); mov(ax, memw_a16[ss, bp - 0x40]);         /* mov ax, [bp-0x40] */
            ii(0x15_6f57, 3); mov(dx, memw_a16[ss, bp - 0x3e]);         /* mov dx, [bp-0x3e] */
            ii(0x15_6f5a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6f5c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6f5e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6f60, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6f62, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6f64, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6f66, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_6f68, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_6f6a, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_6f6e, 4); mov(memw_a16[ss, bp - 0x84], dx);         /* mov [bp-0x84], dx */
            ii(0x15_6f72, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6f75, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x15_6f79, 4); mov(memd_a16[ss, bp - 0x7e], eax);        /* mov [bp-0x7e], eax */
            ii(0x15_6f7d, 4); add(memw_a16[ss, bp - 0x7e], 0x1);        /* add word [bp-0x7e], 0x1 */
            ii(0x15_6f81, 4); adc(memw_a16[ss, bp - 0x7c], 0);          /* adc word [bp-0x7c], 0x0 */
            ii(0x15_6f85, 4); mov(ax, memw_a16[ss, bp - 0x84]);         /* mov ax, [bp-0x84] */
            ii(0x15_6f89, 4); or(ax, memw_a16[ss, bp - 0x86]);          /* or ax, [bp-0x86] */
            ii(0x15_6f8d, 2); if(jzw(0x15_6f92, 0x3)) goto l_0x15_6f92; /* jz 0x6f92 */
            ii(0x15_6f8f, 3); jmpw(0x15_6f95, 0x3); goto l_0x15_6f95;   /* jmp 0x6f95 */
        l_0x15_6f92:
            ii(0x15_6f92, 3); jmpw(0x15_71ee, 0x259); goto l_0x15_71ee; /* jmp 0x71ee */
        l_0x15_6f95:
            ii(0x15_6f95, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_6f98, 3); mov(dx, memw_a16[ss, bp - 0x7c]);         /* mov dx, [bp-0x7c] */
            ii(0x15_6f9b, 4); cmp(memw_a16[ss, bp - 0x86], ax);         /* cmp [bp-0x86], ax */
            ii(0x15_6f9f, 2); if(jzw(0x15_6fa4, 0x3)) goto l_0x15_6fa4; /* jz 0x6fa4 */
            ii(0x15_6fa1, 3); jmpw(0x15_6fb8, 0x14); goto l_0x15_6fb8;  /* jmp 0x6fb8 */
        l_0x15_6fa4:
            ii(0x15_6fa4, 4); cmp(memw_a16[ss, bp - 0x84], dx);         /* cmp [bp-0x84], dx */
            ii(0x15_6fa8, 2); if(jzw(0x15_6fad, 0x3)) goto l_0x15_6fad; /* jz 0x6fad */
            ii(0x15_6faa, 3); jmpw(0x15_6fb8, 0xb); goto l_0x15_6fb8;   /* jmp 0x6fb8 */
        l_0x15_6fad:
            ii(0x15_6fad, 4); and(memw_a16[ss, bp - 0x22], -0x2 /* 0xfe */); /* and word [bp-0x22], 0xfffe */
            ii(0x15_6fb1, 4); and(memw_a16[ss, bp - 0x20], -0x1 /* 0xff */); /* and word [bp-0x20], 0xffff */
            ii(0x15_6fb5, 3); jmpw(0x15_7817, 0x85f); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_6fb8:
            ii(0x15_6fb8, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x15_6fbb, 5); callw_far_abs(0x80, 0xf64);               /* call word 0x80:0xf64 */
            ii(0x15_6fc0, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_6fc3, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_6fc6, 2); if(jzw(0x15_6fcb, 0x3)) goto l_0x15_6fcb; /* jz 0x6fcb */
            ii(0x15_6fc8, 3); jmpw(0x15_6fce, 0x3); goto l_0x15_6fce;   /* jmp 0x6fce */
        l_0x15_6fcb:
            ii(0x15_6fcb, 3); jmpw(0x15_633b, -0xc93); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_6fce:
            ii(0x15_6fce, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x15_6fd1, 3); mov(bx, memw_a16[ss, bp - 0x56]);         /* mov bx, [bp-0x56] */
            ii(0x15_6fd4, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_6fd6, 2); if(jbw(0x15_6f92, -0x46)) goto l_0x15_6f92; /* jb 0x6f92 */
            ii(0x15_6fd8, 3); mov(memw_a16[ss, bp - 0x7a], dx);         /* mov [bp-0x7a], dx */
            ii(0x15_6fdb, 3); mov(memw_a16[ss, bp - 0x78], cx);         /* mov [bp-0x78], cx */
            ii(0x15_6fde, 2); or(dx, cx);                               /* or dx, cx */
            ii(0x15_6fe0, 2); if(jzw(0x15_6f92, -0x50)) goto l_0x15_6f92; /* jz 0x6f92 */
            ii(0x15_6fe2, 3); mov(ax, memw_a16[ds, 0x1294]);            /* mov ax, [0x1294] */
            ii(0x15_6fe5, 4); or(ax, memw_a16[ds, 0x1292]);             /* or ax, [0x1292] */
            ii(0x15_6fe9, 2); if(jnzw(0x15_6fee, 0x3)) goto l_0x15_6fee; /* jnz 0x6fee */
            ii(0x15_6feb, 3); jmpw(0x15_71ee, 0x200); goto l_0x15_71ee; /* jmp 0x71ee */
        l_0x15_6fee:
            ii(0x15_6fee, 4); lea(ax, bp - 0xc4);                       /* lea ax, [bp-0xc4] */
            ii(0x15_6ff2, 1); pushw(ss);                                /* push ss */
            ii(0x15_6ff3, 1); pushw(ax);                                /* push ax */
            ii(0x15_6ff4, 4); callw_a16_far_ind(ds, 0x1292);            /* call far word [0x1292] */
            ii(0x15_6ff8, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_6ffb, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_6ffe, 4); cmp(memw_a16[ss, bp - 0x8e], ax);         /* cmp [bp-0x8e], ax */
            ii(0x15_7002, 2); if(jzw(0x15_7007, 0x3)) goto l_0x15_7007; /* jz 0x7007 */
            ii(0x15_7004, 3); jmpw(0x15_703b, 0x34); goto l_0x15_703b;  /* jmp 0x703b */
        l_0x15_7007:
            ii(0x15_7007, 4); mov(ax, memw_a16[ss, bp - 0xc0]);         /* mov ax, [bp-0xc0] */
            ii(0x15_700b, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x15_700f, 4); mov(memd_a16[ss, bp - 0x7e], eax);        /* mov [bp-0x7e], eax */
            ii(0x15_7013, 4); add(memw_a16[ss, bp - 0x7e], 0x1);        /* add word [bp-0x7e], 0x1 */
            ii(0x15_7017, 4); adc(memw_a16[ss, bp - 0x7c], 0);          /* adc word [bp-0x7c], 0x0 */
            ii(0x15_701b, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_701e, 3); mov(dx, memw_a16[ss, bp - 0x7c]);         /* mov dx, [bp-0x7c] */
            ii(0x15_7021, 4); cmp(memw_a16[ss, bp - 0x84], dx);         /* cmp [bp-0x84], dx */
            ii(0x15_7025, 2); if(jaew(0x15_702a, 0x3)) goto l_0x15_702a; /* jae 0x702a */
            ii(0x15_7027, 3); jmpw(0x15_703b, 0x11); goto l_0x15_703b;  /* jmp 0x703b */
        l_0x15_702a:
            ii(0x15_702a, 2); if(jbew(0x15_702f, 0x3)) goto l_0x15_702f; /* jbe 0x702f */
            ii(0x15_702c, 3); jmpw(0x15_7038, 0x9); goto l_0x15_7038;   /* jmp 0x7038 */
        l_0x15_702f:
            ii(0x15_702f, 4); cmp(memw_a16[ss, bp - 0x86], ax);         /* cmp [bp-0x86], ax */
            ii(0x15_7033, 2); if(jaw(0x15_7038, 0x3)) goto l_0x15_7038; /* ja 0x7038 */
            ii(0x15_7035, 3); jmpw(0x15_703b, 0x3); goto l_0x15_703b;   /* jmp 0x703b */
        l_0x15_7038:
            ii(0x15_7038, 3); jmpw(0x15_71ee, 0x1b3); goto l_0x15_71ee; /* jmp 0x71ee */
        l_0x15_703b:
            ii(0x15_703b, 4); mov(ax, memw_a16[ss, bp - 0x9c]);         /* mov ax, [bp-0x9c] */
            ii(0x15_703f, 4); mov(cx, memw_a16[ss, bp - 0xa8]);         /* mov cx, [bp-0xa8] */
            ii(0x15_7043, 4); mov(memw_a16[ss, bp - 0xc8], cx);         /* mov [bp-0xc8], cx */
            ii(0x15_7047, 4); mov(memw_a16[ss, bp - 0xc6], ax);         /* mov [bp-0xc6], ax */
            ii(0x15_704b, 5); mov(memw_a16[ss, bp - 0x74], 0);          /* mov word [bp-0x74], 0x0 */
            ii(0x15_7050, 3); jmpw(0x15_7056, 0x3); goto l_0x15_7056;   /* jmp 0x7056 */
        l_0x15_7053:
            ii(0x15_7053, 3); inc(memw_a16[ss, bp - 0x74]);             /* inc word [bp-0x74] */
        l_0x15_7056:
            ii(0x15_7056, 3); mov(ax, memw_a16[ss, bp - 0x74]);         /* mov ax, [bp-0x74] */
            ii(0x15_7059, 1); cwd();                                    /* cwd */
            ii(0x15_705a, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_705e, 4); cmp(memw_a16[es, bx + 0x2], dx);          /* cmp [es:bx+0x2], dx */
            ii(0x15_7062, 2); if(jaew(0x15_7067, 0x3)) goto l_0x15_7067; /* jae 0x7067 */
            ii(0x15_7064, 3); jmpw(0x15_71ee, 0x187); goto l_0x15_71ee; /* jmp 0x71ee */
        l_0x15_7067:
            ii(0x15_7067, 2); if(jbew(0x15_706c, 0x3)) goto l_0x15_706c; /* jbe 0x706c */
            ii(0x15_7069, 3); jmpw(0x15_7074, 0x8); goto l_0x15_7074;   /* jmp 0x7074 */
        l_0x15_706c:
            ii(0x15_706c, 3); cmp(memw_a16[es, bx], ax);                /* cmp [es:bx], ax */
            ii(0x15_706f, 2); if(jaw(0x15_7074, 0x3)) goto l_0x15_7074; /* ja 0x7074 */
            ii(0x15_7071, 3); jmpw(0x15_71ee, 0x17a); goto l_0x15_71ee; /* jmp 0x71ee */
        l_0x15_7074:
            ii(0x15_7074, 3); mov(ax, memw_a16[ss, bp - 0x7a]);         /* mov ax, [bp-0x7a] */
            ii(0x15_7077, 3); mov(dx, memw_a16[ss, bp - 0x78]);         /* mov dx, [bp-0x78] */
            ii(0x15_707a, 3); mov(si, memw_a16[ss, bp - 0x74]);         /* mov si, [bp-0x74] */
            ii(0x15_707d, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_707f, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x15_7081, 2); add(si, cx);                              /* add si, cx */
            ii(0x15_7083, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x15_7086, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_708a, 4); cmp(memw_a16[es, bx + si + 0x4], ax);     /* cmp [es:bx+si+0x4], ax */
            ii(0x15_708e, 2); if(jzw(0x15_7093, 0x3)) goto l_0x15_7093; /* jz 0x7093 */
            ii(0x15_7090, 3); jmpw(0x15_71eb, 0x158); goto l_0x15_71eb; /* jmp 0x71eb */
        l_0x15_7093:
            ii(0x15_7093, 4); cmp(memw_a16[es, bx + si + 0x6], dx);     /* cmp [es:bx+si+0x6], dx */
            ii(0x15_7097, 2); if(jzw(0x15_709c, 0x3)) goto l_0x15_709c; /* jz 0x709c */
            ii(0x15_7099, 3); jmpw(0x15_71eb, 0x14f); goto l_0x15_71eb; /* jmp 0x71eb */
        l_0x15_709c:
            ii(0x15_709c, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_709f, 4); cmp(memw_a16[ss, bp - 0x8e], ax);         /* cmp [bp-0x8e], ax */
            ii(0x15_70a3, 2); if(jzw(0x15_70a8, 0x3)) goto l_0x15_70a8; /* jz 0x70a8 */
            ii(0x15_70a5, 3); jmpw(0x15_70b8, 0x10); goto l_0x15_70b8;  /* jmp 0x70b8 */
        l_0x15_70a8:
            ii(0x15_70a8, 3); mov(ax, memw_a16[ss, bp - 0x7a]);         /* mov ax, [bp-0x7a] */
            ii(0x15_70ab, 3); mov(dx, memw_a16[ss, bp - 0x78]);         /* mov dx, [bp-0x78] */
            ii(0x15_70ae, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_70b2, 3); mov(memw_a16[ss, bp - 0x80], dx);         /* mov [bp-0x80], dx */
            ii(0x15_70b5, 3); jmpw(0x15_716e, 0xb6); goto l_0x15_716e;  /* jmp 0x716e */
        l_0x15_70b8:
            ii(0x15_70b8, 3); mov(si, memw_a16[ss, bp - 0x74]);         /* mov si, [bp-0x74] */
            ii(0x15_70bb, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x15_70bd, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x15_70bf, 2); add(si, ax);                              /* add si, ax */
            ii(0x15_70c1, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x15_70c4, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_70c8, 4); mov(ax, memw_a16[es, bx + si + 0xc]);     /* mov ax, [es:bx+si+0xc] */
            ii(0x15_70cc, 4); mov(dx, memw_a16[es, bx + si + 0xe]);     /* mov dx, [es:bx+si+0xe] */
            ii(0x15_70d0, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_70d3, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
            ii(0x15_70d6, 1); pushw(si);                                /* push si */
            ii(0x15_70d7, 1); pushw(di);                                /* push di */
            ii(0x15_70d8, 3); mov(ax, 0x503);                           /* mov ax, 0x503 */
            ii(0x15_70db, 4); mov(bx, memw_a16[ss, bp - 0x84]);         /* mov bx, [bp-0x84] */
            ii(0x15_70df, 4); mov(cx, memw_a16[ss, bp - 0x86]);         /* mov cx, [bp-0x86] */
            ii(0x15_70e3, 3); mov(si, memw_a16[ss, bp - 0x64]);         /* mov si, [bp-0x64] */
            ii(0x15_70e6, 3); mov(di, memw_a16[ss, bp - 0x66]);         /* mov di, [bp-0x66] */
            ii(0x15_70e9, 2); @int(0x31);                               /* int 0x31 */
            ii(0x15_70eb, 3); mov(memw_a16[ss, bp - 0x6c], si);         /* mov [bp-0x6c], si */
            ii(0x15_70ee, 3); mov(memw_a16[ss, bp - 0x6e], di);         /* mov [bp-0x6e], di */
            ii(0x15_70f1, 1); popw(di);                                 /* pop di */
            ii(0x15_70f2, 1); popw(si);                                 /* pop si */
            ii(0x15_70f3, 2); if(jaew(0x15_710a, 0x15)) goto l_0x15_710a; /* jae 0x710a */
            ii(0x15_70f5, 5); mov(memw_a16[ss, bp - 0x34], 0x8);        /* mov word [bp-0x34], 0x8 */
            ii(0x15_70fa, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_70ff, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_7101, 3); mov(memw_a16[ss, bp - 0x3e], ax);         /* mov [bp-0x3e], ax */
            ii(0x15_7104, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_7107, 3); jmpw(0x15_71f8, 0xee); goto l_0x15_71f8;  /* jmp 0x71f8 */
        l_0x15_710a:
            ii(0x15_710a, 3); mov(memw_a16[ss, bp - 0x80], bx);         /* mov [bp-0x80], bx */
            ii(0x15_710d, 4); mov(memw_a16[ss, bp - 0x82], cx);         /* mov [bp-0x82], cx */
            ii(0x15_7111, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x15_7115, 3); mov(dx, memw_a16[ss, bp - 0x80]);         /* mov dx, [bp-0x80] */
            ii(0x15_7118, 3); mov(si, memw_a16[ss, bp - 0x74]);         /* mov si, [bp-0x74] */
            ii(0x15_711b, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_711d, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x15_711f, 2); add(si, cx);                              /* add si, cx */
            ii(0x15_7121, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x15_7124, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_7128, 4); mov(memw_a16[es, bx + si + 0x4], ax);     /* mov [es:bx+si+0x4], ax */
            ii(0x15_712c, 4); mov(memw_a16[es, bx + si + 0x6], dx);     /* mov [es:bx+si+0x6], dx */
            ii(0x15_7130, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_7134, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_7138, 3); mov(si, memw_a16[ss, bp - 0x74]);         /* mov si, [bp-0x74] */
            ii(0x15_713b, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_713d, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x15_713f, 2); add(si, cx);                              /* add si, cx */
            ii(0x15_7141, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x15_7144, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_7148, 4); mov(memw_a16[es, bx + si + 0x8], ax);     /* mov [es:bx+si+0x8], ax */
            ii(0x15_714c, 4); mov(memw_a16[es, bx + si + 0xa], dx);     /* mov [es:bx+si+0xa], dx */
            ii(0x15_7150, 3); mov(ax, memw_a16[ss, bp - 0x6e]);         /* mov ax, [bp-0x6e] */
            ii(0x15_7153, 3); mov(dx, memw_a16[ss, bp - 0x6c]);         /* mov dx, [bp-0x6c] */
            ii(0x15_7156, 3); mov(si, memw_a16[ss, bp - 0x74]);         /* mov si, [bp-0x74] */
            ii(0x15_7159, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x15_715b, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x15_715d, 2); add(si, cx);                              /* add si, cx */
            ii(0x15_715f, 3); shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0x15_7162, 4); les(bx, ss, bp - 0xc8);                   /* les bx, [bp-0xc8] */
            ii(0x15_7166, 4); mov(memw_a16[es, bx + si + 0xc], ax);     /* mov [es:bx+si+0xc], ax */
            ii(0x15_716a, 4); mov(memw_a16[es, bx + si + 0xe], dx);     /* mov [es:bx+si+0xe], dx */
        l_0x15_716e:
            ii(0x15_716e, 3); pushw(memw_a16[ss, bp - 0x80]);           /* push word [bp-0x80] */
            ii(0x15_7171, 4); pushw(memw_a16[ss, bp - 0x82]);           /* push word [bp-0x82] */
            ii(0x15_7175, 4); pushw(memw_a16[ss, bp - 0x84]);           /* push word [bp-0x84] */
            ii(0x15_7179, 4); pushw(memw_a16[ss, bp - 0x86]);           /* push word [bp-0x86] */
            ii(0x15_717d, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_7180, 3); callw(0x15_61f0, -0xf93);                 /* call 0x61f0 */
            ii(0x15_7183, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_7186, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_7189, 4); cmp(memw_a16[ss, bp - 0xc0], ax);         /* cmp [bp-0xc0], ax */
            ii(0x15_718d, 2); if(jzw(0x15_7192, 0x3)) goto l_0x15_7192; /* jz 0x7192 */
            ii(0x15_718f, 3); jmpw(0x15_71e8, 0x56); goto l_0x15_71e8;  /* jmp 0x71e8 */
        l_0x15_7192:
            ii(0x15_7192, 4); mov(ax, memw_a16[ss, bp - 0x8e]);         /* mov ax, [bp-0x8e] */
            ii(0x15_7196, 4); lsl(eax, ax);                             /* lsl eax, ax */
            ii(0x15_719a, 4); mov(memd_a16[ss, bp - 0x7e], eax);        /* mov [bp-0x7e], eax */
            ii(0x15_719e, 4); add(memw_a16[ss, bp - 0x7e], 0x1);        /* add word [bp-0x7e], 0x1 */
            ii(0x15_71a2, 4); adc(memw_a16[ss, bp - 0x7c], 0);          /* adc word [bp-0x7c], 0x0 */
            ii(0x15_71a6, 3); mov(ax, memw_a16[ss, bp - 0x7e]);         /* mov ax, [bp-0x7e] */
            ii(0x15_71a9, 3); mov(dx, memw_a16[ss, bp - 0x7c]);         /* mov dx, [bp-0x7c] */
            ii(0x15_71ac, 4); cmp(memw_a16[ss, bp - 0x84], dx);         /* cmp [bp-0x84], dx */
            ii(0x15_71b0, 2); if(jbew(0x15_71b5, 0x3)) goto l_0x15_71b5; /* jbe 0x71b5 */
            ii(0x15_71b2, 3); jmpw(0x15_71d1, 0x1c); goto l_0x15_71d1;  /* jmp 0x71d1 */
        l_0x15_71b5:
            ii(0x15_71b5, 2); if(jaew(0x15_71ba, 0x3)) goto l_0x15_71ba; /* jae 0x71ba */
            ii(0x15_71b7, 3); jmpw(0x15_71c3, 0x9); goto l_0x15_71c3;   /* jmp 0x71c3 */
        l_0x15_71ba:
            ii(0x15_71ba, 4); cmp(memw_a16[ss, bp - 0x86], ax);         /* cmp [bp-0x86], ax */
            ii(0x15_71be, 2); if(jbw(0x15_71c3, 0x3)) goto l_0x15_71c3; /* jb 0x71c3 */
            ii(0x15_71c0, 3); jmpw(0x15_71d1, 0xe); goto l_0x15_71d1;   /* jmp 0x71d1 */
        l_0x15_71c3:
            ii(0x15_71c3, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_71c7, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_71cb, 3); mov(memw_a16[ss, bp - 0x7e], ax);         /* mov [bp-0x7e], ax */
            ii(0x15_71ce, 3); mov(memw_a16[ss, bp - 0x7c], dx);         /* mov [bp-0x7c], dx */
        l_0x15_71d1:
            ii(0x15_71d1, 3); pushw(memw_a16[ss, bp - 0x80]);           /* push word [bp-0x80] */
            ii(0x15_71d4, 4); pushw(memw_a16[ss, bp - 0x82]);           /* push word [bp-0x82] */
            ii(0x15_71d8, 3); pushw(memw_a16[ss, bp - 0x7c]);           /* push word [bp-0x7c] */
            ii(0x15_71db, 3); pushw(memw_a16[ss, bp - 0x7e]);           /* push word [bp-0x7e] */
            ii(0x15_71de, 4); pushw(memw_a16[ss, bp - 0x8e]);           /* push word [bp-0x8e] */
            ii(0x15_71e2, 3); callw(0x15_61f0, -0xff5);                 /* call 0x61f0 */
            ii(0x15_71e5, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x15_71e8:
            ii(0x15_71e8, 3); jmpw(0x15_6fad, -0x23e); goto l_0x15_6fad; /* jmp 0x6fad */
        l_0x15_71eb:
            ii(0x15_71eb, 3); jmpw(0x15_7053, -0x19b); goto l_0x15_7053; /* jmp 0x7053 */
        l_0x15_71ee:
            ii(0x15_71ee, 5); mov(memw_a16[ss, bp - 0x34], 0x9);        /* mov word [bp-0x34], 0x9 */
            ii(0x15_71f3, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
        l_0x15_71f8:
            ii(0x15_71f8, 4); or(memw_a16[ss, bp - 0x22], 0x1);         /* or word [bp-0x22], 0x1 */
            ii(0x15_71fc, 4); or(memw_a16[ss, bp - 0x20], 0);           /* or word [bp-0x20], 0x0 */
            ii(0x15_7200, 3); jmpw(0x15_7817, 0x614); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_7203:
            ii(0x15_7203, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_7205, 1); nop();                                    /* nop */
            ii(0x15_7206, 1); pushw(cs);                                /* push cs */
            ii(0x15_7207, 3); callw(0x14_f896, -0x7974);                /* call 0xf896 */
            ii(0x15_720a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_720d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_720f, 2); pushw(0x24);                              /* push 0x24 */
            ii(0x15_7211, 1); nop();                                    /* nop */
            ii(0x15_7212, 1); pushw(cs);                                /* push cs */
            ii(0x15_7213, 3); callw(0x15_606f, -0x11a7);                /* call 0x606f */
            ii(0x15_7216, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_7219, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_721c, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_721f, 3); and(ax, memw_a16[ss, bp - 0x3c]);         /* and ax, [bp-0x3c] */
            ii(0x15_7222, 3); and(dx, memw_a16[ss, bp - 0x3a]);         /* and dx, [bp-0x3a] */
            ii(0x15_7225, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_7227, 2); if(jzw(0x15_722c, 0x3)) goto l_0x15_722c; /* jz 0x722c */
            ii(0x15_7229, 3); jmpw(0x15_723f, 0x13); goto l_0x15_723f;  /* jmp 0x723f */
        l_0x15_722c:
            ii(0x15_722c, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_722f, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_7232, 3); and(ax, memw_a16[ss, bp - 0x40]);         /* and ax, [bp-0x40] */
            ii(0x15_7235, 3); and(dx, memw_a16[ss, bp - 0x3e]);         /* and dx, [bp-0x3e] */
            ii(0x15_7238, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_723a, 2); if(jnzw(0x15_723f, 0x3)) goto l_0x15_723f; /* jnz 0x723f */
            ii(0x15_723c, 3); jmpw(0x15_7403, 0x1c4); goto l_0x15_7403; /* jmp 0x7403 */
        l_0x15_723f:
            ii(0x15_723f, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_7242, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_7246, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_7249, 3); mov(memw_a16[ss, bp - 0x7a], ax);         /* mov [bp-0x7a], ax */
            ii(0x15_724c, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_724f, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_7252, 3); mov(memw_a16[ss, bp - 0x66], ax);         /* mov [bp-0x66], ax */
            ii(0x15_7255, 3); mov(memw_a16[ss, bp - 0x64], dx);         /* mov [bp-0x64], dx */
            ii(0x15_7258, 3); mov(ax, memw_a16[ss, bp - 0x40]);         /* mov ax, [bp-0x40] */
            ii(0x15_725b, 3); mov(dx, memw_a16[ss, bp - 0x3e]);         /* mov dx, [bp-0x3e] */
            ii(0x15_725e, 3); mov(memw_a16[ss, bp - 0x74], ax);         /* mov [bp-0x74], ax */
            ii(0x15_7261, 3); mov(memw_a16[ss, bp - 0x72], dx);         /* mov [bp-0x72], dx */
            ii(0x15_7264, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_7267, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_726a, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_726d, 1); nop();                                    /* nop */
            ii(0x15_726e, 1); pushw(cs);                                /* push cs */
            ii(0x15_726f, 3); callw(0x15_789c, 0x62a);                  /* call 0x789c */
            ii(0x15_7272, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7275, 4); mov(memw_a16[ss, bp - 0xc8], ax);         /* mov [bp-0xc8], ax */
            ii(0x15_7279, 3); pushw(memw_a16[ss, bp - 0x3e]);           /* push word [bp-0x3e] */
            ii(0x15_727c, 3); pushw(memw_a16[ss, bp - 0x40]);           /* push word [bp-0x40] */
            ii(0x15_727f, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_7282, 1); nop();                                    /* nop */
            ii(0x15_7283, 1); pushw(cs);                                /* push cs */
            ii(0x15_7284, 3); callw(0x15_789c, 0x615);                  /* call 0x789c */
            ii(0x15_7287, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_728a, 4); mov(memw_a16[ss, bp - 0xc4], ax);         /* mov [bp-0xc4], ax */
            ii(0x15_728e, 6); mov(memw_a16[ss, bp - 0x86], 0);          /* mov word [bp-0x86], 0x0 */
            ii(0x15_7294, 4); mov(ax, memw_a16[ss, bp - 0xc4]);         /* mov ax, [bp-0xc4] */
            ii(0x15_7298, 5); mov(memw_a16[ss, bp - 0x6e], 0);          /* mov word [bp-0x6e], 0x0 */
            ii(0x15_729d, 3); mov(memw_a16[ss, bp - 0x6c], ax);         /* mov [bp-0x6c], ax */
            ii(0x15_72a0, 4); lea(ax, bp - 0xd6);                       /* lea ax, [bp-0xd6] */
            ii(0x15_72a4, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_72a8, 4); mov(memw_a16[ss, bp - 0xd8], ss);         /* mov [bp-0xd8], ss */
            ii(0x15_72ac, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_72af, 4); mov(cx, memw_a16[es, bx + 0x4]);          /* mov cx, [es:bx+0x4] */
            ii(0x15_72b3, 4); mov(memw_a16[ss, bp - 0xd6], cx);         /* mov [bp-0xd6], cx */
            ii(0x15_72b7, 3); cmp(cx, 0);                               /* cmp cx, 0x0 */
            ii(0x15_72ba, 2); if(jnzw(0x15_72bf, 0x3)) goto l_0x15_72bf; /* jnz 0x72bf */
            ii(0x15_72bc, 3); jmpw(0x15_732e, 0x6f); goto l_0x15_732e;  /* jmp 0x732e */
        l_0x15_72bf:
            ii(0x15_72bf, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_72c2, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_72c6, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_72c9, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_72cc, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_72d0, 1); nop();                                    /* nop */
            ii(0x15_72d1, 1); pushw(cs);                                /* push cs */
            ii(0x15_72d2, 3); callw(0x15_789c, 0x5c7);                  /* call 0x789c */
            ii(0x15_72d5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_72d8, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_72dc, 4); mov(ax, memw_a16[ss, bp - 0xd6]);         /* mov ax, [bp-0xd6] */
            ii(0x15_72e0, 5); mov(memw_a16[ss, bp - 0x7e], 0);          /* mov word [bp-0x7e], 0x0 */
            ii(0x15_72e5, 3); mov(memw_a16[ss, bp - 0x7c], ax);         /* mov [bp-0x7c], ax */
        l_0x15_72e8:
            ii(0x15_72e8, 3); les(bx, ss, bp - 0x7e);                   /* les bx, [bp-0x7e] */
            ii(0x15_72eb, 4); mov(si, memw_a16[ss, bp - 0x86]);         /* mov si, [bp-0x86] */
            ii(0x15_72ef, 4); cmp(memw_a16[es, bx + si], 0);            /* cmp word [es:bx+si], 0x0 */
            ii(0x15_72f3, 2); if(jnzw(0x15_72f8, 0x3)) goto l_0x15_72f8; /* jnz 0x72f8 */
            ii(0x15_72f5, 3); jmpw(0x15_72ff, 0x7); goto l_0x15_72ff;   /* jmp 0x72ff */
        l_0x15_72f8:
            ii(0x15_72f8, 4); inc(memw_a16[ss, bp - 0x86]);             /* inc word [bp-0x86] */
            ii(0x15_72fc, 3); jmpw(0x15_72e8, -0x17); goto l_0x15_72e8; /* jmp 0x72e8 */
        l_0x15_72ff:
            ii(0x15_72ff, 4); lea(ax, bp - 0xe2);                       /* lea ax, [bp-0xe2] */
            ii(0x15_7303, 1); pushw(ss);                                /* push ss */
            ii(0x15_7304, 1); pushw(ax);                                /* push ax */
            ii(0x15_7305, 4); pushw(memw_a16[ss, bp - 0xd6]);           /* push word [bp-0xd6] */
            ii(0x15_7309, 5); callw_far_abs(0x80, 0x4f82);              /* call word 0x80:0x4f82 */
            ii(0x15_730e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7311, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_7315, 3); add(ax, 0x2);                             /* add ax, 0x2 */
            ii(0x15_7318, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x15_731c, 4); lea(ax, bp - 0xe2);                       /* lea ax, [bp-0xe2] */
            ii(0x15_7320, 1); pushw(ss);                                /* push ss */
            ii(0x15_7321, 1); pushw(ax);                                /* push ax */
            ii(0x15_7322, 4); pushw(memw_a16[ss, bp - 0xd6]);           /* push word [bp-0xd6] */
            ii(0x15_7326, 5); callw_far_abs(0x80, 0x4ff4);              /* call word 0x80:0x4ff4 */
            ii(0x15_732b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x15_732e:
            ii(0x15_732e, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_7331, 4); pushw(memw_a16[es, bx + 0x8]);            /* push word [es:bx+0x8] */
            ii(0x15_7335, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x15_7339, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_733c, 4); pushw(memw_a16[es, bx + 0xa]);            /* push word [es:bx+0xa] */
            ii(0x15_7340, 1); nop();                                    /* nop */
            ii(0x15_7341, 1); pushw(cs);                                /* push cs */
            ii(0x15_7342, 3); callw(0x15_789c, 0x557);                  /* call 0x789c */
            ii(0x15_7345, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7348, 6); mov(memw_a16[ss, bp - 0xd4], 0);          /* mov word [bp-0xd4], 0x0 */
            ii(0x15_734e, 4); mov(memw_a16[ss, bp - 0xd2], ax);         /* mov [bp-0xd2], ax */
            ii(0x15_7352, 6); mov(memw_a16[ss, bp - 0xd0], 0x1296);     /* mov word [bp-0xd0], 0x1296 */
            ii(0x15_7358, 4); mov(memw_a16[ss, bp - 0xce], ds);         /* mov [bp-0xce], ds */
            ii(0x15_735c, 6); mov(memw_a16[ss, bp - 0xcc], 0x1296);     /* mov word [bp-0xcc], 0x1296 */
            ii(0x15_7362, 4); mov(memw_a16[ss, bp - 0xca], ds);         /* mov [bp-0xca], ds */
            ii(0x15_7366, 4); mov(ax, memw_a16[ss, bp - 0xc8]);         /* mov ax, [bp-0xc8] */
            ii(0x15_736a, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_736d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_736f, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_7372, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_7375, 4); mov(ax, memw_a16[ss, bp - 0xd8]);         /* mov ax, [bp-0xd8] */
            ii(0x15_7379, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_737c, 4); mov(ax, memw_a16[ss, bp - 0xda]);         /* mov ax, [bp-0xda] */
            ii(0x15_7380, 3); mov(memw_a16[ss, bp - 0x40], ax);         /* mov [bp-0x40], ax */
            ii(0x15_7383, 5); mov(memw_a16[ss, bp - 0x3e], 0);          /* mov word [bp-0x3e], 0x0 */
            ii(0x15_7388, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_738b, 1); pushw(ss);                                /* push ss */
            ii(0x15_738c, 1); pushw(ax);                                /* push ax */
            ii(0x15_738d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_7390, 3); callw(0x15_61c1, -0x11d2);                /* call 0x61c1 */
            ii(0x15_7393, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7396, 3); les(bx, ss, bp - 0x6e);                   /* les bx, [bp-0x6e] */
            ii(0x15_7399, 5); cmp(memw_a16[es, bx + 0x4], 0x1);         /* cmp word [es:bx+0x4], 0x1 */
            ii(0x15_739e, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_73a0, 3); and(ax, 0xffff);                          /* and ax, 0xffff */
            ii(0x15_73a3, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x15_73a6, 4); sub(memw_a16[ds, 0x1274], ax);            /* sub [0x1274], ax */
            ii(0x15_73aa, 4); mov(ax, memw_a16[ss, bp - 0xc8]);         /* mov ax, [bp-0xc8] */
            ii(0x15_73ae, 3); cmp(memw_a16[ss, bp - 0x58], ax);         /* cmp [bp-0x58], ax */
            ii(0x15_73b1, 2); if(jzw(0x15_73b6, 0x3)) goto l_0x15_73b6; /* jz 0x73b6 */
            ii(0x15_73b3, 3); jmpw(0x15_73c9, 0x13); goto l_0x15_73c9;  /* jmp 0x73c9 */
        l_0x15_73b6:
            ii(0x15_73b6, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x15_73ba, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_73bd, 3); mov(ax, memw_a16[ss, bp - 0x66]);         /* mov ax, [bp-0x66] */
            ii(0x15_73c0, 3); mov(dx, memw_a16[ss, bp - 0x64]);         /* mov dx, [bp-0x64] */
            ii(0x15_73c3, 3); add(memw_a16[ss, bp - 0x3c], ax);         /* add [bp-0x3c], ax */
            ii(0x15_73c6, 3); adc(memw_a16[ss, bp - 0x3a], dx);         /* adc [bp-0x3a], dx */
        l_0x15_73c9:
            ii(0x15_73c9, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_73cc, 4); cmp(memw_a16[ss, bp - 0xd8], ax);         /* cmp [bp-0xd8], ax */
            ii(0x15_73d0, 2); if(jzw(0x15_73d5, 0x3)) goto l_0x15_73d5; /* jz 0x73d5 */
            ii(0x15_73d2, 3); jmpw(0x15_73e7, 0x12); goto l_0x15_73e7;  /* jmp 0x73e7 */
        l_0x15_73d5:
            ii(0x15_73d5, 3); mov(ax, memw_a16[ss, bp - 0x7a]);         /* mov ax, [bp-0x7a] */
            ii(0x15_73d8, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_73db, 3); mov(ax, memw_a16[ss, bp - 0x74]);         /* mov ax, [bp-0x74] */
            ii(0x15_73de, 3); mov(dx, memw_a16[ss, bp - 0x72]);         /* mov dx, [bp-0x72] */
            ii(0x15_73e1, 3); add(memw_a16[ss, bp - 0x40], ax);         /* add [bp-0x40], ax */
            ii(0x15_73e4, 3); adc(memw_a16[ss, bp - 0x3e], dx);         /* adc [bp-0x3e], dx */
        l_0x15_73e7:
            ii(0x15_73e7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_73e9, 1); nop();                                    /* nop */
            ii(0x15_73ea, 1); pushw(cs);                                /* push cs */
            ii(0x15_73eb, 3); callw(0x14_f850, -0x7b9e);                /* call 0xf850 */
            ii(0x15_73ee, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_73f1, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_73f3, 2); pushw(0x24);                              /* push 0x24 */
            ii(0x15_73f5, 1); nop();                                    /* nop */
            ii(0x15_73f6, 1); pushw(cs);                                /* push cs */
            ii(0x15_73f7, 3); callw(0x15_606f, -0x138b);                /* call 0x606f */
            ii(0x15_73fa, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_73fd, 3); jmpw(0x15_7817, 0x417); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_7400, 3); jmpw(0x15_7414, 0x11); goto l_0x15_7414;  /* jmp 0x7414 */
        l_0x15_7403:
            ii(0x15_7403, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_7406, 1); pushw(ss);                                /* push ss */
            ii(0x15_7407, 1); pushw(ax);                                /* push ax */
            ii(0x15_7408, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_740b, 3); callw(0x15_61c1, -0x124d);                /* call 0x61c1 */
            ii(0x15_740e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7411, 3); jmpw(0x15_73e7, -0x2d); goto l_0x15_73e7; /* jmp 0x73e7 */
        l_0x15_7414:
            ii(0x15_7414, 3); jmpw(0x15_7817, 0x400); goto l_0x15_7817; /* jmp 0x7817 */
        l_0x15_7417:
            ii(0x15_7417, 1); nop();                                    /* nop */
            ii(0x15_7418, 1); pushw(cs);                                /* push cs */
            ii(0x15_7419, 3); callw(0x15_5ec8, -0x1554);                /* call 0x5ec8 */
            ii(0x15_741c, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_741f, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_7422, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_7425, 3); jmpw(0x15_633b, -0x10ed); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_7428:
            ii(0x15_7428, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_742b, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_742e, 3); and(ax, memw_a16[ss, bp - 0x3c]);         /* and ax, [bp-0x3c] */
            ii(0x15_7431, 3); and(dx, memw_a16[ss, bp - 0x3a]);         /* and dx, [bp-0x3a] */
            ii(0x15_7434, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_7436, 2); if(jzw(0x15_743b, 0x3)) goto l_0x15_743b; /* jz 0x743b */
            ii(0x15_7438, 3); jmpw(0x15_744e, 0x13); goto l_0x15_744e;  /* jmp 0x744e */
        l_0x15_743b:
            ii(0x15_743b, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_743e, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_7441, 3); and(ax, memw_a16[ss, bp - 0x50]);         /* and ax, [bp-0x50] */
            ii(0x15_7444, 3); and(dx, memw_a16[ss, bp - 0x4e]);         /* and dx, [bp-0x4e] */
            ii(0x15_7447, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_7449, 2); if(jnzw(0x15_744e, 0x3)) goto l_0x15_744e; /* jnz 0x744e */
            ii(0x15_744b, 3); jmpw(0x15_751b, 0xcd); goto l_0x15_751b;  /* jmp 0x751b */
        l_0x15_744e:
            ii(0x15_744e, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_7451, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_7455, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_7458, 4); mov(memw_a16[ss, bp - 0xc8], ax);         /* mov [bp-0xc8], ax */
            ii(0x15_745c, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x15_745f, 3); mov(dx, memw_a16[ss, bp - 0x3a]);         /* mov dx, [bp-0x3a] */
            ii(0x15_7462, 4); mov(memw_a16[ss, bp - 0xc4], ax);         /* mov [bp-0xc4], ax */
            ii(0x15_7466, 4); mov(memw_a16[ss, bp - 0xc2], dx);         /* mov [bp-0xc2], dx */
            ii(0x15_746a, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_746d, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_7470, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_7474, 4); mov(memw_a16[ss, bp - 0x84], dx);         /* mov [bp-0x84], dx */
            ii(0x15_7478, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_747b, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_747e, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_7481, 1); nop();                                    /* nop */
            ii(0x15_7482, 1); pushw(cs);                                /* push cs */
            ii(0x15_7483, 3); callw(0x15_789c, 0x416);                  /* call 0x789c */
            ii(0x15_7486, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7489, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x15_748d, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x15_7490, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x15_7493, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_7496, 1); nop();                                    /* nop */
            ii(0x15_7497, 1); pushw(cs);                                /* push cs */
            ii(0x15_7498, 3); callw(0x15_789c, 0x401);                  /* call 0x789c */
            ii(0x15_749b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_749e, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_74a2, 4); mov(ax, memw_a16[ss, bp - 0xe2]);         /* mov ax, [bp-0xe2] */
            ii(0x15_74a6, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_74a9, 4); mov(ax, memw_a16[ss, bp - 0xda]);         /* mov ax, [bp-0xda] */
            ii(0x15_74ad, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_74b0, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_74b2, 3); mov(memw_a16[ss, bp - 0x3a], ax);         /* mov [bp-0x3a], ax */
            ii(0x15_74b5, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x15_74b8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_74ba, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x15_74bd, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_74c0, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_74c3, 1); pushw(ss);                                /* push ss */
            ii(0x15_74c4, 1); pushw(ax);                                /* push ax */
            ii(0x15_74c5, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_74c8, 3); callw(0x15_61c1, -0x130a);                /* call 0x61c1 */
            ii(0x15_74cb, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_74ce, 5); sub(memw_a16[ds, 0x1274], 0x2);           /* sub word [0x1274], 0x2 */
            ii(0x15_74d3, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_74d6, 4); cmp(memw_a16[ss, bp - 0xe2], ax);         /* cmp [bp-0xe2], ax */
            ii(0x15_74da, 2); if(jzw(0x15_74df, 0x3)) goto l_0x15_74df; /* jz 0x74df */
            ii(0x15_74dc, 3); jmpw(0x15_74f4, 0x15); goto l_0x15_74f4;  /* jmp 0x74f4 */
        l_0x15_74df:
            ii(0x15_74df, 4); mov(ax, memw_a16[ss, bp - 0xd6]);         /* mov ax, [bp-0xd6] */
            ii(0x15_74e3, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_74e6, 4); mov(ax, memw_a16[ss, bp - 0xc4]);         /* mov ax, [bp-0xc4] */
            ii(0x15_74ea, 4); mov(dx, memw_a16[ss, bp - 0xc2]);         /* mov dx, [bp-0xc2] */
            ii(0x15_74ee, 3); add(memw_a16[ss, bp - 0x3c], ax);         /* add [bp-0x3c], ax */
            ii(0x15_74f1, 3); adc(memw_a16[ss, bp - 0x3a], dx);         /* adc [bp-0x3a], dx */
        l_0x15_74f4:
            ii(0x15_74f4, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_74f7, 4); cmp(memw_a16[ss, bp - 0xda], ax);         /* cmp [bp-0xda], ax */
            ii(0x15_74fb, 2); if(jzw(0x15_7500, 0x3)) goto l_0x15_7500; /* jz 0x7500 */
            ii(0x15_74fd, 3); jmpw(0x15_7515, 0x15); goto l_0x15_7515;  /* jmp 0x7515 */
        l_0x15_7500:
            ii(0x15_7500, 4); mov(ax, memw_a16[ss, bp - 0xc8]);         /* mov ax, [bp-0xc8] */
            ii(0x15_7504, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_7507, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_750b, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_750f, 3); add(memw_a16[ss, bp - 0x50], ax);         /* add [bp-0x50], ax */
            ii(0x15_7512, 3); adc(memw_a16[ss, bp - 0x4e], dx);         /* adc [bp-0x4e], dx */
        l_0x15_7515:
            ii(0x15_7515, 3); jmpw(0x15_7817, 0x2ff); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_7518, 3); jmpw(0x15_751e, 0x3); goto l_0x15_751e;   /* jmp 0x751e */
        l_0x15_751b:
            ii(0x15_751b, 3); jmpw(0x15_633b, -0x11e3); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_751e:
            ii(0x15_751e, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_7521, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_7524, 3); and(ax, memw_a16[ss, bp - 0x4c]);         /* and ax, [bp-0x4c] */
            ii(0x15_7527, 3); and(dx, memw_a16[ss, bp - 0x4a]);         /* and dx, [bp-0x4a] */
            ii(0x15_752a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_752c, 2); if(jnzw(0x15_7531, 0x3)) goto l_0x15_7531; /* jnz 0x7531 */
            ii(0x15_752e, 3); jmpw(0x15_75a7, 0x76); goto l_0x15_75a7;  /* jmp 0x75a7 */
        l_0x15_7531:
            ii(0x15_7531, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_7534, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x15_7538, 3); mov(ax, memw_a16[ss, bp - 0x4c]);         /* mov ax, [bp-0x4c] */
            ii(0x15_753b, 3); mov(dx, memw_a16[ss, bp - 0x4a]);         /* mov dx, [bp-0x4a] */
            ii(0x15_753e, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_7542, 4); mov(memw_a16[ss, bp - 0xd8], dx);         /* mov [bp-0xd8], dx */
            ii(0x15_7546, 3); pushw(memw_a16[ss, bp - 0x4a]);           /* push word [bp-0x4a] */
            ii(0x15_7549, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_754c, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_754f, 1); nop();                                    /* nop */
            ii(0x15_7550, 1); pushw(cs);                                /* push cs */
            ii(0x15_7551, 3); callw(0x15_789c, 0x348);                  /* call 0x789c */
            ii(0x15_7554, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7557, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_755b, 4); mov(ax, memw_a16[ss, bp - 0xd6]);         /* mov ax, [bp-0xd6] */
            ii(0x15_755f, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_7562, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_7564, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x15_7567, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x15_756a, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_756d, 1); pushw(ss);                                /* push ss */
            ii(0x15_756e, 1); pushw(ax);                                /* push ax */
            ii(0x15_756f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_7572, 3); callw(0x15_61c1, -0x13b4);                /* call 0x61c1 */
            ii(0x15_7575, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_7578, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x15_757c, 4); mov(ax, memw_a16[ss, bp - 0xd6]);         /* mov ax, [bp-0xd6] */
            ii(0x15_7580, 3); cmp(memw_a16[ss, bp - 0x58], ax);         /* cmp [bp-0x58], ax */
            ii(0x15_7583, 2); if(jzw(0x15_7588, 0x3)) goto l_0x15_7588; /* jz 0x7588 */
            ii(0x15_7585, 3); jmpw(0x15_758f, 0x7); goto l_0x15_758f;   /* jmp 0x758f */
        l_0x15_7588:
            ii(0x15_7588, 4); mov(ax, memw_a16[ss, bp - 0xe2]);         /* mov ax, [bp-0xe2] */
            ii(0x15_758c, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
        l_0x15_758f:
            ii(0x15_758f, 3); mov(ax, memw_a16[ss, bp - 0x4c]);         /* mov ax, [bp-0x4c] */
            ii(0x15_7592, 1); cwd();                                    /* cwd */
            ii(0x15_7593, 4); add(ax, memw_a16[ss, bp - 0xda]);         /* add ax, [bp-0xda] */
            ii(0x15_7597, 4); adc(dx, memw_a16[ss, bp - 0xd8]);         /* adc dx, [bp-0xd8] */
            ii(0x15_759b, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x15_759e, 3); mov(memw_a16[ss, bp - 0x4a], dx);         /* mov [bp-0x4a], dx */
            ii(0x15_75a1, 3); jmpw(0x15_7817, 0x273); goto l_0x15_7817; /* jmp 0x7817 */
        //    ii(0x15_75a4, 3); jmpw(0x15_75aa, 0x3); goto l_0x15_75aa;   /* jmp 0x75aa */
        l_0x15_75a7:
            ii(0x15_75a7, 3); jmpw(0x15_633b, -0x126f); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_75aa:
            ii(0x15_75aa, 4); cmp(memb_a16[ss, bp - 0x34], 0x6);        /* cmp byte [bp-0x34], 0x6 */
            ii(0x15_75ae, 2); if(jzw(0x15_75b3, 0x3)) goto l_0x15_75b3; /* jz 0x75b3 */
            ii(0x15_75b0, 3); jmpw(0x15_75bb, 0x8); goto l_0x15_75bb;   /* jmp 0x75bb */
        l_0x15_75b3:
            ii(0x15_75b3, 5); mov(memw_a16[ss, bp - 0x2], 0x40);        /* mov word [bp-0x2], 0x40 */
            ii(0x15_75b8, 3); jmpw(0x15_633b, -0x1280); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_75bb:
            ii(0x15_75bb, 4); cmp(memb_a16[ss, bp - 0x34], 0xa);        /* cmp byte [bp-0x34], 0xa */
            ii(0x15_75bf, 2); if(jzw(0x15_75c4, 0x3)) goto l_0x15_75c4; /* jz 0x75c4 */
            ii(0x15_75c1, 3); jmpw(0x15_75c7, 0x3); goto l_0x15_75c7;   /* jmp 0x75c7 */
        l_0x15_75c4:
            ii(0x15_75c4, 3); jmpw(0x15_751e, -0xa9); goto l_0x15_751e; /* jmp 0x751e */
        l_0x15_75c7:
            ii(0x15_75c7, 3); jmpw(0x15_633b, -0x128f); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_75ca:
            ii(0x15_75ca, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_75cd, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x15_75cf, 3); jmpw(0x15_75e3, 0x11); goto l_0x15_75e3;  /* jmp 0x75e3 */
        l_0x15_75d2:
            ii(0x15_75d2, 3); jmpw(0x15_6442, -0x1193); goto l_0x15_6442; /* jmp 0x6442 */
        l_0x15_75d5:
            ii(0x15_75d5, 3); jmpw(0x15_751e, -0xba); goto l_0x15_751e; /* jmp 0x751e */
        l_0x15_75d8:
            ii(0x15_75d8, 5); mov(memw_a16[ss, bp - 0x2], 0x2);         /* mov word [bp-0x2], 0x2 */
            ii(0x15_75dd, 3); jmpw(0x15_7746, 0x166); goto l_0x15_7746; /* jmp 0x7746 */
        //    ii(0x15_75e0, 3); jmpw(0x15_75ff, 0x1c); goto l_0x15_75ff;  /* jmp 0x75ff */
        l_0x15_75e3:
            ii(0x15_75e3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_75e5, 2); if(jgew(0x15_75ea, 0x3)) goto l_0x15_75ea; /* jge 0x75ea */
            ii(0x15_75e7, 3); jmpw(0x15_75ff, 0x15); goto l_0x15_75ff;  /* jmp 0x75ff */
        l_0x15_75ea:
            ii(0x15_75ea, 1); dec(ax);                                  /* dec ax */
            ii(0x15_75eb, 2); if(jgw(0x15_75f0, 0x3)) goto l_0x15_75f0; /* jg 0x75f0 */
            ii(0x15_75ed, 3); jmpw(0x15_75d2, -0x1e); goto l_0x15_75d2; /* jmp 0x75d2 */
        l_0x15_75f0:
            ii(0x15_75f0, 1); dec(ax);                                  /* dec ax */
            ii(0x15_75f1, 2); if(jnzw(0x15_75f6, 0x3)) goto l_0x15_75f6; /* jnz 0x75f6 */
            ii(0x15_75f3, 3); jmpw(0x15_75d5, -0x21); goto l_0x15_75d5; /* jmp 0x75d5 */
        l_0x15_75f6:
            ii(0x15_75f6, 1); dec(ax);                                  /* dec ax */
            ii(0x15_75f7, 2); if(jnzw(0x15_75fc, 0x3)) goto l_0x15_75fc; /* jnz 0x75fc */
            ii(0x15_75f9, 3); jmpw(0x15_75d8, -0x24); goto l_0x15_75d8; /* jmp 0x75d8 */
        l_0x15_75fc:
            ii(0x15_75fc, 3); jmpw(0x15_75ff, 0); goto l_0x15_75ff;     /* jmp 0x75ff */
        l_0x15_75ff:
            ii(0x15_75ff, 3); jmpw(0x15_633b, -0x12c7); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_7602:
            ii(0x15_7602, 3); mov(al, memb_a16[ss, bp - 0x34]);         /* mov al, [bp-0x34] */
            ii(0x15_7605, 4); mov(memb_a16[ss, bp - 0xe2], al);         /* mov [bp-0xe2], al */
            ii(0x15_7609, 4); cmp(memb_a16[ss, bp - 0x33], 0x60);       /* cmp byte [bp-0x33], 0x60 */
            ii(0x15_760d, 2); if(jzw(0x15_7612, 0x3)) goto l_0x15_7612; /* jz 0x7612 */
            ii(0x15_760f, 3); jmpw(0x15_761a, 0x8); goto l_0x15_761a;   /* jmp 0x761a */
        l_0x15_7612:
            ii(0x15_7612, 5); mov(memb_a16[ss, bp - 0xe2], 0x2);        /* mov byte [bp-0xe2], 0x2 */
            ii(0x15_7617, 3); jmpw(0x15_7636, 0x1c); goto l_0x15_7636;  /* jmp 0x7636 */
        l_0x15_761a:
            ii(0x15_761a, 5); cmp(memb_a16[ss, bp - 0xe2], 0x4);        /* cmp byte [bp-0xe2], 0x4 */
            ii(0x15_761f, 2); if(jzw(0x15_7624, 0x3)) goto l_0x15_7624; /* jz 0x7624 */
            ii(0x15_7621, 3); jmpw(0x15_7627, 0x3); goto l_0x15_7627;   /* jmp 0x7627 */
        l_0x15_7624:
            ii(0x15_7624, 3); jmpw(0x15_751e, -0x109); goto l_0x15_751e; /* jmp 0x751e */
        l_0x15_7627:
            ii(0x15_7627, 5); cmp(memb_a16[ss, bp - 0xe2], 0x2);        /* cmp byte [bp-0xe2], 0x2 */
            ii(0x15_762c, 2); if(jzw(0x15_7631, 0x3)) goto l_0x15_7631; /* jz 0x7631 */
            ii(0x15_762e, 3); jmpw(0x15_7636, 0x5); goto l_0x15_7636;   /* jmp 0x7636 */
        l_0x15_7631:
            ii(0x15_7631, 5); mov(memw_a16[ss, bp - 0x2], 0x2);         /* mov word [bp-0x2], 0x2 */
        l_0x15_7636:
            ii(0x15_7636, 5); cmp(memb_a16[ss, bp - 0xe2], 0x2);        /* cmp byte [bp-0xe2], 0x2 */
            ii(0x15_763b, 2); if(jnzw(0x15_7640, 0x3)) goto l_0x15_7640; /* jnz 0x7640 */
            ii(0x15_763d, 3); jmpw(0x15_764a, 0xa); goto l_0x15_764a;   /* jmp 0x764a */
        l_0x15_7640:
            ii(0x15_7640, 5); cmp(memb_a16[ss, bp - 0xe2], 0x3);        /* cmp byte [bp-0xe2], 0x3 */
            ii(0x15_7645, 2); if(jzw(0x15_764a, 0x3)) goto l_0x15_764a; /* jz 0x764a */
            ii(0x15_7647, 3); jmpw(0x15_7738, 0xee); goto l_0x15_7738;  /* jmp 0x7738 */
        l_0x15_764a:
            ii(0x15_764a, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_764d, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_7650, 3); and(ax, memw_a16[ss, bp - 0x4c]);         /* and ax, [bp-0x4c] */
            ii(0x15_7653, 3); and(dx, memw_a16[ss, bp - 0x4a]);         /* and dx, [bp-0x4a] */
            ii(0x15_7656, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_7658, 2); if(jzw(0x15_765d, 0x3)) goto l_0x15_765d; /* jz 0x765d */
            ii(0x15_765a, 3); jmpw(0x15_7670, 0x13); goto l_0x15_7670;  /* jmp 0x7670 */
        l_0x15_765d:
            ii(0x15_765d, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_7660, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_7663, 3); and(ax, memw_a16[ss, bp - 0x50]);         /* and ax, [bp-0x50] */
            ii(0x15_7666, 3); and(dx, memw_a16[ss, bp - 0x4e]);         /* and dx, [bp-0x4e] */
            ii(0x15_7669, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_766b, 2); if(jnzw(0x15_7670, 0x3)) goto l_0x15_7670; /* jnz 0x7670 */
            ii(0x15_766d, 3); jmpw(0x15_7738, 0xc8); goto l_0x15_7738;  /* jmp 0x7738 */
        l_0x15_7670:
            ii(0x15_7670, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_7673, 4); mov(memw_a16[ss, bp - 0xc8], ax);         /* mov [bp-0xc8], ax */
            ii(0x15_7677, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_767a, 4); mov(memw_a16[ss, bp - 0xc4], ax);         /* mov [bp-0xc4], ax */
            ii(0x15_767e, 3); mov(ax, memw_a16[ss, bp - 0x4c]);         /* mov ax, [bp-0x4c] */
            ii(0x15_7681, 3); mov(dx, memw_a16[ss, bp - 0x4a]);         /* mov dx, [bp-0x4a] */
            ii(0x15_7684, 4); mov(memw_a16[ss, bp - 0x86], ax);         /* mov [bp-0x86], ax */
            ii(0x15_7688, 4); mov(memw_a16[ss, bp - 0x84], dx);         /* mov [bp-0x84], dx */
            ii(0x15_768c, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_768f, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_7692, 4); mov(memw_a16[ss, bp - 0x82], ax);         /* mov [bp-0x82], ax */
            ii(0x15_7696, 3); mov(memw_a16[ss, bp - 0x80], dx);         /* mov [bp-0x80], dx */
            ii(0x15_7699, 3); pushw(memw_a16[ss, bp - 0x4a]);           /* push word [bp-0x4a] */
            ii(0x15_769c, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_769f, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x15_76a2, 1); nop();                                    /* nop */
            ii(0x15_76a3, 1); pushw(cs);                                /* push cs */
            ii(0x15_76a4, 3); callw(0x15_789c, 0x1f5);                  /* call 0x789c */
            ii(0x15_76a7, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_76aa, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_76ae, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x15_76b1, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x15_76b4, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_76b7, 1); nop();                                    /* nop */
            ii(0x15_76b8, 1); pushw(cs);                                /* push cs */
            ii(0x15_76b9, 3); callw(0x15_789c, 0x1e0);                  /* call 0x789c */
            ii(0x15_76bc, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_76bf, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_76c3, 4); mov(ax, memw_a16[ss, bp - 0xda]);         /* mov ax, [bp-0xda] */
            ii(0x15_76c7, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_76ca, 4); mov(ax, memw_a16[ss, bp - 0xd6]);         /* mov ax, [bp-0xd6] */
            ii(0x15_76ce, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_76d1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_76d3, 3); mov(memw_a16[ss, bp - 0x4a], ax);         /* mov [bp-0x4a], ax */
            ii(0x15_76d6, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x15_76d9, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_76db, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x15_76de, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_76e1, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_76e4, 1); pushw(ss);                                /* push ss */
            ii(0x15_76e5, 1); pushw(ax);                                /* push ax */
            ii(0x15_76e6, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_76e9, 3); callw(0x15_61c1, -0x152b);                /* call 0x61c1 */
            ii(0x15_76ec, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_76ef, 5); sub(memw_a16[ds, 0x1274], 0x2);           /* sub word [0x1274], 0x2 */
            ii(0x15_76f4, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x15_76f7, 4); cmp(memw_a16[ss, bp - 0xda], ax);         /* cmp [bp-0xda], ax */
            ii(0x15_76fb, 2); if(jzw(0x15_7700, 0x3)) goto l_0x15_7700; /* jz 0x7700 */
            ii(0x15_76fd, 3); jmpw(0x15_7715, 0x15); goto l_0x15_7715;  /* jmp 0x7715 */
        l_0x15_7700:
            ii(0x15_7700, 4); mov(ax, memw_a16[ss, bp - 0xc8]);         /* mov ax, [bp-0xc8] */
            ii(0x15_7704, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x15_7707, 4); mov(ax, memw_a16[ss, bp - 0x86]);         /* mov ax, [bp-0x86] */
            ii(0x15_770b, 4); mov(dx, memw_a16[ss, bp - 0x84]);         /* mov dx, [bp-0x84] */
            ii(0x15_770f, 3); add(memw_a16[ss, bp - 0x4c], ax);         /* add [bp-0x4c], ax */
            ii(0x15_7712, 3); adc(memw_a16[ss, bp - 0x4a], dx);         /* adc [bp-0x4a], dx */
        l_0x15_7715:
            ii(0x15_7715, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_7718, 4); cmp(memw_a16[ss, bp - 0xd6], ax);         /* cmp [bp-0xd6], ax */
            ii(0x15_771c, 2); if(jzw(0x15_7721, 0x3)) goto l_0x15_7721; /* jz 0x7721 */
            ii(0x15_771e, 3); jmpw(0x15_7735, 0x14); goto l_0x15_7735;  /* jmp 0x7735 */
        l_0x15_7721:
            ii(0x15_7721, 4); mov(ax, memw_a16[ss, bp - 0xc4]);         /* mov ax, [bp-0xc4] */
            ii(0x15_7725, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_7728, 4); mov(ax, memw_a16[ss, bp - 0x82]);         /* mov ax, [bp-0x82] */
            ii(0x15_772c, 3); mov(dx, memw_a16[ss, bp - 0x80]);         /* mov dx, [bp-0x80] */
            ii(0x15_772f, 3); add(memw_a16[ss, bp - 0x50], ax);         /* add [bp-0x50], ax */
            ii(0x15_7732, 3); adc(memw_a16[ss, bp - 0x4e], dx);         /* adc [bp-0x4e], dx */
        l_0x15_7735:
            ii(0x15_7735, 3); jmpw(0x15_7817, 0xdf); goto l_0x15_7817;  /* jmp 0x7817 */
        l_0x15_7738:
            ii(0x15_7738, 3); jmpw(0x15_633b, -0x1400); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_773b:
            ii(0x15_773b, 3); jmpw(0x15_7743, 0x5); goto l_0x15_7743;   /* jmp 0x7743 */
        //    ii(0x15_773e, 5); mov(memw_a16[ss, bp - 0x2], 0x40);        /* mov word [bp-0x2], 0x40 */
        l_0x15_7743:
            ii(0x15_7743, 3); jmpw(0x15_633b, -0x140b); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_7746:
            ii(0x15_7746, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x15_7749, 3); mov(dx, memw_a16[ss, bp - 0x14]);         /* mov dx, [bp-0x14] */
            ii(0x15_774c, 3); and(ax, memw_a16[ss, bp - 0x50]);         /* and ax, [bp-0x50] */
            ii(0x15_774f, 3); and(dx, memw_a16[ss, bp - 0x4e]);         /* and dx, [bp-0x4e] */
            ii(0x15_7752, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_7754, 2); if(jnzw(0x15_7759, 0x3)) goto l_0x15_7759; /* jnz 0x7759 */
            ii(0x15_7756, 3); jmpw(0x15_77cf, 0x76); goto l_0x15_77cf;  /* jmp 0x77cf */
        l_0x15_7759:
            ii(0x15_7759, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_775c, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_7760, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_7763, 3); mov(dx, memw_a16[ss, bp - 0x4e]);         /* mov dx, [bp-0x4e] */
            ii(0x15_7766, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_776a, 4); mov(memw_a16[ss, bp - 0xd4], dx);         /* mov [bp-0xd4], dx */
            ii(0x15_776e, 3); pushw(memw_a16[ss, bp - 0x4e]);           /* push word [bp-0x4e] */
            ii(0x15_7771, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x15_7774, 3); pushw(memw_a16[ss, bp - 0x56]);           /* push word [bp-0x56] */
            ii(0x15_7777, 1); nop();                                    /* nop */
            ii(0x15_7778, 1); pushw(cs);                                /* push cs */
            ii(0x15_7779, 3); callw(0x15_789c, 0x120);                  /* call 0x789c */
            ii(0x15_777c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_777f, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x15_7783, 4); mov(ax, memw_a16[ss, bp - 0xe2]);         /* mov ax, [bp-0xe2] */
            ii(0x15_7787, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x15_778a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_778c, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x15_778f, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_7792, 3); lea(ax, bp - 0x5c);                       /* lea ax, [bp-0x5c] */
            ii(0x15_7795, 1); pushw(ss);                                /* push ss */
            ii(0x15_7796, 1); pushw(ax);                                /* push ax */
            ii(0x15_7797, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_779a, 3); callw(0x15_61c1, -0x15dc);                /* call 0x61c1 */
            ii(0x15_779d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_77a0, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x15_77a4, 3); mov(ax, memw_a16[ss, bp - 0x56]);         /* mov ax, [bp-0x56] */
            ii(0x15_77a7, 4); cmp(memw_a16[ss, bp - 0xe2], ax);         /* cmp [bp-0xe2], ax */
            ii(0x15_77ab, 2); if(jzw(0x15_77b0, 0x3)) goto l_0x15_77b0; /* jz 0x77b0 */
            ii(0x15_77ad, 3); jmpw(0x15_77b7, 0x7); goto l_0x15_77b7;   /* jmp 0x77b7 */
        l_0x15_77b0:
            ii(0x15_77b0, 4); mov(ax, memw_a16[ss, bp - 0xda]);         /* mov ax, [bp-0xda] */
            ii(0x15_77b4, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
        l_0x15_77b7:
            ii(0x15_77b7, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x15_77ba, 1); cwd();                                    /* cwd */
            ii(0x15_77bb, 4); add(ax, memw_a16[ss, bp - 0xd6]);         /* add ax, [bp-0xd6] */
            ii(0x15_77bf, 4); adc(dx, memw_a16[ss, bp - 0xd4]);         /* adc dx, [bp-0xd4] */
            ii(0x15_77c3, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x15_77c6, 3); mov(memw_a16[ss, bp - 0x4e], dx);         /* mov [bp-0x4e], dx */
            ii(0x15_77c9, 3); jmpw(0x15_7817, 0x4b); goto l_0x15_7817;  /* jmp 0x7817 */
        //    ii(0x15_77cc, 3); jmpw(0x15_77d2, 0x3); goto l_0x15_77d2;   /* jmp 0x77d2 */
        l_0x15_77cf:
            ii(0x15_77cf, 3); jmpw(0x15_633b, -0x1497); goto l_0x15_633b; /* jmp 0x633b */
        l_0x15_77d2:
            ii(0x15_77d2, 3); jmpw(0x15_7817, 0x42); goto l_0x15_7817;  /* jmp 0x7817 */
        l_0x15_77d5:
            ii(0x15_77d5, 3); cmp(ax, 0x18);                            /* cmp ax, 0x18 */
            ii(0x15_77d8, 2); if(jbew(0x15_77dd, 0x3)) goto l_0x15_77dd; /* jbe 0x77dd */
            ii(0x15_77da, 3); jmpw(0x15_7817, 0x3a); goto l_0x15_7817;  /* jmp 0x7817 */
        l_0x15_77dd:
            ii(0x15_77dd, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_77df, 1); xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x15_77e0, 5); 
            switch (jmpw_abs_switch(memw_a16[cs, bx + 0x23c5]))
            {
                case 0x15_633b:
                    goto l_0x15_633b;
                case 0x15_634c:
                    goto l_0x15_634c;
                case 0x15_6430:
                    goto l_0x15_6430;
                case 0x15_6442:
                    goto l_0x15_6442;
                case 0x15_64c5:
                    goto l_0x15_64c5;
                case 0x15_655f:
                    goto l_0x15_655f;
                case 0x15_6923:
                    goto l_0x15_6923;
                case 0x15_6969:
                    goto l_0x15_6969;
                case 0x15_6a4d:
                    goto l_0x15_6a4d;
                case 0x15_6a5a:
                    goto l_0x15_6a5a;
                case 0x15_6b6f:
                    goto l_0x15_6b6f;
                case 0x15_6b8f:
                    goto l_0x15_6b8f;
                case 0x15_6d0e:
                    goto l_0x15_6d0e;
                case 0x15_6d4f:
                    goto l_0x15_6d4f;
                case 0x15_6e21:
                    goto l_0x15_6e21;
                case 0x15_6f54:
                    goto l_0x15_6f54;
                case 0x15_7203:
                    goto l_0x15_7203;
                case 0x15_7417:
                    goto l_0x15_7417;
                case 0x15_7428:
                    goto l_0x15_7428;
                case 0x15_751e:
                    goto l_0x15_751e;
                case 0x15_75aa:
                    goto l_0x15_75aa;
                case 0x15_75ca:
                    goto l_0x15_75ca;
                case 0x15_7602:
                    goto l_0x15_7602;
                case 0x15_773b:
                    goto l_0x15_773b;
                case 0x15_7746:
                    goto l_0x15_7746;
                default:
                    throw new NotImplementedException();
            } /* jmp word [cs:bx+0x23c5] */
        //    ii(0x15_77e5, 50); /* Служебная область с абсолютными адресами переходов. {0x15_633b, 0x15_6442, 0x15_6430, 0x15_64c5, 0x15_655f, 0x15_6923, 0x15_6969, 0x15_6a4d, 0x15_6a5a, 0x15_6b6f, 0x15_6b8f, 0x15_6d0e, 0x15_6d4f, 0x15_6e21, 0x15_6f54, 0x15_7203, 0x15_7417, 0x15_7428, 0x15_751e, 0x15_75aa, 0x15_75ca, 0x15_7602, 0x15_773b, 0x15_7746, 0x15_634c}. */
        l_0x15_7817:
            ii(0x15_7817, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x15_781a, 3); or(ax, memw_a16[ss, bp - 0x16]);          /* or ax, [bp-0x16] */
            ii(0x15_781d, 2); if(jnzw(0x15_7822, 0x3)) goto l_0x15_7822; /* jnz 0x7822 */
            ii(0x15_781f, 3); jmpw(0x15_7839, 0x17); goto l_0x15_7839;  /* jmp 0x7839 */
        l_0x15_7822:
            ii(0x15_7822, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x15_7826, 2); if(jnzw(0x15_782b, 0x3)) goto l_0x15_782b; /* jnz 0x782b */
            ii(0x15_7828, 3); jmpw(0x15_7839, 0xe); goto l_0x15_7839;   /* jmp 0x7839 */
        l_0x15_782b:
            ii(0x15_782b, 3); mov(ax, memw_a16[ss, bp - 0x34]);         /* mov ax, [bp-0x34] */
            ii(0x15_782e, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x15_7831, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x15_7836, 3); jmpw(0x15_7880, 0x47); goto l_0x15_7880;  /* jmp 0x7880 */
        l_0x15_7839:
            ii(0x15_7839, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x15_783c, 3); or(ax, memw_a16[ss, bp - 0x16]);          /* or ax, [bp-0x16] */
            ii(0x15_783f, 2); if(jnzw(0x15_7844, 0x3)) goto l_0x15_7844; /* jnz 0x7844 */
            ii(0x15_7841, 3); jmpw(0x15_7880, 0x3c); goto l_0x15_7880;  /* jmp 0x7880 */
        l_0x15_7844:
            ii(0x15_7844, 3); lea(ax, bp - 0x34);                       /* lea ax, [bp-0x34] */
            ii(0x15_7847, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x15_784b, 4); mov(memw_a16[ss, bp - 0xe0], ss);         /* mov [bp-0xe0], ss */
        l_0x15_784f:
            ii(0x15_784f, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x15_7853, 2); if(jnzw(0x15_7858, 0x3)) goto l_0x15_7858; /* jnz 0x7858 */
            ii(0x15_7855, 3); jmpw(0x15_7880, 0x28); goto l_0x15_7880;  /* jmp 0x7880 */
        l_0x15_7858:
            ii(0x15_7858, 4); test(memb_a16[ss, bp - 0x2], 0x1);        /* test byte [bp-0x2], 0x1 */
            ii(0x15_785c, 2); if(jnzw(0x15_7861, 0x3)) goto l_0x15_7861; /* jnz 0x7861 */
            ii(0x15_785e, 3); jmpw(0x15_7875, 0x14); goto l_0x15_7875;  /* jmp 0x7875 */
        l_0x15_7861:
            ii(0x15_7861, 4); les(bx, ss, bp - 0xe2);                   /* les bx, [bp-0xe2] */
            ii(0x15_7865, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_7868, 4); les(bx, ss, bp - 0xe2);                   /* les bx, [bp-0xe2] */
            ii(0x15_786c, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_786f, 6); mov(memw_a16[es, bx + 0x2], 0);           /* mov word [es:bx+0x2], 0x0 */
        l_0x15_7875:
            ii(0x15_7875, 5); sub(memw_a16[ss, bp - 0xe2], 0x4);        /* sub word [bp-0xe2], 0x4 */
            ii(0x15_787a, 3); shr(memw_a16[ss, bp - 0x2], 0x1);         /* shr word [bp-0x2], 1 */
            ii(0x15_787d, 3); jmpw(0x15_784f, -0x31); goto l_0x15_784f; /* jmp 0x784f */
        l_0x15_7880:
            ii(0x15_7880, 1); pushw(ds);                                /* push ds */
            ii(0x15_7881, 3); lea(si, bp - 0x5c);                       /* lea si, [bp-0x5c] */
            ii(0x15_7884, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x15_7886, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_7888, 3); les(di, ss, bp + 0x8);                    /* les di, [bp+0x8] */
            ii(0x15_788b, 3); mov(cx, 0x1f);                            /* mov cx, 0x1f */
            ii(0x15_788e, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x15_7890, 1); popw(ds);                                 /* pop ds */
            ii(0x15_7891, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_7894, 3); jmpw(0x15_7897, 0); goto l_0x15_7897;     /* jmp 0x7897 */
        l_0x15_7897:
            ii(0x15_7897, 1); popw(ds);                                 /* pop ds */
            ii(0x15_7898, 1); popw(si);                                 /* pop si */
            ii(0x15_7899, 1); popw(di);                                 /* pop di */
            ii(0x15_789a, 1); leavew();                                 /* leave */
            ii(0x15_789b, 1); retfw(); return;                          /* retf */
        }
    }
}
