using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_be6c-e3bfc6e0")]
        public void Method_100a_be6c()
        {
            ii(0x100a_be6c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_be71, 5);  call(Definitions.sys_check_available_stack_size, 0xb_9edc);/* call 0x10165d52 */
            ii(0x100a_be76, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_be77, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_be78, 1);  push(esi);                            /* push esi */
            ii(0x100a_be79, 1);  push(edi);                            /* push edi */
            ii(0x100a_be7a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_be7b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_be7d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_be83, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_be86, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_be89, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_be8b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_be8e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_be91, 5);  call(0x1013_ad71, 0x8_eedb);          /* call 0x1013ad71 */
            ii(0x100a_be96, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_be98, 2);  if(jz(0x100a_bee3, 0x49)) goto l_0x100a_bee3;/* jz 0x100abee3 */
            ii(0x100a_be9a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_be9d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_bea0, 5);  call(0x100b_7f18, 0xc073);            /* call 0x100b7f18 */
            ii(0x100a_bea5, 5);  call(Definitions.my__get_unit, 0xc172);/* call 0x100b801c */
            ii(0x100a_beaa, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x100a_bead, 2);  if(jnz(0x100a_beb8, 9)) goto l_0x100a_beb8;/* jnz 0x100abeb8 */
            ii(0x100a_beaf, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_beb6, 2);  jmp(0x100a_bed1, 0x19); goto l_0x100a_bed1;/* jmp 0x100abed1 */
        l_0x100a_beb8:
            ii(0x100a_beb8, 5);  mov(ecx, 0x114);                      /* mov ecx, 0x114 */
            ii(0x100a_bebd, 5);  mov(ebx, StringDefinitions.AiMoveCpp2);/* mov ebx, 0x101a0dcf */
            ii(0x100a_bec2, 5);  mov(edx, StringDefinitions.PathRequestGetunitEqualUnit);/* mov edx, 0x101a0ddb */
            ii(0x100a_bec7, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100a_bec9, 5);  call(Definitions.sys_assert, 0xb_9ec4);/* call 0x10165d92 */
            ii(0x100a_bece, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x100a_bed1:
            ii(0x100a_bed1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_bed4, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_bed7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_beda, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_bedd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_bee0, 3);  call_abs(memd[ds, edx + 72]);         /* call dword [edx+0x48] */
        l_0x100a_bee3:
            ii(0x100a_bee3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_bee5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_bee6, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_bee7, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_bee8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_bee9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_beea, 1);  ret();                                /* ret */
        }
    }
}
