using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_af28-fbbdf36c")]
        public void Method_1008_af28()
        {
            ii(0x1008_af28, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_af2d, 5); call(Definitions.sys_check_available_stack_size, 0xd_ae20); /* call 0x10165d52 */
            ii(0x1008_af32, 1); push(ebx);                              /* push ebx */
            ii(0x1008_af33, 1); push(ecx);                              /* push ecx */
            ii(0x1008_af34, 1); push(edx);                              /* push edx */
            ii(0x1008_af35, 1); push(esi);                              /* push esi */
            ii(0x1008_af36, 1); push(edi);                              /* push edi */
            ii(0x1008_af37, 1); push(ebp);                              /* push ebp */
            ii(0x1008_af38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_af3a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_af40, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_af43, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_af46, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1008_af49, 2); if(jz(0x1008_af54, 9)) goto l_0x1008_af54; /* jz 0x1008af54 */
            ii(0x1008_af4b, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_af52, 2); jmp(0x1008_af6d, 0x19); goto l_0x1008_af6d; /* jmp 0x1008af6d */
        l_0x1008_af54:
            ii(0x1008_af54, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x1008_af59, 5); mov(ebx, StringDefinitions.SmartptrH5); /* mov ebx, 0x101a0080 */
            ii(0x1008_af5e, 5); mov(edx, StringDefinitions.PtrNotEqual05); /* mov edx, 0x101a008b */
            ii(0x1008_af63, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_af65, 5); call(Definitions.sys_assert, 0xd_ae28); /* call 0x10165d92 */
            ii(0x1008_af6a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1008_af6d:
            ii(0x1008_af6d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_af70, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_af72, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_af75, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_af78, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_af7a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_af7b, 1); pop(edi);                               /* pop edi */
            ii(0x1008_af7c, 1); pop(esi);                               /* pop esi */
            ii(0x1008_af7d, 1); pop(edx);                               /* pop edx */
            ii(0x1008_af7e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_af7f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_af80, 1); ret();                                  /* ret */
        }
    }
}
