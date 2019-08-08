using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c8a83769-b786-4bee-a2fa-9b6cc3a94427")]
        public void Method_0000_9c08()
        {
            ii(0x9c08, 2);    pushfd();                                 /* pushfd */
            ii(0x9c0a, 2);    pushfd();                                 /* pushfd */
            ii(0x9c0c, 2);    popd(edx);                                /* pop edx */
            ii(0x9c0e, 3);    mov(ecx, edx);                            /* mov ecx, edx */
            ii(0x9c11, 5);    btc(edx, 0x15);                           /* btc edx, 0x15 */
            ii(0x9c16, 5);    btc(edx, 0x12);                           /* btc edx, 0x12 */
            ii(0x9c1b, 2);    pushd(edx);                               /* push edx */
            ii(0x9c1d, 2);    popfd();                                  /* popfd */
            ii(0x9c1f, 2);    pushfd();                                 /* pushfd */
            ii(0x9c21, 2);    popd(edx);                                /* pop edx */
            ii(0x9c23, 3);    mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x9c26, 3);    xor(edx, ecx);                            /* xor edx, ecx */
            ii(0x9c29, 4);    shr(edx, 0x13);                           /* shr edx, 0x13 */
            ii(0x9c2d, 2);    if(jaew(0x9c42, 0x13)) goto l_0x9c42;     /* jae 0x9c42 */
            ii(0x9c2f, 1);    inc(ax);                                  /* inc ax */
            ii(0x9c30, 3);    test(dl, 0x4);                            /* test dl, 0x4 */
            ii(0x9c33, 2);    if(jzw(0x9c42, 0xd)) goto l_0x9c42;       /* jz 0x9c42 */
            ii(0x9c35, 6);    mov(eax, 0x1);                            /* mov eax, 0x1 */
            ii(0x9c3b, 2);    cpuid();                                  /* cpuid */
            ii(0x9c3d, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0x9c3f, 3);    and(ax, 0xf);                             /* and ax, 0xf */
        l_0x9c42:
            ii(0x9c42, 2);    popfd();                                  /* popfd */
            ii(0x9c44, 1);    retw(); return;                           /* ret */
        }
    }
}
