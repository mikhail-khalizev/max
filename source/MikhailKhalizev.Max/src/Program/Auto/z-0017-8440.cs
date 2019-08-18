using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8440-9124a6c0")]
        public void Method_0017_8440()
        {
            ii(0x17_8440, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x17_8444, 1); pushw(di);                                /* push di */
            ii(0x17_8445, 1); pushw(si);                                /* push si */
            ii(0x17_8446, 1); pushw(ds);                                /* push ds */
            ii(0x17_8447, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_844a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_844c, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x17_8451, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_8454, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_8457, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_8459, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_845b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_845d, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_845f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8461, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8463, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8465, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8467, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8469, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_846b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_846d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_846f, 1); pushw(dx);                                /* push dx */
            ii(0x17_8470, 1); pushw(ax);                                /* push ax */
            ii(0x17_8471, 1); pushw(cs);                                /* push cs */
            ii(0x17_8472, 3); callw(0x17_8988, 0x513);                  /* call 0x8988 */
            ii(0x17_8475, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_8478, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x17_847b, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x17_847f, 2); if(jnzw(0x17_8496, 0x15)) goto l_0x17_8496; /* jnz 0x8496 */
            ii(0x17_8481, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_8484, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_8487, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_848a, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_848d, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_8490, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_8493, 2); jmpw(0x17_84db, 0x46); goto l_0x17_84db;  /* jmp 0x84db */
        //    ii(0x17_8495, 1); nop();                                    /* nop */
        l_0x17_8496:
            ii(0x17_8496, 4); cmp(memw_a16[ss, bp + 0x14], 0);          /* cmp word [bp+0x14], 0x0 */
            ii(0x17_849a, 2); if(jzw(0x17_84c4, 0x28)) goto l_0x17_84c4; /* jz 0x84c4 */
            ii(0x17_849c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_849f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_84a2, 3); callw(0x17_8f06, 0xa61);                  /* call 0x8f06 */
            ii(0x17_84a5, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_84a8, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_84ab, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x17_84ae, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_84b1, 2); if(jnzw(0x17_84c1, 0xe)) goto l_0x17_84c1; /* jnz 0x84c1 */
            ii(0x17_84b3, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_84b5, 2); if(jnzw(0x17_84c1, 0xa)) goto l_0x17_84c1; /* jnz 0x84c1 */
            ii(0x17_84b7, 1); pushw(cs);                                /* push cs */
            ii(0x17_84b8, 3); callw(0x17_8b1e, 0x663);                  /* call 0x8b1e */
            ii(0x17_84bb, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_84be, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
        l_0x17_84c1:
            ii(0x17_84c1, 2); jmpw(0x17_84db, 0x18); goto l_0x17_84db;  /* jmp 0x84db */
        //    ii(0x17_84c3, 1); nop();                                    /* nop */
        l_0x17_84c4:
            ii(0x17_84c4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_84c7, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_84ca, 3); or(dh, 0x80);                             /* or dh, 0x80 */
            ii(0x17_84cd, 1); pushw(dx);                                /* push dx */
            ii(0x17_84ce, 1); pushw(ax);                                /* push ax */
            ii(0x17_84cf, 3); callw(0x17_8f06, 0xa34);                  /* call 0x8f06 */
            ii(0x17_84d2, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_84d5, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x17_84d8, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
        l_0x17_84db:
            ii(0x17_84db, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_84de, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_84e1, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x17_84e5, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x17_84e9, 3); callw(0x17_9208, 0xd1c);                  /* call 0x9208 */
            ii(0x17_84ec, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_84ef, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_84f2, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_84f5, 4); cmp(memw_a16[ss, bp + 0x14], 0);          /* cmp word [bp+0x14], 0x0 */
            ii(0x17_84f9, 2); if(jnzw(0x17_84fe, 0x3)) goto l_0x17_84fe; /* jnz 0x84fe */
            ii(0x17_84fb, 3); jmpw(0x17_86a0, 0x1a2); goto l_0x17_86a0; /* jmp 0x86a0 */
        l_0x17_84fe:
            ii(0x17_84fe, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_8501, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_8504, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_8507, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_850a, 1); pushw(ds);                                /* push ds */
            ii(0x17_850b, 3); pushw(0xa52);                             /* push 0xa52 */
            ii(0x17_850e, 1); nop();                                    /* nop */
            ii(0x17_850f, 1); pushw(cs);                                /* push cs */
            ii(0x17_8510, 3); callw(0x17_104f, -0x74c4);                /* call 0x104f */
            ii(0x17_8513, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_8516, 1); pushw(ds);                                /* push ds */
            ii(0x17_8517, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_851a, 4); les(di, ds, 0x4f80);                      /* les di, [0x4f80] */
            ii(0x17_851e, 4); lds(si, ds, 0x4fb8);                      /* lds si, [0x4fb8] */
            ii(0x17_8522, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x17_8525, 1); popw(ds);                                 /* pop ds */
            ii(0x17_8526, 4); and(memb_a16[ss, bp - 0x5], 0x7f);        /* and byte [bp-0x5], 0x7f */
            ii(0x17_852a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_852d, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_8530, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_8533, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_8536, 1); pushw(dx);                                /* push dx */
            ii(0x17_8537, 1); pushw(ax);                                /* push ax */
            ii(0x17_8538, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_853c, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_8540, 3); callw(0x17_9208, 0xcc5);                  /* call 0x9208 */
            ii(0x17_8543, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_8546, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_8549, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x17_854c, 4); test(memb_a16[ss, bp + 0x16], 0x40);      /* test byte [bp+0x16], 0x40 */
            ii(0x17_8550, 2); if(jnzw(0x17_8567, 0x15)) goto l_0x17_8567; /* jnz 0x8567 */
            ii(0x17_8552, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_8555, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_8558, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_855a, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x17_855d, 2); if(jnzw(0x17_8567, 0x8)) goto l_0x17_8567; /* jnz 0x8567 */
            ii(0x17_855f, 3); cmp(dx, memw_a16[ss, bp + 0x8]);          /* cmp dx, [bp+0x8] */
            ii(0x17_8562, 2); if(jnzw(0x17_8567, 0x3)) goto l_0x17_8567; /* jnz 0x8567 */
            ii(0x17_8564, 3); jmpw(0x17_8660, 0xf9); goto l_0x17_8660;  /* jmp 0x8660 */
        l_0x17_8567:
            ii(0x17_8567, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_856b, 3); inc(memb_a16[es, bx]);                    /* inc byte [es:bx] */
            ii(0x17_856e, 1); pushw(cs);                                /* push cs */
            ii(0x17_856f, 3); callw(0x17_8d64, 0x7f2);                  /* call 0x8d64 */
            ii(0x17_8572, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_8577, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_857a, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_857d, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_857f, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_8581, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_8583, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_8585, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8587, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8589, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_858b, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_858d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_858f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8591, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8593, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8595, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x17_8599, 3); cmp(ax, memw_a16[es, bx]);                /* cmp ax, [es:bx] */
            ii(0x17_859c, 2); if(jnzw(0x17_85a4, 0x6)) goto l_0x17_85a4; /* jnz 0x85a4 */
            ii(0x17_859e, 4); cmp(dx, memw_a16[es, bx + 0x2]);          /* cmp dx, [es:bx+0x2] */
            ii(0x17_85a2, 2); if(jzw(0x17_85c2, 0x1e)) goto l_0x17_85c2; /* jz 0x85c2 */
        l_0x17_85a4:
            ii(0x17_85a4, 1); pushw(dx);                                /* push dx */
            ii(0x17_85a5, 1); pushw(ax);                                /* push ax */
            ii(0x17_85a6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_85a8, 1); pushw(cs);                                /* push cs */
            ii(0x17_85a9, 3); callw(0x17_89ec, 0x440);                  /* call 0x89ec */
            ii(0x17_85ac, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_85af, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_85b1, 2); if(jzw(0x17_85c2, 0xf)) goto l_0x17_85c2; /* jz 0x85c2 */
            ii(0x17_85b3, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_85b5, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x17_85b7, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x17_85ba, 1); nop();                                    /* nop */
            ii(0x17_85bb, 1); pushw(cs);                                /* push cs */
            ii(0x17_85bc, 3); callw(0x17_75b4, -0x100b);                /* call 0x75b4 */
            ii(0x17_85bf, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x17_85c2:
            ii(0x17_85c2, 1); pushw(ds);                                /* push ds */
            ii(0x17_85c3, 3); pushw(0xa65);                             /* push 0xa65 */
            ii(0x17_85c6, 1); nop();                                    /* nop */
            ii(0x17_85c7, 1); pushw(cs);                                /* push cs */
            ii(0x17_85c8, 3); callw(0x17_104f, -0x757c);                /* call 0x104f */
            ii(0x17_85cb, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_85ce, 4); pushw(memw_a16[ds, 0x4f82]);              /* push word [0x4f82] */
            ii(0x17_85d2, 4); pushw(memw_a16[ds, 0x4f80]);              /* push word [0x4f80] */
            ii(0x17_85d6, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_85d9, 1); pushw(cs);                                /* push cs */
            ii(0x17_85da, 3); callw(0x17_8a4a, 0x46d);                  /* call 0x8a4a */
            ii(0x17_85dd, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_85e0, 3); cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x17_85e3, 2); if(jnzw(0x17_85e9, 0x4)) goto l_0x17_85e9; /* jnz 0x85e9 */
            ii(0x17_85e5, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_85e7, 2); if(jzw(0x17_85f8, 0xf)) goto l_0x17_85f8; /* jz 0x85f8 */
        l_0x17_85e9:
            ii(0x17_85e9, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_85eb, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x17_85ed, 3); pushw(0x922);                             /* push 0x922 */
            ii(0x17_85f0, 1); nop();                                    /* nop */
            ii(0x17_85f1, 1); pushw(cs);                                /* push cs */
            ii(0x17_85f2, 3); callw(0x17_75b4, -0x1041);                /* call 0x75b4 */
            ii(0x17_85f5, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x17_85f8:
            ii(0x17_85f8, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_85fb, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_85fe, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_8601, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_8604, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_8606, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_8608, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_860a, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_860c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_860e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8610, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8612, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8614, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8616, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8618, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_861a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_861c, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x17_861f, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x17_8621, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_8623, 2); add(bx, cx);                              /* add bx, cx */
            ii(0x17_8625, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_8627, 4); les(si, ds, 0x1f60);                      /* les si, [0x1f60] */
            ii(0x17_862b, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x17_862e, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x17_8632, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_8636, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x17_8639, 4); or(memb_a16[ss, bp - 0x5], -0x80 /* 0x80 */); /* or byte [bp-0x5], 0x80 */
            ii(0x17_863d, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_8640, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_8643, 3); xor(ax, memw_a16[ss, bp + 0x6]);          /* xor ax, [bp+0x6] */
            ii(0x17_8646, 3); xor(dx, memw_a16[ss, bp + 0x8]);          /* xor dx, [bp+0x8] */
            ii(0x17_8649, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_864b, 3); xor(memw_a16[ss, bp - 0x8], ax);          /* xor [bp-0x8], ax */
            ii(0x17_864e, 3); xor(memw_a16[ss, bp - 0x6], dx);          /* xor [bp-0x6], dx */
            ii(0x17_8651, 1); pushw(ds);                                /* push ds */
            ii(0x17_8652, 3); pushw(0xa6d);                             /* push 0xa6d */
            ii(0x17_8655, 1); nop();                                    /* nop */
            ii(0x17_8656, 1); pushw(cs);                                /* push cs */
            ii(0x17_8657, 3); callw(0x17_104f, -0x760b);                /* call 0x104f */
            ii(0x17_865a, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_865d, 2); jmpw(0x17_8670, 0x11); goto l_0x17_8670;  /* jmp 0x8670 */
        //    ii(0x17_865f, 1); nop();                                    /* nop */
        l_0x17_8660:
            ii(0x17_8660, 4); or(memb_a16[ss, bp - 0x5], -0x80 /* 0x80 */); /* or byte [bp-0x5], 0x80 */
            ii(0x17_8664, 1); pushw(ds);                                /* push ds */
            ii(0x17_8665, 3); pushw(0xa75);                             /* push 0xa75 */
            ii(0x17_8668, 1); nop();                                    /* nop */
            ii(0x17_8669, 1); pushw(cs);                                /* push cs */
            ii(0x17_866a, 3); callw(0x17_104f, -0x761e);                /* call 0x104f */
            ii(0x17_866d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x17_8670:
            ii(0x17_8670, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_8673, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_8676, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_8679, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_867c, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x17_8680, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x17_8684, 3); callw(0x17_9235, 0xbae);                  /* call 0x9235 */
            ii(0x17_8687, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_868a, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_868d, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_8690, 1); pushw(ds);                                /* push ds */
            ii(0x17_8691, 3); pushw(0xa81);                             /* push 0xa81 */
            ii(0x17_8694, 1); nop();                                    /* nop */
            ii(0x17_8695, 1); pushw(cs);                                /* push cs */
            ii(0x17_8696, 3); callw(0x17_104f, -0x764a);                /* call 0x104f */
            ii(0x17_8699, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_869c, 3); jmpw(0x17_8869, 0x1ca); goto l_0x17_8869; /* jmp 0x8869 */
        //    ii(0x17_869f, 1); nop();                                    /* nop */
        l_0x17_86a0:
            ii(0x17_86a0, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_86a3, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_86a6, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_86a9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_86ac, 1); pushw(ds);                                /* push ds */
            ii(0x17_86ad, 3); pushw(0xa84);                             /* push 0xa84 */
            ii(0x17_86b0, 1); nop();                                    /* nop */
            ii(0x17_86b1, 1); pushw(cs);                                /* push cs */
            ii(0x17_86b2, 3); callw(0x17_104f, -0x7666);                /* call 0x104f */
            ii(0x17_86b5, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_86b8, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x17_86bb, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x17_86be, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_86c0, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x17_86c3, 2); if(jnzw(0x17_86ca, 0x5)) goto l_0x17_86ca; /* jnz 0x86ca */
            ii(0x17_86c5, 3); cmp(dx, memw_a16[ss, bp + 0x8]);          /* cmp dx, [bp+0x8] */
            ii(0x17_86c8, 2); if(jzw(0x17_86e6, 0x1c)) goto l_0x17_86e6; /* jz 0x86e6 */
        l_0x17_86ca:
            ii(0x17_86ca, 4); les(di, ds, 0x4fb8);                      /* les di, [0x4fb8] */
            ii(0x17_86ce, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_86d0, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_86d3, 3); rep_a16(() => stosd_a16());               /* rep stosd */
            ii(0x17_86d6, 1); pushw(ds);                                /* push ds */
            ii(0x17_86d7, 3); pushw(0xa97);                             /* push 0xa97 */
            ii(0x17_86da, 1); nop();                                    /* nop */
            ii(0x17_86db, 1); pushw(cs);                                /* push cs */
            ii(0x17_86dc, 3); callw(0x17_104f, -0x7690);                /* call 0x104f */
            ii(0x17_86df, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_86e2, 3); jmpw(0x17_8869, 0x184); goto l_0x17_8869; /* jmp 0x8869 */
        //    ii(0x17_86e5, 1); nop();                                    /* nop */
        l_0x17_86e6:
            ii(0x17_86e6, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_86ea, 3); inc(memb_a16[es, bx]);                    /* inc byte [es:bx] */
            ii(0x17_86ed, 1); pushw(cs);                                /* push cs */
            ii(0x17_86ee, 3); callw(0x17_8d64, 0x673);                  /* call 0x8d64 */
            ii(0x17_86f1, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_86f6, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_86f9, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_86fc, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_86fe, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_8700, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_8702, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_8704, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8706, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8708, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_870a, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_870c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_870e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8710, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8712, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8714, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x17_8718, 3); cmp(ax, memw_a16[es, bx]);                /* cmp ax, [es:bx] */
            ii(0x17_871b, 2); if(jnzw(0x17_8723, 0x6)) goto l_0x17_8723; /* jnz 0x8723 */
            ii(0x17_871d, 4); cmp(dx, memw_a16[es, bx + 0x2]);          /* cmp dx, [es:bx+0x2] */
            ii(0x17_8721, 2); if(jzw(0x17_8741, 0x1e)) goto l_0x17_8741; /* jz 0x8741 */
        l_0x17_8723:
            ii(0x17_8723, 1); pushw(dx);                                /* push dx */
            ii(0x17_8724, 1); pushw(ax);                                /* push ax */
            ii(0x17_8725, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_8727, 1); pushw(cs);                                /* push cs */
            ii(0x17_8728, 3); callw(0x17_89ec, 0x2c1);                  /* call 0x89ec */
            ii(0x17_872b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_872e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_8730, 2); if(jzw(0x17_8741, 0xf)) goto l_0x17_8741; /* jz 0x8741 */
            ii(0x17_8732, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_8734, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x17_8736, 3); pushw(0x926);                             /* push 0x926 */
            ii(0x17_8739, 1); nop();                                    /* nop */
            ii(0x17_873a, 1); pushw(cs);                                /* push cs */
            ii(0x17_873b, 3); callw(0x17_75b4, -0x118a);                /* call 0x75b4 */
            ii(0x17_873e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x17_8741:
            ii(0x17_8741, 4); pushw(memw_a16[ds, 0x4f82]);              /* push word [0x4f82] */
            ii(0x17_8745, 4); pushw(memw_a16[ds, 0x4f80]);              /* push word [0x4f80] */
            ii(0x17_8749, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_874c, 1); pushw(cs);                                /* push cs */
            ii(0x17_874d, 3); callw(0x17_8ab4, 0x364);                  /* call 0x8ab4 */
            ii(0x17_8750, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_8753, 3); cmp(ax, 0x1000);                          /* cmp ax, 0x1000 */
            ii(0x17_8756, 2); if(jnzw(0x17_875c, 0x4)) goto l_0x17_875c; /* jnz 0x875c */
            ii(0x17_8758, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_875a, 2); if(jzw(0x17_876b, 0xf)) goto l_0x17_876b; /* jz 0x876b */
        l_0x17_875c:
            ii(0x17_875c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_875e, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x17_8760, 3); pushw(0x926);                             /* push 0x926 */
            ii(0x17_8763, 1); nop();                                    /* nop */
            ii(0x17_8764, 1); pushw(cs);                                /* push cs */
            ii(0x17_8765, 3); callw(0x17_75b4, -0x11b4);                /* call 0x75b4 */
            ii(0x17_8768, 3); add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x17_876b:
            ii(0x17_876b, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_876e, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_8771, 3); add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x17_8774, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_8777, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_8779, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_877b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_877d, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_877f, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8781, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8783, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8785, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_8787, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_8789, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_878b, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_878d, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_878f, 3); mov(bx, memw_a16[ss, bp - 0x4]);          /* mov bx, [bp-0x4] */
            ii(0x17_8792, 2); mov(cx, bx);                              /* mov cx, bx */
            ii(0x17_8794, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_8796, 2); add(bx, cx);                              /* add bx, cx */
            ii(0x17_8798, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_879a, 4); les(si, ds, 0x1f60);                      /* les si, [0x1f60] */
            ii(0x17_879e, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x17_87a1, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x17_87a5, 4); les(bx, ds, 0x1efc);                      /* les bx, [0x1efc] */
            ii(0x17_87a9, 3); dec(memb_a16[es, bx]);                    /* dec byte [es:bx] */
            ii(0x17_87ac, 1); pushw(ds);                                /* push ds */
            ii(0x17_87ad, 3); mov(cx, 0x400);                           /* mov cx, 0x400 */
            ii(0x17_87b0, 4); les(di, ds, 0x4fb8);                      /* les di, [0x4fb8] */
            ii(0x17_87b4, 4); lds(si, ds, 0x4f80);                      /* lds si, [0x4f80] */
            ii(0x17_87b8, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x17_87bb, 1); popw(ds);                                 /* pop ds */
            ii(0x17_87bc, 4); and(memb_a16[ss, bp - 0x5], 0x7f);        /* and byte [bp-0x5], 0x7f */
            ii(0x17_87c0, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x17_87c3, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_87c6, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_87c9, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_87cc, 4); pushw(memw_a16[ds, 0x4fb6]);              /* push word [0x4fb6] */
            ii(0x17_87d0, 4); pushw(memw_a16[ds, 0x4fb4]);              /* push word [0x4fb4] */
            ii(0x17_87d4, 3); callw(0x17_9235, 0xa5e);                  /* call 0x9235 */
            ii(0x17_87d7, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_87da, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_87dd, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_87e0, 1); pushw(ds);                                /* push ds */
            ii(0x17_87e1, 3); pushw(0xaa2);                             /* push 0xaa2 */
            ii(0x17_87e4, 1); nop();                                    /* nop */
            ii(0x17_87e5, 1); pushw(cs);                                /* push cs */
            ii(0x17_87e6, 3); callw(0x17_104f, -0x779a);                /* call 0x104f */
            ii(0x17_87e9, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_87ec, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_87ef, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_87f2, 3); sub(ax, 0);                               /* sub ax, 0x0 */
            ii(0x17_87f5, 3); sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x17_87f8, 1); pushw(dx);                                /* push dx */
            ii(0x17_87f9, 1); pushw(ax);                                /* push ax */
            ii(0x17_87fa, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_87fe, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_8802, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_8804, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_8806, 3); callw(0x17_9208, 0x9ff);                  /* call 0x9208 */
            ii(0x17_8809, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_880c, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x17_880f, 3); mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0x17_8812, 4); and(memb_a16[ss, bp - 0xc], -0x41 /* 0xbf */); /* and byte [bp-0xc], 0xbf */
            ii(0x17_8816, 1); pushw(dx);                                /* push dx */
            ii(0x17_8817, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_881a, 1); pushw(di);                                /* push di */
            ii(0x17_881b, 1); pushw(si);                                /* push si */
            ii(0x17_881c, 4); pushw(memw_a16[ds, 0x4f8e]);              /* push word [0x4f8e] */
            ii(0x17_8820, 4); pushw(memw_a16[ds, 0x4f8c]);              /* push word [0x4f8c] */
            ii(0x17_8824, 3); callw(0x17_9235, 0xa0e);                  /* call 0x9235 */
            ii(0x17_8827, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x17_882a, 5); cmp(memw_a16[ds, 0x984], 0);              /* cmp word [0x984], 0x0 */
            ii(0x17_882f, 2); if(jzw(0x17_8869, 0x38)) goto l_0x17_8869; /* jz 0x8869 */
            ii(0x17_8831, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_8835, 4); mov(memb_a16[es, bx], 0x31);              /* mov byte [es:bx], 0x31 */
            ii(0x17_8839, 3); mov(al, memb_a16[ds, 0x5130]);            /* mov al, [0x5130] */
            ii(0x17_883c, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_8840, 4); mov(memb_a16[es, bx + 0x1], al);          /* mov [es:bx+0x1], al */
            ii(0x17_8844, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x17_8847, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x17_884a, 4); les(bx, ds, 0x4fc4);                      /* les bx, [0x4fc4] */
            ii(0x17_884e, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x17_8852, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x17_8856, 4); pushw(memw_a16[ds, 0x5167]);              /* push word [0x5167] */
            ii(0x17_885a, 4); pushw(memw_a16[ds, 0x4fc6]);              /* push word [0x4fc6] */
            ii(0x17_885e, 4); pushw(memw_a16[ds, 0x4fc4]);              /* push word [0x4fc4] */
            ii(0x17_8862, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x17_8864, 1); nop();                                    /* nop */
            ii(0x17_8865, 1); pushw(cs);                                /* push cs */
            ii(0x17_8866, 3); callw(0x18_0864, 0x7ffb);                 /* call 0x864 */
        l_0x17_8869:
            ii(0x17_8869, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_886c, 1); pushw(ds);                                /* push ds */
            ii(0x17_886d, 3); pushw(0xaac);                             /* push 0xaac */
            ii(0x17_8870, 1); nop();                                    /* nop */
            ii(0x17_8871, 1); pushw(cs);                                /* push cs */
            ii(0x17_8872, 3); callw(0x17_104f, -0x7826);                /* call 0x104f */
            ii(0x17_8875, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_8878, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_887a, 1); popw(ds);                                 /* pop ds */
            ii(0x17_887b, 1); popw(si);                                 /* pop si */
            ii(0x17_887c, 1); popw(di);                                 /* pop di */
            ii(0x17_887d, 1); leavew();                                 /* leave */
            ii(0x17_887e, 1); retfw(); return;                          /* retf */
        //  ii(0x17_887f, 265); Недостижимый (и не декодированный) код.
        //    ii(0x17_8988, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
        //    ii(0x17_898c, 1); pushw(ds);                                /* push ds */
        //    ii(0x17_898d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
        //    ii(0x17_8990, 2); mov(ds, ax);                              /* mov ds, ax */
        //    ii(0x17_8992, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        //    ii(0x17_8995, 4); mov(bx, memw_a16[ds, 0x4fba]);            /* mov bx, [0x4fba] */
        //    ii(0x17_8999, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
        //    ii(0x17_899c, 2); mov(es, cx);                              /* mov es, cx */
        //    ii(0x17_899e, 3); mov(memw_a16[ss, bp - 0x4], bx);          /* mov [bp-0x4], bx */
        //    ii(0x17_89a1, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
        //    ii(0x17_89a4, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
        //    ii(0x17_89a8, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
        //    ii(0x17_89ab, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
        //    ii(0x17_89ae, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
        //    ii(0x17_89b2, 3); mov(al, memb_a16[ss, bp + 0x9]);          /* mov al, [bp+0x9] */
        //    ii(0x17_89b5, 4); mov(memb_a16[es, bx + 0x7], al);          /* mov [es:bx+0x7], al */
        //    ii(0x17_89b9, 1); popw(ds);                                 /* pop ds */
        //    ii(0x17_89ba, 1); leavew();                                 /* leave */
        //    ii(0x17_89bb, 1); retfw(); return;                          /* retf */
        }
    }
}
