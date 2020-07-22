using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_2d1d-a4f2c9b5")]
        public void Method_100e_2d1d()
        {
            ii(0x100e_2d1d, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_2d22, 5);  call(Definitions.sys_check_available_stack_size, 0x8_302b);/* call 0x10165d52 */
            ii(0x100e_2d27, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_2d28, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_2d29, 1);  push(esi);                            /* push esi */
            ii(0x100e_2d2a, 1);  push(edi);                            /* push edi */
            ii(0x100e_2d2b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_2d2c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_2d2e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_2d34, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2d37, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_2d3a, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100e_2d41, 2);  if(jz(0x100e_2d57, 0x14)) goto l_0x100e_2d57;/* jz 0x100e2d57 */
            ii(0x100e_2d43, 5);  mov(edx, 0x101b_604c);                /* mov edx, 0x101b604c */
            ii(0x100e_2d48, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d4b, 5);  call(Definitions.sys_call_dtor_arr, 0x8_3268);/* call 0x10165fb8 */
            ii(0x100e_2d50, 5);  call(Definitions.sys_delete_arr, 0x8_3283);/* call 0x10165fd8 */
            ii(0x100e_2d55, 2);  jmp(0x100e_2db0, 0x59); goto l_0x100e_2db0;/* jmp 0x100e2db0 */
        l_0x100e_2d57:
            ii(0x100e_2d57, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d5a, 7);  mov(memd[ds, eax + 19], 0x101b_6060); /* mov dword [eax+0x13], 0x101b6060 */
            ii(0x100e_2d61, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d64, 5);  call(0x100e_3b27, 0xdbe);             /* call 0x100e3b27 */
            ii(0x100e_2d69, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2d6b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d6e, 3);  add(eax, 0x1c);                       /* add eax, 0x1c */
            ii(0x100e_2d71, 5);  call(Definitions.my_dtor_0x101b_56fc, -0x5_a13a);/* call 0x10088c3c */
            ii(0x100e_2d76, 3);  sub(eax, 0x1c);                       /* sub eax, 0x1c */
            ii(0x100e_2d79, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2d7c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_2d7e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d81, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x100e_2d84, 5);  call(0x1007_5f2c, -0x6_ce5d);         /* call 0x10075f2c */
            ii(0x100e_2d89, 3);  sub(eax, 0x18);                       /* sub eax, 0x18 */
            ii(0x100e_2d8c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2d8f, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_2d94, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2d97, 5);  call(0x100d_6999, -0xc403);           /* call 0x100d6999 */
            ii(0x100e_2d9c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2d9f, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100e_2da6, 2);  if(jz(0x100e_2db0, 8)) goto l_0x100e_2db0;/* jz 0x100e2db0 */
            ii(0x100e_2da8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2dab, 5);  call(Definitions.sys_delete, 0x8_31b4);/* call 0x10165f64 */
        l_0x100e_2db0:
            ii(0x100e_2db0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2db3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_2db6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_2db9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_2dbb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_2dbc, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_2dbd, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_2dbe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_2dbf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_2dc0, 1);  ret();                                /* ret */
        }
    }
}
