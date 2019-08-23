using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_92be-4619640e")]
        public void /* sys */ Method_1017_92be()
        {
            ii(0x1017_92be, 1); push(ebx);                              /* push ebx */
            ii(0x1017_92bf, 1); push(ecx);                              /* push ecx */
            ii(0x1017_92c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_92c2, 6); mov(dl, memb[ds, 0x101b_e58e]);         /* mov dl, [0x101be58e] */
            ii(0x1017_92c8, 3); cmp(edx, 0x2);                          /* cmp edx, 0x2 */
            ii(0x1017_92cb, 2); if(jl(0x1017_92db, 0xe)) goto l_0x1017_92db; /* jl 0x101792db */
            ii(0x1017_92cd, 3); cmp(edx, 0x8);                          /* cmp edx, 0x8 */
            ii(0x1017_92d0, 2); if(jg(0x1017_92db, 0x9)) goto l_0x1017_92db; /* jg 0x101792db */
            ii(0x1017_92d2, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_92d4, 5); mov(eax, 0x2502);                       /* mov eax, 0x2502 */
            ii(0x1017_92d9, 2); jmp(0x1017_92e5, 0xa); goto l_0x1017_92e5; /* jmp 0x101792e5 */
        l_0x1017_92db:
            ii(0x1017_92db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_92e0, 2); xor(cl, cl);                            /* xor cl, cl */
            ii(0x1017_92e2, 3); or(ah, 0x35);                           /* or ah, 0x35 */
        l_0x1017_92e5:
            ii(0x1017_92e5, 1); push(es);                               /* push es */
            ii(0x1017_92e6, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_92e8, 2); mov(edx, es);                           /* mov edx, es */
            ii(0x1017_92ea, 1); pop(es);                                /* pop es */
            ii(0x1017_92eb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_92ed, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_92ee, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_92ef, 1); ret();                                  /* ret */
        }
    }
}
