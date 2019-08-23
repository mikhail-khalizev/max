using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4e3d-6d6c04be")]
        public void /* sys */ Method_1019_4e3d()
        {
            ii(0x1019_4e3d, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_4e40, 2); mov(gs, eax);                           /* mov gs, eax */
            ii(0x1019_4e42, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1019_4e44, 2); mov(fs, eax);                           /* mov fs, eax */
            ii(0x1019_4e46, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4e47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4e49, 1); push(esi);                              /* push esi */
            ii(0x1019_4e4a, 1); push(edi);                              /* push edi */
            ii(0x1019_4e4b, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4e4c, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4e4d, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4e4f, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4e51, 1); pushd(es);                              /* push es */
            ii(0x1019_4e52, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4e54, 4); mov(ax, 0x101);                         /* mov ax, 0x101 */
            ii(0x1019_4e58, 3); mov(edx, memd[ss, ebp + 0x8]);          /* mov edx, [ebp+0x8] */
            ii(0x1019_4e5b, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4e5d, 1); popd(es);                               /* pop es */
            ii(0x1019_4e5e, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4e60, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4e62, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4e63, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4e64, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4e65, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4e66, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4e67, 1); ret();                                  /* ret */
        }
    }
}
