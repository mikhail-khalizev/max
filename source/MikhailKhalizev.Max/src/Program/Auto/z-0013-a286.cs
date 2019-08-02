using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a66c22d-a185-42e2-b1cb-a40f57d05e2d")]
        public void Method_0013_a286()
        {
            ii(0x13_a286, 4); enterw(0x40, 0);                          /* enter 0x40, 0x0 */
            ii(0x13_a28a, 1); pushw(di);                                /* push di */
            ii(0x13_a28b, 1); pushw(si);                                /* push si */
            ii(0x13_a28c, 1); pushw(ds);                                /* push ds */
            ii(0x13_a28d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_a290, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_a292, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_a294, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_a297, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x13_a29a, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x13_a29d, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x13_a2a0, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a2a3, 4); mov(ax, memw_a16[es, bx + 0x14]);         /* mov ax, [es:bx+0x14] */
            ii(0x13_a2a7, 4); mov(dx, memw_a16[es, bx + 0x16]);         /* mov dx, [es:bx+0x16] */
            ii(0x13_a2ab, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_a2ae, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x13_a2b1, 4); mov(ax, memw_a16[es, bx + 0x1c]);         /* mov ax, [es:bx+0x1c] */
            ii(0x13_a2b5, 4); mov(dx, memw_a16[es, bx + 0x1e]);         /* mov dx, [es:bx+0x1e] */
            ii(0x13_a2b9, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_a2bc, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_a2bf, 6); test(memw_a16[es, bx + 0xa], 0xffff);     /* test word [es:bx+0xa], 0xffff */
            ii(0x13_a2c5, 2); if(jzw(0x13_a2d0, 0x9)) goto l_0x13_a2d0; /* jz 0xa2d0 */
            ii(0x13_a2c7, 5); mov(memw_a16[ss, bp - 0x12], 0x8023);     /* mov word [bp-0x12], 0x8023 */
            ii(0x13_a2cc, 3); jmpw(0x13_a658, 0x389); goto l_0x13_a658; /* jmp 0xa658 */
        //  ii(0x13_a2cf, 1); Недостижимый код.
l_0x13_a2d0:
            ii(0x13_a2d0, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x13_a2d4, 3); mov(memw_a16[ss, bp - 0x36], ax);         /* mov [bp-0x36], ax */
            ii(0x13_a2d7, 1); pushw(ax);                                /* push ax */
            ii(0x13_a2d8, 1); pushw(cs);                                /* push cs */
            ii(0x13_a2d9, 3); callw(0x13_c79c, 0x24c0);                 /* call 0xc79c */
            ii(0x13_a2dc, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_a2df, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x13_a2e2, 3); mov(memw_a16[ss, bp - 0x1c], dx);         /* mov [bp-0x1c], dx */
            ii(0x13_a2e5, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_a2e8, 2); if(jnzw(0x13_a2f6, 0xc)) goto l_0x13_a2f6; /* jnz 0xa2f6 */
            ii(0x13_a2ea, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_a2ec, 2); if(jnzw(0x13_a2f6, 0x8)) goto l_0x13_a2f6; /* jnz 0xa2f6 */
            ii(0x13_a2ee, 5); mov(memw_a16[ss, bp - 0x12], 0x8023);     /* mov word [bp-0x12], 0x8023 */
            ii(0x13_a2f3, 3); jmpw(0x13_a658, 0x362); goto l_0x13_a658; /* jmp 0xa658 */
        l_0x13_a2f6:
            ii(0x13_a2f6, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x13_a2f9, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x13_a2fc, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_a2fe, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_a300, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_a302, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_a304, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a306, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a308, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a30a, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a30c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a30e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a310, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a312, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a314, 3); add(memw_a16[ss, bp - 0x1e], ax);         /* add [bp-0x1e], ax */
            ii(0x13_a317, 3); adc(memw_a16[ss, bp - 0x1c], dx);         /* adc [bp-0x1c], dx */
            ii(0x13_a31a, 3); mov(ax, memw_a16[ss, bp - 0x1e]);         /* mov ax, [bp-0x1e] */
            ii(0x13_a31d, 3); mov(dx, memw_a16[ss, bp - 0x1c]);         /* mov dx, [bp-0x1c] */
            ii(0x13_a320, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x13_a323, 3); adc(dx, 0x1);                             /* adc dx, 0x1 */
            ii(0x13_a326, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_a328, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_a32a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_a32c, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_a32e, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a330, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a332, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a334, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a336, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a338, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a33a, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_a33c, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_a33e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_a341, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_a344, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a347, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_a34c, 4); pushw(memw_a16[es, bx + 0x1a]);           /* push word [es:bx+0x1a] */
            ii(0x13_a350, 4); pushw(memw_a16[es, bx + 0x18]);           /* push word [es:bx+0x18] */
            ii(0x13_a354, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x13_a358, 1); nop();                                    /* nop */
            ii(0x13_a359, 1); pushw(cs);                                /* push cs */
            ii(0x13_a35a, 3); callw(0x13_4860, -0x5afd);                /* call 0x4860 */
            ii(0x13_a35d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_a360, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x13_a362, 3); mov(memw_a16[ss, bp - 0x32], cx);         /* mov [bp-0x32], cx */
            ii(0x13_a365, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x13_a368, 3); mov(memw_a16[ss, bp - 0x22], cx);         /* mov [bp-0x22], cx */
            ii(0x13_a36b, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x13_a36e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_a370, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x13_a373, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x13_a376, 2); jmpw(0x13_a380, 0x8); goto l_0x13_a380;   /* jmp 0xa380 */
        l_0x13_a378:
            ii(0x13_a378, 4); add(memw_a16[ss, bp - 0x2a], 0x1);        /* add word [bp-0x2a], 0x1 */
            ii(0x13_a37c, 4); adc(memw_a16[ss, bp - 0x28], 0);          /* adc word [bp-0x28], 0x0 */
        l_0x13_a380:
            ii(0x13_a380, 3); mov(ax, memw_a16[ss, bp - 0x2a]);         /* mov ax, [bp-0x2a] */
            ii(0x13_a383, 3); mov(dx, memw_a16[ss, bp - 0x28]);         /* mov dx, [bp-0x28] */
            ii(0x13_a386, 3); cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x13_a389, 2); if(jbw(0x13_a3b8, 0x2d)) goto l_0x13_a3b8; /* jb 0xa3b8 */
            ii(0x13_a38b, 2); if(jaw(0x13_a392, 0x5)) goto l_0x13_a392; /* ja 0xa392 */
            ii(0x13_a38d, 3); cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x13_a390, 2); if(jbew(0x13_a3b8, 0x26)) goto l_0x13_a3b8; /* jbe 0xa3b8 */
        l_0x13_a392:
            ii(0x13_a392, 3); les(bx, ss, bp - 0x22);                   /* les bx, [bp-0x22] */
            ii(0x13_a395, 4); add(memw_a16[ss, bp - 0x22], 0x2);        /* add word [bp-0x22], 0x2 */
            ii(0x13_a399, 3); mov(si, memw_a16[es, bx]);                /* mov si, [es:bx] */
            ii(0x13_a39c, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_a39e, 3); and(ax, 0x3);                             /* and ax, 0x3 */
            ii(0x13_a3a1, 2); jmpw(0x13_a3b0, 0xd); goto l_0x13_a3b0;   /* jmp 0xa3b0 */
        //  ii(0x13_a3a3, 1); Недостижимый код.
