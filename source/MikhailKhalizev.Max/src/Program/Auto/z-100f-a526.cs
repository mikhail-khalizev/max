using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a526-414c24dd")]
        public void Method_100f_a526()
        {
            ii(0x100f_a526, 5); mov(eax, memd[ds, 0x101c_3908]);        /* mov eax, [0x101c3908] */
            ii(0x100f_a52b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a52e, 1); push(eax);                              /* push eax */
            ii(0x100f_a52f, 6); mov(ecx, memd[ds, 0x101c_3906]);        /* mov ecx, [0x101c3906] */
            ii(0x100f_a535, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a538, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a53d, 5); call(0x1007_65d0, -0x8_3f72);           /* call 0x100765d0 */
            ii(0x100f_a542, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a544, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_a546, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100f_a54b, 5); call(0x100f_79d4, -0x2b7c);             /* call 0x100f79d4 */
            ii(0x100f_a550, 5); if(jmp_func(0x100f_a75d, 0x208)) return; /* jmp 0x100fa75d */
        }
    }
}
