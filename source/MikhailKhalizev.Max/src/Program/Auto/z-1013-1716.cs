using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1716-f7c556")]
        public void Method_1013_1716()
        {
            ii(0x1013_1716, 5); push(0x30);                             /* push 0x30 */
            ii(0x1013_171b, 5); call(Definitions.sys_check_available_stack_size, 0x3_4632); /* call 0x10165d52 */
            ii(0x1013_1720, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1721, 1); push(esi);                              /* push esi */
            ii(0x1013_1722, 1); push(edi);                              /* push edi */
            ii(0x1013_1723, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1724, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1726, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_172c, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_172f, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1013_1732, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1013_1735, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1738, 5); call(0x1013_aaa8, 0x936b);              /* call 0x1013aaa8 */
            ii(0x1013_173d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_1740, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1013_1743, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1013_1746, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1749, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1013_174c, 5); call(0x1013_1c74, 0x523);               /* call 0x10131c74 */
            ii(0x1013_1751, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1013_1754, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_1757, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1013_175a, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1013_175d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1760, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_1763, 5); call(Definitions.my_string_ctor, 0x1_0380); /* call 0x10141ae8 */
            ii(0x1013_1768, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1013_176b, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_176e, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1013_1771, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1013_1774, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1777, 7); mov(memd[ds, eax + 2], 0x101b_6bd4);    /* mov dword [eax+0x2], 0x101b6bd4 */
            ii(0x1013_177e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_1781, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1784, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_1787, 5); call(0x1014_2246, 0x1_0aba);            /* call 0x10142246 */
            ii(0x1013_178c, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1013_178f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_1792, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1013_1795, 5); call(0x1013_1c3c, 0x4a2);               /* call 0x10131c3c */
            ii(0x1013_179a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_179d, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1013_17a0, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1013_17a3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_17a5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_17a6, 1); pop(edi);                               /* pop edi */
            ii(0x1013_17a7, 1); pop(esi);                               /* pop esi */
            ii(0x1013_17a8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_17a9, 1); ret();                                  /* ret */
        }
    }
}
