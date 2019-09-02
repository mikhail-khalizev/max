using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_5d15-2d4f360")]
        public void Method_1010_5d15()
        {
            ii(0x1010_5d15, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_5d1a, 5); call(Definitions.sys_check_available_stack_size, 0x6_0033); /* call 0x10165d52 */
            ii(0x1010_5d1f, 1); push(ebx);                              /* push ebx */
            ii(0x1010_5d20, 1); push(ecx);                              /* push ecx */
            ii(0x1010_5d21, 1); push(edx);                              /* push edx */
            ii(0x1010_5d22, 1); push(esi);                              /* push esi */
            ii(0x1010_5d23, 1); push(edi);                              /* push edi */
            ii(0x1010_5d24, 1); push(ebp);                              /* push ebp */
            ii(0x1010_5d25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5d27, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_5d2d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_5d30, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_5d33, 10); mov(memd[ds, eax + 132], 0);           /* mov dword [eax+0x84], 0x0 */
            ii(0x1010_5d3d, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_5d44, 2); jmp(0x1010_5d4c, 6); goto l_0x1010_5d4c; /* jmp 0x10105d4c */
        l_0x1010_5d46:
            ii(0x1010_5d46, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_5d49, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x1010_5d4c:
            ii(0x1010_5d4c, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5d50, 3); cmp(eax, 0x76);                         /* cmp eax, 0x76 */
            ii(0x1010_5d53, 2); if(jge(0x1010_5d6b, 0x16)) goto l_0x1010_5d6b; /* jge 0x10105d6b */
            ii(0x1010_5d55, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_5d59, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_5d5c, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_5d5f, 10); mov(memd[ds, eax + 172], 0);           /* mov dword [eax+0xac], 0x0 */
            ii(0x1010_5d69, 2); jmp(0x1010_5d46, -0x25); goto l_0x1010_5d46; /* jmp 0x10105d46 */
        l_0x1010_5d6b:
            ii(0x1010_5d6b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_5d6e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_5d71, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_5d74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_5d76, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_5d77, 1); pop(edi);                               /* pop edi */
            ii(0x1010_5d78, 1); pop(esi);                               /* pop esi */
            ii(0x1010_5d79, 1); pop(edx);                               /* pop edx */
            ii(0x1010_5d7a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_5d7b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_5d7c, 1); ret();                                  /* ret */
        }
    }
}
