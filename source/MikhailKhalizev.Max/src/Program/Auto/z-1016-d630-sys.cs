using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_d630-201996d4")]
        public void /* sys */ Method_1016_d630()
        {
            ii(0x1016_d630, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_d631, 1); pushd(edx);                             /* push edx */
            ii(0x1016_d632, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_d634, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1016_d636, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1016_d639, 6); mov(ebx, memd_a32[ds, edx + 0x101d_0020]); /* mov ebx, [edx+0x101d0020] */
            ii(0x1016_d63f, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_d641, 2); if(jzd(0x1016_d663, 0x20)) goto l_0x1016_d663; /* jz 0x1016d663 */
            ii(0x1016_d643, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_d645, 3); mov(ebx, memd_a32[ds, ebx - 0x4]);      /* mov ebx, [ebx-0x4] */
            ii(0x1016_d648, 1); dec(ebx);                               /* dec ebx */
            ii(0x1016_d649, 3); mov(memd_a32[ds, eax - 0x4], ebx);      /* mov [eax-0x4], ebx */
            ii(0x1016_d64c, 2); if(jnzd(0x1016_d663, 0x15)) goto l_0x1016_d663; /* jnz 0x1016d663 */
            ii(0x1016_d64e, 6); mov(eax, memd_a32[ds, edx + 0x101d_0020]); /* mov eax, [edx+0x101d0020] */
            ii(0x1016_d654, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1016_d657, 6); calld_abs(memd_a32[ds, 0x101b_deb8]);   /* call dword [0x101bdeb8] */ /* Вызов '0x1016_ca6c'. */
            ii(0x1016_d65d, 6); mov(memd_a32[ds, edx + 0x101d_0020], ebx); /* mov [edx+0x101d0020], ebx */
        l_0x1016_d663:
            ii(0x1016_d663, 1); popd(edx);                              /* pop edx */
            ii(0x1016_d664, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_d665, 1); retd(); return;                         /* ret */
        }
    }
}
