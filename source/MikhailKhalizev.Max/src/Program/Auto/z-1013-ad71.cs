using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ad71-f7b20ec1")]
        public void Method_1013_ad71()
        {
            ii(0x1013_ad71, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1013_ad76, 5); call(Definitions.sys_check_available_stack_size, 0x2_afd7); /* call 0x10165d52 */
            ii(0x1013_ad7b, 1); push(ebx);                              /* push ebx */
            ii(0x1013_ad7c, 1); push(ecx);                              /* push ecx */
            ii(0x1013_ad7d, 1); push(esi);                              /* push esi */
            ii(0x1013_ad7e, 1); push(edi);                              /* push edi */
            ii(0x1013_ad7f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_ad80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ad82, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_ad88, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_ad8b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_ad8e, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_ad92, 2); if(jnz(0x1013_adae, 0x1a)) goto l_0x1013_adae; /* jnz 0x1013adae */
            ii(0x1013_ad94, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ad97, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1013_ad9a, 2); if(jz(0x1013_ada2, 6)) goto l_0x1013_ada2; /* jz 0x1013ada2 */
            ii(0x1013_ad9c, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1013_ada0, 2); jmp(0x1013_ada6, 4); goto l_0x1013_ada6; /* jmp 0x1013ada6 */
        l_0x1013_ada2:
            ii(0x1013_ada2, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1013_ada6:
            ii(0x1013_ada6, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1013_ada9, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1013_adac, 2); jmp(0x1013_adc6, 0x18); goto l_0x1013_adc6; /* jmp 0x1013adc6 */
        l_0x1013_adae:
            ii(0x1013_adae, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_adb1, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1013_adb4, 2); if(jnz(0x1013_adbc, 6)) goto l_0x1013_adbc; /* jnz 0x1013adbc */
            ii(0x1013_adb6, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1013_adba, 2); jmp(0x1013_adc0, 4); goto l_0x1013_adc0; /* jmp 0x1013adc0 */
        l_0x1013_adbc:
            ii(0x1013_adbc, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
        l_0x1013_adc0:
            ii(0x1013_adc0, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1013_adc3, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
        l_0x1013_adc6:
            ii(0x1013_adc6, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1013_adc9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_adcb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_adcc, 1); pop(edi);                               /* pop edi */
            ii(0x1013_adcd, 1); pop(esi);                               /* pop esi */
            ii(0x1013_adce, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_adcf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_add0, 1); ret();                                  /* ret */
        }
    }
}
