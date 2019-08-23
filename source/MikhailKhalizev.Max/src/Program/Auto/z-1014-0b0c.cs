using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_0b0c-cc9e6922")]
        public void Method_1014_0b0c()
        {
            ii(0x1014_0b0c, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_0b11, 5); call(Definitions.sys_check_available_stack_size, 0x2_523c); /* call 0x10165d52 */
            ii(0x1014_0b16, 1); push(ebx);                              /* push ebx */
            ii(0x1014_0b17, 1); push(ecx);                              /* push ecx */
            ii(0x1014_0b18, 1); push(esi);                              /* push esi */
            ii(0x1014_0b19, 1); push(edi);                              /* push edi */
            ii(0x1014_0b1a, 1); push(ebp);                              /* push ebp */
            ii(0x1014_0b1b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_0b1d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_0b23, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_0b26, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_0b29, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b2c, 4); mov(ax, memw[ds, eax + 0x26]);          /* mov ax, [eax+0x26] */
            ii(0x1014_0b30, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1014_0b34, 2); if(jle(0x1014_0b40, 0xa)) goto l_0x1014_0b40; /* jle 0x10140b40 */
            ii(0x1014_0b36, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_0b39, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_0b3c, 4); mov(memw[ds, edx + 0x26], ax);          /* mov [edx+0x26], ax */
        l_0x1014_0b40:
            ii(0x1014_0b40, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b43, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x1014_0b46, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0b49, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b4c, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1014_0b4f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0b52, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_0b54, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_0b58, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_0b5a, 2); if(jg(0x1014_0b6e, 0x12)) goto l_0x1014_0b6e; /* jg 0x10140b6e */
            ii(0x1014_0b5c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b5f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_0b62, 4); sub(dx, memw[ds, eax + 0x2a]);          /* sub dx, [eax+0x2a] */
            ii(0x1014_0b66, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b69, 1); inc(edx);                               /* inc edx */
            ii(0x1014_0b6a, 4); mov(memw[ds, eax + 0x26], dx);          /* mov [eax+0x26], dx */
        l_0x1014_0b6e:
            ii(0x1014_0b6e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b71, 3); mov(edx, memd[ds, eax + 0x24]);         /* mov edx, [eax+0x24] */
            ii(0x1014_0b74, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0b77, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b7a, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1014_0b7d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0b80, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_0b82, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b85, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0b88, 5); call(Definitions.my_1_get_count, -0x9_56b5); /* call 0x100ab4d8 */
            ii(0x1014_0b8d, 1); cwde();                                 /* cwde */
            ii(0x1014_0b8e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1014_0b90, 2); if(jle(0x1014_0baf, 0x1d)) goto l_0x1014_0baf; /* jle 0x10140baf */
            ii(0x1014_0b92, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0b95, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_0b98, 5); call(Definitions.my_1_get_count, -0x9_56c5); /* call 0x100ab4d8 */
            ii(0x1014_0b9d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0b9f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0ba2, 4); mov(bx, memw[ds, eax + 0x2a]);          /* mov bx, [eax+0x2a] */
            ii(0x1014_0ba6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0ba9, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1014_0bab, 4); mov(memw[ds, eax + 0x26], dx);          /* mov [eax+0x26], dx */
        l_0x1014_0baf:
            ii(0x1014_0baf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0bb2, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1014_0bb5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0bb8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_0bba, 2); if(jge(0x1014_0bc5, 0x9)) goto l_0x1014_0bc5; /* jge 0x10140bc5 */
            ii(0x1014_0bbc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0bbf, 6); mov(memw[ds, eax + 0x26], 0);           /* mov word [eax+0x26], 0x0 */
        l_0x1014_0bc5:
            ii(0x1014_0bc5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_0bc7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_0bc8, 1); pop(edi);                               /* pop edi */
            ii(0x1014_0bc9, 1); pop(esi);                               /* pop esi */
            ii(0x1014_0bca, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_0bcb, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_0bcc, 1); ret();                                  /* ret */
        }
    }
}
