using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb1d9-3cf7074f")]
        public void Method_0000_b1d9()
        {
            ii(0xb1d9, 5);    mov(eax, memd[cs, 0x7bb2]);               /* mov eax, [cs:0x7bb2] */
            ii(0xb1de, 6);    movzx(edi, memw[ds, 0xeca]);              /* movzx edi, word [0xeca] */
            ii(0xb1e4, 6);    mov(ebx, 0x1000);                         /* mov ebx, 0x1000 */
            ii(0xb1ea, 4);    mov(cx, memw[ds, 0xdfa]);                 /* mov cx, [0xdfa] */
            ii(0xb1ee, 2);    add(cx, di);                              /* add cx, di */
            ii(0xb1f0, 4);    shl(eax, 4);                              /* shl eax, 0x4 */
            ii(0xb1f4, 3);    add(eax, ebx);                            /* add eax, ebx */
            ii(0xb1f7, 2);    dec(eax);                                 /* dec eax */
            ii(0xb1f9, 3);    and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0xb1fc, 3);    or(ax, 0xc07);                            /* or ax, 0xc07 */
        l_0xb1ff:
            ii(0xb1ff, 2);    cmp(di, cx);                              /* cmp di, cx */
            ii(0xb201, 2);    if(jae(0xb211, 0xe)) goto l_0xb211;       /* jae 0xb211 */
            ii(0xb203, 6);    mov(memd_a32[es, esi + edi], eax);        /* mov [es:esi+edi], eax */
            ii(0xb209, 3);    add(di, 4);                               /* add di, 0x4 */
            ii(0xb20c, 3);    add(eax, ebx);                            /* add eax, ebx */
            ii(0xb20f, 2);    jmp(0xb1ff, -0x12); goto l_0xb1ff;        /* jmp 0xb1ff */
        l_0xb211:
            ii(0xb211, 4);    shl(edi, 6);                              /* shl edi, 0x6 */
            ii(0xb215, 5);    mov(memd[ds, 0xac], edi);                 /* mov [0xac], edi */
            ii(0xb21a, 1);    ret();                                    /* ret */
        }
    }
}
