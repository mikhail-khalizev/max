using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e554-ed50ba2e")]
        public void Method_1012_e554()
        {
            ii(0x1012_e554, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_e559, 5);  call(Definitions.sys_check_available_stack_size, 0x3_77f4);/* call 0x10165d52 */
            ii(0x1012_e55e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_e55f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_e560, 1);  push(edx);                            /* push edx */
            ii(0x1012_e561, 1);  push(esi);                            /* push esi */
            ii(0x1012_e562, 1);  push(edi);                            /* push edi */
            ii(0x1012_e563, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_e564, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_e566, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_e56c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_e56f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e572, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e575, 5);  call(Definitions.my_1_get_count, -0x8_30a2);/* call 0x100ab4d8 */
            ii(0x1012_e57a, 1);  cwde();                               /* cwde */
            ii(0x1012_e57b, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_e57d, 2);  if(jz(0x1012_e5ed, 0x6e)) goto l_0x1012_e5ed;/* jz 0x1012e5ed */
            ii(0x1012_e57f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_e581, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e584, 3);  add(eax, 0x36);                       /* add eax, 0x36 */
            ii(0x1012_e587, 5);  call(0x1013_ad11, 0xc785);            /* call 0x1013ad11 */
            ii(0x1012_e58c, 2);  test(al, al);                         /* test al, al */
            ii(0x1012_e58e, 2);  if(jz(0x1012_e5a3, 0x13)) goto l_0x1012_e5a3;/* jz 0x1012e5a3 */
            ii(0x1012_e590, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e593, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e596, 5);  call(Definitions.my_1_get_count, -0x8_30c3);/* call 0x100ab4d8 */
            ii(0x1012_e59b, 3);  sub(eax, 2);                          /* sub eax, 0x2 */
            ii(0x1012_e59e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_e5a1, 2);  jmp(0x1012_e5bb, 0x18); goto l_0x1012_e5bb;/* jmp 0x1012e5bb */
        l_0x1012_e5a3:
            ii(0x1012_e5a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e5a6, 3);  add(eax, 0x36);                       /* add eax, 0x36 */
            ii(0x1012_e5a9, 5);  call(0x1013_1c0c, 0x365e);            /* call 0x10131c0c */
            ii(0x1012_e5ae, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_e5b0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e5b3, 5);  call(0x1012_e30e, -0x2aa);            /* call 0x1012e30e */
            ii(0x1012_e5b8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x1012_e5bb:
            ii(0x1012_e5bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e5be, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e5c1, 5);  call(Definitions.my_1_get_count, -0x8_30ee);/* call 0x100ab4d8 */
            ii(0x1012_e5c6, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1012_e5ca, 2);  if(jle(0x1012_e5ed, 0x21)) goto l_0x1012_e5ed;/* jle 0x1012e5ed */
            ii(0x1012_e5cc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e5cf, 1);  inc(eax);                             /* inc eax */
            ii(0x1012_e5d0, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1012_e5d3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e5d6, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e5d9, 5);  call(0x1013_18f8, 0x331a);            /* call 0x101318f8 */
            ii(0x1012_e5de, 5);  call(0x1013_19f4, 0x3411);            /* call 0x101319f4 */
            ii(0x1012_e5e3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_e5e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_e5e8, 5);  call(0x1012_e37c, -0x271);            /* call 0x1012e37c */
        l_0x1012_e5ed:
            ii(0x1012_e5ed, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_e5ef, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_e5f0, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_e5f1, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_e5f2, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_e5f3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_e5f4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_e5f5, 1);  ret();                                /* ret */
        }
    }
}
