using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_474a-417f885e")]
        public void /* sys */ Method_1019_474a()
        {
            // Wait eax seconds? Skip.
            retd();

#if false

            ii(0x1019_474a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_474b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_474c, 1); pushd(edx);                             /* push edx */
            ii(0x1019_474d, 1); pushd(esi);                             /* push esi */
            ii(0x1019_474e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_4750, 2); if(jzd(0x1019_477b, 0x29)) goto l_0x1019_477b; /* jz 0x1019477b */

            ii(0x1019_4752, 7); imul(eax, memd_a32[ds, 0x1020_bc5c]);   /* imul eax, [0x1020bc5c] */
            ii(0x1019_4759, 5); mov(ebx, 0x3e8);                        /* mov ebx, 0x3e8 */
            ii(0x1019_475e, 5); add(eax, 0x1f4);                        /* add eax, 0x1f4 */
            ii(0x1019_4763, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_4765, 2); div(ebx);                               /* div ebx */
            ii(0x1019_4767, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_4769, 2); if(jnzd(0x1019_476c, 0x1)) goto l_0x1019_476c; /* jnz 0x1019476c */
            ii(0x1019_476b, 1); inc(eax);                               /* inc eax */
        l_0x1019_476c:
            ii(0x1019_476c, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1019_476e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4770, 2); mov(bl, al);                            /* mov bl, al */
        l_0x1019_4772:
            ii(0x1019_4772, 2); mov(ah, 0x2c);                          /* mov ah, 0x2c */
            ii(0x1019_4774, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1019_4776, 2); cmp(bl, dh);                            /* cmp bl, dh */
            ii(0x1019_4778, 1); dec(esi);                               /* dec esi */
            ii(0x1019_4779, 2); if(jnzd(0x1019_4772, -0x9)) goto l_0x1019_4772; /* jnz 0x10194772 */

        l_0x1019_477b:
            ii(0x1019_477b, 1); popd(esi);                              /* pop esi */
            ii(0x1019_477c, 1); popd(edx);                              /* pop edx */
            ii(0x1019_477d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_477e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_477f, 1); retd(); return;                         /* ret */
#endif
        }
    }
}