l_0x13_a3a4:
            ii(0x13_a3a4, 4); add(memw_a16[ss, bp - 0xc], 0x1);         /* add word [bp-0xc], 0x1 */
            ii(0x13_a3a8, 4); adc(memw_a16[ss, bp - 0xa], 0);           /* adc word [bp-0xa], 0x0 */
            ii(0x13_a3ac, 2); jmpw(0x13_a3b6, 0x8); goto l_0x13_a3b6;   /* jmp 0xa3b6 */
        //  ii(0x13_a3ae, 2); Недостижимый код.
l_0x13_a3b0:
            ii(0x13_a3b0, 1); dec(ax);                                  /* dec ax */
            ii(0x13_a3b1, 2); if(jzw(0x13_a3a4, -0xf)) goto l_0x13_a3a4; /* jz 0xa3a4 */
            ii(0x13_a3b3, 2); jmpw(0x13_a3b6, 0x1); goto l_0x13_a3b6;   /* jmp 0xa3b6 */
        //  ii(0x13_a3b5, 1); Недостижимый код.
l_0x13_a3b6:
            ii(0x13_a3b6, 2); jmpw(0x13_a378, -0x40); goto l_0x13_a378; /* jmp 0xa378 */
        l_0x13_a3b8:
            ii(0x13_a3b8, 4); cmp(memw_a16[ss, bp - 0xa], 0);           /* cmp word [bp-0xa], 0x0 */
            ii(0x13_a3bc, 2); if(jgew(0x13_a3c1, 0x3)) goto l_0x13_a3c1; /* jge 0xa3c1 */
            ii(0x13_a3be, 3); jmpw(0x13_a450, 0x8f); goto l_0x13_a450;  /* jmp 0xa450 */
        l_0x13_a3c1:
            ii(0x13_a3c1, 2); if(jgw(0x13_a3cc, 0x9)) goto l_0x13_a3cc; /* jg 0xa3cc */
            ii(0x13_a3c3, 4); cmp(memw_a16[ss, bp - 0xc], 0);           /* cmp word [bp-0xc], 0x0 */
            ii(0x13_a3c7, 2); if(jnzw(0x13_a3cc, 0x3)) goto l_0x13_a3cc; /* jnz 0xa3cc */
            ii(0x13_a3c9, 3); jmpw(0x13_a450, 0x84); goto l_0x13_a450;  /* jmp 0xa450 */
        l_0x13_a3cc:
            ii(0x13_a3cc, 3); mov(ax, memw_a16[ds, 0x1fc4]);            /* mov ax, [0x1fc4] */
            ii(0x13_a3cf, 4); mov(dx, memw_a16[ds, 0x1fc6]);            /* mov dx, [0x1fc6] */
            ii(0x13_a3d3, 3); cmp(memw_a16[ss, bp - 0xa], dx);          /* cmp [bp-0xa], dx */
            ii(0x13_a3d6, 2); if(jlw(0x13_a3ea, 0x12)) goto l_0x13_a3ea; /* jl 0xa3ea */
            ii(0x13_a3d8, 2); if(jgw(0x13_a3df, 0x5)) goto l_0x13_a3df; /* jg 0xa3df */
            ii(0x13_a3da, 3); cmp(memw_a16[ss, bp - 0xc], ax);          /* cmp [bp-0xc], ax */
            ii(0x13_a3dd, 2); if(jbew(0x13_a3ea, 0xb)) goto l_0x13_a3ea; /* jbe 0xa3ea */
        l_0x13_a3df:
            ii(0x13_a3df, 5); mov(memw_a16[ss, bp - 0x12], 0x8016);     /* mov word [bp-0x12], 0x8016 */
            ii(0x13_a3e4, 3); jmpw(0x13_a658, 0x271); goto l_0x13_a658; /* jmp 0xa658 */
        //  ii(0x13_a3e7, 3); Недостижимый код.
