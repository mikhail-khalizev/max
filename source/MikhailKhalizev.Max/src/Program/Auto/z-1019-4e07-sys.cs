using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("429c1124-b57a-4200-8025-ae0a9fc02049")]
        public void /* sys */ Method_1019_4e07()
        {
            ii(0x1019_4e07, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4e08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4e0a, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4e0b, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4e0c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_4e0d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_4e0e, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4e10, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4e12, 1); pushd(es);                              /* push es */
            ii(0x1019_4e13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4e15, 4); mov(ax, 0x100);                         /* mov ax, 0x100 */
            ii(0x1019_4e19, 3); mov(ebx, memd_a32[ss, ebp + 0x8]);      /* mov ebx, [ebp+0x8] */
            ii(0x1019_4e1c, 6); add(ebx, 0x100);                        /* add ebx, 0x100 */
            ii(0x1019_4e22, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4e24, 3); mov(esi, memd_a32[ss, ebp + 0xc]);      /* mov esi, [ebp+0xc] */
            ii(0x1019_4e27, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1019_4e2a, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1019_4e2c, 3); mov(esi, memd_a32[ss, ebp + 0x10]);     /* mov esi, [ebp+0x10] */
            ii(0x1019_4e2f, 3); mov(memw_a32[ds, esi], dx);             /* mov [esi], dx */
            ii(0x1019_4e32, 1); popd(es);                               /* pop es */
            ii(0x1019_4e33, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4e35, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4e37, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_4e38, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4e39, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4e3a, 1); popd(esi);                              /* pop esi */
            ii(0x1019_4e3b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_4e3c, 1); retd(); return;                         /* ret */
        }
    }
}
