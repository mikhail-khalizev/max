using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("892f90cc-c029-46ad-80ea-4f78481a5b0b")]
        public void /* sys */ Method_1016_72d4()
        {
            ii(0x1016_72d4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_72d5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_72d6, 1); pushd(edx);                             /* push edx */
            ii(0x1016_72d7, 1); pushd(esi);                             /* push esi */
            ii(0x1016_72d8, 5); calld(/* sys */ 0x1016_7dac, 0xacf);    /* call 0x10167dac */
            ii(0x1016_72dd, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1016_72df, 6); mov(edx, memd_a32[ds, 0x101b_ddbc]);    /* mov edx, [0x101bddbc] */
            ii(0x1016_72e5, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_72e7, 7); mov(ecx, memd_a32[ds, ecx * 4 + 0x101c_b134]); /* mov ecx, [ecx*4+0x101cb134] */
            ii(0x1016_72ee, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_72f0, 6); if(jzd(0x1016_7385, 0x8f)) goto l_0x1016_7385; /* jz 0x10167385 */
            ii(0x1016_72f6, 3); mov(dl, memb_a32[ds, eax + 0x4]);       /* mov dl, [eax+0x4] */
            ii(0x1016_72f9, 3); test(dl, 0x8);                          /* test dl, 0x8 */
            ii(0x1016_72fc, 2); if(jzd(0x1016_731b, 0x1d)) goto l_0x1016_731b; /* jz 0x1016731b */
            ii(0x1016_72fe, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1016_7300, 3); and(dh, 0xf7);                          /* and dh, 0xf7 */
            ii(0x1016_7303, 3); mov(memb_a32[ds, eax + 0x4], dh);       /* mov [eax+0x4], dh */
            ii(0x1016_7306, 6); mov(edx, memd_a32[ds, 0x101c_b2d8]);    /* mov edx, [0x101cb2d8] */
            ii(0x1016_730c, 1); dec(edx);                               /* dec edx */
            ii(0x1016_730d, 2); cmp(ecx, edx);                          /* cmp ecx, edx */
            ii(0x1016_730f, 2); if(jnzd(0x1016_731b, 0xa)) goto l_0x1016_731b; /* jnz 0x1016731b */
            ii(0x1016_7311, 3); lea(edx, eax + 0x8);                    /* lea edx, [eax+0x8] */
            ii(0x1016_7314, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7316, 5); calld(/* sys */ 0x1016_7500, 0x1e5);    /* call 0x10167500 */
        l_0x1016_731b:
            ii(0x1016_731b, 6); mov(ebx, memd_a32[ds, 0x101c_b2d8]);    /* mov ebx, [0x101cb2d8] */
            ii(0x1016_7321, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_7322, 2); cmp(ecx, ebx);                          /* cmp ecx, ebx */
            ii(0x1016_7324, 2); if(jged(0x1016_7385, 0x5f)) goto l_0x1016_7385; /* jge 0x10167385 */
            ii(0x1016_7326, 4); test(memb_a32[ds, esi + 0x4], 0x2);     /* test byte [esi+0x4], 0x2 */
            ii(0x1016_732a, 2); if(jzd(0x1016_735e, 0x32)) goto l_0x1016_735e; /* jz 0x1016735e */
            ii(0x1016_732c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_732d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_732e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_732f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_7330, 1); retd(); return;                         /* ret */
        l_0x1016_7331:
            ii(0x1016_7331, 4); test(memb_a32[ds, esi + 0x4], 0x4);     /* test byte [esi+0x4], 0x4 */
            ii(0x1016_7335, 2); if(jnzd(0x1016_7343, 0xc)) goto l_0x1016_7343; /* jnz 0x10167343 */
            ii(0x1016_7337, 6); mov(edx, memd_a32[ds, eax + 0x101c_b200]); /* mov edx, [eax+0x101cb200] */
            ii(0x1016_733d, 4); test(memb_a32[ds, edx + 0x4], 0x4);     /* test byte [edx+0x4], 0x4 */
            ii(0x1016_7341, 2); if(jnzd(0x1016_7369, 0x26)) goto l_0x1016_7369; /* jnz 0x10167369 */
        l_0x1016_7343:
            ii(0x1016_7343, 6); mov(edx, memd_a32[ds, eax + 0x101c_b200]); /* mov edx, [eax+0x101cb200] */
            ii(0x1016_7349, 6); mov(memd_a32[ds, eax + 0x101c_b1fc], edx); /* mov [eax+0x101cb1fc], edx */
            ii(0x1016_734f, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1016_7351, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_7354, 7); mov(memd_a32[ds, edx * 4 + 0x101c_b134], ecx); /* mov [edx*4+0x101cb134], ecx */
            ii(0x1016_735b, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_735c, 2); jmpd(0x1016_7365, 0x7); goto l_0x1016_7365; /* jmp 0x10167365 */
        l_0x1016_735e:
            ii(0x1016_735e, 7); lea(eax, ecx * 4 + 0);                  /* lea eax, [ecx*4] */
        l_0x1016_7365:
            ii(0x1016_7365, 2); cmp(ecx, ebx);                          /* cmp ecx, ebx */
            ii(0x1016_7367, 2); if(jld(0x1016_7331, -0x38)) goto l_0x1016_7331; /* jl 0x10167331 */
        l_0x1016_7369:
            ii(0x1016_7369, 7); mov(memd_a32[ds, ecx * 4 + 0x101c_b1fc], esi); /* mov [ecx*4+0x101cb1fc], esi */
            ii(0x1016_7370, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_7372, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7374, 3); lea(edx, esi + 0x8);                    /* lea edx, [esi+0x8] */
            ii(0x1016_7377, 7); mov(memd_a32[ds, eax * 4 + 0x101c_b134], ecx); /* mov [eax*4+0x101cb134], ecx */
            ii(0x1016_737e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7380, 5); calld(/* sys */ 0x1016_7500, 0x17b);    /* call 0x10167500 */
        l_0x1016_7385:
            ii(0x1016_7385, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7386, 1); popd(edx);                              /* pop edx */
            ii(0x1016_7387, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_7388, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_7389, 1); retd(); return;                         /* ret */
        }
    }
}
