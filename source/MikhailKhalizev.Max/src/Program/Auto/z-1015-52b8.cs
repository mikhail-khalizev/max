using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_52b8-fe1880f3")]
        public void Method_1015_52b8()
        {
            ii(0x1015_52b8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_52bd, 5); call(Definitions.sys_check_available_stack_size, 0x1_0a90); /* call 0x10165d52 */
            ii(0x1015_52c2, 1); push(ebx);                              /* push ebx */
            ii(0x1015_52c3, 1); push(ecx);                              /* push ecx */
            ii(0x1015_52c4, 1); push(edx);                              /* push edx */
            ii(0x1015_52c5, 1); push(esi);                              /* push esi */
            ii(0x1015_52c6, 1); push(edi);                              /* push edi */
            ii(0x1015_52c7, 1); push(ebp);                              /* push ebp */
            ii(0x1015_52c8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_52ca, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_52d0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_52d3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_52d6, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1015_52d9, 2); if(jz(0x1015_52e4, 9)) goto l_0x1015_52e4; /* jz 0x101552e4 */
            ii(0x1015_52db, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1015_52e2, 2); jmp(0x1015_52fd, 0x19); goto l_0x1015_52fd; /* jmp 0x101552fd */
        l_0x1015_52e4:
            ii(0x1015_52e4, 5); mov(ecx, 0xa7);                         /* mov ecx, 0xa7 */
            ii(0x1015_52e9, 5); mov(ebx, StringDefinitions.SmartptrH23); /* mov ebx, 0x101ad1b9 */
            ii(0x1015_52ee, 5); mov(edx, StringDefinitions.PtrNotEqual025); /* mov edx, 0x101ad1c4 */
            ii(0x1015_52f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_52f5, 5); call(Definitions.sys_assert, 0x1_0a98); /* call 0x10165d92 */
            ii(0x1015_52fa, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1015_52fd:
            ii(0x1015_52fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_5300, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1015_5302, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_5305, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_5308, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_530a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_530b, 1); pop(edi);                               /* pop edi */
            ii(0x1015_530c, 1); pop(esi);                               /* pop esi */
            ii(0x1015_530d, 1); pop(edx);                               /* pop edx */
            ii(0x1015_530e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_530f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_5310, 1); ret();                                  /* ret */
        }
    }
}
