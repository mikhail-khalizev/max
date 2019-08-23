using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_11ea-c872498a")]
        public void Method_1012_11ea()
        {
            ii(0x1012_11ea, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_11ef, 5); call(Definitions.sys_check_available_stack_size, 0x4_4b5e); /* call 0x10165d52 */
            ii(0x1012_11f4, 1); push(ebx);                              /* push ebx */
            ii(0x1012_11f5, 1); push(ecx);                              /* push ecx */
            ii(0x1012_11f6, 1); push(edx);                              /* push edx */
            ii(0x1012_11f7, 1); push(esi);                              /* push esi */
            ii(0x1012_11f8, 1); push(edi);                              /* push edi */
            ii(0x1012_11f9, 1); push(ebp);                              /* push ebp */
            ii(0x1012_11fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_11fc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_1202, 5); mov(al, memb[ds, 0x101c_5620]);         /* mov al, [0x101c5620] */
            ii(0x1012_1207, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_120a, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_120d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_120f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_1210, 1); pop(edi);                               /* pop edi */
            ii(0x1012_1211, 1); pop(esi);                               /* pop esi */
            ii(0x1012_1212, 1); pop(edx);                               /* pop edx */
            ii(0x1012_1213, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_1214, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_1215, 1); ret();                                  /* ret */
        }
    }
}
