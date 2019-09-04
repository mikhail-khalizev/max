using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_13bf-41aea746")]
        public void Method_1013_13bf()
        {
            ii(0x1013_13bf, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_13c4, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4989);/* call 0x10165d52 */
            ii(0x1013_13c9, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_13ca, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_13cb, 1);  push(esi);                            /* push esi */
            ii(0x1013_13cc, 1);  push(edi);                            /* push edi */
            ii(0x1013_13cd, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_13ce, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_13d0, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_13d6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_13d9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_13dc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_13df, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_13e2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_13e5, 3);  mov(al, memb[ds, eax + 23]);          /* mov al, [eax+0x17] */
            ii(0x1013_13e8, 3);  mov(memb[ss, ebp - 12], al);          /* mov [ebp-0xc], al */
            ii(0x1013_13eb, 5);  jmp(0x1013_148e, 0x9e); goto l_0x1013_148e;/* jmp 0x1013148e */
        l_0x1013_13f0:
            ii(0x1013_13f0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_13f3, 4);  mov(dx, memw[ds, eax + 58]);          /* mov dx, [eax+0x3a] */
            ii(0x1013_13f7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_13fa, 4);  sub(memw[ds, eax + 48], dx);          /* sub [eax+0x30], dx */
            ii(0x1013_13fe, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1401, 3);  mov(eax, memd[ds, eax + 46]);         /* mov eax, [eax+0x2e] */
            ii(0x1013_1404, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_1407, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_1409, 2);  if(jge(0x1013_1414, 9)) goto l_0x1013_1414;/* jge 0x10131414 */
            ii(0x1013_140b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_140e, 6);  mov(memw[ds, eax + 48], 0);           /* mov word [eax+0x30], 0x0 */
        l_0x1013_1414:
            ii(0x1013_1414, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_1419, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_141c, 5);  call(0x1013_0c16, -0x80b);            /* call 0x10130c16 */
            ii(0x1013_1421, 5);  jmp(0x1013_14b4, 0x8e); goto l_0x1013_14b4;/* jmp 0x101314b4 */
        l_0x1013_1426:
            ii(0x1013_1426, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1429, 4);  mov(dx, memw[ds, eax + 60]);          /* mov dx, [eax+0x3c] */
            ii(0x1013_142d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1430, 4);  sub(memw[ds, eax + 50], dx);          /* sub [eax+0x32], dx */
            ii(0x1013_1434, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1437, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x1013_143a, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_143d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_143f, 2);  if(jge(0x1013_144a, 9)) goto l_0x1013_144a;/* jge 0x1013144a */
            ii(0x1013_1441, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1444, 6);  mov(memw[ds, eax + 50], 0);           /* mov word [eax+0x32], 0x0 */
        l_0x1013_144a:
            ii(0x1013_144a, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_144f, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1452, 5);  call(0x1013_0c16, -0x841);            /* call 0x10130c16 */
            ii(0x1013_1457, 2);  jmp(0x1013_14b4, 0x5b); goto l_0x1013_14b4;/* jmp 0x101314b4 */
        l_0x1013_1459:
            ii(0x1013_1459, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_145c, 4);  mov(dx, memw[ds, eax + 62]);          /* mov dx, [eax+0x3e] */
            ii(0x1013_1460, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1463, 4);  sub(memw[ds, eax + 52], dx);          /* sub [eax+0x34], dx */
            ii(0x1013_1467, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_146a, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1013_146d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1013_1470, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_1472, 2);  if(jge(0x1013_147d, 9)) goto l_0x1013_147d;/* jge 0x1013147d */
            ii(0x1013_1474, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1477, 6);  mov(memw[ds, eax + 52], 0);           /* mov word [eax+0x34], 0x0 */
        l_0x1013_147d:
            ii(0x1013_147d, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_1482, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_1485, 5);  call(0x1013_0c16, -0x874);            /* call 0x10130c16 */
            ii(0x1013_148a, 2);  jmp(0x1013_14b4, 0x28); goto l_0x1013_14b4;/* jmp 0x101314b4 */
        l_0x1013_148c:
            ii(0x1013_148c, 2);  jmp(0x1013_14b4, 0x26); goto l_0x1013_14b4;/* jmp 0x101314b4 */
        l_0x1013_148e:
            ii(0x1013_148e, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1013_1491, 3);  mov(memb[ss, ebp - 20], al);          /* mov [ebp-0x14], al */
            ii(0x1013_1494, 4);  cmp(memb[ss, ebp - 20], 1);           /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_1498, 2);  if(jb(0x1013_14a8, 0xe)) goto l_0x1013_14a8;/* jb 0x101314a8 */
            ii(0x1013_149a, 4);  cmp(memb[ss, ebp - 20], 1);           /* cmp byte [ebp-0x14], 0x1 */
            ii(0x1013_149e, 2);  if(jbe(0x1013_1426, -0x7a)) goto l_0x1013_1426;/* jbe 0x10131426 */
            ii(0x1013_14a0, 4);  cmp(memb[ss, ebp - 20], 3);           /* cmp byte [ebp-0x14], 0x3 */
            ii(0x1013_14a4, 2);  if(jz(0x1013_1459, -0x4d)) goto l_0x1013_1459;/* jz 0x10131459 */
            ii(0x1013_14a6, 2);  jmp(0x1013_148c, -0x1c); goto l_0x1013_148c;/* jmp 0x1013148c */
        l_0x1013_14a8:
            ii(0x1013_14a8, 4);  cmp(memb[ss, ebp - 20], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1013_14ac, 6);  if(jz(0x1013_13f0, -0xc2)) goto l_0x1013_13f0;/* jz 0x101313f0 */
            ii(0x1013_14b2, 2);  jmp(0x1013_148c, -0x28); goto l_0x1013_148c;/* jmp 0x1013148c */
        l_0x1013_14b4:
            ii(0x1013_14b4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_14b6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_14b7, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_14b8, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_14b9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_14ba, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_14bb, 1);  ret();                                /* ret */
        }
    }
}
