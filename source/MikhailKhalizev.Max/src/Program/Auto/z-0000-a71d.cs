using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a9f208b-8ced-4184-8e30-3289cd9fe182")]
        public void Method_0000_a71d()
        {
            ii(0xa71d, 3);    mov(memw_a16[ds, 0xc4c], ax);             /* mov [0xc4c], ax */
            ii(0xa720, 4);    mov(memb_a16[ds, 0x980], dl);             /* mov [0x980], dl */
            ii(0xa724, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xa726, 2);    xor(di, di);                              /* xor di, di */
            ii(0xa728, 1);    pushw(cs);                                /* push cs */
            ii(0xa729, 3);    callw(0xab81, 0x455);                     /* call 0xab81 */
            ii(0xa72c, 6);    mov(esi, memd_a16[cs, 0x6e14]);           /* mov esi, [cs:0x6e14] */
            ii(0xa732, 6);    mov(edi, memd_a16[cs, 0x6e18]);           /* mov edi, [cs:0x6e18] */
            ii(0xa738, 6);    mov(edx, memd_a16[cs, 0x6e1c]);           /* mov edx, [cs:0x6e1c] */
            ii(0xa73e, 6);    mov(memw_a16[ds, 0xaa4], 0x571d);         /* mov word [0xaa4], 0x571d */
            ii(0xa744, 6);    mov(memw_a16[ds, 0xaa6], 0x56f4);         /* mov word [0xaa6], 0x56f4 */
            ii(0xa74a, 1);    retw(); return;                           /* ret */
        }
    }
}
