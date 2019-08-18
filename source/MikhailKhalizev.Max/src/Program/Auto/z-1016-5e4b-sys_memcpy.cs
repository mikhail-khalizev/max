using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5e4b-d737e962")]
        public void /* sys */ sys_memcpy()
        {
            ii(0x1016_5e4b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5e4c, 1); pushd(esi);                             /* push esi */
            ii(0x1016_5e4d, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5e4e, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1016_5e50, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_5e52, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_5e54, 1); pushd(es);                              /* push es */
            ii(0x1016_5e55, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1016_5e57, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1016_5e59, 1); pushd(edi);                             /* push edi */
            ii(0x1016_5e5a, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_5e5c, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1016_5e5f, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1016_5e61, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_5e63, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1016_5e66, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1016_5e68, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5e69, 1); popd(es);                               /* pop es */
            ii(0x1016_5e6a, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_5e6c, 1); popd(edi);                              /* pop edi */
            ii(0x1016_5e6d, 1); popd(esi);                              /* pop esi */
            ii(0x1016_5e6e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5e6f, 1); retd(); return;                         /* ret */
        }
    }
}
