using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_c5dc-da13707")]
        public void Method_1019_c5dc()
        {
            ii(0x1019_c5dc, 2);  ftst();                               /* ftst */
            ii(0x1019_c5de, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_c5df, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_c5e1, 3);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1019_c5e4, 1);  wait();                               /* wait */
            ii(0x1019_c5e5, 3);  fnstsw(memw[ss, ebp - 16]);           /* fnstsw word [ebp-0x10] */
            ii(0x1019_c5e8, 1);  wait();                               /* wait */
            ii(0x1019_c5e9, 3);  mov(ah, memb[ss, ebp - 15]);          /* mov ah, [ebp-0xf] */
            ii(0x1019_c5ec, 1);  sahf();                               /* sahf */
            ii(0x1019_c5ed, 2);  if(ja(0x1019_c601, 0x12)) goto l_0x1019_c601;/* ja 0x1019c601 */
            ii(0x1019_c5ef, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1019_c5f2, 3);  fstp(memq[ss, ebp - 16]);             /* fstp qword [ebp-0x10] */
            ii(0x1019_c5f5, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1019_c5f8, 5);  call(0x1019_cca5, 0x6a8);             /* call 0x1019cca5 */
            ii(0x1019_c5fd, 2);  mov(al, 1);                           /* mov al, 0x1 */
            ii(0x1019_c5ff, 2);  jmp(0x1019_c619, 0x18); goto l_0x1019_c619;/* jmp 0x1019c619 */
        l_0x1019_c601:
            ii(0x1019_c601, 2);  cmp(al, 0xb);                         /* cmp al, 0xb */
            ii(0x1019_c603, 2);  if(jnz(0x1019_c609, 4)) goto l_0x1019_c609;/* jnz 0x1019c609 */
            ii(0x1019_c605, 2);  fldlg2();                             /* fldlg2 */
            ii(0x1019_c607, 2);  jmp(0x1019_c613, 0xa); goto l_0x1019_c613;/* jmp 0x1019c613 */
        l_0x1019_c609:
            ii(0x1019_c609, 2);  cmp(al, 9);                           /* cmp al, 0x9 */
            ii(0x1019_c60b, 2);  if(jnz(0x1019_c611, 4)) goto l_0x1019_c611;/* jnz 0x1019c611 */
            ii(0x1019_c60d, 2);  fld1();                               /* fld1 */
            ii(0x1019_c60f, 2);  jmp(0x1019_c613, 2); goto l_0x1019_c613;/* jmp 0x1019c613 */
        l_0x1019_c611:
            ii(0x1019_c611, 2);  fldln2();                             /* fldln2 */
        l_0x1019_c613:
            ii(0x1019_c613, 2);  fxch(ST(0), ST(1));                   /* fxch st0, st1 */
            ii(0x1019_c615, 2);  fyl2x();                              /* fyl2x */
            ii(0x1019_c617, 2);  mov(al, 0);                           /* mov al, 0x0 */
        l_0x1019_c619:
            ii(0x1019_c619, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1019_c61b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_c61c, 1);  ret();                                /* ret */
        }
    }
}
