using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_467e-a499f2da")]
        public void /* sys */ Method_1019_467e()
        {
            ii(0x1019_467e, 1); push(ebx);                              /* push ebx */
            ii(0x1019_467f, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4680, 1); push(edx);                              /* push edx */
            ii(0x1019_4681, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_4683, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1019_4685, 2); mov(ah, 0x44);                          /* mov ah, 0x44 */
            ii(0x1019_4687, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4689, 2); rcl(edx, 1);                            /* rcl edx, 1 */
            ii(0x1019_468b, 2); ror(edx, 1);                            /* ror edx, 1 */
            ii(0x1019_468d, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1019_468f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4691, 3); and(dl, 0x80);                          /* and dl, 0x80 */
            ii(0x1019_4694, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1019_4697, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_4699, 3); setnz(al);                              /* setnz al */
            ii(0x1019_469c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1019_46a1, 1); pop(edx);                               /* pop edx */
            ii(0x1019_46a2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_46a3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_46a4, 1); ret();                                  /* ret */
        }
    }
}
