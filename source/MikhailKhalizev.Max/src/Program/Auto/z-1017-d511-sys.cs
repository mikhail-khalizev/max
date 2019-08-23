using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d511-649db3bc")]
        public void /* sys */ Method_1017_d511()
        {
            ii(0x1017_d511, 2); mov(edi, ecx);                          /* mov edi, ecx */
            ii(0x1017_d513, 1); pop(es);                                /* pop es */
            ii(0x1017_d514, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1017_d516:
            ii(0x1017_d516, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_d518, 2); if(jz(0x1017_d527, 0xd)) goto l_0x1017_d527; /* jz 0x1017d527 */
            ii(0x1017_d51a, 2); mov(dl, memb[ds, esi]);                 /* mov dl, [esi] */
            ii(0x1017_d51c, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
            ii(0x1017_d51e, 2); test(dl, dl);                           /* test dl, dl */
            ii(0x1017_d520, 2); if(jz(0x1017_d527, 0x5)) goto l_0x1017_d527; /* jz 0x1017d527 */
            ii(0x1017_d522, 1); inc(eax);                               /* inc eax */
            ii(0x1017_d523, 1); inc(esi);                               /* inc esi */
            ii(0x1017_d524, 1); dec(ebx);                               /* dec ebx */
            ii(0x1017_d525, 2); jmp(0x1017_d516, -0x11); goto l_0x1017_d516; /* jmp 0x1017d516 */
        l_0x1017_d527:
            ii(0x1017_d527, 3); mov(memb[ds, eax], 0);                  /* mov byte [eax], 0x0 */
            ii(0x1017_d52a, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1017_d52c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_d52d, 1); pop(edi);                               /* pop edi */
            ii(0x1017_d52e, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d52f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_d530, 1); ret();                                  /* ret */
        }
    }
}
