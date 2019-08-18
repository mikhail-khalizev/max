using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("74987edd-6b16-449b-91a8-de50de42d047")]
        public void /* sys */ Method_1019_540c()
        {
            ii(0x1019_540c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_540d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_540f, 1); pushd(esi);                             /* push esi */
            ii(0x1019_5410, 1); pushd(edi);                             /* push edi */
            ii(0x1019_5411, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5412, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_5413, 2); pushd(fs);                              /* push fs */
            ii(0x1019_5415, 2); pushd(gs);                              /* push gs */
            ii(0x1019_5417, 1); pushd(es);                              /* push es */
            ii(0x1019_5418, 4); mov(ax, 0x800);                         /* mov ax, 0x800 */
            ii(0x1019_541c, 4); mov(bx, memw_a32[ss, ebp + 0xa]);       /* mov bx, [ebp+0xa] */
            ii(0x1019_5420, 4); mov(cx, memw_a32[ss, ebp + 0x8]);       /* mov cx, [ebp+0x8] */
            ii(0x1019_5424, 4); mov(si, 0);                             /* mov si, 0x0 */
            ii(0x1019_5428, 4); mov(di, 0x4000);                        /* mov di, 0x4000 */
            ii(0x1019_542c, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_542e, 4); mov(memw_a32[ss, ebp - 0x8], cx);       /* mov [ebp-0x8], cx */
            ii(0x1019_5432, 4); mov(memw_a32[ss, ebp - 0x6], bx);       /* mov [ebp-0x6], bx */
            ii(0x1019_5436, 4); mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1019_543a, 4); mov(cx, 0x1);                           /* mov cx, 0x1 */
            ii(0x1019_543e, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_5440, 4); mov(memw_a32[ss, ebp - 0x4], ax);       /* mov [ebp-0x4], ax */
            ii(0x1019_5444, 4); mov(ax, 0x7);                           /* mov ax, 0x7 */
            ii(0x1019_5448, 4); mov(bx, memw_a32[ss, ebp - 0x4]);       /* mov bx, [ebp-0x4] */
            ii(0x1019_544c, 4); mov(cx, memw_a32[ss, ebp - 0x6]);       /* mov cx, [ebp-0x6] */
            ii(0x1019_5450, 4); mov(dx, memw_a32[ss, ebp - 0x8]);       /* mov dx, [ebp-0x8] */
            ii(0x1019_5454, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_5456, 4); mov(ax, 0x8);                           /* mov ax, 0x8 */
            ii(0x1019_545a, 4); mov(bx, memw_a32[ss, ebp - 0x4]);       /* mov bx, [ebp-0x4] */
            ii(0x1019_545e, 4); mov(cx, 0xffff);                        /* mov cx, 0xffff */
            ii(0x1019_5462, 4); mov(dx, 0xffff);                        /* mov dx, 0xffff */
            ii(0x1019_5466, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_5468, 4); mov(ax, 0x9);                           /* mov ax, 0x9 */
            ii(0x1019_546c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1019_546e, 3); mov(cx, ds);                            /* mov cx, ds */
            ii(0x1019_5471, 3); lar(ecx, cx);                           /* lar ecx, cx */
            ii(0x1019_5474, 3); shr(ecx, 0x8);                          /* shr ecx, 0x8 */
            ii(0x1019_5477, 4); mov(bx, memw_a32[ss, ebp - 0x4]);       /* mov bx, [ebp-0x4] */
            ii(0x1019_547b, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1019_547d, 4); mov(ax, memw_a32[ss, ebp - 0x4]);       /* mov ax, [ebp-0x4] */
            ii(0x1019_5481, 1); popd(es);                               /* pop es */
            ii(0x1019_5482, 2); popd(gs);                               /* pop gs */
            ii(0x1019_5484, 2); popd(fs);                               /* pop fs */
            ii(0x1019_5486, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_5487, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_5488, 1); popd(edi);                              /* pop edi */
            ii(0x1019_5489, 1); popd(esi);                              /* pop esi */
            ii(0x1019_548a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_548b, 1); retd(); return;                         /* ret */
        }
    }
}
