using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c6eb-44f911c")]
        public void Method_100e_c6eb()
        {
            ii(0x100e_c6eb, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100e_c6f0, 5);  call(Definitions.sys_check_available_stack_size, 0x7_965d);/* call 0x10165d52 */
            ii(0x100e_c6f5, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_c6f6, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_c6f7, 1);  push(esi);                            /* push esi */
            ii(0x100e_c6f8, 1);  push(edi);                            /* push edi */
            ii(0x100e_c6f9, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_c6fa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_c6fc, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_c702, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_c705, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_c708, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x100e_c70d, 5);  call(0x1007_6338, -0x7_63da);         /* call 0x10076338 */
            ii(0x100e_c712, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x100e_c715, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_c717, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100e_c719, 5);  call(0x1007_64b8, -0x7_6266);         /* call 0x100764b8 */
            ii(0x100e_c71e, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100e_c725, 2);  jmp(0x100e_c72f, 8); goto l_0x100e_c72f;/* jmp 0x100ec72f */
        l_0x100e_c727:
            ii(0x100e_c727, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c72a, 5);  call(0x1007_6bf8, -0x7_5b37);         /* call 0x10076bf8 */
        l_0x100e_c72f:
            ii(0x100e_c72f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c731, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c734, 5);  call(0x1013_ad71, 0x4_e638);          /* call 0x1013ad71 */
            ii(0x100e_c739, 2);  test(al, al);                         /* test al, al */
            ii(0x100e_c73b, 2);  if(jz(0x100e_c78e, 0x51)) goto l_0x100e_c78e;/* jz 0x100ec78e */
            ii(0x100e_c73d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c740, 5);  call(0x1007_63a0, -0x7_63a5);         /* call 0x100763a0 */
            ii(0x100e_c745, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c747, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100e_c74a, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c74e, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100e_c750, 2);  if(jnz(0x100e_c764, 0x12)) goto l_0x100e_c764;/* jnz 0x100ec764 */
            ii(0x100e_c752, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c755, 5);  call(0x1007_63a0, -0x7_63ba);         /* call 0x100763a0 */
            ii(0x100e_c75a, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100e_c75e, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100e_c762, 2);  if(jz(0x100e_c766, 2)) goto l_0x100e_c766;/* jz 0x100ec766 */
        l_0x100e_c764:
            ii(0x100e_c764, 2);  jmp(0x100e_c784, 0x1e); goto l_0x100e_c784;/* jmp 0x100ec784 */
        l_0x100e_c766:
            ii(0x100e_c766, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c769, 5);  call(0x1007_63a0, -0x7_63ce);         /* call 0x100763a0 */
            ii(0x100e_c76e, 4);  cmp(memb[ds, eax + 61], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x100e_c772, 2);  if(jz(0x100e_c782, 0xe)) goto l_0x100e_c782;/* jz 0x100ec782 */
            ii(0x100e_c774, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c777, 5);  call(0x1007_63a0, -0x7_63dc);         /* call 0x100763a0 */
            ii(0x100e_c77c, 4);  cmp(memb[ds, eax + 61], 4);           /* cmp byte [eax+0x3d], 0x4 */
            ii(0x100e_c780, 2);  if(jnz(0x100e_c784, 2)) goto l_0x100e_c784;/* jnz 0x100ec784 */
        l_0x100e_c782:
            ii(0x100e_c782, 2);  jmp(0x100e_c786, 2); goto l_0x100e_c786;/* jmp 0x100ec786 */
        l_0x100e_c784:
            ii(0x100e_c784, 2);  jmp(0x100e_c78c, 6); goto l_0x100e_c78c;/* jmp 0x100ec78c */
        l_0x100e_c786:
            ii(0x100e_c786, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c789, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100e_c78c:
            ii(0x100e_c78c, 2);  jmp(0x100e_c727, -0x67); goto l_0x100e_c727;/* jmp 0x100ec727 */
        l_0x100e_c78e:
            ii(0x100e_c78e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_c791, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_c794, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_c796, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100e_c799, 5);  call(0x1007_5f6c, -0x7_6832);         /* call 0x10075f6c */
            ii(0x100e_c79e, 2);  jmp(0x100e_c7aa, 0xa); goto l_0x100e_c7aa;/* jmp 0x100ec7aa */
        //  ii(0x100e_c7a0, 10);  Недостижимый код.
        l_0x100e_c7aa:
            ii(0x100e_c7aa, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_c7ad, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_c7af, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_c7b0, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_c7b1, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_c7b2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_c7b3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_c7b4, 1);  ret();                                /* ret */
        }
    }
}
