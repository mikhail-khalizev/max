using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_92f0-feb76115")]
        public void /* sys */ Method_1017_92f0()
        {
            ii(0x1017_92f0, 1); push(edx);                              /* push edx */
            ii(0x1017_92f1, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_92f3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_92f5, 6); mov(bl, memb[ds, 0x101b_e58e]);         /* mov bl, [0x101be58e] */
            ii(0x1017_92fb, 3); cmp(ebx, 0x2);                          /* cmp ebx, 0x2 */
            ii(0x1017_92fe, 2); if(jl(0x1017_9313, 0x13)) goto l_0x1017_9313; /* jl 0x10179313 */
            ii(0x1017_9300, 3); cmp(ebx, 0x8);                          /* cmp ebx, 0x8 */
            ii(0x1017_9303, 2); if(jg(0x1017_9313, 0xe)) goto l_0x1017_9313; /* jg 0x10179313 */
            ii(0x1017_9305, 1); pushd(ds);                              /* push ds */
            ii(0x1017_9306, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1017_9308, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_930a, 2); mov(al, 0x4);                           /* mov al, 0x4 */
            ii(0x1017_930c, 2); mov(ah, 0x25);                          /* mov ah, 0x25 */
            ii(0x1017_930e, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_9310, 1); popd(ds);                               /* pop ds */
            ii(0x1017_9311, 1); pop(edx);                               /* pop edx */
            ii(0x1017_9312, 1); ret(); return;                          /* ret */
        l_0x1017_9313:
            ii(0x1017_9313, 1); pushd(ds);                              /* push ds */
            ii(0x1017_9314, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1017_9316, 2); mov(ah, 0x25);                          /* mov ah, 0x25 */
            ii(0x1017_9318, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1017_931a, 1); popd(ds);                               /* pop ds */
            ii(0x1017_931b, 1); pop(edx);                               /* pop edx */
            ii(0x1017_931c, 1); ret();                                  /* ret */
        }
    }
}
