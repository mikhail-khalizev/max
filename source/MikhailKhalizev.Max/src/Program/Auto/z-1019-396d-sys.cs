using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_396d-1a954e7e")]
        public void /* sys */ Method_1019_396d()
        {
            ii(0x1019_396d, 3);  mov(ecx, memd[ss, ebp + 20]);         /* mov ecx, [ebp+0x14] */
            ii(0x1019_3970, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_3975, 2);  jmp(0x1019_397d, 6); goto l_0x1019_397d;/* jmp 0x1019397d */
        l_0x1019_3977:
            ii(0x1019_3977, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_397a, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_397d:
            ii(0x1019_397d, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3980, 2);  if(jz(0x1019_3977, -0xb)) goto l_0x1019_3977;/* jz 0x10193977 */
            ii(0x1019_3982, 2);  if(jb(0x1019_399b, 0x17)) goto l_0x1019_399b;/* jb 0x1019399b */
            ii(0x1019_3984, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_3987, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_398a, 2);  if(loop(0x1019_397d, -0xf)) goto l_0x1019_397d;/* loop 0x1019397d */
            ii(0x1019_398c, 2);  if(jmp_func(0x1019_394d, -0x41)) return;/* jmp 0x1019394d */
        l_0x1019_398e:
            ii(0x1019_398e, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_3991, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_3994:
            ii(0x1019_3994, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3997, 2);  if(ja(0x1019_39a7, 0xe)) goto l_0x1019_39a7;/* ja 0x101939a7 */
            ii(0x1019_3999, 2);  if(jz(0x1019_398e, -0xd)) goto l_0x1019_398e;/* jz 0x1019398e */
        l_0x1019_399b:
            ii(0x1019_399b, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1019_399e, 2);  if(loop(0x1019_3994, -0xc)) goto l_0x1019_3994;/* loop 0x10193994 */
            ii(0x1019_39a0, 5);  call(/* sys */ 0x1019_39bb, 0x16);    /* call 0x101939bb */
            ii(0x1019_39a5, 2);  if(jmp_func(0x1019_394d, -0x5a)) return;/* jmp 0x1019394d */
        l_0x1019_39a7:
            ii(0x1019_39a7, 5);  call(/* sys */ 0x1019_39bb, 0xf);     /* call 0x101939bb */
            ii(0x1019_39ac, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_39af, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_39b2, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_39b7, 2);  if(loop(0x1019_397d, -0x3c)) goto l_0x1019_397d;/* loop 0x1019397d */
            ii(0x1019_39b9, 2);  jmp_func(0x1019_394d, -0x6e);         /* jmp 0x1019394d */
        }
    }
}
