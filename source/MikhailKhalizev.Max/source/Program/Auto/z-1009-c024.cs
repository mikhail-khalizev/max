using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c024-b374dc6c")]
        public void Method_1009_c024()
        {
            ii(0x1009_c024, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_c029, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9d24);/* call 0x10165d52 */
            ii(0x1009_c02e, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c02f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c030, 1);  push(esi);                            /* push esi */
            ii(0x1009_c031, 1);  push(edi);                            /* push edi */
            ii(0x1009_c032, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c033, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c035, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_c03b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c03e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c041, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_c048, 2);  if(jz(0x1009_c05e, 0x14)) goto l_0x1009_c05e;/* jz 0x1009c05e */
            ii(0x1009_c04a, 5);  mov(edx, 0x101b_415c);                /* mov edx, 0x101b415c */
            ii(0x1009_c04f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c052, 5);  call(Definitions.sys_call_dtor_arr, 0xc_9f61);/* call 0x10165fb8 */
            ii(0x1009_c057, 5);  call(Definitions.sys_delete_arr, 0xc_9f7c);/* call 0x10165fd8 */
            ii(0x1009_c05c, 2);  jmp(0x1009_c092, 0x34); goto l_0x1009_c092;/* jmp 0x1009c092 */
        l_0x1009_c05e:
            ii(0x1009_c05e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_c060, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c063, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_c066, 5);  call(Definitions.my_dtor_0x101b_56fc, -0x1_342f);/* call 0x10088c3c */
            ii(0x1009_c06b, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x1009_c06e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c071, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_c076, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c079, 5);  call(0x100a_284c, 0x67ce);            /* call 0x100a284c */
            ii(0x1009_c07e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c081, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_c088, 2);  if(jz(0x1009_c092, 8)) goto l_0x1009_c092;/* jz 0x1009c092 */
            ii(0x1009_c08a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c08d, 5);  call(Definitions.sys_delete, 0xc_9ed2);/* call 0x10165f64 */
        l_0x1009_c092:
            ii(0x1009_c092, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c095, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c098, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_c09b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c09d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c09e, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c09f, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c0a0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c0a1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c0a2, 1);  ret();                                /* ret */
        }
    }
}
