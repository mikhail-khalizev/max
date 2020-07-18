using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_4fba-17016f21")]
        public void Method_1014_4fba()
        {
            ii(0x1014_4fba, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_4fbf, 5);  call(Definitions.sys_check_available_stack_size, 0x2_0d8e);/* call 0x10165d52 */
            ii(0x1014_4fc4, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_4fc5, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_4fc6, 1);  push(esi);                            /* push esi */
            ii(0x1014_4fc7, 1);  push(edi);                            /* push edi */
            ii(0x1014_4fc8, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_4fc9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_4fcb, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_4fd1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_4fd4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_4fd7, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1014_4fde, 2);  if(jz(0x1014_4ff4, 0x14)) goto l_0x1014_4ff4;/* jz 0x10144ff4 */
            ii(0x1014_4fe0, 5);  mov(edx, 0x101b_71d0);                /* mov edx, 0x101b71d0 */
            ii(0x1014_4fe5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4fe8, 5);  call(Definitions.sys_call_dtor_arr, 0x2_0fcb);/* call 0x10165fb8 */
            ii(0x1014_4fed, 5);  call(Definitions.sys_delete_arr, 0x2_0fe6);/* call 0x10165fd8 */
            ii(0x1014_4ff2, 2);  jmp(0x1014_5045, 0x51); goto l_0x1014_5045;/* jmp 0x10145045 */
        l_0x1014_4ff4:
            ii(0x1014_4ff4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_4ff7, 7);  mov(memd[ds, eax + 2], 0x101b_727c);  /* mov dword [eax+0x2], 0x101b727c */
            ii(0x1014_4ffe, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5000, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5003, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1014_5006, 5);  call(0x1013_9d0c, -0xb2ff);           /* call 0x10139d0c */
            ii(0x1014_500b, 3);  sub(eax, 0xa);                        /* sub eax, 0xa */
            ii(0x1014_500e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5011, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5013, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5016, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1014_5019, 5);  call(Definitions.my_string_dtor, -0x34f4);/* call 0x10141b2a */
            ii(0x1014_501e, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1014_5021, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5024, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_5029, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_502c, 5);  call(0x1013_ab27, -0xa50a);           /* call 0x1013ab27 */
            ii(0x1014_5031, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5034, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1014_503b, 2);  if(jz(0x1014_5045, 8)) goto l_0x1014_5045;/* jz 0x10145045 */
            ii(0x1014_503d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5040, 5);  call(Definitions.sys_delete, 0x2_0f1f);/* call 0x10165f64 */
        l_0x1014_5045:
            ii(0x1014_5045, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5048, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_504b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_504e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5050, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5051, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5052, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5053, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_5054, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_5055, 1);  ret();                                /* ret */
        }
    }
}
