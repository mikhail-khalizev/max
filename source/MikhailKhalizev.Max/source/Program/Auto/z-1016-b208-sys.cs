using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b208-59478654")]
        public void /* sys */ Method_1016_b208()
        {
            ii(0x1016_b208, 1);  push(edx);                            /* push edx */
            ii(0x1016_b209, 5);  call(/* sys */ 0x1016_b258, 0x4a);    /* call 0x1016b258 */
            ii(0x1016_b20e, 5);  call(/* sys */ 0x1016_b310, 0xfd);    /* call 0x1016b310 */
            ii(0x1016_b213, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1016_b215, 3);  cmp(eax, -1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_b218, 2);  if(jnz(0x1016_b239, 0x1f)) goto l_0x1016_b239;/* jnz 0x1016b239 */
            ii(0x1016_b21a, 5);  call(/* sys */ 0x1016_c348, 0x1129);  /* call 0x1016c348 */
            ii(0x1016_b21f, 2);  test(al, 0x33);                       /* test al, 0x33 */
            ii(0x1016_b221, 2);  if(jz(0x1016_b239, 0x16)) goto l_0x1016_b239;/* jz 0x1016b239 */
            ii(0x1016_b223, 5);  mov(edx, 0x101c_fb50);                /* mov edx, 0x101cfb50 */
            ii(0x1016_b228, 5);  mov(eax, 0x101c_fb4c);                /* mov eax, 0x101cfb4c */
            ii(0x1016_b22d, 5);  call(/* sys */ 0x1016_c298, 0x1066);  /* call 0x1016c298 */
            ii(0x1016_b232, 5);  mov(eax, 0xffff_fffe);                /* mov eax, 0xfffffffe */
            ii(0x1016_b237, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b238, 1);  ret(); return;                        /* ret */
        l_0x1016_b239:
            ii(0x1016_b239, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_b23b, 5);  call(/* sys */ 0x1016_7f58, -0x32e8); /* call 0x10167f58 */
            ii(0x1016_b240, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b241, 1);  ret();                                /* ret */
        }
    }
}
