using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_70e8-94dbbe17")]
        public void /* sys */ Method_1018_70e8()
        {
            ii(0x1018_70e8, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_70ea, 7);  mov(bx, memw[ds, 0x101b_e88c]);       /* mov bx, [0x101be88c] */
            ii(0x1018_70f1, 3);  mov(ax, memw[ds, ebx]);               /* mov ax, [ebx] */
            ii(0x1018_70f4, 6);  mov(memw[ds, 0x101b_e898], ax);       /* mov [0x101be898], ax */
            ii(0x1018_70fa, 2);  mov(al, 0x34);                        /* mov al, 0x34 */
            ii(0x1018_70fc, 2);  outb(0x43, al);                       /* out 0x43, al */
            ii(0x1018_70fe, 2);  xor(al, al);                          /* xor al, al */
            ii(0x1018_7100, 2);  outb(0x40, al);                       /* out 0x40, al */
            ii(0x1018_7102, 2);  outb(0x40, al);                       /* out 0x40, al */
            ii(0x1018_7104, 1);  ret();                                /* ret */
        }
    }
}
