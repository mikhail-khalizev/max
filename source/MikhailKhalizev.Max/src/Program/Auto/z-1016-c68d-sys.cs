using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c68d-82961d1d")]
        public void /* sys */ Method_1016_c68d()
        {
            ii(0x1016_c68d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c68e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c68f, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_c692, 6); mov(ebx, memd_a32[ds, 0x101c_fc94]);    /* mov ebx, [0x101cfc94] */
            ii(0x1016_c698, 3); cmp(ebx, 0x21);                         /* cmp ebx, 0x21 */
            ii(0x1016_c69b, 2); if(jzd(0x1016_c6c2, 0x25)) goto l_0x1016_c6c2; /* jz 0x1016c6c2 */
            ii(0x1016_c69d, 10); mov(memd_a32[ds, 0x101c_fc94], 0x21);  /* mov dword [0x101cfc94], 0x21 */
            ii(0x1016_c6a7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_c6a9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
        l_0x1016_c6ac:
            ii(0x1016_c6ac, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_c6ae, 2); if(jzd(0x1016_c6c2, 0x12)) goto l_0x1016_c6c2; /* jz 0x1016c6c2 */
            ii(0x1016_c6b0, 6); mov(eax, memd_a32[ds, edx + 0x101c_fc10]); /* mov eax, [edx+0x101cfc10] */
            ii(0x1016_c6b6, 3); sub(edx, 0x4);                          /* sub edx, 0x4 */
            ii(0x1016_c6b9, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_c6bc, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_c6bd, 3); calld_abs(memd_a32[ss, esp]);           /* call dword [esp] */
            ii(0x1016_c6c0, 2); jmpd(0x1016_c6ac, -0x16); goto l_0x1016_c6ac; /* jmp 0x1016c6ac */
        l_0x1016_c6c2:
            ii(0x1016_c6c2, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_c6c5, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c6c6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c6c7, 1); retd();                                 /* ret */
        }
    }
}
