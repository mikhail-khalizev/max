using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d850-edbf23c0")]
        public void Method_100c_d850()
        {
            ii(0x100c_d850, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_d855, 5); call(Definitions.sys_check_available_stack_size, 0x9_84f8); /* call 0x10165d52 */
            ii(0x100c_d85a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_d85b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_d85c, 1); push(esi);                              /* push esi */
            ii(0x100c_d85d, 1); push(edi);                              /* push edi */
            ii(0x100c_d85e, 1); push(ebp);                              /* push ebp */
            ii(0x100c_d85f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d861, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_d867, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_d86a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_d86d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d870, 7); mov(memd[ds, eax + 0xc], 0x101b_5b7c);  /* mov dword [eax+0xc], 0x101b5b7c */
            ii(0x100c_d877, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d87a, 4); mov(dx, memw[ds, eax + 0x6]);           /* mov dx, [eax+0x6] */
            ii(0x100c_d87e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d881, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
            ii(0x100c_d885, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d888, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100c_d88b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d88e, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x100c_d891, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d894, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x100c_d898, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d89b, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
            ii(0x100c_d89f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d8a2, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x100c_d8a6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8a9, 4); mov(memw[ds, eax + 0x2], dx);           /* mov [eax+0x2], dx */
            ii(0x100c_d8ad, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8b0, 5); cmp(memw[ds, eax + 0x4], 0);            /* cmp word [eax+0x4], 0x0 */
            ii(0x100c_d8b5, 2); if(jnz(0x100c_d8c3, 0xc)) goto l_0x100c_d8c3; /* jnz 0x100cd8c3 */
            ii(0x100c_d8b7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8ba, 7); mov(memd[ds, eax + 0x8], 0);            /* mov dword [eax+0x8], 0x0 */
            ii(0x100c_d8c1, 2); jmp(0x100c_d905, 0x42); goto l_0x100c_d905; /* jmp 0x100cd905 */
        l_0x100c_d8c3:
            ii(0x100c_d8c3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8c6, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_d8c9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_d8cc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8cf, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_d8d2, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100c_d8d5, 5); call(Definitions.sys_new_arr, 0x9_8736); /* call 0x10166010 */
            ii(0x100c_d8da, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_d8dc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8df, 3); mov(memd[ds, eax + 0x8], ebx);          /* mov [eax+0x8], ebx */
            ii(0x100c_d8e2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8e5, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_d8e8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_d8eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8ee, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x100c_d8f1, 3); imul(ebx, edx);                         /* imul ebx, edx */
            ii(0x100c_d8f4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_d8f7, 3); mov(edx, memd[ds, eax + 0x8]);          /* mov edx, [eax+0x8] */
            ii(0x100c_d8fa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d8fd, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_d900, 5); call(Definitions.sys_memcpy, 0x9_8546); /* call 0x10165e4b */
        l_0x100c_d905:
            ii(0x100c_d905, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_d908, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_d90b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_d90e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d910, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_d911, 1); pop(edi);                               /* pop edi */
            ii(0x100c_d912, 1); pop(esi);                               /* pop esi */
            ii(0x100c_d913, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_d914, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_d915, 1); ret();                                  /* ret */
        }
    }
}
