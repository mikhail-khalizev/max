using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_d531-79b3c8d")]
        public void /* sys */ Method_1017_d531()
        {
            ii(0x1017_d531, 1); push(ecx);                              /* push ecx */
            ii(0x1017_d532, 1); push(esi);                              /* push esi */
            ii(0x1017_d533, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1017_d535, 2); mov(esi, ebx);                          /* mov esi, ebx */
        l_0x1017_d537:
            ii(0x1017_d537, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1017_d539, 2); if(jnz(0x1017_d540, 0x5)) goto l_0x1017_d540; /* jnz 0x1017d540 */
        l_0x1017_d53b:
            ii(0x1017_d53b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_d53d, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d53e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_d53f, 1); ret(); return;                          /* ret */
        l_0x1017_d540:
            ii(0x1017_d540, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1017_d542, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_d544, 2); mov(ah, memb[ds, edx]);                 /* mov ah, [edx] */
            ii(0x1017_d546, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1017_d548, 3); cmp(ebx, 0x41);                         /* cmp ebx, 0x41 */
            ii(0x1017_d54b, 2); if(jl(0x1017_d554, 0x7)) goto l_0x1017_d554; /* jl 0x1017d554 */
            ii(0x1017_d54d, 3); cmp(ebx, 0x5a);                         /* cmp ebx, 0x5a */
            ii(0x1017_d550, 2); if(jg(0x1017_d554, 0x2)) goto l_0x1017_d554; /* jg 0x1017d554 */
            ii(0x1017_d552, 2); add(al, 0x20);                          /* add al, 0x20 */
        l_0x1017_d554:
            ii(0x1017_d554, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_d556, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1017_d558, 3); cmp(ebx, 0x41);                         /* cmp ebx, 0x41 */
            ii(0x1017_d55b, 2); if(jl(0x1017_d565, 0x8)) goto l_0x1017_d565; /* jl 0x1017d565 */
            ii(0x1017_d55d, 3); cmp(ebx, 0x5a);                         /* cmp ebx, 0x5a */
            ii(0x1017_d560, 2); if(jg(0x1017_d565, 0x3)) goto l_0x1017_d565; /* jg 0x1017d565 */
            ii(0x1017_d562, 3); add(ah, 0x20);                          /* add ah, 0x20 */
        l_0x1017_d565:
            ii(0x1017_d565, 2); cmp(al, ah);                            /* cmp al, ah */
            ii(0x1017_d567, 2); if(jz(0x1017_d57b, 0x12)) goto l_0x1017_d57b; /* jz 0x1017d57b */
            ii(0x1017_d569, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_d56b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1017_d56d, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1017_d56f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_d574, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1017_d576, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_d578, 1); pop(esi);                               /* pop esi */
            ii(0x1017_d579, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_d57a, 1); ret(); return;                          /* ret */
        l_0x1017_d57b:
            ii(0x1017_d57b, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1017_d57d, 2); if(jz(0x1017_d53b, -0x44)) goto l_0x1017_d53b; /* jz 0x1017d53b */
            ii(0x1017_d57f, 1); inc(ecx);                               /* inc ecx */
            ii(0x1017_d580, 1); inc(edx);                               /* inc edx */
            ii(0x1017_d581, 1); dec(esi);                               /* dec esi */
            ii(0x1017_d582, 2); jmp(0x1017_d537, -0x4d); goto l_0x1017_d537; /* jmp 0x1017d537 */
        }
    }
}
