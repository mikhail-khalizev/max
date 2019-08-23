using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6b2b-e315b100")]
        public void /* sys */ Method_1018_6b2b()
        {
            ii(0x1018_6b2b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_6b2c, 1); pushd(edx);                             /* push edx */
            ii(0x1018_6b2d, 1); pushd(esi);                             /* push esi */
            ii(0x1018_6b2e, 6); mov(edx, memd_a32[ds, 0x101b_de10]);    /* mov edx, [0x101bde10] */
            ii(0x1018_6b34, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_6b36, 2); if(jnzd(0x1018_6b41, 0x9)) goto l_0x1018_6b41; /* jnz 0x10186b41 */
            ii(0x1018_6b38, 3); mov(edx, memd_a32[ds, edx + 0x8]);      /* mov edx, [edx+0x8] */
            ii(0x1018_6b3b, 6); mov(memd_a32[ds, 0x101b_de10], edx);    /* mov [0x101bde10], edx */
        l_0x1018_6b41:
            ii(0x1018_6b41, 6); cmp(eax, memd_a32[ds, 0x101c_f968]);    /* cmp eax, [0x101cf968] */
            ii(0x1018_6b47, 2); if(jnzd(0x1018_6b51, 0x8)) goto l_0x1018_6b51; /* jnz 0x10186b51 */
            ii(0x1018_6b49, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_6b4b, 6); mov(memd_a32[ds, 0x101c_f968], ecx);    /* mov [0x101cf968], ecx */
        l_0x1018_6b51:
            ii(0x1018_6b51, 6); mov(esi, memd_a32[ds, 0x101b_de0c]);    /* mov esi, [0x101bde0c] */
            ii(0x1018_6b57, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1018_6b59, 2); if(jnzd(0x1018_6b64, 0x9)) goto l_0x1018_6b64; /* jnz 0x10186b64 */
            ii(0x1018_6b5b, 3); mov(edx, memd_a32[ds, esi + 0x8]);      /* mov edx, [esi+0x8] */
            ii(0x1018_6b5e, 6); mov(memd_a32[ds, 0x101b_de0c], edx);    /* mov [0x101bde0c], edx */
        l_0x1018_6b64:
            ii(0x1018_6b64, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1018_6b67, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1018_6b6a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_6b6c, 2); if(jzd(0x1018_6b71, 0x3)) goto l_0x1018_6b71; /* jz 0x10186b71 */
            ii(0x1018_6b6e, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
        l_0x1018_6b71:
            ii(0x1018_6b71, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6b73, 2); if(jzd(0x1018_6b78, 0x3)) goto l_0x1018_6b78; /* jz 0x10186b78 */
            ii(0x1018_6b75, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
        l_0x1018_6b78:
            ii(0x1018_6b78, 1); popd(esi);                              /* pop esi */
            ii(0x1018_6b79, 1); popd(edx);                              /* pop edx */
            ii(0x1018_6b7a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_6b7b, 1); retd();                                 /* ret */
        }
    }
}
