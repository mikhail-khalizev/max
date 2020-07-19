using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7b64-c3d83e76")]
        public void Method_1008_7b64()
        {
            ii(0x1008_7b64, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_7b69, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e1e4);/* call 0x10165d52 */
            ii(0x1008_7b6e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_7b6f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_7b70, 1);  push(esi);                            /* push esi */
            ii(0x1008_7b71, 1);  push(edi);                            /* push edi */
            ii(0x1008_7b72, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_7b73, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_7b75, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_7b7b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_7b7e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_7b81, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_7b83, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_7b86, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_7b89, 5);  call(0x1013_ad11, 0xb_3183);          /* call 0x1013ad11 */
            ii(0x1008_7b8e, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_7b90, 2);  if(jnz(0x1008_7ba9, 0x17)) goto l_0x1008_7ba9;/* jnz 0x10087ba9 */
            ii(0x1008_7b92, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_7b95, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1008_7b98, 5);  call(0x1007_6574, -0x1_1629);         /* call 0x10076574 */
            ii(0x1008_7b9d, 3);  mov(al, memb[ds, eax + 77]);          /* mov al, [eax+0x4d] */
            ii(0x1008_7ba0, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_7ba5, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1008_7ba7, 2);  if(jnz(0x1008_7bab, 2)) goto l_0x1008_7bab;/* jnz 0x10087bab */
        l_0x1008_7ba9:
            ii(0x1008_7ba9, 2);  jmp(0x1008_7bbd, 0x12); goto l_0x1008_7bbd;/* jmp 0x10087bbd */
        l_0x1008_7bab:
            ii(0x1008_7bab, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_7bae, 3);  add(edx, 0x17);                       /* add edx, 0x17 */
            ii(0x1008_7bb1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_7bb4, 5);  call(0x1008_b4b4, 0x38fb);            /* call 0x1008b4b4 */
            ii(0x1008_7bb9, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_7bbb, 2);  if(jz(0x1008_7bc3, 6)) goto l_0x1008_7bc3;/* jz 0x10087bc3 */
        l_0x1008_7bbd:
            ii(0x1008_7bbd, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1008_7bc1, 2);  jmp(0x1008_7bc7, 4); goto l_0x1008_7bc7;/* jmp 0x10087bc7 */
        l_0x1008_7bc3:
            ii(0x1008_7bc3, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1008_7bc7:
            ii(0x1008_7bc7, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1008_7bca, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1008_7bcd, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1008_7bd0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7bd2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7bd3, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7bd4, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7bd5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_7bd6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_7bd7, 1);  ret();                                /* ret */
        }
    }
}
