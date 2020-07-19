using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a5af-fb6d4a80")]
        public void Method_1013_a5af()
        {
            ii(0x1013_a5af, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_a5b4, 5);  call(Definitions.sys_check_available_stack_size, 0x2_b799);/* call 0x10165d52 */
            ii(0x1013_a5b9, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_a5ba, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_a5bb, 1);  push(esi);                            /* push esi */
            ii(0x1013_a5bc, 1);  push(edi);                            /* push edi */
            ii(0x1013_a5bd, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_a5be, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_a5c0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_a5c6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_a5c9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_a5cc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a5ce, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a5d1, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1013_a5d4, 5);  call(0x1013_ad11, 0x738);             /* call 0x1013ad11 */
            ii(0x1013_a5d9, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a5db, 2);  if(jz(0x1013_a5f5, 0x18)) goto l_0x1013_a5f5;/* jz 0x1013a5f5 */
            ii(0x1013_a5dd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a5e0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a5e3, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a5e6, 5);  call(0x1008_b4ec, -0xa_f0ff);         /* call 0x1008b4ec */
            ii(0x1013_a5eb, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a5ed, 6);  if(jnz(0x1013_a663, 0x70)) goto l_0x1013_a663;/* jnz 0x1013a663 */
            ii(0x1013_a5f3, 2);  jmp(0x1013_a60f, 0x1a); goto l_0x1013_a60f;/* jmp 0x1013a60f */
        l_0x1013_a5f5:
            ii(0x1013_a5f5, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a5f8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a5fb, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1013_a5fe, 5);  call(0x1013_aa3c, 0x439);             /* call 0x1013aa3c */
            ii(0x1013_a603, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1013_a606, 5);  call(0x1008_b4ec, -0xa_f11f);         /* call 0x1008b4ec */
            ii(0x1013_a60b, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a60d, 2);  if(jnz(0x1013_a663, 0x54)) goto l_0x1013_a663;/* jnz 0x1013a663 */
        l_0x1013_a60f:
            ii(0x1013_a60f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a612, 3);  dec(memw[ds, eax]);                   /* dec word [eax] */
            ii(0x1013_a615, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a618, 5);  call(0x1013_a037, -0x5e6);            /* call 0x1013a037 */
            ii(0x1013_a61d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a620, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a623, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a626, 5);  call(0x1007_6e00, -0xc_382b);         /* call 0x10076e00 */
            ii(0x1013_a62b, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a62d, 2);  if(jz(0x1013_a640, 0x11)) goto l_0x1013_a640;/* jz 0x1013a640 */
            ii(0x1013_a62f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a632, 3);  add(edx, 0xa);                        /* add edx, 0xa */
            ii(0x1013_a635, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a638, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a63b, 5);  call(0x1013_aa70, 0x430);             /* call 0x1013aa70 */
        l_0x1013_a640:
            ii(0x1013_a640, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a643, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a646, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_a649, 5);  call(0x1007_6e00, -0xc_384e);         /* call 0x10076e00 */
            ii(0x1013_a64e, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a650, 2);  if(jz(0x1013_a663, 0x11)) goto l_0x1013_a663;/* jz 0x1013a663 */
            ii(0x1013_a652, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a655, 3);  add(edx, 0xe);                        /* add edx, 0xe */
            ii(0x1013_a658, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a65b, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_a65e, 5);  call(0x1013_aa70, 0x40d);             /* call 0x1013aa70 */
        l_0x1013_a663:
            ii(0x1013_a663, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_a665, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_a666, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_a667, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_a668, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_a669, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_a66a, 1);  ret();                                /* ret */
        }
    }
}
