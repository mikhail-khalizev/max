using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_a286-c3d4ecce")]
        public void Method_0017_a286()
        {
            ii(0x17_a286, 4); enter(0x40, 0);                           /* enter 0x40, 0x0 */
            ii(0x17_a28a, 1); push(di);                                 /* push di */
            ii(0x17_a28b, 1); push(si);                                 /* push si */
            ii(0x17_a28c, 1); push(ds);                                 /* push ds */
            ii(0x17_a28d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_a290, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_a292, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_a294, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x17_a297, 3); mov(memw[ss, bp - 12], ax);               /* mov [bp-0xc], ax */
            ii(0x17_a29a, 3); mov(memw[ss, bp - 18], ax);               /* mov [bp-0x12], ax */
            ii(0x17_a29d, 3); mov(memw[ss, bp - 52], ax);               /* mov [bp-0x34], ax */
            ii(0x17_a2a0, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_a2a3, 4); mov(ax, memw[es, bx + 20]);               /* mov ax, [es:bx+0x14] */
            ii(0x17_a2a7, 4); mov(dx, memw[es, bx + 22]);               /* mov dx, [es:bx+0x16] */
            ii(0x17_a2ab, 3); mov(memw[ss, bp - 16], ax);               /* mov [bp-0x10], ax */
            ii(0x17_a2ae, 3); mov(memw[ss, bp - 14], dx);               /* mov [bp-0xe], dx */
            ii(0x17_a2b1, 4); mov(ax, memw[es, bx + 28]);               /* mov ax, [es:bx+0x1c] */
            ii(0x17_a2b5, 4); mov(dx, memw[es, bx + 30]);               /* mov dx, [es:bx+0x1e] */
            ii(0x17_a2b9, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x17_a2bc, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_a2bf, 6); test(memw[es, bx + 10], 0xffff);          /* test word [es:bx+0xa], 0xffff */
            ii(0x17_a2c5, 2); if(jz(0x17_a2d0, 9)) goto l_0x17_a2d0;    /* jz 0xa2d0 */
            ii(0x17_a2c7, 5); mov(memw[ss, bp - 18], 0x8023);           /* mov word [bp-0x12], 0x8023 */
            ii(0x17_a2cc, 3); jmp(0x17_a658, 0x389); goto l_0x17_a658;  /* jmp 0xa658 */
        //  ii(0x17_a2cf, 1); nop();                                    /* nop */
        l_0x17_a2d0:
            ii(0x17_a2d0, 4); mov(ax, memw[es, bx + 8]);                /* mov ax, [es:bx+0x8] */
            ii(0x17_a2d4, 3); mov(memw[ss, bp - 54], ax);               /* mov [bp-0x36], ax */
            ii(0x17_a2d7, 1); push(ax);                                 /* push ax */
            ii(0x17_a2d8, 1); push(cs);                                 /* push cs */
            ii(0x17_a2d9, 3); call(0x17_c79c, 0x24c0);                  /* call 0xc79c */
            ii(0x17_a2dc, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x17_a2df, 3); mov(memw[ss, bp - 30], ax);               /* mov [bp-0x1e], ax */
            ii(0x17_a2e2, 3); mov(memw[ss, bp - 28], dx);               /* mov [bp-0x1c], dx */
            ii(0x17_a2e5, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_a2e8, 2); if(jnz(0x17_a2f6, 0xc)) goto l_0x17_a2f6; /* jnz 0xa2f6 */
            ii(0x17_a2ea, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x17_a2ec, 2); if(jnz(0x17_a2f6, 8)) goto l_0x17_a2f6;   /* jnz 0xa2f6 */
            ii(0x17_a2ee, 5); mov(memw[ss, bp - 18], 0x8023);           /* mov word [bp-0x12], 0x8023 */
            ii(0x17_a2f3, 3); jmp(0x17_a658, 0x362); goto l_0x17_a658;  /* jmp 0xa658 */
        l_0x17_a2f6:
            ii(0x17_a2f6, 3); mov(ax, memw[ss, bp - 16]);               /* mov ax, [bp-0x10] */
            ii(0x17_a2f9, 3); mov(dx, memw[ss, bp - 14]);               /* mov dx, [bp-0xe] */
            ii(0x17_a2fc, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_a2fe, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_a300, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_a302, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_a304, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a306, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a308, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a30a, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a30c, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a30e, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a310, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a312, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a314, 3); add(memw[ss, bp - 30], ax);               /* add [bp-0x1e], ax */
            ii(0x17_a317, 3); adc(memw[ss, bp - 28], dx);               /* adc [bp-0x1c], dx */
            ii(0x17_a31a, 3); mov(ax, memw[ss, bp - 30]);               /* mov ax, [bp-0x1e] */
            ii(0x17_a31d, 3); mov(dx, memw[ss, bp - 28]);               /* mov dx, [bp-0x1c] */
            ii(0x17_a320, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x17_a323, 3); adc(dx, 1);                               /* adc dx, 0x1 */
            ii(0x17_a326, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_a328, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_a32a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_a32c, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_a32e, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_a330, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_a332, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_a334, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_a336, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_a338, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_a33a, 2); shl(ax, 1);                               /* shl ax, 1 */
            ii(0x17_a33c, 2); rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x17_a33e, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x17_a341, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x17_a344, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_a347, 5); and(memb[es, bx + 44], -2 /* 0xfe */);    /* and byte [es:bx+0x2c], 0xfe */
            ii(0x17_a34c, 4); push(memw[es, bx + 26]);                  /* push word [es:bx+0x1a] */
            ii(0x17_a350, 4); push(memw[es, bx + 24]);                  /* push word [es:bx+0x18] */
            ii(0x17_a354, 4); push(memw[es, bx + 2]);                   /* push word [es:bx+0x2] */
            ii(0x17_a358, 1); nop();                                    /* nop */
            ii(0x17_a359, 1); push(cs);                                 /* push cs */
            ii(0x17_a35a, 3); call(0x17_4860, -0x5afd);                 /* call 0x4860 */
            ii(0x17_a35d, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x17_a360, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x17_a362, 3); mov(memw[ss, bp - 50], cx);               /* mov [bp-0x32], cx */
            ii(0x17_a365, 3); mov(memw[ss, bp - 48], ax);               /* mov [bp-0x30], ax */
            ii(0x17_a368, 3); mov(memw[ss, bp - 34], cx);               /* mov [bp-0x22], cx */
            ii(0x17_a36b, 3); mov(memw[ss, bp - 32], ax);               /* mov [bp-0x20], ax */
            ii(0x17_a36e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_a370, 3); mov(memw[ss, bp - 40], ax);               /* mov [bp-0x28], ax */
            ii(0x17_a373, 3); mov(memw[ss, bp - 42], ax);               /* mov [bp-0x2a], ax */
            ii(0x17_a376, 2); jmp(0x17_a380, 8); goto l_0x17_a380;      /* jmp 0xa380 */
        l_0x17_a378:
            ii(0x17_a378, 4); add(memw[ss, bp - 42], 1);                /* add word [bp-0x2a], 0x1 */
            ii(0x17_a37c, 4); adc(memw[ss, bp - 40], 0);                /* adc word [bp-0x28], 0x0 */
        l_0x17_a380:
            ii(0x17_a380, 3); mov(ax, memw[ss, bp - 42]);               /* mov ax, [bp-0x2a] */
            ii(0x17_a383, 3); mov(dx, memw[ss, bp - 40]);               /* mov dx, [bp-0x28] */
            ii(0x17_a386, 3); cmp(memw[ss, bp - 2], dx);                /* cmp [bp-0x2], dx */
            ii(0x17_a389, 2); if(jb(0x17_a3b8, 0x2d)) goto l_0x17_a3b8; /* jb 0xa3b8 */
            ii(0x17_a38b, 2); if(ja(0x17_a392, 5)) goto l_0x17_a392;    /* ja 0xa392 */
            ii(0x17_a38d, 3); cmp(memw[ss, bp - 4], ax);                /* cmp [bp-0x4], ax */
            ii(0x17_a390, 2); if(jbe(0x17_a3b8, 0x26)) goto l_0x17_a3b8; /* jbe 0xa3b8 */
        l_0x17_a392:
            ii(0x17_a392, 3); les(bx, memw[ss, bp - 34]);               /* les bx, [bp-0x22] */
            ii(0x17_a395, 4); add(memw[ss, bp - 34], 2);                /* add word [bp-0x22], 0x2 */
            ii(0x17_a399, 3); mov(si, memw[es, bx]);                    /* mov si, [es:bx] */
            ii(0x17_a39c, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_a39e, 3); and(ax, 3);                               /* and ax, 0x3 */
            ii(0x17_a3a1, 2); jmp(0x17_a3b0, 0xd); goto l_0x17_a3b0;    /* jmp 0xa3b0 */
        //  ii(0x17_a3a3, 1); nop();                                    /* nop */
        l_0x17_a3a4:
            ii(0x17_a3a4, 4); add(memw[ss, bp - 12], 1);                /* add word [bp-0xc], 0x1 */
            ii(0x17_a3a8, 4); adc(memw[ss, bp - 10], 0);                /* adc word [bp-0xa], 0x0 */
            ii(0x17_a3ac, 2); jmp(0x17_a3b6, 8); goto l_0x17_a3b6;      /* jmp 0xa3b6 */
        //  ii(0x17_a3ae, 2); jmp(0x17_a3b6, 6); goto l_0x17_a3b6;      /* jmp 0xa3b6 */
        l_0x17_a3b0:
            ii(0x17_a3b0, 1); dec(ax);                                  /* dec ax */
            ii(0x17_a3b1, 2); if(jz(0x17_a3a4, -0xf)) goto l_0x17_a3a4; /* jz 0xa3a4 */
            ii(0x17_a3b3, 2); jmp(0x17_a3b6, 1); goto l_0x17_a3b6;      /* jmp 0xa3b6 */
        //  ii(0x17_a3b5, 1); nop();                                    /* nop */
        l_0x17_a3b6:
            ii(0x17_a3b6, 2); jmp(0x17_a378, -0x40); goto l_0x17_a378;  /* jmp 0xa378 */
        l_0x17_a3b8:
            ii(0x17_a3b8, 4); cmp(memw[ss, bp - 10], 0);                /* cmp word [bp-0xa], 0x0 */
            ii(0x17_a3bc, 2); if(jge(0x17_a3c1, 3)) goto l_0x17_a3c1;   /* jge 0xa3c1 */
            ii(0x17_a3be, 3); jmp(0x17_a450, 0x8f); goto l_0x17_a450;   /* jmp 0xa450 */
        l_0x17_a3c1:
            ii(0x17_a3c1, 2); if(jg(0x17_a3cc, 9)) goto l_0x17_a3cc;    /* jg 0xa3cc */
            ii(0x17_a3c3, 4); cmp(memw[ss, bp - 12], 0);                /* cmp word [bp-0xc], 0x0 */
            ii(0x17_a3c7, 2); if(jnz(0x17_a3cc, 3)) goto l_0x17_a3cc;   /* jnz 0xa3cc */
            ii(0x17_a3c9, 3); jmp(0x17_a450, 0x84); goto l_0x17_a450;   /* jmp 0xa450 */
        l_0x17_a3cc:
            ii(0x17_a3cc, 3); mov(ax, memw[ds, 0x1fc4]);                /* mov ax, [0x1fc4] */
            ii(0x17_a3cf, 4); mov(dx, memw[ds, 0x1fc6]);                /* mov dx, [0x1fc6] */
            ii(0x17_a3d3, 3); cmp(memw[ss, bp - 10], dx);               /* cmp [bp-0xa], dx */
            ii(0x17_a3d6, 2); if(jl(0x17_a3ea, 0x12)) goto l_0x17_a3ea; /* jl 0xa3ea */
            ii(0x17_a3d8, 2); if(jg(0x17_a3df, 5)) goto l_0x17_a3df;    /* jg 0xa3df */
            ii(0x17_a3da, 3); cmp(memw[ss, bp - 12], ax);               /* cmp [bp-0xc], ax */
            ii(0x17_a3dd, 2); if(jbe(0x17_a3ea, 0xb)) goto l_0x17_a3ea; /* jbe 0xa3ea */
        l_0x17_a3df:
            ii(0x17_a3df, 5); mov(memw[ss, bp - 18], 0x8016);           /* mov word [bp-0x12], 0x8016 */
            ii(0x17_a3e4, 3); jmp(0x17_a658, 0x271); goto l_0x17_a658;  /* jmp 0xa658 */
        //  ii(0x17_a3e7, 2); jmp(0x17_a450, 0x67); goto l_0x17_a450;   /* jmp 0xa450 */
        //  ii(0x17_a3e9, 1); nop();                                    /* nop */
        l_0x17_a3ea:
            ii(0x17_a3ea, 3); mov(ax, memw[ds, 0x1a]);                  /* mov ax, [0x1a] */
            ii(0x17_a3ed, 4); or(ax, memw[ds, 0x18]);                   /* or ax, [0x18] */
            ii(0x17_a3f1, 2); if(jz(0x17_a450, 0x5d)) goto l_0x17_a450; /* jz 0xa450 */
            ii(0x17_a3f3, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_a3f6, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_a3f9, 4); sub(ax, memw[ds, 0x1fc4]);                /* sub ax, [0x1fc4] */
            ii(0x17_a3fd, 4); sbb(dx, memw[ds, 0x1fc6]);                /* sbb dx, [0x1fc6] */
            ii(0x17_a401, 4); sub(ax, memw[ds, 0x1fc0]);                /* sub ax, [0x1fc0] */
            ii(0x17_a405, 4); sbb(dx, memw[ds, 0x1fc2]);                /* sbb dx, [0x1fc2] */
            ii(0x17_a409, 4); add(ax, memw[ds, 0x1fb4]);                /* add ax, [0x1fb4] */
            ii(0x17_a40d, 4); adc(dx, memw[ds, 0x1fb6]);                /* adc dx, [0x1fb6] */
            ii(0x17_a411, 3); add(ax, 4);                               /* add ax, 0x4 */
            ii(0x17_a414, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x17_a417, 3); mov(memw[ss, bp - 26], ax);               /* mov [bp-0x1a], ax */
            ii(0x17_a41a, 3); mov(memw[ss, bp - 24], dx);               /* mov [bp-0x18], dx */
            ii(0x17_a41d, 4); mov(cx, memw[ds, 0x1f50]);                /* mov cx, [0x1f50] */
            ii(0x17_a421, 4); mov(bx, memw[ds, 0x1f52]);                /* mov bx, [0x1f52] */
            ii(0x17_a425, 2); cmp(dx, bx);                              /* cmp dx, bx */
            ii(0x17_a427, 2); if(jl(0x17_a450, 0x27)) goto l_0x17_a450; /* jl 0xa450 */
            ii(0x17_a429, 2); if(jg(0x17_a42f, 4)) goto l_0x17_a42f;    /* jg 0xa42f */
            ii(0x17_a42b, 2); cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x17_a42d, 2); if(jbe(0x17_a450, 0x21)) goto l_0x17_a450; /* jbe 0xa450 */
        l_0x17_a42f:
            ii(0x17_a42f, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_a431, 2); sbb(dx, bx);                              /* sbb dx, bx */
            ii(0x17_a433, 3); mov(memw[ss, bp - 60], ax);               /* mov [bp-0x3c], ax */
            ii(0x17_a436, 3); mov(memw[ss, bp - 58], dx);               /* mov [bp-0x3a], dx */
            ii(0x17_a439, 1); push(dx);                                 /* push dx */
            ii(0x17_a43a, 1); push(ax);                                 /* push ax */
            ii(0x17_a43b, 1); nop();                                    /* nop */
            ii(0x17_a43c, 1); push(cs);                                 /* push cs */
            ii(0x17_a43d, 3); call(0x17_8ba6, -0x189a);                 /* call 0x8ba6 */
            ii(0x17_a440, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x17_a443, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_a445, 2); if(jnz(0x17_a450, 9)) goto l_0x17_a450;   /* jnz 0xa450 */
            ii(0x17_a447, 5); mov(memw[ss, bp - 18], 0x8014);           /* mov word [bp-0x12], 0x8014 */
            ii(0x17_a44c, 3); jmp(0x17_a658, 0x209); goto l_0x17_a658;  /* jmp 0xa658 */
        //  ii(0x17_a44f, 1); nop();                                    /* nop */
        l_0x17_a450:
            ii(0x17_a450, 3); mov(ax, memw[ds, 0x4f8c]);                /* mov ax, [0x4f8c] */
            ii(0x17_a453, 4); mov(dx, memw[ds, 0x4f8e]);                /* mov dx, [0x4f8e] */
            ii(0x17_a457, 3); mov(memw[ss, bp - 22], ax);               /* mov [bp-0x16], ax */
            ii(0x17_a45a, 3); mov(memw[ss, bp - 20], dx);               /* mov [bp-0x14], dx */
            ii(0x17_a45d, 3); mov(ax, memw[ss, bp - 30]);               /* mov ax, [bp-0x1e] */
            ii(0x17_a460, 3); mov(dx, memw[ss, bp - 28]);               /* mov dx, [bp-0x1c] */
            ii(0x17_a463, 3); mov(memw[ss, bp - 38], ax);               /* mov [bp-0x26], ax */
            ii(0x17_a466, 3); mov(memw[ss, bp - 36], dx);               /* mov [bp-0x24], dx */
        l_0x17_a469:
            ii(0x17_a469, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x17_a46c, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x17_a46f, 4); sub(memw[ss, bp - 4], 1);                 /* sub word [bp-0x4], 0x1 */
            ii(0x17_a473, 4); sbb(memw[ss, bp - 2], 0);                 /* sbb word [bp-0x2], 0x0 */
            ii(0x17_a477, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x17_a479, 2); if(jnz(0x17_a482, 7)) goto l_0x17_a482;   /* jnz 0xa482 */
            ii(0x17_a47b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_a47d, 2); if(jnz(0x17_a482, 3)) goto l_0x17_a482;   /* jnz 0xa482 */
            ii(0x17_a47f, 3); jmp(0x17_a658, 0x1d6); goto l_0x17_a658;  /* jmp 0xa658 */
        l_0x17_a482:
            ii(0x17_a482, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_a484, 4); mov(es, memw[ds, 0xaa]);                  /* mov es, [0xaa] */
            ii(0x17_a488, 4); mov(edi, memd[ss, bp - 22]);              /* mov edi, [bp-0x16] */
            ii(0x17_a48c, 4); mov(ebx, memd[ss, bp - 38]);              /* mov ebx, [bp-0x26] */
            ii(0x17_a490, 6); mov(eax, memd_a32[es, edi + ebx * 4]);    /* mov eax, [es:edi+ebx*4] */
            ii(0x17_a496, 4); mov(memd[ss, bp - 46], eax);              /* mov [bp-0x2e], eax */
            ii(0x17_a49a, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x17_a49c, 2); sub(di, di);                              /* sub di, di */
            ii(0x17_a49e, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_a4a1, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_a4a4, 4); push(memw[ds, 0x4ff6]);                   /* push word [0x4ff6] */
            ii(0x17_a4a8, 4); push(memw[ds, 0x4ff4]);                   /* push word [0x4ff4] */
            ii(0x17_a4ac, 3); call(0x17_90c4, -0x13eb);                 /* call 0x90c4 */
            ii(0x17_a4af, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_a4b2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_a4b4, 2); if(jnz(0x17_a4be, 8)) goto l_0x17_a4be;   /* jnz 0xa4be */
            ii(0x17_a4b6, 5); mov(memw[ss, bp - 18], 0x8002);           /* mov word [bp-0x12], 0x8002 */
            ii(0x17_a4bb, 3); jmp(0x17_a658, 0x19a); goto l_0x17_a658;  /* jmp 0xa658 */
        l_0x17_a4be:
            ii(0x17_a4be, 3); les(bx, memw[ss, bp - 50]);               /* les bx, [bp-0x32] */
            ii(0x17_a4c1, 4); add(memw[ss, bp - 50], 2);                /* add word [bp-0x32], 0x2 */
            ii(0x17_a4c5, 3); mov(si, memw[es, bx]);                    /* mov si, [es:bx] */
            ii(0x17_a4c8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_a4ca, 3); and(ax, 3);                               /* and ax, 0x3 */
            ii(0x17_a4cd, 3); jmp(0x17_a5ce, 0xfe); goto l_0x17_a5ce;   /* jmp 0xa5ce */
        l_0x17_a4d0:
            ii(0x17_a4d0, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_a4d3, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_a4d6, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_a4da, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_a4de, 3); call(0x17_90c4, -0x141d);                 /* call 0x90c4 */
            ii(0x17_a4e1, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_a4e4, 3); mov(memb[ss, bp - 56], al);               /* mov [bp-0x38], al */
            ii(0x17_a4e7, 4); cmp(memb[ds, 0x51b5], al);                /* cmp [0x51b5], al */
            ii(0x17_a4eb, 2); if(jnz(0x17_a4f0, 3)) goto l_0x17_a4f0;   /* jnz 0xa4f0 */
            ii(0x17_a4ed, 3); jmp(0x17_a5e2, 0xf2); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        l_0x17_a4f0:
            ii(0x17_a4f0, 3); mov(al, memb[ss, bp - 56]);               /* mov al, [bp-0x38] */
            ii(0x17_a4f3, 4); cmp(memb[ds, 0x51a6], al);                /* cmp [0x51a6], al */
            ii(0x17_a4f7, 2); if(jnz(0x17_a52e, 0x35)) goto l_0x17_a52e; /* jnz 0xa52e */
        l_0x17_a4f9:
            ii(0x17_a4f9, 3); mov(al, memb[ds, 0x51b5]);                /* mov al, [0x51b5] */
            ii(0x17_a4fc, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_a4fe, 1); push(ax);                                 /* push ax */
            ii(0x17_a4ff, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_a502, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_a505, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_a509, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_a50d, 3); call(0x17_91e3, -0x132d);                 /* call 0x91e3 */
            ii(0x17_a510, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_a513, 4); and(memb[ss, bp - 46], -2 /* 0xfe */);    /* and byte [bp-0x2e], 0xfe */
            ii(0x17_a517, 3); mov(ax, memw[ss, bp - 46]);               /* mov ax, [bp-0x2e] */
            ii(0x17_a51a, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x17_a51d, 3); mov(memw[ss, bp - 46], ax);               /* mov [bp-0x2e], ax */
            ii(0x17_a520, 5); mov(memw[ss, bp - 44], 0);                /* mov word [bp-0x2c], 0x0 */
            ii(0x17_a525, 4); and(memb[ss, bp - 46], -0x23 /* 0xdd */); /* and byte [bp-0x2e], 0xdd */
            ii(0x17_a529, 1); inc(di);                                  /* inc di */
            ii(0x17_a52a, 3); jmp(0x17_a5e2, 0xb5); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        //  ii(0x17_a52d, 1); nop();                                    /* nop */
        l_0x17_a52e:
            ii(0x17_a52e, 3); mov(al, memb[ss, bp - 56]);               /* mov al, [bp-0x38] */
            ii(0x17_a531, 4); cmp(memb[ds, 0x51a6], al);                /* cmp [0x51a6], al */
            ii(0x17_a535, 2); if(jnz(0x17_a53d, 6)) goto l_0x17_a53d;   /* jnz 0xa53d */
            ii(0x17_a537, 4); cmp(memb[ds, 0x51b5], al);                /* cmp [0x51b5], al */
            ii(0x17_a53b, 2); if(jz(0x17_a56e, 0x31)) goto l_0x17_a56e; /* jz 0xa56e */
        l_0x17_a53d:
            ii(0x17_a53d, 4); test(memb[ss, bp - 46], 1);               /* test byte [bp-0x2e], 0x1 */
            ii(0x17_a541, 2); if(jz(0x17_a56b, 0x28)) goto l_0x17_a56b; /* jz 0xa56b */
            ii(0x17_a543, 3); mov(ax, memw[ss, bp - 46]);               /* mov ax, [bp-0x2e] */
            ii(0x17_a546, 3); mov(dx, memw[ss, bp - 44]);               /* mov dx, [bp-0x2c] */
            ii(0x17_a549, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_a54b, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_a54d, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_a54f, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_a551, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a553, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a555, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a557, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a559, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a55b, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a55d, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_a55f, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_a561, 1); push(dx);                                 /* push dx */
            ii(0x17_a562, 1); push(ax);                                 /* push ax */
            ii(0x17_a563, 1); nop();                                    /* nop */
            ii(0x17_a564, 1); push(cs);                                 /* push cs */
            ii(0x17_a565, 3); call(0x17_7f3a, -0x262e);                 /* call 0x7f3a */
            ii(0x17_a568, 3); add(sp, 4);                               /* add sp, 0x4 */
        l_0x17_a56b:
            ii(0x17_a56b, 2); jmp(0x17_a4f9, -0x74); goto l_0x17_a4f9;  /* jmp 0xa4f9 */
        //  ii(0x17_a56d, 1); nop();                                    /* nop */
        l_0x17_a56e:
            ii(0x17_a56e, 2); jmp(0x17_a5e2, 0x72); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        l_0x17_a570:
            ii(0x17_a570, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_a573, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_a576, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_a57a, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_a57e, 3); call(0x17_90c4, -0x14bd);                 /* call 0x90c4 */
            ii(0x17_a581, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_a584, 3); mov(memb[ss, bp - 56], al);               /* mov [bp-0x38], al */
            ii(0x17_a587, 4); cmp(memb[ds, 0x51a6], al);                /* cmp [0x51a6], al */
            ii(0x17_a58b, 2); if(jnz(0x17_a596, 9)) goto l_0x17_a596;   /* jnz 0xa596 */
            ii(0x17_a58d, 5); mov(memw[ss, bp - 18], 0x8002);           /* mov word [bp-0x12], 0x8002 */
            ii(0x17_a592, 3); jmp(0x17_a658, 0xc3); goto l_0x17_a658;   /* jmp 0xa658 */
        //  ii(0x17_a595, 1); nop();                                    /* nop */
        l_0x17_a596:
            ii(0x17_a596, 3); mov(al, memb[ss, bp - 56]);               /* mov al, [bp-0x38] */
            ii(0x17_a599, 4); cmp(memb[ds, 0x51b5], al);                /* cmp [0x51b5], al */
            ii(0x17_a59d, 2); if(jz(0x17_a5a2, 3)) goto l_0x17_a5a2;    /* jz 0xa5a2 */
            ii(0x17_a59f, 2); jmp(0x17_a5e2, 0x41); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        //  ii(0x17_a5a1, 1); nop();                                    /* nop */
        l_0x17_a5a2:
            ii(0x17_a5a2, 3); mov(al, memb[ds, 0x51a7]);                /* mov al, [0x51a7] */
            ii(0x17_a5a5, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_a5a7, 1); push(ax);                                 /* push ax */
            ii(0x17_a5a8, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x17_a5ab, 3); push(memw[ss, bp - 38]);                  /* push word [bp-0x26] */
            ii(0x17_a5ae, 4); push(memw[ds, 0x1fa6]);                   /* push word [0x1fa6] */
            ii(0x17_a5b2, 4); push(memw[ds, 0x1fa4]);                   /* push word [0x1fa4] */
            ii(0x17_a5b6, 3); call(0x17_91e3, -0x13d6);                 /* call 0x91e3 */
            ii(0x17_a5b9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_a5bc, 3); mov(di, 1);                               /* mov di, 0x1 */
            ii(0x17_a5bf, 2); jmp(0x17_a5e2, 0x21); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        //  ii(0x17_a5c1, 1); nop();                                    /* nop */
        l_0x17_a5c2:
            ii(0x17_a5c2, 2); jmp(0x17_a5e2, 0x1e); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        l_0x17_a5c4:
            ii(0x17_a5c4, 5); mov(memw[ss, bp - 18], 0x8021);           /* mov word [bp-0x12], 0x8021 */
            ii(0x17_a5c9, 3); jmp(0x17_a658, 0x8c); goto l_0x17_a658;   /* jmp 0xa658 */
        //  ii(0x17_a5cc, 2); jmp(0x17_a5e2, 0x14); goto l_0x17_a5e2;   /* jmp 0xa5e2 */
        l_0x17_a5ce:
            ii(0x17_a5ce, 3); cmp(ax, 0x10);                            /* cmp ax, 0x10 */
            ii(0x17_a5d1, 2); if(jz(0x17_a5c2, -0x11)) goto l_0x17_a5c2; /* jz 0xa5c2 */
            ii(0x17_a5d3, 2); if(ja(0x17_a5c4, -0x11)) goto l_0x17_a5c4; /* ja 0xa5c4 */
            ii(0x17_a5d5, 2); or(al, al);                               /* or al, al */
            ii(0x17_a5d7, 2); if(jnz(0x17_a5dc, 3)) goto l_0x17_a5dc;   /* jnz 0xa5dc */
            ii(0x17_a5d9, 3); jmp(0x17_a4d0, -0x10c); goto l_0x17_a4d0; /* jmp 0xa4d0 */
        l_0x17_a5dc:
            ii(0x17_a5dc, 2); dec(al);                                  /* dec al */
            ii(0x17_a5de, 2); if(jz(0x17_a570, -0x70)) goto l_0x17_a570; /* jz 0xa570 */
            ii(0x17_a5e0, 2); jmp(0x17_a5c4, -0x1e); goto l_0x17_a5c4;  /* jmp 0xa5c4 */
        l_0x17_a5e2:
            ii(0x17_a5e2, 4); test(si, 0x10);                           /* test si, 0x10 */
            ii(0x17_a5e6, 2); if(jz(0x17_a623, 0x3b)) goto l_0x17_a623; /* jz 0xa623 */
            ii(0x17_a5e8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_a5ea, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x17_a5ed, 3); cmp(ax, 1);                               /* cmp ax, 0x1 */
            ii(0x17_a5f0, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x17_a5f2, 1); inc(ax);                                  /* inc ax */
            ii(0x17_a5f3, 3); shl(al, 6);                               /* shl al, 0x6 */
            ii(0x17_a5f6, 3); xor(al, memb[ss, bp - 46]);               /* xor al, [bp-0x2e] */
            ii(0x17_a5f9, 3); and(ax, 0x40);                            /* and ax, 0x40 */
            ii(0x17_a5fc, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x17_a5fe, 3); xor(memw[ss, bp - 46], ax);               /* xor [bp-0x2e], ax */
            ii(0x17_a601, 3); xor(memw[ss, bp - 44], dx);               /* xor [bp-0x2c], dx */
            ii(0x17_a604, 3); mov(ax, memw[ss, bp - 46]);               /* mov ax, [bp-0x2e] */
            ii(0x17_a607, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x17_a609, 3); and(cx, 0x40);                            /* and cx, 0x40 */
            ii(0x17_a60c, 3); cmp(cx, 1);                               /* cmp cx, 0x1 */
            ii(0x17_a60f, 2); sbb(cx, cx);                              /* sbb cx, cx */
            ii(0x17_a611, 1); inc(cx);                                  /* inc cx */
            ii(0x17_a612, 3); shl(cx, 5);                               /* shl cx, 0x5 */
            ii(0x17_a615, 2); xor(al, cl);                              /* xor al, cl */
            ii(0x17_a617, 3); and(ax, 0x20);                            /* and ax, 0x20 */
            ii(0x17_a61a, 3); xor(memw[ss, bp - 46], ax);               /* xor [bp-0x2e], ax */
            ii(0x17_a61d, 3); xor(memw[ss, bp - 44], dx);               /* xor [bp-0x2c], dx */
            ii(0x17_a620, 3); mov(di, 1);                               /* mov di, 0x1 */
        l_0x17_a623:
            ii(0x17_a623, 2); or(di, di);                               /* or di, di */
            ii(0x17_a625, 2); if(jz(0x17_a641, 0x1a)) goto l_0x17_a641; /* jz 0xa641 */
            ii(0x17_a627, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x17_a629, 4); mov(es, memw[ds, 0xaa]);                  /* mov es, [0xaa] */
            ii(0x17_a62d, 4); mov(edi, memd[ss, bp - 22]);              /* mov edi, [bp-0x16] */
            ii(0x17_a631, 4); mov(ebx, memd[ss, bp - 38]);              /* mov ebx, [bp-0x26] */
            ii(0x17_a635, 4); mov(eax, memd[ss, bp - 46]);              /* mov eax, [bp-0x2e] */
            ii(0x17_a639, 6); mov(memd_a32[es, edi + ebx * 4], eax);    /* mov [es:edi+ebx*4], eax */
            ii(0x17_a63f, 2); mov(di, dx);                              /* mov di, dx */
        l_0x17_a641:
            ii(0x17_a641, 3); or(memw[ss, bp - 52], di);                /* or [bp-0x34], di */
            ii(0x17_a644, 4); add(memw[ss, bp - 38], 1);                /* add word [bp-0x26], 0x1 */
            ii(0x17_a648, 4); adc(memw[ss, bp - 36], 0);                /* adc word [bp-0x24], 0x0 */
            ii(0x17_a64c, 5); add(memw[ss, bp - 8], 0x1000);            /* add word [bp-0x8], 0x1000 */
            ii(0x17_a651, 4); adc(memw[ss, bp - 6], 0);                 /* adc word [bp-0x6], 0x0 */
            ii(0x17_a655, 3); jmp(0x17_a469, -0x1ef); goto l_0x17_a469; /* jmp 0xa469 */
        l_0x17_a658:
            ii(0x17_a658, 4); cmp(memw[ss, bp - 18], 0);                /* cmp word [bp-0x12], 0x0 */
            ii(0x17_a65c, 2); if(jz(0x17_a672, 0x14)) goto l_0x17_a672; /* jz 0xa672 */
            ii(0x17_a65e, 3); mov(ax, memw[ss, bp - 18]);               /* mov ax, [bp-0x12] */
            ii(0x17_a661, 1); cwd();                                    /* cwd */
            ii(0x17_a662, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_a665, 4); mov(memw[es, bx + 32], ax);               /* mov [es:bx+0x20], ax */
            ii(0x17_a669, 4); mov(memw[es, bx + 34], dx);               /* mov [es:bx+0x22], dx */
            ii(0x17_a66d, 5); or(memb[es, bx + 44], 1);                 /* or byte [es:bx+0x2c], 0x1 */
        l_0x17_a672:
            ii(0x17_a672, 1); nop();                                    /* nop */
            ii(0x17_a673, 1); push(cs);                                 /* push cs */
            ii(0x17_a674, 3); call(0x17_488e, -0x5de9);                 /* call 0x488e */
            ii(0x17_a677, 4); cmp(memw[ss, bp - 52], 0);                /* cmp word [bp-0x34], 0x0 */
            ii(0x17_a67b, 2); if(jz(0x17_a683, 6)) goto l_0x17_a683;    /* jz 0xa683 */
            ii(0x17_a67d, 3); mov(eax, cr3);                            /* mov eax, cr3 */
            ii(0x17_a680, 3); mov(cr3, eax);                            /* mov cr3, eax */
        l_0x17_a683:
            ii(0x17_a683, 1); pop(ds);                                  /* pop ds */
            ii(0x17_a684, 1); pop(si);                                  /* pop si */
            ii(0x17_a685, 1); pop(di);                                  /* pop di */
            ii(0x17_a686, 1); leave();                                  /* leave */
            ii(0x17_a687, 1); retf();                                   /* retf */
        }
    }
}
