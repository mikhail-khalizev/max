using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_1544-3017f9cf")]
        public void Method_100e_1544()
        {
            ii(0x100e_1544, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100e_1549, 5);  call(Definitions.sys_check_available_stack_size, 0x8_4804);/* call 0x10165d52 */
            ii(0x100e_154e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_154f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_1550, 1);  push(edx);                            /* push edx */
            ii(0x100e_1551, 1);  push(esi);                            /* push esi */
            ii(0x100e_1552, 1);  push(edi);                            /* push edi */
            ii(0x100e_1553, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_1554, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_1556, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_155c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_155f, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100e_1562, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_1565, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100e_1567, 5);  call(0x100d_6a11, -0xab5b);           /* call 0x100d6a11 */
            ii(0x100e_156c, 3);  mov(edx, memd[ss, ebp - 14]);         /* mov edx, [ebp-0xe] */
            ii(0x100e_156f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_1572, 3);  mov(eax, memd[ds, eax + 16]);         /* mov eax, [eax+0x10] */
            ii(0x100e_1575, 5);  call(0x100c_f85c, -0x1_1d1e);         /* call 0x100cf85c */
            ii(0x100e_157a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_157d, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100e_1581, 2);  if(jz(0x100e_15ad, 0x2a)) goto l_0x100e_15ad;/* jz 0x100e15ad */
            ii(0x100e_1583, 3);  mov(edx, memd[ss, ebp - 14]);         /* mov edx, [ebp-0xe] */
            ii(0x100e_1586, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_1589, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100e_158c, 5);  call(0x100c_f85c, -0x1_1d35);         /* call 0x100cf85c */
            ii(0x100e_1591, 3);  mov(edx, memd[ss, ebp - 14]);         /* mov edx, [ebp-0xe] */
            ii(0x100e_1594, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_1597, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x100e_159a, 5);  call(0x100c_f85c, -0x1_1d43);         /* call 0x100cf85c */
            ii(0x100e_159f, 3);  mov(edx, memd[ss, ebp - 14]);         /* mov edx, [ebp-0xe] */
            ii(0x100e_15a2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_15a5, 3);  mov(eax, memd[ds, eax + 28]);         /* mov eax, [eax+0x1c] */
            ii(0x100e_15a8, 5);  call(0x100c_f85c, -0x1_1d51);         /* call 0x100cf85c */
        l_0x100e_15ad:
            ii(0x100e_15ad, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_15af, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_15b0, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_15b1, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_15b2, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_15b3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_15b4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_15b5, 1);  ret();                                /* ret */
        }
    }
}
