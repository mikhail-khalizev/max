using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_bda4-50d4c2f1")]
        public void Method_1009_bda4()
        {
            ii(0x1009_bda4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_bda9, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9fa4);/* call 0x10165d52 */
            ii(0x1009_bdae, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_bdaf, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_bdb0, 1);  push(esi);                            /* push esi */
            ii(0x1009_bdb1, 1);  push(edi);                            /* push edi */
            ii(0x1009_bdb2, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_bdb3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_bdb5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_bdbb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bdbe, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_bdc1, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_bdc8, 2);  if(jz(0x1009_bdde, 0x14)) goto l_0x1009_bdde;/* jz 0x1009bdde */
            ii(0x1009_bdca, 5);  mov(edx, 0x101b_40f8);                /* mov edx, 0x101b40f8 */
            ii(0x1009_bdcf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bdd2, 5);  call(Definitions.sys_call_dtor_arr, 0xc_a1e1);/* call 0x10165fb8 */
            ii(0x1009_bdd7, 5);  call(Definitions.sys_delete_arr, 0xc_a1fc);/* call 0x10165fd8 */
            ii(0x1009_bddc, 2);  jmp(0x1009_be12, 0x34); goto l_0x1009_be12;/* jmp 0x1009be12 */
        l_0x1009_bdde:
            ii(0x1009_bdde, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_bde0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bde3, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_bde6, 5);  call(0x1009_bbf8, -0x1f3);            /* call 0x1009bbf8 */
            ii(0x1009_bdeb, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1009_bdee, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_bdf1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_bdf6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_bdf9, 5);  call(0x100a_284c, 0x6a4e);            /* call 0x100a284c */
            ii(0x1009_bdfe, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_be01, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_be08, 2);  if(jz(0x1009_be12, 8)) goto l_0x1009_be12;/* jz 0x1009be12 */
            ii(0x1009_be0a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be0d, 5);  call(Definitions.sys_delete, 0xc_a152);/* call 0x10165f64 */
        l_0x1009_be12:
            ii(0x1009_be12, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_be15, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_be18, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_be1b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_be1d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_be1e, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_be1f, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_be20, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_be21, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_be22, 1);  ret();                                /* ret */
        }
    }
}
