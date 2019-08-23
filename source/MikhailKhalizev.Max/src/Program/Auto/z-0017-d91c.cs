using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_d91c-499350fe")]
        public void Method_0017_d91c()
        {
            ii(0x17_d91c, 1); push(bp);                                 /* push bp */
            ii(0x17_d91d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_d91f, 3); sub(sp, 0x4);                             /* sub sp, 0x4 */
            ii(0x17_d922, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x17_d925, 4); cmp(bx, memw[ds, 0x1c5b]);                /* cmp bx, [0x1c5b] */
            ii(0x17_d929, 2); if(jb(0x17_d930, 0x5)) goto l_0x17_d930;  /* jb 0xd930 */
            ii(0x17_d92b, 3); mov(ax, 0x900);                           /* mov ax, 0x900 */
            ii(0x17_d92e, 2); jmp(0x17_d95a, 0x2a); goto l_0x17_d95a;   /* jmp 0xd95a */
        l_0x17_d930:
            ii(0x17_d930, 5); test(memw[ss, bp + 0xa], 0x8000);         /* test word [bp+0xa], 0x8000 */
            ii(0x17_d935, 2); if(jz(0x17_d97f, 0x48)) goto l_0x17_d97f; /* jz 0xd97f */
            ii(0x17_d937, 4); cmp(memw[ss, bp + 0xc], 0);               /* cmp word [bp+0xc], 0x0 */
            ii(0x17_d93b, 2); if(jz(0x17_d957, 0x1a)) goto l_0x17_d957; /* jz 0xd957 */
            ii(0x17_d93d, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x17_d93f, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x17_d941, 3); mov(ax, 0x4201);                          /* mov ax, 0x4201 */
            ii(0x17_d944, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d946, 2); if(jb(0x17_d993, 0x4b)) goto l_0x17_d993; /* jb 0xd993 */
            ii(0x17_d948, 5); test(memw[ss, bp + 0xc], 0x2);            /* test word [bp+0xc], 0x2 */
            ii(0x17_d94d, 2); if(jnz(0x17_d95d, 0xe)) goto l_0x17_d95d; /* jnz 0xd95d */
            ii(0x17_d94f, 3); add(ax, memw[ss, bp + 0x8]);              /* add ax, [bp+0x8] */
            ii(0x17_d952, 3); adc(dx, memw[ss, bp + 0xa]);              /* adc dx, [bp+0xa] */
            ii(0x17_d955, 2); if(jns(0x17_d97f, 0x28)) goto l_0x17_d97f; /* jns 0xd97f */
        l_0x17_d957:
            ii(0x17_d957, 3); mov(ax, 0x1600);                          /* mov ax, 0x1600 */
        l_0x17_d95a:
            ii(0x17_d95a, 1); stc();                                    /* stc */
            ii(0x17_d95b, 2); jmp(0x17_d993, 0x36); goto l_0x17_d993;   /* jmp 0xd993 */
        l_0x17_d95d:
            ii(0x17_d95d, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_d960, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_d963, 2); mov(dx, cx);                              /* mov dx, cx */
            ii(0x17_d965, 3); mov(ax, 0x4202);                          /* mov ax, 0x4202 */
            ii(0x17_d968, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d96a, 3); add(ax, memw[ss, bp + 0x8]);              /* add ax, [bp+0x8] */
            ii(0x17_d96d, 3); adc(dx, memw[ss, bp + 0xa]);              /* adc dx, [bp+0xa] */
            ii(0x17_d970, 2); if(jns(0x17_d97f, 0xd)) goto l_0x17_d97f; /* jns 0xd97f */
            ii(0x17_d972, 3); mov(cx, memw[ss, bp - 0x2]);              /* mov cx, [bp-0x2] */
            ii(0x17_d975, 3); mov(dx, memw[ss, bp - 0x4]);              /* mov dx, [bp-0x4] */
            ii(0x17_d978, 3); mov(ax, 0x4200);                          /* mov ax, 0x4200 */
            ii(0x17_d97b, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d97d, 2); jmp(0x17_d957, -0x28); goto l_0x17_d957;  /* jmp 0xd957 */
        l_0x17_d97f:
            ii(0x17_d97f, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_d982, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x17_d985, 3); mov(al, memb[ss, bp + 0xc]);              /* mov al, [bp+0xc] */
            ii(0x17_d988, 2); mov(ah, 0x42);                            /* mov ah, 0x42 */
            ii(0x17_d98a, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d98c, 2); if(jb(0x17_d993, 0x5)) goto l_0x17_d993;  /* jb 0xd993 */
            ii(0x17_d98e, 5); and(memb[ds, bx + 0x1c5d], -0x3 /* 0xfd */); /* and byte [bx+0x1c5d], 0xfd */
        l_0x17_d993:
            ii(0x17_d993, 3); if(jmp_func(0x17_d8bb, -0xdb)) return;    /* jmp 0xd8bb */
        }
    }
}
