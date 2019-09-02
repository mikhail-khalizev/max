using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_13f7-fbae44c1")]
        public void Method_100a_13f7()
        {
            ii(0x100a_13f7, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_13fc, 5); call(Definitions.sys_check_available_stack_size, 0xc_4951); /* call 0x10165d52 */
            ii(0x100a_1401, 1); push(ebx);                              /* push ebx */
            ii(0x100a_1402, 1); push(ecx);                              /* push ecx */
            ii(0x100a_1403, 1); push(esi);                              /* push esi */
            ii(0x100a_1404, 1); push(edi);                              /* push edi */
            ii(0x100a_1405, 1); push(ebp);                              /* push ebp */
            ii(0x100a_1406, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_1408, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_140e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_1411, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_1414, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1417, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100a_141a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_141d, 3); sub(memw[ds, eax], dx);                 /* sub [eax], dx */
            ii(0x100a_1420, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1423, 4); mov(dx, memw[ds, eax + 2]);             /* mov dx, [eax+0x2] */
            ii(0x100a_1427, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_142a, 4); sub(memw[ds, eax + 2], dx);             /* sub [eax+0x2], dx */
            ii(0x100a_142e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_1431, 4); mov(dx, memw[ds, eax + 4]);             /* mov dx, [eax+0x4] */
            ii(0x100a_1435, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_1438, 4); sub(memw[ds, eax + 4], dx);             /* sub [eax+0x4], dx */
            ii(0x100a_143c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_143f, 4); mov(dx, memw[ds, eax + 6]);             /* mov dx, [eax+0x6] */
            ii(0x100a_1443, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_1446, 4); sub(memw[ds, eax + 6], dx);             /* sub [eax+0x6], dx */
            ii(0x100a_144a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_144d, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x100a_1451, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_1454, 4); sub(memw[ds, eax + 8], dx);             /* sub [eax+0x8], dx */
            ii(0x100a_1458, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_145a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_145b, 1); pop(edi);                               /* pop edi */
            ii(0x100a_145c, 1); pop(esi);                               /* pop esi */
            ii(0x100a_145d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_145e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_145f, 1); ret();                                  /* ret */
        }
    }
}
