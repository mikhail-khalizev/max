using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_224d-e38700c")]
        public void /* sys */ Method_1018_224d()
        {
            ii(0x1018_224d, 1); push(edx);                              /* push edx */
            ii(0x1018_224e, 6); mov(ah, memb[ds, 0x101b_ddac]);         /* mov ah, [0x101bddac] */
            ii(0x1018_2254, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1018_2256, 2); if(jnz(0x1018_2295, 0x3d)) goto l_0x1018_2295; /* jnz 0x10182295 */
            ii(0x1018_2258, 6); mov(memb[ds, 0x101b_ddad], ah);         /* mov [0x101bddad], ah */
            ii(0x1018_225e, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1018_2260, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_2262, 1); push(eax);                              /* push eax */
            ii(0x1018_2263, 2); fninit();                               /* fninit */
            ii(0x1018_2265, 3); fnstcw(memw[ss, esp]);                  /* fnstcw word [esp] */
            ii(0x1018_2268, 1); pop(eax);                               /* pop eax */
            ii(0x1018_2269, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1018_226b, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_226d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_2272, 3); cmp(eax, 3);                            /* cmp eax, 0x3 */
            ii(0x1018_2275, 2); if(jnz(0x1018_2280, 9)) goto l_0x1018_2280; /* jnz 0x10182280 */
            ii(0x1018_2277, 5); call(/* sys */ 0x1018_2212, -0x6a);     /* call 0x10182212 */
            ii(0x1018_227c, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_227e, 2); mov(dh, al);                            /* mov dh, al */
        l_0x1018_2280:
            ii(0x1018_2280, 7); cmp(memb[ds, 0x101b_e58c], 0);          /* cmp byte [0x101be58c], 0x0 */
            ii(0x1018_2287, 2); if(jnz(0x1018_2295, 0xc)) goto l_0x1018_2295; /* jnz 0x10182295 */
            ii(0x1018_2289, 6); mov(memb[ds, 0x101b_ddac], dl);         /* mov [0x101bddac], dl */
            ii(0x1018_228f, 6); mov(memb[ds, 0x101b_ddad], dh);         /* mov [0x101bddad], dh */
        l_0x1018_2295:
            ii(0x1018_2295, 1); pop(edx);                               /* pop edx */
            ii(0x1018_2296, 1); ret();                                  /* ret */
        }
    }
}
