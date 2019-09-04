using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_2130-359081be")]
        public void Method_0001_2130()
        {
            ii(0x1_2130, 3);  call(0x1_2040, -0xf3);                   /* call 0x2040 */
            ii(0x1_2133, 2);  if(jb_func(0x1_211d, -0x18)) return;     /* jb 0x211d */
            ii(0x1_2135, 2);  if(jcxz_func(0x1_211d, -0x1a)) return;   /* jcxz 0x211d */
            ii(0x1_2137, 4);  cmp(bx, 0x80);                           /* cmp bx, 0x80 */
            ii(0x1_213b, 2);  if(jb_func(0x1_211d, -0x20)) return;     /* jb 0x211d */
            ii(0x1_213d, 2);  xor(ax, ax);                             /* xor ax, ax */
            ii(0x1_213f, 3);  mov(memb[ds, bx + 5], al);               /* mov [bx+0x5], al */
            ii(0x1_2142, 2);  push(0x50);                              /* push 0x50 */
            ii(0x1_2144, 1);  pop(ds);                                 /* pop ds */
            ii(0x1_2145, 3);  shr(bx, 3);                              /* shr bx, 0x3 */
            ii(0x1_2148, 2);  mov(memb[ds, bx], al);                   /* mov [bx], al */
            ii(0x1_214a, 4);  mov(cx, memw_a32[ss, ebp]);              /* mov cx, [ebp] */
            ii(0x1_214e, 3);  shr(cx, 3);                              /* shr cx, 0x3 */
            ii(0x1_2151, 2);  xor(cx, bx);                             /* xor cx, bx */
            ii(0x1_2153, 4);  if(jnz(0x1_215b, 4)) goto l_0x1_215b;    /* jnz 0x215b */
            ii(0x1_2157, 4);  mov(memw_a32[ss, ebp], cx);              /* mov [ebp], cx */
        l_0x1_215b:
            ii(0x1_215b, 4);  mov(cx, memw_a32[ss, ebp + 2]);          /* mov cx, [ebp+0x2] */
            ii(0x1_215f, 3);  shr(cx, 3);                              /* shr cx, 0x3 */
            ii(0x1_2162, 2);  xor(cx, bx);                             /* xor cx, bx */
            ii(0x1_2164, 4);  if(jnz(0x1_216c, 4)) goto l_0x1_216c;    /* jnz 0x216c */
            ii(0x1_2168, 4);  mov(memw_a32[ss, ebp + 2], cx);          /* mov [ebp+0x2], cx */
        l_0x1_216c:
            ii(0x1_216c, 2);  mov(cx, fs);                             /* mov cx, fs */
            ii(0x1_216e, 3);  shr(cx, 3);                              /* shr cx, 0x3 */
            ii(0x1_2171, 2);  xor(cx, bx);                             /* xor cx, bx */
            ii(0x1_2173, 4);  if(jnz(0x1_2179, 2)) goto l_0x1_2179;    /* jnz 0x2179 */
            ii(0x1_2177, 2);  mov(fs, cx);                             /* mov fs, cx */
        l_0x1_2179:
            ii(0x1_2179, 2);  mov(cx, gs);                             /* mov cx, gs */
            ii(0x1_217b, 3);  shr(cx, 3);                              /* shr cx, 0x3 */
            ii(0x1_217e, 2);  xor(cx, bx);                             /* xor cx, bx */
            ii(0x1_2180, 4);  if(jnz(0x1_2186, 2)) goto l_0x1_2186;    /* jnz 0x2186 */
            ii(0x1_2184, 2);  mov(gs, cx);                             /* mov gs, cx */
        l_0x1_2186:
            ii(0x1_2186, 3);  if(jmp_func(0x1_2037, -0x152)) return;   /* jmp 0x2037 */
        }
    }
}
