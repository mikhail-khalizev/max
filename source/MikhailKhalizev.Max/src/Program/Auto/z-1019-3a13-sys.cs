using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3a13-cae9dcc5")]
        public void /* sys */ Method_1019_3a13()
        {
            ii(0x1019_3a13, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_3a14, 1);  push(edx);                            /* push edx */
            ii(0x1019_3a15, 1);  push(esi);                            /* push esi */
            ii(0x1019_3a16, 1);  push(edi);                            /* push edi */
            ii(0x1019_3a17, 3);  mov(ecx, memd[ss, ebp + 20]);         /* mov ecx, [ebp+0x14] */
            ii(0x1019_3a1a, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_3a1f, 2);  jmp(0x1019_3a27, 6); goto l_0x1019_3a27;/* jmp 0x10193a27 */
        l_0x1019_3a21:
            ii(0x1019_3a21, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_3a24, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_3a27:
            ii(0x1019_3a27, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3a2a, 2);  if(jz(0x1019_3a21, -0xb)) goto l_0x1019_3a21;/* jz 0x10193a21 */
            ii(0x1019_3a2c, 2);  if(jb(0x1019_3a48, 0x1a)) goto l_0x1019_3a48;/* jb 0x10193a48 */
            ii(0x1019_3a2e, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_3a31, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_3a34, 2);  if(loop(0x1019_3a27, -0xf)) goto l_0x1019_3a27;/* loop 0x10193a27 */
            ii(0x1019_3a36, 5);  if(jmp_func(0x1019_3b0f, 0xd4)) return;/* jmp 0x10193b0f */
        l_0x1019_3a3b:
            ii(0x1019_3a3b, 3);  mov(dx, memw[ds, ebx]);               /* mov dx, [ebx] */
            ii(0x1019_3a3e, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
        l_0x1019_3a41:
            ii(0x1019_3a41, 3);  add(dx, dx);                          /* add dx, dx */
            ii(0x1019_3a44, 2);  if(ja(0x1019_3a57, 0x11)) goto l_0x1019_3a57;/* ja 0x10193a57 */
            ii(0x1019_3a46, 2);  if(jz(0x1019_3a3b, -0xd)) goto l_0x1019_3a3b;/* jz 0x10193a3b */
        l_0x1019_3a48:
            ii(0x1019_3a48, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1019_3a4b, 2);  if(loop(0x1019_3a41, -0xc)) goto l_0x1019_3a41;/* loop 0x10193a41 */
            ii(0x1019_3a4d, 5);  call(/* sys */ 0x1019_3a6e, 0x1c);    /* call 0x10193a6e */
            ii(0x1019_3a52, 5);  if(jmp_func(0x1019_3b0f, 0xb8)) return;/* jmp 0x10193b0f */
        l_0x1019_3a57:
            ii(0x1019_3a57, 5);  call(/* sys */ 0x1019_3a6e, 0x12);    /* call 0x10193a6e */
            ii(0x1019_3a5c, 3);  add(esi, 8);                          /* add esi, 0x8 */
            ii(0x1019_3a5f, 3);  add(edi, 8);                          /* add edi, 0x8 */
            ii(0x1019_3a62, 5);  mov(eax, 0);                          /* mov eax, 0x0 */
            ii(0x1019_3a67, 2);  if(loop(0x1019_3a27, -0x42)) goto l_0x1019_3a27;/* loop 0x10193a27 */
            ii(0x1019_3a69, 5);  if(jmp_func(0x1019_3b0f, 0xa1)) return;/* jmp 0x10193b0f */
        }
    }
}
