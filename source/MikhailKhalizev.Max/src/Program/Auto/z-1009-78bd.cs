using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_78bd-1665423c")]
        public void Method_1009_78bd()
        {
            ii(0x1009_78bd, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_78c2, 5); call(Definitions.sys_check_available_stack_size, 0xc_e48b); /* call 0x10165d52 */
            ii(0x1009_78c7, 1); push(esi);                              /* push esi */
            ii(0x1009_78c8, 1); push(edi);                              /* push edi */
            ii(0x1009_78c9, 1); push(ebp);                              /* push ebp */
            ii(0x1009_78ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_78cc, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_78d2, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_78d5, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_78d8, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_78db, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_78de, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_78e1, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_78e4, 2); jmp(0x1009_78ec, 0x6); goto l_0x1009_78ec; /* jmp 0x100978ec */
        l_0x1009_78e6:
            ii(0x1009_78e6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_78e9, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x1009_78ec:
            ii(0x1009_78ec, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_78ef, 4); cmp(ax, memw[ss, ebp + 0x10]);          /* cmp ax, [ebp+0x10] */
            ii(0x1009_78f3, 2); if(jge(0x1009_7925, 0x30)) goto l_0x1009_7925; /* jge 0x10097925 */
            ii(0x1009_78f5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_78f8, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_78fb, 2); jmp(0x1009_7903, 0x6); goto l_0x1009_7903; /* jmp 0x10097903 */
        l_0x1009_78fd:
            ii(0x1009_78fd, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_7900, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1009_7903:
            ii(0x1009_7903, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_7906, 4); cmp(ax, memw[ss, ebp + 0x14]);          /* cmp ax, [ebp+0x14] */
            ii(0x1009_790a, 2); if(jge(0x1009_7923, 0x17)) goto l_0x1009_7923; /* jge 0x10097923 */
            ii(0x1009_790c, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1009_7910, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7913, 3); add(eax, memd[ss, ebp - 0xc]);          /* add eax, [ebp-0xc] */
            ii(0x1009_7916, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1009_791a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_791c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_791e, 3); mov(memb[ds, eax], 0x2);                /* mov byte [eax], 0x2 */
            ii(0x1009_7921, 2); jmp(0x1009_78fd, -0x26); goto l_0x1009_78fd; /* jmp 0x100978fd */
        l_0x1009_7923:
            ii(0x1009_7923, 2); jmp(0x1009_78e6, -0x3f); goto l_0x1009_78e6; /* jmp 0x100978e6 */
        l_0x1009_7925:
            ii(0x1009_7925, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_7928, 1); push(eax);                              /* push eax */
            ii(0x1009_7929, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x1009_792d, 1); push(eax);                              /* push eax */
            ii(0x1009_792e, 4); movsx(ecx, memw[ss, ebp + 0x10]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1009_7932, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_7936, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1009_793a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_793d, 5); call(0x1009_4fea, -0x2958);             /* call 0x10094fea */
            ii(0x1009_7942, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_7944, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_7945, 1); pop(edi);                               /* pop edi */
            ii(0x1009_7946, 1); pop(esi);                               /* pop esi */
            ii(0x1009_7947, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
