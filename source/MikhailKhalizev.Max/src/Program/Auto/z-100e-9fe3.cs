using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9fe3-43a40231")]
        public void Method_100e_9fe3()
        {
            ii(0x100e_9fe3, 5); push(0x30);                             /* push 0x30 */
            ii(0x100e_9fe8, 5); call(Definitions.sys_check_available_stack_size, 0x7_bd65); /* call 0x10165d52 */
            ii(0x100e_9fed, 1); push(ebx);                              /* push ebx */
            ii(0x100e_9fee, 1); push(ecx);                              /* push ecx */
            ii(0x100e_9fef, 1); push(esi);                              /* push esi */
            ii(0x100e_9ff0, 1); push(edi);                              /* push edi */
            ii(0x100e_9ff1, 1); push(ebp);                              /* push ebp */
            ii(0x100e_9ff2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9ff4, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_9ffa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_9ffd, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_a000, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a003, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x100e_a007, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_a00a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a00d, 4); movsx(ax, memb[ds, eax]);               /* movsx ax, byte [eax] */
            ii(0x100e_a011, 3); sub(memd[ss, ebp - 0x14], eax);         /* sub [ebp-0x14], eax */
            ii(0x100e_a014, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a017, 5); movsx(ax, memb[ds, eax + 0x1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x100e_a01c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_a01f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a022, 5); movsx(ax, memb[ds, eax + 0x1]);         /* movsx ax, byte [eax+0x1] */
            ii(0x100e_a027, 3); sub(memd[ss, ebp - 0xc], eax);          /* sub [ebp-0xc], eax */
            ii(0x100e_a02a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_a02d, 5); movsx(ax, memb[ds, eax + 0x2]);         /* movsx ax, byte [eax+0x2] */
            ii(0x100e_a032, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_a035, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_a038, 5); movsx(ax, memb[ds, eax + 0x2]);         /* movsx ax, byte [eax+0x2] */
            ii(0x100e_a03d, 3); sub(memd[ss, ebp - 0x10], eax);         /* sub [ebp-0x10], eax */
            ii(0x100e_a040, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x100e_a043, 4); imul(edx, memd[ss, ebp - 0x14]);        /* imul edx, [ebp-0x14] */
            ii(0x100e_a047, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_a04a, 4); imul(eax, memd[ss, ebp - 0xc]);         /* imul eax, [ebp-0xc] */
            ii(0x100e_a04e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a050, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_a053, 4); imul(eax, memd[ss, ebp - 0x10]);        /* imul eax, [ebp-0x10] */
            ii(0x100e_a057, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_a059, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x100e_a05c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100e_a05f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_a061, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_a062, 1); pop(edi);                               /* pop edi */
            ii(0x100e_a063, 1); pop(esi);                               /* pop esi */
            ii(0x100e_a064, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_a065, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_a066, 1); ret();                                  /* ret */
        }
    }
}
