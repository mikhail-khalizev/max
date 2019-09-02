using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_61bb-12ff3d74")]
        public void Method_1010_61bb()
        {
            ii(0x1010_61bb, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_61c0, 5); call(Definitions.sys_check_available_stack_size, 0x5_fb8d); /* call 0x10165d52 */
            ii(0x1010_61c5, 1); push(ebx);                              /* push ebx */
            ii(0x1010_61c6, 1); push(ecx);                              /* push ecx */
            ii(0x1010_61c7, 1); push(esi);                              /* push esi */
            ii(0x1010_61c8, 1); push(edi);                              /* push edi */
            ii(0x1010_61c9, 1); push(ebp);                              /* push ebp */
            ii(0x1010_61ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_61cc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_61d2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_61d5, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1010_61d8, 4); cmp(memb[ss, ebp - 4], 0x76);           /* cmp byte [ebp-0x4], 0x76 */
            ii(0x1010_61dc, 2); if(jge(0x1010_61f3, 0x15)) goto l_0x1010_61f3; /* jge 0x101061f3 */
            ii(0x1010_61de, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_61e2, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_61e5, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_61e8, 6); mov(eax, memd[ds, eax + 172]);          /* mov eax, [eax+0xac] */
            ii(0x1010_61ee, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_61f1, 2); jmp(0x1010_61fa, 7); goto l_0x1010_61fa; /* jmp 0x101061fa */
        l_0x1010_61f3:
            ii(0x1010_61f3, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_61fa:
            ii(0x1010_61fa, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_61fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_61ff, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_6200, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6201, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6202, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_6203, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_6204, 1); ret();                                  /* ret */
        }
    }
}
