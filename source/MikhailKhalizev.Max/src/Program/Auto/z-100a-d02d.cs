using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d02d-3f2c0045")]
        public void Method_100a_d02d()
        {
            ii(0x100a_d02d, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_d032, 5);  call(Definitions.sys_check_available_stack_size, 0xb_8d1b);/* call 0x10165d52 */
            ii(0x100a_d037, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_d038, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_d039, 1);  push(esi);                            /* push esi */
            ii(0x100a_d03a, 1);  push(edi);                            /* push edi */
            ii(0x100a_d03b, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_d03c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_d03e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_d044, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_d047, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100a_d04a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d04c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d04f, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_d052, 5);  call(0x1013_ad71, 0x8_dd1a);          /* call 0x1013ad71 */
            ii(0x100a_d057, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_d059, 6);  if(jz(0x100a_d0db, 0x7c)) goto l_0x100a_d0db;/* jz 0x100ad0db */
            ii(0x100a_d05f, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100a_d061, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d064, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d067, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_d06a, 5);  call(0x1007_6574, -0x3_6afb);         /* call 0x10076574 */
            ii(0x100a_d06f, 5);  call(0x1015_2962, 0xa_58ee);          /* call 0x10152962 */
            ii(0x100a_d074, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d076, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d079, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_d07c, 5);  call(0x1013_ad71, 0x8_dcf0);          /* call 0x1013ad71 */
            ii(0x100a_d081, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_d083, 2);  if(jz(0x100a_d0a7, 0x22)) goto l_0x100a_d0a7;/* jz 0x100ad0a7 */
            ii(0x100a_d085, 4);  movsx(ebx, memb[ss, ebp - 4]);        /* movsx ebx, byte [ebp-0x4] */
            ii(0x100a_d089, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d08c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_d08f, 5);  call(0x1007_65d0, -0x3_6ac4);         /* call 0x100765d0 */
            ii(0x100a_d094, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_d096, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d099, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_d09c, 5);  call(0x1008_af84, -0x2_211d);         /* call 0x1008af84 */
            ii(0x100a_d0a1, 3);  mov(ecx, memd[ss, ebp - 8]);          /* mov ecx, [ebp-0x8] */
            ii(0x100a_d0a4, 3);  call_abs(memd[ds, ecx + 64]);         /* call dword [ecx+0x40] */
        l_0x100a_d0a7:
            ii(0x100a_d0a7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d0a9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d0ac, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_d0af, 5);  call(0x1007_6630, -0x3_6a84);         /* call 0x10076630 */
            ii(0x100a_d0b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d0b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d0b9, 3);  add(eax, 0x3c);                       /* add eax, 0x3c */
            ii(0x100a_d0bc, 5);  call(0x1009_c8f8, -0x1_07c9);         /* call 0x1009c8f8 */
            ii(0x100a_d0c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d0c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d0c6, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_d0c9, 5);  call(0x1008_afe4, -0x2_20ea);         /* call 0x1008afe4 */
            ii(0x100a_d0ce, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d0d1, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100a_d0d6, 5);  call(0x100a_5e27, -0x72b4);           /* call 0x100a5e27 */
        l_0x100a_d0db:
            ii(0x100a_d0db, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_d0dd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_d0de, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_d0df, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_d0e0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_d0e1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_d0e2, 1);  ret();                                /* ret */
        }
    }
}
