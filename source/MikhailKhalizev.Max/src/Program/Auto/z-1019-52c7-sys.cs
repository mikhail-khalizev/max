using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fb716a46-5d13-446d-a9cb-9f8f4ae03d68")]
        public void /* sys */ Method_1019_52c7()
        {
            ii(0x1019_52c7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_52c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_52ca, 1); pushd(esi);                             /* push esi */
            ii(0x1019_52cb, 1); pushd(edi);                             /* push edi */
            ii(0x1019_52cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_52cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_52ce, 2); pushd(fs);                              /* push fs */
            ii(0x1019_52d0, 2); pushd(gs);                              /* push gs */
            ii(0x1019_52d2, 1); pushd(es);                              /* push es */
            ii(0x1019_52d3, 4); mov(ax, 0x1600);                        /* mov ax, 0x1600 */
            ii(0x1019_52d7, 2); @int(0x2f);                             /* int 0x2f */
            ii(0x1019_52d9, 1); popd(es);                               /* pop es */
            ii(0x1019_52da, 2); popd(gs);                               /* pop gs */
            ii(0x1019_52dc, 2); popd(fs);                               /* pop fs */
            ii(0x1019_52de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_52df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_52e0, 1); popd(edi);                              /* pop edi */
            ii(0x1019_52e1, 1); popd(esi);                              /* pop esi */
            ii(0x1019_52e2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_52e3, 1); retd(); return;                         /* ret */
        }
    }
}
