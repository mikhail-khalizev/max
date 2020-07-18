using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7724-67df149c")]
        public void Method_100b_7724()
        {
            ii(0x100b_7724, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_7729, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e624);/* call 0x10165d52 */
            ii(0x100b_772e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_772f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7730, 1);  push(esi);                            /* push esi */
            ii(0x100b_7731, 1);  push(edi);                            /* push edi */
            ii(0x100b_7732, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7733, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7735, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_773b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_773e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7741, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_7748, 2);  if(jz(0x100b_775e, 0x14)) goto l_0x100b_775e;/* jz 0x100b775e */
            ii(0x100b_774a, 5);  mov(edx, 0x101b_50d0);                /* mov edx, 0x101b50d0 */
            ii(0x100b_774f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7752, 5);  call(Definitions.sys_call_dtor_arr, 0xa_e861);/* call 0x10165fb8 */
            ii(0x100b_7757, 5);  call(Definitions.sys_delete_arr, 0xa_e87c);/* call 0x10165fd8 */
            ii(0x100b_775c, 2);  jmp(0x100b_7792, 0x34); goto l_0x100b_7792;/* jmp 0x100b7792 */
        l_0x100b_775e:
            ii(0x100b_775e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_7760, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7763, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_7766, 5);  call(0x1007_5f2c, -0x4_183f);         /* call 0x10075f2c */
            ii(0x100b_776b, 3);  sub(eax, 0x13);                       /* sub eax, 0x13 */
            ii(0x100b_776e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7771, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100b_7776, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7779, 5);  call(0x100a_284c, -0x1_4f32);         /* call 0x100a284c */
            ii(0x100b_777e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7781, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_7788, 2);  if(jz(0x100b_7792, 8)) goto l_0x100b_7792;/* jz 0x100b7792 */
            ii(0x100b_778a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_778d, 5);  call(Definitions.sys_delete, 0xa_e7d2);/* call 0x10165f64 */
        l_0x100b_7792:
            ii(0x100b_7792, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7795, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_7798, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_779b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_779d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_779e, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_779f, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_77a0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_77a1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_77a2, 1);  ret();                                /* ret */
        }
    }
}
