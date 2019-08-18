using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_548c-b0584502")]
        public void /* sys */ Method_1019_548c()
        {
            ii(0x1019_548c, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_548f, 2); mov(gs, eax);                           /* mov gs, eax */
            ii(0x1019_5491, 2); mov(fs, eax);                           /* mov fs, eax */
            ii(0x1019_5493, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_5495, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_5496, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_5498, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5499, 1); pushd(edi);                             /* push edi */
            ii(0x1019_549a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_549b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_549c, 2); pushd(fs);                              /* push fs */
            ii(0x1019_549e, 2); pushd(gs);                              /* push gs */
            ii(0x1019_54a0, 1); pushd(es);                              /* push es */
            ii(0x1019_54a1, 4); mov(ax, 0x1);                           /* mov ax, 0x1 */
            ii(0x1019_54a5, 4); mov(bx, memw_a32[ss, ebp + 0x8]);       /* mov bx, [ebp+0x8] */
            ii(0x1019_54a9, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_54ab, 1); popd(es);                               /* pop es */
            ii(0x1019_54ac, 2); popd(gs);                               /* pop gs */
            ii(0x1019_54ae, 2); popd(fs);                               /* pop fs */
            ii(0x1019_54b0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_54b1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_54b2, 1); popd(edi);                              /* pop edi */
            ii(0x1019_54b3, 1); popd(esi);                              /* pop esi */
            ii(0x1019_54b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_54b5, 1); retd(); return;                         /* ret */
        }
    }
}
