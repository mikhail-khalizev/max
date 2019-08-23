using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ff84-ee3c9f6f")]
        public void Method_100a_ff84()
        {
            ii(0x100a_ff84, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_ff89, 5); call(Definitions.sys_check_available_stack_size, 0xb_5dc4); /* call 0x10165d52 */
            ii(0x100a_ff8e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ff8f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ff90, 1); push(esi);                              /* push esi */
            ii(0x100a_ff91, 1); push(edi);                              /* push edi */
            ii(0x100a_ff92, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ff93, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ff95, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_ff9b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ff9e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_ffa1, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_ffa4, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100a_ffa7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ffaa, 5); call(0x1007_6d98, -0x3_9217);           /* call 0x10076d98 */
            ii(0x100a_ffaf, 2); test(al, al);                           /* test al, al */
            ii(0x100a_ffb1, 2); if(jz(0x100a_ffc0, 0xd)) goto l_0x100a_ffc0; /* jz 0x100affc0 */
            ii(0x100a_ffb3, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100a_ffb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ffbb, 5); call(0x100a_d02d, -0x2f93);             /* call 0x100ad02d */
        l_0x100a_ffc0:
            ii(0x100a_ffc0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ffc2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ffc3, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ffc4, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ffc5, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ffc6, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ffc7, 1); ret();                                  /* ret */
        }
    }
}
