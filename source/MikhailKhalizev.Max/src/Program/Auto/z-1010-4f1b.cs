using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4f1b-7349d0c5")]
        public void Method_1010_4f1b()
        {
            ii(0x1010_4f1b, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_4f20, 5); call(Definitions.sys_check_available_stack_size, 0x6_0e2d); /* call 0x10165d52 */
            ii(0x1010_4f25, 1); push(ebx);                              /* push ebx */
            ii(0x1010_4f26, 1); push(ecx);                              /* push ecx */
            ii(0x1010_4f27, 1); push(edx);                              /* push edx */
            ii(0x1010_4f28, 1); push(esi);                              /* push esi */
            ii(0x1010_4f29, 1); push(edi);                              /* push edi */
            ii(0x1010_4f2a, 1); push(ebp);                              /* push ebp */
            ii(0x1010_4f2b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4f2d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_4f33, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_4f36, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f39, 7); cmp(memd[ds, eax + 0x45d], 0);          /* cmp dword [eax+0x45d], 0x0 */
            ii(0x1010_4f40, 2); if(jg(0x1010_4f48, 6)) goto l_0x1010_4f48; /* jg 0x10104f48 */
            ii(0x1010_4f42, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_4f46, 2); jmp(0x1010_4fa0, 0x58); goto l_0x1010_4fa0; /* jmp 0x10104fa0 */
        l_0x1010_4f48:
            ii(0x1010_4f48, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f4b, 6); mov(eax, memd[ds, eax + 0x45d]);        /* mov eax, [eax+0x45d] */
            ii(0x1010_4f51, 1); inc(eax);                               /* inc eax */
            ii(0x1010_4f52, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_4f55, 7); cmp(memd[ss, ebp - 0xc], 0x3e8);        /* cmp dword [ebp-0xc], 0x3e8 */
            ii(0x1010_4f5c, 2); if(jle(0x1010_4f65, 7)) goto l_0x1010_4f65; /* jle 0x10104f65 */
            ii(0x1010_4f5e, 7); mov(memd[ss, ebp - 0xc], 0x3e8);        /* mov dword [ebp-0xc], 0x3e8 */
        l_0x1010_4f65:
            ii(0x1010_4f65, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f68, 6); mov(ebx, memd[ds, eax + 0x459]);        /* mov ebx, [eax+0x459] */
            ii(0x1010_4f6e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_4f71, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f74, 3); add(eax, 0x6f);                         /* add eax, 0x6f */
            ii(0x1010_4f77, 5); call(/* sys */ 0x1017_8fa7, 0x7_402b);  /* call 0x10178fa7 */
            ii(0x1010_4f7c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_4f7e, 2); if(jnz(0x1010_4f86, 6)) goto l_0x1010_4f86; /* jnz 0x10104f86 */
            ii(0x1010_4f80, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_4f84, 2); jmp(0x1010_4fa0, 0x1a); goto l_0x1010_4fa0; /* jmp 0x10104fa0 */
        l_0x1010_4f86:
            ii(0x1010_4f86, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f89, 3); add(eax, 0x6f);                         /* add eax, 0x6f */
            ii(0x1010_4f8c, 5); call(Definitions.sys_strlen, 0x6_cf36); /* call 0x10171ec7 */
            ii(0x1010_4f91, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_4f93, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_4f96, 6); sub(memd[ds, eax + 0x45d], edx);        /* sub [eax+0x45d], edx */
            ii(0x1010_4f9c, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
        l_0x1010_4fa0:
            ii(0x1010_4fa0, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1010_4fa3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_4fa5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_4fa6, 1); pop(edi);                               /* pop edi */
            ii(0x1010_4fa7, 1); pop(esi);                               /* pop esi */
            ii(0x1010_4fa8, 1); pop(edx);                               /* pop edx */
            ii(0x1010_4fa9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_4faa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_4fab, 1); ret();                                  /* ret */
        }
    }
}
