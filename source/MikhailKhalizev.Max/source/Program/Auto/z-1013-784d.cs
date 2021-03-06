using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_784d-5c22721f")]
        public void Method_1013_784d()
        {
            ii(0x1013_784d, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1013_7852, 5);  call(Definitions.sys_check_available_stack_size, 0x2_e4fb);/* call 0x10165d52 */
            ii(0x1013_7857, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_7858, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_7859, 1);  push(esi);                            /* push esi */
            ii(0x1013_785a, 1);  push(edi);                            /* push edi */
            ii(0x1013_785b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_785c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_785e, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_7864, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_7867, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_786a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_786d, 4);  cmp(memb[ds, eax + 77], 0);           /* cmp byte [eax+0x4d], 0x0 */
            ii(0x1013_7871, 2);  if(jz(0x1013_788f, 0x1c)) goto l_0x1013_788f;/* jz 0x1013788f */
            ii(0x1013_7873, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_7876, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1013_7879, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_787c, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_787e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_7881, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_7884, 6);  mov(eax, memd[ds, eax + 0x101b_d454]);/* mov eax, [eax+0x101bd454] */
            ii(0x1013_788a, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_788d, 2);  jmp(0x1013_789d, 0xe); goto l_0x1013_789d;/* jmp 0x1013789d */
        l_0x1013_788f:
            ii(0x1013_788f, 7);  mov(memd[ss, ebp - 12], StringDefinitions.Empty9);/* mov dword [ebp-0xc], 0x101ac7d4 */
            ii(0x1013_7896, 7);  mov(memd[ss, ebp - 16], StringDefinitions.Empty10);/* mov dword [ebp-0x10], 0x101ac7d5 */
        l_0x1013_789d:
            ii(0x1013_789d, 2);  push(5);                              /* push 0x5 */
            ii(0x1013_789f, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x1013_78a2, 5);  mov(ebx, 0x4b7);                      /* mov ebx, 0x4b7 */
            ii(0x1013_78a7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78aa, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x1013_78ad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78b0, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1013_78b3, 5);  call(0x1013_7754, -0x164);            /* call 0x10137754 */
            ii(0x1013_78b8, 2);  push(2);                              /* push 0x2 */
            ii(0x1013_78ba, 3);  mov(ecx, memd[ss, ebp - 16]);         /* mov ecx, [ebp-0x10] */
            ii(0x1013_78bd, 5);  mov(ebx, 0x4b9);                      /* mov ebx, 0x4b9 */
            ii(0x1013_78c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78c5, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x1013_78c8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78cb, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x1013_78ce, 5);  call(0x1013_7754, -0x17f);            /* call 0x10137754 */
            ii(0x1013_78d3, 2);  push(5);                              /* push 0x5 */
            ii(0x1013_78d5, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x1013_78d8, 3);  add(ecx, 0x20);                       /* add ecx, 0x20 */
            ii(0x1013_78db, 5);  mov(ebx, 0x4b8);                      /* mov ebx, 0x4b8 */
            ii(0x1013_78e0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78e3, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x1013_78e6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_78e9, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1013_78ec, 5);  call(0x1013_7754, -0x19d);            /* call 0x10137754 */
            ii(0x1013_78f1, 2);  push(2);                              /* push 0x2 */
            ii(0x1013_78f3, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1013_78f5, 3);  mov(cl, memb[ss, ebp - 4]);           /* mov cl, [ebp-0x4] */
            ii(0x1013_78f8, 3);  shl(ecx, 2);                          /* shl ecx, 0x2 */
            ii(0x1013_78fb, 6);  mov(ecx, memd[ds, ecx + 0x101b_d454]);/* mov ecx, [ecx+0x101bd454] */
            ii(0x1013_7901, 5);  mov(ebx, 0x4ba);                      /* mov ebx, 0x4ba */
            ii(0x1013_7906, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_7909, 3);  mov(edx, memd[ds, eax + 12]);         /* mov edx, [eax+0xc] */
            ii(0x1013_790c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_790f, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1013_7912, 5);  call(0x1013_7754, -0x1c3);            /* call 0x10137754 */
            ii(0x1013_7917, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_7919, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_791a, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_791b, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_791c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_791d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_791e, 1);  ret();                                /* ret */
        }
    }
}
