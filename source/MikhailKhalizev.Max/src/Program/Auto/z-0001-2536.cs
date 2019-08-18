using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a57a60ee-649f-49ea-9983-cb8e2d26d12a")]
        public void Method_0001_2536()
        {
            ii(0x1_2536, 3);  callw(0xfcd2, -0x2867);                   /* call 0xfcd2 */
            ii(0x1_2539, 6);  lss(esp, ds, 0xc18);                      /* lss esp, [0xc18] */
            ii(0x1_253f, 6);  add(memw_a16[ds, 0x996], 0x180);          /* add word [0x996], 0x180 */
            ii(0x1_2545, 4);  popw(memw_a16[ds, 0xc1c]);                /* pop word [0xc1c] */
            ii(0x1_2549, 5);  popd(memd_a16[ds, 0xc18]);                /* pop dword [0xc18] */
            ii(0x1_254e, 2);  popd(edi);                                /* pop edi */
            ii(0x1_2550, 2);  mov(bl, ah);                              /* mov bl, ah */
            ii(0x1_2552, 2);  mov(bh, dl);                              /* mov bh, dl */
            ii(0x1_2554, 2);  mov(cl, dh);                              /* mov cl, dh */
            ii(0x1_2556, 2);  mov(ch, 0);                               /* mov ch, 0x0 */
            ii(0x1_2558, 1);  pushw(cx);                                /* push cx */
            ii(0x1_2559, 1);  pushw(bx);                                /* push bx */
            ii(0x1_255a, 4);  mov(dx, memw_a16[ds, 0x11fc]);            /* mov dx, [0x11fc] */
            ii(0x1_255e, 3);  mov(ax, memw_a16[ds, 0x11fa]);            /* mov ax, [0x11fa] */
            ii(0x1_2561, 2);  mov(bl, ah);                              /* mov bl, ah */
            ii(0x1_2563, 2);  mov(bh, dl);                              /* mov bh, dl */
            ii(0x1_2565, 2);  mov(cl, dh);                              /* mov cl, dh */
            ii(0x1_2567, 3);  callw(0x1_25fa, 0x90);                    /* call 0x25fa */
            ii(0x1_256a, 4);  mov(es, memw_a32[ss, ebp + 0x2]);         /* mov es, [ebp+0x2] */
            ii(0x1_256e, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2570, 2);  mov(ax, dx);                              /* mov ax, dx */
            ii(0x1_2572, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2574, 2);  mov(ax, bx);                              /* mov ax, bx */
            ii(0x1_2576, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2578, 2);  mov(ax, cx);                              /* mov ax, cx */
            ii(0x1_257a, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_257c, 2);  mov(ax, bx);                              /* mov ax, bx */
            ii(0x1_257e, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2580, 2);  mov(ax, cx);                              /* mov ax, cx */
            ii(0x1_2582, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2584, 3);  mov(ax, memw_a16[ds, 0x9d]);              /* mov ax, [0x9d] */
            ii(0x1_2587, 4);  sub(ax, memw_a16[ds, 0x99]);              /* sub ax, [0x99] */
            ii(0x1_258b, 4);  mov(dl, memb_a16[ds, 0x9f]);              /* mov dl, [0x9f] */
            ii(0x1_258f, 4);  sbb(dl, memb_a16[ds, 0x9b]);              /* sbb dl, [0x9b] */
            ii(0x1_2593, 2);  mov(dh, 0);                               /* mov dh, 0x0 */
            ii(0x1_2595, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_2597, 2);  mov(ax, dx);                              /* mov ax, dx */
            ii(0x1_2599, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_259b, 2);  mov(ax, bx);                              /* mov ax, bx */
            ii(0x1_259d, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_259f, 1);  popw(bx);                                 /* pop bx */
            ii(0x1_25a0, 1);  popw(cx);                                 /* pop cx */
            ii(0x1_25a1, 2);  mov(ax, cx);                              /* mov ax, cx */
            ii(0x1_25a3, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25a5, 2);  mov(ax, bx);                              /* mov ax, bx */
            ii(0x1_25a7, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25a9, 2);  mov(ax, cx);                              /* mov ax, cx */
            ii(0x1_25ab, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25ad, 3);  mov(ax, memw_a16[ds, 0x9d]);              /* mov ax, [0x9d] */
            ii(0x1_25b0, 4);  sub(ax, memw_a16[ds, 0x99]);              /* sub ax, [0x99] */
            ii(0x1_25b4, 4);  mov(dl, memb_a16[ds, 0x9f]);              /* mov dl, [0x9f] */
            ii(0x1_25b8, 4);  sbb(dl, memb_a16[ds, 0x9b]);              /* sbb dl, [0x9b] */
            ii(0x1_25bc, 2);  mov(dh, 0);                               /* mov dh, 0x0 */
            ii(0x1_25be, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25c0, 2);  mov(ax, dx);                              /* mov ax, dx */
            ii(0x1_25c2, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25c4, 2);  mov(ax, bx);                              /* mov ax, bx */
            ii(0x1_25c6, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25c8, 2);  mov(ax, cx);                              /* mov ax, cx */
            ii(0x1_25ca, 2);  stosw_a32();                              /* a32 stosw */
            ii(0x1_25cc, 3);  mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x1_25cf, 6);  mov(ecx, 0x8);                            /* mov ecx, 0x8 */
            ii(0x1_25d5, 3);  rep_a32(() => stosw_a32());               /* a32 rep stosw */
            ii(0x1_25d8, 3);  if(jmpw_func(0x1_2037, -0x5a4)) return;   /* jmp 0x2037 */
        }
    }
}
