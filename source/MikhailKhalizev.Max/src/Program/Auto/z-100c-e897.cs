using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e897-30bace7b")]
        public void Method_100c_e897()
        {
            ii(0x100c_e897, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_e89c, 5); call(Definitions.sys_check_available_stack_size, 0x9_74b1); /* call 0x10165d52 */
            ii(0x100c_e8a1, 1); push(ebx);                              /* push ebx */
            ii(0x100c_e8a2, 1); push(ecx);                              /* push ecx */
            ii(0x100c_e8a3, 1); push(edx);                              /* push edx */
            ii(0x100c_e8a4, 1); push(esi);                              /* push esi */
            ii(0x100c_e8a5, 1); push(edi);                              /* push edi */
            ii(0x100c_e8a6, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e8a7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e8a9, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_e8af, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_e8b2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e8b5, 4); cmp(memd[ds, eax + 0x14], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_e8b9, 2); if(jnz(0x100c_e8c8, 0xd)) goto l_0x100c_e8c8; /* jnz 0x100ce8c8 */
            ii(0x100c_e8bb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e8be, 5); call(0x100c_e809, -0xba);               /* call 0x100ce809 */
            ii(0x100c_e8c3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_e8c6, 2); jmp(0x100c_e8d6, 0xe); goto l_0x100c_e8d6; /* jmp 0x100ce8d6 */
        l_0x100c_e8c8:
            ii(0x100c_e8c8, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_e8cb, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x100c_e8ce, 5); call(0x100d_4e8c, 0x65b9);              /* call 0x100d4e8c */
            ii(0x100c_e8d3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x100c_e8d6:
            ii(0x100c_e8d6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_e8d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e8db, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e8dc, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e8dd, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e8de, 1); pop(edx);                               /* pop edx */
            ii(0x100c_e8df, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_e8e0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_e8e1, 1); ret();                                  /* ret */
        }
    }
}
