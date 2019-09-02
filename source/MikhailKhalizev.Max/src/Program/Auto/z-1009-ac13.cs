using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ac13-df0c515d")]
        public void Method_1009_ac13()
        {
            ii(0x1009_ac13, 5); push(0x34);                             /* push 0x34 */
            ii(0x1009_ac18, 5); call(Definitions.sys_check_available_stack_size, 0xc_b135); /* call 0x10165d52 */
            ii(0x1009_ac1d, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ac1e, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ac1f, 1); push(esi);                              /* push esi */
            ii(0x1009_ac20, 1); push(edi);                              /* push edi */
            ii(0x1009_ac21, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ac22, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ac24, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ac2a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ac2d, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_ac30, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_ac32, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ac35, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ac38, 5); call(0x1013_ad11, 0xa_00d4);            /* call 0x1013ad11 */
            ii(0x1009_ac3d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_ac3f, 2); if(jz(0x1009_ac50, 0xf)) goto l_0x1009_ac50; /* jz 0x1009ac50 */
            ii(0x1009_ac41, 5); mov(edx, StringDefinitions.CompletedMineRemoval); /* mov edx, 0x101a06f9 */
            ii(0x1009_ac46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ac49, 5); call(Definitions.sys_strcpy, 0xc_b281); /* call 0x10165ecf */
            ii(0x1009_ac4e, 2); jmp(0x1009_ac88, 0x38); goto l_0x1009_ac88; /* jmp 0x1009ac88 */
        l_0x1009_ac50:
            ii(0x1009_ac50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ac53, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ac56, 5); call(0x1007_6574, -0x2_46e7);           /* call 0x10076574 */
            ii(0x1009_ac5b, 3); mov(eax, memd[ds, eax + 0x1a]);         /* mov eax, [eax+0x1a] */
            ii(0x1009_ac5e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ac61, 1); inc(eax);                               /* inc eax */
            ii(0x1009_ac62, 1); push(eax);                              /* push eax */
            ii(0x1009_ac63, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ac66, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ac69, 5); call(0x1007_6574, -0x2_46fa);           /* call 0x10076574 */
            ii(0x1009_ac6e, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1009_ac71, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ac74, 1); inc(eax);                               /* inc eax */
            ii(0x1009_ac75, 1); push(eax);                              /* push eax */
            ii(0x1009_ac76, 5); mov(eax, StringDefinitions.RemoveMineFromII); /* mov eax, 0x101a0710 */
            ii(0x1009_ac7b, 1); push(eax);                              /* push eax */
            ii(0x1009_ac7c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ac7f, 1); push(eax);                              /* push eax */
            ii(0x1009_ac80, 5); call(Definitions.sys_sprintf, 0xc_b27c); /* call 0x10165f01 */
            ii(0x1009_ac85, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1009_ac88:
            ii(0x1009_ac88, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ac8b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_ac8e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_ac91, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ac93, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_ac94, 1); pop(edi);                               /* pop edi */
            ii(0x1009_ac95, 1); pop(esi);                               /* pop esi */
            ii(0x1009_ac96, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_ac97, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_ac98, 1); ret();                                  /* ret */
        }
    }
}
