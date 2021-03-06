using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3240-3d6e6ff6")]
        public void Method_1010_3240()
        {
            ii(0x1010_3240, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_3245, 5);  call(Definitions.sys_check_available_stack_size, 0x6_2b08);/* call 0x10165d52 */
            ii(0x1010_324a, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_324b, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_324c, 1);  push(esi);                            /* push esi */
            ii(0x1010_324d, 1);  push(edi);                            /* push edi */
            ii(0x1010_324e, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_324f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_3251, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_3257, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_325a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_325d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3260, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_3263, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x1010_3266, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3269, 4);  mov(memw[ss, ebp - 12], ax);          /* mov [ebp-0xc], ax */
            ii(0x1010_326d, 5);  mov(ebx, 0x101b_63ec);                /* mov ebx, 0x101b63ec */
            ii(0x1010_3272, 3);  mov(edx, memd[ss, ebp - 14]);         /* mov edx, [ebp-0xe] */
            ii(0x1010_3275, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_3278, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x1010_327b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_327e, 3);  imul(eax, eax, 0xa);                  /* imul eax, eax, 0xa */
            ii(0x1010_3281, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1010_3284, 5);  call(Definitions.sys_new_arr, 0x6_2d87);/* call 0x10166010 */
            ii(0x1010_3289, 5);  call(Definitions.sys_call_ctor_arr, 0x6_eb71);/* call 0x10171dff */
            ii(0x1010_328e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_3290, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3293, 3);  mov(memd[ds, eax + 4], edx);          /* mov [eax+0x4], edx */
            ii(0x1010_3296, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3299, 6);  mov(memw[ds, eax + 2], 0);            /* mov word [eax+0x2], 0x0 */
        l_0x1010_329f:
            ii(0x1010_329f, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_32a3, 5);  cmp(eax, 0x80);                       /* cmp eax, 0x80 */
            ii(0x1010_32a8, 2);  if(jle(0x1010_32b7, 0xd)) goto l_0x1010_32b7;/* jle 0x101032b7 */
            ii(0x1010_32aa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_32ad, 4);  inc(memw[ds, eax + 2]);               /* inc word [eax+0x2] */
            ii(0x1010_32b1, 4);  sar(memw[ss, ebp - 4], 1);            /* sar word [ebp-0x4], 1 */
            ii(0x1010_32b5, 2);  jmp(0x1010_329f, -0x18); goto l_0x1010_329f;/* jmp 0x1010329f */
        l_0x1010_32b7:
            ii(0x1010_32b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_32ba, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_32bd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_32c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_32c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_32c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_32c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_32c5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_32c6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_32c7, 1);  ret();                                /* ret */
        }
    }
}
