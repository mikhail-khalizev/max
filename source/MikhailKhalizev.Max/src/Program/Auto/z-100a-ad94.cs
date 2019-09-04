using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ad94-4843062c")]
        public void Method_100a_ad94()
        {
            ii(0x100a_ad94, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_ad99, 5); call(Definitions.sys_check_available_stack_size, 0xb_afb4); /* call 0x10165d52 */
            ii(0x100a_ad9e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ad9f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ada0, 1); push(edx);                              /* push edx */
            ii(0x100a_ada1, 1); push(esi);                              /* push esi */
            ii(0x100a_ada2, 1); push(edi);                              /* push edi */
            ii(0x100a_ada3, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ada4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ada6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_adac, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_adaf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_adb2, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100a_adb5, 2); if(jz(0x100a_adc0, 9)) goto l_0x100a_adc0; /* jz 0x100aadc0 */
            ii(0x100a_adb7, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100a_adbe, 2); jmp(0x100a_add9, 0x19); goto l_0x100a_add9; /* jmp 0x100aadd9 */
        l_0x100a_adc0:
            ii(0x100a_adc0, 5); mov(ecx, 0xae);                         /* mov ecx, 0xae */
            ii(0x100a_adc5, 5); mov(ebx, StringDefinitions.SmartptrH9); /* mov ebx, 0x101a0850 */
            ii(0x100a_adca, 5); mov(edx, StringDefinitions.PtrNotEqual09); /* mov edx, 0x101a085b */
            ii(0x100a_adcf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_add1, 5); call(Definitions.sys_assert, 0xb_afbc); /* call 0x10165d92 */
            ii(0x100a_add6, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100a_add9:
            ii(0x100a_add9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_addc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100a_adde, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_ade1, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_ade4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ade6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ade7, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ade8, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ade9, 1); pop(edx);                               /* pop edx */
            ii(0x100a_adea, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_adeb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_adec, 1); ret();                                  /* ret */
        }
    }
}
