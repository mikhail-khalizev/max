using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ff68-3b5e0f32")]
        public void Method_1009_ff68()
        {
            ii(0x1009_ff68, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_ff6d, 5);  call(Definitions.sys_check_available_stack_size, 0xc_5de0);/* call 0x10165d52 */
            ii(0x1009_ff72, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_ff73, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_ff74, 1);  push(esi);                            /* push esi */
            ii(0x1009_ff75, 1);  push(edi);                            /* push edi */
            ii(0x1009_ff76, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_ff77, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_ff79, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_ff7f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ff82, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_ff85, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1009_ff8c, 2);  if(jz(0x1009_ffa2, 0x14)) goto l_0x1009_ffa2;/* jz 0x1009ffa2 */
            ii(0x1009_ff8e, 5);  mov(edx, 0x101b_48b0);                /* mov edx, 0x101b48b0 */
            ii(0x1009_ff93, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ff96, 5);  call(Definitions.sys_call_dtor_arr, 0xc_601d);/* call 0x10165fb8 */
            ii(0x1009_ff9b, 5);  call(Definitions.sys_delete_arr, 0xc_6038);/* call 0x10165fd8 */
            ii(0x1009_ffa0, 2);  jmp(0x1009_ffc3, 0x21); goto l_0x1009_ffc3;/* jmp 0x1009ffc3 */
        l_0x1009_ffa2:
            ii(0x1009_ffa2, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_ffa7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ffaa, 5);  call(0x1009_fdbc, -0x1f3);            /* call 0x1009fdbc */
            ii(0x1009_ffaf, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ffb2, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1009_ffb9, 2);  if(jz(0x1009_ffc3, 8)) goto l_0x1009_ffc3;/* jz 0x1009ffc3 */
            ii(0x1009_ffbb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ffbe, 5);  call(Definitions.sys_delete, 0xc_5fa1);/* call 0x10165f64 */
        l_0x1009_ffc3:
            ii(0x1009_ffc3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ffc6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_ffc9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_ffcc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_ffce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_ffcf, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_ffd0, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_ffd1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_ffd2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_ffd3, 1);  ret();                                /* ret */
        }
    }
}
