using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_9c2f-33e30a4c")]
        public void Method_1014_9c2f()
        {
            ii(0x1014_9c2f, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_9c34, 5); call(Definitions.sys_check_available_stack_size, 0x1_c119); /* call 0x10165d52 */
            ii(0x1014_9c39, 1); push(ecx);                              /* push ecx */
            ii(0x1014_9c3a, 1); push(esi);                              /* push esi */
            ii(0x1014_9c3b, 1); push(edi);                              /* push edi */
            ii(0x1014_9c3c, 1); push(ebp);                              /* push ebp */
            ii(0x1014_9c3d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9c3f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_9c45, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_9c48, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1014_9c4b, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1014_9c4e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_9c51, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_9c54, 4); add(memw[ds, edx + 0x16], ax);          /* add [edx+0x16], ax */
            ii(0x1014_9c58, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9c5c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9c5f, 6); add(memd[ds, eax + 0xb5], edx);         /* add [eax+0xb5], edx */
            ii(0x1014_9c65, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9c69, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9c6c, 6); add(memd[ds, eax + 0xbd], edx);         /* add [eax+0xbd], edx */
            ii(0x1014_9c72, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9c76, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9c79, 6); add(memd[ds, eax + 0xc5], edx);         /* add [eax+0xc5], edx */
            ii(0x1014_9c7f, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1014_9c83, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9c86, 6); add(memd[ds, eax + 0xcd], edx);         /* add [eax+0xcd], edx */
            ii(0x1014_9c8c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_9c8f, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1014_9c92, 4); add(memw[ds, edx + 0x18], ax);          /* add [edx+0x18], ax */
            ii(0x1014_9c96, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_9c9a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9c9d, 6); add(memd[ds, eax + 0xb9], edx);         /* add [eax+0xb9], edx */
            ii(0x1014_9ca3, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_9ca7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9caa, 6); add(memd[ds, eax + 0xc1], edx);         /* add [eax+0xc1], edx */
            ii(0x1014_9cb0, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_9cb4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9cb7, 6); add(memd[ds, eax + 0xc9], edx);         /* add [eax+0xc9], edx */
            ii(0x1014_9cbd, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_9cc1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_9cc4, 6); add(memd[ds, eax + 0xd1], edx);         /* add [eax+0xd1], edx */
            ii(0x1014_9cca, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9ccc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_9ccd, 1); pop(edi);                               /* pop edi */
            ii(0x1014_9cce, 1); pop(esi);                               /* pop esi */
            ii(0x1014_9ccf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_9cd0, 1); ret();                                  /* ret */
        }
    }
}
