using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4e07-31d9ccf")]
        public void /* sys */ Method_1019_4e07()
        {
            ii(0x1019_4e07, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4e08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4e0a, 1); push(esi);                              /* push esi */
            ii(0x1019_4e0b, 1); push(edi);                              /* push edi */
            ii(0x1019_4e0c, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4e0d, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4e0e, 2); push(fs);                               /* push fs */
            ii(0x1019_4e10, 2); push(gs);                               /* push gs */
            ii(0x1019_4e12, 1); push(es);                               /* push es */
            ii(0x1019_4e13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4e15, 4); mov(ax, 0x100);                         /* mov ax, 0x100 */
            ii(0x1019_4e19, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1019_4e1c, 6); add(ebx, 0x100);                        /* add ebx, 0x100 */
            ii(0x1019_4e22, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4e24, 3); mov(esi, memd[ss, ebp + 0xc]);          /* mov esi, [ebp+0xc] */
            ii(0x1019_4e27, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1019_4e2a, 2); mov(memd[ds, esi], eax);                /* mov [esi], eax */
            ii(0x1019_4e2c, 3); mov(esi, memd[ss, ebp + 0x10]);         /* mov esi, [ebp+0x10] */
            ii(0x1019_4e2f, 3); mov(memw[ds, esi], dx);                 /* mov [esi], dx */
            ii(0x1019_4e32, 1); pop(es);                                /* pop es */
            ii(0x1019_4e33, 2); pop(gs);                                /* pop gs */
            ii(0x1019_4e35, 2); pop(fs);                                /* pop fs */
            ii(0x1019_4e37, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4e38, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4e39, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4e3a, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4e3b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4e3c, 1); ret();                                  /* ret */
        }
    }
}
