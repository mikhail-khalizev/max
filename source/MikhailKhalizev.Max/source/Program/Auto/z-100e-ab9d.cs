using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_ab9d-61303f23")]
        public void Method_100e_ab9d()
        {
            ii(0x100e_ab9d, 5);  push(0x40);                           /* push 0x40 */
            ii(0x100e_aba2, 5);  call(Definitions.sys_check_available_stack_size, 0x7_b1ab);/* call 0x10165d52 */
            ii(0x100e_aba7, 1);  push(esi);                            /* push esi */
            ii(0x100e_aba8, 1);  push(edi);                            /* push edi */
            ii(0x100e_aba9, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_abaa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_abac, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x100e_abb2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_abb5, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100e_abb8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_abbb, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100e_abbe, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_abc4, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_abc5, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_abc8, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100e_abcc, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100e_abd0, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_abd2, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_abd5, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100e_abd7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_abda, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_abde, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_abe0, 2);  if(jz(0x100e_abe8, 6)) goto l_0x100e_abe8;/* jz 0x100eabe8 */
            ii(0x100e_abe2, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100e_abe6, 2);  if(jnz(0x100e_abed, 5)) goto l_0x100e_abed;/* jnz 0x100eabed */
        l_0x100e_abe8:
            ii(0x100e_abe8, 5);  jmp(0x100e_aca6, 0xb9); goto l_0x100e_aca6;/* jmp 0x100eaca6 */
        l_0x100e_abed:
            ii(0x100e_abed, 3);  lea(ecx, memd[ss, ebp - 28]);         /* lea ecx, [ebp-0x1c] */
            ii(0x100e_abf0, 4);  movsx(ebx, memw[ss, ebp + 16]);       /* movsx ebx, word [ebp+0x10] */
            ii(0x100e_abf4, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_abf8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_abfb, 5);  call(0x100e_969d, -0x1563);           /* call 0x100e969d */
            ii(0x100e_ac00, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_ac03, 4);  cmp(memb[ss, ebp + 28], 0);           /* cmp byte [ebp+0x1c], 0x0 */
            ii(0x100e_ac07, 2);  if(jz(0x100e_ac2d, 0x24)) goto l_0x100e_ac2d;/* jz 0x100eac2d */
            ii(0x100e_ac09, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_ac0d, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_ac11, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100e_ac14, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100e_ac18, 1);  inc(edx);                             /* inc edx */
            ii(0x100e_ac19, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100e_ac1b, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_ac1d, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_ac20, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_ac22, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_ac24, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_ac28, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_ac2a, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
        l_0x100e_ac2d:
            ii(0x100e_ac2d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ac30, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_ac33, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_ac3a, 2);  jmp(0x100e_ac42, 6); goto l_0x100e_ac42;/* jmp 0x100eac42 */
        l_0x100e_ac3c:
            ii(0x100e_ac3c, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ac3f, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x100e_ac42:
            ii(0x100e_ac42, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ac45, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x100e_ac49, 2);  if(jge(0x100e_ac8e, 0x43)) goto l_0x100e_ac8e;/* jge 0x100eac8e */
            ii(0x100e_ac4b, 3);  mov(edx, memd[ss, ebp + 32]);         /* mov edx, [ebp+0x20] */
            ii(0x100e_ac4e, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_ac51, 5);  call(0x100d_4d78, -0x1_5ede);         /* call 0x100d4d78 */
            ii(0x100e_ac56, 1);  push(eax);                            /* push eax */
            ii(0x100e_ac57, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_ac59, 3);  mov(al, memb[ss, ebp + 24]);          /* mov al, [ebp+0x18] */
            ii(0x100e_ac5c, 1);  push(eax);                            /* push eax */
            ii(0x100e_ac5d, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100e_ac61, 1);  push(eax);                            /* push eax */
            ii(0x100e_ac62, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_ac65, 4);  imul(eax, memd[ss, ebp - 20]);        /* imul eax, [ebp-0x14] */
            ii(0x100e_ac69, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100e_ac6c, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100e_ac6f, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_ac73, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_ac77, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_ac7a, 3);  add(eax, memd[ss, ebp - 32]);         /* add eax, [ebp-0x20] */
            ii(0x100e_ac7d, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_14ba);/* call 0x100897c8 */
            ii(0x100e_ac82, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_ac84, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_ac87, 5);  call(0x100e_a99a, -0x2f2);            /* call 0x100ea99a */
            ii(0x100e_ac8c, 2);  jmp(0x100e_ac3c, -0x52); goto l_0x100e_ac3c;/* jmp 0x100eac3c */
        l_0x100e_ac8e:
            ii(0x100e_ac8e, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100e_ac92, 2);  if(jz(0x100e_aca6, 0x12)) goto l_0x100e_aca6;/* jz 0x100eaca6 */
            ii(0x100e_ac94, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x100e_ac99, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_ac9c, 5);  call(Definitions.sys_call_dtor_arr, 0x7_b317);/* call 0x10165fb8 */
            ii(0x100e_aca1, 5);  call(Definitions.sys_delete_arr, 0x7_b332);/* call 0x10165fd8 */
        l_0x100e_aca6:
            ii(0x100e_aca6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_aca8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_aca9, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_acaa, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_acab, 3);  ret(0x14);                            /* ret 0x14 */
        }
    }
}
