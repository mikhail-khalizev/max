using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb989-3cf7074f")]
        public void Method_0000_b989()
        {
            ii(0xb989, 5);  mov(eax, memd[cs, 0x7bb2]);                /* mov eax, [cs:0x7bb2] */
            ii(0xb98e, 6);  movzx(edi, memw[ds, 0xeca]);               /* movzx edi, word [0xeca] */
            ii(0xb994, 6);  mov(ebx, 0x1000);                          /* mov ebx, 0x1000 */
            ii(0xb99a, 4);  mov(cx, memw[ds, 0xdfa]);                  /* mov cx, [0xdfa] */
            ii(0xb99e, 2);  add(cx, di);                               /* add cx, di */
            ii(0xb9a0, 4);  shl(eax, 4);                               /* shl eax, 0x4 */
            ii(0xb9a4, 3);  add(eax, ebx);                             /* add eax, ebx */
            ii(0xb9a7, 2);  dec(eax);                                  /* dec eax */
            ii(0xb9a9, 3);  and(ax, 0xf000);                           /* and ax, 0xf000 */
            ii(0xb9ac, 3);  or(ax, 0xc07);                             /* or ax, 0xc07 */
        l_0xb9af:
            ii(0xb9af, 2);  cmp(di, cx);                               /* cmp di, cx */
            ii(0xb9b1, 2);  if(jae(0xb9c1, 0xe)) goto l_0xb9c1;        /* jae 0xb9c1 */
            ii(0xb9b3, 6);  mov(memd_a32[es, esi + edi], eax);         /* mov [es:esi+edi], eax */
            ii(0xb9b9, 3);  add(di, 4);                                /* add di, 0x4 */
            ii(0xb9bc, 3);  add(eax, ebx);                             /* add eax, ebx */
            ii(0xb9bf, 2);  jmp(0xb9af, -0x12); goto l_0xb9af;         /* jmp 0xb9af */
        l_0xb9c1:
            ii(0xb9c1, 4);  shl(edi, 6);                               /* shl edi, 0x6 */
            ii(0xb9c5, 5);  mov(memd[ds, 0xac], edi);                  /* mov [0xac], edi */
            ii(0xb9ca, 1);  ret();                                     /* ret */
        }
    }
}
