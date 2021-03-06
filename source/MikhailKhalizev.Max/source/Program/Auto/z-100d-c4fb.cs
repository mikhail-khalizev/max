using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_c4fb-76d3eca")]
        public void Method_100d_c4fb()
        {
            ii(0x100d_c4fb, 5);  push(0x50);                           /* push 0x50 */
            ii(0x100d_c500, 5);  call(Definitions.sys_check_available_stack_size, 0x8_984d);/* call 0x10165d52 */
            ii(0x100d_c505, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_c506, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_c507, 1);  push(edx);                            /* push edx */
            ii(0x100d_c508, 1);  push(esi);                            /* push esi */
            ii(0x100d_c509, 1);  push(edi);                            /* push edi */
            ii(0x100d_c50a, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_c50b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_c50d, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x100d_c513, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_c516, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c51a, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x100d_c51d, 9);  mov(memw[ds, eax + 0x101c_35c4], 0);  /* mov word [eax+0x101c35c4], 0x0 */
            ii(0x100d_c526, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c52a, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100d_c530, 9);  mov(memw[ds, eax + 0x101c_a583], 0);  /* mov word [eax+0x101ca583], 0x0 */
            ii(0x100d_c539, 5);  call(0x1009_cb74, -0x3_f9ca);         /* call 0x1009cb74 */
            ii(0x100d_c53e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c540, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_c542, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_c546, 3);  imul(edx, edx, 0x13);                 /* imul edx, edx, 0x13 */
            ii(0x100d_c549, 5);  mov(eax, 0x101c_35b4);                /* mov eax, 0x101c35b4 */
            ii(0x100d_c54e, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_c550, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c553, 5);  call(0x1009_cab0, -0x3_faa8);         /* call 0x1009cab0 */
            ii(0x100d_c558, 5);  call(0x100e_0a00, 0x44a3);            /* call 0x100e0a00 */
            ii(0x100d_c55d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c55f, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_c561, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_c565, 3);  imul(edx, edx, 0x13);                 /* imul edx, edx, 0x13 */
            ii(0x100d_c568, 5);  mov(eax, 0x101c_35b4);                /* mov eax, 0x101c35b4 */
            ii(0x100d_c56d, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_c56f, 3);  lea(edx, memd[ds, eax + 4]);          /* lea edx, [eax+0x4] */
            ii(0x100d_c572, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c575, 5);  call(0x100e_0970, 0x43f6);            /* call 0x100e0970 */
            ii(0x100d_c57a, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c57d, 5);  call(0x1009_caf8, -0x3_fa8a);         /* call 0x1009caf8 */
            ii(0x100d_c582, 7);  mov(memd[ss, ebp - 12], 0x31);        /* mov dword [ebp-0xc], 0x31 */
            ii(0x100d_c589, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x100d_c58c, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c58f, 5);  call(0x1008_b2a8, -0x5_12ec);         /* call 0x1008b2a8 */
            ii(0x100d_c594, 7);  mov(memd[ss, ebp - 32], 0x3d);        /* mov dword [ebp-0x20], 0x3d */
            ii(0x100d_c59b, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100d_c59e, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c5a1, 5);  call(0x1008_b2a8, -0x5_12fe);         /* call 0x1008b2a8 */
            ii(0x100d_c5a6, 7);  mov(memd[ss, ebp - 36], 0x39);        /* mov dword [ebp-0x24], 0x39 */
            ii(0x100d_c5ad, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x100d_c5b0, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c5b3, 5);  call(0x1008_b2a8, -0x5_1310);         /* call 0x1008b2a8 */
            ii(0x100d_c5b8, 5);  call(0x1009_cb74, -0x3_fa49);         /* call 0x1009cb74 */
            ii(0x100d_c5bd, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100d_c5bf, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100d_c5c1, 3);  lea(edx, memd[ss, ebp - 40]);         /* lea edx, [ebp-0x28] */
            ii(0x100d_c5c4, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x100d_c5c7, 5);  call(0x1009_cab0, -0x3_fb1c);         /* call 0x1009cab0 */
            ii(0x100d_c5cc, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_c5ce, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_c5d2, 5);  call(0x100d_c405, -0x1d2);            /* call 0x100dc405 */
            ii(0x100d_c5d7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c5d9, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x100d_c5dc, 5);  call(0x1008_8b04, -0x5_3add);         /* call 0x10088b04 */
            ii(0x100d_c5e1, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c5e4, 5);  call(Definitions.my_2_get_count, -0x5_1281);/* call 0x1008b368 */
            ii(0x100d_c5e9, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_c5ec, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c5ef, 5);  call(0x100c_aac8, -0x1_1b2c);         /* call 0x100caac8 */
            ii(0x100d_c5f4, 7);  mov(memd[ss, ebp - 8], 0x28);         /* mov dword [ebp-0x8], 0x28 */
            ii(0x100d_c5fb, 3);  lea(edx, memd[ss, ebp - 8]);          /* lea edx, [ebp-0x8] */
            ii(0x100d_c5fe, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c601, 5);  call(0x100c_aa44, -0x1_1bc2);         /* call 0x100caa44 */
            ii(0x100d_c606, 7);  mov(memd[ss, ebp - 28], 0x14);        /* mov dword [ebp-0x1c], 0x14 */
            ii(0x100d_c60d, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x100d_c610, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c613, 5);  call(0x100c_aa44, -0x1_1bd4);         /* call 0x100caa44 */
            ii(0x100d_c618, 7);  mov(memd[ss, ebp - 24], 2);           /* mov dword [ebp-0x18], 0x2 */
            ii(0x100d_c61f, 2);  jmp(0x100d_c627, 6); goto l_0x100d_c627;/* jmp 0x100dc627 */
        l_0x100d_c621:
            ii(0x100d_c621, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_c624, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x100d_c627:
            ii(0x100d_c627, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_c62a, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_c62e, 2);  if(jge(0x100d_c644, 0x14)) goto l_0x100d_c644;/* jge 0x100dc644 */
            ii(0x100d_c630, 7);  mov(memd[ss, ebp - 52], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x100d_c637, 3);  lea(edx, memd[ss, ebp - 52]);         /* lea edx, [ebp-0x34] */
            ii(0x100d_c63a, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c63d, 5);  call(0x100c_aa44, -0x1_1bfe);         /* call 0x100caa44 */
            ii(0x100d_c642, 2);  jmp(0x100d_c621, -0x23); goto l_0x100d_c621;/* jmp 0x100dc621 */
        l_0x100d_c644:
            ii(0x100d_c644, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_c647, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_c64a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c64c, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100d_c64f, 5);  call(0x100e_0244, 0x3bf0);            /* call 0x100e0244 */
            ii(0x100d_c654, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100d_c656, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100d_c659, 5);  call(0x1008_8b04, -0x5_3b5a);         /* call 0x10088b04 */
            ii(0x100d_c65e, 2);  jmp(0x100d_c674, 0x14); goto l_0x100d_c674;/* jmp 0x100dc674 */
        //  ii(0x100d_c660, 20);  Недостижимый код.
        l_0x100d_c674:
            ii(0x100d_c674, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_c677, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_c679, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_c67a, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_c67b, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_c67c, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_c67d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_c67e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_c67f, 1);  ret();                                /* ret */
        }
    }
}
