using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0bfd-e33abe22")]
        public void Method_100d_0bfd()
        {
            ii(0x100d_0bfd, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_0c02, 5);  call(Definitions.sys_check_available_stack_size, 0x9_514b);/* call 0x10165d52 */
            ii(0x100d_0c07, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_0c08, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_0c09, 1);  push(esi);                            /* push esi */
            ii(0x100d_0c0a, 1);  push(edi);                            /* push edi */
            ii(0x100d_0c0b, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_0c0c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_0c0e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_0c14, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_0c17, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_0c1a, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_0c21, 2);  if(jz(0x100d_0c37, 0x14)) goto l_0x100d_0c37;/* jz 0x100d0c37 */
            ii(0x100d_0c23, 5);  mov(edx, 0x101b_5c24);                /* mov edx, 0x101b5c24 */
            ii(0x100d_0c28, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c2b, 5);  call(Definitions.sys_call_dtor_arr, 0x9_5388);/* call 0x10165fb8 */
            ii(0x100d_0c30, 5);  call(Definitions.sys_delete_arr, 0x9_53a3);/* call 0x10165fd8 */
            ii(0x100d_0c35, 2);  jmp(0x100d_0c6d, 0x36); goto l_0x100d_0c6d;/* jmp 0x100d0c6d */
        l_0x100d_0c37:
            ii(0x100d_0c37, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c3a, 7);  mov(memd[ds, eax + 64], 0x101b_5ca4); /* mov dword [eax+0x40], 0x101b5ca4 */
            ii(0x100d_0c41, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c44, 3);  mov(eax, memd[ds, eax + 68]);         /* mov eax, [eax+0x44] */
            ii(0x100d_0c47, 5);  call(Definitions.sys_free, 0x9_a475); /* call 0x1016b0c1 */
            ii(0x100d_0c4c, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100d_0c51, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c54, 5);  call(0x100d_00b2, -0xba7);            /* call 0x100d00b2 */
            ii(0x100d_0c59, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_0c5c, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_0c63, 2);  if(jz(0x100d_0c6d, 8)) goto l_0x100d_0c6d;/* jz 0x100d0c6d */
            ii(0x100d_0c65, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c68, 5);  call(Definitions.sys_delete, 0x9_52f7);/* call 0x10165f64 */
        l_0x100d_0c6d:
            ii(0x100d_0c6d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0c70, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_0c73, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_0c76, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_0c78, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_0c79, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_0c7a, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_0c7b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_0c7c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_0c7d, 1);  ret();                                /* ret */
        }
    }
}
