using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1d24-e3ee69fe")]
        public void /* sys */ Method_1018_1d24()
        {
            ii(0x1018_1d24, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_1d25, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_1d26, 1); pushd(edx);                             /* push edx */
            ii(0x1018_1d27, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_1d29, 5); calld(/* sys */ 0x1019_5d01, 0x1_3fd3); /* call 0x10195d01 */
            ii(0x1018_1d2e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_1d30, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_1d32, 2); if(jzd(0x1018_1d68, 0x34)) goto l_0x1018_1d68; /* jz 0x10181d68 */
            ii(0x1018_1d34, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x1018_1d37, 2); if(jnzd(0x1018_1d68, 0x2f)) goto l_0x1018_1d68; /* jnz 0x10181d68 */
            ii(0x1018_1d39, 3); mov(ecx, memd_a32[ds, edx + 0x4]);      /* mov ecx, [edx+0x4] */
            ii(0x1018_1d3c, 3); cmp(ecx, memd_a32[ds, edx + 0x9]);      /* cmp ecx, [edx+0x9] */
            ii(0x1018_1d3f, 2); if(jnzd(0x1018_1d4a, 0x9)) goto l_0x1018_1d4a; /* jnz 0x10181d4a */
            ii(0x1018_1d41, 2); jmpd(0x1018_1d68, 0x25); goto l_0x1018_1d68; /* jmp 0x10181d68 */
        l_0x1018_1d43:
            ii(0x1018_1d43, 5); calld(/* sys */ 0x1019_5dab, 0x1_4063); /* call 0x10195dab */
            ii(0x1018_1d48, 2); jmpd(0x1018_1d68, 0x1e); goto l_0x1018_1d68; /* jmp 0x10181d68 */
        l_0x1018_1d4a:
            ii(0x1018_1d4a, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1018_1d4d, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1018_1d50, 4); cmp(ax, 0x2);                           /* cmp ax, 0x2 */
            ii(0x1018_1d54, 2); if(jbd(0x1018_1d43, -0x13)) goto l_0x1018_1d43; /* jb 0x10181d43 */
            ii(0x1018_1d56, 4); cmp(ax, 0x4);                           /* cmp ax, 0x4 */
            ii(0x1018_1d5a, 2); if(jbed(0x1018_1d68, 0xc)) goto l_0x1018_1d68; /* jbe 0x10181d68 */
            ii(0x1018_1d5c, 4); cmp(ax, 0x5);                           /* cmp ax, 0x5 */
            ii(0x1018_1d60, 2); if(jbed(0x1018_1d43, -0x1f)) goto l_0x1018_1d43; /* jbe 0x10181d43 */
            ii(0x1018_1d62, 4); cmp(ax, 0xb);                           /* cmp ax, 0xb */
            ii(0x1018_1d66, 2); if(jad(0x1018_1d43, -0x25)) goto l_0x1018_1d43; /* ja 0x10181d43 */
        l_0x1018_1d68:
            ii(0x1018_1d68, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_1d6a, 1); popd(edx);                              /* pop edx */
            ii(0x1018_1d6b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_1d6c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_1d6d, 1); retd(); return;                         /* ret */
        }
    }
}
