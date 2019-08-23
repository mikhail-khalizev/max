using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4c5d-32b14ef1")]
        public void /* sys */ Method_1019_4c5d()
        {
            ii(0x1019_4c5d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4c5e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4c60, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4c61, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4c62, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4c63, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4c64, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4c66, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4c68, 1); pushd(es);                              /* push es */
            ii(0x1019_4c69, 4); mov(cx, memw_a32[ss, ebp + 0x8]);       /* mov cx, [ebp+0x8] */
            ii(0x1019_4c6d, 4); mov(bx, memw_a32[ss, ebp + 0xa]);       /* mov bx, [ebp+0xa] */
            ii(0x1019_4c71, 4); mov(di, memw_a32[ss, ebp + 0xc]);       /* mov di, [ebp+0xc] */
            ii(0x1019_4c75, 4); mov(si, memw_a32[ss, ebp + 0xe]);       /* mov si, [ebp+0xe] */
            ii(0x1019_4c79, 4); mov(ax, 0x600);                         /* mov ax, 0x600 */
            ii(0x1019_4c7d, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4c7f, 1); popd(es);                               /* pop es */
            ii(0x1019_4c80, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4c82, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4c84, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4c85, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4c86, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4c87, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4c88, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4c89, 1); retd();                                 /* ret */
        }
    }
}
