using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4c8a-32b14ef1")]
        public void /* sys */ Method_1019_4c8a()
        {
            ii(0x1019_4c8a, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4c8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4c8d, 1); push(esi);                              /* push esi */
            ii(0x1019_4c8e, 1); push(edi);                              /* push edi */
            ii(0x1019_4c8f, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4c90, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4c91, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4c93, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4c95, 1); pushd(es);                              /* push es */
            ii(0x1019_4c96, 4); mov(cx, memw[ss, ebp + 0x8]);           /* mov cx, [ebp+0x8] */
            ii(0x1019_4c9a, 4); mov(bx, memw[ss, ebp + 0xa]);           /* mov bx, [ebp+0xa] */
            ii(0x1019_4c9e, 4); mov(di, memw[ss, ebp + 0xc]);           /* mov di, [ebp+0xc] */
            ii(0x1019_4ca2, 4); mov(si, memw[ss, ebp + 0xe]);           /* mov si, [ebp+0xe] */
            ii(0x1019_4ca6, 4); mov(ax, 0x600);                         /* mov ax, 0x600 */
            ii(0x1019_4caa, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4cac, 1); popd(es);                               /* pop es */
            ii(0x1019_4cad, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4caf, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4cb1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4cb2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4cb3, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4cb4, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4cb5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4cb6, 1); ret();                                  /* ret */
        }
    }
}
