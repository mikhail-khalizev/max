using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_e41a-dea62f6")]
        public void Method_1011_e41a()
        {
            ii(0x1011_e41a, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1011_e41f, 5);  call(Definitions.sys_check_available_stack_size, 0x4_792e);/* call 0x10165d52 */
            ii(0x1011_e424, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_e425, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_e426, 1);  push(esi);                            /* push esi */
            ii(0x1011_e427, 1);  push(edi);                            /* push edi */
            ii(0x1011_e428, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_e429, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_e42b, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1011_e431, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_e434, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_e437, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_e43a, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_e43d, 5);  call(0x1012_0984, 0x2542);            /* call 0x10120984 */
            ii(0x1011_e442, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_e445, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e448, 5);  call(0x1007_6e00, -0xa_764d);         /* call 0x10076e00 */
            ii(0x1011_e44d, 2);  test(al, al);                         /* test al, al */
            ii(0x1011_e44f, 6);  if(jz(0x1011_e4d9, 0x84)) goto l_0x1011_e4d9;/* jz 0x1011e4d9 */
            ii(0x1011_e455, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e458, 4);  cmp(memd[ds, eax + 22], 0);           /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_e45c, 2);  if(jz(0x1011_e488, 0x2a)) goto l_0x1011_e488;/* jz 0x1011e488 */
            ii(0x1011_e45e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e461, 3);  mov(eax, memd[ds, eax + 22]);         /* mov eax, [eax+0x16] */
            ii(0x1011_e464, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_e467, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1011_e46b, 2);  if(jz(0x1011_e481, 0x14)) goto l_0x1011_e481;/* jz 0x1011e481 */
            ii(0x1011_e46d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e46f, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_e472, 5);  call(Definitions.my_dtor_d7, -0x2235);/* call 0x1011c242 */
            ii(0x1011_e477, 5);  call(Definitions.sys_delete, 0x4_7ae8);/* call 0x10165f64 */
            ii(0x1011_e47c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_e47f, 2);  jmp(0x1011_e488, 7); goto l_0x1011_e488;/* jmp 0x1011e488 */
        l_0x1011_e481:
            ii(0x1011_e481, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1011_e488:
            ii(0x1011_e488, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e48b, 4);  cmp(memd[ds, eax + 26], 0);           /* cmp dword [eax+0x1a], 0x0 */
            ii(0x1011_e48f, 2);  if(jz(0x1011_e4bb, 0x2a)) goto l_0x1011_e4bb;/* jz 0x1011e4bb */
            ii(0x1011_e491, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e494, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1011_e497, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_e49a, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_e49e, 2);  if(jz(0x1011_e4b4, 0x14)) goto l_0x1011_e4b4;/* jz 0x1011e4b4 */
            ii(0x1011_e4a0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e4a2, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1011_e4a5, 5);  call(Definitions.my_dtor_d7, -0x2268);/* call 0x1011c242 */
            ii(0x1011_e4aa, 5);  call(Definitions.sys_delete, 0x4_7ab5);/* call 0x10165f64 */
            ii(0x1011_e4af, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1011_e4b2, 2);  jmp(0x1011_e4bb, 7); goto l_0x1011_e4bb;/* jmp 0x1011e4bb */
        l_0x1011_e4b4:
            ii(0x1011_e4b4, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1011_e4bb:
            ii(0x1011_e4bb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e4be, 7);  mov(memd[ds, eax + 22], 0);           /* mov dword [eax+0x16], 0x0 */
            ii(0x1011_e4c5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e4c8, 7);  mov(memd[ds, eax + 26], 0);           /* mov dword [eax+0x1a], 0x0 */
            ii(0x1011_e4cf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e4d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e4d4, 5);  call(0x100b_7fa4, -0x6_6535);         /* call 0x100b7fa4 */
        l_0x1011_e4d9:
            ii(0x1011_e4d9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_e4dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_e4df, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1011_e4e2, 5);  call(0x1012_07cc, 0x22e5);            /* call 0x101207cc */
            ii(0x1011_e4e7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_e4ea, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_e4ed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_e4f0, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1011_e4f3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1011_e4f6, 3);  call_abs(memd[ds, edx + 8]);          /* call dword [edx+0x8] */
            ii(0x1011_e4f9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_e4fb, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1011_e4fe, 5);  call(0x100b_7368, -0x6_719b);         /* call 0x100b7368 */
            ii(0x1011_e503, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_e505, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_e506, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_e507, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_e508, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_e509, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_e50a, 1);  ret();                                /* ret */
        }
    }
}
