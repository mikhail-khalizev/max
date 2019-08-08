using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d489b6b0-86b6-4d66-ae3c-59331495c4de")]
        public void /* sys */ Method_1017_21ac()
        {
            ii(0x1017_21ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_21ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_21ae, 1); pushd(edx);                             /* push edx */
            ii(0x1017_21af, 1); pushd(esi);                             /* push esi */
            ii(0x1017_21b0, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_21b3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_21b5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_21b7, 2); mov(al, memb_a32[ds, ebx]);             /* mov al, [ebx] */
            ii(0x1017_21b9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_21bb, 5); calld(Definitions.sys_toupper, 0xed2a); /* call 0x10180eea */
            ii(0x1017_21c0, 3); mov(memb_a32[ss, esp], al);             /* mov [esp], al */
            ii(0x1017_21c3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_21c8, 3); cmp(eax, 0x72);                         /* cmp eax, 0x72 */
            ii(0x1017_21cb, 2); if(jzd(0x1017_21e8, 0x1b)) goto l_0x1017_21e8; /* jz 0x101721e8 */
            ii(0x1017_21cd, 3); cmp(eax, 0x77);                         /* cmp eax, 0x77 */
            ii(0x1017_21d0, 2); if(jzd(0x1017_21e8, 0x16)) goto l_0x1017_21e8; /* jz 0x101721e8 */
            ii(0x1017_21d2, 3); cmp(eax, 0x61);                         /* cmp eax, 0x61 */
            ii(0x1017_21d5, 2); if(jzd(0x1017_21e8, 0x11)) goto l_0x1017_21e8; /* jz 0x101721e8 */
            ii(0x1017_21d7, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_21dc, 5); calld(/* sys */ 0x1018_d3bf, 0x1_b1de); /* call 0x1018d3bf */
            ii(0x1017_21e1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_21e3, 5); jmpd(0x1017_2275, 0x8d); goto l_0x1017_2275; /* jmp 0x10172275 */
        l_0x1017_21e8:
            ii(0x1017_21e8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_21ea, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1017_21ec, 3); mov(cl, memb_a32[ds, ebx + 0x1]);       /* mov cl, [ebx+0x1] */
            ii(0x1017_21ef, 4); or(si, 0x3);                            /* or si, 0x3 */
            ii(0x1017_21f3, 3); cmp(ecx, 0x2b);                         /* cmp ecx, 0x2b */
            ii(0x1017_21f6, 2); if(jnzd(0x1017_221d, 0x25)) goto l_0x1017_221d; /* jnz 0x1017221d */
            ii(0x1017_21f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_21fa, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_21fc, 3); mov(al, memb_a32[ds, ebx + 0x2]);       /* mov al, [ebx+0x2] */
            ii(0x1017_21ff, 4); or(si, 0x40);                           /* or si, 0x40 */
            ii(0x1017_2203, 3); cmp(eax, 0x62);                         /* cmp eax, 0x62 */
            ii(0x1017_2206, 2); if(jzd(0x1017_2219, 0x11)) goto l_0x1017_2219; /* jz 0x10172219 */
            ii(0x1017_2208, 3); cmp(eax, 0x74);                         /* cmp eax, 0x74 */
            ii(0x1017_220b, 2); if(jzd(0x1017_2257, 0x4a)) goto l_0x1017_2257; /* jz 0x10172257 */
            ii(0x1017_220d, 10); cmp(memd_a32[ds, 0x101b_e7a9], 0x200); /* cmp dword [0x101be7a9], 0x200 */
        l_0x1017_2217:
            ii(0x1017_2217, 2); if(jnzd(0x1017_2257, 0x3e)) goto l_0x1017_2257; /* jnz 0x10172257 */
        l_0x1017_2219:
            ii(0x1017_2219, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_221b, 2); jmpd(0x1017_2257, 0x3a); goto l_0x1017_2257; /* jmp 0x10172257 */
        l_0x1017_221d:
            ii(0x1017_221d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_221f, 2); or(al, 0x40);                           /* or al, 0x40 */
            ii(0x1017_2221, 3); cmp(ecx, 0x62);                         /* cmp ecx, 0x62 */
            ii(0x1017_2224, 2); if(jnzd(0x1017_223a, 0x14)) goto l_0x1017_223a; /* jnz 0x1017223a */
            ii(0x1017_2226, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2228, 3); mov(bl, memb_a32[ds, ebx + 0x2]);       /* mov bl, [ebx+0x2] */
            ii(0x1017_222b, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1017_2231, 3); cmp(ebx, 0x2b);                         /* cmp ebx, 0x2b */
            ii(0x1017_2234, 2); if(jnzd(0x1017_2257, 0x21)) goto l_0x1017_2257; /* jnz 0x10172257 */
            ii(0x1017_2236, 2); or(al, 0x3);                            /* or al, 0x3 */
            ii(0x1017_2238, 2); jmpd(0x1017_2255, 0x1b); goto l_0x1017_2255; /* jmp 0x10172255 */
        l_0x1017_223a:
            ii(0x1017_223a, 3); cmp(ecx, 0x74);                         /* cmp ecx, 0x74 */
            ii(0x1017_223d, 2); if(jnzd(0x1017_2249, 0xa)) goto l_0x1017_2249; /* jnz 0x10172249 */
            ii(0x1017_223f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2241, 3); mov(al, memb_a32[ds, ebx + 0x2]);       /* mov al, [ebx+0x2] */
            ii(0x1017_2244, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1017_2247, 2); jmpd(0x1017_2217, -0x32); goto l_0x1017_2217; /* jmp 0x10172217 */
        l_0x1017_2249:
            ii(0x1017_2249, 10); cmp(memd_a32[ds, 0x101b_e7a9], 0x200); /* cmp dword [0x101be7a9], 0x200 */
            ii(0x1017_2253, 2); if(jnzd(0x1017_2257, 0x2)) goto l_0x1017_2257; /* jnz 0x10172257 */
        l_0x1017_2255:
            ii(0x1017_2255, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1017_2257:
            ii(0x1017_2257, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2259, 3); mov(al, memb_a32[ss, esp]);             /* mov al, [esp] */
            ii(0x1017_225c, 3); cmp(eax, 0x77);                         /* cmp eax, 0x77 */
            ii(0x1017_225f, 2); if(jnzd(0x1017_2266, 0x5)) goto l_0x1017_2266; /* jnz 0x10172266 */
            ii(0x1017_2261, 3); or(dl, 0x2);                            /* or dl, 0x2 */
            ii(0x1017_2264, 2); jmpd(0x1017_2273, 0xd); goto l_0x1017_2273; /* jmp 0x10172273 */
        l_0x1017_2266:
            ii(0x1017_2266, 3); cmp(eax, 0x61);                         /* cmp eax, 0x61 */
            ii(0x1017_2269, 2); if(jnzd(0x1017_2270, 0x5)) goto l_0x1017_2270; /* jnz 0x10172270 */
            ii(0x1017_226b, 3); or(dl, 0x82);                           /* or dl, 0x82 */
            ii(0x1017_226e, 2); jmpd(0x1017_2273, 0x3); goto l_0x1017_2273; /* jmp 0x10172273 */
        l_0x1017_2270:
            ii(0x1017_2270, 3); or(dl, 0x1);                            /* or dl, 0x1 */
        l_0x1017_2273:
            ii(0x1017_2273, 2); mov(eax, edx);                          /* mov eax, edx */
        l_0x1017_2275:
            ii(0x1017_2275, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_2278, 1); popd(esi);                              /* pop esi */
            ii(0x1017_2279, 1); popd(edx);                              /* pop edx */
            ii(0x1017_227a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_227b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_227c, 1); retd(); return;                         /* ret */
        }
    }
}
