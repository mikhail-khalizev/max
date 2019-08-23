using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7105-3fb3ec8b")]
        public void /* sys */ Method_1018_7105()
        {
            ii(0x1018_7105, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1018_7107, 1); cli();                                  /* cli */
            ii(0x1018_7108, 2); outb(0x43, al);                         /* out 0x43, al */
            ii(0x1018_710a, 2); inb(al, 0x40);                          /* in al, 0x40 */
            ii(0x1018_710c, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_710e, 2); inb(al, 0x40);                          /* in al, 0x40 */
            ii(0x1018_7110, 2); mov(dh, al);                            /* mov dh, al */
            ii(0x1018_7112, 1); sti();                                  /* sti */
            ii(0x1018_7113, 6); mov(ax, memw_a32[ds, 0x101b_e88e]);     /* mov ax, [0x101be88e] */
            ii(0x1018_7119, 3); sub(ax, dx);                            /* sub ax, dx */
            ii(0x1018_711c, 7); mul(memw_a32[ds, 0x101b_e890]);         /* mul word [0x101be890] */
            ii(0x1018_7123, 7); div(memw_a32[ds, 0x101b_e896]);         /* div word [0x101be896] */
            ii(0x1018_712a, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1018_712d, 7); div(memw_a32[ds, 0x101b_e896]);         /* div word [0x101be896] */
            ii(0x1018_7134, 5); cmp(dx, 0x1f4);                         /* cmp dx, 0x1f4 */
            ii(0x1018_7139, 2); if(jbd(0x1018_713d, 0x2)) goto l_0x1018_713d; /* jb 0x1018713d */
            ii(0x1018_713b, 2); inc(ax);                                /* inc ax */
        l_0x1018_713d:
            ii(0x1018_713d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1018_713f, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1018_7142, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_7144, 7); mov(bx, memw_a32[ds, 0x101b_e88c]);     /* mov bx, [0x101be88c] */
            ii(0x1018_714b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_714d, 3); mov(ax, memw_a32[ds, ebx]);             /* mov ax, [ebx] */
            ii(0x1018_7150, 7); sub(ax, memw_a32[ds, 0x101b_e898]);     /* sub ax, [0x101be898] */
            ii(0x1018_7157, 6); mul(memd_a32[ds, 0x101b_e892]);         /* mul dword [0x101be892] */
            ii(0x1018_715d, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_715f, 1); retd();                                 /* ret */
        }
    }
}
