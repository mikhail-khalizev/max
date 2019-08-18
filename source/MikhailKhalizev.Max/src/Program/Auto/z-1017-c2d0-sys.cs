using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6446e890-2c79-48fe-8c05-9b565cc9fd58")]
        public void /* sys */ Method_1017_c2d0()
        {
            ii(0x1017_c2d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_c2d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_c2d3, 7); cmp(memd_a32[ds, 0x101b_e458], 0);      /* cmp dword [0x101be458], 0x0 */
            ii(0x1017_c2da, 2); if(jzd(0x1017_c2f3, 0x17)) goto l_0x1017_c2f3; /* jz 0x1017c2f3 */
            ii(0x1017_c2dc, 5); calld(/* sys */ 0x1017_97f0, -0x2af1);  /* call 0x101797f0 */
            ii(0x1017_c2e1, 5); calld(/* sys */ 0x1017_9650, -0x2c96);  /* call 0x10179650 */
            ii(0x1017_c2e6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c2e8, 5); calld(/* sys */ 0x1017_9cb0, -0x263d);  /* call 0x10179cb0 */
            ii(0x1017_c2ed, 6); mov(memd_a32[ds, 0x101b_e458], ebx);    /* mov [0x101be458], ebx */
        l_0x1017_c2f3:
            ii(0x1017_c2f3, 5); mov(eax, 0x1020_9c60);                  /* mov eax, 0x10209c60 */
            ii(0x1017_c2f8, 5); calld(/* sys */ 0x1017_94e0, -0x2e1d);  /* call 0x101794e0 */
            ii(0x1017_c2fd, 5); mov(eax, 0x1020_9c50);                  /* mov eax, 0x10209c50 */
            ii(0x1017_c302, 5); calld(/* sys */ 0x1017_94e0, -0x2e27);  /* call 0x101794e0 */
            ii(0x1017_c307, 5); mov(eax, 0x1020_9a50);                  /* mov eax, 0x10209a50 */
            ii(0x1017_c30c, 5); calld(/* sys */ 0x1017_94e0, -0x2e31);  /* call 0x101794e0 */
            ii(0x1017_c311, 5); mov(eax, 0x1020_9a60);                  /* mov eax, 0x10209a60 */
            ii(0x1017_c316, 5); calld(/* sys */ 0x1017_94e0, -0x2e3b);  /* call 0x101794e0 */
            ii(0x1017_c31b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1017_c31d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_c31e, 1); retd(); return;                         /* ret */
        }
    }
}