l_0x13_a3ea:
            ii(0x13_a3ea, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x13_a3ed, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x13_a3f1, 2); if(jzw(0x13_a450, 0x5d)) goto l_0x13_a450; /* jz 0xa450 */
            ii(0x13_a3f3, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_a3f6, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_a3f9, 4); sub(ax, memw_a16[ds, 0x1fc4]);            /* sub ax, [0x1fc4] */
            ii(0x13_a3fd, 4); sbb(dx, memw_a16[ds, 0x1fc6]);            /* sbb dx, [0x1fc6] */
            ii(0x13_a401, 4); sub(ax, memw_a16[ds, 0x1fc0]);            /* sub ax, [0x1fc0] */
            ii(0x13_a405, 4); sbb(dx, memw_a16[ds, 0x1fc2]);            /* sbb dx, [0x1fc2] */
            ii(0x13_a409, 4); add(ax, memw_a16[ds, 0x1fb4]);            /* add ax, [0x1fb4] */
            ii(0x13_a40d, 4); adc(dx, memw_a16[ds, 0x1fb6]);            /* adc dx, [0x1fb6] */
            ii(0x13_a411, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x13_a414, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x13_a417, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x13_a41a, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x13_a41d, 4); mov(cx, memw_a16[ds, 0x1f50]);            /* mov cx, [0x1f50] */
            ii(0x13_a421, 4); mov(bx, memw_a16[ds, 0x1f52]);            /* mov bx, [0x1f52] */
            ii(0x13_a425, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x13_a427, 2); if(jlw(0x13_a450, 0x27)) goto l_0x13_a450; /* jl 0xa450 */
            ii(0x13_a429, 2); if(jgw(0x13_a42f, 0x4)) goto l_0x13_a42f; /* jg 0xa42f */
            ii(0x13_a42b, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x13_a42d, 2); if(jbew(0x13_a450, 0x21)) goto l_0x13_a450; /* jbe 0xa450 */
        l_0x13_a42f:
            ii(0x13_a42f, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x13_a431, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x13_a433, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x13_a436, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x13_a439, 1); pushw(dx);                                /* push dx */
            ii(0x13_a43a, 1); pushw(ax);                                /* push ax */
            ii(0x13_a43b, 1); nop();                                    /* nop */
            ii(0x13_a43c, 1); pushw(cs);                                /* push cs */
            ii(0x13_a43d, 3); callw(0x13_8ba6, -0x189a);                /* call 0x8ba6 */
            ii(0x13_a440, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_a443, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_a445, 2); if(jnzw(0x13_a450, 0x9)) goto l_0x13_a450; /* jnz 0xa450 */
            ii(0x13_a447, 5); mov(memw_a16[ss, bp - 0x12], 0x8014);     /* mov word [bp-0x12], 0x8014 */
            ii(0x13_a44c, 3); jmpw(0x13_a658, 0x209); goto l_0x13_a658; /* jmp 0xa658 */
        //  ii(0x13_a44f, 1); Недостижимый код.
