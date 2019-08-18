using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dd02-7915c1c2")]
        public void /* sys */ Method_1018_dd02()
        {
            ii(0x1018_dd02, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_dd03, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_dd05, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_dd06, 3); mov(ecx, memd_a32[ss, ebp + 0x8]);      /* mov ecx, [ebp+0x8] */
        l_0x1018_dd09:
            ii(0x1018_dd09, 2); mov(al, 0x80);                          /* mov al, 0x80 */
            ii(0x1018_dd0b, 1); cli();                                  /* cli */
            ii(0x1018_dd0c, 2); outb(0x43, al);                         /* out 0x43, al */
            ii(0x1018_dd0e, 2); inb(al, 0x42);                          /* in al, 0x42 */
            ii(0x1018_dd10, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1018_dd12, 2); inb(al, 0x42);                          /* in al, 0x42 */
            ii(0x1018_dd14, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1018_dd16, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1018_dd18, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_dd1a, 7); mov(bx, memw_a32[ds, 0x1020_9dd0]);     /* mov bx, [0x10209dd0] */
            ii(0x1018_dd21, 3); sub(bx, ax);                            /* sub bx, ax */
            ii(0x1018_dd24, 6); add(ebx, memd_a32[ds, 0x101b_e420]);    /* add ebx, [0x101be420] */
            ii(0x1018_dd2a, 1); sti();                                  /* sti */
            ii(0x1018_dd2b, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1018_dd2d, 2); if(jsd(0x1018_dd09, -0x26)) goto l_0x1018_dd09; /* js 0x1018dd09 */
            ii(0x1018_dd2f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_dd31, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_dd32, 1); leaved();                               /* leave */
            ii(0x1018_dd33, 1); retd(); return;                         /* ret */
        }
    }
}
