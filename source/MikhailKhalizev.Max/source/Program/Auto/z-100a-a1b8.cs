using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a1b8-d52c94ce")]
        public void Method_100a_a1b8()
        {
            ii(0x100a_a1b8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_a1bd, 5);  call(Definitions.sys_check_available_stack_size, 0xb_bb90);/* call 0x10165d52 */
            ii(0x100a_a1c2, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_a1c3, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_a1c4, 1);  push(esi);                            /* push esi */
            ii(0x100a_a1c5, 1);  push(edi);                            /* push edi */
            ii(0x100a_a1c6, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_a1c7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_a1c9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_a1cf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a1d2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_a1d5, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a1dc, 2);  if(jz(0x100a_a1f2, 0x14)) goto l_0x100a_a1f2;/* jz 0x100aa1f2 */
            ii(0x100a_a1de, 5);  mov(edx, 0x101b_4c54);                /* mov edx, 0x101b4c54 */
            ii(0x100a_a1e3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a1e6, 5);  call(Definitions.sys_call_dtor_arr, 0xb_bdcd);/* call 0x10165fb8 */
            ii(0x100a_a1eb, 5);  call(Definitions.sys_delete_arr, 0xb_bde8);/* call 0x10165fd8 */
            ii(0x100a_a1f0, 2);  jmp(0x100a_a226, 0x34); goto l_0x100a_a226;/* jmp 0x100aa226 */
        l_0x100a_a1f2:
            ii(0x100a_a1f2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a1f4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a1f7, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_a1fa, 5);  call(0x1007_5f2c, -0x3_42d3);         /* call 0x10075f2c */
            ii(0x100a_a1ff, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x100a_a202, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a205, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_a20a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a20d, 5);  call(0x100a_36c9, -0x6b49);           /* call 0x100a36c9 */
            ii(0x100a_a212, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a215, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a21c, 2);  if(jz(0x100a_a226, 8)) goto l_0x100a_a226;/* jz 0x100aa226 */
            ii(0x100a_a21e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a221, 5);  call(Definitions.sys_delete, 0xb_bd3e);/* call 0x10165f64 */
        l_0x100a_a226:
            ii(0x100a_a226, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a229, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_a22c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_a22f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_a231, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_a232, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_a233, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_a234, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_a235, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_a236, 1);  ret();                                /* ret */
        }
    }
}
