using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5b5c-6d02945b")]
        public void /* sys */ Method_1018_5b5c()
        {
            ii(0x1018_5b5c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_5b5d, 1); pushd(edx);                             /* push edx */
            ii(0x1018_5b5e, 1); pushd(esi);                             /* push esi */
            ii(0x1018_5b5f, 6); mov(ebx, memd_a32[ds, 0x1020_a2a4]);    /* mov ebx, [0x1020a2a4] */
            ii(0x1018_5b65, 3); cmp(ebx, -0x1 /* 0xff */);              /* cmp ebx, 0xffffffff */
            ii(0x1018_5b68, 2); if(jzd(0x1018_5bd3, 0x69)) goto l_0x1018_5bd3; /* jz 0x10185bd3 */
            ii(0x1018_5b6a, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1018_5b71, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1018_5b73, 7); mov(eax, memd_a32[ds, eax * 4 + 0x1020_a268]); /* mov eax, [eax*4+0x1020a268] */
            ii(0x1018_5b7a, 5); calld(/* sys */ 0x1016_6990, -0x1_f1ef); /* call 0x10166990 */
            ii(0x1018_5b7f, 6); mov(ebx, memd_a32[ds, 0x1020_a2a4]);    /* mov ebx, [0x1020a2a4] */
            ii(0x1018_5b85, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_5b87, 7); lea(eax, ebx * 4 + 0);                  /* lea eax, [ebx*4] */
            ii(0x1018_5b8e, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1018_5b90, 7); mov(eax, memd_a32[ds, eax * 4 + 0x1020_a26c]); /* mov eax, [eax*4+0x1020a26c] */
            ii(0x1018_5b97, 2); xor(edx, ebx);                          /* xor edx, ebx */
            ii(0x1018_5b99, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_5b9a, 7); mov(memd_a32[ds, eax * 8 + 0x1020_a234], edx); /* mov [eax*8+0x1020a234], edx */
            ii(0x1018_5ba1, 3); cmp(ebx, 0x5);                          /* cmp ebx, 0x5 */
            ii(0x1018_5ba4, 2); if(jnzd(0x1018_5ba8, 0x2)) goto l_0x1018_5ba8; /* jnz 0x10185ba8 */
            ii(0x1018_5ba6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
        l_0x1018_5ba8:
            ii(0x1018_5ba8, 6); cmp(ebx, memd_a32[ds, 0x1020_a2ac]);    /* cmp ebx, [0x1020a2ac] */
            ii(0x1018_5bae, 2); if(jnzd(0x1018_5bd3, 0x23)) goto l_0x1018_5bd3; /* jnz 0x10185bd3 */
            ii(0x1018_5bb0, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1018_5bb5, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_5bb7, 5); mov(eax, /* sys */ 0x1018_5b08);        /* mov eax, 0x10185b08 */
            ii(0x1018_5bbc, 6); mov(memd_a32[ds, 0x1020_a2ac], esi);    /* mov [0x1020a2ac], esi */
            ii(0x1018_5bc2, 6); mov(memd_a32[ds, 0x1020_a2a4], ebx);    /* mov [0x1020a2a4], ebx */
            ii(0x1018_5bc8, 5); calld(/* sys */ 0x1016_b42c, -0x1_a7a1); /* call 0x1016b42c */
            ii(0x1018_5bcd, 6); mov(ebx, memd_a32[ds, 0x1020_a2a4]);    /* mov ebx, [0x1020a2a4] */
        l_0x1018_5bd3:
            ii(0x1018_5bd3, 6); mov(memd_a32[ds, 0x1020_a2a4], ebx);    /* mov [0x1020a2a4], ebx */
            ii(0x1018_5bd9, 1); popd(esi);                              /* pop esi */
            ii(0x1018_5bda, 1); popd(edx);                              /* pop edx */
            ii(0x1018_5bdb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_5bdc, 1); retd();                                 /* ret */
        }
    }
}
