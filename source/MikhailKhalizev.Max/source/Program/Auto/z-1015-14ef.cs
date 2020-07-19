using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_14ef-1f4832f2")]
        public void Method_1015_14ef()
        {
            ii(0x1015_14ef, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1015_14f4, 5);  call(Definitions.sys_check_available_stack_size, 0x1_4859);/* call 0x10165d52 */
            ii(0x1015_14f9, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_14fa, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_14fb, 1);  push(edx);                            /* push edx */
            ii(0x1015_14fc, 1);  push(esi);                            /* push esi */
            ii(0x1015_14fd, 1);  push(edi);                            /* push edi */
            ii(0x1015_14fe, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_14ff, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_1501, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_1507, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_150a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_150d, 4);  test(memb[ds, eax + 19], 1);          /* test byte [eax+0x13], 0x1 */
            ii(0x1015_1511, 2);  if(jz(0x1015_151f, 0xc)) goto l_0x1015_151f;/* jz 0x1015151f */
            ii(0x1015_1513, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1516, 4);  mov(ax, memw[ds, eax + 120]);         /* mov ax, [eax+0x78] */
            ii(0x1015_151a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_151d, 2);  jmp(0x1015_1559, 0x3a); goto l_0x1015_1559;/* jmp 0x10151559 */
        l_0x1015_151f:
            ii(0x1015_151f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1522, 3);  mov(ebx, memd[ds, eax + 80]);         /* mov ebx, [eax+0x50] */
            ii(0x1015_1525, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1015_1528, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_152b, 3);  mov(al, memb[ds, eax + 69]);          /* mov al, [eax+0x45] */
            ii(0x1015_152e, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1015_1530, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1015_1533, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_1536, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1015_1539, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_153c, 5);  call(0x100d_4c69, -0x7_c8d8);         /* call 0x100d4c69 */
            ii(0x1015_1541, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_1544, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1015_1548, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_154b, 3);  mov(eax, memd[ds, eax + 118]);        /* mov eax, [eax+0x76] */
            ii(0x1015_154e, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1015_1551, 5);  call(Definitions.my_min, -0xc_7dd2);  /* call 0x10089784 */
            ii(0x1015_1556, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1015_1559:
            ii(0x1015_1559, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_155c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_155e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_155f, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_1560, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_1561, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_1562, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_1563, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_1564, 1);  ret();                                /* ret */
        }
    }
}
