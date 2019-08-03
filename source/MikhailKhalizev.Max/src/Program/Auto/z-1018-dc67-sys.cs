using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("90565a08-8701-4ffd-81c5-58808a5583f0")]
        public void /* sys */ Method_1018_dc67()
        {
            ii(0x1018_dc67, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_dc68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_dc6a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_dc6b, 1); cli();                                  /* cli */
            ii(0x1018_dc6c, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1018_dc6f, 5); mov(memd_a32[ds, 0x101b_e420], eax);    /* mov [0x101be420], eax */
            ii(0x1018_dc74, 2); mov(al, 0x80);                          /* mov al, 0x80 */
            ii(0x1018_dc76, 2); outb(0x43, al);                         /* out 0x43, al */
            ii(0x1018_dc78, 2); inb(al, 0x42);                          /* in al, 0x42 */
            ii(0x1018_dc7a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1018_dc7c, 2); inb(al, 0x42);                          /* in al, 0x42 */
            ii(0x1018_dc7e, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1018_dc80, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_dc82, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dc84, 7); mov(bx, memw_a32[ds, 0x1020_9dd0]);     /* mov bx, [0x10209dd0] */
            ii(0x1018_dc8b, 3); sub(bx, ax);                            /* sub bx, ax */
            ii(0x1018_dc8e, 6); sub(memd_a32[ds, 0x101b_e420], ebx);    /* sub [0x101be420], ebx */
            ii(0x1018_dc94, 1); sti();                                  /* sti */
            ii(0x1018_dc95, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_dc96, 1); leaved();                               /* leave */
            ii(0x1018_dc97, 1); retd(); return;                         /* ret */
        }
    }
}
