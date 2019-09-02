using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_af3b-fcd9171b")]
        public void Method_1013_af3b()
        {
            ii(0x1013_af3b, 5); push(0x38);                             /* push 0x38 */
            ii(0x1013_af40, 5); call(Definitions.sys_check_available_stack_size, 0x2_ae0d); /* call 0x10165d52 */
            ii(0x1013_af45, 1); push(ecx);                              /* push ecx */
            ii(0x1013_af46, 1); push(esi);                              /* push esi */
            ii(0x1013_af47, 1); push(edi);                              /* push edi */
            ii(0x1013_af48, 1); push(ebp);                              /* push ebp */
            ii(0x1013_af49, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_af4b, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1013_af51, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_af54, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1013_af57, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1013_af5a, 5); mov(eax, 0x16);                         /* mov eax, 0x16 */
            ii(0x1013_af5f, 5); call(Definitions.sys_new, 0x2_ae9c);    /* call 0x10165e00 */
            ii(0x1013_af64, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_af67, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_af6a, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_af6d, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_af71, 2); if(jz(0x1013_af8e, 0x1b)) goto l_0x1013_af8e; /* jz 0x1013af8e */
            ii(0x1013_af73, 4); movsx(ebx, memw[ss, ebp - 4]);          /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_af77, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1013_af7b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_af7e, 5); call(0x1013_ae58, -0x12b);              /* call 0x1013ae58 */
            ii(0x1013_af83, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_af86, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_af89, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_af8c, 2); jmp(0x1013_af94, 6); goto l_0x1013_af94; /* jmp 0x1013af94 */
        l_0x1013_af8e:
            ii(0x1013_af8e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_af91, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_af94:
            ii(0x1013_af94, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1013_af97, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_af9a, 5); call(0x1013_abc3, -0x3dc);              /* call 0x1013abc3 */
            ii(0x1013_af9f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_afa2, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1013_afa5, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_afa8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_afab, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_afae, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_afb1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_afb3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_afb4, 1); pop(edi);                               /* pop edi */
            ii(0x1013_afb5, 1); pop(esi);                               /* pop esi */
            ii(0x1013_afb6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_afb7, 1); ret();                                  /* ret */
        }
    }
}
