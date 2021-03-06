using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_6046-dcde97c1")]
        public void /* sys */ sys_sqrt()
        {
            ii(0x1016_6046, 2);  mov(al, 3);                           /* mov al, 0x3 */
            ii(0x1016_6048, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_6049, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_604b, 2);  ftst();                               /* ftst */
            ii(0x1016_604d, 3);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1016_6050, 1);  wait();                               /* wait */
            ii(0x1016_6051, 3);  fnstsw(memw[ss, ebp - 8]);            /* fnstsw word [ebp-0x8] */
            ii(0x1016_6054, 1);  wait();                               /* wait */
            ii(0x1016_6055, 4);  xchg(memw[ss, ebp - 8], ax);          /* xchg [ebp-0x8], ax */
            ii(0x1016_6059, 1);  sahf();                               /* sahf */
            ii(0x1016_605a, 2);  if(jae(0x1016_6075, 0x19)) goto l_0x1016_6075;/* jae 0x10166075 */
            ii(0x1016_605c, 3);  fstp(memq[ss, ebp - 16]);             /* fstp qword [ebp-0x10] */
            ii(0x1016_605f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_6062, 2);  cmp(al, 3);                           /* cmp al, 0x3 */
            ii(0x1016_6064, 2);  if(jz(0x1016_6069, 3)) goto l_0x1016_6069;/* jz 0x10166069 */
            ii(0x1016_6066, 3);  fstp(memq[ss, ebp - 16]);             /* fstp qword [ebp-0x10] */
        l_0x1016_6069:
            ii(0x1016_6069, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_606c, 5);  call(/* sys */ 0x1018_1f17, 0x1_bea6);/* call 0x10181f17 */
            ii(0x1016_6071, 2);  mov(al, 1);                           /* mov al, 0x1 */
            ii(0x1016_6073, 2);  jmp(0x1016_6079, 4); goto l_0x1016_6079;/* jmp 0x10166079 */
        l_0x1016_6075:
            ii(0x1016_6075, 2);  fsqrt();                              /* fsqrt */
            ii(0x1016_6077, 2);  mov(al, 0);                           /* mov al, 0x0 */
        l_0x1016_6079:
            ii(0x1016_6079, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_607b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_607c, 1);  ret();                                /* ret */
        }
    }
}
