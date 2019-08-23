using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xd999-3cf7074f")]
        public void Method_0000_d999()
        {
            ii(0xd999, 5);    mov(eax, memd_a16[cs, 0x7bb2]);           /* mov eax, [cs:0x7bb2] */
            ii(0xd99e, 6);    movzx(edi, memw_a16[ds, 0xeca]);          /* movzx edi, word [0xeca] */
            ii(0xd9a4, 6);    mov(ebx, 0x1000);                         /* mov ebx, 0x1000 */
            ii(0xd9aa, 4);    mov(cx, memw_a16[ds, 0xdfa]);             /* mov cx, [0xdfa] */
            ii(0xd9ae, 2);    add(cx, di);                              /* add cx, di */
            ii(0xd9b0, 4);    shl(eax, 0x4);                            /* shl eax, 0x4 */
            ii(0xd9b4, 3);    add(eax, ebx);                            /* add eax, ebx */
            ii(0xd9b7, 2);    dec(eax);                                 /* dec eax */
            ii(0xd9b9, 3);    and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0xd9bc, 3);    or(ax, 0xc07);                            /* or ax, 0xc07 */
        l_0xd9bf:
            ii(0xd9bf, 2);    cmp(di, cx);                              /* cmp di, cx */
            ii(0xd9c1, 2);    if(jaew(0xd9d1, 0xe)) goto l_0xd9d1;      /* jae 0xd9d1 */
            ii(0xd9c3, 6);    mov(memd_a32[es, esi + edi], eax);        /* mov [es:esi+edi], eax */
            ii(0xd9c9, 3);    add(di, 0x4);                             /* add di, 0x4 */
            ii(0xd9cc, 3);    add(eax, ebx);                            /* add eax, ebx */
            ii(0xd9cf, 2);    jmpw(0xd9bf, -0x12); goto l_0xd9bf;       /* jmp 0xd9bf */
        l_0xd9d1:
            ii(0xd9d1, 4);    shl(edi, 0x6);                            /* shl edi, 0x6 */
            ii(0xd9d5, 5);    mov(memd_a16[ds, 0xac], edi);             /* mov [0xac], edi */
            ii(0xd9da, 1);    retw();                                   /* ret */
        }
    }
}
