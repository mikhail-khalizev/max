using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaec1-9da3bec0")]
        public void Method_0000_aec1()
        {
            ii(0xaec1, 5);  cmp(memb[ds, 0xdff], 0);                   /* cmp byte [0xdff], 0x0 */
            ii(0xaec6, 2);  if(jz(0xaeda, 0x12)) goto l_0xaeda;        /* jz 0xaeda */
            ii(0xaec8, 5);  or(memb[ds, 0xa16], 1);                    /* or byte [0xa16], 0x1 */
            ii(0xaecd, 5);  test(memb[ds, 0x11d2], 1);                 /* test byte [0x11d2], 0x1 */
            ii(0xaed2, 2);  if(jnz(0xaeda, 6)) goto l_0xaeda;          /* jnz 0xaeda */
            ii(0xaed4, 6);  mov(memw[ds, 0xecc], 0xef00);              /* mov word [0xecc], 0xef00 */
        l_0xaeda:
            ii(0xaeda, 2);  mov(ax, ds);                               /* mov ax, ds */
            ii(0xaedc, 3);  mov(bx, 0x10);                             /* mov bx, 0x10 */
            ii(0xaedf, 2);  mul(bx);                                   /* mul bx */
            ii(0xaee1, 4);  add(memw[ds, 0xd34], ax);                  /* add [0xd34], ax */
            ii(0xaee5, 4);  adc(memw[ds, 0xd36], dx);                  /* adc [0xd36], dx */
            ii(0xaee9, 4);  add(memw[ds, 0xd3c], ax);                  /* add [0xd3c], ax */
            ii(0xaeed, 4);  adc(memw[ds, 0xd3e], dx);                  /* adc [0xd3e], dx */
            ii(0xaef1, 4);  add(memw[ds, 0xd40], ax);                  /* add [0xd40], ax */
            ii(0xaef5, 4);  adc(memw[ds, 0xd42], dx);                  /* adc [0xd42], dx */
            ii(0xaef9, 3);  add(ax, 0xd74);                            /* add ax, 0xd74 */
            ii(0xaefc, 3);  adc(dx, 0);                                /* adc dx, 0x0 */
            ii(0xaeff, 3);  mov(memw[ds, 0x91a], ax);                  /* mov [0x91a], ax */
            ii(0xaf02, 4);  mov(memb[ds, 0x91c], dl);                  /* mov [0x91c], dl */
            ii(0xaf06, 3);  mov(ax, memw[ds, 0xaa]);                   /* mov ax, [0xaa] */
            ii(0xaf09, 2);  inc(ah);                                   /* inc ah */
            ii(0xaf0b, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0xaf0d, 2);  xor(di, di);                               /* xor di, di */
            ii(0xaf0f, 3);  mov(si, 0x940);                            /* mov si, 0x940 */
            ii(0xaf12, 3);  mov(ax, 0xde01);                           /* mov ax, 0xde01 */
            ii(0xaf15, 2);  @int(0x67);                                /* int 0x67 */
            ii(0xaf17, 2);  or(ah, ah);                                /* or ah, ah */
            ii(0xaf19, 2);  jz_func(0xaf23, 8);                        /* jz 0xaf23 */
        }
    }
}
