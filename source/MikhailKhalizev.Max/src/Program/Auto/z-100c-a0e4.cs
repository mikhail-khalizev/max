using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a0e4-d362fbf7")]
        public void Method_100c_a0e4()
        {
            ii(0x100c_a0e4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a0e9, 5); call(Definitions.sys_check_available_stack_size, 0x9_bc64); /* call 0x10165d52 */
            ii(0x100c_a0ee, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a0ef, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a0f0, 1); push(esi);                              /* push esi */
            ii(0x100c_a0f1, 1); push(edi);                              /* push edi */
            ii(0x100c_a0f2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a0f3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a0f5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a0fb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a0fe, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a101, 5); mov(ebx, 0x101b_5724);                  /* mov ebx, 0x101b5724 */
            ii(0x100c_a106, 5); mov(edx, 0xa);                          /* mov edx, 0xa */
            ii(0x100c_a10b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a10e, 5); call(Definitions.sys_call_dtor_arr_v2, 0x9_becd); /* call 0x10165fe0 */
            ii(0x100c_a113, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a116, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_a119, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a11b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a11c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a11d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a11e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a11f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a120, 1); ret();                                  /* ret */
        }
    }
}