l_0x13_a450:
            ii(0x13_a450, 3); mov(ax, memw_a16[ds, 0x4f8c]);            /* mov ax, [0x4f8c] */
            ii(0x13_a453, 4); mov(dx, memw_a16[ds, 0x4f8e]);            /* mov dx, [0x4f8e] */
            ii(0x13_a457, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x13_a45a, 3); mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x13_a45d, 3); mov(ax, memw_a16[ss, bp - 0x1e]);         /* mov ax, [bp-0x1e] */
            ii(0x13_a460, 3); mov(dx, memw_a16[ss, bp - 0x1c]);         /* mov dx, [bp-0x1c] */
            ii(0x13_a463, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x13_a466, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
        l_0x13_a469:
            ii(0x13_a469, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_a46c, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_a46f, 4); sub(memw_a16[ss, bp - 0x4], 0x1);         /* sub word [bp-0x4], 0x1 */
            ii(0x13_a473, 4); sbb(memw_a16[ss, bp - 0x2], 0);           /* sbb word [bp-0x2], 0x0 */
            ii(0x13_a477, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x13_a479, 2); if(jnzw(0x13_a482, 0x7)) goto l_0x13_a482; /* jnz 0xa482 */
            ii(0x13_a47b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_a47d, 2); if(jnzw(0x13_a482, 0x3)) goto l_0x13_a482; /* jnz 0xa482 */
            ii(0x13_a47f, 3); jmpw(0x13_a658, 0x1d6); goto l_0x13_a658; /* jmp 0xa658 */
        l_0x13_a482:
            ii(0x13_a482, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x13_a484, 4); mov(es, memw_a16[ds, 0xaa]);              /* mov es, [0xaa] */
            ii(0x13_a488, 4); mov(edi, memd_a16[ss, bp - 0x16]);        /* mov edi, [bp-0x16] */
            ii(0x13_a48c, 4); mov(ebx, memd_a16[ss, bp - 0x26]);        /* mov ebx, [bp-0x26] */
            ii(0x13_a490, 6); mov(eax, memd_a32[es, edi + ebx * 4]);    /* mov eax, [es:edi+ebx*4] */
            ii(0x13_a496, 4); mov(memd_a16[ss, bp - 0x2e], eax);        /* mov [bp-0x2e], eax */
            ii(0x13_a49a, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x13_a49c, 2); sub(di, di);                              /* sub di, di */
            ii(0x13_a49e, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_a4a1, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_a4a4, 4); pushw(memw_a16[ds, 0x4ff6]);              /* push word [0x4ff6] */
            ii(0x13_a4a8, 4); pushw(memw_a16[ds, 0x4ff4]);              /* push word [0x4ff4] */
            ii(0x13_a4ac, 3); callw(0x13_90c4, -0x13eb);                /* call 0x90c4 */
            ii(0x13_a4af, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_a4b2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_a4b4, 2); if(jnzw(0x13_a4be, 0x8)) goto l_0x13_a4be; /* jnz 0xa4be */
            ii(0x13_a4b6, 5); mov(memw_a16[ss, bp - 0x12], 0x8002);     /* mov word [bp-0x12], 0x8002 */
            ii(0x13_a4bb, 3); jmpw(0x13_a658, 0x19a); goto l_0x13_a658; /* jmp 0xa658 */
        l_0x13_a4be:
            ii(0x13_a4be, 3); les(bx, ss, bp - 0x32);                   /* les bx, [bp-0x32] */
            ii(0x13_a4c1, 4); add(memw_a16[ss, bp - 0x32], 0x2);        /* add word [bp-0x32], 0x2 */
            ii(0x13_a4c5, 3); mov(si, memw_a16[es, bx]);                /* mov si, [es:bx] */
            ii(0x13_a4c8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_a4ca, 3); and(ax, 0x3);                             /* and ax, 0x3 */
            ii(0x13_a4cd, 3); jmpw(0x13_a5ce, 0xfe); goto l_0x13_a5ce;  /* jmp 0xa5ce */
        l_0x13_a4d0:
            ii(0x13_a4d0, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_a4d3, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_a4d6, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a4da, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a4de, 3); callw(0x13_90c4, -0x141d);                /* call 0x90c4 */
            ii(0x13_a4e1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_a4e4, 3); mov(memb_a16[ss, bp - 0x38], al);         /* mov [bp-0x38], al */
            ii(0x13_a4e7, 4); cmp(memb_a16[ds, 0x51b5], al);            /* cmp [0x51b5], al */
            ii(0x13_a4eb, 2); if(jnzw(0x13_a4f0, 0x3)) goto l_0x13_a4f0; /* jnz 0xa4f0 */
            ii(0x13_a4ed, 3); jmpw(0x13_a5e2, 0xf2); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        l_0x13_a4f0:
            ii(0x13_a4f0, 3); mov(al, memb_a16[ss, bp - 0x38]);         /* mov al, [bp-0x38] */
            ii(0x13_a4f3, 4); cmp(memb_a16[ds, 0x51a6], al);            /* cmp [0x51a6], al */
            ii(0x13_a4f7, 2); if(jnzw(0x13_a52e, 0x35)) goto l_0x13_a52e; /* jnz 0xa52e */
        l_0x13_a4f9:
            ii(0x13_a4f9, 3); mov(al, memb_a16[ds, 0x51b5]);            /* mov al, [0x51b5] */
            ii(0x13_a4fc, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_a4fe, 1); pushw(ax);                                /* push ax */
            ii(0x13_a4ff, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_a502, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_a505, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a509, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a50d, 3); callw(0x13_91e3, -0x132d);                /* call 0x91e3 */
            ii(0x13_a510, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_a513, 4); and(memb_a16[ss, bp - 0x2e], -0x2 /* 0xfe */); /* and byte [bp-0x2e], 0xfe */
            ii(0x13_a517, 3); mov(ax, memw_a16[ss, bp - 0x2e]);         /* mov ax, [bp-0x2e] */
            ii(0x13_a51a, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x13_a51d, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x13_a520, 5); mov(memw_a16[ss, bp - 0x2c], 0);          /* mov word [bp-0x2c], 0x0 */
            ii(0x13_a525, 4); and(memb_a16[ss, bp - 0x2e], -0x23 /* 0xdd */); /* and byte [bp-0x2e], 0xdd */
            ii(0x13_a529, 1); inc(di);                                  /* inc di */
            ii(0x13_a52a, 3); jmpw(0x13_a5e2, 0xb5); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        //  ii(0x13_a52d, 1); Недостижимый код.
l_0x13_a52e:
            ii(0x13_a52e, 3); mov(al, memb_a16[ss, bp - 0x38]);         /* mov al, [bp-0x38] */
            ii(0x13_a531, 4); cmp(memb_a16[ds, 0x51a6], al);            /* cmp [0x51a6], al */
            ii(0x13_a535, 2); if(jnzw(0x13_a53d, 0x6)) goto l_0x13_a53d; /* jnz 0xa53d */
            ii(0x13_a537, 4); cmp(memb_a16[ds, 0x51b5], al);            /* cmp [0x51b5], al */
            ii(0x13_a53b, 2); if(jzw(0x13_a56e, 0x31)) goto l_0x13_a56e; /* jz 0xa56e */
        l_0x13_a53d:
            ii(0x13_a53d, 4); test(memb_a16[ss, bp - 0x2e], 0x1);       /* test byte [bp-0x2e], 0x1 */
            ii(0x13_a541, 2); if(jzw(0x13_a56b, 0x28)) goto l_0x13_a56b; /* jz 0xa56b */
            ii(0x13_a543, 3); mov(ax, memw_a16[ss, bp - 0x2e]);         /* mov ax, [bp-0x2e] */
            ii(0x13_a546, 3); mov(dx, memw_a16[ss, bp - 0x2c]);         /* mov dx, [bp-0x2c] */
            ii(0x13_a549, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_a54b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_a54d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_a54f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_a551, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a553, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a555, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a557, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a559, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a55b, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a55d, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_a55f, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_a561, 1); pushw(dx);                                /* push dx */
            ii(0x13_a562, 1); pushw(ax);                                /* push ax */
            ii(0x13_a563, 1); nop();                                    /* nop */
            ii(0x13_a564, 1); pushw(cs);                                /* push cs */
            ii(0x13_a565, 3); callw(0x13_7f3a, -0x262e);                /* call 0x7f3a */
            ii(0x13_a568, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x13_a56b:
            ii(0x13_a56b, 2); jmpw(0x13_a4f9, -0x74); goto l_0x13_a4f9; /* jmp 0xa4f9 */
        //  ii(0x13_a56d, 1); Недостижимый код.
l_0x13_a56e:
            ii(0x13_a56e, 2); jmpw(0x13_a5e2, 0x72); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        l_0x13_a570:
            ii(0x13_a570, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_a573, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_a576, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a57a, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a57e, 3); callw(0x13_90c4, -0x14bd);                /* call 0x90c4 */
            ii(0x13_a581, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_a584, 3); mov(memb_a16[ss, bp - 0x38], al);         /* mov [bp-0x38], al */
            ii(0x13_a587, 4); cmp(memb_a16[ds, 0x51a6], al);            /* cmp [0x51a6], al */
            ii(0x13_a58b, 2); if(jnzw(0x13_a596, 0x9)) goto l_0x13_a596; /* jnz 0xa596 */
            ii(0x13_a58d, 5); mov(memw_a16[ss, bp - 0x12], 0x8002);     /* mov word [bp-0x12], 0x8002 */
            ii(0x13_a592, 3); jmpw(0x13_a658, 0xc3); goto l_0x13_a658;  /* jmp 0xa658 */
        //  ii(0x13_a595, 1); Недостижимый код.
l_0x13_a596:
            ii(0x13_a596, 3); mov(al, memb_a16[ss, bp - 0x38]);         /* mov al, [bp-0x38] */
            ii(0x13_a599, 4); cmp(memb_a16[ds, 0x51b5], al);            /* cmp [0x51b5], al */
            ii(0x13_a59d, 2); if(jzw(0x13_a5a2, 0x3)) goto l_0x13_a5a2; /* jz 0xa5a2 */
            ii(0x13_a59f, 2); jmpw(0x13_a5e2, 0x41); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        //  ii(0x13_a5a1, 1); Недостижимый код.
l_0x13_a5a2:
            ii(0x13_a5a2, 3); mov(al, memb_a16[ds, 0x51a7]);            /* mov al, [0x51a7] */
            ii(0x13_a5a5, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_a5a7, 1); pushw(ax);                                /* push ax */
            ii(0x13_a5a8, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x13_a5ab, 3); pushw(memw_a16[ss, bp - 0x26]);           /* push word [bp-0x26] */
            ii(0x13_a5ae, 4); pushw(memw_a16[ds, 0x1fa6]);              /* push word [0x1fa6] */
            ii(0x13_a5b2, 4); pushw(memw_a16[ds, 0x1fa4]);              /* push word [0x1fa4] */
            ii(0x13_a5b6, 3); callw(0x13_91e3, -0x13d6);                /* call 0x91e3 */
            ii(0x13_a5b9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x13_a5bc, 3); mov(di, 0x1);                             /* mov di, 0x1 */
            ii(0x13_a5bf, 2); jmpw(0x13_a5e2, 0x21); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        //  ii(0x13_a5c1, 1); Недостижимый код.
l_0x13_a5c2:
            ii(0x13_a5c2, 2); jmpw(0x13_a5e2, 0x1e); goto l_0x13_a5e2;  /* jmp 0xa5e2 */
        l_0x13_a5c4:
            ii(0x13_a5c4, 5); mov(memw_a16[ss, bp - 0x12], 0x8021);     /* mov word [bp-0x12], 0x8021 */
            ii(0x13_a5c9, 3); jmpw(0x13_a658, 0x8c); goto l_0x13_a658;  /* jmp 0xa658 */
        //  ii(0x13_a5cc, 2); Недостижимый код.
l_0x13_a5ce:
            ii(0x13_a5ce, 3); cmp(ax, 0x10);                            /* cmp ax, 0x10 */
            ii(0x13_a5d1, 2); if(jzw(0x13_a5c2, -0x11)) goto l_0x13_a5c2; /* jz 0xa5c2 */
            ii(0x13_a5d3, 2); if(jaw(0x13_a5c4, -0x11)) goto l_0x13_a5c4; /* ja 0xa5c4 */
            ii(0x13_a5d5, 2); or(al, al);                               /* or al, al */
            ii(0x13_a5d7, 2); if(jnzw(0x13_a5dc, 0x3)) goto l_0x13_a5dc; /* jnz 0xa5dc */
            ii(0x13_a5d9, 3); jmpw(0x13_a4d0, -0x10c); goto l_0x13_a4d0; /* jmp 0xa4d0 */
        l_0x13_a5dc:
            ii(0x13_a5dc, 2); dec(al);                                  /* dec al */
            ii(0x13_a5de, 2); if(jzw(0x13_a570, -0x70)) goto l_0x13_a570; /* jz 0xa570 */
            ii(0x13_a5e0, 2); jmpw(0x13_a5c4, -0x1e); goto l_0x13_a5c4; /* jmp 0xa5c4 */
        l_0x13_a5e2:
            ii(0x13_a5e2, 4); test(si, 0x10);                           /* test si, 0x10 */
            ii(0x13_a5e6, 2); if(jzw(0x13_a623, 0x3b)) goto l_0x13_a623; /* jz 0xa623 */
            ii(0x13_a5e8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x13_a5ea, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x13_a5ed, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x13_a5f0, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x13_a5f2, 1); inc(ax);                                  /* inc ax */
            ii(0x13_a5f3, 3); shl(al, 0x6);                             /* shl al, 0x6 */
            ii(0x13_a5f6, 3); xor(al, memb_a16[ss, bp - 0x2e]);         /* xor al, [bp-0x2e] */
            ii(0x13_a5f9, 3); and(ax, 0x40);                            /* and ax, 0x40 */
            ii(0x13_a5fc, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_a5fe, 3); xor(memw_a16[ss, bp - 0x2e], ax);         /* xor [bp-0x2e], ax */
            ii(0x13_a601, 3); xor(memw_a16[ss, bp - 0x2c], dx);         /* xor [bp-0x2c], dx */
            ii(0x13_a604, 3); mov(ax, memw_a16[ss, bp - 0x2e]);         /* mov ax, [bp-0x2e] */
            ii(0x13_a607, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x13_a609, 3); and(cx, 0x40);                            /* and cx, 0x40 */
            ii(0x13_a60c, 3); cmp(cx, 0x1);                             /* cmp cx, 0x1 */
            ii(0x13_a60f, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x13_a611, 1); inc(cx);                                  /* inc cx */
            ii(0x13_a612, 3); shl(cx, 0x5);                             /* shl cx, 0x5 */
            ii(0x13_a615, 2); xor(al, cl);                              /* xor al, cl */
            ii(0x13_a617, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x13_a61a, 3); xor(memw_a16[ss, bp - 0x2e], ax);         /* xor [bp-0x2e], ax */
            ii(0x13_a61d, 3); xor(memw_a16[ss, bp - 0x2c], dx);         /* xor [bp-0x2c], dx */
            ii(0x13_a620, 3); mov(di, 0x1);                             /* mov di, 0x1 */
        l_0x13_a623:
            ii(0x13_a623, 2); or(di, di);                               /* or di, di */
            ii(0x13_a625, 2); if(jzw(0x13_a641, 0x1a)) goto l_0x13_a641; /* jz 0xa641 */
            ii(0x13_a627, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x13_a629, 4); mov(es, memw_a16[ds, 0xaa]);              /* mov es, [0xaa] */
            ii(0x13_a62d, 4); mov(edi, memd_a16[ss, bp - 0x16]);        /* mov edi, [bp-0x16] */
            ii(0x13_a631, 4); mov(ebx, memd_a16[ss, bp - 0x26]);        /* mov ebx, [bp-0x26] */
            ii(0x13_a635, 4); mov(eax, memd_a16[ss, bp - 0x2e]);        /* mov eax, [bp-0x2e] */
            ii(0x13_a639, 6); mov(memd_a32[es, edi + ebx * 4], eax);    /* mov [es:edi+ebx*4], eax */
            ii(0x13_a63f, 2); mov(di, dx);                              /* mov di, dx */
        l_0x13_a641:
            ii(0x13_a641, 3); or(memw_a16[ss, bp - 0x34], di);          /* or [bp-0x34], di */
            ii(0x13_a644, 4); add(memw_a16[ss, bp - 0x26], 0x1);        /* add word [bp-0x26], 0x1 */
            ii(0x13_a648, 4); adc(memw_a16[ss, bp - 0x24], 0);          /* adc word [bp-0x24], 0x0 */
            ii(0x13_a64c, 5); add(memw_a16[ss, bp - 0x8], 0x1000);      /* add word [bp-0x8], 0x1000 */
            ii(0x13_a651, 4); adc(memw_a16[ss, bp - 0x6], 0);           /* adc word [bp-0x6], 0x0 */
            ii(0x13_a655, 3); jmpw(0x13_a469, -0x1ef); goto l_0x13_a469; /* jmp 0xa469 */
        l_0x13_a658:
            ii(0x13_a658, 4); cmp(memw_a16[ss, bp - 0x12], 0);          /* cmp word [bp-0x12], 0x0 */
            ii(0x13_a65c, 2); if(jzw(0x13_a672, 0x14)) goto l_0x13_a672; /* jz 0xa672 */
            ii(0x13_a65e, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0x13_a661, 1); cwd();                                    /* cwd */
            ii(0x13_a662, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_a665, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x13_a669, 4); mov(memw_a16[es, bx + 0x22], dx);         /* mov [es:bx+0x22], dx */
            ii(0x13_a66d, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
        l_0x13_a672:
            ii(0x13_a672, 1); nop();                                    /* nop */
            ii(0x13_a673, 1); pushw(cs);                                /* push cs */
            ii(0x13_a674, 3); callw(0x13_488e, -0x5de9);                /* call 0x488e */
            ii(0x13_a677, 4); cmp(memw_a16[ss, bp - 0x34], 0);          /* cmp word [bp-0x34], 0x0 */
            ii(0x13_a67b, 2); if(jzw(0x13_a683, 0x6)) goto l_0x13_a683; /* jz 0xa683 */
            ii(0x13_a67d, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x13_a680, 3); mov(cr3, eax);                            /* mov cr3, eax */
        l_0x13_a683:
            ii(0x13_a683, 1); popw(ds);                                 /* pop ds */
            ii(0x13_a684, 1); popw(si);                                 /* pop si */
            ii(0x13_a685, 1); popw(di);                                 /* pop di */
            ii(0x13_a686, 1); leavew();                                 /* leave */
            ii(0x13_a687, 1); retfw(); return;                          /* retf */
        }
    }
}
