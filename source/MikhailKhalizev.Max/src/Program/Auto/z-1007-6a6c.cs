using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6a6c-19284a93")]
        public void Method_1007_6a6c()
        {
            ii(0x1007_6a6c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_6a71, 5); call(Definitions.sys_check_available_stack_size, 0xe_f2dc); /* call 0x10165d52 */
            ii(0x1007_6a76, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6a77, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6a78, 1); push(esi);                              /* push esi */
            ii(0x1007_6a79, 1); push(edi);                              /* push edi */
            ii(0x1007_6a7a, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6a7b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6a7d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_6a83, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6a86, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6a89, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6a8c, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1007_6a8f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6a92, 3); sub(memw[ds, eax], dx);                 /* sub [eax], dx */
            ii(0x1007_6a95, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6a98, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1007_6a9c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6a9f, 4); sub(memw[ds, eax + 0x2], dx);           /* sub [eax+0x2], dx */
            ii(0x1007_6aa3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6aa5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6aa6, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6aa7, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6aa8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6aa9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6aaa, 1); ret();                                  /* ret */
        }
    }
}
