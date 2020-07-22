using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5e8c-501ae2b7")]
        public void Method_1013_5e8c()
        {
            ii(0x1013_5e8c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_5e91, 5);  call(Definitions.sys_check_available_stack_size, 0x2_febc);/* call 0x10165d52 */
            ii(0x1013_5e96, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_5e97, 1);  push(esi);                            /* push esi */
            ii(0x1013_5e98, 1);  push(edi);                            /* push edi */
            ii(0x1013_5e99, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_5e9a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_5e9c, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_5ea2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_5ea5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_5ea8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1013_5eab, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_5eae, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_5eb1, 5);  jmp(0x1013_5fa8, 0xf2); goto l_0x1013_5fa8;/* jmp 0x10135fa8 */
        l_0x1013_5eb6:
            ii(0x1013_5eb6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5eb9, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5ebc, 4);  mov(memw[ds, edx + 8], ax);           /* mov [edx+0x8], ax */
            ii(0x1013_5ec0, 5);  jmp(0x1013_5fc5, 0x100); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5ec5:
            ii(0x1013_5ec5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5ec8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5ecb, 4);  add(memw[ds, edx + 10], ax);          /* add [edx+0xa], ax */
            ii(0x1013_5ecf, 5);  jmp(0x1013_5fc5, 0xf1); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5ed4:
            ii(0x1013_5ed4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5ed7, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5eda, 4);  add(memw[ds, edx + 12], ax);          /* add [edx+0xc], ax */
            ii(0x1013_5ede, 5);  jmp(0x1013_5fc5, 0xe2); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5ee3:
            ii(0x1013_5ee3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5ee6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5ee9, 4);  add(memw[ds, edx + 14], ax);          /* add [edx+0xe], ax */
            ii(0x1013_5eed, 5);  jmp(0x1013_5fc5, 0xd3); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5ef2:
            ii(0x1013_5ef2, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_5ef5, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5ef8, 3);  add(memb[ds, edx + 22], al);          /* add [edx+0x16], al */
            ii(0x1013_5efb, 5);  jmp(0x1013_5fc5, 0xc5); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f00:
            ii(0x1013_5f00, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f03, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f06, 4);  add(memw[ds, edx + 16], ax);          /* add [edx+0x10], ax */
            ii(0x1013_5f0a, 5);  jmp(0x1013_5fc5, 0xb6); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f0f:
            ii(0x1013_5f0f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f12, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f15, 4);  add(memw[ds, edx + 18], ax);          /* add [edx+0x12], ax */
            ii(0x1013_5f19, 5);  jmp(0x1013_5fc5, 0xa7); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f1e:
            ii(0x1013_5f1e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f21, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f24, 4);  add(memw[ds, edx + 20], ax);          /* add [edx+0x14], ax */
            ii(0x1013_5f28, 5);  jmp(0x1013_5fc5, 0x98); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f2d:
            ii(0x1013_5f2d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f30, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f33, 4);  add(memw[ds, edx + 23], ax);          /* add [edx+0x17], ax */
            ii(0x1013_5f37, 5);  jmp(0x1013_5fc5, 0x89); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f3c:
            ii(0x1013_5f3c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f3f, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f42, 4);  add(memw[ds, edx + 25], ax);          /* add [edx+0x19], ax */
            ii(0x1013_5f46, 5);  jmp(0x1013_5fc5, 0x7a); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f4b:
            ii(0x1013_5f4b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f4e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f51, 4);  add(memw[ds, edx + 27], ax);          /* add [edx+0x1b], ax */
            ii(0x1013_5f55, 2);  jmp(0x1013_5fc5, 0x6e); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f57:
            ii(0x1013_5f57, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f5a, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f5d, 4);  add(memw[ds, edx + 29], ax);          /* add [edx+0x1d], ax */
            ii(0x1013_5f61, 2);  jmp(0x1013_5fc5, 0x62); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f63:
            ii(0x1013_5f63, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_5f66, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_5f69, 4);  add(memw[ds, edx + 31], ax);          /* add [edx+0x1f], ax */
            ii(0x1013_5f6d, 2);  jmp(0x1013_5fc5, 0x56); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        l_0x1013_5f6f:
            ii(0x1013_5f6f, 2);  jmp(0x1013_5fc5, 0x54); goto l_0x1013_5fc5;/* jmp 0x10135fc5 */
        //  ii(0x1013_5f71, 55);  Недостижимый код.
        l_0x1013_5fa8:
            ii(0x1013_5fa8, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_5fab, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_5fae, 5);  cmp(memw[ss, ebp - 20], 0xc);         /* cmp word [ebp-0x14], 0xc */
            ii(0x1013_5fb3, 2);  if(ja(0x1013_5f6f, -0x46)) goto l_0x1013_5f6f;/* ja 0x10135f6f */
            ii(0x1013_5fb5, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_5fb7, 4);  mov(ax, memw[ss, ebp - 20]);          /* mov ax, [ebp-0x14] */
            ii(0x1013_5fbb, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_5fbe, 7);  /* jmp dword [cs:eax+0x10135f74] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1013_5f74]))
            {
                case 0x1013_5eb6:
                    goto l_0x1013_5eb6;
                case 0x1013_5ec5:
                    goto l_0x1013_5ec5;
                case 0x1013_5ed4:
                    goto l_0x1013_5ed4;
                case 0x1013_5ee3:
                    goto l_0x1013_5ee3;
                case 0x1013_5ef2:
                    goto l_0x1013_5ef2;
                case 0x1013_5f00:
                    goto l_0x1013_5f00;
                case 0x1013_5f0f:
                    goto l_0x1013_5f0f;
                case 0x1013_5f1e:
                    goto l_0x1013_5f1e;
                case 0x1013_5f2d:
                    goto l_0x1013_5f2d;
                case 0x1013_5f3c:
                    goto l_0x1013_5f3c;
                case 0x1013_5f4b:
                    goto l_0x1013_5f4b;
                case 0x1013_5f57:
                    goto l_0x1013_5f57;
                case 0x1013_5f63:
                    goto l_0x1013_5f63;
                default:
                    throw new NotImplementedException();
            }
        l_0x1013_5fc5:
            ii(0x1013_5fc5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_5fc7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_5fc8, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_5fc9, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_5fca, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_5fcb, 1);  ret();                                /* ret */
        }
    }
}
