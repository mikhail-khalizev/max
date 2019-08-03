using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66f86321-046c-4567-9e14-70c8340409f9")]
        public void /* sys */ Method_1019_5c28()
        {
            ii(0x1019_5c28, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5c29, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_5c2a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_5c2c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1019_5c2e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_5c30, 2); if(jnzd(0x1019_5c37, 0x5)) goto l_0x1019_5c37; /* jnz 0x10195c37 */
            ii(0x1019_5c32, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_5c34, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5c35, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5c36, 1); retd(); return;                         /* ret */
        l_0x1019_5c37:
            ii(0x1019_5c37, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1019_5c39, 7); mov(edx, memd_a32[ds, edx * 4 + 0x1020_a21c]); /* mov edx, [edx*4+0x1020a21c] */
            ii(0x1019_5c40, 2); calld_abs(memd_a32[ds, edx]);           /* call dword [edx] */
            ii(0x1019_5c42, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_5c44, 3); cmp(memd_a32[ds, ebx], 0x2);            /* cmp dword [ebx], 0x2 */
            ii(0x1019_5c47, 2); if(jzd(0x1019_5c53, 0xa)) goto l_0x1019_5c53; /* jz 0x10195c53 */
            ii(0x1019_5c49, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_5c4b, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_5c4e, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x1019_5c51, 2); add(eax, edx);                          /* add eax, edx */
        l_0x1019_5c53:
            ii(0x1019_5c53, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5c54, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5c55, 1); retd(); return;                         /* ret */
        }
    }
}
