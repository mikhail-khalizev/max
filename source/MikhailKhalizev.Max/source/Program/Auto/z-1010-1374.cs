using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_1374-4466419a")]
        public void Method_1010_1374()
        {
            ii(0x1010_1374, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_1379, 5);  call(Definitions.sys_check_available_stack_size, 0x6_49d4);/* call 0x10165d52 */
            ii(0x1010_137e, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_137f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_1380, 1);  push(edx);                            /* push edx */
            ii(0x1010_1381, 1);  push(esi);                            /* push esi */
            ii(0x1010_1382, 1);  push(edi);                            /* push edi */
            ii(0x1010_1383, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_1384, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_1386, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_138c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_138f, 5);  call(0x100f_40a6, -0xd2ee);           /* call 0x100f40a6 */
            ii(0x1010_1394, 5);  call(0x100f_f5c1, -0x1dd8);           /* call 0x100ff5c1 */
            ii(0x1010_1399, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_139b, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x1010_139e, 5);  mov(eax, 0x101c_37bc);                /* mov eax, 0x101c37bc */
            ii(0x1010_13a3, 5);  call(0x1007_6600, -0x8_ada8);         /* call 0x10076600 */
            ii(0x1010_13a8, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_13aa, 6);  mov(cl, memb[ds, 0x101c_37da]);       /* mov cl, [0x101c37da] */
            ii(0x1010_13b0, 3);  movsx(ecx, cx);                       /* movsx ecx, cx */
            ii(0x1010_13b3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_13b5, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1010_13b7, 5);  call(0x1007_2c3a, -0x8_e782);         /* call 0x10072c3a */
            ii(0x1010_13bc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_13bf, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_13c3, 2);  if(jnz(0x1010_13d5, 0x10)) goto l_0x1010_13d5;/* jnz 0x101013d5 */
            ii(0x1010_13c5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_13c7, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1010_13cc, 1);  cwde();                               /* cwde */
            ii(0x1010_13cd, 5);  call(0x100f_1d28, -0xf6aa);           /* call 0x100f1d28 */
            ii(0x1010_13d2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1010_13d5:
            ii(0x1010_13d5, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1010_13d9, 2);  if(jnz(0x1010_13e4, 9)) goto l_0x1010_13e4;/* jnz 0x101013e4 */
            ii(0x1010_13db, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1010_13dd, 5);  call(0x100f_f637, -0x1dab);           /* call 0x100ff637 */
            ii(0x1010_13e2, 2);  jmp(0x1010_141e, 0x3a); goto l_0x1010_141e;/* jmp 0x1010141e */
        l_0x1010_13e4:
            ii(0x1010_13e4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_13e7, 5);  call(0x1010_1103, -0x2e9);            /* call 0x10101103 */
            ii(0x1010_13ec, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1010_13ef, 2);  if(jnz(0x1010_1416, 0x25)) goto l_0x1010_1416;/* jnz 0x10101416 */
            ii(0x1010_13f1, 5);  call(0x1010_2acc, 0x16d6);            /* call 0x10102acc */
            ii(0x1010_13f6, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_13f8, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1010_13fa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_13fd, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1010_1400, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1010_1403, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1406, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1010_1409, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_140c, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1010_1411, 5);  call(0x1010_1620, 0x20a);             /* call 0x10101620 */
        l_0x1010_1416:
            ii(0x1010_1416, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1419, 5);  call(0x100f_f637, -0x1de7);           /* call 0x100ff637 */
        l_0x1010_141e:
            ii(0x1010_141e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_1420, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_1421, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_1422, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_1423, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_1424, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_1425, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_1426, 1);  ret();                                /* ret */
        }
    }
}
