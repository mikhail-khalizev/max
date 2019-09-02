using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4d7e-d839013f")]
        public void /* sys */ Method_1019_4d7e()
        {
            ii(0x1019_4d7e, 1); push(ebp);                              /* push ebp */
            ii(0x1019_4d7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4d81, 1); push(esi);                              /* push esi */
            ii(0x1019_4d82, 1); push(edi);                              /* push edi */
            ii(0x1019_4d83, 1); push(ebx);                              /* push ebx */
            ii(0x1019_4d84, 1); push(ecx);                              /* push ecx */
            ii(0x1019_4d85, 2); pushd(fs);                              /* push fs */
            ii(0x1019_4d87, 2); pushd(gs);                              /* push gs */
            ii(0x1019_4d89, 1); pushd(es);                              /* push es */
            ii(0x1019_4d8a, 4); mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1019_4d8e, 4); mov(cx, 1);                             /* mov cx, 0x1 */
            ii(0x1019_4d92, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4d94, 1); push(eax);                              /* push eax */
            ii(0x1019_4d95, 1); push(eax);                              /* push eax */
            ii(0x1019_4d96, 1); push(eax);                              /* push eax */
            ii(0x1019_4d97, 1); push(eax);                              /* push eax */
            ii(0x1019_4d98, 4); mov(bx, memw[ss, ebp + 0xc]);           /* mov bx, [ebp+0xc] */
            ii(0x1019_4d9c, 4); mov(ax, 6);                             /* mov ax, 0x6 */
            ii(0x1019_4da0, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4da2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4da3, 4); mov(ax, 7);                             /* mov ax, 0x7 */
            ii(0x1019_4da7, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4da9, 4); mov(ax, 8);                             /* mov ax, 0x8 */
            ii(0x1019_4dad, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4dae, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_4db0, 5); mov(edx, 0xffff);                       /* mov edx, 0xffff */
            ii(0x1019_4db5, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4db7, 4); mov(ax, 9);                             /* mov ax, 0x9 */
            ii(0x1019_4dbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4dbc, 3); lar(ecx, bx);                           /* lar ecx, bx */
            ii(0x1019_4dbf, 3); shr(ecx, 8);                            /* shr ecx, 0x8 */
            ii(0x1019_4dc2, 5); or(cx, 0x4008);                         /* or cx, 0x4008 */
            ii(0x1019_4dc7, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_4dc9, 1); pop(edx);                               /* pop edx */
            ii(0x1019_4dca, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_4dcc, 1); popd(es);                               /* pop es */
            ii(0x1019_4dcd, 2); popd(gs);                               /* pop gs */
            ii(0x1019_4dcf, 2); popd(fs);                               /* pop fs */
            ii(0x1019_4dd1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_4dd2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_4dd3, 1); pop(edi);                               /* pop edi */
            ii(0x1019_4dd4, 1); pop(esi);                               /* pop esi */
            ii(0x1019_4dd5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_4dd6, 1); ret();                                  /* ret */
        }
    }
}
