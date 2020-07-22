using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_1621-b5b0533a")]
        public void Method_1016_1621()
        {
            ii(0x1016_1621, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1016_1626, 5);  call(Definitions.sys_check_available_stack_size, 0x4727);/* call 0x10165d52 */
            ii(0x1016_162b, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_162c, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_162d, 1);  push(edx);                            /* push edx */
            ii(0x1016_162e, 1);  push(esi);                            /* push esi */
            ii(0x1016_162f, 1);  push(edi);                            /* push edi */
            ii(0x1016_1630, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_1631, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_1633, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_1639, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_163c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_163f, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x1016_1643, 2);  if(jz(0x1016_1654, 0xf)) goto l_0x1016_1654;/* jz 0x10161654 */
            ii(0x1016_1645, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1648, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1016_164d, 5);  call(0x1008_aab4, -0xd_6b9e);         /* call 0x1008aab4 */
            ii(0x1016_1652, 2);  jmp(0x1016_16b4, 0x60); goto l_0x1016_16b4;/* jmp 0x101616b4 */
        l_0x1016_1654:
            ii(0x1016_1654, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1657, 6);  test(memw[ds, eax + 18], 0x180);      /* test word [eax+0x12], 0x180 */
            ii(0x1016_165d, 2);  if(jz(0x1016_166e, 0xf)) goto l_0x1016_166e;/* jz 0x1016166e */
            ii(0x1016_165f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1662, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1016_1667, 5);  call(0x1008_aab4, -0xd_6bb8);         /* call 0x1008aab4 */
            ii(0x1016_166c, 2);  jmp(0x1016_16b4, 0x46); goto l_0x1016_16b4;/* jmp 0x101616b4 */
        l_0x1016_166e:
            ii(0x1016_166e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1671, 4);  test(memb[ds, eax + 19], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x1016_1675, 2);  if(jz(0x1016_1686, 0xf)) goto l_0x1016_1686;/* jz 0x10161686 */
            ii(0x1016_1677, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_167a, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1016_167f, 5);  call(0x1008_aab4, -0xd_6bd0);         /* call 0x1008aab4 */
            ii(0x1016_1684, 2);  jmp(0x1016_16b4, 0x2e); goto l_0x1016_16b4;/* jmp 0x101616b4 */
        l_0x1016_1686:
            ii(0x1016_1686, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_1689, 4);  test(memb[ds, eax + 18], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1016_168d, 2);  if(jz(0x1016_169e, 0xf)) goto l_0x1016_169e;/* jz 0x1016169e */
            ii(0x1016_168f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_1692, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1016_1697, 5);  call(0x1008_aab4, -0xd_6be8);         /* call 0x1008aab4 */
            ii(0x1016_169c, 2);  jmp(0x1016_16b4, 0x16); goto l_0x1016_16b4;/* jmp 0x101616b4 */
        l_0x1016_169e:
            ii(0x1016_169e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_16a1, 4);  test(memb[ds, eax + 18], 0x20);       /* test byte [eax+0x12], 0x20 */
            ii(0x1016_16a5, 2);  if(jz(0x1016_16b4, 0xd)) goto l_0x1016_16b4;/* jz 0x101616b4 */
            ii(0x1016_16a7, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1016_16aa, 5);  mov(eax, 0x101c_8190);                /* mov eax, 0x101c8190 */
            ii(0x1016_16af, 5);  call(0x1008_aab4, -0xd_6c00);         /* call 0x1008aab4 */
        l_0x1016_16b4:
            ii(0x1016_16b4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_16b6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_16b7, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_16b8, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_16b9, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_16ba, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_16bb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_16bc, 1);  ret();                                /* ret */
        }
    }
}
