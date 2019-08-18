using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7cbad969-6b19-480c-8be7-e1ed7824727c")]
        public void /* sys */ Method_1019_4c8a()
        {
            ii(0x1019_4c8a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4c8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4c8d, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4c8e, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4c8f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4c90, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4c91, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4c93, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4c95, 1); pushd(es);                              /* push es */
            ii(0x1019_4c96, 4); mov(cx, memw_a32[ss, ebp + 0x8]);       /* mov cx, [ebp+0x8] */
            ii(0x1019_4c9a, 4); mov(bx, memw_a32[ss, ebp + 0xa]);       /* mov bx, [ebp+0xa] */
            ii(0x1019_4c9e, 4); mov(di, memw_a32[ss, ebp + 0xc]);       /* mov di, [ebp+0xc] */
            ii(0x1019_4ca2, 4); mov(si, memw_a32[ss, ebp + 0xe]);       /* mov si, [ebp+0xe] */
            ii(0x1019_4ca6, 4); mov(ax, 0x600);                         /* mov ax, 0x600 */
            ii(0x1019_4caa, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4cac, 1); popd(es);                               /* pop es */
            ii(0x1019_4cad, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4caf, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4cb1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4cb2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4cb3, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4cb4, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4cb5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4cb6, 1); retd(); return;                         /* ret */
        }
    }
}
