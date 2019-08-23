using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fd07-49a0c628")]
        public void Method_100c_fd07()
        {
            ii(0x100c_fd07, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_fd0c, 5); call(Definitions.sys_check_available_stack_size, 0x9_6041); /* call 0x10165d52 */
            ii(0x100c_fd11, 1); push(ebx);                              /* push ebx */
            ii(0x100c_fd12, 1); push(ecx);                              /* push ecx */
            ii(0x100c_fd13, 1); push(esi);                              /* push esi */
            ii(0x100c_fd14, 1); push(edi);                              /* push edi */
            ii(0x100c_fd15, 1); push(ebp);                              /* push ebp */
            ii(0x100c_fd16, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fd18, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_fd1e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_fd21, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_fd24, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fd27, 5); call(Definitions.my_2_get_count, -0x4_49c4); /* call 0x1008b368 */
            ii(0x100c_fd2c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_fd2f, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_fd33, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fd36, 5); call(0x1013_c0fa, 0x6_c3bf);            /* call 0x1013c0fa */
            ii(0x100c_fd3b, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_fd42, 2); jmp(0x100c_fd4a, 0x6); goto l_0x100c_fd4a; /* jmp 0x100cfd4a */
        l_0x100c_fd44:
            ii(0x100c_fd44, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_fd47, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100c_fd4a:
            ii(0x100c_fd4a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fd4d, 5); call(Definitions.my_2_get_count, -0x4_49ea); /* call 0x1008b368 */
            ii(0x100c_fd52, 4); cmp(ax, memw[ss, ebp - 0x10]);          /* cmp ax, [ebp-0x10] */
            ii(0x100c_fd56, 2); if(jle(0x100c_fd7c, 0x24)) goto l_0x100c_fd7c; /* jle 0x100cfd7c */
            ii(0x100c_fd58, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100c_fd5c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fd5f, 5); call(0x1008_b228, -0x4_4b3c);           /* call 0x1008b228 */
            ii(0x100c_fd64, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100c_fd67, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_fd6a, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100c_fd6f, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100c_fd72, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fd75, 5); call(0x1013_c055, 0x6_c2db);            /* call 0x1013c055 */
            ii(0x100c_fd7a, 2); jmp(0x100c_fd44, -0x38); goto l_0x100c_fd44; /* jmp 0x100cfd44 */
        l_0x100c_fd7c:
            ii(0x100c_fd7c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fd7e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_fd7f, 1); pop(edi);                               /* pop edi */
            ii(0x100c_fd80, 1); pop(esi);                               /* pop esi */
            ii(0x100c_fd81, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_fd82, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_fd83, 1); ret();                                  /* ret */
        }
    }
}
