using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6f3f-a41dc94d")]
        public void Method_1010_6f3f()
        {
            ii(0x1010_6f3f, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_6f44, 5);  call(Definitions.sys_check_available_stack_size, 0x5_ee09);/* call 0x10165d52 */
            ii(0x1010_6f49, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_6f4a, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6f4b, 1);  push(edx);                            /* push edx */
            ii(0x1010_6f4c, 1);  push(esi);                            /* push esi */
            ii(0x1010_6f4d, 1);  push(edi);                            /* push edi */
            ii(0x1010_6f4e, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6f4f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6f51, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_6f57, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_6f5a, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_6f61, 2);  jmp(0x1010_6f69, 6); goto l_0x1010_6f69;/* jmp 0x10106f69 */
        l_0x1010_6f63:
            ii(0x1010_6f63, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_6f66, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1010_6f69:
            ii(0x1010_6f69, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_6f6d, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x1010_6f70, 2);  if(jge(0x1010_6f9b, 0x29)) goto l_0x1010_6f9b;/* jge 0x10106f9b */
            ii(0x1010_6f72, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x1010_6f77, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_6f7b, 3);  imul(edx, edx, 6);                    /* imul edx, edx, 0x6 */
            ii(0x1010_6f7e, 5);  mov(eax, 0x101c_4090);                /* mov eax, 0x101c4090 */
            ii(0x1010_6f83, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_6f85, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6f88, 5);  call(/* sys */ 0x1016_61c4, 0x5_f237);/* call 0x101661c4 */
            ii(0x1010_6f8d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_6f8f, 2);  if(jnz(0x1010_6f99, 8)) goto l_0x1010_6f99;/* jnz 0x10106f99 */
            ii(0x1010_6f91, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_6f94, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_6f97, 2);  jmp(0x1010_6fa2, 9); goto l_0x1010_6fa2;/* jmp 0x10106fa2 */
        l_0x1010_6f99:
            ii(0x1010_6f99, 2);  jmp(0x1010_6f63, -0x38); goto l_0x1010_6f63;/* jmp 0x10106f63 */
        l_0x1010_6f9b:
            ii(0x1010_6f9b, 7);  mov(memd[ss, ebp - 12], 0xffff_ffff); /* mov dword [ebp-0xc], 0xffffffff */
        l_0x1010_6fa2:
            ii(0x1010_6fa2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_6fa5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_6fa7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6fa8, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6fa9, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6faa, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_6fab, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6fac, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6fad, 1);  ret();                                /* ret */
        }
    }
}
