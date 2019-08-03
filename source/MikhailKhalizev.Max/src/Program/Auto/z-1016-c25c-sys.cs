using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78a35c60-1737-420b-9bf2-55d81d1f58ea")]
        public void /* sys */ Method_1016_c25c()
        {
            ii(0x1016_c25c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c25d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_c25e, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c25f, 6); mov(edx, memd_a32[ds, 0x101c_fbd4]);    /* mov edx, [0x101cfbd4] */
            ii(0x1016_c265, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1016_c267, 6); mov(edx, memd_a32[ds, 0x101c_fbd0]);    /* mov edx, [0x101cfbd0] */
            ii(0x1016_c26d, 6); mov(ebx, memd_a32[ds, 0x101c_fbf0]);    /* mov ebx, [0x101cfbf0] */
            ii(0x1016_c273, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1016_c276, 6); mov(edx, memd_a32[ds, 0x101c_fbd4]);    /* mov edx, [0x101cfbd4] */
            ii(0x1016_c27c, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1016_c27e, 1); dec(edx);                               /* dec edx */
            ii(0x1016_c27f, 6); mov(ecx, memd_a32[ds, 0x101c_fb94]);    /* mov ecx, [0x101cfb94] */
            ii(0x1016_c285, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x1016_c288, 6); mov(edx, memd_a32[ds, 0x101c_fbd0]);    /* mov edx, [0x101cfbd0] */
            ii(0x1016_c28e, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1016_c290, 1); dec(edx);                               /* dec edx */
            ii(0x1016_c291, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x1016_c294, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c295, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_c296, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c297, 1); retd(); return;                         /* ret */
        }
    }
}
