using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9f72-a4f7cd71")]
        public void Method_1009_9f72()
        {
            ii(0x1009_9f72, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_9f77, 5); call(Definitions.sys_check_available_stack_size, 0xc_bdd6); /* call 0x10165d52 */
            ii(0x1009_9f7c, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9f7d, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9f7e, 1); push(edx);                              /* push edx */
            ii(0x1009_9f7f, 1); push(esi);                              /* push esi */
            ii(0x1009_9f80, 1); push(edi);                              /* push edi */
            ii(0x1009_9f81, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9f82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9f84, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1009_9f8a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_9f8d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9f8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9f92, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9f95, 5); call(0x1009_c44c, 0x24b2);              /* call 0x1009c44c */
            ii(0x1009_9f9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9f9c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9f9f, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_9fa2, 5); call(0x1008_afe4, -0xefc3);             /* call 0x1008afe4 */
            ii(0x1009_9fa7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_9faa, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_9faf, 5); call(0x100a_5e27, 0xbe73);              /* call 0x100a5e27 */
            ii(0x1009_9fb4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9fb6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9fb7, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9fb8, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9fb9, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9fba, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9fbb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9fbc, 1); ret();                                  /* ret */
        }
    }
}
