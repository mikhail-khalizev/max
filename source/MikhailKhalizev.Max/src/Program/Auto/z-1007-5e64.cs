using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5e64-e8e9edd3")]
        public void Method_1007_5e64()
        {
            ii(0x1007_5e64, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_5e69, 5); call(Definitions.sys_check_available_stack_size, 0xe_fee4); /* call 0x10165d52 */
            ii(0x1007_5e6e, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5e6f, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5e70, 1); push(esi);                              /* push esi */
            ii(0x1007_5e71, 1); push(edi);                              /* push edi */
            ii(0x1007_5e72, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5e73, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5e75, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5e7b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_5e7e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_5e81, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_5e84, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1007_5e87, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5e8a, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1007_5e8d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_5e90, 4); mov(dx, memw[ds, eax + 2]);             /* mov dx, [eax+0x2] */
            ii(0x1007_5e94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5e97, 4); mov(memw[ds, eax + 2], dx);             /* mov [eax+0x2], dx */
            ii(0x1007_5e9b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_5e9e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_5ea1, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_5ea4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5ea6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5ea7, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5ea8, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5ea9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5eaa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5eab, 1); ret();                                  /* ret */
        }
    }
}
