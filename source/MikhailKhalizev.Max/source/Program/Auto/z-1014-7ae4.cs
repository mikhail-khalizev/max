using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7ae4-b9e0a59e")]
        public void Method_1014_7ae4()
        {
            ii(0x1014_7ae4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_7ae9, 5);  call(Definitions.sys_check_available_stack_size, 0x1_e264);/* call 0x10165d52 */
            ii(0x1014_7aee, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7aef, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7af0, 1);  push(esi);                            /* push esi */
            ii(0x1014_7af1, 1);  push(edi);                            /* push edi */
            ii(0x1014_7af2, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7af3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7af5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_7afb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7afe, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7b01, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_7b08, 2);  if(jz(0x1014_7b1e, 0x14)) goto l_0x1014_7b1e;/* jz 0x10147b1e */
            ii(0x1014_7b0a, 5);  mov(edx, 0x101b_716c);                /* mov edx, 0x101b716c */
            ii(0x1014_7b0f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7b12, 5);  call(Definitions.sys_call_dtor_arr, 0x1_e4a1);/* call 0x10165fb8 */
            ii(0x1014_7b17, 5);  call(Definitions.sys_delete_arr, 0x1_e4bc);/* call 0x10165fd8 */
            ii(0x1014_7b1c, 2);  jmp(0x1014_7b52, 0x34); goto l_0x1014_7b52;/* jmp 0x10147b52 */
        l_0x1014_7b1e:
            ii(0x1014_7b1e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_7b20, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7b23, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x1014_7b26, 5);  call(0x100e_0158, -0x6_79d3);         /* call 0x100e0158 */
            ii(0x1014_7b2b, 3);  sub(eax, 0x14);                       /* sub eax, 0x14 */
            ii(0x1014_7b2e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7b31, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_7b36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7b39, 5);  call(0x1014_4fba, -0x2b84);           /* call 0x10144fba */
            ii(0x1014_7b3e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7b41, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_7b48, 2);  if(jz(0x1014_7b52, 8)) goto l_0x1014_7b52;/* jz 0x10147b52 */
            ii(0x1014_7b4a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7b4d, 5);  call(Definitions.sys_delete, 0x1_e412);/* call 0x10165f64 */
        l_0x1014_7b52:
            ii(0x1014_7b52, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7b55, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_7b58, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_7b5b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7b5d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7b5e, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7b5f, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7b60, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7b61, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7b62, 1);  ret();                                /* ret */
        }
    }
}
