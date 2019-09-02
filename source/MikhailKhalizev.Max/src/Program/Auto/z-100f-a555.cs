using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a555-f37d1540")]
        public void Method_100f_a555()
        {
            ii(0x100f_a555, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a55a, 5); call(0x1007_6574, -0x8_3feb);           /* call 0x10076574 */
            ii(0x100f_a55f, 7); mov(dx, memw[ds, 0x101c_3908]);         /* mov dx, [0x101c3908] */
            ii(0x100f_a566, 4); mov(memw[ds, eax + 65], dx);            /* mov [eax+0x41], dx */
            ii(0x100f_a56a, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a56f, 5); call(0x1007_6574, -0x8_4000);           /* call 0x10076574 */
            ii(0x100f_a574, 7); mov(dx, memw[ds, 0x101c_390a]);         /* mov dx, [0x101c390a] */
            ii(0x100f_a57b, 4); mov(memw[ds, eax + 67], dx);            /* mov [eax+0x43], dx */
            ii(0x100f_a57f, 5); mov(eax, memd[ds, 0x101c_3908]);        /* mov eax, [0x101c3908] */
            ii(0x100f_a584, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_a587, 1); push(eax);                              /* push eax */
            ii(0x100f_a588, 6); mov(ecx, memd[ds, 0x101c_3906]);        /* mov ecx, [0x101c3906] */
            ii(0x100f_a58e, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a591, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a596, 5); call(0x1007_65d0, -0x8_3fcb);           /* call 0x100765d0 */
            ii(0x100f_a59b, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_a59d, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_a5a2, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x100f_a5a7, 5); call(0x100f_79d4, -0x2bd8);             /* call 0x100f79d4 */
            ii(0x100f_a5ac, 5); if(jmp_func(0x100f_a75d, 0x1ac)) return; /* jmp 0x100fa75d */
        }
    }
}
