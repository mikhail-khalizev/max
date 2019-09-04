using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0760-d7cb2cdc")]
        public void Method_100e_0760()
        {
            ii(0x100e_0760, 5); push(0x28);                             /* push 0x28 */
            ii(0x100e_0765, 5); call(Definitions.sys_check_available_stack_size, 0x8_55e8); /* call 0x10165d52 */
            ii(0x100e_076a, 1); push(ebx);                              /* push ebx */
            ii(0x100e_076b, 1); push(ecx);                              /* push ecx */
            ii(0x100e_076c, 1); push(edx);                              /* push edx */
            ii(0x100e_076d, 1); push(esi);                              /* push esi */
            ii(0x100e_076e, 1); push(edi);                              /* push edi */
            ii(0x100e_076f, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0770, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0772, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0778, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_077b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_077e, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100e_0781, 2); if(jz(0x100e_078c, 9)) goto l_0x100e_078c; /* jz 0x100e078c */
            ii(0x100e_0783, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_078a, 2); jmp(0x100e_07a5, 0x19); goto l_0x100e_07a5; /* jmp 0x100e07a5 */
        l_0x100e_078c:
            ii(0x100e_078c, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100e_0791, 5); mov(ebx, StringDefinitions.SmartptrH14); /* mov ebx, 0x101a17b0 */
            ii(0x100e_0796, 5); mov(edx, StringDefinitions.PtrNotEqual014); /* mov edx, 0x101a17bb */
            ii(0x100e_079b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_079d, 5); call(Definitions.sys_assert, 0x8_55f0); /* call 0x10165d92 */
            ii(0x100e_07a2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100e_07a5:
            ii(0x100e_07a5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_07a8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_07aa, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_07ad, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_07b0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_07b2, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_07b3, 1); pop(edi);                               /* pop edi */
            ii(0x100e_07b4, 1); pop(esi);                               /* pop esi */
            ii(0x100e_07b5, 1); pop(edx);                               /* pop edx */
            ii(0x100e_07b6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_07b7, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_07b8, 1); ret();                                  /* ret */
        }
    }
}
