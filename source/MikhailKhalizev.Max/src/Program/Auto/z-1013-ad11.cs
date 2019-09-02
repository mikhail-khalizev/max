using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ad11-85d4e43f")]
        public void Method_1013_ad11()
        {
            ii(0x1013_ad11, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1013_ad16, 5); call(Definitions.sys_check_available_stack_size, 0x2_b037); /* call 0x10165d52 */
            ii(0x1013_ad1b, 1); push(ebx);                              /* push ebx */
            ii(0x1013_ad1c, 1); push(ecx);                              /* push ecx */
            ii(0x1013_ad1d, 1); push(esi);                              /* push esi */
            ii(0x1013_ad1e, 1); push(edi);                              /* push edi */
            ii(0x1013_ad1f, 1); push(ebp);                              /* push ebp */
            ii(0x1013_ad20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ad22, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1013_ad28, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_ad2b, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_ad2e, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_ad32, 2); if(jz(0x1013_ad4e, 0x1a)) goto l_0x1013_ad4e; /* jz 0x1013ad4e */
            ii(0x1013_ad34, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ad37, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1013_ad3a, 2); if(jz(0x1013_ad42, 6)) goto l_0x1013_ad42; /* jz 0x1013ad42 */
            ii(0x1013_ad3c, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1013_ad40, 2); jmp(0x1013_ad46, 4); goto l_0x1013_ad46; /* jmp 0x1013ad46 */
        l_0x1013_ad42:
            ii(0x1013_ad42, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
        l_0x1013_ad46:
            ii(0x1013_ad46, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1013_ad49, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1013_ad4c, 2); jmp(0x1013_ad66, 0x18); goto l_0x1013_ad66; /* jmp 0x1013ad66 */
        l_0x1013_ad4e:
            ii(0x1013_ad4e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ad51, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x1013_ad54, 2); if(jnz(0x1013_ad5c, 6)) goto l_0x1013_ad5c; /* jnz 0x1013ad5c */
            ii(0x1013_ad56, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1013_ad5a, 2); jmp(0x1013_ad60, 4); goto l_0x1013_ad60; /* jmp 0x1013ad60 */
        l_0x1013_ad5c:
            ii(0x1013_ad5c, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
        l_0x1013_ad60:
            ii(0x1013_ad60, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1013_ad63, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
        l_0x1013_ad66:
            ii(0x1013_ad66, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1013_ad69, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ad6b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ad6c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ad6d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ad6e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ad6f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ad70, 1); ret();                                  /* ret */
        }
    }
}
