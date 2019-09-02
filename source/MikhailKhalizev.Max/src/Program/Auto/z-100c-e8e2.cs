using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e8e2-f5bfc2ff")]
        public void Method_100c_e8e2()
        {
            ii(0x100c_e8e2, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_e8e7, 5); call(Definitions.sys_check_available_stack_size, 0x9_7466); /* call 0x10165d52 */
            ii(0x100c_e8ec, 1); push(ebx);                              /* push ebx */
            ii(0x100c_e8ed, 1); push(ecx);                              /* push ecx */
            ii(0x100c_e8ee, 1); push(edx);                              /* push edx */
            ii(0x100c_e8ef, 1); push(esi);                              /* push esi */
            ii(0x100c_e8f0, 1); push(edi);                              /* push edi */
            ii(0x100c_e8f1, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e8f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e8f4, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_e8fa, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_e8fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e900, 4); cmp(memd[ds, eax + 24], 0);             /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_e904, 2); if(jnz(0x100c_e913, 0xd)) goto l_0x100c_e913; /* jnz 0x100ce913 */
            ii(0x100c_e906, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e909, 5); call(0x100c_e850, -0xbe);               /* call 0x100ce850 */
            ii(0x100c_e90e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_e911, 2); jmp(0x100c_e921, 0xe); goto l_0x100c_e921; /* jmp 0x100ce921 */
        l_0x100c_e913:
            ii(0x100c_e913, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e916, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x100c_e919, 5); call(0x100d_4e8c, 0x656e);              /* call 0x100d4e8c */
            ii(0x100c_e91e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100c_e921:
            ii(0x100c_e921, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e924, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e926, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e927, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e928, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e929, 1); pop(edx);                               /* pop edx */
            ii(0x100c_e92a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_e92b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_e92c, 1); ret();                                  /* ret */
        }
    }
}
