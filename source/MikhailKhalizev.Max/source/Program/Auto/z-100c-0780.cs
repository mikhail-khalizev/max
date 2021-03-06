using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_0780-49838f31")]
        public void Method_100c_0780()
        {
            ii(0x100c_0780, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_0785, 5);  call(Definitions.sys_check_available_stack_size, 0xa_55c8);/* call 0x10165d52 */
            ii(0x100c_078a, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_078b, 1);  push(esi);                            /* push esi */
            ii(0x100c_078c, 1);  push(edi);                            /* push edi */
            ii(0x100c_078d, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_078e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_0790, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_0796, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_0799, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_079c, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_079f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_07a2, 4);  cmp(memb[ds, eax + 80], 0);           /* cmp byte [eax+0x50], 0x0 */
            ii(0x100c_07a6, 2);  if(jz(0x100c_07b4, 0xc)) goto l_0x100c_07b4;/* jz 0x100c07b4 */
            ii(0x100c_07a8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_07ab, 5);  call(0x100a_2edb, -0x1_d8d5);         /* call 0x100a2edb */
            ii(0x100c_07b0, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_07b2, 2);  if(jnz(0x100c_07b6, 2)) goto l_0x100c_07b6;/* jnz 0x100c07b6 */
        l_0x100c_07b4:
            ii(0x100c_07b4, 2);  jmp(0x100c_07c5, 0xf); goto l_0x100c_07c5;/* jmp 0x100c07c5 */
        l_0x100c_07b6:
            ii(0x100c_07b6, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_07b9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_07bc, 5);  call(0x1007_4bde, -0x4_bbe3);         /* call 0x10074bde */
            ii(0x100c_07c1, 2);  test(al, al);                         /* test al, al */
            ii(0x100c_07c3, 2);  if(jnz(0x100c_07ce, 9)) goto l_0x100c_07ce;/* jnz 0x100c07ce */
        l_0x100c_07c5:
            ii(0x100c_07c5, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_07cc, 2);  jmp(0x100c_082d, 0x5f); goto l_0x100c_082d;/* jmp 0x100c082d */
        l_0x100c_07ce:
            ii(0x100c_07ce, 4);  cmp(memb[ss, ebp - 4], 1);            /* cmp byte [ebp-0x4], 0x1 */
            ii(0x100c_07d2, 2);  if(jnz(0x100c_07e2, 0xe)) goto l_0x100c_07e2;/* jnz 0x100c07e2 */
            ii(0x100c_07d4, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_07d7, 5);  call(0x1007_623c, -0x4_a5a0);         /* call 0x1007623c */
            ii(0x100c_07dc, 4);  cmp(memb[ds, eax + 22], 0);           /* cmp byte [eax+0x16], 0x0 */
            ii(0x100c_07e0, 2);  if(jz(0x100c_07e4, 2)) goto l_0x100c_07e4;/* jz 0x100c07e4 */
        l_0x100c_07e2:
            ii(0x100c_07e2, 2);  jmp(0x100c_07ed, 9); goto l_0x100c_07ed;/* jmp 0x100c07ed */
        l_0x100c_07e4:
            ii(0x100c_07e4, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_07eb, 2);  jmp(0x100c_082d, 0x40); goto l_0x100c_082d;/* jmp 0x100c082d */
        l_0x100c_07ed:
            ii(0x100c_07ed, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_07f0, 5);  call(0x1015_26ac, 0x9_1eb7);          /* call 0x101526ac */
            ii(0x100c_07f5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_07f7, 2);  if(jz(0x100c_0810, 0x17)) goto l_0x100c_0810;/* jz 0x100c0810 */
            ii(0x100c_07f9, 5);  mov(edx, 0x400);                      /* mov edx, 0x400 */
            ii(0x100c_07fe, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_0801, 5);  call(0x1015_26ac, 0x9_1ea6);          /* call 0x101526ac */
            ii(0x100c_0806, 5);  call(0x100a_2bc4, -0x1_dc47);         /* call 0x100a2bc4 */
            ii(0x100c_080b, 1);  cwde();                               /* cwde */
            ii(0x100c_080c, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_080e, 2);  if(jle(0x100c_0812, 2)) goto l_0x100c_0812;/* jle 0x100c0812 */
        l_0x100c_0810:
            ii(0x100c_0810, 2);  jmp(0x100c_081b, 9); goto l_0x100c_081b;/* jmp 0x100c081b */
        l_0x100c_0812:
            ii(0x100c_0812, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100c_0819, 2);  jmp(0x100c_082d, 0x12); goto l_0x100c_082d;/* jmp 0x100c082d */
        l_0x100c_081b:
            ii(0x100c_081b, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100c_081f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_0822, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_0825, 5);  call(0x100c_0532, -0x2f8);            /* call 0x100c0532 */
            ii(0x100c_082a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
        l_0x100c_082d:
            ii(0x100c_082d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_0830, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_0832, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_0833, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_0834, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_0835, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_0836, 1);  ret();                                /* ret */
        }
    }
}
