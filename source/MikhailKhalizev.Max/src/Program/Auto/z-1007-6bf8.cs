using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6bf8-3902bcd5")]
        public void Method_1007_6bf8()
        {
            ii(0x1007_6bf8, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_6bfd, 5); call(Definitions.sys_check_available_stack_size, 0xe_f150); /* call 0x10165d52 */
            ii(0x1007_6c02, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6c03, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6c04, 1); push(edx);                              /* push edx */
            ii(0x1007_6c05, 1); push(esi);                              /* push esi */
            ii(0x1007_6c06, 1); push(edi);                              /* push edi */
            ii(0x1007_6c07, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6c08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6c0a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1007_6c10, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6c13, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6c16, 5); call(0x1007_6c68, 0x4d);                /* call 0x10076c68 */
            ii(0x1007_6c1b, 3); lea(edx, eax + 0xa);                    /* lea edx, [eax+0xa] */
            ii(0x1007_6c1e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6c21, 5); call(0x1013_acc5, 0xc_409f);            /* call 0x1013acc5 */
            ii(0x1007_6c26, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6c28, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6c29, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6c2a, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6c2b, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6c2c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6c2d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6c2e, 1); ret();                                  /* ret */
        }
    }
}
