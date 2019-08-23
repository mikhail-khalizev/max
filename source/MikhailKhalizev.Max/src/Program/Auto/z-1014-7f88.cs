using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7f88-5a05f373")]
        public void Method_1014_7f88()
        {
            ii(0x1014_7f88, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_7f8d, 5); call(Definitions.sys_check_available_stack_size, 0x1_ddc0); /* call 0x10165d52 */
            ii(0x1014_7f92, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7f93, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7f94, 1); push(edx);                              /* push edx */
            ii(0x1014_7f95, 1); push(esi);                              /* push esi */
            ii(0x1014_7f96, 1); push(edi);                              /* push edi */
            ii(0x1014_7f97, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7f98, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7f9a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7fa0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_7fa3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_7fa6, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_7fa9, 5); call(Definitions.my_strobj_c_str_v2, -0xb_e7e6); /* call 0x100897c8 */
            ii(0x1014_7fae, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7fb1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7fb4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7fb6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7fb7, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7fb8, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7fb9, 1); pop(edx);                               /* pop edx */
            ii(0x1014_7fba, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7fbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7fbc, 1); ret();                                  /* ret */
        }
    }
}
